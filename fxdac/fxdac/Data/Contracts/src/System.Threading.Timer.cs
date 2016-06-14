[assembly:System.CLSCompliant(true)]
namespace System.Threading {

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class Timer :System.IDisposable
    {
        public Timer(System.Threading.TimerCallback callback) { }
        public Timer(System.Threading.TimerCallback callback, object state, int dueTime, int period) { }
        public Timer(System.Threading.TimerCallback callback, object state, long dueTime, long period) { }
        public Timer(System.Threading.TimerCallback callback, object state, System.TimeSpan dueTime, System.TimeSpan period) { }
        [System.CLSCompliantAttribute(false)]
        public Timer(System.Threading.TimerCallback callback, object state, uint dueTime, uint period) { }
        public bool Change(int dueTime, int period) { return default(bool); }
        public bool Change(long dueTime, long period) { return default(bool); }
        public bool Change(System.TimeSpan dueTime, System.TimeSpan period) { return default(bool); }
        [System.CLSCompliantAttribute(false)]
        public bool Change(uint dueTime, uint period) { return default(bool); }
        public void Dispose() { }
        public bool Dispose(System.Threading.WaitHandle notifyObject) { return default(bool); }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public delegate void TimerCallback(object state);
} // end of System.Threading
