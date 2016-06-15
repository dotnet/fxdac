[assembly:System.CLSCompliant(true)]
namespace System.Threading {
    public sealed partial class RegisteredWaitHandle     {
        internal RegisteredWaitHandle() { }
        public bool Unregister(System.Threading.WaitHandle waitObject) { return default(bool); }
    }
    public static partial class ThreadPool
    {
        [System.ObsoleteAttribute("ThreadPool.BindHandle(IntPtr) has been deprecated.  Please use ThreadPool.BindHandle(SafeHandle) instead.", false)]
        public static bool BindHandle(System.IntPtr osHandle) { return default(bool); }
        public static bool BindHandle(System.Runtime.InteropServices.SafeHandle osHandle) { return default(bool); }
        public static void GetAvailableThreads(out int workerThreads, out int completionPortThreads) { workerThreads = default(int); completionPortThreads = default(int); }
        public static void GetMaxThreads(out int workerThreads, out int completionPortThreads) { workerThreads = default(int); completionPortThreads = default(int); }
        public static void GetMinThreads(out int workerThreads, out int completionPortThreads) { workerThreads = default(int); completionPortThreads = default(int); }
        public static bool QueueUserWorkItem(System.Threading.WaitCallback callBack) { return default(bool); }
        public static bool QueueUserWorkItem(System.Threading.WaitCallback callBack, object state) { return default(bool); }
        public static System.Threading.RegisteredWaitHandle RegisterWaitForSingleObject(System.Threading.WaitHandle waitObject, System.Threading.WaitOrTimerCallback callBack, object state, int millisecondsTimeOutInterval, bool executeOnlyOnce) { return default(System.Threading.RegisteredWaitHandle); }
        public static System.Threading.RegisteredWaitHandle RegisterWaitForSingleObject(System.Threading.WaitHandle waitObject, System.Threading.WaitOrTimerCallback callBack, object state, long millisecondsTimeOutInterval, bool executeOnlyOnce) { return default(System.Threading.RegisteredWaitHandle); }
        public static System.Threading.RegisteredWaitHandle RegisterWaitForSingleObject(System.Threading.WaitHandle waitObject, System.Threading.WaitOrTimerCallback callBack, object state, System.TimeSpan timeout, bool executeOnlyOnce) { return default(System.Threading.RegisteredWaitHandle); }
        [System.CLSCompliantAttribute(false)]
        public static System.Threading.RegisteredWaitHandle RegisterWaitForSingleObject(System.Threading.WaitHandle waitObject, System.Threading.WaitOrTimerCallback callBack, object state, uint millisecondsTimeOutInterval, bool executeOnlyOnce) { return default(System.Threading.RegisteredWaitHandle); }
        public static bool SetMaxThreads(int workerThreads, int completionPortThreads) { return default(bool); }
        public static bool SetMinThreads(int workerThreads, int completionPortThreads) { return default(bool); }
        [System.CLSCompliantAttribute(false)]
        public unsafe static bool UnsafeQueueNativeOverlapped(System.Threading.NativeOverlapped* overlapped) { return default(bool); }
        public static bool UnsafeQueueUserWorkItem(System.Threading.WaitCallback callBack, object state) { return default(bool); }
        public static System.Threading.RegisteredWaitHandle UnsafeRegisterWaitForSingleObject(System.Threading.WaitHandle waitObject, System.Threading.WaitOrTimerCallback callBack, object state, int millisecondsTimeOutInterval, bool executeOnlyOnce) { return default(System.Threading.RegisteredWaitHandle); }
        public static System.Threading.RegisteredWaitHandle UnsafeRegisterWaitForSingleObject(System.Threading.WaitHandle waitObject, System.Threading.WaitOrTimerCallback callBack, object state, long millisecondsTimeOutInterval, bool executeOnlyOnce) { return default(System.Threading.RegisteredWaitHandle); }
        public static System.Threading.RegisteredWaitHandle UnsafeRegisterWaitForSingleObject(System.Threading.WaitHandle waitObject, System.Threading.WaitOrTimerCallback callBack, object state, System.TimeSpan timeout, bool executeOnlyOnce) { return default(System.Threading.RegisteredWaitHandle); }
        [System.CLSCompliantAttribute(false)]
        public static System.Threading.RegisteredWaitHandle UnsafeRegisterWaitForSingleObject(System.Threading.WaitHandle waitObject, System.Threading.WaitOrTimerCallback callBack, object state, uint millisecondsTimeOutInterval, bool executeOnlyOnce) { return default(System.Threading.RegisteredWaitHandle); }
    }
    public delegate void WaitCallback(object state);
    public delegate void WaitOrTimerCallback(object state, bool timedOut);
} // end of System.Threading
