[assembly:System.CLSCompliant(true)]
namespace System.Threading {
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public partial class AbandonedMutexException : System.SystemException {
    public AbandonedMutexException() { }
    public AbandonedMutexException(int location, System.Threading.WaitHandle handle) { }
    protected AbandonedMutexException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public AbandonedMutexException(string message) { }
    public AbandonedMutexException(string message, System.Exception inner) { }
    public AbandonedMutexException(string message, System.Exception inner, int location, System.Threading.WaitHandle handle) { }
    public AbandonedMutexException(string message, int location, System.Threading.WaitHandle handle) { }
    public System.Threading.Mutex Mutex { get { return default(System.Threading.Mutex); } }
    public int MutexIndex { get { return default(int); } }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class AutoResetEvent : System.Threading.EventWaitHandle {
    public AutoResetEvent(bool initialState) : base (default(bool), default(System.Threading.EventResetMode)) { }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class EventWaitHandle : System.Threading.WaitHandle {
    public EventWaitHandle(bool initialState, System.Threading.EventResetMode mode) { }
    public EventWaitHandle(bool initialState, System.Threading.EventResetMode mode, string name) { }
    public EventWaitHandle(bool initialState, System.Threading.EventResetMode mode, string name, out bool createdNew) { createdNew = default(bool); }
    public EventWaitHandle(bool initialState, System.Threading.EventResetMode mode, string name, out bool createdNew, System.Security.AccessControl.EventWaitHandleSecurity eventSecurity) { createdNew = default(bool); }
    public static System.Threading.EventWaitHandle OpenExisting(string name) { return default(System.Threading.EventWaitHandle); }
    public static System.Threading.EventWaitHandle OpenExisting(string name, System.Security.AccessControl.EventWaitHandleRights rights) { return default(System.Threading.EventWaitHandle); }
    public bool Reset() { return default(bool); }
    public bool Set() { return default(bool); }
    public static bool TryOpenExisting(string name, System.Security.AccessControl.EventWaitHandleRights rights, out System.Threading.EventWaitHandle result) { result = default(System.Threading.EventWaitHandle); return default(bool); }
    public static bool TryOpenExisting(string name, out System.Threading.EventWaitHandle result) { result = default(System.Threading.EventWaitHandle); return default(bool); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class ManualResetEvent : System.Threading.EventWaitHandle {
    public ManualResetEvent(bool initialState) : base (default(bool), default(System.Threading.EventResetMode)) { }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class Mutex : System.Threading.WaitHandle {
    [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute((System.Runtime.ConstrainedExecution.Consistency)(3), (System.Runtime.ConstrainedExecution.Cer)(1))]
    public Mutex() { }
    [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute((System.Runtime.ConstrainedExecution.Consistency)(3), (System.Runtime.ConstrainedExecution.Cer)(1))]
    public Mutex(bool initiallyOwned) { }
    public Mutex(bool initiallyOwned, string name) { }
    public Mutex(bool initiallyOwned, string name, out bool createdNew) { createdNew = default(bool); }
    public Mutex(bool initiallyOwned, string name, out bool createdNew, System.Security.AccessControl.MutexSecurity mutexSecurity) { createdNew = default(bool); }
    public static System.Threading.Mutex OpenExisting(string name) { return default(System.Threading.Mutex); }
    public static System.Threading.Mutex OpenExisting(string name, System.Security.AccessControl.MutexRights rights) { return default(System.Threading.Mutex); }
    [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute((System.Runtime.ConstrainedExecution.Consistency)(3), (System.Runtime.ConstrainedExecution.Cer)(1))]
    public void ReleaseMutex() { }
    public static bool TryOpenExisting(string name, System.Security.AccessControl.MutexRights rights, out System.Threading.Mutex result) { result = default(System.Threading.Mutex); return default(bool); }
    public static bool TryOpenExisting(string name, out System.Threading.Mutex result) { result = default(System.Threading.Mutex); return default(bool); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public sealed partial class Semaphore : System.Threading.WaitHandle {
    public Semaphore(int initialCount, int maximumCount) { }
    public Semaphore(int initialCount, int maximumCount, string name) { }
    public Semaphore(int initialCount, int maximumCount, string name, out bool createdNew) { createdNew = default(bool); }
    public Semaphore(int initialCount, int maximumCount, string name, out bool createdNew, System.Security.AccessControl.SemaphoreSecurity semaphoreSecurity) { createdNew = default(bool); }
    public System.Security.AccessControl.SemaphoreSecurity GetAccessControl() { return default(System.Security.AccessControl.SemaphoreSecurity); }
    public static System.Threading.Semaphore OpenExisting(string name) { return default(System.Threading.Semaphore); }
    public static System.Threading.Semaphore OpenExisting(string name, System.Security.AccessControl.SemaphoreRights rights) { return default(System.Threading.Semaphore); }
    [System.Runtime.ConstrainedExecution.PrePrepareMethodAttribute]
    [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute((System.Runtime.ConstrainedExecution.Consistency)(3), (System.Runtime.ConstrainedExecution.Cer)(2))]
    public int Release() { return default(int); }
    [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute((System.Runtime.ConstrainedExecution.Consistency)(3), (System.Runtime.ConstrainedExecution.Cer)(2))]
    public int Release(int releaseCount) { return default(int); }
    public void SetAccessControl(System.Security.AccessControl.SemaphoreSecurity semaphoreSecurity) { }
    public static bool TryOpenExisting(string name, System.Security.AccessControl.SemaphoreRights rights, out System.Threading.Semaphore result) { result = default(System.Threading.Semaphore); return default(bool); }
    public static bool TryOpenExisting(string name, out System.Threading.Semaphore result) { result = default(System.Threading.Semaphore); return default(bool); }
  }

  public partial class ThreadExceptionEventArgs : System.EventArgs {
    public ThreadExceptionEventArgs(System.Exception t) { }
    public System.Exception Exception { get { return default(System.Exception); } }
  }

  public delegate void ThreadExceptionEventHandler(object sender, System.Threading.ThreadExceptionEventArgs e);

} // end of System.Threading
