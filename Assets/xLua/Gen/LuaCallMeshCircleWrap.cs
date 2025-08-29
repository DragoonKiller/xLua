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
    public class LuaCallMeshCircleWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(LuaCallMeshCircle);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 16, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "GetCircleRadius", _m_GetCircleRadius_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetCircleWidth", _m_GetCircleWidth_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetCircleSegments", _m_GetCircleSegments_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetCirclePercent", _m_GetCirclePercent_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetCirclePercent", _m_SetCirclePercent_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetCircleSubDivide", _m_GetCircleSubDivide_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetCircleRadius", _m_SetCircleRadius_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetCircleSegments", _m_SetCircleSegments_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetCircleWidth", _m_SetCircleWidth_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetCircleSubDivide", _m_SetCircleSubDivide_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetCircleUVRepeat", _m_GetCircleUVRepeat_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetCircleUVRepeat", _m_SetCircleUVRepeat_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ForceUpdate", _m_ForceUpdate_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetCircleEstimatedVertexCount", _m_GetCircleEstimatedVertexCount_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetCircleWillExceedVertexLimit", _m_GetCircleWillExceedVertexLimit_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "LuaCallMeshCircle does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetCircleRadius_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _id;translator.Get(L, 1, out _id);
                    
                        var gen_ret = LuaCallMeshCircle.GetCircleRadius( _id );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetCircleWidth_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _id;translator.Get(L, 1, out _id);
                    
                        var gen_ret = LuaCallMeshCircle.GetCircleWidth( _id );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetCircleSegments_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _id;translator.Get(L, 1, out _id);
                    
                        var gen_ret = LuaCallMeshCircle.GetCircleSegments( _id );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetCirclePercent_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _id;translator.Get(L, 1, out _id);
                    
                        var gen_ret = LuaCallMeshCircle.GetCirclePercent( _id );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetCirclePercent_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _id;translator.Get(L, 1, out _id);
                    float _percent = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    LuaCallMeshCircle.SetCirclePercent( _id, _percent );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetCircleSubDivide_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _id;translator.Get(L, 1, out _id);
                    
                        var gen_ret = LuaCallMeshCircle.GetCircleSubDivide( _id );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetCircleRadius_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _id;translator.Get(L, 1, out _id);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    LuaCallMeshCircle.SetCircleRadius( _id, _radius );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetCircleSegments_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _id;translator.Get(L, 1, out _id);
                    int _segments = LuaAPI.xlua_tointeger(L, 2);
                    
                    LuaCallMeshCircle.SetCircleSegments( _id, _segments );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetCircleWidth_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _id;translator.Get(L, 1, out _id);
                    float _width = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    LuaCallMeshCircle.SetCircleWidth( _id, _width );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetCircleSubDivide_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _id;translator.Get(L, 1, out _id);
                    int _subDivide = LuaAPI.xlua_tointeger(L, 2);
                    
                    LuaCallMeshCircle.SetCircleSubDivide( _id, _subDivide );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetCircleUVRepeat_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _id;translator.Get(L, 1, out _id);
                    
                        var gen_ret = LuaCallMeshCircle.GetCircleUVRepeat( _id );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetCircleUVRepeat_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _id;translator.Get(L, 1, out _id);
                    float _uvRepeat = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    LuaCallMeshCircle.SetCircleUVRepeat( _id, _uvRepeat );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ForceUpdate_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _id;translator.Get(L, 1, out _id);
                    
                    LuaCallMeshCircle.ForceUpdate( _id );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetCircleEstimatedVertexCount_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _id;translator.Get(L, 1, out _id);
                    
                        var gen_ret = LuaCallMeshCircle.GetCircleEstimatedVertexCount( _id );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetCircleWillExceedVertexLimit_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _id;translator.Get(L, 1, out _id);
                    
                        var gen_ret = LuaCallMeshCircle.GetCircleWillExceedVertexLimit( _id );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
