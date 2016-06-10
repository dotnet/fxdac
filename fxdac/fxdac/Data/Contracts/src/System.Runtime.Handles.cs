[assembly:System.CLSCompliant(true)]
namespace System.Runtime.InteropServices {

    public abstract partial class CriticalHandle : System.Runtime.ConstrainedExecution.CriticalFinalizerObject, System.IDisposable
    {
        protected System.IntPtr handle;
        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute((System.Runtime.ConstrainedExecution.Consistency)(3), (System.Runtime.ConstrainedExecution.Cer)(1))]
        protected CriticalHandle(System.IntPtr invalidHandleValue) { }
        public bool IsClosed { [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute((System.Runtime.ConstrainedExecution.Consistency)(3), (System.Runtime.ConstrainedExecution.Cer)(2))]get { return default(bool); } }
        public abstract bool IsInvalid { [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute((System.Runtime.ConstrainedExecution.Consistency)(3), (System.Runtime.ConstrainedExecution.Cer)(2))]get; }
        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute((System.Runtime.ConstrainedExecution.Consistency)(3), (System.Runtime.ConstrainedExecution.Cer)(2))]
        public void Close() { }
        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute((System.Runtime.ConstrainedExecution.Consistency)(3), (System.Runtime.ConstrainedExecution.Cer)(2))]
        public void Dispose() { }
        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute((System.Runtime.ConstrainedExecution.Consistency)(3), (System.Runtime.ConstrainedExecution.Cer)(2))]
        protected virtual void Dispose(bool disposing) { }
        ~CriticalHandle() { }
        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute((System.Runtime.ConstrainedExecution.Consistency)(3), (System.Runtime.ConstrainedExecution.Cer)(2))]
        protected abstract bool ReleaseHandle();
        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute((System.Runtime.ConstrainedExecution.Consistency)(3), (System.Runtime.ConstrainedExecution.Cer)(2))]
        protected void SetHandle(System.IntPtr handle) { }
        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute((System.Runtime.ConstrainedExecution.Consistency)(3), (System.Runtime.ConstrainedExecution.Cer)(2))]
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
    [System.Security.SecurityCriticalAttribute]
    public static Microsoft.Win32.SafeHandles.SafeWaitHandle GetSafeWaitHandle(this System.Threading.WaitHandle waitHandle) { return default(Microsoft.Win32.SafeHandles.SafeWaitHandle); }
    [System.Security.SecurityCriticalAttribute]
    public static void SetSafeWaitHandle(this System.Threading.WaitHandle waitHandle, Microsoft.Win32.SafeHandles.SafeWaitHandle value) { }
  }

} // end of System.Threading
