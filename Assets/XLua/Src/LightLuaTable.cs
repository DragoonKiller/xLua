using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using XLua;

using LuaAPI = XLua.LuaDLL.Lua;

public struct LightLuaTable : IDisposable, IEquatable<LightLuaTable>
{
    // static Dictionary<string, int> debugList = new();
    // string createPlace;
    // void Record()
    // {
    //     if(debugList.ContainsKey(createPlace))
    //     {
    //         debugList[createPlace] += 1;
    //     }
    //     else
    //     {
    //         debugList[createPlace] = 1;
    //     }
    // }
    // void RemoveRecord()
    // {
    //     debugList[createPlace] -= 1;
    // }
    // 
    public LuaVM vm { get; private set; }
    public LuaEnv env => vm.env;
    public int reference { get; private set; }
    public UnityEngine.Object backref { get; private set; }
    
    public static LightLuaTable none => default;
    
    public bool valid => vm != null && vm.valid && reference != 0;
    
    IntPtr _addr;
    public IntPtr addr
    {
        get
        {
            if (_addr == default)
            {    
                using var _ = LuaUtils.CallNative(out var L);
                LuaAPI.lua_getref(L, reference);
                _addr = LuaAPI.lua_topointer(env.L, -1);
            }
            return _addr;
        }
    }
    
    LightLuaTable(LuaVM vm, int reference, UnityEngine.Object backref)
    {
        this.vm = vm;
        this.reference = reference;
        this.backref = backref;
        _addr = default;
        // createPlace = System.Environment.StackTrace.ToString();
        // Record();
    }
    
    LightLuaTable(LuaVM vm, int reference)
    {
        this.vm = vm;
        this.reference = reference;
        this.backref = null;
        _addr = default;
        // createPlace = System.Environment.StackTrace.ToString();
        // Record();
    }
    
    public static LightLuaTable FromRef(LuaVM vm, int reference)
    {
        // Debug.LogWarning("create r" + LuaExecutor.frameCount);
        return new LightLuaTable(vm, reference);
    }
    
    public static LightLuaTable New(LuaVM vm, UnityEngine.Object backref = null)
    {
        // Debug.LogWarning("create t" + LuaExecutor.frameCount);
        using var _ = LuaUtils.CallNative(out var L);
        // stack: <none>
		LuaAPI.lua_newtable(L);
		// stack: <none>, newTable
        var r = LuaAPI.luaL_ref(L);
		
        return new LightLuaTable(vm, r, backref);
    }
    
    public void Dispose()
    {
        if(!valid) return;
        LuaAPI.lua_unref(env.L, reference);
		this.reference = 0;
    }
    
    public void push() => LuaAPI.lua_getref(env.L, reference);
    
    public int Length
    {
        get
        {
            if(!valid) throw new LuaException("LightLuaTable is invalid");
            using var _ = LuaUtils.CallNative(out var L);
            push();                                 // stack: table
            var len = (int)LuaAPI.xlua_objlen(L, -1);         // stack: table
            return len;
        }
    }
    
    // ====================================================================================================
    // ====================================================================================================
    
    #region Set functions
    
    public void SetNil(string key)
    {
        if(!valid) throw new LuaException("LightLuaTable is invalid");
        using var _ = LuaUtils.CallNative(out var L);
        push();                                 // stack: table
        LuaAPI.lua_pushstring(L, key);          // stack: table, key
        LuaAPI.lua_pushnil(L);                  // stack: table, key, nil
        var success = LuaAPI.xlua_psettable(L, -3);           // stack: table
        if(!LuaUtils.CommonErrorHandler(success, backref)) return;
    }
    
    public void SetNil(int key)
    {
        if(!valid) throw new LuaException("LightLuaTable is invalid");
        using var _ = LuaUtils.CallNative(out var L);
        push();                                 // stack: table
        LuaAPI.xlua_pushinteger(L, key);          // stack: table, key
		var success = LuaAPI.xlua_psettable(L, -3);           // stack: table
        if(!LuaUtils.CommonErrorHandler(success, backref)) return;
    }
    
    public void SetNil(float key)
    {
        if(!valid) throw new LuaException("LightLuaTable is invalid");
        using var _ = LuaUtils.CallNative(out var L);
        push();                                 // stack: table
        LuaAPI.lua_pushnumber(L, key);          // stack: table, key
		var success = LuaAPI.xlua_psettable(L, -3);           // stack: table
        if(!LuaUtils.CommonErrorHandler(success, backref)) return;
    }
    
