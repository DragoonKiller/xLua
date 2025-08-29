#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using System;
using System.Collections.Generic;
using System.Reflection;


namespace XLua.CSObjectWrap
{
    public class XLua_Gen_Initer_Register__
	{
        
        
        static void wrapInit0(LuaEnv luaenv, ObjectTranslator translator)
        {
        
            translator.DelayWrapLoader(typeof(object), SystemObjectWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(System.ValueType), SystemValueTypeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(System.Enum), SystemEnumWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Vector3), UnityEngineVector3Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Vector4), UnityEngineVector4Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Quaternion), UnityEngineQuaternionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Color), UnityEngineColorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Ray), UnityEngineRayWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Bounds), UnityEngineBoundsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Ray2D), UnityEngineRay2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Rect), UnityEngineRectWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Mathf), UnityEngineMathfWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.KeyCode), UnityEngineKeyCodeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Input), UnityEngineInputWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Time), UnityEngineTimeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(DefenseGridLayer), DefenseGridLayerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Coord), CoordWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(_Lua_DefenseGrid), _Lua_DefenseGridWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(RangeLayer), RangeLayerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(_Lua_Range), _Lua_RangeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(RangeQueryMode), RangeQueryModeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(_Lua_RangeQuery), _Lua_RangeQueryWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(PassiveMovementType), PassiveMovementTypeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(_Lua_PassiveMovement), _Lua_PassiveMovementWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(_Lua_Localization), _Lua_LocalizationWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(_Lua_Physics), _Lua_PhysicsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(_Lua_StringCache), _Lua_StringCacheWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(LuaCSNode), LuaCSNodeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(LuaCSApplication), LuaCSApplicationWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(LuaCSAsset), LuaCSAssetWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(LuaCSAudio), LuaCSAudioWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(LuaCSCamera), LuaCSCameraWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(LuaCSCanvas), LuaCSCanvasWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(LuaCSEventSystem), LuaCSEventSystemWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(LuaCSFile), LuaCSFileWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(LuaLayerMask), LuaLayerMaskWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(LuaCSLineRenderer), LuaCSLineRendererWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(LuaCSLog), LuaCSLogWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(LuaCSMath), LuaCSMathWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(LuaCSParticleSystem), LuaCSParticleSystemWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(LuaCSProfiler), LuaCSProfilerWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(LuaCSShader), LuaCSShaderWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(LuaCSTrailRenderer), LuaCSTrailRendererWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Lua_Arc), Lua_ArcWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(LuaCallUICircle), LuaCallUICircleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(LuaCallMeshCircle), LuaCallMeshCircleWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(LuaMultithread.LuaCSMT), LuaMultithreadLuaCSMTWrap.__Register);
        
        
        
        }
        
        static void Init(LuaEnv luaenv, ObjectTranslator translator)
        {
            
            wrapInit0(luaenv, translator);
            
            
        }
        
	    static XLua_Gen_Initer_Register__()
        {
		    XLua.LuaEnv.AddIniter(Init);
		}
		
		
	}
	
}
namespace XLua
{
	public partial class ObjectTranslator
	{
		static XLua.CSObjectWrap.XLua_Gen_Initer_Register__ s_gen_reg_dumb_obj = new XLua.CSObjectWrap.XLua_Gen_Initer_Register__();
		static XLua.CSObjectWrap.XLua_Gen_Initer_Register__ gen_reg_dumb_obj {get{return s_gen_reg_dumb_obj;}}
	}
	
	internal partial class InternalGlobals
    {
	    
	    static InternalGlobals()
		{
		    extensionMethodMap = new Dictionary<Type, IEnumerable<MethodInfo>>()
			{
			    
			};
			
			genTryArrayGetPtr = StaticLuaCallbacks.__tryArrayGet;
            genTryArraySetPtr = StaticLuaCallbacks.__tryArraySet;
		}
	}
}
