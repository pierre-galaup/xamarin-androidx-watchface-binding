# xamarin-androidx-watchface-binding

https://github.com/xamarin/AndroidX/issues/671
https://github.com/xamarin/AndroidX/issues/677

The binding compiles, but when we select the WatchFace, I have an error in the constructor of the class "CanvasRenderer2":

```
android.runtime.JavaProxyThrowable: System.ArgumentException: Cannot bind to the target method because its signature is not compatible with that of the delegate type.
   at System.Delegate.CreateDelegate(Type type, Type target, String method, Boolean ignoreCase, Boolean throwOnBindFailure)
   at System.Delegate.CreateDelegate(Type type, Type target, String method)
   at Android.Runtime.AndroidTypeManager.RegisterNativeMembers(JniType nativeClass, Type type, ReadOnlySpan`1 methods)
--- End of stack trace from previous location ---
   at Java.Interop.JniEnvironment.Object.AllocObject(JniObjectReference type)
   at Java.Interop.JniType.AllocObject()
   at Java.Interop.JniPeerMembers.JniInstanceMethods.StartCreateInstance(String constructorSignature, Type declaringType, JniArgumentValue* parameters)
   at Androidx.Wear.Watchface.Renderer.CanvasRenderer2..ctor(ISurfaceHolder surfaceHolder, CurrentUserStyleRepository currentUserStyleRepository, WatchState watchState, Int32 canvasType, Int64 interactiveDrawModeUpdateDelayMillis, Boolean clearWithBackgroundTintBeforeRenderingHighlightLayer)
   at Sample.WearOS.CustomCanvasRenderer..ctor(ISurfaceHolder surfaceHolder, CurrentUserStyleRepository currentUserStyleRepository, WatchState watchState, Int32 canvasType)
   at Sample.WearOS.MyWatchFaceService.CreateWatchFace(ISurfaceHolder surfaceHolder, WatchState watchState, ComplicationSlotsManager complicationSlotsManager, CurrentUserStyleRepository currentUserStyleRepository, IContinuation p4)
   at Androidx.Wear.Watchface.WatchFaceService.n_CreateWatchFace_Landroid_view_SurfaceHolder_Landroidx_wear_watchface_WatchState_Landroidx_wear_watchface_ComplicationSlotsManager_Landroidx_wear_watchface_style_CurrentUserStyleRepository_Lkotlin_coroutines_Continuation_(IntPtr jnienv, IntPtr native__this, IntPtr native_surfaceHolder, IntPtr native_watchState, IntPtr native_complicationSlotsManager, IntPtr native_currentUserStyleRepository, IntPtr native_p4)
   at Android.Runtime.DynamicMethodNameCounter.1(IntPtr , IntPtr , IntPtr , IntPtr , IntPtr , IntPtr , IntPtr )
	at crc645526c0bb8eafc12f.MyWatchFaceService.n_createWatchFace(Native Method)
	at crc645526c0bb8eafc12f.MyWatchFaceService.createWatchFace(MyWatchFaceService.java:30)
	at androidx.wear.watchface.WatchFaceService$EngineWrapper$createWatchFaceInternal$1.invokeSuspend(WatchFaceService.kt:1918)
	at kotlin.coroutines.jvm.internal.BaseContinuationImpl.resumeWith(ContinuationImpl.kt:33)
	at kotlinx.coroutines.DispatchedTask.run(DispatchedTask.kt:106)
	at android.os.Handler.handleCallback(Handler.java:938)
	at android.os.Handler.dispatchMessage(Handler.java:99)
	at android.os.Looper.loop(Looper.java:246)
	at android.os.HandlerThread.run(HandlerThread.java:67)
	Suppressed: kotlinx.coroutines.DiagnosticCoroutineContextException: [StandaloneCoroutine{Cancelling}@81dab8d, Handler (android.os.Handler) {af53142}.immediate]
```