    public void SetNil(long key)
    {
        if(!valid) throw new LuaException("LightLuaTable is invalid");
        using var _ = LuaUtils.CallNative(out var L);
        push();                                 // stack: table
        LuaAPI.lua_pushint64(L, key);          // stack: table, key
		var success = LuaAPI.xlua_psettable(L, -3);           // stack: table
        if(!LuaUtils.CommonErrorHandler(success, backref)) return;
    }
    
    public void SetNil(bool key)
    {
        if(!valid) throw new LuaException("LightLuaTable is invalid");
        using var _ = LuaUtils.CallNative(out var L);
        push();                                 // stack: table
        LuaAPI.lua_pushboolean(L, key);          // stack: table, key
		var success = LuaAPI.xlua_psettable(L, -3);           // stack: table
        if(!LuaUtils.CommonErrorHandler(success, backref)) return;
    }
    
    
    public void Set(string key, int value)
    {
        if(!valid) throw new LuaException("LightLuaTable is invalid");
        using var _ = LuaUtils.CallNative(out var L);
        push();                                 // stack: table
        LuaAPI.lua_pushstring(L, key);          // stack: table, key
        LuaAPI.xlua_pushinteger(L, value);         // stack: table, key, value
        var success = LuaAPI.xlua_psettable(L, -3);           // stack: table
        if(!LuaUtils.CommonErrorHandler(success, backref)) return;
    }
    
    public void Set(string key, float value)
    {
        if(!valid) throw new LuaException("LightLuaTable is invalid");
        using var _ = LuaUtils.CallNative(out var L);
        push();                                 // stack: table
        LuaAPI.lua_pushstring(L, key);          // stack: table, key
        LuaAPI.lua_pushnumber(L, value);        // stack: table, key, value
        var success = LuaAPI.xlua_psettable(L, -3);           // stack: table
        if(!LuaUtils.CommonErrorHandler(success, backref)) return;
    }
    
    public void Set(string key, string value)
    {
        if(!valid) throw new LuaException("LightLuaTable is invalid");
        using var _ = LuaUtils.CallNative(out var L);
        push();                                 // stack: table
        LuaAPI.lua_pushstring(L, key);          // stack: table, key
        LuaAPI.lua_pushstring(L, value);        // stack: table, key, value
        var success = LuaAPI.xlua_psettable(L, -3);           // stack: table
        if(!LuaUtils.CommonErrorHandler(success, backref)) return;
    }
    
    public void Set(string key, bool value)
    {
        if(!valid) throw new LuaException("LightLuaTable is invalid");
        using var _ = LuaUtils.CallNative(out var L);
        push();                                 // stack: table
        LuaAPI.lua_pushstring(L, key);          // stack: table, key
        LuaAPI.lua_pushboolean(L, value);       // stack: table, key, value
        var success = LuaAPI.xlua_psettable(L, -3);           // stack: table
        if(!LuaUtils.CommonErrorHandler(success, backref)) return;
    }
    
    public void Set<T>(string key, T value)
    {
        if(!valid) throw new LuaException("LightLuaTable is invalid");
        using var _ = LuaUtils.CallNative(out var L);
        push();                                 // stack: table
        LuaAPI.lua_pushstring(L, key);          // stack: table, key
        env.translator.PushByType(L, value);     // stack: table, key, value
        var success = LuaAPI.xlua_psettable(L, -3);           // stack: table
        if(!LuaUtils.CommonErrorHandler(success, backref)) return;
    }
    
    public void Set(string key, IntPtr value)
    {
        if(!valid) throw new LuaException("LightLuaTable is invalid");
        using var _ = LuaUtils.CallNative(out var L);
        push();                                 // stack: table
        LuaAPI.lua_pushstring(L, key);          // stack: table, key
        LuaAPI.lua_pushlightuserdata(L, value);     // stack: table, key, value
        var success = LuaAPI.xlua_psettable(L, -3);           // stack: table
        if(!LuaUtils.CommonErrorHandler(success, backref)) return;
	}
	
