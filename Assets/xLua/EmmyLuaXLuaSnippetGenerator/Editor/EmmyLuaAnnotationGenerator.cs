using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using Prota;
using UnityEditor;
using UnityEngine;
using XLua;

namespace EmmyTypeGenerator
{
    public static class EmmyLuaAnnotationGenerator
    {
        /// <summary>
        /// 该文件只用来给ide进行lua类型提示的,不要在运行时require该文件或者打包到版本中.
        /// </summary>
        private static string TypeDefineFilePath
        {
            get { return Path.Combine(Application.dataPath, "../ProtaLua/GeneratedEmmyLua.lua"); }
        }

        private static HashSet<Type> luaNumberTypeSet = new HashSet<Type>
        {
            typeof(byte),
            typeof(sbyte),
            typeof(short),
            typeof(ushort),
            typeof(int),
            typeof(uint),
            typeof(long),
            typeof(ulong),
            typeof(float),
            typeof(double)
        };

        private static HashSet<Type> luaIntegerTypeSet = new HashSet<Type>
        {
            typeof(byte),
            typeof(sbyte),
            typeof(short),
            typeof(ushort),
            typeof(int),
            typeof(uint),
            typeof(long),
            typeof(ulong)
        };

        private static HashSet<Type> luaFloatTypeSet = new HashSet<Type>
        {
            typeof(float),
            typeof(double)
        };

        private static HashSet<string> luaKeywordSet = new HashSet<string>
        {
            "and",
            "break",
            "do",
            "else",
            "elseif",
            "end",
            "false",
            "for",
            "function",
            "if",
            "in",
            "local",
            "nil",
            "not",
            "or",
            "repeat",
            "return",
            "then",
            "true",
            "until",
            "while"
        };

        public static StringBuilder sb = new StringBuilder(1024);
        private static StringBuilder tempSb = new StringBuilder(1024);
        private static List<Type> exportTypeList = new List<Type>();

        private static Dictionary<Type, List<MethodInfo>>
            extensionMethodsDic = new Dictionary<Type, List<MethodInfo>>();

        [MenuItem("Lua/EmmyTypeGenerate")]
        public static void GenerateEmmyTypeFiles()
        {
            var set = CollectAllExportType();
            exportTypeList.AddRange(set);

            HandleExtensionMethods();

            GenerateTypeDefines();
            
            AssetDatabase.Refresh();
            Debug.Log("Generate lua snippet Complete!");
        }

        [MenuItem("Lua/TestGene")]
        public static void Test()
        {
            var v3Type = typeof(Vector3);
            var assembly = v3Type.Assembly;
            HashSet<Type> set = CollectAllExportType();
            var array = set.ToArray();
            var hasV3 = set.Contains(v3Type);
        }

        private static HashSet<Type> CollectAllExportType()
        {
            var set = GenConfig.LuaCallCSharp.ToHashSet();
            set.AddRange(TypeCache.GetTypesWithAttribute<LuaCallCSharpAttribute>());
            return set;
        }

        private static void HandleExtensionMethods()
        {
            for (var i = 0; i < exportTypeList.Count; i++)
            {
                Type type = exportTypeList[i];

                MethodInfo[] publicStaticMethodInfos =
                    type.GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly);
                for (var j = 0; j < publicStaticMethodInfos.Length; j++)
                {
                    MethodInfo methodInfo = publicStaticMethodInfos[j];
                    if (methodInfo.IsDefined(typeof(ExtensionAttribute), false))
                    {
                        Type extensionType = methodInfo.GetParameters()[0].ParameterType;
                        if (extensionMethodsDic.TryGetValue(extensionType, out List<MethodInfo> extensionMethodList))
                        {
                            extensionMethodList.Add(methodInfo);
                        }
                        else
                        {
                            List<MethodInfo> methodList = new List<MethodInfo> { methodInfo };
                            extensionMethodsDic.Add(extensionType, methodList);
                        }
                    }
                }
            }
        }

