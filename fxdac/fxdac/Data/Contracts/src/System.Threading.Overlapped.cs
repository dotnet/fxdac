[assembly:System.CLSCompliant(true)]
namespace System.Threading {

    [System.CLSCompliantAttribute(false)]
    public unsafe delegate void IOCompletionCallback(uint errorCode, uint numBytes, System.Threading.NativeOverlapped* pOVERLAP);
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct NativeOverlapped
    {
        public System.IntPtr EventHandle;
        public System.IntPtr InternalHigh;
        public System.IntPtr InternalLow;
        public int OffsetHigh;
        public int OffsetLow;
    }
    public partial class Overlapped
    {
        public Overlapped() { }
        [System.ObsoleteAttribute("Not 64bit compatible.  Please use the constructor that takes IntPtr for the event handle")]
        public Overlapped(int offsetLo, int offsetHi, int hEvent, System.IAsyncResult ar) { }
        public Overlapped(int offsetLo, int offsetHi, System.IntPtr hEvent, System.IAsyncResult ar) { }
        public System.IAsyncResult AsyncResult { get { return default(System.IAsyncResult); } set { } }
        [System.ObsoleteAttribute("Not 64bit compatible.  Use EventHandleIntPtr instead.")]
        public int EventHandle { get { return default(int); } set { } }
        public System.IntPtr EventHandleIntPtr { get { return default(System.IntPtr); } set { } }
        public int OffsetHigh { get { return default(int); } set { } }
        public int OffsetLow { get { return default(int); } set { } }
        [System.CLSCompliantAttribute(false)]
        public unsafe static void Free(System.Threading.NativeOverlapped* nativeOverlappedPtr) { }
        [System.CLSCompliantAttribute(false)]
        [System.ObsoleteAttribute("Use Pack(iocb, userData) instead")]
        public unsafe System.Threading.NativeOverlapped* Pack(System.Threading.IOCompletionCallback iocb) { return default(System.Threading.NativeOverlapped*); }
        [System.CLSCompliantAttribute(false)]
        public unsafe System.Threading.NativeOverlapped* Pack(System.Threading.IOCompletionCallback iocb, object userData) { return default(System.Threading.NativeOverlapped*); }
        [System.CLSCompliantAttribute(false)]
        public unsafe static System.Threading.Overlapped Unpack(System.Threading.NativeOverlapped* nativeOverlappedPtr) { return default(System.Threading.Overlapped); }
        [System.CLSCompliantAttribute(false)]
        [System.ObsoleteAttribute("Use UnsafePack(iocb, userData) instead")]
        public unsafe System.Threading.NativeOverlapped* UnsafePack(System.Threading.IOCompletionCallback iocb) { return default(System.Threading.NativeOverlapped*); }
        [System.CLSCompliantAttribute(false)]
        public unsafe System.Threading.NativeOverlapped* UnsafePack(System.Threading.IOCompletionCallback iocb, object userData) { return default(System.Threading.NativeOverlapped*); }
    }
  public sealed partial class PreAllocatedOverlapped : System.IDisposable {
    [System.CLSCompliantAttribute(false)]
    public PreAllocatedOverlapped(System.Threading.IOCompletionCallback callback, object state, object pinData) { }
    public void Dispose() { }
  }
  public sealed partial class ThreadPoolBoundHandle : System.IDisposable {
    internal ThreadPoolBoundHandle() { }
    public System.Runtime.InteropServices.SafeHandle Handle { get { return default(System.Runtime.InteropServices.SafeHandle); } }
    [System.CLSCompliantAttribute(false)]
    public unsafe System.Threading.NativeOverlapped* AllocateNativeOverlapped(System.Threading.IOCompletionCallback callback, object state, object pinData) { return default(System.Threading.NativeOverlapped*); }
    [System.CLSCompliantAttribute(false)]
    public unsafe System.Threading.NativeOverlapped* AllocateNativeOverlapped(System.Threading.PreAllocatedOverlapped preAllocated) { return default(System.Threading.NativeOverlapped*); }
    public static System.Threading.ThreadPoolBoundHandle BindHandle(System.Runtime.InteropServices.SafeHandle handle) { return default(System.Threading.ThreadPoolBoundHandle); }
    public void Dispose() { }
    [System.CLSCompliantAttribute(false)]
    public unsafe void FreeNativeOverlapped(System.Threading.NativeOverlapped* overlapped) { }
    [System.CLSCompliantAttribute(false)]
    public unsafe static object GetNativeOverlappedState(System.Threading.NativeOverlapped* overlapped) { return default(object); }
  }
} // end of System.Threading
