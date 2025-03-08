
using System;
using System.Numerics;

namespace XLua
{
    using LuaAPI = XLua.LuaDLL.Lua;
    
    public partial class ObjectTranslator
	{
        // T 用于模板匹配
        public bool Assignable<T>(IntPtr L, int index, T valueDefault)
		{
            return Assignable(L, index, typeof(T));
        }
        
        public bool Assignable(IntPtr L, int index, LightLuaTable t)
        {
            return LuaAPI.lua_istable(L, index);
        }
        
    }
}