        private static void GenerateTypeDefines()
        {
            sb.Clear();
            sb.AppendLine("---@meta");
            sb.AppendLine("---@class NotExportType @表明该类型未导出");
            sb.AppendLine("");
            sb.AppendLine("---@class NotExportEnum @表明该枚举未导出");
            sb.AppendLine("");

            sb.AppendLine(string.Format("---@class {0}", "CS"));
            sb.AppendLine("CS = {}");
            
            // 收集所有需要的命名空间
            HashSet<string> namespaces = new HashSet<string>();
            for (int i = 0; i < exportTypeList.Count; i++)
            {
                Type typeInst = exportTypeList[i];
                string fullName = typeInst.FullName;
                if (!string.IsNullOrEmpty(fullName))
                {
                    int lastDotIndex = fullName.LastIndexOf('.');
                    if (lastDotIndex > 0)
                    {
                        string namespaceName = fullName.Substring(0, lastDotIndex);
                        namespaces.Add(namespaceName);
                    }
                }
            }
            
            // 生成命名空间表的注释
            foreach (string namespaceName in namespaces.OrderBy(n => n))
            {
                string luaNamespaceName = "CS." + namespaceName.Replace("+", ".");
                sb.AppendLine(string.Format("---@class {0}", luaNamespaceName));
                sb.AppendLine(string.Format("{0} = {{}}", luaNamespaceName));
                sb.AppendLine("");
            }
            
            for (int i = 0; i < exportTypeList.Count; i++)
            {
                Type typeInst = exportTypeList[i];

                keepStringTypeName = typeInst == typeof(string);

                WriteClassDefine(typeInst);
                if(typeInst.IsEnum || typeInst.FullName.StartsWith("UnityEngine."))
                    WriteClassFieldDefine(typeInst);     // no fields accessable for standard classes.
				// 为所有输出类型添加ToString()方法注解
				WriteToStringMethodDefine(typeInst);
                sb.AppendLine(string.Format("{0} = {{}}", typeInst.ToLuaTypeName().ReplaceDotOrPlusWithUnderscore()));

                WriteClassConstructorDefine(typeInst);
                WriteClassMethodDefine(typeInst);

                sb.AppendLine("");
            }
            
            // sb.Replace("CS.System.String", "string");
            sb.Replace("CS.XLua.LuaTable", "Node");
            sb.Replace("CS.LightLuaTable", "Node");
            sb.Replace("CS.LightLuaFunction", "function");
            sb.Replace("CS.XLua.LuaFunction", "function");
            sb.Replace("CS.UnityEngine.Vector2", "Vector2");
            // sb.Replace("CS.UnityEngine.Vector3", "Vector3");
            // sb.Replace("CS.UnityEngine.Vector4", "Vector4");
            // sb.Replace("CS.UnityEngine.Quaternion", "Quaternion");
            // sb.Replace("CS.UnityEngine.Color", "Color");
            // sb.Replace("CS.LuaLayerMask", "Layer");
            // sb.Replace("CS.Coord", "Coord");
            
            File.WriteAllText(TypeDefineFilePath, sb.ToString());
        }

        #region TypeDefineFileGenerator

        public static void WriteClassDefine(Type type)
        {
            if (type.BaseType != null && !type.IsEnum)
            {
                sb.AppendLine(string.Format("---@class {0} : {1}", type.ToLuaTypeName(),
                    type.BaseType.ToLuaTypeName()));
            }
            else
            {
                sb.AppendLine(string.Format("---@class {0}", type.ToLuaTypeName()));
            }
        }

        public static void WriteClassFieldDefine(Type type)
        {
            FieldInfo[] publicInstanceFieldInfos =
                type.GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
            FieldInfo[] publicStaticFieldInfos =
                type.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly);
            List<FieldInfo> fieldInfoList = new List<FieldInfo>();
            fieldInfoList.AddRange(publicStaticFieldInfos);
            if (!type.IsEnum)
            {
                fieldInfoList.AddRange(publicInstanceFieldInfos);
            }

            for (int i = 0; i < fieldInfoList.Count; i++)
            {
                FieldInfo fieldInfo = fieldInfoList[i];
                if (fieldInfo.IsMemberObsolete(type))
                {
                    continue;
                }

                Type fieldType = fieldInfo.FieldType;
                sb.AppendLine(string.Format("---@field {0} {1}", fieldInfo.Name, fieldType.ToLuaTypeName()));
            }

            PropertyInfo[] publicInstancePropertyInfo =
                type.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
            PropertyInfo[] publicStaticPropertyInfo =
                type.GetProperties(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly);
            List<PropertyInfo> propertyInfoList = new List<PropertyInfo>();
            propertyInfoList.AddRange(publicStaticPropertyInfo);
            if (!type.IsEnum)
            {
                propertyInfoList.AddRange(publicInstancePropertyInfo);
            }

