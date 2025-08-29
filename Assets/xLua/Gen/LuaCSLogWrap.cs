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
    public class LuaCSLogWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(LuaCSLog);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 15, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Lua_Log", _m_Lua_Log_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Lua_Warning", _m_Lua_Warning_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Lua_Error", _m_Lua_Error_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Lua_DebugBreak", _m_Lua_DebugBreak_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Lua_DebugDrawBox2D", _m_Lua_DebugDrawBox2D_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Lua_DebugDrawLine", _m_Lua_DebugDrawLine_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Lua_DebugDrawArrow", _m_Lua_DebugDrawArrow_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Lua_DebugDrawCircle", _m_Lua_DebugDrawCircle_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Lua_DebugDrawCross", _m_Lua_DebugDrawCross_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Lua_DebugDrawArc", _m_Lua_DebugDrawArc_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Lua_DebugDrawDashLine", _m_Lua_DebugDrawDashLine_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Lua_DebugText", _m_Lua_DebugText_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Lua_GetCSharpStackTrace", _m_Lua_GetCSharpStackTrace_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Lua_GetExceptionStackTrace", _m_Lua_GetExceptionStackTrace_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "LuaCSLog does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Lua_Log_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _x = LuaAPI.lua_tostring(L, 1);
                    
                    LuaCSLog.Lua_Log( _x );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Lua_Warning_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _x = LuaAPI.lua_tostring(L, 1);
                    
                    LuaCSLog.Lua_Warning( _x );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Lua_Error_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _x = LuaAPI.lua_tostring(L, 1);
                    
                    LuaCSLog.Lua_Error( _x );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Lua_DebugBreak_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    LuaCSLog.Lua_DebugBreak(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Lua_DebugDrawBox2D_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& translator.Assignable(L, 1, (UnityEngine.Vector2)default)&& translator.Assignable(L, 2, (UnityEngine.Vector2)default)&& translator.Assignable(L, 3, (UnityEngine.Color)default)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector2 _center;translator.Get(L, 1, out _center);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    UnityEngine.Color _c;translator.Get(L, 3, out _c);
                    float _d = (float)LuaAPI.lua_tonumber(L, 4);
                    
                    LuaCSLog.Lua_DebugDrawBox2D( _center, _size, _c, _d );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable(L, 1, (UnityEngine.Vector2)default)&& translator.Assignable(L, 2, (UnityEngine.Vector2)default)&& translator.Assignable(L, 3, (UnityEngine.Color)default)) 
                {
                    UnityEngine.Vector2 _center;translator.Get(L, 1, out _center);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    UnityEngine.Color _c;translator.Get(L, 3, out _c);
                    
                    LuaCSLog.Lua_DebugDrawBox2D( _center, _size, _c );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to LuaCSLog.Lua_DebugDrawBox2D!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Lua_DebugDrawLine_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& translator.Assignable(L, 1, (UnityEngine.Vector2)default)&& translator.Assignable(L, 2, (UnityEngine.Vector2)default)&& translator.Assignable(L, 3, (UnityEngine.Color)default)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector2 _from;translator.Get(L, 1, out _from);
                    UnityEngine.Vector2 _to;translator.Get(L, 2, out _to);
                    UnityEngine.Color _c;translator.Get(L, 3, out _c);
                    float _d = (float)LuaAPI.lua_tonumber(L, 4);
                    
                    LuaCSLog.Lua_DebugDrawLine( _from, _to, _c, _d );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable(L, 1, (UnityEngine.Vector2)default)&& translator.Assignable(L, 2, (UnityEngine.Vector2)default)&& translator.Assignable(L, 3, (UnityEngine.Color)default)) 
                {
                    UnityEngine.Vector2 _from;translator.Get(L, 1, out _from);
                    UnityEngine.Vector2 _to;translator.Get(L, 2, out _to);
                    UnityEngine.Color _c;translator.Get(L, 3, out _c);
                    
                    LuaCSLog.Lua_DebugDrawLine( _from, _to, _c );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to LuaCSLog.Lua_DebugDrawLine!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Lua_DebugDrawArrow_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& translator.Assignable(L, 1, (UnityEngine.Vector2)default)&& translator.Assignable(L, 2, (UnityEngine.Vector2)default)&& translator.Assignable(L, 3, (UnityEngine.Color)default)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector2 _from;translator.Get(L, 1, out _from);
                    UnityEngine.Vector2 _to;translator.Get(L, 2, out _to);
                    UnityEngine.Color _c;translator.Get(L, 3, out _c);
                    float _d = (float)LuaAPI.lua_tonumber(L, 4);
                    
                    LuaCSLog.Lua_DebugDrawArrow( _from, _to, _c, _d );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable(L, 1, (UnityEngine.Vector2)default)&& translator.Assignable(L, 2, (UnityEngine.Vector2)default)&& translator.Assignable(L, 3, (UnityEngine.Color)default)) 
                {
                    UnityEngine.Vector2 _from;translator.Get(L, 1, out _from);
                    UnityEngine.Vector2 _to;translator.Get(L, 2, out _to);
                    UnityEngine.Color _c;translator.Get(L, 3, out _c);
                    
                    LuaCSLog.Lua_DebugDrawArrow( _from, _to, _c );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to LuaCSLog.Lua_DebugDrawArrow!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Lua_DebugDrawCircle_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& translator.Assignable(L, 1, (UnityEngine.Vector2)default)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable(L, 3, (UnityEngine.Color)default)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector2 _center;translator.Get(L, 1, out _center);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Color _c;translator.Get(L, 3, out _c);
                    float _d = (float)LuaAPI.lua_tonumber(L, 4);
                    
                    LuaCSLog.Lua_DebugDrawCircle( _center, _radius, _c, _d );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable(L, 1, (UnityEngine.Vector2)default)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable(L, 3, (UnityEngine.Color)default)) 
                {
                    UnityEngine.Vector2 _center;translator.Get(L, 1, out _center);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Color _c;translator.Get(L, 3, out _c);
                    
                    LuaCSLog.Lua_DebugDrawCircle( _center, _radius, _c );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to LuaCSLog.Lua_DebugDrawCircle!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Lua_DebugDrawCross_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& translator.Assignable(L, 1, (UnityEngine.Vector2)default)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable(L, 3, (UnityEngine.Color)default)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector2 _center;translator.Get(L, 1, out _center);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Color _c;translator.Get(L, 3, out _c);
                    float _d = (float)LuaAPI.lua_tonumber(L, 4);
                    
                    LuaCSLog.Lua_DebugDrawCross( _center, _radius, _c, _d );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable(L, 1, (UnityEngine.Vector2)default)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable(L, 3, (UnityEngine.Color)default)) 
                {
                    UnityEngine.Vector2 _center;translator.Get(L, 1, out _center);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Color _c;translator.Get(L, 3, out _c);
                    
                    LuaCSLog.Lua_DebugDrawCross( _center, _radius, _c );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to LuaCSLog.Lua_DebugDrawCross!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Lua_DebugDrawArc_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 6&& translator.Assignable(L, 1, (UnityEngine.Vector2)default)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable(L, 5, (UnityEngine.Color)default)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector2 _center;translator.Get(L, 1, out _center);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 2);
                    float _dirAngle = (float)LuaAPI.lua_tonumber(L, 3);
                    float _arcSizeAngle = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Color _c;translator.Get(L, 5, out _c);
                    float _d = (float)LuaAPI.lua_tonumber(L, 6);
                    
                    LuaCSLog.Lua_DebugDrawArc( _center, _radius, _dirAngle, _arcSizeAngle, _c, _d );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& translator.Assignable(L, 1, (UnityEngine.Vector2)default)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable(L, 5, (UnityEngine.Color)default)) 
                {
                    UnityEngine.Vector2 _center;translator.Get(L, 1, out _center);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 2);
                    float _dirAngle = (float)LuaAPI.lua_tonumber(L, 3);
                    float _arcSizeAngle = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Color _c;translator.Get(L, 5, out _c);
                    
                    LuaCSLog.Lua_DebugDrawArc( _center, _radius, _dirAngle, _arcSizeAngle, _c );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to LuaCSLog.Lua_DebugDrawArc!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Lua_DebugDrawDashLine_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& translator.Assignable(L, 1, (UnityEngine.Vector2)default)&& translator.Assignable(L, 2, (UnityEngine.Vector2)default)&& translator.Assignable(L, 3, (UnityEngine.Color)default)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector2 _from;translator.Get(L, 1, out _from);
                    UnityEngine.Vector2 _to;translator.Get(L, 2, out _to);
                    UnityEngine.Color _c;translator.Get(L, 3, out _c);
                    float _d = (float)LuaAPI.lua_tonumber(L, 4);
                    
                    LuaCSLog.Lua_DebugDrawDashLine( _from, _to, _c, _d );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& translator.Assignable(L, 1, (UnityEngine.Vector2)default)&& translator.Assignable(L, 2, (UnityEngine.Vector2)default)&& translator.Assignable(L, 3, (UnityEngine.Color)default)&& translator.Assignable(L, 4, (UnityEngine.Color)default)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector2 _from;translator.Get(L, 1, out _from);
                    UnityEngine.Vector2 _to;translator.Get(L, 2, out _to);
                    UnityEngine.Color _c1;translator.Get(L, 3, out _c1);
                    UnityEngine.Color _c2;translator.Get(L, 4, out _c2);
                    float _d = (float)LuaAPI.lua_tonumber(L, 5);
                    
                    LuaCSLog.Lua_DebugDrawDashLine( _from, _to, _c1, _c2, _d );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 6&& translator.Assignable(L, 1, (UnityEngine.Vector2)default)&& translator.Assignable(L, 2, (UnityEngine.Vector2)default)&& translator.Assignable(L, 3, (UnityEngine.Color)default)&& translator.Assignable(L, 4, (UnityEngine.Color)default)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector2 _from;translator.Get(L, 1, out _from);
                    UnityEngine.Vector2 _to;translator.Get(L, 2, out _to);
                    UnityEngine.Color _c1;translator.Get(L, 3, out _c1);
                    UnityEngine.Color _c2;translator.Get(L, 4, out _c2);
                    float _dashLength = (float)LuaAPI.lua_tonumber(L, 5);
                    float _d = (float)LuaAPI.lua_tonumber(L, 6);
                    
                    LuaCSLog.Lua_DebugDrawDashLine( _from, _to, _c1, _c2, _dashLength, _d );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to LuaCSLog.Lua_DebugDrawDashLine!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Lua_DebugText_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 5&& translator.Assignable(L, 1, (UnityEngine.Vector2)default)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable(L, 4, (UnityEngine.Color)default)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector2 _worldpos;translator.Get(L, 1, out _worldpos);
                    string _text = LuaAPI.lua_tostring(L, 2);
                    float _scale = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Color _color;translator.Get(L, 4, out _color);
                    float _d = (float)LuaAPI.lua_tonumber(L, 5);
                    
                    LuaCSLog.Lua_DebugText( _worldpos, _text, _scale, _color, _d );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& translator.Assignable(L, 1, (UnityEngine.Vector2)default)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable(L, 4, (UnityEngine.Color)default)) 
                {
                    UnityEngine.Vector2 _worldpos;translator.Get(L, 1, out _worldpos);
                    string _text = LuaAPI.lua_tostring(L, 2);
                    float _scale = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Color _color;translator.Get(L, 4, out _color);
                    
                    LuaCSLog.Lua_DebugText( _worldpos, _text, _scale, _color );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to LuaCSLog.Lua_DebugText!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Lua_GetCSharpStackTrace_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                        var gen_ret = LuaCSLog.Lua_GetCSharpStackTrace(  );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Lua_GetExceptionStackTrace_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.Exception _exception = (System.Exception)translator.GetObject(L, 1, typeof(System.Exception));
                    
                        var gen_ret = LuaCSLog.Lua_GetExceptionStackTrace( _exception );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
