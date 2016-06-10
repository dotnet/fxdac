[assembly:System.CLSCompliant(true)]
namespace System.Threading {

    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public delegate void ParameterizedThreadStart(object obj);


    [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(0))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class Thread : System.Runtime.ConstrainedExecution.CriticalFinalizerObject
    {
        [System.Security.SecuritySafeCriticalAttribute]
        public Thread(System.Threading.ParameterizedThreadStart start) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public Thread(System.Threading.ParameterizedThreadStart start, int maxStackSize) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public Thread(System.Threading.ThreadStart start) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public Thread(System.Threading.ThreadStart start, int maxStackSize) { }
        [System.ObsoleteAttribute("Deprecated in favor of GetApartmentState, SetApartmentState and TrySetApartmentState.")]
        public System.Threading.ApartmentState ApartmentState { get { return default(System.Threading.ApartmentState); } set { } }
        public System.Globalization.CultureInfo CurrentCulture { get { return default(System.Globalization.CultureInfo); } set { } }
        public static System.Security.Principal.IPrincipal CurrentPrincipal { get { return default(System.Security.Principal.IPrincipal); } set { } }
        public static System.Threading.Thread CurrentThread { [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute((System.Runtime.ConstrainedExecution.Consistency)(3), (System.Runtime.ConstrainedExecution.Cer)(1))]get { return default(System.Threading.Thread); } }
        public System.Globalization.CultureInfo CurrentUICulture { get { return default(System.Globalization.CultureInfo); } set { } }
        public System.Threading.ExecutionContext ExecutionContext { [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute((System.Runtime.ConstrainedExecution.Consistency)(3), (System.Runtime.ConstrainedExecution.Cer)(1)), System.Security.SecuritySafeCriticalAttribute]get { return default(System.Threading.ExecutionContext); } }
        public bool IsAlive { get { return default(bool); } }
        public bool IsBackground { get { return default(bool); } set { } }
        public bool IsThreadPoolThread { get { return default(bool); } }
        public int ManagedThreadId { [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute((System.Runtime.ConstrainedExecution.Consistency)(3), (System.Runtime.ConstrainedExecution.Cer)(2))]get { return default(int); } }
        public string Name { get { return default(string); } set { } }
        public System.Threading.ThreadPriority Priority { [System.Security.SecuritySafeCriticalAttribute]get { return default(System.Threading.ThreadPriority); } [System.Security.SecuritySafeCriticalAttribute]set { } }
        public System.Threading.ThreadState ThreadState { get { return default(System.Threading.ThreadState); } }
        public void Abort() { }
        public void Abort(object stateInfo) { }
        public static System.LocalDataStoreSlot AllocateDataSlot() { return default(System.LocalDataStoreSlot); }
        public static System.LocalDataStoreSlot AllocateNamedDataSlot(string name) { return default(System.LocalDataStoreSlot); }
        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute((System.Runtime.ConstrainedExecution.Consistency)(3), (System.Runtime.ConstrainedExecution.Cer)(1))]
        public static void BeginCriticalRegion() { }
        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute((System.Runtime.ConstrainedExecution.Consistency)(3), (System.Runtime.ConstrainedExecution.Cer)(1))]
        public static void BeginThreadAffinity() { }
        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute((System.Runtime.ConstrainedExecution.Consistency)(3), (System.Runtime.ConstrainedExecution.Cer)(2))]
        public static void EndCriticalRegion() { }
        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute((System.Runtime.ConstrainedExecution.Consistency)(3), (System.Runtime.ConstrainedExecution.Cer)(1))]
        public static void EndThreadAffinity() { }
        ~Thread() { }
        public static void FreeNamedDataSlot(string name) { }
        public System.Threading.ApartmentState GetApartmentState() { return default(System.Threading.ApartmentState); }
        [System.ObsoleteAttribute("Thread.GetCompressedStack is no longer supported. Please use the System.Threading.CompressedStack class")]
        [System.Security.SecurityCriticalAttribute]
        public System.Threading.CompressedStack GetCompressedStack() { return default(System.Threading.CompressedStack); }
        public static object GetData(System.LocalDataStoreSlot slot) { return default(object); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
        public static int GetDomainID() { return default(int); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override int GetHashCode() { return default(int); }
        public static System.LocalDataStoreSlot GetNamedDataSlot(string name) { return default(System.LocalDataStoreSlot); }
        [System.Security.SecuritySafeCriticalAttribute]
        public void Interrupt() { }
        [System.Security.SecuritySafeCriticalAttribute]
        public void Join() { }
        [System.Security.SecuritySafeCriticalAttribute]
        public bool Join(int millisecondsTimeout) { return default(bool); }
        public bool Join(System.TimeSpan timeout) { return default(bool); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
        [System.Security.SecuritySafeCriticalAttribute]
        public static void MemoryBarrier() { }
        [System.Security.SecuritySafeCriticalAttribute]
        public static void ResetAbort() { }
        [System.ObsoleteAttribute("Thread.Resume has been deprecated.  Please use other classes in System.Threading, such as Monitor, Mutex, Event, and Semaphore, to synchronize Threads or protect resources.  http://go.microsoft.com/fwlink/?linkid=14202", false)]
        [System.Security.SecuritySafeCriticalAttribute]
        public void Resume() { }
        public void SetApartmentState(System.Threading.ApartmentState state) { }
        [System.ObsoleteAttribute("Thread.SetCompressedStack is no longer supported. Please use the System.Threading.CompressedStack class")]
        [System.Security.SecurityCriticalAttribute]
        public void SetCompressedStack(System.Threading.CompressedStack stack) { }
        public static void SetData(System.LocalDataStoreSlot slot, object data) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public static void Sleep(int millisecondsTimeout) { }
        public static void Sleep(System.TimeSpan timeout) { }
        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute((System.Runtime.ConstrainedExecution.Consistency)(3), (System.Runtime.ConstrainedExecution.Cer)(2))]
        public static void SpinWait(int iterations) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        public void Start() { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        public void Start(object parameter) { }
        [System.ObsoleteAttribute("Thread.Suspend has been deprecated.  Please use other classes in System.Threading, such as Monitor, Mutex, Event, and Semaphore, to synchronize Threads or protect resources.  http://go.microsoft.com/fwlink/?linkid=14202", false)]
        [System.Security.SecuritySafeCriticalAttribute]
        public void Suspend() { }
        public bool TrySetApartmentState(System.Threading.ApartmentState state) { return default(bool); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
        public static byte VolatileRead(ref byte address) { return default(byte); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
        public static double VolatileRead(ref double address) { return default(double); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
        public static short VolatileRead(ref short address) { return default(short); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
        public static int VolatileRead(ref int address) { return default(int); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
        public static long VolatileRead(ref long address) { return default(long); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
        public static System.IntPtr VolatileRead(ref System.IntPtr address) { return default(System.IntPtr); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
        public static object VolatileRead(ref object address) { return default(object); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
        [System.CLSCompliantAttribute(false)]
        public static sbyte VolatileRead(ref sbyte address) { return default(sbyte); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
        public static float VolatileRead(ref float address) { return default(float); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
        [System.CLSCompliantAttribute(false)]
        public static ushort VolatileRead(ref ushort address) { return default(ushort); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
        [System.CLSCompliantAttribute(false)]
        public static uint VolatileRead(ref uint address) { return default(uint); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
        [System.CLSCompliantAttribute(false)]
        public static ulong VolatileRead(ref ulong address) { return default(ulong); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
        [System.CLSCompliantAttribute(false)]
        public static System.UIntPtr VolatileRead(ref System.UIntPtr address) { return default(System.UIntPtr); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
        public static void VolatileWrite(ref byte address, byte value) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
        public static void VolatileWrite(ref double address, double value) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
        public static void VolatileWrite(ref short address, short value) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
        public static void VolatileWrite(ref int address, int value) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
        public static void VolatileWrite(ref long address, long value) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
        public static void VolatileWrite(ref System.IntPtr address, System.IntPtr value) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
        public static void VolatileWrite(ref object address, object value) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
        [System.CLSCompliantAttribute(false)]
        public static void VolatileWrite(ref sbyte address, sbyte value) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
        public static void VolatileWrite(ref float address, float value) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
        [System.CLSCompliantAttribute(false)]
        public static void VolatileWrite(ref ushort address, ushort value) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
        [System.CLSCompliantAttribute(false)]
        public static void VolatileWrite(ref uint address, uint value) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
        [System.CLSCompliantAttribute(false)]
        public static void VolatileWrite(ref ulong address, ulong value) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
        [System.CLSCompliantAttribute(false)]
        public static void VolatileWrite(ref System.UIntPtr address, System.UIntPtr value) { }
        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute((System.Runtime.ConstrainedExecution.Consistency)(3), (System.Runtime.ConstrainedExecution.Cer)(2))]
        [System.Security.SecuritySafeCriticalAttribute]
        public static bool Yield() { return default(bool); }
    }


    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public delegate void ThreadStart();


    public sealed partial class ThreadStartException : System.SystemException
    {
        internal ThreadStartException() { }
    }


    [System.FlagsAttribute]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
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


    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ThreadStateException : System.SystemException
    {
        public ThreadStateException() { }
        protected ThreadStateException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public ThreadStateException(string message) { }
        public ThreadStateException(string message, System.Exception innerException) { }
    }

} // end of System.Threading
