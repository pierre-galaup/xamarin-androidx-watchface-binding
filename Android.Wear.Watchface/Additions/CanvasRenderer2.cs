using System;
using Android.Graphics;
using Android.Runtime;
using Java.Interop;

namespace Androidx.Wear.Watchface;

public abstract partial class Renderer
{
    public abstract partial class CanvasRenderer2
    {
        [Register("render", "(Landroid/graphics/Canvas;Landroid/graphics/Rect;Ljava.time.ZonedDateTime;Landroidx/wear/watchface/Renderer$SharedAssets;)V", "")]
        protected abstract void Render(Android.Graphics.Canvas canvas, Android.Graphics.Rect rect, Java.Lang.Object dateTime, ISharedAssets sharedAssets);

        [Register("renderHighlightLayer", "(Landroid/graphics/Canvas;Landroid/graphics/Rect;Ljava.time.ZonedDateTime;Landroidx/wear/watchface/Renderer$SharedAssets;)V", "")]
        protected abstract void RenderHighlightLayer(Android.Graphics.Canvas canvas, Android.Graphics.Rect rect, Java.Lang.Object dateTime, ISharedAssets sharedAssets);
    }

    internal partial class CanvasRenderer2Invoker
    {
        [Register("render", "(Landroid/graphics/Canvas;Landroid/graphics/Rect;Ljava.time.ZonedDateTime;Landroidx/wear/watchface/Renderer$SharedAssets;)V", "")]
        protected override unsafe void Render(Canvas canvas, Rect rect, Java.Lang.Object dateTime, ISharedAssets sharedAssets)
        {
            const string __id = "render.(Landroid/graphics/Canvas;Landroid/graphics/Rect;Ljava.time.ZonedDateTime;Landroidx/wear/watchface/Renderer$SharedAssets;)V";

            if (((global::Java.Lang.Object)this).Handle != IntPtr.Zero)
                return;

            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[6];
                __args[0] = new JniArgumentValue((canvas == null) ? IntPtr.Zero : ((global::Java.Lang.Object)canvas).Handle);
                __args[1] = new JniArgumentValue((rect == null) ? IntPtr.Zero : ((global::Java.Lang.Object)rect).Handle);
                __args[3] = new JniArgumentValue((dateTime == null) ? IntPtr.Zero : ((global::Java.Lang.Object)dateTime).Handle);
                __args[3] = new JniArgumentValue((sharedAssets == null) ? IntPtr.Zero : ((global::Java.Lang.Object)sharedAssets).Handle);
                var __r = _members.InstanceMethods.StartCreateInstance(__id, ((object)this).GetType(), __args);
                SetHandle(__r.Handle, JniHandleOwnership.TransferLocalRef);
                _members.InstanceMethods.FinishCreateInstance(__id, this, __args);
            }
            finally
            {
                global::System.GC.KeepAlive(canvas);
                global::System.GC.KeepAlive(rect);
                global::System.GC.KeepAlive(dateTime);
                global::System.GC.KeepAlive(sharedAssets);
            }
        }

        [Register("renderHighlightLayer", "(Landroid/graphics/Canvas;Landroid/graphics/Rect;Ljava.time.ZonedDateTime;Landroidx/wear/watchface/Renderer$SharedAssets;)V", "")]
        protected override unsafe void RenderHighlightLayer(Canvas canvas, Rect rect, Java.Lang.Object dateTime, ISharedAssets sharedAssets)
        {
            const string __id = "renderHighlightLayer.(Landroid/graphics/Canvas;Landroid/graphics/Rect;Ljava.time.ZonedDateTime;Landroidx/wear/watchface/Renderer$SharedAssets;)V";

            if (((global::Java.Lang.Object)this).Handle != IntPtr.Zero)
                return;

            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[6];
                __args[0] = new JniArgumentValue((canvas == null) ? IntPtr.Zero : ((global::Java.Lang.Object)canvas).Handle);
                __args[1] = new JniArgumentValue((rect == null) ? IntPtr.Zero : ((global::Java.Lang.Object)rect).Handle);
                __args[3] = new JniArgumentValue((dateTime == null) ? IntPtr.Zero : ((global::Java.Lang.Object)dateTime).Handle);
                __args[3] = new JniArgumentValue((sharedAssets == null) ? IntPtr.Zero : ((global::Java.Lang.Object)sharedAssets).Handle);
                var __r = _members.InstanceMethods.StartCreateInstance(__id, ((object)this).GetType(), __args);
                SetHandle(__r.Handle, JniHandleOwnership.TransferLocalRef);
                _members.InstanceMethods.FinishCreateInstance(__id, this, __args);
            }
            finally
            {
                global::System.GC.KeepAlive(canvas);
                global::System.GC.KeepAlive(rect);
                global::System.GC.KeepAlive(dateTime);
                global::System.GC.KeepAlive(sharedAssets);
            }
        }
    }
}