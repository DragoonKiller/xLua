using System.Collections.Generic;
using System;
using UnityEngine;
using XLua;
using System.Linq;
using System.Reflection;
using CSObjectWrapEditor;

public static class GenConfig
{
    [GenPath]
    public static string genPath = "Assets/3rd/XLua/Gen/";
    
    
    //lua中要使用到C#库的配置，比如C#标准库，或者Unity API，第三方库等。
    [LuaCallCSharp]
    public static List<Type> LuaCallCSharp = new List<Type>() {
                typeof(System.Object),
                typeof(Vector2),
                typeof(Vector3),
                typeof(Vector4),
                typeof(Vector2Int),
                typeof(Vector3Int),
                typeof(Quaternion),
                typeof(Color),
                typeof(Ray),
                typeof(Bounds),
                typeof(Ray2D),
                typeof(Rect),
                typeof(Mathf),
                typeof(KeyCode),
                typeof(UnityEngine.Input),
                typeof(LuaCSNode),
                typeof(LuaCSUtils),
                typeof(LuaCSMath),
                typeof(LuaCSCallback),
                typeof(LuaCSData),
                typeof(LuaVM),
                typeof(_Lua_Localization),
                typeof(LuaCSTimer),
                typeof(_Lua_DenfenceGrid),
                typeof(_Lua_PathProvider),
                typeof(_Lua_FireControl),
                typeof(_Lua_Physics),
                typeof(_Lua_Movement),
                typeof(_Lua_StringCache),
            };

    //C#静态调用Lua的配置（包括事件的原型），仅可以配delegate，interface
    [CSharpCallLua]
    public static List<Type> CSharpCallLua = new List<Type>() {
        
    };

    //黑名单
    [BlackList]
    public static List<List<string>> BlackList = new List<List<string>>()  {
            new List<string>(){"UnityEngine.WWW", "movie"},
            new List<string>(){"LuaCSTimer+Timer", "LuaCSTimer+TimerQueue"}
        };
    
    public static List<Type> BlackGenericTypeList = new List<Type>()
    {
        typeof(Span<>),
        typeof(ReadOnlySpan<>),
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
                return IsBlacklistedGenericType(propertyInfo.PropertyType);

            case ConstructorInfo constructorInfo:
                return constructorInfo.GetParameters().Any(p => IsBlacklistedGenericType(p.ParameterType));

            case MethodInfo methodInfo:
                return methodInfo.GetParameters().Any(p => IsBlacklistedGenericType(p.ParameterType));

            default:
                return false;
        }
    };
}
