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
    public class LuaCSMathWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(LuaCSMath);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 9, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "ColorLerp", _m_ColorLerp_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "HexColor", _m_HexColor_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ColorClone", _m_ColorClone_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ColorClamp", _m_ColorClamp_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ColorApproach", _m_ColorApproach_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ColorAnisoApproach", _m_ColorAnisoApproach_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "VecMoveTo", _m_VecMoveTo_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LaunchDirection", _m_LaunchDirection_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					var gen_ret = new LuaCSMath();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to LuaCSMath constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ColorLerp_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Color _a;translator.Get(L, 1, out _a);
                    UnityEngine.Color _b;translator.Get(L, 2, out _b);
                    float _t = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        var gen_ret = LuaCSMath.ColorLerp( _a, _b, _t );
                        translator.PushUnityEngineColor(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HexColor_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _hex = LuaAPI.lua_tostring(L, 1);
                    
                        var gen_ret = LuaCSMath.HexColor( _hex );
                        translator.PushUnityEngineColor(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ColorClone_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Color _color;translator.Get(L, 1, out _color);
                    
                        var gen_ret = LuaCSMath.ColorClone( _color );
                        translator.PushUnityEngineColor(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ColorClamp_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Color _x;translator.Get(L, 1, out _x);
                    float _a = (float)LuaAPI.lua_tonumber(L, 2);
                    float _b = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        var gen_ret = LuaCSMath.ColorClamp( _x, _a, _b );
                        translator.PushUnityEngineColor(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ColorApproach_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 5&& translator.Assignable(L, 1, (UnityEngine.Color)default)&& translator.Assignable(L, 2, (UnityEngine.Color)default)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Color _from;translator.Get(L, 1, out _from);
                    UnityEngine.Color _to;translator.Get(L, 2, out _to);
                    float _rate = (float)LuaAPI.lua_tonumber(L, 3);
                    float _dt = (float)LuaAPI.lua_tonumber(L, 4);
                    float _min = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        var gen_ret = LuaCSMath.ColorApproach( _from, _to, _rate, _dt, _min );
                        translator.PushUnityEngineColor(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable(L, 1, (UnityEngine.Color)default)&& translator.Assignable(L, 2, (UnityEngine.Color)default)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Color _from;translator.Get(L, 1, out _from);
                    UnityEngine.Color _to;translator.Get(L, 2, out _to);
                    float _rate = (float)LuaAPI.lua_tonumber(L, 3);
                    float _dt = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        var gen_ret = LuaCSMath.ColorApproach( _from, _to, _rate, _dt );
                        translator.PushUnityEngineColor(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to LuaCSMath.ColorApproach!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ColorAnisoApproach_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Color _current;translator.Get(L, 1, out _current);
                    UnityEngine.Color _target;translator.Get(L, 2, out _target);
                    float _lightupSpeed = (float)LuaAPI.lua_tonumber(L, 3);
                    float _fadeSpeed = (float)LuaAPI.lua_tonumber(L, 4);
                    float _deltaTime = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        var gen_ret = LuaCSMath.ColorAnisoApproach( _current, _target, _lightupSpeed, _fadeSpeed, _deltaTime );
                        translator.PushUnityEngineColor(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_VecMoveTo_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Vector2 _a;translator.Get(L, 1, out _a);
                    UnityEngine.Vector2 _b;translator.Get(L, 2, out _b);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        var gen_ret = LuaCSMath.VecMoveTo( _a, _b, _distance );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LaunchDirection_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Vector2 _mypos;translator.Get(L, 1, out _mypos);
                    UnityEngine.Vector2 _tgtpos;translator.Get(L, 2, out _tgtpos);
                    UnityEngine.Vector2 _tgtRelativeV;translator.Get(L, 3, out _tgtRelativeV);
                    float _projectileSpeed = (float)LuaAPI.lua_tonumber(L, 4);
                    float _t;
                    
                        var gen_ret = LuaCSMath.LaunchDirection( _mypos, _tgtpos, _tgtRelativeV, _projectileSpeed, out _t );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    LuaAPI.lua_pushnumber(L, _t);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
