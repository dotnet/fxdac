[assembly:System.CLSCompliant(true)]
namespace System.Runtime.InteropServices {

    public abstract partial class CriticalHandle : System.Runtime.ConstrainedExecution.CriticalFinalizerObject, System.IDisposable
    {
        protected System.IntPtr handle;
        protected CriticalHandle(System.IntPtr invalidHandleValue) { }
        public bool IsClosed { get { return default(bool); } }
        public abstract bool IsInvalid { get; }
        public void Close() { }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        ~CriticalHandle() { }
        protected abstract bool ReleaseHandle();
        protected void SetHandle(System.IntPtr handle) { }
        public void SetHandleAsInvalid() { }
    }
} // end of System.Runtime.InteropServices
namespace System.IO {
    public enum HandleInheritability
    {
        Inheritable = 1,
        None = 0,
    }
} // end of System.IO
namespace System.Threading {
  public static partial class WaitHandleExtensions {
    public static Microsoft.Win32.SafeHandles.SafeWaitHandle GetSafeWaitHandle(this System.Threading.WaitHandle waitHandle) { return default(Microsoft.Win32.SafeHandles.SafeWaitHandle); }
    public static void SetSafeWaitHandle(this System.Threading.WaitHandle waitHandle, Microsoft.Win32.SafeHandles.SafeWaitHandle value) { }
  }
} // end of System.Threading
