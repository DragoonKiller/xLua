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
    public class LuaCSNodeWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(LuaCSNode);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 149, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetActive", _m__Node_SetActive_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_IsActive", _m__Node_IsActive_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_IsSelfActive", _m__Node_IsSelfActive_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_DontDestroyOnLoad", _m__Node_DontDestroyOnLoad_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_HasAnimator", _m__Node_HasAnimator_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_HasAnim", _m__Node_HasAnim_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_GetAnimSpeed", _m__Node_GetAnimSpeed_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetAnimSpeed", _m__Node_SetAnimSpeed_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_PlayAnim", _m__Node_PlayAnim_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_GetAnimRatio", _m__Node_GetAnimRatio_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetAnimRatio", _m__Node_SetAnimRatio_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_IsAnimPlaying", _m__Node_IsAnimPlaying_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_GetBounce", _m__Node_GetBounce_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetBounce", _m__Node_SetBounce_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetColliderSize", _m__Node_SetColliderSize_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_GetColliderSize", _m__Node_GetColliderSize_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_GetColor", _m__Node_GetColor_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_GetAlpha", _m__Node_GetAlpha_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetAlpha", _m__Node_SetAlpha_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_AlphaTo", _m__Node_AlphaTo_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetColor", _m__Node_SetColor_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_GetRGB", _m__Node_GetRGB_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetRGB", _m__Node_SetRGB_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetRGBColor", _m__Node_SetRGBColor_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetComponentEnable", _m__Node_SetComponentEnable_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetInteractable", _m__Node_SetInteractable_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_GetInteractable", _m__Node_GetInteractable_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_GetParent", _m__Node_GetParent_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetParent", _m__Node_SetParent_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_GetChildCount", _m__Node_GetChildCount_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_GetChildAt", _m__Node_GetChildAt_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_FindChild", _m__Node_FindChild_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_FindAllChild", _m__Node_FindAllChild_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetLayer", _m__Node_SetLayer_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_GetLayer", _m__Node_GetLayer_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_IsValidLoadPath", _m__Node_IsValidLoadPath_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_Load", _m__Node_Load_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_LoadWithName", _m__Node_LoadWithName_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_Inspect", _m__Node_Inspect_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_LoadSimple", _m__Node_LoadSimple_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_LoadEmpty", _m__Node_LoadEmpty_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_Clone", _m__Node_Clone_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_DestroyNode", _m__Node_DestroyNode_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetMatColor", _m__Node_SetMatColor_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetMatRGB", _m__Node_SetMatRGB_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetMatFloat", _m__Node_SetMatFloat_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetMatVec4", _m__Node_SetMatVec4_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetMatVec3", _m__Node_SetMatVec3_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetMatVec2", _m__Node_SetMatVec2_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetMatTexture", _m__Node_SetMatTexture_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetMaterial", _m__Node_SetMaterial_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "UseStandardMaterial", _m_UseStandardMaterial_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_GetObjectName", _m__Node_GetObjectName_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetObjectName", _m__Node_SetObjectName_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_GetName", _m__Node_GetName_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_GetNamePath", _m__Node_GetNamePath_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_GetWorldRect", _m__Node_GetWorldRect_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_GetRect", _m__Node_GetRect_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetRect", _m__Node_SetRect_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetWorldRect", _m__Node_SetWorldRect_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetRigidbody", _m__Node_SetRigidbody_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetMass", _m__Node_SetMass_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_GetMass", _m__Node_GetMass_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetLinearDrag", _m__Node_SetLinearDrag_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_GetLinearDrag", _m__Node_GetLinearDrag_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetAngularDrag", _m__Node_SetAngularDrag_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_GetAngularDrag", _m__Node_GetAngularDrag_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetInertia", _m__Node_SetInertia_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_GetInertia", _m__Node_GetInertia_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_GetCenterOfMass", _m__Node_GetCenterOfMass_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetCenterOfMass", _m__Node_SetCenterOfMass_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetGravityScale", _m__Node_SetGravityScale_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_GetGravityScale", _m__Node_GetGravityScale_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_GetSize", _m__Node_GetSize_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_GetSizeXY", _m__Node_GetSizeXY_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetSizeXY", _m__Node_SetSizeXY_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetSizeX", _m__Node_SetSizeX_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_IsSprite", _m__Node_IsSprite_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetSprite", _m__Node_SetSprite_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_GetBounds", _m__Node_GetBounds_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_GetWorldBounds", _m__Node_GetWorldBounds_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_CopySpriteTo", _m__Node_CopySpriteTo_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetNativeSize", _m__Node_SetNativeSize_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetKeepAspectRatio", _m__Node_SetKeepAspectRatio_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_GetKeepAspectRatio", _m__Node_GetKeepAspectRatio_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetSpriteSizeXY", _m__Node_SetSpriteSizeXY_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetSpriteSizeVec", _m__Node_SetSpriteSizeVec_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_GetSpriteSize", _m__Node_GetSpriteSize_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetText", _m__Node_SetText_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_GetText", _m__Node_GetText_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_GetWorldRotation", _m__Node_GetWorldRotation_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetWorldRotation", _m__Node_SetWorldRotation_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_GetRotation", _m__Node_GetRotation_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetRotation", _m__Node_SetRotation_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_GetWorldPosition", _m__Node_GetWorldPosition_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_GetPositionXY", _m__Node_GetPositionXY_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_GetWorldPositionXY", _m__Node_GetWorldPositionXY_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetWorldPositionXY", _m__Node_SetWorldPositionXY_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_GetPosition", _m__Node_GetPosition_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetPositionXY", _m__Node_SetPositionXY_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_GetScaleXY", _m__Node_GetScaleXY_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetScaleXY", _m__Node_SetScaleXY_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetScaleX", _m__Node_SetScaleX_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetWorldScaleXY", _m__Node_SetWorldScaleXY_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetWorldScaleX", _m__Node_SetWorldScaleX_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_GetWorldScaleXY", _m__Node_GetWorldScaleXY_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_UpdateAutoPosition", _m__Node_UpdateAutoPosition_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetAnchoredPositionXY", _m__Node_SetAnchoredPositionXY_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_GetAnchoredPosition", _m__Node_GetAnchoredPosition_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetAnchoredPositionVec", _m__Node_SetAnchoredPositionVec_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_WorldToLocalPointXY", _m__Node_WorldToLocalPointXY_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_LocalToWorldPointXY", _m__Node_LocalToWorldPointXY_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_WorldToLocalVectorXY", _m__Node_WorldToLocalVectorXY_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_LocalToWorldVectorXY", _m__Node_LocalToWorldVectorXY_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_WorldToLocalLength", _m__Node_WorldToLocalLength_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_LocalToWorldLength", _m__Node_LocalToWorldLength_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_ScreenToUIPos", _m__Node_ScreenToUIPos_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_UIToScreenPos", _m__Node_UIToScreenPos_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_Tremble", _m__Node_Tremble_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_GetFillAmount", _m__Node_GetFillAmount_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetFillAmount", _m__Node_SetFillAmount_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_HasTween", _m__Node_HasTween_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetTweenDuration", _m__Node_SetTweenDuration_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_Tween", _m__Node_Tween_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetTweenProgress", _m__Node_SetTweenProgress_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetTweenControl", _m__Node_SetTweenControl_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_GetVelocityXY", _m__Node_GetVelocityXY_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetVelocityXY", _m__Node_SetVelocityXY_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_GetAngularVelocity", _m__Node_GetAngularVelocity_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetAngularVelocity", _m__Node_SetAngularVelocity_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_GetSpeed", _m__Node_GetSpeed_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetSpeed", _m__Node_SetSpeed_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_GetVelocityAngle", _m__Node_GetVelocityAngle_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetVelocityAngle", _m__Node_SetVelocityAngle_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_PlayFX", _m__Node_PlayFX_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_StopFX", _m__Node_StopFX_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_BurstFX", _m__Node_BurstFX_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetVFXFloat", _m__Node_SetVFXFloat_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetVFXVec2", _m__Node_SetVFXVec2_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetVFXVec3", _m__Node_SetVFXVec3_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetVFXVec4", _m__Node_SetVFXVec4_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetVFXColor", _m__Node_SetVFXColor_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetVFXRGB", _m__Node_SetVFXRGB_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetVFXAlpha", _m__Node_SetVFXAlpha_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_GetZ", _m__Node_GetZ_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetZ", _m__Node_SetZ_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_GetWorldZ", _m__Node_GetWorldZ_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "_Node_SetWorldZ", _m__Node_SetWorldZ_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "LuaCSNode does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetActive_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    bool _active = LuaAPI.lua_toboolean(L, 2);
                    
                    LuaCSNode._Node_SetActive( _tableId, _active );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_IsActive_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    
                        var gen_ret = LuaCSNode._Node_IsActive( _tableId );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_IsSelfActive_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    
                        var gen_ret = LuaCSNode._Node_IsSelfActive( _tableId );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_DontDestroyOnLoad_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    
                    LuaCSNode._Node_DontDestroyOnLoad( _tableId );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_HasAnimator_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    
                        var gen_ret = LuaCSNode._Node_HasAnimator( _tableId );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_HasAnim_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        var gen_ret = LuaCSNode._Node_HasAnim( _tableId, _name );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_GetAnimSpeed_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    
                        var gen_ret = LuaCSNode._Node_GetAnimSpeed( _tableId );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetAnimSpeed_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    float _speed = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    LuaCSNode._Node_SetAnimSpeed( _tableId, _speed );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_PlayAnim_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& translator.Assignable(L, 1, (NodeId)default)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    string _name = LuaAPI.lua_tostring(L, 2);
                    bool _restart = LuaAPI.lua_toboolean(L, 3);
                    
                    LuaCSNode._Node_PlayAnim( _tableId, _name, _restart );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable(L, 1, (NodeId)default)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                    LuaCSNode._Node_PlayAnim( _tableId, _name );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to LuaCSNode._Node_PlayAnim!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_GetAnimRatio_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    
                        var gen_ret = LuaCSNode._Node_GetAnimRatio( _tableId );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetAnimRatio_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    float _ratio = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    LuaCSNode._Node_SetAnimRatio( _tableId, _ratio );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_IsAnimPlaying_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    
                        var gen_ret = LuaCSNode._Node_IsAnimPlaying( _tableId );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_GetBounce_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    
                        var gen_ret = LuaCSNode._Node_GetBounce( _tableId );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetBounce_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    float _bounce = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    LuaCSNode._Node_SetBounce( _tableId, _bounce );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetColliderSize_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable(L, 1, (NodeId)default)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    float _x = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    LuaCSNode._Node_SetColliderSize( _tableId, _x );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable(L, 1, (NodeId)default)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    float _x = (float)LuaAPI.lua_tonumber(L, 2);
                    float _y = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    LuaCSNode._Node_SetColliderSize( _tableId, _x, _y );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to LuaCSNode._Node_SetColliderSize!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_GetColliderSize_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    
                        var gen_ret = LuaCSNode._Node_GetColliderSize( _tableId );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_GetColor_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    
                        var gen_ret = LuaCSNode._Node_GetColor( _tableId );
                        translator.PushUnityEngineColor(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_GetAlpha_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    
                        var gen_ret = LuaCSNode._Node_GetAlpha( _tableId );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetAlpha_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    float _alpha = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    LuaCSNode._Node_SetAlpha( _tableId, _alpha );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_AlphaTo_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    float _toAlpha = (float)LuaAPI.lua_tonumber(L, 2);
                    float _maxDelta = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    LuaCSNode._Node_AlphaTo( _tableId, _toAlpha, _maxDelta );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetColor_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 5&& translator.Assignable(L, 1, (NodeId)default)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    float _r = (float)LuaAPI.lua_tonumber(L, 2);
                    float _g = (float)LuaAPI.lua_tonumber(L, 3);
                    float _b = (float)LuaAPI.lua_tonumber(L, 4);
                    float _a = (float)LuaAPI.lua_tonumber(L, 5);
                    
                    LuaCSNode._Node_SetColor( _tableId, _r, _g, _b, _a );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable(L, 1, (NodeId)default)&& translator.Assignable(L, 2, (UnityEngine.Color)default)) 
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    UnityEngine.Color _color;translator.Get(L, 2, out _color);
                    
                    LuaCSNode._Node_SetColor( _tableId, _color );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to LuaCSNode._Node_SetColor!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_GetRGB_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    
                        var gen_ret = LuaCSNode._Node_GetRGB( _tableId );
                        translator.PushUnityEngineColor(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetRGB_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    float _r = (float)LuaAPI.lua_tonumber(L, 2);
                    float _g = (float)LuaAPI.lua_tonumber(L, 3);
                    float _b = (float)LuaAPI.lua_tonumber(L, 4);
                    
                    LuaCSNode._Node_SetRGB( _tableId, _r, _g, _b );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetRGBColor_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    UnityEngine.Color _color;translator.Get(L, 2, out _color);
                    
                    LuaCSNode._Node_SetRGBColor( _tableId, _color );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetComponentEnable_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    int _nameId = LuaAPI.xlua_tointeger(L, 2);
                    bool _enable = LuaAPI.lua_toboolean(L, 3);
                    
                    LuaCSNode._Node_SetComponentEnable( _tableId, _nameId, _enable );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetInteractable_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    bool _interactable = LuaAPI.lua_toboolean(L, 2);
                    
                    LuaCSNode._Node_SetInteractable( _tableId, _interactable );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_GetInteractable_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    
                        var gen_ret = LuaCSNode._Node_GetInteractable( _tableId );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_GetParent_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    LightLuaTable _t;translator.Get(L, 2, out _t);
                    
                    LuaCSNode._Node_GetParent( _tableId, _t );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetParent_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& translator.Assignable(L, 1, (NodeId)default)&& translator.Assignable(L, 2, (NodeId)default)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    NodeId _parentTableId;translator.Get(L, 2, out _parentTableId);
                    bool _worldPositionStays = LuaAPI.lua_toboolean(L, 3);
                    
                    LuaCSNode._Node_SetParent( _tableId, _parentTableId, _worldPositionStays );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable(L, 1, (NodeId)default)&& translator.Assignable(L, 2, (NodeId)default)) 
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    NodeId _parentTableId;translator.Get(L, 2, out _parentTableId);
                    
                    LuaCSNode._Node_SetParent( _tableId, _parentTableId );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to LuaCSNode._Node_SetParent!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_GetChildCount_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    
                        var gen_ret = LuaCSNode._Node_GetChildCount( _tableId );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_GetChildAt_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    string _childName;
                    LightLuaTable _result;translator.Get(L, 3, out _result);
                    
                    LuaCSNode._Node_GetChildAt( _tableId, _index, out _childName, _result );
                    LuaAPI.lua_pushstring(L, _childName);
                        
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_FindChild_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    string _childName = LuaAPI.lua_tostring(L, 2);
                    LightLuaTable _resultTable;translator.Get(L, 3, out _resultTable);
                    
                    LuaCSNode._Node_FindChild( _tableId, _childName, _resultTable );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_FindAllChild_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    string _prefix = LuaAPI.lua_tostring(L, 2);
                    LightLuaTable _resultTable;translator.Get(L, 3, out _resultTable);
                    
                    LuaCSNode._Node_FindAllChild( _tableId, _prefix, _resultTable );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetLayer_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& translator.Assignable(L, 1, (NodeId)default)&& translator.Assignable(L, 2, (LuaLayerMask)default)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    LuaLayerMask _layer;translator.Get(L, 2, out _layer);
                    bool _includeChildren = LuaAPI.lua_toboolean(L, 3);
                    
                    LuaCSNode._Node_SetLayer( _tableId, _layer, _includeChildren );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable(L, 1, (NodeId)default)&& translator.Assignable(L, 2, (LuaLayerMask)default)) 
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    LuaLayerMask _layer;translator.Get(L, 2, out _layer);
                    
                    LuaCSNode._Node_SetLayer( _tableId, _layer );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to LuaCSNode._Node_SetLayer!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_GetLayer_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    
                        var gen_ret = LuaCSNode._Node_GetLayer( _tableId );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_IsValidLoadPath_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    int _pathId = LuaAPI.xlua_tointeger(L, 1);
                    
                        var gen_ret = LuaCSNode._Node_IsValidLoadPath( _pathId );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_Load_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    int _pathId = LuaAPI.xlua_tointeger(L, 1);
                    NodeId _parentTableId;translator.Get(L, 2, out _parentTableId);
                    int _classNameId = LuaAPI.xlua_tointeger(L, 3);
                    
                        var gen_ret = LuaCSNode._Node_Load( _pathId, _parentTableId, _classNameId );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_LoadWithName_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    int _pathId = LuaAPI.xlua_tointeger(L, 1);
                    int _nameId = LuaAPI.xlua_tointeger(L, 2);
                    NodeId _parentTableId;translator.Get(L, 3, out _parentTableId);
                    int _classNameId = LuaAPI.xlua_tointeger(L, 4);
                    
                        var gen_ret = LuaCSNode._Node_LoadWithName( _pathId, _nameId, _parentTableId, _classNameId );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_Inspect_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    int _pathId = LuaAPI.xlua_tointeger(L, 1);
                    
                        var gen_ret = LuaCSNode._Node_Inspect( _pathId );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_LoadSimple_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    int _pathId = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.Vector3 _position;translator.Get(L, 2, out _position);
                    float _rotation = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector2 _scale;translator.Get(L, 4, out _scale);
                    NodeId _parentId;translator.Get(L, 5, out _parentId);
                    
                    LuaCSNode._Node_LoadSimple( _pathId, _position, _rotation, _scale, _parentId );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_LoadEmpty_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    int _nameId = LuaAPI.xlua_tointeger(L, 1);
                    NodeId _parentTableId;translator.Get(L, 2, out _parentTableId);
                    int _classNameId = LuaAPI.xlua_tointeger(L, 3);
                    
                        var gen_ret = LuaCSNode._Node_LoadEmpty( _nameId, _parentTableId, _classNameId );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_Clone_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    string _newName = LuaAPI.lua_tostring(L, 2);
                    
                        var gen_ret = LuaCSNode._Node_Clone( _tableId, _newName );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_DestroyNode_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    
                    LuaCSNode._Node_DestroyNode( _tableId );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetMatColor_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    int _name = LuaAPI.xlua_tointeger(L, 2);
                    float _r = (float)LuaAPI.lua_tonumber(L, 3);
                    float _g = (float)LuaAPI.lua_tonumber(L, 4);
                    float _b = (float)LuaAPI.lua_tonumber(L, 5);
                    float _a = (float)LuaAPI.lua_tonumber(L, 6);
                    
                    LuaCSNode._Node_SetMatColor( _tableId, _name, _r, _g, _b, _a );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetMatRGB_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    int _name = LuaAPI.xlua_tointeger(L, 2);
                    float _r = (float)LuaAPI.lua_tonumber(L, 3);
                    float _g = (float)LuaAPI.lua_tonumber(L, 4);
                    float _b = (float)LuaAPI.lua_tonumber(L, 5);
                    
                    LuaCSNode._Node_SetMatRGB( _tableId, _name, _r, _g, _b );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetMatFloat_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    int _name = LuaAPI.xlua_tointeger(L, 2);
                    float _value = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    LuaCSNode._Node_SetMatFloat( _tableId, _name, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetMatVec4_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    int _name = LuaAPI.xlua_tointeger(L, 2);
                    float _x = (float)LuaAPI.lua_tonumber(L, 3);
                    float _y = (float)LuaAPI.lua_tonumber(L, 4);
                    float _z = (float)LuaAPI.lua_tonumber(L, 5);
                    float _w = (float)LuaAPI.lua_tonumber(L, 6);
                    
                    LuaCSNode._Node_SetMatVec4( _tableId, _name, _x, _y, _z, _w );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetMatVec3_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    int _name = LuaAPI.xlua_tointeger(L, 2);
                    float _x = (float)LuaAPI.lua_tonumber(L, 3);
                    float _y = (float)LuaAPI.lua_tonumber(L, 4);
                    float _z = (float)LuaAPI.lua_tonumber(L, 5);
                    
                    LuaCSNode._Node_SetMatVec3( _tableId, _name, _x, _y, _z );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetMatVec2_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    int _name = LuaAPI.xlua_tointeger(L, 2);
                    float _x = (float)LuaAPI.lua_tonumber(L, 3);
                    float _y = (float)LuaAPI.lua_tonumber(L, 4);
                    
                    LuaCSNode._Node_SetMatVec2( _tableId, _name, _x, _y );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetMatTexture_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    int _name = LuaAPI.xlua_tointeger(L, 2);
                    string _textureResPath = LuaAPI.lua_tostring(L, 3);
                    
                    LuaCSNode._Node_SetMatTexture( _tableId, _name, _textureResPath );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetMaterial_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    int _pathId = LuaAPI.xlua_tointeger(L, 2);
                    
                    LuaCSNode._Node_SetMaterial( _tableId, _pathId );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UseStandardMaterial_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    
                    LuaCSNode.UseStandardMaterial( _tableId );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_GetObjectName_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    
                        var gen_ret = LuaCSNode._Node_GetObjectName( _tableId );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetObjectName_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                    LuaCSNode._Node_SetObjectName( _tableId, _name );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_GetName_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    
                        var gen_ret = LuaCSNode._Node_GetName( _tableId );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_GetNamePath_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    
                        var gen_ret = LuaCSNode._Node_GetNamePath( _tableId );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_GetWorldRect_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    float _minX;
                    float _minY;
                    float _maxX;
                    float _maxY;
                    
                    LuaCSNode._Node_GetWorldRect( _tableId, out _minX, out _minY, out _maxX, out _maxY );
                    LuaAPI.lua_pushnumber(L, _minX);
                        
                    LuaAPI.lua_pushnumber(L, _minY);
                        
                    LuaAPI.lua_pushnumber(L, _maxX);
                        
                    LuaAPI.lua_pushnumber(L, _maxY);
                        
                    
                    
                    
                    return 4;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_GetRect_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    float _minX;
                    float _minY;
                    float _maxX;
                    float _maxY;
                    
                    LuaCSNode._Node_GetRect( _tableId, out _minX, out _minY, out _maxX, out _maxY );
                    LuaAPI.lua_pushnumber(L, _minX);
                        
                    LuaAPI.lua_pushnumber(L, _minY);
                        
                    LuaAPI.lua_pushnumber(L, _maxX);
                        
                    LuaAPI.lua_pushnumber(L, _maxY);
                        
                    
                    
                    
                    return 4;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetRect_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    UnityEngine.Vector2 _min;translator.Get(L, 2, out _min);
                    UnityEngine.Vector2 _max;translator.Get(L, 3, out _max);
                    
                    LuaCSNode._Node_SetRect( _tableId, _min, _max );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetWorldRect_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    UnityEngine.Vector2 _min;translator.Get(L, 2, out _min);
                    UnityEngine.Vector2 _max;translator.Get(L, 3, out _max);
                    
                    LuaCSNode._Node_SetWorldRect( _tableId, _min, _max );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetRigidbody_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    
                    LuaCSNode._Node_SetRigidbody( _tableId );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetMass_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    float _mass = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    LuaCSNode._Node_SetMass( _tableId, _mass );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_GetMass_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    
                        var gen_ret = LuaCSNode._Node_GetMass( _tableId );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetLinearDrag_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    float _drag = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    LuaCSNode._Node_SetLinearDrag( _tableId, _drag );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_GetLinearDrag_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    float _drag;
                    
                    LuaCSNode._Node_GetLinearDrag( _tableId, out _drag );
                    LuaAPI.lua_pushnumber(L, _drag);
                        
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetAngularDrag_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    float _drag = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    LuaCSNode._Node_SetAngularDrag( _tableId, _drag );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_GetAngularDrag_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    
                        var gen_ret = LuaCSNode._Node_GetAngularDrag( _tableId );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetInertia_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    float _inertia = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    LuaCSNode._Node_SetInertia( _tableId, _inertia );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_GetInertia_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    
                        var gen_ret = LuaCSNode._Node_GetInertia( _tableId );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_GetCenterOfMass_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    
                        var gen_ret = LuaCSNode._Node_GetCenterOfMass( _tableId );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetCenterOfMass_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    UnityEngine.Vector2 _center;translator.Get(L, 2, out _center);
                    
                    LuaCSNode._Node_SetCenterOfMass( _tableId, _center );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetGravityScale_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    float _scale = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    LuaCSNode._Node_SetGravityScale( _tableId, _scale );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_GetGravityScale_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    
                        var gen_ret = LuaCSNode._Node_GetGravityScale( _tableId );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_GetSize_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    
                        var gen_ret = LuaCSNode._Node_GetSize( _tableId );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_GetSizeXY_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    float _x;
                    float _y;
                    
                    LuaCSNode._Node_GetSizeXY( _tableId, out _x, out _y );
                    LuaAPI.lua_pushnumber(L, _x);
                        
                    LuaAPI.lua_pushnumber(L, _y);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetSizeXY_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    float _x = (float)LuaAPI.lua_tonumber(L, 2);
                    float _y = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    LuaCSNode._Node_SetSizeXY( _tableId, _x, _y );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetSizeX_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    float _x = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    LuaCSNode._Node_SetSizeX( _tableId, _x );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_IsSprite_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    
                        var gen_ret = LuaCSNode._Node_IsSprite( _tableId );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetSprite_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable(L, 1, (NodeId)default)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    int _texId = LuaAPI.xlua_tointeger(L, 2);
                    
                    LuaCSNode._Node_SetSprite( _tableId, _texId );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable(L, 1, (NodeId)default)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    int _texId = LuaAPI.xlua_tointeger(L, 2);
                    int _spriteId = LuaAPI.xlua_tointeger(L, 3);
                    
                    LuaCSNode._Node_SetSprite( _tableId, _texId, _spriteId );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to LuaCSNode._Node_SetSprite!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_GetBounds_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _nodeId;translator.Get(L, 1, out _nodeId);
                    UnityEngine.Vector2 _min;
                    UnityEngine.Vector2 _max;
                    
                    LuaCSNode._Node_GetBounds( _nodeId, out _min, out _max );
                    translator.Push(L, _min);
                        
                    translator.Push(L, _max);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_GetWorldBounds_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _nodeId;translator.Get(L, 1, out _nodeId);
                    UnityEngine.Vector2 _min;
                    UnityEngine.Vector2 _max;
                    
                    LuaCSNode._Node_GetWorldBounds( _nodeId, out _min, out _max );
                    translator.Push(L, _min);
                        
                    translator.Push(L, _max);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_CopySpriteTo_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    NodeId _tgtid;translator.Get(L, 2, out _tgtid);
                    
                    LuaCSNode._Node_CopySpriteTo( _tableId, _tgtid );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetNativeSize_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    
                    LuaCSNode._Node_SetNativeSize( _tableId );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetKeepAspectRatio_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    bool _keep = LuaAPI.lua_toboolean(L, 2);
                    
                    LuaCSNode._Node_SetKeepAspectRatio( _tableId, _keep );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_GetKeepAspectRatio_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    
                        var gen_ret = LuaCSNode._Node_GetKeepAspectRatio( _tableId );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetSpriteSizeXY_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    float _width = (float)LuaAPI.lua_tonumber(L, 2);
                    float _height = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    LuaCSNode._Node_SetSpriteSizeXY( _tableId, _width, _height );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetSpriteSizeVec_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    
                    LuaCSNode._Node_SetSpriteSizeVec( _tableId, _size );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_GetSpriteSize_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    
                        var gen_ret = LuaCSNode._Node_GetSpriteSize( _tableId );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetText_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    string _text = LuaAPI.lua_tostring(L, 2);
                    
                    LuaCSNode._Node_SetText( _tableId, _text );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_GetText_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    
                        var gen_ret = LuaCSNode._Node_GetText( _tableId );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_GetWorldRotation_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    
                        var gen_ret = LuaCSNode._Node_GetWorldRotation( _tableId );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetWorldRotation_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    float _target = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    LuaCSNode._Node_SetWorldRotation( _tableId, _target );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_GetRotation_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    
                        var gen_ret = LuaCSNode._Node_GetRotation( _tableId );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetRotation_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    float _target = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    LuaCSNode._Node_SetRotation( _tableId, _target );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_GetWorldPosition_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    
                        var gen_ret = LuaCSNode._Node_GetWorldPosition( _tableId );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_GetPositionXY_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    float _x;
                    float _y;
                    
                    LuaCSNode._Node_GetPositionXY( _tableId, out _x, out _y );
                    LuaAPI.lua_pushnumber(L, _x);
                        
                    LuaAPI.lua_pushnumber(L, _y);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_GetWorldPositionXY_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    float _x;
                    float _y;
                    
                    LuaCSNode._Node_GetWorldPositionXY( _tableId, out _x, out _y );
                    LuaAPI.lua_pushnumber(L, _x);
                        
                    LuaAPI.lua_pushnumber(L, _y);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetWorldPositionXY_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    float _x = (float)LuaAPI.lua_tonumber(L, 2);
                    float _y = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    LuaCSNode._Node_SetWorldPositionXY( _tableId, _x, _y );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_GetPosition_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    
                        var gen_ret = LuaCSNode._Node_GetPosition( _tableId );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetPositionXY_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    float _x = (float)LuaAPI.lua_tonumber(L, 2);
                    float _y = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    LuaCSNode._Node_SetPositionXY( _tableId, _x, _y );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_GetScaleXY_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    float _x;
                    float _y;
                    
                    LuaCSNode._Node_GetScaleXY( _tableId, out _x, out _y );
                    LuaAPI.lua_pushnumber(L, _x);
                        
                    LuaAPI.lua_pushnumber(L, _y);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetScaleXY_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    float _x = (float)LuaAPI.lua_tonumber(L, 2);
                    float _y = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    LuaCSNode._Node_SetScaleXY( _tableId, _x, _y );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetScaleX_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    float _x = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    LuaCSNode._Node_SetScaleX( _tableId, _x );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetWorldScaleXY_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    float _x = (float)LuaAPI.lua_tonumber(L, 2);
                    float _y = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    LuaCSNode._Node_SetWorldScaleXY( _tableId, _x, _y );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetWorldScaleX_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    float _x = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    LuaCSNode._Node_SetWorldScaleX( _tableId, _x );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_GetWorldScaleXY_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    float _x;
                    float _y;
                    
                    LuaCSNode._Node_GetWorldScaleXY( _tableId, out _x, out _y );
                    LuaAPI.lua_pushnumber(L, _x);
                        
                    LuaAPI.lua_pushnumber(L, _y);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_UpdateAutoPosition_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    
                    LuaCSNode._Node_UpdateAutoPosition( _tableId );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetAnchoredPositionXY_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    float _x = (float)LuaAPI.lua_tonumber(L, 2);
                    float _y = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    LuaCSNode._Node_SetAnchoredPositionXY( _tableId, _x, _y );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_GetAnchoredPosition_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    
                        var gen_ret = LuaCSNode._Node_GetAnchoredPosition( _tableId );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetAnchoredPositionVec_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    UnityEngine.Vector2 _position;translator.Get(L, 2, out _position);
                    
                    LuaCSNode._Node_SetAnchoredPositionVec( _tableId, _position );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_WorldToLocalPointXY_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    float _x = (float)LuaAPI.lua_tonumber(L, 2);
                    float _y = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        var gen_ret = LuaCSNode._Node_WorldToLocalPointXY( _tableId, _x, _y );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_LocalToWorldPointXY_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    float _x = (float)LuaAPI.lua_tonumber(L, 2);
                    float _y = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        var gen_ret = LuaCSNode._Node_LocalToWorldPointXY( _tableId, _x, _y );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_WorldToLocalVectorXY_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    float _x = (float)LuaAPI.lua_tonumber(L, 2);
                    float _y = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        var gen_ret = LuaCSNode._Node_WorldToLocalVectorXY( _tableId, _x, _y );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_LocalToWorldVectorXY_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    float _x = (float)LuaAPI.lua_tonumber(L, 2);
                    float _y = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        var gen_ret = LuaCSNode._Node_LocalToWorldVectorXY( _tableId, _x, _y );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_WorldToLocalLength_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    float _length = (float)LuaAPI.lua_tonumber(L, 2);
                    
                        var gen_ret = LuaCSNode._Node_WorldToLocalLength( _tableId, _length );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_LocalToWorldLength_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    float _length = (float)LuaAPI.lua_tonumber(L, 2);
                    
                        var gen_ret = LuaCSNode._Node_LocalToWorldLength( _tableId, _length );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_ScreenToUIPos_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    UnityEngine.Vector2 _pos;translator.Get(L, 2, out _pos);
                    
                    LuaCSNode._Node_ScreenToUIPos( _tableId, _pos );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_UIToScreenPos_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    UnityEngine.Vector2 _pos;translator.Get(L, 2, out _pos);
                    
                        var gen_ret = LuaCSNode._Node_UIToScreenPos( _tableId, _pos );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_Tremble_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    float _strength = (float)LuaAPI.lua_tonumber(L, 2);
                    float _duration = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    LuaCSNode._Node_Tremble( _tableId, _strength, _duration );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_GetFillAmount_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    
                        var gen_ret = LuaCSNode._Node_GetFillAmount( _tableId );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetFillAmount_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    float _fill = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    LuaCSNode._Node_SetFillAmount( _tableId, _fill );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_HasTween_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    int _nameid = LuaAPI.xlua_tointeger(L, 2);
                    
                        var gen_ret = LuaCSNode._Node_HasTween( _tableId, _nameid );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetTweenDuration_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& translator.Assignable(L, 1, (NodeId)default)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    int _nameid = LuaAPI.xlua_tointeger(L, 2);
                    float _duration = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    LuaCSNode._Node_SetTweenDuration( _tableId, _nameid, _duration );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable(L, 1, (NodeId)default)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    int _nameid = LuaAPI.xlua_tointeger(L, 2);
                    
                    LuaCSNode._Node_SetTweenDuration( _tableId, _nameid );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to LuaCSNode._Node_SetTweenDuration!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_Tween_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    int _nameid = LuaAPI.xlua_tointeger(L, 2);
                    bool _restart = LuaAPI.lua_toboolean(L, 3);
                    bool _backward = LuaAPI.lua_toboolean(L, 4);
                    
                    LuaCSNode._Node_Tween( _tableId, _nameid, _restart, _backward );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetTweenProgress_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    int _nameid = LuaAPI.xlua_tointeger(L, 2);
                    float _ratio = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    LuaCSNode._Node_SetTweenProgress( _tableId, _nameid, _ratio );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetTweenControl_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    int _nameid = LuaAPI.xlua_tointeger(L, 2);
                    bool _control = LuaAPI.lua_toboolean(L, 3);
                    
                    LuaCSNode._Node_SetTweenControl( _tableId, _nameid, _control );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_GetVelocityXY_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    float _x;
                    float _y;
                    
                    LuaCSNode._Node_GetVelocityXY( _tableId, out _x, out _y );
                    LuaAPI.lua_pushnumber(L, _x);
                        
                    LuaAPI.lua_pushnumber(L, _y);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetVelocityXY_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    float _x = (float)LuaAPI.lua_tonumber(L, 2);
                    float _y = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    LuaCSNode._Node_SetVelocityXY( _tableId, _x, _y );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_GetAngularVelocity_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    
                        var gen_ret = LuaCSNode._Node_GetAngularVelocity( _tableId );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetAngularVelocity_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    float _av = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    LuaCSNode._Node_SetAngularVelocity( _tableId, _av );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_GetSpeed_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    
                        var gen_ret = LuaCSNode._Node_GetSpeed( _tableId );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetSpeed_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    float _target = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    LuaCSNode._Node_SetSpeed( _tableId, _target );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_GetVelocityAngle_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    
                        var gen_ret = LuaCSNode._Node_GetVelocityAngle( _tableId );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetVelocityAngle_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    float _a = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    LuaCSNode._Node_SetVelocityAngle( _tableId, _a );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_PlayFX_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    
                    LuaCSNode._Node_PlayFX( _tableId );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_StopFX_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    
                    LuaCSNode._Node_StopFX( _tableId );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_BurstFX_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    
                    LuaCSNode._Node_BurstFX( _tableId );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetVFXFloat_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    int _name = LuaAPI.xlua_tointeger(L, 2);
                    float _value = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    LuaCSNode._Node_SetVFXFloat( _tableId, _name, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetVFXVec2_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& translator.Assignable(L, 1, (NodeId)default)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    int _name = LuaAPI.xlua_tointeger(L, 2);
                    float _x = (float)LuaAPI.lua_tonumber(L, 3);
                    float _y = (float)LuaAPI.lua_tonumber(L, 4);
                    
                    LuaCSNode._Node_SetVFXVec2( _tableId, _name, _x, _y );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable(L, 1, (NodeId)default)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable(L, 3, (UnityEngine.Vector2)default)) 
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    int _name = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Vector2 _value;translator.Get(L, 3, out _value);
                    
                    LuaCSNode._Node_SetVFXVec2( _tableId, _name, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to LuaCSNode._Node_SetVFXVec2!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetVFXVec3_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 5&& translator.Assignable(L, 1, (NodeId)default)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    int _name = LuaAPI.xlua_tointeger(L, 2);
                    float _x = (float)LuaAPI.lua_tonumber(L, 3);
                    float _y = (float)LuaAPI.lua_tonumber(L, 4);
                    float _z = (float)LuaAPI.lua_tonumber(L, 5);
                    
                    LuaCSNode._Node_SetVFXVec3( _tableId, _name, _x, _y, _z );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable(L, 1, (NodeId)default)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable(L, 3, (UnityEngine.Vector3)default)) 
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    int _name = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Vector3 _value;translator.Get(L, 3, out _value);
                    
                    LuaCSNode._Node_SetVFXVec3( _tableId, _name, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to LuaCSNode._Node_SetVFXVec3!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetVFXVec4_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 6&& translator.Assignable(L, 1, (NodeId)default)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    int _name = LuaAPI.xlua_tointeger(L, 2);
                    float _x = (float)LuaAPI.lua_tonumber(L, 3);
                    float _y = (float)LuaAPI.lua_tonumber(L, 4);
                    float _z = (float)LuaAPI.lua_tonumber(L, 5);
                    float _w = (float)LuaAPI.lua_tonumber(L, 6);
                    
                    LuaCSNode._Node_SetVFXVec4( _tableId, _name, _x, _y, _z, _w );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable(L, 1, (NodeId)default)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable(L, 3, (UnityEngine.Vector4)default)) 
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    int _name = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Vector4 _value;translator.Get(L, 3, out _value);
                    
                    LuaCSNode._Node_SetVFXVec4( _tableId, _name, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to LuaCSNode._Node_SetVFXVec4!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetVFXColor_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 6&& translator.Assignable(L, 1, (NodeId)default)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    int _name = LuaAPI.xlua_tointeger(L, 2);
                    float _r = (float)LuaAPI.lua_tonumber(L, 3);
                    float _g = (float)LuaAPI.lua_tonumber(L, 4);
                    float _b = (float)LuaAPI.lua_tonumber(L, 5);
                    float _a = (float)LuaAPI.lua_tonumber(L, 6);
                    
                    LuaCSNode._Node_SetVFXColor( _tableId, _name, _r, _g, _b, _a );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable(L, 1, (NodeId)default)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable(L, 3, (UnityEngine.Color)default)) 
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    int _name = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Color _value;translator.Get(L, 3, out _value);
                    
                    LuaCSNode._Node_SetVFXColor( _tableId, _name, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to LuaCSNode._Node_SetVFXColor!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetVFXRGB_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 5&& translator.Assignable(L, 1, (NodeId)default)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    int _name = LuaAPI.xlua_tointeger(L, 2);
                    float _r = (float)LuaAPI.lua_tonumber(L, 3);
                    float _g = (float)LuaAPI.lua_tonumber(L, 4);
                    float _b = (float)LuaAPI.lua_tonumber(L, 5);
                    
                    LuaCSNode._Node_SetVFXRGB( _tableId, _name, _r, _g, _b );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable(L, 1, (NodeId)default)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable(L, 3, (UnityEngine.Color)default)) 
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    int _name = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Color _value;translator.Get(L, 3, out _value);
                    
                    LuaCSNode._Node_SetVFXRGB( _tableId, _name, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to LuaCSNode._Node_SetVFXRGB!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetVFXAlpha_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    int _name = LuaAPI.xlua_tointeger(L, 2);
                    float _alpha = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    LuaCSNode._Node_SetVFXAlpha( _tableId, _name, _alpha );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_GetZ_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    
                        var gen_ret = LuaCSNode._Node_GetZ( _tableId );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetZ_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    float _z = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    LuaCSNode._Node_SetZ( _tableId, _z );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_GetWorldZ_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    
                        var gen_ret = LuaCSNode._Node_GetWorldZ( _tableId );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__Node_SetWorldZ_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    NodeId _tableId;translator.Get(L, 1, out _tableId);
                    float _z = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    LuaCSNode._Node_SetWorldZ( _tableId, _z );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
