using Android.Graphics;
using Android.Util;
using Android.Views;
using Androidx.Wear.Watchface;
using Androidx.Wear.Watchface.Style;
using Kotlin.Coroutines;
using Object = Java.Lang.Object;

namespace Sample.WearOS;

public class CustomCanvasRenderer : Renderer.CanvasRenderer2, WatchFace.ITapListener
{
    public CustomCanvasRenderer(ISurfaceHolder surfaceHolder, CurrentUserStyleRepository currentUserStyleRepository, WatchState watchState, int canvasType)
        : base(surfaceHolder, currentUserStyleRepository, watchState, canvasType, 16L, false)
    {
        Log.Info("myappwatch", "CTOR");
    }

    protected override void Render(Canvas canvas, Rect rect, Object dateTime, ISharedAssets sharedAssets)
    {
        Log.Info("myappwatch", "Render");
    }

    protected override void RenderHighlightLayer(Canvas canvas, Rect rect, Object dateTime, ISharedAssets sharedAssets)
    {
        Log.Info("myappwatch", "RenderHighlightLayer");
    }

    protected override Object? CreateSharedAssets(IContinuation p0)
    {
        Log.Info("myappwatch", "CreateSharedAssets");
        return new AnalogSharedAssets();
    }

    public void OnTapEvent(int tapType, TapEvent tapEvent, ComplicationSlot? complicationSlot)
    {
        Log.Info("myappwatch", "OnTapEvent");
    }
}

class AnalogSharedAssets : Object, Renderer.ISharedAssets
{
    public void OnDestroy()
    {
        Log.Info("myappwatch", "OnDestroy");
    }
}