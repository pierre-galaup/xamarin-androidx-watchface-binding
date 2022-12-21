using Android.OS;

namespace Androidx.Wear.Watchface;

public abstract partial class WatchFaceService
{
    public sealed partial class EngineWrapper
    {
        public Handler BackgroundThreadHandler
        {
            get;
        }
        public Handler UiThreadHandler
        {
            get;
        }
    }
}