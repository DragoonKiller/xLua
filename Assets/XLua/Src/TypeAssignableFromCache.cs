
using System;
using System.Collections.Generic;
using Prota;

namespace XLua
{
    internal class TypeAssignableFromCache
    {
        public static readonly HashMapDict<Type, Type, bool> typeMap = new HashMapDict<Type, Type, bool>();
        // find out if a is assignable from b (a = b is valid)
        public static bool IsAssignableFrom(Type a, Type b)
        {
            if (a == b) return true;        // quick return.
            if (typeMap.TryGetElement(a, b, out bool value)) return value;
            bool result = a.IsAssignableFrom(b);
            typeMap.SetElement(a, b, result);
            return result;
        }
    }
}
