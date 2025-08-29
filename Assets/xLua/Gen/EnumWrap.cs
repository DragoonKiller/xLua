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
    
    public class UnityEngineKeyCodeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UnityEngine.KeyCode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UnityEngine.KeyCode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UnityEngine.KeyCode), L, null, 340, 0, 0);

            Utils.RegisterEnumType(L, typeof(UnityEngine.KeyCode));

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UnityEngine.KeyCode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUnityEngineKeyCode(L, (UnityEngine.KeyCode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

                try
				{
                    translator.TranslateToEnumToTop(L, typeof(UnityEngine.KeyCode), 1);
				}
				catch (System.Exception e)
				{
					return LuaAPI.luaL_error(L, "cast to " + typeof(UnityEngine.KeyCode) + " exception:" + e);
				}

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UnityEngine.KeyCode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class DefenseGridLayerWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(DefenseGridLayer), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(DefenseGridLayer), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(DefenseGridLayer), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Turret", DefenseGridLayer.Turret);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Creep", DefenseGridLayer.Creep);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(DefenseGridLayer), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushDefenseGridLayer(L, (DefenseGridLayer)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Turret"))
                {
                    translator.PushDefenseGridLayer(L, DefenseGridLayer.Turret);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Creep"))
                {
                    translator.PushDefenseGridLayer(L, DefenseGridLayer.Creep);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for DefenseGridLayer!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for DefenseGridLayer! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class RangeLayerWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(RangeLayer), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(RangeLayer), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(RangeLayer), L, null, 7, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", RangeLayer.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Hostile", RangeLayer.Hostile);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Friendly", RangeLayer.Friendly);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Debris", RangeLayer.Debris);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Mining", RangeLayer.Mining);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Gas", RangeLayer.Gas);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(RangeLayer), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushRangeLayer(L, (RangeLayer)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushRangeLayer(L, RangeLayer.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Hostile"))
                {
                    translator.PushRangeLayer(L, RangeLayer.Hostile);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Friendly"))
                {
                    translator.PushRangeLayer(L, RangeLayer.Friendly);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Debris"))
                {
                    translator.PushRangeLayer(L, RangeLayer.Debris);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Mining"))
                {
                    translator.PushRangeLayer(L, RangeLayer.Mining);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Gas"))
                {
                    translator.PushRangeLayer(L, RangeLayer.Gas);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for RangeLayer!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for RangeLayer! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class RangeQueryModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(RangeQueryMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(RangeQueryMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(RangeQueryMode), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "All", RangeQueryMode.All);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Closest", RangeQueryMode.Closest);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "AllSorted", RangeQueryMode.AllSorted);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(RangeQueryMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushRangeQueryMode(L, (RangeQueryMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "All"))
                {
                    translator.PushRangeQueryMode(L, RangeQueryMode.All);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Closest"))
                {
                    translator.PushRangeQueryMode(L, RangeQueryMode.Closest);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "AllSorted"))
                {
                    translator.PushRangeQueryMode(L, RangeQueryMode.AllSorted);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for RangeQueryMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for RangeQueryMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class PassiveMovementTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(PassiveMovementType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(PassiveMovementType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(PassiveMovementType), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", PassiveMovementType.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Stay", PassiveMovementType.Stay);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Orbit", PassiveMovementType.Orbit);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(PassiveMovementType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushPassiveMovementType(L, (PassiveMovementType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushPassiveMovementType(L, PassiveMovementType.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Stay"))
                {
                    translator.PushPassiveMovementType(L, PassiveMovementType.Stay);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Orbit"))
                {
                    translator.PushPassiveMovementType(L, PassiveMovementType.Orbit);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for PassiveMovementType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for PassiveMovementType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
}