            for (int i = 0; i < propertyInfoList.Count; i++)
            {
                PropertyInfo propertyInfo = propertyInfoList[i];
                if (propertyInfo.IsMemberObsolete(type))
                {
                    continue;
                }

                Type propertyType = propertyInfo.PropertyType;
                sb.AppendLine(string.Format("---@field {0} {1}", propertyInfo.Name, propertyType.ToLuaTypeName()));
            }
        }

        public static void WriteClassConstructorDefine(Type type)
        {
            if (type == typeof(MonoBehaviour) || type.IsSubclassOf(typeof(MonoBehaviour)))
            {
                return;
            }

            string className = type.ToLuaTypeName().ReplaceDotOrPlusWithUnderscore();
            ConstructorInfo[] constructorInfos = type.GetConstructors();
            if (constructorInfos.Length == 0)
            {
                return;
            }

            for (int i = 0; i < constructorInfos.Length - 1; i++)
            {
                ConstructorInfo ctorInfo = constructorInfos[i];
                if (ctorInfo.IsStatic || ctorInfo.IsGenericMethod)
                {
                    continue;
                }

                WriteOverloadMethodCommentDecalre(ctorInfo.GetParameters(), type);
            }

            ConstructorInfo lastCtorInfo = constructorInfos[constructorInfos.Length - 1];
            WriteMethodFunctionDeclare(lastCtorInfo.GetParameters(), type, "New", className, true);
        }

        public static void WriteClassMethodDefine(Type type)
        {
            // string classNameWithNameSpace = type.ToLuaTypeName().Replace(".", "_");
            string classNameWithNameSpace = type.ToLuaTypeName();

            Dictionary<string, List<MethodInfo>> methodGroup = new Dictionary<string, List<MethodInfo>>();
            MethodInfo[] publicInstanceMethodInfos =
                type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
            MethodInfo[] publicStaticMethodInfos =
                type.GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly);

            Action<MethodInfo> recordMethodGroup = methodInfo =>
            {
                string methodName = methodInfo.Name;

                if (methodInfo.IsGenericMethod)
                {
                    return;
                }

                if (methodName.StartsWith("get_") || methodName.StartsWith("set_") || methodName.StartsWith("op_"))
                {
                    return;
                }

                if (methodName.StartsWith("add_") || methodName.StartsWith("remove_"))
                {
                    return;
                }

                if (methodGroup.ContainsKey(methodName))
                {
                    List<MethodInfo> methodInfoList = methodGroup[methodName];
                    if (methodInfoList == null)
                    {
                        methodInfoList = new List<MethodInfo>();
                    }

                    methodInfoList.Add(methodInfo);
                    methodGroup[methodName] = methodInfoList;
                }
                else
                {
                    methodGroup.Add(methodName, new List<MethodInfo> { methodInfo });
                }
            };

            for (int i = 0; i < publicStaticMethodInfos.Length; i++)
            {
                MethodInfo methodInfo = publicStaticMethodInfos[i];
                if (methodInfo.IsMemberObsolete(type))
                {
                    continue;
                }

                recordMethodGroup(methodInfo);
            }

            for (int i = 0; i < publicInstanceMethodInfos.Length; i++)
            {
                MethodInfo methodInfo = publicInstanceMethodInfos[i];
                if (methodInfo.IsMemberObsolete(type))
                {
                    continue;
                }

                recordMethodGroup(methodInfo);
            }

            foreach (var oneGroup in methodGroup)
            {
                List<MethodInfo> methodInfoList = oneGroup.Value;
                //前面的方法都是overload
                for (int i = 0; i < methodInfoList.Count - 1; i++)
                {
                    WriteOverloadMethodCommentDecalre(methodInfoList[i].GetParameters(), methodInfoList[i].ReturnType);
                }

                MethodInfo lastMethodInfo = methodInfoList[methodInfoList.Count - 1];
                WriteMethodFunctionDeclare(lastMethodInfo.GetParameters(), lastMethodInfo.ReturnType,
                    lastMethodInfo.Name,
                    classNameWithNameSpace, lastMethodInfo.IsStatic);
            }
            WriteExtensionMethodFunctionDecalre(type);
        }

        public static void WriteOverloadMethodCommentDecalre(ParameterInfo[] parameterInfos, Type returnType)
        {
            List<ParameterInfo> outOrRefParameterInfoList = new List<ParameterInfo>();

            tempSb.Clear();
            for (int i = 0; i < parameterInfos.Length; i++)
            {
                ParameterInfo parameterInfo = parameterInfos[i];
                string parameterName = parameterInfo.Name;
                string parameterTypeName = parameterInfo.ParameterType.ToLuaTypeName();
                if (parameterInfo.IsOut)
                {
                    parameterName = "out_" + parameterName;
                    outOrRefParameterInfoList.Add(parameterInfo);

                    parameterTypeName = parameterInfo.ParameterType.GetElementType().ToLuaTypeName();
                }
                else if (parameterInfo.ParameterType.IsByRef)
                {
                    parameterName = "ref_" + parameterName;
                    outOrRefParameterInfoList.Add(parameterInfo);

                    parameterTypeName = parameterInfo.ParameterType.GetElementType().ToLuaTypeName();
                }

                parameterName = EscapeLuaKeyword(parameterName);
                if (i == parameterInfos.Length - 1)
                {
                    tempSb.Append(string.Format("{0} : {1}", parameterName, parameterTypeName));
                }
                else
                {
                    tempSb.Append(string.Format("{0} : {1}, ", parameterName, parameterTypeName));
                }
            }

            //return
            List<Type> returnTypeList = new List<Type>();
            if (returnType != null && returnType != typeof(void))
            {
                returnTypeList.Add(returnType);
            }

            for (int i = 0; i < outOrRefParameterInfoList.Count; i++)
            {
                returnTypeList.Add(outOrRefParameterInfoList[i].ParameterType.GetElementType());
            }

            string returnTypeString = "";
            for (int i = 0; i < returnTypeList.Count; i++)
            {
                if (i == returnTypeList.Count - 1)
                {
                    returnTypeString += returnTypeList[i].ToLuaTypeName();
                }
                else
                {
                    returnTypeString += returnTypeList[i].ToLuaTypeName() + ", ";
                }
            }

            if (returnTypeList.Count > 0)
            {
                sb.AppendLine(string.Format("---@overload fun({0}) : {1}", tempSb, returnTypeString));
            }
            else
            {
                sb.AppendLine(string.Format("---@overload fun({0})", tempSb));
            }
        }

        public static void WriteMethodFunctionDeclare(ParameterInfo[] parameterInfos, Type returnType,
            string methodName,
            string className, bool isStaticMethod)
        {
            List<ParameterInfo> outOrRefParameterInfoList = new List<ParameterInfo>();
            bool isFirst = true;

            tempSb.Clear();
            for (int i = 0; i < parameterInfos.Length; i++)
            {
                ParameterInfo parameterInfo = parameterInfos[i];
                if (parameterInfo.IsOut || parameterInfo.ParameterType.IsByRef)
                {
                    outOrRefParameterInfoList.Add(parameterInfo);
                    continue;
                }
                
                string parameterName = parameterInfo.Name;
                string parameterTypeName = parameterInfo.ParameterType.ToLuaTypeName();

                parameterName = EscapeLuaKeyword(parameterName);

                if (isFirst)
                {
                    isFirst = false;
                    tempSb.Append(parameterName);
                }
                else
                {
                    tempSb.Append(string.Format(", {0}", parameterName));
                }
                
                sb.AppendLine(string.Format("---@param {0} {1}", parameterName, parameterTypeName));
            }

            
            {
                // original return
                bool haveReturn = (returnType != null && returnType != typeof(void)) || outOrRefParameterInfoList.Count > 0;
                
                if (haveReturn)
                {
                    sb.Append("---@return ");
                }
                
                isFirst = true;
                if (returnType != null && returnType != typeof(void))
                {
                    isFirst = false;
                    sb.Append(returnType.ToLuaTypeName());
                }

                for (int i = 0; i < outOrRefParameterInfoList.Count; i++)
                {
                    sb.Append(string.Format(isFirst ? "{0}" : ",{0}",
                        outOrRefParameterInfoList[i].ParameterType.GetElementType().ToLuaTypeName()));
                    isFirst = false;
                }

                if (haveReturn)
                {
                    sb.AppendLine("");
                }
            }
            
            

            if (isStaticMethod)
            {
                sb.AppendLine(string.Format("function {0}.{1}({2}) end", className, methodName, tempSb));
            }
            else
            {
                sb.AppendLine(string.Format("function {0}:{1}({2}) end", className, methodName, tempSb));
            }
        }

        private static void WriteExtensionMethodFunctionDecalre(Type type)
        {
            if (extensionMethodsDic.TryGetValue(type, out List<MethodInfo> extensionMethodList))
            {
                for (var i = 0; i < extensionMethodList.Count; i++)
                {
                    MethodInfo methodInfo = extensionMethodList[i];
                    ParameterInfo[] parameterInfos = methodInfo.GetParameters();
                    if (parameterInfos.Length > 0)
                    {
                        //第一个param是拓展类型，去掉
                        parameterInfos = parameterInfos.ToList().GetRange(1, parameterInfos.Length - 1).ToArray();
                    }

                    Type returnType = methodInfo.ReturnType;
                    string methodName = methodInfo.Name;
                    string classNameWithNameSpace = type.ToLuaTypeName();

                    WriteMethodFunctionDeclare(parameterInfos, returnType, methodName, classNameWithNameSpace, false);
                }
            }
        }

        /// <summary>
        /// 为所有输出类型添加ToString()方法的注解
        /// </summary>
        /// <param name="type">类型</param>
        private static void WriteToStringMethodDefine(Type type)
        {
            // 检查类型是否已经有ToString方法
            bool hasToStringMethod = false;
            MethodInfo[] publicInstanceMethodInfos = type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
            
            foreach (var methodInfo in publicInstanceMethodInfos)
            {
                if (methodInfo.Name == "ToString" && methodInfo.GetParameters().Length == 0)
                {
                    hasToStringMethod = true;
                    break;
                }
            }
            
            // 如果类型没有ToString方法，则添加一个默认的ToString方法注解
            if (!hasToStringMethod)
            {
                sb.AppendLine("---@field ToString fun():string");
            }
        }

        #endregion

        private static bool TypeIsExport(Type type)
        {
            return exportTypeList.Contains(type) || type == typeof(string) ||
                               luaNumberTypeSet.Contains(type) || type == typeof(bool);
        }

        private static bool keepStringTypeName;

        public static string ToLuaTypeName(this Type type)
        {
            if (type == null)
            {
                return "NullType";
            }

            // if (!TypeIsExport(type))
            // {
            //     if (type.IsEnum)
            //     {
            //         return "NotExportEnum";
            //     }

            //     return "NotExportType";
            // }

            if (luaIntegerTypeSet.Contains(type))
            {
                return "integer";
            }

            if (luaFloatTypeSet.Contains(type))
            {
                return "number";
            }

            if (type == typeof(string))
            {
                return keepStringTypeName ? "System.String" : "string";
            }

            if (type == typeof(bool))
            {
                return "boolean";
            }

            string typeName = type.FullName;
            if (typeName == null)
            {
                return "CS." + type.ToString().EscapeGenericTypeSuffix();
            }

            if (type.IsEnum)
            {
                return "CS." + type.FullName.EscapeGenericTypeSuffix().Replace("+", ".");
            }

            //去除泛型后缀
            typeName = typeName.EscapeGenericTypeSuffix();

            int bracketIndex = typeName.IndexOf("[[");
            if (bracketIndex > 0)
            {
                typeName = typeName.Substring(0, bracketIndex);
                Type[] genericTypes = type.GetGenericArguments();
                for (int i = 0; i < genericTypes.Length; i++)
                {
                    Type genericArgumentType = genericTypes[i];
                    string genericArgumentTypeName;
                    if (CSharpTypeNameDic.ContainsKey(genericArgumentType))
                    {
                        genericArgumentTypeName = CSharpTypeNameDic[genericArgumentType];
                    }
                    else
                    {
                        genericArgumentTypeName = genericArgumentType.ToLuaTypeName();
                    }

                    typeName = typeName + "_" + genericArgumentTypeName.ReplaceDotOrPlusWithUnderscore();
                }
            }

            return "CS." + typeName;
        }

        private static Dictionary<Type, string> CSharpTypeNameDic = new Dictionary<Type, string>
        {
            {typeof(byte), "byte"},
            {typeof(sbyte), "sbyte"},
            {typeof(short), "short"},
            {typeof(ushort), "ushort"},
            {typeof(int), "int"},
            {typeof(uint), "uint"},
            {typeof(long), "long"},
            {typeof(ulong), "ulong"},
            {typeof(float), "float"},
            {typeof(double), "double"},
            {typeof(bool), "bool"},
            {typeof(string), "string"},
        };


        public static string EscapeLuaKeyword(string s)
        {
            if (luaKeywordSet.Contains(s))
            {
                return "_" + s;
            }

            return s;
        }

        public static string ReplaceDotOrPlusWithUnderscore(this string s)
        {
            // return s.Replace(".", "_").Replace("+", "_");
            return s.Replace("+", "_");
        }

        public static string EscapeGenericTypeSuffix(this string s)
        {
            var reg = "[^a-zA-Z0-9\\._+]";
            string result = Regex.Replace(s, reg, "").Replace("+", ".");
            return result;
        }

        public static bool IsMemberObsolete(this MemberInfo memberInfo, Type type)
        {
            return memberInfo.GetCustomAttributes(typeof(ObsoleteAttribute), false).Length > 0 ||
                   IsMemberFilter(memberInfo, type);
        }

        public static bool IsMemberFilter(MemberInfo mi, Type type)
        {
            if (type.IsGenericType)
            {
            }
            return false;
        }
    }
}
