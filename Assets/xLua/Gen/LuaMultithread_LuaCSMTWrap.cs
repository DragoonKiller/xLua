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
    public class LuaMultithreadLuaCSMTWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(LuaMultithread.LuaCSMT);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 8, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "PushModule", _m_PushModule_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "NewTask", _m_NewTask_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Schedule", _m_Schedule_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Execute", _m_Execute_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "TaskCompleted", _m_TaskCompleted_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetTaskError", _m_GetTaskError_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ReturnTask", _m_ReturnTask_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "LuaMultithread.LuaCSMT does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushModule_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    int _modulePathId = LuaAPI.xlua_tointeger(L, 1);
                    
                    LuaMultithread.LuaCSMT.PushModule( _modulePathId );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_NewTask_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    int _functionNameId = LuaAPI.xlua_tointeger(L, 1);
                    int _requestSize = LuaAPI.xlua_tointeger(L, 2);
                    int _resultSize = LuaAPI.xlua_tointeger(L, 3);
                    int _id;
                    System.IntPtr _input;
                    System.IntPtr _output;
                    
                    LuaMultithread.LuaCSMT.NewTask( _functionNameId, _requestSize, _resultSize, out _id, out _input, out _output );
                    LuaAPI.xlua_pushinteger(L, _id);
                        
                    LuaAPI.lua_pushlightuserdata(L, _input);
                        
                    LuaAPI.lua_pushlightuserdata(L, _output);
                        
                    
                    
                    
                    return 3;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Schedule_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    int _id = LuaAPI.xlua_tointeger(L, 1);
                    
                    LuaMultithread.LuaCSMT.Schedule( _id );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Execute_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    LuaMultithread.LuaCSMT.Execute(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TaskCompleted_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    int _id = LuaAPI.xlua_tointeger(L, 1);
                    
                        var gen_ret = LuaMultithread.LuaCSMT.TaskCompleted( _id );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetTaskError_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    int _taskId = LuaAPI.xlua_tointeger(L, 1);
                    
                        var gen_ret = LuaMultithread.LuaCSMT.GetTaskError( _taskId );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReturnTask_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    int _taskId = LuaAPI.xlua_tointeger(L, 1);
                    
                        var gen_ret = LuaMultithread.LuaCSMT.ReturnTask( _taskId );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
