[assembly:System.CLSCompliant(true)]
namespace System.Runtime.CompilerServices {
    public partial class CallConvCdecl
    {
        public CallConvCdecl() { }
    }
    public partial class CallConvFastcall
    {
        public CallConvFastcall() { }
    }
    public partial class CallConvStdcall
    {
        public CallConvStdcall() { }
    }
    public partial class CallConvThiscall
    {
        public CallConvThiscall() { }
    }

    public static partial class IsBoxed
    {
    }

    public static partial class IsByValue
    {
    }
    public static partial class IsCopyConstructed
    {
    }

    public static partial class IsExplicitlyDereferenced
    {
    }

    public static partial class IsImplicitlyDereferenced
    {
    }

    public static partial class IsJitIntrinsic
    {
    }

    public static partial class IsLong
    {
    }

    public static partial class IsPinned
    {
    }

    public static partial class IsSignUnspecifiedByte
    {
    }

    public static partial class IsUdtReturn
    {
    }

    [System.AttributeUsageAttribute((System.AttributeTargets)(2304), Inherited = false)]
    public sealed partial class IUnknownConstantAttribute : System.Runtime.CompilerServices.CustomConstantAttribute
    {
        public IUnknownConstantAttribute() { }
        public override object Value { get { return default(object); } }
    }

    [System.AttributeUsageAttribute((System.AttributeTargets)(8), Inherited = true)]
    public sealed partial class NativeCppClassAttribute : System.Attribute
    {
        public NativeCppClassAttribute() { }
    }

    [System.AttributeUsageAttribute((System.AttributeTargets)(1052), AllowMultiple = true, Inherited = false)]
    public sealed partial class RequiredAttributeAttribute : System.Attribute
    {
        public RequiredAttributeAttribute(System.Type requiredContract) { }
        public System.Type RequiredContract { get { return default(System.Type); } }
    }
} // end of System.Runtime.CompilerServices
