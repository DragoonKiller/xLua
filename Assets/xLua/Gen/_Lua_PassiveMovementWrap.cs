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
    public class _Lua_PassiveMovementWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(_Lua_PassiveMovement);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 3, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Set", _m_Set_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Get", _m_Get_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "_Lua_PassiveMovement does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Set_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    PassiveMovementType _type;translator.Get(L, 2, out _type);
                    UnityEngine.Vector2 _pos;translator.Get(L, 3, out _pos);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 4);
                    float _speed = (float)LuaAPI.lua_tonumber(L, 5);
                    float _angularSpeed = (float)LuaAPI.lua_tonumber(L, 6);
                    
                    _Lua_PassiveMovement.Set( _tableId, _type, _pos, _distance, _speed, _angularSpeed );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Get_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    PassiveMovementType _type;
                    UnityEngine.Vector2 _pos;
                    float _distance;
                    float _speed;
                    float _angularSpeed;
                    
                    _Lua_PassiveMovement.Get( _tableId, out _type, out _pos, out _distance, out _speed, out _angularSpeed );
                    translator.PushPassiveMovementType(L, _type);
                        
                    translator.Push(L, _pos);
                        
                    LuaAPI.lua_pushnumber(L, _distance);
                        
                    LuaAPI.lua_pushnumber(L, _speed);
                        
                    LuaAPI.lua_pushnumber(L, _angularSpeed);
                        
                    
                    
                    
                    return 5;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
