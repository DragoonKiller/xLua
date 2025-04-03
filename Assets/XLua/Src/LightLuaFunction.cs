using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor.Rendering;
using UnityEngine;
using XLua;

using LuaAPI = XLua.LuaDLL.Lua;

public struct LightLuaFunction : IDisposable
{
    public LuaVM vm { get; private set; }
    public LuaEnv env => vm.env;
    public int reference { get; private set; }
    public UnityEngine.Object backref { get; private set; }
    
    public static LightLuaFunction none => default;
    
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
                _addr = LuaAPI.lua_topointer(vm.L, -1);
            }
            return _addr;
        }
    }
    
    LightLuaFunction(LuaVM vm, int reference, UnityEngine.Object backref)
    {
        this.vm = vm;
        this.reference = reference;
        this.backref = backref;
        _addr = default;
    }
    
    LightLuaFunction(LuaVM vm, int reference)
    {
        this.vm = vm;
        this.reference = reference;
        this.backref = null;
        _addr = default;
    }
    
    public static LightLuaFunction FromRef(LuaVM vm, int reference)
    {
        return new LightLuaFunction(vm, reference);
    }
    
    public static LightLuaFunction New(LuaVM vm, UnityEngine.Object backref = null)
    {
        var L = vm.L;
        using var _ = new LuaUtils.LuaStackTopGuard(vm.L);
        LuaAPI.lua_newtable(L);
        int udata = LuaAPI.xlua_tocsobj_safe(L, -1);
        Debug.Assert(udata == -1);
        LuaAPI.lua_pushvalue(L, -1);
        var r = LuaAPI.luaL_ref(L);
        return new LightLuaFunction(vm, r, backref);
    }
    
    public void Dispose()
    {
        vm.translator.ReleaseLuaBase(vm.L, reference, false);
        this.reference = 0;
    }
    
    public void push() => LuaAPI.lua_getref(vm.L, reference);
    
    // ====================================================================================================
    // ====================================================================================================
    
    public void Call()
    {
        if(!valid) throw new Exception("invalid lua function");
        using var _ = LuaUtils.CallNative(out var L);
        int errf = LuaAPI.load_error_func(L, vm.env.errorFuncRef);
        push();
        LuaAPI.lua_pcall(L, 0, 0, errf);
    }
    
    public void Call<T1>(T1 arg1)
    {
        if(!valid) throw new Exception("invalid lua function");
        using var _ = LuaUtils.CallNative(out var L);
        int errf = LuaAPI.load_error_func(L, vm.env.errorFuncRef);
        push();
        vm.translator.PushByType(L, arg1);
        LuaAPI.lua_pcall(L, 1, 0, errf);
    }
    
    public void Call<T1, T2>(T1 arg1, T2 arg2)
    {
        if(!valid) throw new Exception("invalid lua function");
        using var _ = LuaUtils.CallNative(out var L);
        int errf = LuaAPI.load_error_func(L, vm.env.errorFuncRef);
        push();
        vm.translator.PushByType(L, arg1);
        vm.translator.PushByType(L, arg2);
        LuaAPI.lua_pcall(L, 2, 0, errf);
    }
    
    public void Call<T1, T2, T3>(T1 arg1, T2 arg2, T3 arg3)
    {
        if(!valid) throw new Exception("invalid lua function");
        using var _ = LuaUtils.CallNative(out var L);
        int errf = LuaAPI.load_error_func(L, vm.env.errorFuncRef);
        push();
        vm.translator.PushByType(L, arg1);
        vm.translator.PushByType(L, arg2);
        vm.translator.PushByType(L, arg3);
        LuaAPI.lua_pcall(L, 3, 0, errf);
    }
    
    public TResult CallR<TResult>()
    {
        if(!valid) throw new Exception("invalid lua function");
        using var _ = LuaUtils.CallNative(out var L);
        int errf = LuaAPI.load_error_func(L, vm.env.errorFuncRef);
        push();
        LuaAPI.lua_pcall(L, 0, 1, errf);
        vm.translator.Get(L, -1, out TResult r);
        return r;
    }
    
    public TResult CallR<T1, TResult>(T1 arg1)
    {
        if(!valid) throw new Exception("invalid lua function");
        using var _ = LuaUtils.CallNative(out var L);
        int errf = LuaAPI.load_error_func(L, vm.env.errorFuncRef);
        push();
        vm.translator.PushByType(L, arg1);
        LuaAPI.lua_pcall(L, 1, 1, errf);
        vm.translator.Get(L, -1, out TResult r);
        return r;
    }
    
    public TResult CallR<T1, T2, TResult>(T1 arg1, T2 arg2)
    {
        if(!valid) throw new Exception("invalid lua function");
        using var _ = LuaUtils.CallNative(out var L);
        int errf = LuaAPI.load_error_func(L, vm.env.errorFuncRef);
        push();
        vm.translator.PushByType(L, arg1);
        vm.translator.PushByType(L, arg2);
        LuaAPI.lua_pcall(L, 2, 1, errf);
        vm.translator.Get(L, -1, out TResult r);
        return r;
    }
    
    public TResult CallR<T1, T2, T3, TResult>(T1 arg1, T2 arg2, T3 arg3)
    {
        if(!valid) throw new Exception("invalid lua function");
        using var _ = LuaUtils.CallNative(out var L);
        int errf = LuaAPI.load_error_func(L, vm.env.errorFuncRef);
        push();
        vm.translator.PushByType(L, arg1);
        vm.translator.PushByType(L, arg2);
        vm.translator.PushByType(L, arg3);
        LuaAPI.lua_pcall(L, 3, 1, errf);
        vm.translator.Get(L, -1, out TResult r);
        return r;
    }
    
    
    
    
}
