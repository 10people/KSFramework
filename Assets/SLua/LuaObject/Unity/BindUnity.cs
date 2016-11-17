﻿using System;
using System.Collections.Generic;
namespace SLua {
	[LuaBinder(0)]
	public class BindUnity {
		public static Action<IntPtr>[] GetBindList() {
			Action<IntPtr>[] list= {
				Lua_UnityEngine_AsyncOperation.reg,
				Lua_UnityEngine_AssetBundleCreateRequest.reg,
				Lua_UnityEngine_AssetBundleRequest.reg,
				Lua_UnityEngine_Object.reg,
				Lua_UnityEngine_AssetBundle.reg,
				Lua_UnityEngine_AssetBundleManifest.reg,
				Lua_UnityEngine_SendMessageOptions.reg,
				Lua_UnityEngine_PrimitiveType.reg,
				Lua_UnityEngine_Space.reg,
				Lua_UnityEngine_RuntimePlatform.reg,
				Lua_UnityEngine_SystemLanguage.reg,
				Lua_UnityEngine_LogType.reg,
				Lua_UnityEngine_DeviceType.reg,
				Lua_UnityEngine_SystemInfo.reg,
				Lua_UnityEngine_WaitForSeconds.reg,
				Lua_UnityEngine_WaitForFixedUpdate.reg,
				Lua_UnityEngine_WaitForEndOfFrame.reg,
				Lua_UnityEngine_CustomYieldInstruction.reg,
				Lua_UnityEngine_WaitWhile.reg,
				Lua_UnityEngine_WaitUntil.reg,
				Lua_UnityEngine_ScriptableObject.reg,
				Lua_UnityEngine_ThreadPriority.reg,
				Lua_UnityEngine_Profiler.reg,
				Lua_UnityEngine_Caching.reg,
				Lua_UnityEngine_CrashReport.reg,
				Lua_UnityEngine_Component.reg,
				Lua_UnityEngine_OcclusionArea.reg,
				Lua_UnityEngine_OcclusionPortal.reg,
				Lua_UnityEngine_RenderSettings.reg,
				Lua_UnityEngine_QualitySettings.reg,
				Lua_UnityEngine_MeshFilter.reg,
				Lua_UnityEngine_CombineInstance.reg,
				Lua_UnityEngine_BoneWeight.reg,
				Lua_UnityEngine_Renderer.reg,
				Lua_UnityEngine_SkinnedMeshRenderer.reg,
				Lua_UnityEngine_Flare.reg,
				Lua_UnityEngine_Behaviour.reg,
				Lua_UnityEngine_LensFlare.reg,
				Lua_UnityEngine_Projector.reg,
				Lua_UnityEngine_Skybox.reg,
				Lua_UnityEngine_TrailRenderer.reg,
				Lua_UnityEngine_LineRenderer.reg,
				Lua_UnityEngine_MaterialPropertyBlock.reg,
				Lua_UnityEngine_Graphics.reg,
				Lua_UnityEngine_LightmapData.reg,
				Lua_UnityEngine_LightmapsModeLegacy.reg,
				Lua_UnityEngine_LightProbes.reg,
				Lua_UnityEngine_LightmapSettings.reg,
				Lua_UnityEngine_GeometryUtility.reg,
				Lua_UnityEngine_Screen.reg,
				Lua_UnityEngine_SleepTimeout.reg,
				Lua_UnityEngine_GL.reg,
				Lua_UnityEngine_MeshRenderer.reg,
				Lua_UnityEngine_StaticBatchingUtility.reg,
				Lua_UnityEngine_ImageEffectTransformsToLDR.reg,
				Lua_UnityEngine_ImageEffectAllowedInSceneView.reg,
				Lua_UnityEngine_ImageEffectOpaque.reg,
				Lua_UnityEngine_RectOffset.reg,
				Lua_UnityEngine_Texture.reg,
				Lua_UnityEngine_Texture2D.reg,
				Lua_UnityEngine_Cubemap.reg,
				Lua_UnityEngine_Texture3D.reg,
				Lua_UnityEngine_Texture2DArray.reg,
				Lua_UnityEngine_SparseTexture.reg,
				Lua_UnityEngine_RenderTexture.reg,
				Lua_UnityEngine_ReflectionProbe.reg,
				Lua_UnityEngine_Rendering_GraphicsSettings.reg,
				Lua_UnityEngine_LODFadeMode.reg,
				Lua_UnityEngine_LOD.reg,
				Lua_UnityEngine_LODGroup.reg,
				Lua_UnityEngine_BoundingSphere.reg,
				Lua_UnityEngine_CullingGroupEvent.reg,
				Lua_UnityEngine_CullingGroup.reg,
				Lua_UnityEngine_GradientColorKey.reg,
				Lua_UnityEngine_GradientAlphaKey.reg,
				Lua_UnityEngine_Gradient.reg,
				Lua_UnityEngine_FlareLayer.reg,
				Lua_UnityEngine_LayerMask.reg,
				Lua_UnityEngine_LightProbeGroup.reg,
				Lua_UnityEngine_LightProbeProxyVolume.reg,
				Lua_UnityEngine_LightProbeProxyVolume_ResolutionMode.reg,
				Lua_UnityEngine_LightProbeProxyVolume_BoundingBoxMode.reg,
				Lua_UnityEngine_LightProbeProxyVolume_ProbePositionMode.reg,
				Lua_UnityEngine_LightProbeProxyVolume_RefreshMode.reg,
				Lua_UnityEngine_Vector2.reg,
				Lua_UnityEngine_Vector3.reg,
				Lua_UnityEngine_Color32.reg,
				Lua_UnityEngine_Quaternion.reg,
				Lua_UnityEngine_Rect.reg,
				Lua_UnityEngine_Matrix4x4.reg,
				Lua_UnityEngine_Bounds.reg,
				Lua_UnityEngine_Vector4.reg,
				Lua_UnityEngine_Ray.reg,
				Lua_UnityEngine_Ray2D.reg,
				Lua_UnityEngine_Plane.reg,
				Lua_UnityEngine_Mathf.reg,
				Lua_UnityEngine_Keyframe.reg,
				Lua_UnityEngine_AnimationCurve.reg,
				Lua_UnityEngine_Mesh.reg,
				Lua_UnityEngine_DrivenTransformProperties.reg,
				Lua_UnityEngine_DrivenRectTransformTracker.reg,
				Lua_UnityEngine_Transform.reg,
				Lua_UnityEngine_RectTransform.reg,
				Lua_UnityEngine_RectTransform_Edge.reg,
				Lua_UnityEngine_RectTransform_Axis.reg,
				Lua_UnityEngine_Rendering_CommandBuffer.reg,
				Lua_UnityEngine_ResourceRequest.reg,
				Lua_UnityEngine_Resources.reg,
				Lua_UnityEngine_TextAsset.reg,
				Lua_UnityEngine_Security.reg,
				Lua_UnityEngine_Shader.reg,
				Lua_UnityEngine_Material.reg,
				Lua_UnityEngine_SortingLayer.reg,
				Lua_UnityEngine_Rendering_SphericalHarmonicsL2.reg,
				Lua_UnityEngine_ProceduralProcessorUsage.reg,
				Lua_UnityEngine_ProceduralCacheSize.reg,
				Lua_UnityEngine_ProceduralLoadingBehavior.reg,
				Lua_UnityEngine_ProceduralPropertyType.reg,
				Lua_UnityEngine_ProceduralOutputType.reg,
				Lua_UnityEngine_ProceduralPropertyDescription.reg,
				Lua_UnityEngine_ProceduralMaterial.reg,
				Lua_UnityEngine_ProceduralTexture.reg,
				Lua_UnityEngine_SpriteAlignment.reg,
				Lua_UnityEngine_SpritePackingMode.reg,
				Lua_UnityEngine_SpritePackingRotation.reg,
				Lua_UnityEngine_SpriteMeshType.reg,
				Lua_UnityEngine_Sprite.reg,
				Lua_UnityEngine_SpriteRenderer.reg,
				Lua_UnityEngine_Sprites_DataUtility.reg,
				Lua_UnityEngine_Hash128.reg,
				Lua_UnityEngine_WWW.reg,
				Lua_UnityEngine_WWWForm.reg,
				Lua_UnityEngine_UnityEventQueueSystem.reg,
				Lua_UnityEngine_ColorUtility.reg,
				Lua_UnityEngine_Application.reg,
				Lua_UnityEngine_UserAuthorization.reg,
				Lua_UnityEngine_ApplicationInstallMode.reg,
				Lua_UnityEngine_ApplicationSandboxType.reg,
				Lua_UnityEngine_Camera.reg,
				Lua_UnityEngine_ComputeShader.reg,
				Lua_UnityEngine_ComputeBuffer.reg,
				Lua_UnityEngine_Debug.reg,
				Lua_UnityEngine_Display.reg,
				Lua_UnityEngine_MonoBehaviour.reg,
				Lua_UnityEngine_TouchPhase.reg,
				Lua_UnityEngine_IMECompositionMode.reg,
				Lua_UnityEngine_TouchType.reg,
				Lua_UnityEngine_Touch.reg,
				Lua_UnityEngine_DeviceOrientation.reg,
				Lua_UnityEngine_AccelerationEvent.reg,
				Lua_UnityEngine_Gyroscope.reg,
				Lua_UnityEngine_LocationInfo.reg,
				Lua_UnityEngine_LocationServiceStatus.reg,
				Lua_UnityEngine_LocationService.reg,
				Lua_UnityEngine_Compass.reg,
				Lua_UnityEngine_Input.reg,
				Lua_UnityEngine_HideFlags.reg,
				Lua_UnityEngine_Light.reg,
				Lua_UnityEngine_GameObject.reg,
				Lua_UnityEngine_Diagnostics_PlayerConnection.reg,
				Lua_UnityEngine_Time.reg,
				Lua_UnityEngine_Random.reg,
				Lua_UnityEngine_Random_State.reg,
				Lua_UnityEngine_PlayerPrefsException.reg,
				Lua_UnityEngine_PlayerPrefs.reg,
				Lua_UnityEngine_Motion.reg,
				Lua_UnityEngine_Windows_Speech_PhraseRecognitionSystem.reg,
				Lua_UnityEngine_Windows_Speech_PhraseRecognizer.reg,
				Lua_UnityEngine_Windows_Speech_DictationRecognizer.reg,
				Lua_UnityEngine_BillboardAsset.reg,
				Lua_UnityEngine_BillboardRenderer.reg,
				Lua_UnityEngine_Experimental_Director_DirectorUpdateMode.reg,
				Lua_UnityEngine_Experimental_Director_DirectorPlayer.reg,
				Lua_UnityEngine_Experimental_Director_PlayState.reg,
				Lua_UnityEngine_Experimental_Director_Playable.reg,
				Lua_UnityEngine_Experimental_Director_GenericMixerPlayable.reg,
				Lua_UnityEngine_Experimental_Director_ScriptPlayable.reg,
				Lua_UnityEngine_SceneManagement_LoadSceneMode.reg,
				Lua_UnityEngine_SceneManagement_SceneManager.reg,
				Lua_UnityEngine_SceneManagement_Scene.reg,
				Lua_UnityEngine_WindZoneMode.reg,
				Lua_UnityEngine_WindZone.reg,
				Lua_UnityEngine_DynamicGI.reg,
				Lua_UnityEngine_UVChannelFlags.reg,
				Lua_UnityEngine_ParticleSystemRenderMode.reg,
				Lua_UnityEngine_ParticleSystemSortMode.reg,
				Lua_UnityEngine_ParticleSystemCollisionQuality.reg,
				Lua_UnityEngine_ParticleSystemRenderSpace.reg,
				Lua_UnityEngine_ParticleSystemEmissionType.reg,
				Lua_UnityEngine_ParticleSystemCurveMode.reg,
				Lua_UnityEngine_ParticleSystemGradientMode.reg,
				Lua_UnityEngine_ParticleSystemShapeType.reg,
				Lua_UnityEngine_ParticleSystemMeshShapeType.reg,
				Lua_UnityEngine_ParticleSystemAnimationType.reg,
				Lua_UnityEngine_ParticleSystemCollisionType.reg,
				Lua_UnityEngine_ParticleSystemCollisionMode.reg,
				Lua_UnityEngine_ParticleSystemOverlapAction.reg,
				Lua_UnityEngine_ParticleSystemSimulationSpace.reg,
				Lua_UnityEngine_ParticleSystemScalingMode.reg,
				Lua_UnityEngine_ParticleSystemInheritVelocityMode.reg,
				Lua_UnityEngine_ParticleSystem.reg,
				Lua_UnityEngine_ParticleSystem_Burst.reg,
				Lua_UnityEngine_ParticleSystem_MinMaxCurve.reg,
				Lua_UnityEngine_ParticleSystem_MinMaxGradient.reg,
				Lua_UnityEngine_ParticleSystem_EmissionModule.reg,
				Lua_UnityEngine_ParticleSystem_ShapeModule.reg,
				Lua_UnityEngine_ParticleSystem_VelocityOverLifetimeModule.reg,
				Lua_UnityEngine_ParticleSystem_LimitVelocityOverLifetimeModule.reg,
				Lua_UnityEngine_ParticleSystem_InheritVelocityModule.reg,
				Lua_UnityEngine_ParticleSystem_ForceOverLifetimeModule.reg,
				Lua_UnityEngine_ParticleSystem_ColorOverLifetimeModule.reg,
				Lua_UnityEngine_ParticleSystem_ColorBySpeedModule.reg,
				Lua_UnityEngine_ParticleSystem_SizeOverLifetimeModule.reg,
				Lua_UnityEngine_ParticleSystem_SizeBySpeedModule.reg,
				Lua_UnityEngine_ParticleSystem_RotationOverLifetimeModule.reg,
				Lua_UnityEngine_ParticleSystem_RotationBySpeedModule.reg,
				Lua_UnityEngine_ParticleSystem_ExternalForcesModule.reg,
				Lua_UnityEngine_ParticleSystem_CollisionModule.reg,
				Lua_UnityEngine_ParticleSystem_TriggerModule.reg,
				Lua_UnityEngine_ParticleSystem_SubEmittersModule.reg,
				Lua_UnityEngine_ParticleSystem_TextureSheetAnimationModule.reg,
				Lua_UnityEngine_ParticleSystem_Particle.reg,
				Lua_UnityEngine_ParticleSystem_EmitParams.reg,
				Lua_UnityEngine_ParticleSystemRenderer.reg,
				Lua_UnityEngine_ParticleCollisionEvent.reg,
				Lua_UnityEngine_ParticlePhysicsExtensions.reg,
				Lua_UnityEngine_RigidbodyConstraints.reg,
				Lua_UnityEngine_ForceMode.reg,
				Lua_UnityEngine_JointProjectionMode.reg,
				Lua_UnityEngine_WheelFrictionCurve.reg,
				Lua_UnityEngine_SoftJointLimit.reg,
				Lua_UnityEngine_SoftJointLimitSpring.reg,
				Lua_UnityEngine_JointDrive.reg,
				Lua_UnityEngine_RigidbodyInterpolation.reg,
				Lua_UnityEngine_JointMotor.reg,
				Lua_UnityEngine_JointSpring.reg,
				Lua_UnityEngine_JointLimits.reg,
				Lua_UnityEngine_ControllerColliderHit.reg,
				Lua_UnityEngine_PhysicMaterialCombine.reg,
				Lua_UnityEngine_Collision.reg,
				Lua_UnityEngine_CollisionFlags.reg,
				Lua_UnityEngine_ClothSkinningCoefficient.reg,
				Lua_UnityEngine_QueryTriggerInteraction.reg,
				Lua_UnityEngine_Physics.reg,
				Lua_UnityEngine_WheelHit.reg,
				Lua_UnityEngine_ContactPoint.reg,
				Lua_UnityEngine_Rigidbody.reg,
				Lua_UnityEngine_Joint.reg,
				Lua_UnityEngine_HingeJoint.reg,
				Lua_UnityEngine_SpringJoint.reg,
				Lua_UnityEngine_FixedJoint.reg,
				Lua_UnityEngine_CharacterJoint.reg,
				Lua_UnityEngine_ConfigurableJointMotion.reg,
				Lua_UnityEngine_RotationDriveMode.reg,
				Lua_UnityEngine_ConfigurableJoint.reg,
				Lua_UnityEngine_ConstantForce.reg,
				Lua_UnityEngine_CollisionDetectionMode.reg,
				Lua_UnityEngine_Collider.reg,
				Lua_UnityEngine_BoxCollider.reg,
				Lua_UnityEngine_SphereCollider.reg,
				Lua_UnityEngine_MeshCollider.reg,
				Lua_UnityEngine_CapsuleCollider.reg,
				Lua_UnityEngine_WheelCollider.reg,
				Lua_UnityEngine_RaycastHit.reg,
				Lua_UnityEngine_PhysicMaterial.reg,
				Lua_UnityEngine_CharacterController.reg,
				Lua_UnityEngine_ClothSphereColliderPair.reg,
				Lua_UnityEngine_Cloth.reg,
				Lua_UnityEngine_Physics2D.reg,
				Lua_UnityEngine_RaycastHit2D.reg,
				Lua_UnityEngine_RigidbodyInterpolation2D.reg,
				Lua_UnityEngine_RigidbodySleepMode2D.reg,
				Lua_UnityEngine_CollisionDetectionMode2D.reg,
				Lua_UnityEngine_ForceMode2D.reg,
				Lua_UnityEngine_RigidbodyConstraints2D.reg,
				Lua_UnityEngine_Rigidbody2D.reg,
				Lua_UnityEngine_Collider2D.reg,
				Lua_UnityEngine_CircleCollider2D.reg,
				Lua_UnityEngine_BoxCollider2D.reg,
				Lua_UnityEngine_EdgeCollider2D.reg,
				Lua_UnityEngine_PolygonCollider2D.reg,
				Lua_UnityEngine_ContactPoint2D.reg,
				Lua_UnityEngine_Collision2D.reg,
				Lua_UnityEngine_JointLimitState2D.reg,
				Lua_UnityEngine_JointAngleLimits2D.reg,
				Lua_UnityEngine_JointTranslationLimits2D.reg,
				Lua_UnityEngine_JointMotor2D.reg,
				Lua_UnityEngine_JointSuspension2D.reg,
				Lua_UnityEngine_Joint2D.reg,
				Lua_UnityEngine_AnchoredJoint2D.reg,
				Lua_UnityEngine_SpringJoint2D.reg,
				Lua_UnityEngine_DistanceJoint2D.reg,
				Lua_UnityEngine_FrictionJoint2D.reg,
				Lua_UnityEngine_HingeJoint2D.reg,
				Lua_UnityEngine_RelativeJoint2D.reg,
				Lua_UnityEngine_SliderJoint2D.reg,
				Lua_UnityEngine_TargetJoint2D.reg,
				Lua_UnityEngine_FixedJoint2D.reg,
				Lua_UnityEngine_WheelJoint2D.reg,
				Lua_UnityEngine_PhysicsMaterial2D.reg,
				Lua_UnityEngine_PhysicsUpdateBehaviour2D.reg,
				Lua_UnityEngine_ConstantForce2D.reg,
				Lua_UnityEngine_EffectorSelection2D.reg,
				Lua_UnityEngine_EffectorForceMode2D.reg,
				Lua_UnityEngine_Effector2D.reg,
				Lua_UnityEngine_AreaEffector2D.reg,
				Lua_UnityEngine_BuoyancyEffector2D.reg,
				Lua_UnityEngine_PointEffector2D.reg,
				Lua_UnityEngine_PlatformEffector2D.reg,
				Lua_UnityEngine_SurfaceEffector2D.reg,
				Lua_UnityEngine_ObstacleAvoidanceType.reg,
				Lua_UnityEngine_NavMeshAgent.reg,
				Lua_UnityEngine_NavMeshHit.reg,
				Lua_UnityEngine_NavMeshTriangulation.reg,
				Lua_UnityEngine_NavMesh.reg,
				Lua_UnityEngine_NavMeshObstacleShape.reg,
				Lua_UnityEngine_NavMeshObstacle.reg,
				Lua_UnityEngine_NavMeshPathStatus.reg,
				Lua_UnityEngine_NavMeshPath.reg,
				Lua_UnityEngine_OffMeshLinkType.reg,
				Lua_UnityEngine_OffMeshLinkData.reg,
				Lua_UnityEngine_OffMeshLink.reg,
				Lua_UnityEngine_AudioSpeakerMode.reg,
				Lua_UnityEngine_AudioDataLoadState.reg,
				Lua_UnityEngine_AudioConfiguration.reg,
				Lua_UnityEngine_AudioSettings.reg,
				Lua_UnityEngine_AudioType.reg,
				Lua_UnityEngine_AudioCompressionFormat.reg,
				Lua_UnityEngine_AudioClipLoadType.reg,
				Lua_UnityEngine_AudioClip.reg,
				Lua_UnityEngine_AudioVelocityUpdateMode.reg,
				Lua_UnityEngine_AudioListener.reg,
				Lua_UnityEngine_AudioRolloffMode.reg,
				Lua_UnityEngine_AudioSourceCurveType.reg,
				Lua_UnityEngine_AudioSource.reg,
				Lua_UnityEngine_AudioReverbPreset.reg,
				Lua_UnityEngine_AudioReverbZone.reg,
				Lua_UnityEngine_AudioLowPassFilter.reg,
				Lua_UnityEngine_AudioHighPassFilter.reg,
				Lua_UnityEngine_AudioDistortionFilter.reg,
				Lua_UnityEngine_AudioEchoFilter.reg,
				Lua_UnityEngine_AudioChorusFilter.reg,
				Lua_UnityEngine_AudioReverbFilter.reg,
				Lua_UnityEngine_Microphone.reg,
				Lua_UnityEngine_Audio_AudioMixerUpdateMode.reg,
				Lua_UnityEngine_Audio_AudioMixer.reg,
				Lua_UnityEngine_Audio_AudioMixerSnapshot.reg,
				Lua_UnityEngine_Audio_AudioMixerGroup.reg,
				Lua_UnityEngine_WebCamFlags.reg,
				Lua_UnityEngine_WebCamDevice.reg,
				Lua_UnityEngine_WebCamTexture.reg,
				Lua_UnityEngine_AnimationClipPair.reg,
				Lua_UnityEngine_RuntimeAnimatorController.reg,
				Lua_UnityEngine_AnimatorOverrideController.reg,
				Lua_UnityEngine_WrapMode.reg,
				Lua_UnityEngine_AnimationEvent.reg,
				Lua_UnityEngine_AnimationClip.reg,
				Lua_UnityEngine_PlayMode.reg,
				Lua_UnityEngine_QueueMode.reg,
				Lua_UnityEngine_AnimationBlendMode.reg,
				Lua_UnityEngine_AnimationPlayMode.reg,
				Lua_UnityEngine_AnimationCullingType.reg,
				Lua_UnityEngine_Animation.reg,
				Lua_UnityEngine_AnimationState.reg,
				Lua_UnityEngine_AvatarTarget.reg,
				Lua_UnityEngine_AvatarIKGoal.reg,
				Lua_UnityEngine_AvatarIKHint.reg,
				Lua_UnityEngine_AnimatorControllerParameterType.reg,
				Lua_UnityEngine_AnimatorRecorderMode.reg,
				Lua_UnityEngine_AnimatorClipInfo.reg,
				Lua_UnityEngine_AnimatorCullingMode.reg,
				Lua_UnityEngine_AnimatorUpdateMode.reg,
				Lua_UnityEngine_AnimatorStateInfo.reg,
				Lua_UnityEngine_AnimatorTransitionInfo.reg,
				Lua_UnityEngine_MatchTargetWeightMask.reg,
				Lua_UnityEngine_Animator.reg,
				Lua_UnityEngine_AnimatorControllerParameter.reg,
				Lua_UnityEngine_AnimatorUtility.reg,
				Lua_UnityEngine_SkeletonBone.reg,
				Lua_UnityEngine_HumanLimit.reg,
				Lua_UnityEngine_HumanBone.reg,
				Lua_UnityEngine_HumanDescription.reg,
				Lua_UnityEngine_AvatarBuilder.reg,
				Lua_UnityEngine_HumanBodyBones.reg,
				Lua_UnityEngine_Avatar.reg,
				Lua_UnityEngine_HumanTrait.reg,
				Lua_UnityEngine_HumanPose.reg,
				Lua_UnityEngine_HumanPoseHandler.reg,
				Lua_UnityEngine_Experimental_Director_AnimatorControllerPlayable.reg,
				Lua_UnityEngine_Experimental_Director_AnimationMixerPlayable.reg,
				Lua_UnityEngine_Experimental_Director_AnimationClipPlayable.reg,
				Lua_UnityEngine_Experimental_Director_AnimationPlayable.reg,
				Lua_UnityEngine_Experimental_Director_CustomAnimationPlayable.reg,
				Lua_UnityEngine_TextGenerationSettings.reg,
				Lua_UnityEngine_TextAnchor.reg,
				Lua_UnityEngine_HorizontalWrapMode.reg,
				Lua_UnityEngine_VerticalWrapMode.reg,
				Lua_UnityEngine_TextMesh.reg,
				Lua_UnityEngine_CharacterInfo.reg,
				Lua_UnityEngine_Font.reg,
				Lua_UnityEngine_UICharInfo.reg,
				Lua_UnityEngine_UILineInfo.reg,
				Lua_UnityEngine_UIVertex.reg,
				Lua_UnityEngine_RenderMode.reg,
				Lua_UnityEngine_Canvas.reg,
				Lua_UnityEngine_CanvasGroup.reg,
				Lua_UnityEngine_CanvasRenderer.reg,
				Lua_UnityEngine_RectTransformUtility.reg,
				Lua_UnityEngine_Event.reg,
				Lua_UnityEngine_KeyCode.reg,
				Lua_UnityEngine_ScaleMode.reg,
				Lua_UnityEngine_ImagePosition.reg,
				Lua_UnityEngine_FocusType.reg,
				Lua_UnityEngine_JsonUtility.reg,
				Lua_UnityEngine_Analytics_Gender.reg,
				Lua_UnityEngine_Analytics_AnalyticsResult.reg,
				Lua_UnityEngine_Analytics_Analytics.reg,
				Lua_UnityEngine_VR_VRNode.reg,
				Lua_UnityEngine_VR_VRSettings.reg,
				Lua_UnityEngine_VR_VRDevice.reg,
				Lua_UnityEngine_VR_VRStats.reg,
				Lua_UnityEngine_VR_InputTracking.reg,
				Lua_UnityEngine_Color.reg,
				Lua_UnityEngine_Resolution.reg,
				Lua_UnityEngine_RenderBuffer.reg,
				Lua_UnityEngine_RenderTargetSetup.reg,
				Lua_UnityEngine_RenderingPath.reg,
				Lua_UnityEngine_TransparencySortMode.reg,
				Lua_UnityEngine_StereoTargetEyeMask.reg,
				Lua_UnityEngine_CameraType.reg,
				Lua_UnityEngine_ComputeBufferType.reg,
				Lua_UnityEngine_LightType.reg,
				Lua_UnityEngine_LightRenderMode.reg,
				Lua_UnityEngine_LightShadows.reg,
				Lua_UnityEngine_LightShadowResolution.reg,
				Lua_UnityEngine_FogMode.reg,
				Lua_UnityEngine_ShadowProjection.reg,
				Lua_UnityEngine_ShadowResolution.reg,
				Lua_UnityEngine_CameraClearFlags.reg,
				Lua_UnityEngine_DepthTextureMode.reg,
				Lua_UnityEngine_TexGenMode.reg,
				Lua_UnityEngine_AnisotropicFiltering.reg,
				Lua_UnityEngine_BlendWeights.reg,
				Lua_UnityEngine_MeshTopology.reg,
				Lua_UnityEngine_SkinQuality.reg,
				Lua_UnityEngine_ColorSpace.reg,
				Lua_UnityEngine_ScreenOrientation.reg,
				Lua_UnityEngine_FilterMode.reg,
				Lua_UnityEngine_TextureWrapMode.reg,
				Lua_UnityEngine_NPOTSupport.reg,
				Lua_UnityEngine_TextureFormat.reg,
				Lua_UnityEngine_CubemapFace.reg,
				Lua_UnityEngine_RenderTextureFormat.reg,
				Lua_UnityEngine_RenderTextureReadWrite.reg,
				Lua_UnityEngine_LightmapsMode.reg,
				Lua_UnityEngine_MaterialGlobalIlluminationFlags.reg,
				Lua_UnityEngine_Rendering_OpaqueSortMode.reg,
				Lua_UnityEngine_Rendering_RenderQueue.reg,
				Lua_UnityEngine_Rendering_RenderBufferLoadAction.reg,
				Lua_UnityEngine_Rendering_RenderBufferStoreAction.reg,
				Lua_UnityEngine_Rendering_BlendMode.reg,
				Lua_UnityEngine_Rendering_BlendOp.reg,
				Lua_UnityEngine_Rendering_CompareFunction.reg,
				Lua_UnityEngine_Rendering_CullMode.reg,
				Lua_UnityEngine_Rendering_ColorWriteMask.reg,
				Lua_UnityEngine_Rendering_StencilOp.reg,
				Lua_UnityEngine_Rendering_AmbientMode.reg,
				Lua_UnityEngine_Rendering_DefaultReflectionMode.reg,
				Lua_UnityEngine_Rendering_ReflectionCubemapCompression.reg,
				Lua_UnityEngine_Rendering_CameraEvent.reg,
				Lua_UnityEngine_Rendering_LightEvent.reg,
				Lua_UnityEngine_Rendering_BuiltinRenderTextureType.reg,
				Lua_UnityEngine_Rendering_PassType.reg,
				Lua_UnityEngine_Rendering_ShadowCastingMode.reg,
				Lua_UnityEngine_Rendering_GraphicsDeviceType.reg,
				Lua_UnityEngine_Rendering_ShaderHardwareTier.reg,
				Lua_UnityEngine_Rendering_RenderTargetIdentifier.reg,
				Lua_UnityEngine_Rendering_ReflectionProbeUsage.reg,
				Lua_UnityEngine_Rendering_ReflectionProbeType.reg,
				Lua_UnityEngine_Rendering_ReflectionProbeClearFlags.reg,
				Lua_UnityEngine_Rendering_ReflectionProbeMode.reg,
				Lua_UnityEngine_Rendering_ReflectionProbeBlendInfo.reg,
				Lua_UnityEngine_Rendering_ReflectionProbeRefreshMode.reg,
				Lua_UnityEngine_Rendering_ReflectionProbeTimeSlicingMode.reg,
				Lua_UnityEngine_Rendering_ShadowSamplingMode.reg,
				Lua_UnityEngine_Rendering_LightProbeUsage.reg,
				Lua_UnityEngine_Rendering_BuiltinShaderType.reg,
				Lua_UnityEngine_Rendering_BuiltinShaderMode.reg,
				Lua_UnityEngine_Rendering_TextureDimension.reg,
				Lua_UnityEngine_Rendering_CopyTextureSupport.reg,
				Lua_JetBrains_Annotations_ImplicitUseKindFlags.reg,
				Lua_JetBrains_Annotations_ImplicitUseTargetFlags.reg,
				Lua_UnityEngine_RuntimeInitializeLoadType.reg,
				Lua_UnityEngine_StackTraceUtility.reg,
				Lua_UnityEngine_UnityException.reg,
				Lua_UnityEngine_MissingComponentException.reg,
				Lua_UnityEngine_UnassignedReferenceException.reg,
				Lua_UnityEngine_MissingReferenceException.reg,
				Lua_UnityEngine_StateMachineBehaviour.reg,
				Lua_UnityEngine_StackTraceLogType.reg,
				Lua_UnityEngine_Events_PersistentListenerMode.reg,
				Lua_UnityEngine_Events_UnityEventCallState.reg,
				Lua_UnityEngine_Events_UnityEventBase.reg,
				Lua_UnityEngine_Events_UnityEvent.reg,
				Lua_UnityEngine_WaitForSecondsRealtime.reg,
				Lua_UnityEngine_Assertions_Assert.reg,
				Lua_UnityEngine_Assertions_AssertionException.reg,
				Lua_UnityEngine_Assertions_Comparers_FloatComparer.reg,
				Lua_UnityEngine_Experimental_Director_FrameData.reg,
				Lua_UnityEngine_Logger.reg,
				Lua_UnityEngine_Windows_Speech_ConfidenceLevel.reg,
				Lua_UnityEngine_Windows_Speech_SpeechSystemStatus.reg,
				Lua_UnityEngine_Windows_Speech_SpeechError.reg,
				Lua_UnityEngine_Windows_Speech_DictationTopicConstraint.reg,
				Lua_UnityEngine_Windows_Speech_DictationCompletionCause.reg,
				Lua_UnityEngine_Windows_Speech_SemanticMeaning.reg,
				Lua_UnityEngine_Windows_Speech_PhraseRecognizedEventArgs.reg,
				Lua_UnityEngine_Windows_Speech_KeywordRecognizer.reg,
				Lua_UnityEngine_Windows_Speech_GrammarRecognizer.reg,
			};
			return list;
		}
	}
}