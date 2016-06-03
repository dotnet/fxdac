[assembly:System.CLSCompliant(true)]
namespace System.Threading {
  [System.CLSCompliantAttribute(false)]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Security.SecurityCriticalAttribute]
  public unsafe delegate void IOCompletionCallback(uint errorCode, uint numBytes, System.Threading.NativeOverlapped* pOVERLAP);

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct NativeOverlapped {
    public System.IntPtr EventHandle;
    public System.IntPtr InternalHigh;
    public System.IntPtr InternalLow;
    public int OffsetHigh;
    public int OffsetLow;
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class Overlapped {
    public Overlapped() { }
    [System.ObsoleteAttribute("Not 64bit compatible.  Please use the constructor that takes IntPtr for the event handle")]
    public Overlapped(int offsetLo, int offsetHi, int hEvent, System.IAsyncResult ar) { }
    public Overlapped(int offsetLo, int offsetHi, System.IntPtr hEvent, System.IAsyncResult ar) { }
    public System.IAsyncResult AsyncResult { get { return default(System.IAsyncResult); } set { } }
    [System.ObsoleteAttribute("Not 64bit compatible.  Use EventHandleIntPtr instead.")]
    public int EventHandle { get { return default(int); } set { } }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public System.IntPtr EventHandleIntPtr { get { return default(System.IntPtr); } set { } }
    public int OffsetHigh { get { return default(int); } set { } }
    public int OffsetLow { get { return default(int); } set { } }
    [System.CLSCompliantAttribute(false)]
    public unsafe static void Free(System.Threading.NativeOverlapped* nativeOverlappedPtr) { }
    [System.CLSCompliantAttribute(false)]
    [System.ObsoleteAttribute("Use Pack(iocb, userData) instead")]
    public unsafe System.Threading.NativeOverlapped* Pack(System.Threading.IOCompletionCallback iocb) { return default(System.Threading.NativeOverlapped*); }
    [System.CLSCompliantAttribute(false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public unsafe System.Threading.NativeOverlapped* Pack(System.Threading.IOCompletionCallback iocb, object userData) { return default(System.Threading.NativeOverlapped*); }
    [System.CLSCompliantAttribute(false)]
    public unsafe static System.Threading.Overlapped Unpack(System.Threading.NativeOverlapped* nativeOverlappedPtr) { return default(System.Threading.Overlapped); }
    [System.CLSCompliantAttribute(false)]
    [System.ObsoleteAttribute("Use UnsafePack(iocb, userData) instead")]
    public unsafe System.Threading.NativeOverlapped* UnsafePack(System.Threading.IOCompletionCallback iocb) { return default(System.Threading.NativeOverlapped*); }
    [System.CLSCompliantAttribute(false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public unsafe System.Threading.NativeOverlapped* UnsafePack(System.Threading.IOCompletionCallback iocb, object userData) { return default(System.Threading.NativeOverlapped*); }
  }

} // end of System.Threading
