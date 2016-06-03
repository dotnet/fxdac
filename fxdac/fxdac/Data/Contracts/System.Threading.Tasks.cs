[assembly:System.CLSCompliant(true)]
namespace System.Threading {
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public partial class CancellationTokenSource : System.IDisposable {
    [System.Runtime.TargetedPatchingOptOutAttribute("Performance critical to inline across NGen image boundaries")]
    public CancellationTokenSource() { }
    public CancellationTokenSource(int millisecondsDelay) { }
    public CancellationTokenSource(System.TimeSpan delay) { }
    public bool IsCancellationRequested { [System.Runtime.TargetedPatchingOptOutAttribute("Performance critical to inline across NGen image boundaries")]get { return default(bool); } }
    public System.Threading.CancellationToken Token { [System.Runtime.TargetedPatchingOptOutAttribute("Performance critical to inline across NGen image boundaries")]get { return default(System.Threading.CancellationToken); } }
    public void Cancel() { }
    public void Cancel(bool throwOnFirstException) { }
    public void CancelAfter(int millisecondsDelay) { }
    public void CancelAfter(System.TimeSpan delay) { }
    public static System.Threading.CancellationTokenSource CreateLinkedTokenSource(System.Threading.CancellationToken token1, System.Threading.CancellationToken token2) { return default(System.Threading.CancellationTokenSource); }
    public static System.Threading.CancellationTokenSource CreateLinkedTokenSource(params System.Threading.CancellationToken[] tokens) { return default(System.Threading.CancellationTokenSource); }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
  }

} // end of System.Threading
namespace System.Threading.Tasks {
  public static partial class TaskExtensions {
    public static System.Threading.Tasks.Task Unwrap(this System.Threading.Tasks.Task<System.Threading.Tasks.Task> task) { return default(System.Threading.Tasks.Task); }
    public static System.Threading.Tasks.Task<TResult> Unwrap<TResult>(this System.Threading.Tasks.Task<System.Threading.Tasks.Task<TResult>> task) { return default(System.Threading.Tasks.Task<TResult>); }
  }

} // end of System.Threading.Tasks
