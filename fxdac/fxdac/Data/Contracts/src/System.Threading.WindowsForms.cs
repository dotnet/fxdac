[assembly:System.CLSCompliant(true)]
namespace System.Threading {

    public partial class ThreadExceptionEventArgs : System.EventArgs
    {
        public ThreadExceptionEventArgs(System.Exception t) { }
        public System.Exception Exception { get { return default(System.Exception); } }
    }

    public delegate void ThreadExceptionEventHandler(object sender, System.Threading.ThreadExceptionEventArgs e);
} // end of System.Threading
