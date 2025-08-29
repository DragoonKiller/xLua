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
    public class LuaCSLineRendererWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(LuaCSLineRenderer);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 12, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "SetPointCount", _m_SetPointCount_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetPoint", _m_SetPoint_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetWidth", _m_SetWidth_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetStartEndWidth", _m_SetStartEndWidth_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetStartEndColor", _m_SetStartEndColor_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetStartEndAlpha", _m_GetStartEndAlpha_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetStartEndColor", _m_GetStartEndColor_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetAlpha", _m_SetAlpha_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetStartEndAlpha", _m_SetStartEndAlpha_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetRGB", _m_SetRGB_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetStartEndRGB", _m_SetStartEndRGB_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "LuaCSLineRenderer does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetPointCount_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    int _count = LuaAPI.xlua_tointeger(L, 2);
                    
                    LuaCSLineRenderer.SetPointCount( _tableId, _count );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetPoint_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Vector2 _point;translator.Get(L, 3, out _point);
                    
                    LuaCSLineRenderer.SetPoint( _tableId, _index, _point );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetWidth_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    float _width = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    LuaCSLineRenderer.SetWidth( _tableId, _width );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetStartEndWidth_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    float _startWidth = (float)LuaAPI.lua_tonumber(L, 2);
                    float _endWidth = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    LuaCSLineRenderer.SetStartEndWidth( _tableId, _startWidth, _endWidth );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetStartEndColor_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    UnityEngine.Color _startColor;translator.Get(L, 2, out _startColor);
                    UnityEngine.Color _endColor;translator.Get(L, 3, out _endColor);
                    
                    LuaCSLineRenderer.SetStartEndColor( _tableId, _startColor, _endColor );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetStartEndAlpha_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    float _startAlpha;
                    float _endAlpha;
                    
                    LuaCSLineRenderer.GetStartEndAlpha( _tableId, out _startAlpha, out _endAlpha );
                    LuaAPI.lua_pushnumber(L, _startAlpha);
                        
                    LuaAPI.lua_pushnumber(L, _endAlpha);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetStartEndColor_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    UnityEngine.Color _startColor;
                    UnityEngine.Color _endColor;
                    
                    LuaCSLineRenderer.GetStartEndColor( _tableId, out _startColor, out _endColor );
                    translator.PushUnityEngineColor(L, _startColor);
                        
                    translator.PushUnityEngineColor(L, _endColor);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetAlpha_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    float _alpha = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    LuaCSLineRenderer.SetAlpha( _tableId, _alpha );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetStartEndAlpha_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    float _startAlpha = (float)LuaAPI.lua_tonumber(L, 2);
                    float _endAlpha = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    LuaCSLineRenderer.SetStartEndAlpha( _tableId, _startAlpha, _endAlpha );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetRGB_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    UnityEngine.Color _color;translator.Get(L, 2, out _color);
                    
                    LuaCSLineRenderer.SetRGB( _tableId, _color );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetStartEndRGB_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    UnityEngine.Color _color;translator.Get(L, 2, out _color);
                    
                    LuaCSLineRenderer.SetStartEndRGB( _tableId, _color );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
