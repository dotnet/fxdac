[assembly:System.CLSCompliant(true)]
namespace System.Runtime.ConstrainedExecution {
    public enum Cer
    {
        MayFail = 1,
        None = 0,
        Success = 2,
    }

    public enum Consistency
    {
        MayCorruptAppDomain = 1,
        MayCorruptInstance = 2,
        MayCorruptProcess = 0,
        WillNotCorruptState = 3,
    }
    public abstract partial class CriticalFinalizerObject
    {
        protected CriticalFinalizerObject() { }
        ~CriticalFinalizerObject() { }
    }

    [System.AttributeUsageAttribute((System.AttributeTargets)(96), Inherited = false)]
    public sealed partial class PrePrepareMethodAttribute : System.Attribute
    {
        public PrePrepareMethodAttribute() { }
    }

    [System.AttributeUsageAttribute((System.AttributeTargets)(1133), Inherited = false)]
    public sealed partial class ReliabilityContractAttribute : System.Attribute
    {
        public ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency consistencyGuarantee, System.Runtime.ConstrainedExecution.Cer cer) { }
        public System.Runtime.ConstrainedExecution.Cer Cer { get { return default(System.Runtime.ConstrainedExecution.Cer); } }
        public System.Runtime.ConstrainedExecution.Consistency ConsistencyGuarantee { get { return default(System.Runtime.ConstrainedExecution.Consistency); } }
    }
} // end of System.Runtime.ConstrainedExecution
