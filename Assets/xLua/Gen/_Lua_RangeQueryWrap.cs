#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using XLua;
using System.Collections.Generic;


namespace XLua.CSObjectWrap
{
    using Utils = XLua.Utils;
    public class _Lua_RangeQueryWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(_Lua_RangeQuery);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 6, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Query", _m_Query_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetSizeFromRangeNode", _m_GetSizeFromRangeNode_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "MergeLayer", _m_MergeLayer_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SubtractLayer", _m_SubtractLayer_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "IntersectLayer", _m_IntersectLayer_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "_Lua_RangeQuery does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Query_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    RangeLayer _layer;translator.Get(L, 2, out _layer);
                    float _range = (float)LuaAPI.lua_tonumber(L, 3);
                    RangeQueryMode _mode;translator.Get(L, 4, out _mode);
                    LightLuaFunction _callback;translator.Get(L, 5, out _callback);
                    
                    _Lua_RangeQuery.Query( _tableId, _layer, _range, _mode, _callback );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetSizeFromRangeNode_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    
                        var gen_ret = _Lua_RangeQuery.GetSizeFromRangeNode( _tableId );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MergeLayer_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    RangeLayer _a;translator.Get(L, 1, out _a);
                    RangeLayer _b;translator.Get(L, 2, out _b);
                    
                        var gen_ret = _Lua_RangeQuery.MergeLayer( _a, _b );
                        translator.PushRangeLayer(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SubtractLayer_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    RangeLayer _a;translator.Get(L, 1, out _a);
                    RangeLayer _b;translator.Get(L, 2, out _b);
                    
                        var gen_ret = _Lua_RangeQuery.SubtractLayer( _a, _b );
                        translator.PushRangeLayer(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IntersectLayer_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    RangeLayer _a;translator.Get(L, 1, out _a);
                    RangeLayer _b;translator.Get(L, 2, out _b);
                    
                        var gen_ret = _Lua_RangeQuery.IntersectLayer( _a, _b );
                        translator.PushRangeLayer(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
