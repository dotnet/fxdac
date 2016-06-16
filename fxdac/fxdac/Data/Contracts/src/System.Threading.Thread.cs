[assembly:System.CLSCompliant(true)]
namespace System.Threading {
    public delegate void ParameterizedThreadStart(object obj);
    public sealed partial class Thread     {
        public Thread(System.Threading.ParameterizedThreadStart start) { }
        public Thread(System.Threading.ParameterizedThreadStart start, int maxStackSize) { }
        public Thread(System.Threading.ThreadStart start) { }
        public Thread(System.Threading.ThreadStart start, int maxStackSize) { }
        [System.ObsoleteAttribute("Deprecated in favor of GetApartmentState, SetApartmentState and TrySetApartmentState.")]
        public System.Threading.ApartmentState ApartmentState { get { return default(System.Threading.ApartmentState); } set { } }
        public System.Globalization.CultureInfo CurrentCulture { get { return default(System.Globalization.CultureInfo); } set { } }
        public static System.Security.Principal.IPrincipal CurrentPrincipal { get { return default(System.Security.Principal.IPrincipal); } set { } }
        public static System.Threading.Thread CurrentThread { get { return default(System.Threading.Thread); } }
        public System.Globalization.CultureInfo CurrentUICulture { get { return default(System.Globalization.CultureInfo); } set { } }
        public System.Threading.ExecutionContext ExecutionContext { get { return default(System.Threading.ExecutionContext); } }
        public bool IsAlive { get { return default(bool); } }
        public bool IsBackground { get { return default(bool); } set { } }
        public bool IsThreadPoolThread { get { return default(bool); } }
        public int ManagedThreadId { get { return default(int); } }
        public string Name { get { return default(string); } set { } }
        public System.Threading.ThreadPriority Priority { get { return default(System.Threading.ThreadPriority); } set { } }
        public System.Threading.ThreadState ThreadState { get { return default(System.Threading.ThreadState); } }
        public void Abort() { }
        public void Abort(object stateInfo) { }
        public static System.LocalDataStoreSlot AllocateDataSlot() { return default(System.LocalDataStoreSlot); }
        public static System.LocalDataStoreSlot AllocateNamedDataSlot(string name) { return default(System.LocalDataStoreSlot); }
        public static void BeginCriticalRegion() { }
        public static void BeginThreadAffinity() { }
        public static void EndCriticalRegion() { }
        public static void EndThreadAffinity() { }
        ~Thread() { }
        public static void FreeNamedDataSlot(string name) { }
        public System.Threading.ApartmentState GetApartmentState() { return default(System.Threading.ApartmentState); }
        [System.ObsoleteAttribute("Thread.GetCompressedStack is no longer supported. Please use the System.Threading.CompressedStack class")]
        public System.Threading.CompressedStack GetCompressedStack() { return default(System.Threading.CompressedStack); }
        public static object GetData(System.LocalDataStoreSlot slot) { return default(object); }
        public static int GetDomainID() { return default(int); }
        public override int GetHashCode() { return default(int); }
        public static System.LocalDataStoreSlot GetNamedDataSlot(string name) { return default(System.LocalDataStoreSlot); }
        public void Interrupt() { }
        public void Join() { }
        public bool Join(int millisecondsTimeout) { return default(bool); }
        public bool Join(System.TimeSpan timeout) { return default(bool); }
        public static void MemoryBarrier() { }
        public static void ResetAbort() { }
        [System.ObsoleteAttribute("Thread.Resume has been deprecated.  Please use other classes in System.Threading, such as Monitor, Mutex, Event, and Semaphore, to synchronize Threads or protect resources.  http://go.microsoft.com/fwlink/?linkid=14202", false)]
        public void Resume() { }
        public void SetApartmentState(System.Threading.ApartmentState state) { }
        [System.ObsoleteAttribute("Thread.SetCompressedStack is no longer supported. Please use the System.Threading.CompressedStack class")]
        public void SetCompressedStack(System.Threading.CompressedStack stack) { }
        public static void SetData(System.LocalDataStoreSlot slot, object data) { }
        public static void Sleep(int millisecondsTimeout) { }
        public static void Sleep(System.TimeSpan timeout) { }
        public static void SpinWait(int iterations) { }
        public void Start() { }
        public void Start(object parameter) { }
        [System.ObsoleteAttribute("Thread.Suspend has been deprecated.  Please use other classes in System.Threading, such as Monitor, Mutex, Event, and Semaphore, to synchronize Threads or protect resources.  http://go.microsoft.com/fwlink/?linkid=14202", false)]
        public void Suspend() { }
        public bool TrySetApartmentState(System.Threading.ApartmentState state) { return default(bool); }
        public static byte VolatileRead(ref byte address) { return default(byte); }
        public static double VolatileRead(ref double address) { return default(double); }
        public static short VolatileRead(ref short address) { return default(short); }
        public static int VolatileRead(ref int address) { return default(int); }
        public static long VolatileRead(ref long address) { return default(long); }
        public static System.IntPtr VolatileRead(ref System.IntPtr address) { return default(System.IntPtr); }
        public static object VolatileRead(ref object address) { return default(object); }
        [System.CLSCompliantAttribute(false)]
        public static sbyte VolatileRead(ref sbyte address) { return default(sbyte); }
        public static float VolatileRead(ref float address) { return default(float); }
        [System.CLSCompliantAttribute(false)]
        public static ushort VolatileRead(ref ushort address) { return default(ushort); }
        [System.CLSCompliantAttribute(false)]
        public static uint VolatileRead(ref uint address) { return default(uint); }
        [System.CLSCompliantAttribute(false)]
        public static ulong VolatileRead(ref ulong address) { return default(ulong); }
        [System.CLSCompliantAttribute(false)]
        public static System.UIntPtr VolatileRead(ref System.UIntPtr address) { return default(System.UIntPtr); }
        public static void VolatileWrite(ref byte address, byte value) { }
        public static void VolatileWrite(ref double address, double value) { }
        public static void VolatileWrite(ref short address, short value) { }
        public static void VolatileWrite(ref int address, int value) { }
        public static void VolatileWrite(ref long address, long value) { }
        public static void VolatileWrite(ref System.IntPtr address, System.IntPtr value) { }
        public static void VolatileWrite(ref object address, object value) { }
        [System.CLSCompliantAttribute(false)]
        public static void VolatileWrite(ref sbyte address, sbyte value) { }
        public static void VolatileWrite(ref float address, float value) { }
        [System.CLSCompliantAttribute(false)]
        public static void VolatileWrite(ref ushort address, ushort value) { }
        [System.CLSCompliantAttribute(false)]
        public static void VolatileWrite(ref uint address, uint value) { }
        [System.CLSCompliantAttribute(false)]
        public static void VolatileWrite(ref ulong address, ulong value) { }
        [System.CLSCompliantAttribute(false)]
        public static void VolatileWrite(ref System.UIntPtr address, System.UIntPtr value) { }
        public static bool Yield() { return default(bool); }
    }
    public delegate void ThreadStart();

    public sealed partial class ThreadStartException : System.SystemException
    {
        internal ThreadStartException() { }
    }

    [System.FlagsAttribute]
    public enum ThreadState
    {
        Aborted = 256,
        AbortRequested = 128,
        Background = 4,
        Running = 0,
        Stopped = 16,
        StopRequested = 1,
        Suspended = 64,
        SuspendRequested = 2,
        Unstarted = 8,
        WaitSleepJoin = 32,
    }
    public partial class ThreadStateException : System.SystemException
    {
        public ThreadStateException() { }
        protected ThreadStateException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public ThreadStateException(string message) { }
        public ThreadStateException(string message, System.Exception innerException) { }
    }
} // end of System.Threading
