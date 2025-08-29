using System.Collections.Generic;
using System;
using UnityEngine;
using XLua;
using System.Linq;
using System.Reflection;
using CSObjectWrapEditor;
using Prota;
using System.Collections;

public static class GenConfig
{
    [GenPath]
    public static string genPath = "Assets/3rd/XLua/Gen/";
    
    
    //lua中要使用到C#库的配置，比如C#标准库，或者Unity API，第三方库等。
    [LuaCallCSharp]
    public static List<Type> LuaCallCSharp = new List<Type>() {
                typeof(System.Object),
                typeof(System.ValueType),
                typeof(System.Enum),
                // typeof(Vector2),
                typeof(Vector3),
                typeof(Vector4),
                typeof(Quaternion),
                typeof(Color),
                typeof(Ray),
                typeof(Bounds),
                typeof(Ray2D),
                typeof(Rect),
                typeof(Mathf),
                typeof(KeyCode),
                typeof(UnityEngine.Input),
				typeof(Time),
            };

    [GCOptimize]
    static List<Type> GCOptimize
    {
        get
        {
            return new List<Type>() {
                // typeof(Vector2),
                typeof(Vector3),
                typeof(Vector4),
                typeof(Color),
                typeof(Quaternion),
                typeof(Ray),
                typeof(Ray2D),
                typeof(Bounds),
                // 这几个的属性是 private, 必须装箱
                // typeof(Vector2Int),
                // typeof(Vector3Int),
                // typeof(Rect),
            };
        }
    }
    
    // 这些属性会存放到 Lua 的 user data 中. 否则不装箱的话读不出属性来.
    
    [AdditionalProperties]
    static Dictionary<Type, List<string>> AdditionalProperties
    {
        get
        {
            return new Dictionary<Type, List<string>>()
            {
                { typeof(Ray), new List<string>() { "origin", "direction" } },
                { typeof(Ray2D), new List<string>() { "origin", "direction" } },
                { typeof(Bounds), new List<string>() { "center", "extents" } },
            };
        }
    }

    //C#静态调用Lua的配置(包括事件的原型)，仅可以配delegate，interface
    [CSharpCallLua]
    public static List<Type> CSharpCallLua = new List<Type>() {
        
    };

    //黑名单
    [BlackList]
    public static List<List<string>> BlackList = new List<List<string>>()  {
            new List<string>(){"UnityEngine.WWW", "movie"},
            new List<string>(){"LuaCSTimer+Timer", "LuaCSTimer+TimerQueue"},
            new List<string>(){ "UnityEngine.Input", "IsJoystickPreconfigured","System.String"},
        };
    
    public static List<Type> BlackGenericTypeList = new List<Type>()
    {
        typeof(Span<>),
        typeof(ReadOnlySpan<>),
        typeof(List<>),
        typeof(HashSet<>),
        typeof(Dictionary<,>),
        typeof(Queue<>),
        typeof(Stack<>),
        typeof(LinkedList<>),
        typeof(SortedSet<>),
        typeof(SortedList<,>),
        typeof(HashMapArray<,>),
        typeof(HashMapList<,>),
        typeof(HashMapSet<,>),
        typeof(ArrayList),
        typeof(ArrayLinkedList<>),
    };

    private static bool IsBlacklistedGenericType(Type type)
    {
        if (!type.IsGenericType) return false;
        return BlackGenericTypeList.Contains(type.GetGenericTypeDefinition());
    }

    [BlackList] public static Func<MemberInfo, bool> GenericTypeFilter = (memberInfo) =>
    {
        switch (memberInfo)
        {
            case PropertyInfo propertyInfo:
                // return IsBlacklistedGenericType(propertyInfo.PropertyType);
                return false;

            case ConstructorInfo constructorInfo:
                return constructorInfo.GetParameters().Any(p => IsBlacklistedGenericType(p.ParameterType));

            case MethodInfo methodInfo:
                return methodInfo.GetParameters().Any(p => IsBlacklistedGenericType(p.ParameterType));

            default:
                return false;
        }
    };
}