    public void Set(string key, LightLuaTable t)
    {
        if(!valid) throw new LuaException("LightLuaTable is invalid");
        if(!t.valid) throw new LuaException("LightLuaTable is invalid");
        using var _ = LuaUtils.CallNative(out var L);
        push();                                 // stack: table
        LuaAPI.lua_pushstring(L, key);          // stack: table, key
        LuaAPI.lua_getref(L, t.reference);      // stack: table, key, table
        var success = LuaAPI.xlua_psettable(L, -3);           // stack: table
        if(!LuaUtils.CommonErrorHandler(success, backref)) return;
    }
    
    public void Set(string key, LuaTable t)
    {
        if(!valid) throw new LuaException("LightLuaTable is invalid");
        if(!t.valid) throw new LuaException("LightLuaTable is invalid");
        using var _ = LuaUtils.CallNative(out var L);
        push();                                 // stack: table
        LuaAPI.lua_pushstring(L, key);          // stack: table, key
        t.push(L);                              // stack: table, key, table
        var success = LuaAPI.xlua_psettable(L, -3);           // stack: table
        if(!LuaUtils.CommonErrorHandler(success, backref)) return;
    }
    
    public void Set(int key, int value)
    {
        if(!valid) throw new LuaException("LightLuaTable is invalid");
        using var _ = LuaUtils.CallNative(out var L);
        push();                                 // stack: table
        LuaAPI.xlua_pushinteger(L, key);           // stack: table, key
        LuaAPI.xlua_pushinteger(L, value);         // stack: table, key, value
        var success = LuaAPI.xlua_psettable(L, -3);           // stack: table
        if(!LuaUtils.CommonErrorHandler(success, backref)) return;
    }
    
    public void Set(int key, float value)
    {
        if(!valid) throw new LuaException("LightLuaTable is invalid");
        using var _ = LuaUtils.CallNative(out var L);
        push();                                 // stack: table
        LuaAPI.xlua_pushinteger(L, key);           // stack: table, key
        LuaAPI.lua_pushnumber(L, value);        // stack: table, key, value
        var success = LuaAPI.xlua_psettable(L, -3);           // stack: table
        if(!LuaUtils.CommonErrorHandler(success, backref)) return;
    }
    
    public void Set(int key, string value)
    {
        if(!valid) throw new LuaException("LightLuaTable is invalid");
        using var _ = LuaUtils.CallNative(out var L);
        push();                                 // stack: table
        LuaAPI.xlua_pushinteger(L, key);           // stack: table, key
        LuaAPI.lua_pushstring(L, value);        // stack: table, key, value
        var success = LuaAPI.xlua_psettable(L, -3);           // stack: table
        if(!LuaUtils.CommonErrorHandler(success, backref)) return;
    }
    
    public void Set(int key, bool value)
    {
        if(!valid) throw new LuaException("LightLuaTable is invalid");
        using var _ = LuaUtils.CallNative(out var L);
        push();                                 // stack: table
        LuaAPI.xlua_pushinteger(L, key);           // stack: table, key
        LuaAPI.lua_pushboolean(L, value);       // stack: table, key, value
        var success = LuaAPI.xlua_psettable(L, -3);           // stack: table
        if(!LuaUtils.CommonErrorHandler(success, backref)) return;
    }
    
    public void Set(int key, LightLuaTable t)
    {
        if(!valid) throw new LuaException("LightLuaTable is invalid");
        if(!t.valid) throw new LuaException("LightLuaTable is invalid");
        using var _ = LuaUtils.CallNative(out var L);
        push();                                 // stack: table
        LuaAPI.xlua_pushinteger(L, key);           // stack: table, key
        LuaAPI.lua_getref(L, t.reference);      // stack: table, key, table
        var success = LuaAPI.xlua_psettable(L, -3);           // stack: table
        if(!LuaUtils.CommonErrorHandler(success, backref)) return;
    }
    
    public void Set(int key, LuaTable t)
    {
        if(!valid) throw new LuaException("LightLuaTable is invalid");
        if(!t.valid) throw new LuaException("LightLuaTable is invalid");
        using var _ = LuaUtils.CallNative(out var L);
        push();                                 // stack: table
        LuaAPI.xlua_pushinteger(L, key);           // stack: table, key
        t.push(L);                              // stack: table, key, table
        var success = LuaAPI.xlua_psettable(L, -3);           // stack: table
        if(!LuaUtils.CommonErrorHandler(success, backref)) return;
		
	}
	
	public void Set(int key, Vector2 value)
	{
		if(!valid) throw new LuaException("LightLuaTable is invalid");
		using var _ = LuaUtils.CallNative(out var L);
		push();                                 // stack: table
		LuaAPI.xlua_pushinteger(L, key);           // stack: table, key
		env.translator.Push(L, value);     // stack: table, key, value
		var success = LuaAPI.xlua_psettable(L, -3);           // stack: table
        if(!LuaUtils.CommonErrorHandler(success, backref)) return;
	}
    
    
    public void Set<T>(int key, T value)
    {
        if(!valid) throw new LuaException("LightLuaTable is invalid");
        using var _ = LuaUtils.CallNative(out var L);
        push();                                 // stack: table
        LuaAPI.xlua_pushinteger(L, key);           // stack: table, key
        env.translator.PushByType(L, value);     // stack: table, key, value
        var success = LuaAPI.xlua_psettable(L, -3);           // stack: table
        if(!LuaUtils.CommonErrorHandler(success, backref)) return;
    }
    #endregion
    
    #region Get functions
    
    public bool Get<T>(string key, out T value)
    {
        if(!valid) throw new LuaException("LightLuaTable is invalid");
        value = default;
        using var _ = LuaUtils.CallNative(out var L);
        push();                                             // stack: table
        LuaAPI.lua_pushstring(L, key);                      // stack: table, key
        var success = LuaAPI.xlua_pgettable(L, -2);         // stack: table, value
        if(!LuaUtils.CommonErrorHandler(success, backref)) return false;
        env.translator.Get(L, -1, out value);
        return true;
    }
    
    public bool Get<T>(int key, out T value)
    {
        if(!valid) throw new LuaException("LightLuaTable is invalid");
        value = default;
        using var _ = LuaUtils.CallNative(out var L);
        push();                                             // stack: table
        LuaAPI.xlua_pushinteger(L, key);                       // stack: table, key
        var success = LuaAPI.xlua_pgettable(L, -2);         // stack: table, value
        if(!LuaUtils.CommonErrorHandler(success, backref)) return false;
        env.translator.Get(L, -1, out value);
        return true;
    }
    
    public bool Get(object key, out object value)
    {
        if(!valid) throw new LuaException("LightLuaTable is invalid");
        value = default;
        using var _ = LuaUtils.CallNative(out var L);
        push();                                             // stack: table
        env.translator.PushByType(L, key);                   // stack: table, key
        var success = LuaAPI.xlua_pgettable(L, -2);         // stack: table, value
        if(!LuaUtils.CommonErrorHandler(success, backref)) return false;
        value = env.translator.GetObject(L, -1);
        return true;
    }
    
    // this function should be followed by error handler.
    public int GetNative(string key)
    {
        if(!valid) throw new LuaException("LightLuaTable is invalid");
        var L = env.L;
        push();                                             // stack: table
        LuaAPI.lua_pushstring(L, key);                      // stack: table, key
        var success = LuaAPI.xlua_pgettable(L, -2);         // stack: table, value
        return success;
    }
    
    // this function should be followed by error handler.
    public int GetNative(float key)
    {
        if(!valid) throw new LuaException("LightLuaTable is invalid");
        var L = env.L;
        push();                                             // stack: table
        LuaAPI.lua_pushnumber(L, key);                      // stack: table, key
        var success = LuaAPI.xlua_pgettable(L, -2);         // stack: table, value
        return success;
    }
    
    // this function should be followed by error handler.
    public int GetNative(int key)
    {
        if(!valid) throw new LuaException("LightLuaTable is invalid");
        var L = env.L;
        push();                                             // stack: table
        LuaAPI.xlua_pushinteger(L, key);                       // stack: table, key
        var success = LuaAPI.xlua_pgettable(L, -2);         // stack: table, value
        return success;
    }
    
    // this function should be followed by error handler.
    public int GetNative(long key)
    {
        if(!valid) throw new LuaException("LightLuaTable is invalid");
        var L = env.L;
        push();                                             // stack: table
        LuaAPI.lua_pushint64(L, key);                       // stack: table, key
        var success = LuaAPI.xlua_pgettable(L, -2);         // stack: table, value
        return success;
    }
    
    #endregion
    
    #region utils functions
    
    public LuaTable ToLuaTable()
    {
        using var _ = LuaUtils.CallNative(out var L);
        LuaAPI.lua_getref(L, reference);
        var res = env.translator.GetObject(L, -1) as LuaTable;
        return res;
    }
    
    public void SetMetaTable(LuaTable t)
    {
        if(!valid) throw new LuaException("table t in setmetatable(t, meta) is invalid");
        if(!t.valid) throw new LuaException("table meta in setmetatable(t, meta) is invalid");
        using var _ = LuaUtils.CallNative(out var L);
        push();                                 // stack: table
        t.push(L);                              // stack: table, table
        LuaAPI.lua_setmetatable(L, -2);          // stack: table
    }
    
    public void ClearTable()
    {
        if(!valid) throw new LuaException("LightLuaTable is invalid");
        using var _ = LuaUtils.CallNative(out var L);
        vm.cache.ClearTable.push(L);                       // stack: func
        push();                                         // stack: func, table
        var success = LuaAPI.lua_pcall(L, 1, 0, 0);     // stack: func
        if(!LuaUtils.CommonErrorHandler(success, backref)) return;
    }
    
    public IEnumerable<object> GetKeys()
    {
        using var _ = LuaUtils.CallNative(out var L);
        var translator = env.translator;
        LuaAPI.lua_getref(L, reference);
        LuaAPI.lua_pushnil(L);
        while (LuaAPI.lua_next(L, -2) != 0)
        {
            yield return translator.GetObject(L, -2);
            LuaAPI.lua_pop(L, 1);
        }
    }
    
    public IEnumerable<string> GetStringKeys()
    {
        using var _ = LuaUtils.CallNative(out var L);
        var translator = env.translator;
        LuaAPI.lua_getref(L, reference);
        LuaAPI.lua_pushnil(L);
        while (LuaAPI.lua_next(L, -2) != 0)
        {
            if(LuaAPI.lua_type(L, -2) == XLua.LuaTypes.LUA_TSTRING)
            {
                var str = LuaAPI.lua_tostring(L, -2);
                yield return str;
            }
            LuaAPI.lua_pop(L, 1);
        }
    }
    
    public IEnumerable<int> GetIntKeys()
    {
        using var _ = LuaUtils.CallNative(out var L);
        var translator = env.translator;
        LuaAPI.lua_getref(L, reference);
        LuaAPI.lua_pushnil(L);
        while (LuaAPI.lua_next(L, -2) != 0)
        {
            if(LuaAPI.lua_type(L, -2) == XLua.LuaTypes.LUA_TNUMBER)
            {
                yield return (int)LuaAPI.lua_toint64(L, -2);
            }
            LuaAPI.lua_pop(L, 1);
        }
    }
    
    public IEnumerable<long> GetInt64Keys()
    {
        using var _ = LuaUtils.CallNative(out var L);
        var translator = env.translator;
        LuaAPI.lua_getref(L, reference);
        LuaAPI.lua_pushnil(L);
        while (LuaAPI.lua_next(L, -2) != 0)
        {
            if(LuaAPI.lua_type(L, -2) == XLua.LuaTypes.LUA_TNUMBER)
            {
                yield return LuaAPI.lua_toint64(L, -2);
            }
            LuaAPI.lua_pop(L, 1);
        }
    }
    
    public IEnumerable<float> GetFloatKeys()
    {
        using var _ = LuaUtils.CallNative(out var L);
        var translator = env.translator;
        LuaAPI.lua_getref(L, reference);
        LuaAPI.lua_pushnil(L);
        while (LuaAPI.lua_next(L, -2) != 0)
        {
            if(LuaAPI.lua_type(L, -2) == XLua.LuaTypes.LUA_TNUMBER)
            {
                yield return (float)LuaAPI.lua_tonumber(L, -2);
            }
            LuaAPI.lua_pop(L, 1);
        }
    }

    #endregion
    
    
    #region IEquatable
    
    public bool Equals(LightLuaTable other)
        => this.reference == other.reference && this.vm == other.vm;
    
    public override bool Equals(object obj)
        => obj is LightLuaTable t && Equals(t);
    
    public override int GetHashCode()
        => reference.GetHashCode() ^ env.GetHashCode();
    
    public static bool operator ==(LightLuaTable a, LightLuaTable b)
        => a.Equals(b);
    
    public static bool operator !=(LightLuaTable a, LightLuaTable b)
        => !a.Equals(b);
    
    #endregion
    
}
