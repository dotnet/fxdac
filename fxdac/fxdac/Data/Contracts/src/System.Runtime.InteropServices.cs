[assembly:System.CLSCompliant(true)]
namespace System.Runtime.InteropServices {

    [System.AttributeUsageAttribute((System.AttributeTargets)(64), AllowMultiple = false, Inherited = false)]
    public sealed partial class AllowReversePInvokeCallsAttribute : System.Attribute
    {
        public AllowReversePInvokeCallsAttribute() { }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct ArrayWithOffset
    {
        public ArrayWithOffset(object array, int offset) { throw new System.NotImplementedException(); }
        public override bool Equals(object obj) { return default(bool); }
        public bool Equals(System.Runtime.InteropServices.ArrayWithOffset obj) { return default(bool); }
        public object GetArray() { return default(object); }
        public override int GetHashCode() { return default(int); }
        public int GetOffset() { return default(int); }
        public static bool operator ==(System.Runtime.InteropServices.ArrayWithOffset a, System.Runtime.InteropServices.ArrayWithOffset b) { return default(bool); }
        public static bool operator !=(System.Runtime.InteropServices.ArrayWithOffset a, System.Runtime.InteropServices.ArrayWithOffset b) { return default(bool); }
    }

    [System.FlagsAttribute]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum AssemblyRegistrationFlags
    {
        None = 0,
        SetCodeBase = 1,
    }

    [System.AttributeUsageAttribute((System.AttributeTargets)(1029), Inherited = false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class AutomationProxyAttribute : System.Attribute
    {
        public AutomationProxyAttribute(bool val) { }
        public bool Value { get { return default(bool); } }
    }

    [System.AttributeUsageAttribute((System.AttributeTargets)(1037), Inherited = false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class BestFitMappingAttribute : System.Attribute
    {
        public bool ThrowOnUnmappableChar;
        public BestFitMappingAttribute(bool BestFitMapping) { }
        public bool BestFitMapping { get { return default(bool); } }
    }

    [System.ObsoleteAttribute]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct BIND_OPTS
    {
        public int cbStruct;
        public int dwTickCountDeadline;
        public int grfFlags;
        public int grfMode;
    }

    [System.ObsoleteAttribute]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
    public partial struct BINDPTR
    {
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public System.IntPtr lpfuncdesc;
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public System.IntPtr lptcomp;
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public System.IntPtr lpvardesc;
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class BStrWrapper
    {
        public BStrWrapper(object value) { }
        public BStrWrapper(string value) { }
        public string WrappedObject { get { return default(string); } }
    }

    [System.ObsoleteAttribute]
    public enum CALLCONV
    {
        CC_CDECL = 1,
        CC_MACPASCAL = 3,
        CC_MAX = 9,
        CC_MPWCDECL = 7,
        CC_MPWPASCAL = 8,
        CC_MSCPASCAL = 2,
        CC_PASCAL = 2,
        CC_RESERVED = 5,
        CC_STDCALL = 4,
        CC_SYSCALL = 6,
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum CallingConvention
    {
        Cdecl = 2,
        FastCall = 5,
        StdCall = 3,
        ThisCall = 4,
        Winapi = 1,
    }

    [System.AttributeUsageAttribute((System.AttributeTargets)(1024), Inherited = false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class CoClassAttribute : System.Attribute
    {
        public CoClassAttribute(System.Type coClass) { }
        public System.Type CoClass { get { return default(System.Type); } }
    }

    [System.AttributeUsageAttribute((System.AttributeTargets)(10624), Inherited = false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class ComAliasNameAttribute : System.Attribute
    {
        public ComAliasNameAttribute(string alias) { }
        public string Value { get { return default(string); } }
    }

    [System.AttributeUsageAttribute((System.AttributeTargets)(1), Inherited = false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class ComCompatibleVersionAttribute : System.Attribute
    {
        public ComCompatibleVersionAttribute(int major, int minor, int build, int revision) { }
        public int BuildNumber { get { return default(int); } }
        public int MajorVersion { get { return default(int); } }
        public int MinorVersion { get { return default(int); } }
        public int RevisionNumber { get { return default(int); } }
    }

    [System.AttributeUsageAttribute((System.AttributeTargets)(32767), Inherited = false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class ComConversionLossAttribute : System.Attribute
    {
        public ComConversionLossAttribute() { }
    }

    [System.AttributeUsageAttribute((System.AttributeTargets)(1024), Inherited = false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class ComEventInterfaceAttribute : System.Attribute
    {
        public ComEventInterfaceAttribute(System.Type SourceInterface, System.Type EventProvider) { }
        public System.Type EventProvider { get { return default(System.Type); } }
        public System.Type SourceInterface { get { return default(System.Type); } }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class COMException : System.Runtime.InteropServices.ExternalException
    {
        public COMException() { }
        protected COMException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public COMException(string message) { }
        public COMException(string message, System.Exception inner) { }
        public COMException(string message, int errorCode) { }
        public override string ToString() { return default(string); }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum ComMemberType
    {
        Method = 0,
        PropGet = 1,
        PropSet = 2,
    }

    [System.AttributeUsageAttribute((System.AttributeTargets)(64), Inherited = false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class ComRegisterFunctionAttribute : System.Attribute
    {
        public ComRegisterFunctionAttribute() { }
    }

    [System.AttributeUsageAttribute((System.AttributeTargets)(4), Inherited = true)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class ComSourceInterfacesAttribute : System.Attribute
    {
        public ComSourceInterfacesAttribute(string sourceInterfaces) { }
        public ComSourceInterfacesAttribute(System.Type sourceInterface) { }
        public ComSourceInterfacesAttribute(System.Type sourceInterface1, System.Type sourceInterface2) { }
        public ComSourceInterfacesAttribute(System.Type sourceInterface1, System.Type sourceInterface2, System.Type sourceInterface3) { }
        public ComSourceInterfacesAttribute(System.Type sourceInterface1, System.Type sourceInterface2, System.Type sourceInterface3, System.Type sourceInterface4) { }
        public string Value { get { return default(string); } }
    }

    [System.AttributeUsageAttribute((System.AttributeTargets)(64), Inherited = false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class ComUnregisterFunctionAttribute : System.Attribute
    {
        public ComUnregisterFunctionAttribute() { }
    }

    [System.ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.CONNECTDATA instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct CONNECTDATA
    {
        public int dwCookie;
        public object pUnk;
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class CurrencyWrapper
    {
        public CurrencyWrapper(decimal obj) { }
        public CurrencyWrapper(object obj) { }
        public decimal WrappedObject { get { return default(decimal); } }
    }

    [System.AttributeUsageAttribute((System.AttributeTargets)(2), Inherited = false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class DefaultCharSetAttribute : System.Attribute
    {
        public DefaultCharSetAttribute(System.Runtime.InteropServices.CharSet charSet) { }
        public System.Runtime.InteropServices.CharSet CharSet { get { return default(System.Runtime.InteropServices.CharSet); } }
    }

    [System.AttributeUsageAttribute((System.AttributeTargets)(65), AllowMultiple = false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public sealed partial class DefaultDllImportSearchPathsAttribute : System.Attribute
    {
        public DefaultDllImportSearchPathsAttribute(System.Runtime.InteropServices.DllImportSearchPath paths) { }
        public System.Runtime.InteropServices.DllImportSearchPath Paths { get { return default(System.Runtime.InteropServices.DllImportSearchPath); } }
    }

    [System.ObsoleteAttribute]
    public enum DESCKIND
    {
        DESCKIND_FUNCDESC = 1,
        DESCKIND_IMPLICITAPPOBJ = 4,
        DESCKIND_MAX = 5,
        DESCKIND_NONE = 0,
        DESCKIND_TYPECOMP = 3,
        DESCKIND_VARDESC = 2,
    }

    [System.ObsoleteAttribute]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct DISPPARAMS
    {
        public int cArgs;
        public int cNamedArgs;
        public System.IntPtr rgdispidNamedArgs;
        public System.IntPtr rgvarg;
    }

    [System.AttributeUsageAttribute((System.AttributeTargets)(64), Inherited = false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class DllImportAttribute : System.Attribute
    {
        public bool BestFitMapping;
        public System.Runtime.InteropServices.CallingConvention CallingConvention;
        public System.Runtime.InteropServices.CharSet CharSet;
        public string EntryPoint;
        public bool ExactSpelling;
        public bool PreserveSig;
        public bool SetLastError;
        public bool ThrowOnUnmappableChar;
        public DllImportAttribute(string dllName) { }
        public string Value { get { return default(string); } }
    }

    [System.FlagsAttribute]
    public enum DllImportSearchPath
    {
        ApplicationDirectory = 512,
        AssemblyDirectory = 2,
        LegacyBehavior = 0,
        SafeDirectories = 4096,
        System32 = 2048,
        UseDllDirectoryForDependencies = 256,
        UserDirectories = 1024,
    }

    [System.ObsoleteAttribute]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct ELEMDESC
    {
        public System.Runtime.InteropServices.ELEMDESC.DESCUNION desc;
        public System.Runtime.InteropServices.TYPEDESC tdesc;
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
        public partial struct DESCUNION
        {
            [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
            public System.Runtime.InteropServices.IDLDESC idldesc;
            [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
            public System.Runtime.InteropServices.PARAMDESC paramdesc;
        }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum ExporterEventKind
    {
        ERROR_REFTOINVALIDASSEMBLY = 2,
        NOTIF_CONVERTWARNING = 1,
        NOTIF_TYPECONVERTED = 0,
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class ExtensibleClassFactory
    {
        internal ExtensibleClassFactory() { }
        public static void RegisterObjectCreationCallback(System.Runtime.InteropServices.ObjectCreationDelegate callback) { }
    }

    [System.ObsoleteAttribute]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct FILETIME
    {
        public int dwHighDateTime;
        public int dwLowDateTime;
    }

    [System.ObsoleteAttribute]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct FUNCDESC
    {
        public System.Runtime.InteropServices.CALLCONV callconv;
        public short cParams;
        public short cParamsOpt;
        public short cScodes;
        public System.Runtime.InteropServices.ELEMDESC elemdescFunc;
        public System.Runtime.InteropServices.FUNCKIND funckind;
        public System.Runtime.InteropServices.INVOKEKIND invkind;
        public System.IntPtr lprgelemdescParam;
        public System.IntPtr lprgscode;
        public int memid;
        public short oVft;
        public short wFuncFlags;
    }

    [System.FlagsAttribute]
    [System.ObsoleteAttribute]
    public enum FUNCFLAGS
    {
        FUNCFLAG_FBINDABLE = 4,
        FUNCFLAG_FDEFAULTBIND = 32,
        FUNCFLAG_FDEFAULTCOLLELEM = 256,
        FUNCFLAG_FDISPLAYBIND = 16,
        FUNCFLAG_FHIDDEN = 64,
        FUNCFLAG_FIMMEDIATEBIND = 4096,
        FUNCFLAG_FNONBROWSABLE = 1024,
        FUNCFLAG_FREPLACEABLE = 2048,
        FUNCFLAG_FREQUESTEDIT = 8,
        FUNCFLAG_FRESTRICTED = 1,
        FUNCFLAG_FSOURCE = 2,
        FUNCFLAG_FUIDEFAULT = 512,
        FUNCFLAG_FUSESGETLASTERROR = 128,
    }

    [System.ObsoleteAttribute]
    public enum FUNCKIND
    {
        FUNC_DISPATCH = 4,
        FUNC_NONVIRTUAL = 2,
        FUNC_PUREVIRTUAL = 1,
        FUNC_STATIC = 3,
        FUNC_VIRTUAL = 0,
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct GCHandle
    {
        public bool IsAllocated { get { return default(bool); } }
        public object Target { get { return default(object); } set { } }
        public System.IntPtr AddrOfPinnedObject() { return default(System.IntPtr); }
        public static System.Runtime.InteropServices.GCHandle Alloc(object value) { return default(System.Runtime.InteropServices.GCHandle); }
        public static System.Runtime.InteropServices.GCHandle Alloc(object value, System.Runtime.InteropServices.GCHandleType type) { return default(System.Runtime.InteropServices.GCHandle); }
        public override bool Equals(object o) { return default(bool); }
        public void Free() { }
        public static System.Runtime.InteropServices.GCHandle FromIntPtr(System.IntPtr value) { return default(System.Runtime.InteropServices.GCHandle); }
        public override int GetHashCode() { return default(int); }
        public static bool operator ==(System.Runtime.InteropServices.GCHandle a, System.Runtime.InteropServices.GCHandle b) { return default(bool); }
        public static explicit operator System.Runtime.InteropServices.GCHandle(System.IntPtr value) { return default(System.Runtime.InteropServices.GCHandle); }
        public static explicit operator System.IntPtr(System.Runtime.InteropServices.GCHandle value) { return default(System.IntPtr); }
        public static bool operator !=(System.Runtime.InteropServices.GCHandle a, System.Runtime.InteropServices.GCHandle b) { return default(bool); }
        public static System.IntPtr ToIntPtr(System.Runtime.InteropServices.GCHandle value) { return default(System.IntPtr); }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum GCHandleType
    {
        Normal = 2,
        Pinned = 3,
        Weak = 0,
        WeakTrackResurrection = 1,
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct HandleRef
    {
        public HandleRef(object wrapper, System.IntPtr handle) { throw new System.NotImplementedException(); }
        public System.IntPtr Handle { get { return default(System.IntPtr); } }
        public object Wrapper { get { return default(object); } }
        public static explicit operator System.IntPtr(System.Runtime.InteropServices.HandleRef value) { return default(System.IntPtr); }
        public static System.IntPtr ToIntPtr(System.Runtime.InteropServices.HandleRef value) { return default(System.IntPtr); }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface ICustomAdapter
    {
        object GetUnderlyingObject();
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface ICustomMarshaler
    {
        void CleanUpManagedData(object ManagedObj);
        void CleanUpNativeData(System.IntPtr pNativeData);
        int GetNativeDataSize();
        System.IntPtr MarshalManagedToNative(object ManagedObj);
        object MarshalNativeToManaged(System.IntPtr pNativeData);
    }

    [System.AttributeUsageAttribute((System.AttributeTargets)(5), Inherited = false)]
    [System.ObsoleteAttribute("This attribute is deprecated and will be removed in a future version.", false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class IDispatchImplAttribute : System.Attribute
    {
        public IDispatchImplAttribute(short implType) { }
        public IDispatchImplAttribute(System.Runtime.InteropServices.IDispatchImplType implType) { }
        public System.Runtime.InteropServices.IDispatchImplType Value { get { return default(System.Runtime.InteropServices.IDispatchImplType); } }
    }

    [System.ObsoleteAttribute("The IDispatchImplAttribute is deprecated.", false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum IDispatchImplType
    {
        CompatibleImpl = 2,
        InternalImpl = 1,
        SystemDefinedImpl = 0,
    }

    [System.ObsoleteAttribute]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct IDLDESC
    {
        public int dwReserved;
        public System.Runtime.InteropServices.IDLFLAG wIDLFlags;
    }

    [System.FlagsAttribute]
    [System.ObsoleteAttribute]
    public enum IDLFLAG
    {
        IDLFLAG_FIN = 1,
        IDLFLAG_FLCID = 4,
        IDLFLAG_FOUT = 2,
        IDLFLAG_FRETVAL = 8,
        IDLFLAG_NONE = 0,
    }

    [System.FlagsAttribute]
    [System.ObsoleteAttribute]
    public enum IMPLTYPEFLAGS
    {
        IMPLTYPEFLAG_FDEFAULT = 1,
        IMPLTYPEFLAG_FDEFAULTVTABLE = 8,
        IMPLTYPEFLAG_FRESTRICTED = 4,
        IMPLTYPEFLAG_FSOURCE = 2,
    }

    [System.AttributeUsageAttribute((System.AttributeTargets)(1), Inherited = false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class ImportedFromTypeLibAttribute : System.Attribute
    {
        public ImportedFromTypeLibAttribute(string tlbFile) { }
        public string Value { get { return default(string); } }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum ImporterEventKind
    {
        ERROR_REFTOINVALIDTYPELIB = 2,
        NOTIF_CONVERTWARNING = 1,
        NOTIF_TYPECONVERTED = 0,
    }

    [System.AttributeUsageAttribute((System.AttributeTargets)(2048), Inherited = false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class InAttribute : System.Attribute
    {
        public InAttribute() { }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class InvalidComObjectException : System.SystemException
    {
        public InvalidComObjectException() { }
        protected InvalidComObjectException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public InvalidComObjectException(string message) { }
        public InvalidComObjectException(string message, System.Exception inner) { }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class InvalidOleVariantTypeException : System.SystemException
    {
        public InvalidOleVariantTypeException() { }
        protected InvalidOleVariantTypeException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public InvalidOleVariantTypeException(string message) { }
        public InvalidOleVariantTypeException(string message, System.Exception inner) { }
    }

    [System.ObsoleteAttribute]
    public enum INVOKEKIND
    {
        INVOKE_FUNC = 1,
        INVOKE_PROPERTYGET = 2,
        INVOKE_PROPERTYPUT = 4,
        INVOKE_PROPERTYPUTREF = 8,
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("CCBD682C-73A5-4568-B8B0-C7007E11ABA2")]
    public partial interface IRegistrationServices
    {
        System.Guid GetManagedCategoryGuid();
        string GetProgIdForType(System.Type type);
        System.Type[] GetRegistrableTypesInAssembly(System.Reflection.Assembly assembly);
        bool RegisterAssembly(System.Reflection.Assembly assembly, System.Runtime.InteropServices.AssemblyRegistrationFlags flags);
        void RegisterTypeForComClients(System.Type type, ref System.Guid g);
        bool TypeRepresentsComType(System.Type type);
        bool TypeRequiresRegistration(System.Type type);
        bool UnregisterAssembly(System.Reflection.Assembly assembly);
    }

    [System.AttributeUsageAttribute((System.AttributeTargets)(64), Inherited = false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class LCIDConversionAttribute : System.Attribute
    {
        public LCIDConversionAttribute(int lcid) { }
        public int Value { get { return default(int); } }
    }

    [System.FlagsAttribute]
    [System.ObsoleteAttribute]
    public enum LIBFLAGS
    {
        LIBFLAG_FCONTROL = 2,
        LIBFLAG_FHASDISKIMAGE = 8,
        LIBFLAG_FHIDDEN = 4,
        LIBFLAG_FRESTRICTED = 1,
    }

    public static partial class Marshal
    {
        public static readonly int SystemDefaultCharSize;
        public static readonly int SystemMaxDBCSCharSize;
        public static int AddRef(System.IntPtr pUnk) { return default(int); }
        public static System.IntPtr AllocCoTaskMem(int cb) { return default(System.IntPtr); }
        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute((System.Runtime.ConstrainedExecution.Consistency)(3), (System.Runtime.ConstrainedExecution.Cer)(1))]
        public static System.IntPtr AllocHGlobal(int cb) { return default(System.IntPtr); }
        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute((System.Runtime.ConstrainedExecution.Consistency)(3), (System.Runtime.ConstrainedExecution.Cer)(1))]
        public static System.IntPtr AllocHGlobal(System.IntPtr cb) { return default(System.IntPtr); }
        public static object BindToMoniker(string monikerName) { return default(object); }
        public static void ChangeWrapperHandleStrength(object otp, bool fIsWeak) { }
        public static void Copy(byte[] source, int startIndex, System.IntPtr destination, int length) { }
        public static void Copy(char[] source, int startIndex, System.IntPtr destination, int length) { }
        public static void Copy(double[] source, int startIndex, System.IntPtr destination, int length) { }
        public static void Copy(short[] source, int startIndex, System.IntPtr destination, int length) { }
        public static void Copy(int[] source, int startIndex, System.IntPtr destination, int length) { }
        public static void Copy(long[] source, int startIndex, System.IntPtr destination, int length) { }
        public static void Copy(System.IntPtr source, byte[] destination, int startIndex, int length) { }
        public static void Copy(System.IntPtr source, char[] destination, int startIndex, int length) { }
        public static void Copy(System.IntPtr source, double[] destination, int startIndex, int length) { }
        public static void Copy(System.IntPtr source, short[] destination, int startIndex, int length) { }
        public static void Copy(System.IntPtr source, int[] destination, int startIndex, int length) { }
        public static void Copy(System.IntPtr source, long[] destination, int startIndex, int length) { }
        public static void Copy(System.IntPtr source, System.IntPtr[] destination, int startIndex, int length) { }
        public static void Copy(System.IntPtr source, float[] destination, int startIndex, int length) { }
        public static void Copy(System.IntPtr[] source, int startIndex, System.IntPtr destination, int length) { }
        public static void Copy(float[] source, int startIndex, System.IntPtr destination, int length) { }
        public static System.IntPtr CreateAggregatedObject(System.IntPtr pOuter, object o) { return default(System.IntPtr); }
        public static System.IntPtr CreateAggregatedObject<T>(System.IntPtr pOuter, T o) { return default(System.IntPtr); }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public static void DestroyStructure(System.IntPtr ptr, System.Type structuretype) { }
        public static void DestroyStructure<T>(System.IntPtr ptr) { }
        public static void FreeBSTR(System.IntPtr ptr) { }
        public static void FreeCoTaskMem(System.IntPtr ptr) { }
        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute((System.Runtime.ConstrainedExecution.Consistency)(3), (System.Runtime.ConstrainedExecution.Cer)(2))]
        public static void FreeHGlobal(System.IntPtr hglobal) { }
        public static System.Delegate GetDelegateForFunctionPointer(System.IntPtr ptr, System.Type t) { return default(System.Delegate); }
        public static TDelegate GetDelegateForFunctionPointer<TDelegate>(System.IntPtr ptr) { return default(TDelegate); }
        public static System.Exception GetExceptionForHR(int errorCode) { return default(System.Exception); }
        public static System.Exception GetExceptionForHR(int errorCode, System.IntPtr errorInfo) { return default(System.Exception); }
        public static System.IntPtr GetFunctionPointerForDelegate(System.Delegate d) { return default(System.IntPtr); }
        public static System.IntPtr GetFunctionPointerForDelegate<TDelegate>(TDelegate d) { return default(System.IntPtr); }
        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute((System.Runtime.ConstrainedExecution.Consistency)(3), (System.Runtime.ConstrainedExecution.Cer)(2))]
        public static int GetLastWin32Error() { return default(int); }
        public static System.IntPtr OffsetOf(System.Type t, string fieldName) { return default(System.IntPtr); }
        public static System.IntPtr OffsetOf<T>(string fieldName) { return default(System.IntPtr); }
        public static void Prelink(System.Reflection.MethodInfo m) { }
        public static void PrelinkAll(System.Type c) { }
        public static string PtrToStringAnsi(System.IntPtr ptr) { return default(string); }
        public static string PtrToStringAnsi(System.IntPtr ptr, int len) { return default(string); }
        public static string PtrToStringAuto(System.IntPtr ptr) { return default(string); }
        public static string PtrToStringAuto(System.IntPtr ptr, int len) { return default(string); }
        public static string PtrToStringBSTR(System.IntPtr ptr) { return default(string); }
        public static string PtrToStringUni(System.IntPtr ptr) { return default(string); }
        public static string PtrToStringUni(System.IntPtr ptr, int len) { return default(string); }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public static void PtrToStructure(System.IntPtr ptr, object structure) { }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public static object PtrToStructure(System.IntPtr ptr, System.Type structureType) { return default(object); }
        public static T PtrToStructure<T>(System.IntPtr ptr) { return default(T); }
        public static void PtrToStructure<T>(System.IntPtr ptr, T structure) { }
        public static int QueryInterface(System.IntPtr pUnk, ref System.Guid iid, out System.IntPtr ppv) { ppv = default(System.IntPtr); return default(int); }
        public static byte ReadByte(System.IntPtr ptr) { return default(byte); }
        public static byte ReadByte(System.IntPtr ptr, int ofs) { return default(byte); }
        public static byte ReadByte(object ptr, int ofs) { return default(byte); }
        public static short ReadInt16(System.IntPtr ptr) { return default(short); }
        public static short ReadInt16(System.IntPtr ptr, int ofs) { return default(short); }
        public static short ReadInt16(object ptr, int ofs) { return default(short); }
        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute((System.Runtime.ConstrainedExecution.Consistency)(3), (System.Runtime.ConstrainedExecution.Cer)(2))]
        public static int ReadInt32(System.IntPtr ptr) { return default(int); }
        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute((System.Runtime.ConstrainedExecution.Consistency)(3), (System.Runtime.ConstrainedExecution.Cer)(2))]
        public static int ReadInt32(System.IntPtr ptr, int ofs) { return default(int); }
        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute((System.Runtime.ConstrainedExecution.Consistency)(3), (System.Runtime.ConstrainedExecution.Cer)(2))]
        public static int ReadInt32(object ptr, int ofs) { return default(int); }
        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute((System.Runtime.ConstrainedExecution.Consistency)(3), (System.Runtime.ConstrainedExecution.Cer)(2))]
        public static long ReadInt64(System.IntPtr ptr) { return default(long); }
        public static long ReadInt64(System.IntPtr ptr, int ofs) { return default(long); }
        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute((System.Runtime.ConstrainedExecution.Consistency)(3), (System.Runtime.ConstrainedExecution.Cer)(2))]
        public static long ReadInt64(object ptr, int ofs) { return default(long); }
        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute((System.Runtime.ConstrainedExecution.Consistency)(3), (System.Runtime.ConstrainedExecution.Cer)(2))]
        public static System.IntPtr ReadIntPtr(System.IntPtr ptr) { return default(System.IntPtr); }
        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute((System.Runtime.ConstrainedExecution.Consistency)(3), (System.Runtime.ConstrainedExecution.Cer)(2))]
        public static System.IntPtr ReadIntPtr(System.IntPtr ptr, int ofs) { return default(System.IntPtr); }
        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute((System.Runtime.ConstrainedExecution.Consistency)(3), (System.Runtime.ConstrainedExecution.Cer)(2))]
        public static System.IntPtr ReadIntPtr(object ptr, int ofs) { return default(System.IntPtr); }
        public static System.IntPtr ReAllocCoTaskMem(System.IntPtr pv, int cb) { return default(System.IntPtr); }
        public static System.IntPtr ReAllocHGlobal(System.IntPtr pv, System.IntPtr cb) { return default(System.IntPtr); }
        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute((System.Runtime.ConstrainedExecution.Consistency)(3), (System.Runtime.ConstrainedExecution.Cer)(2))]
        public static int Release(System.IntPtr pUnk) { return default(int); }
        public static System.IntPtr SecureStringToBSTR(System.Security.SecureString s) { return default(System.IntPtr); }
        public static System.IntPtr SecureStringToCoTaskMemAnsi(System.Security.SecureString s) { return default(System.IntPtr); }
        public static System.IntPtr SecureStringToCoTaskMemUnicode(System.Security.SecureString s) { return default(System.IntPtr); }
        public static System.IntPtr SecureStringToGlobalAllocAnsi(System.Security.SecureString s) { return default(System.IntPtr); }
        public static System.IntPtr SecureStringToGlobalAllocUnicode(System.Security.SecureString s) { return default(System.IntPtr); }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public static int SizeOf(object structure) { return default(int); }
        public static int SizeOf(System.Type t) { return default(int); }
        public static int SizeOf<T>() { return default(int); }
        public static int SizeOf<T>(T structure) { return default(int); }
        public static System.IntPtr StringToBSTR(string s) { return default(System.IntPtr); }
        public static System.IntPtr StringToCoTaskMemAnsi(string s) { return default(System.IntPtr); }
        public static System.IntPtr StringToCoTaskMemAuto(string s) { return default(System.IntPtr); }
        public static System.IntPtr StringToCoTaskMemUni(string s) { return default(System.IntPtr); }
        public static System.IntPtr StringToHGlobalAnsi(string s) { return default(System.IntPtr); }
        public static System.IntPtr StringToHGlobalAuto(string s) { return default(System.IntPtr); }
        public static System.IntPtr StringToHGlobalUni(string s) { return default(System.IntPtr); }
        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute((System.Runtime.ConstrainedExecution.Consistency)(3), (System.Runtime.ConstrainedExecution.Cer)(1))]
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public static void StructureToPtr(object structure, System.IntPtr ptr, bool fDeleteOld) { }
        public static void StructureToPtr<T>(T structure, System.IntPtr ptr, bool fDeleteOld) { }
        public static void ThrowExceptionForHR(int errorCode) { }
        public static void ThrowExceptionForHR(int errorCode, System.IntPtr errorInfo) { }
        public static System.IntPtr UnsafeAddrOfPinnedArrayElement(System.Array arr, int index) { return default(System.IntPtr); }
        public static System.IntPtr UnsafeAddrOfPinnedArrayElement<T>(T[] arr, int index) { return default(System.IntPtr); }
        public static void WriteByte(System.IntPtr ptr, byte val) { }
        public static void WriteByte(System.IntPtr ptr, int ofs, byte val) { }
        public static void WriteByte(object ptr, int ofs, byte val) { ptr = default(object); }
        public static void WriteInt16(System.IntPtr ptr, char val) { }
        public static void WriteInt16(System.IntPtr ptr, short val) { }
        public static void WriteInt16(System.IntPtr ptr, int ofs, char val) { }
        public static void WriteInt16(System.IntPtr ptr, int ofs, short val) { }
        public static void WriteInt16(object ptr, int ofs, char val) { ptr = default(object); }
        public static void WriteInt16(object ptr, int ofs, short val) { ptr = default(object); }
        public static void WriteInt32(System.IntPtr ptr, int val) { }
        public static void WriteInt32(System.IntPtr ptr, int ofs, int val) { }
        public static void WriteInt32(object ptr, int ofs, int val) { ptr = default(object); }
        public static void WriteInt64(System.IntPtr ptr, int ofs, long val) { }
        public static void WriteInt64(System.IntPtr ptr, long val) { }
        public static void WriteInt64(object ptr, int ofs, long val) { ptr = default(object); }
        public static void WriteIntPtr(System.IntPtr ptr, int ofs, System.IntPtr val) { }
        public static void WriteIntPtr(System.IntPtr ptr, System.IntPtr val) { }
        public static void WriteIntPtr(object ptr, int ofs, System.IntPtr val) { ptr = default(object); }
        public static void ZeroFreeBSTR(System.IntPtr s) { }
        public static void ZeroFreeCoTaskMemAnsi(System.IntPtr s) { }
        public static void ZeroFreeCoTaskMemUnicode(System.IntPtr s) { }
        public static void ZeroFreeGlobalAllocAnsi(System.IntPtr s) { }
        public static void ZeroFreeGlobalAllocUnicode(System.IntPtr s) { }
        [System.Security.SecurityCriticalAttribute]
        public static bool AreComObjectsAvailableForCleanup() { return default(bool); }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("CreateWrapperOfType(Object, Type) may be unavailable in future releases. Instead, use CreateWrapperOfType<T,T2>(T). For more info, go to http://go.microsoft.com/fwlink/?LinkID=296519")]
        [System.Security.SecurityCriticalAttribute]
        public static object CreateWrapperOfType(object o, System.Type t) { return default(object); }
        [System.Security.SecurityCriticalAttribute]
        public static TWrapper CreateWrapperOfType<T, TWrapper>(T o) { return default(TWrapper); }
        [System.Security.SecurityCriticalAttribute]
        public static int FinalReleaseComObject(object o) { return default(int); }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("GetComInterfaceForObject(Object, Type) may be unavailable in future releases. Instead, use GetComInterfaceForObject<T,T2>(T). For more info, go to http://go.microsoft.com/fwlink/?LinkID=296509")]
        [System.Security.SecurityCriticalAttribute]
        public static System.IntPtr GetComInterfaceForObject(object o, System.Type T) { return default(System.IntPtr); }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("GetComInterfaceForObject(Object, Type, CustomQueryInterfaceMode) and support for ICustomQueryInterface may be unavailable in future releases.")]
        [System.Security.SecurityCriticalAttribute]
        public static System.IntPtr GetComInterfaceForObject(object o, System.Type T, System.Runtime.InteropServices.CustomQueryInterfaceMode mode) { return default(System.IntPtr); }
        [System.Security.SecurityCriticalAttribute]
        public static System.IntPtr GetComInterfaceForObject<T, TInterface>(T o) { return default(System.IntPtr); }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("GetExceptionCode() may be unavailable in future releases.")]
        [System.Security.SecurityCriticalAttribute]
        public static int GetExceptionCode() { return default(int); }
        [System.Security.SecurityCriticalAttribute]
        public static int GetHRForException(System.Exception e) { return default(int); }
        [System.Security.SecurityCriticalAttribute]
        public static int GetHRForLastWin32Error() { return default(int); }
        [System.Security.SecurityCriticalAttribute]
        public static System.IntPtr GetIUnknownForObject(object o) { return default(System.IntPtr); }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("GetNativeVariantForObject(Object, IntPtr) may be unavailable in future releases.")]
        [System.Security.SecurityCriticalAttribute]
        public static void GetNativeVariantForObject(object obj, System.IntPtr pDstNativeVariant) { }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("GetNativeVariantForObject<T>(T, IntPtr) may be unavailable in future releases.")]
        [System.Security.SecurityCriticalAttribute]
        public static void GetNativeVariantForObject<T>(T obj, System.IntPtr pDstNativeVariant) { }
        [System.Security.SecurityCriticalAttribute]
        public static object GetObjectForIUnknown(System.IntPtr pUnk) { return default(object); }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("GetObjectForNativeVariant(IntPtr) may be unavailable in future releases.")]
        [System.Security.SecurityCriticalAttribute]
        public static object GetObjectForNativeVariant(System.IntPtr pSrcNativeVariant) { return default(object); }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("GetObjectForNativeVariant<T>(IntPtr) may be unavailable in future releases.")]
        [System.Security.SecurityCriticalAttribute]
        public static T GetObjectForNativeVariant<T>(System.IntPtr pSrcNativeVariant) { return default(T); }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("GetObjectsForNativeVariants(IntPtr, Int32) may be unavailable in future releases.")]
        [System.Security.SecurityCriticalAttribute]
        public static object[] GetObjectsForNativeVariants(System.IntPtr aSrcNativeVariant, int cVars) { return default(object[]); }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("GetObjectsForNativeVariants<T>(IntPtr, Int32) may be unavailable in future releases.")]
        [System.Security.SecurityCriticalAttribute]
        public static T[] GetObjectsForNativeVariants<T>(System.IntPtr aSrcNativeVariant, int cVars) { return default(T[]); }
        [System.Security.SecurityCriticalAttribute]
        public static int GetStartComSlot(System.Type t) { return default(int); }
        public static System.Type GetTypeFromCLSID(System.Guid clsid) { return default(System.Type); }
        [System.Security.SecurityCriticalAttribute]
        public static string GetTypeInfoName(System.Runtime.InteropServices.ComTypes.ITypeInfo typeInfo) { return default(string); }
        [System.Security.SecurityCriticalAttribute]
        public static object GetUniqueObjectForIUnknown(System.IntPtr unknown) { return default(object); }
        public static bool IsComObject(object o) { return default(bool); }
        [System.Security.SecurityCriticalAttribute]
        public static int ReleaseComObject(object o) { return default(int); }
    }

    [System.AttributeUsageAttribute((System.AttributeTargets)(10496), Inherited = false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class MarshalAsAttribute : System.Attribute
    {
        public System.Runtime.InteropServices.UnmanagedType ArraySubType;
        public int IidParameterIndex;
        public string MarshalCookie;
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public string MarshalType;
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public System.Type MarshalTypeRef;
        public System.Runtime.InteropServices.VarEnum SafeArraySubType;
        public System.Type SafeArrayUserDefinedSubType;
        public int SizeConst;
        public short SizeParamIndex;
        public MarshalAsAttribute(short unmanagedType) { }
        public MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType unmanagedType) { }
        public System.Runtime.InteropServices.UnmanagedType Value { get { return default(System.Runtime.InteropServices.UnmanagedType); } }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class MarshalDirectiveException : System.SystemException
    {
        public MarshalDirectiveException() { }
        protected MarshalDirectiveException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public MarshalDirectiveException(string message) { }
        public MarshalDirectiveException(string message, System.Exception inner) { }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public delegate System.IntPtr ObjectCreationDelegate(System.IntPtr aggregator);

    [System.AttributeUsageAttribute((System.AttributeTargets)(2048), Inherited = false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class OptionalAttribute : System.Attribute
    {
        public OptionalAttribute() { }
    }

    [System.ObsoleteAttribute]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct PARAMDESC
    {
        public System.IntPtr lpVarValue;
        public System.Runtime.InteropServices.PARAMFLAG wParamFlags;
    }

    [System.FlagsAttribute]
    [System.ObsoleteAttribute]
    public enum PARAMFLAG
    {
        PARAMFLAG_FHASCUSTDATA = 64,
        PARAMFLAG_FHASDEFAULT = 32,
        PARAMFLAG_FIN = 1,
        PARAMFLAG_FLCID = 4,
        PARAMFLAG_FOPT = 16,
        PARAMFLAG_FOUT = 2,
        PARAMFLAG_FRETVAL = 8,
        PARAMFLAG_NONE = 0,
    }

    [System.AttributeUsageAttribute((System.AttributeTargets)(64), Inherited = false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class PreserveSigAttribute : System.Attribute
    {
        public PreserveSigAttribute() { }
    }

    [System.AttributeUsageAttribute((System.AttributeTargets)(1), Inherited = false, AllowMultiple = true)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class PrimaryInteropAssemblyAttribute : System.Attribute
    {
        public PrimaryInteropAssemblyAttribute(int major, int minor) { }
        public int MajorVersion { get { return default(int); } }
        public int MinorVersion { get { return default(int); } }
    }

    [System.AttributeUsageAttribute((System.AttributeTargets)(4), Inherited = false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class ProgIdAttribute : System.Attribute
    {
        public ProgIdAttribute(string progId) { }
        public string Value { get { return default(string); } }
    }

    [System.FlagsAttribute]
    public enum RegistrationClassContext
    {
        DisableActivateAsActivator = 32768,
        EnableActivateAsActivator = 65536,
        EnableCodeDownload = 8192,
        FromDefaultContext = 131072,
        InProcessHandler = 2,
        InProcessHandler16 = 32,
        InProcessServer = 1,
        InProcessServer16 = 8,
        LocalServer = 4,
        NoCodeDownload = 1024,
        NoCustomMarshal = 4096,
        NoFailureLog = 16384,
        RemoteServer = 16,
        Reserved1 = 64,
        Reserved2 = 128,
        Reserved3 = 256,
        Reserved4 = 512,
        Reserved5 = 2048,
    }

    [System.FlagsAttribute]
    public enum RegistrationConnectionType
    {
        MultipleUse = 1,
        MultiSeparate = 2,
        SingleUse = 0,
        Surrogate = 8,
        Suspended = 4,
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class RuntimeEnvironment
    {
        public RuntimeEnvironment() { }
        public static string SystemConfigurationFile { get { return default(string); } }
        public static bool FromGlobalAccessCache(System.Reflection.Assembly a) { return default(bool); }
        public static string GetRuntimeDirectory() { return default(string); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static string GetSystemVersion() { return default(string); }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SafeArrayRankMismatchException : System.SystemException
    {
        public SafeArrayRankMismatchException() { }
        protected SafeArrayRankMismatchException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public SafeArrayRankMismatchException(string message) { }
        public SafeArrayRankMismatchException(string message, System.Exception inner) { }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SafeArrayTypeMismatchException : System.SystemException
    {
        public SafeArrayTypeMismatchException() { }
        protected SafeArrayTypeMismatchException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public SafeArrayTypeMismatchException(string message) { }
        public SafeArrayTypeMismatchException(string message, System.Exception inner) { }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SEHException : System.Runtime.InteropServices.ExternalException
    {
        public SEHException() { }
        protected SEHException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public SEHException(string message) { }
        public SEHException(string message, System.Exception inner) { }
        public virtual bool CanResume() { return default(bool); }
    }

    [System.AttributeUsageAttribute((System.AttributeTargets)(1), Inherited = false)]
    [System.ObsoleteAttribute("This attribute has been deprecated.  Application Domains no longer respect Activation Context boundaries in IDispatch calls.", false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SetWin32ContextInIDispatchAttribute : System.Attribute
    {
        public SetWin32ContextInIDispatchAttribute() { }
    }

    [System.ObsoleteAttribute]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct STATSTG
    {
        public System.Runtime.InteropServices.FILETIME atime;
        public long cbSize;
        public System.Guid clsid;
        public System.Runtime.InteropServices.FILETIME ctime;
        public int grfLocksSupported;
        public int grfMode;
        public int grfStateBits;
        public System.Runtime.InteropServices.FILETIME mtime;
        public string pwcsName;
        public int reserved;
        public int type;
    }

    [System.ObsoleteAttribute]
    public enum SYSKIND
    {
        SYS_MAC = 2,
        SYS_WIN16 = 0,
        SYS_WIN32 = 1,
    }

    [System.ObsoleteAttribute]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct TYPEATTR
    {
        public short cbAlignment;
        public int cbSizeInstance;
        public short cbSizeVft;
        public short cFuncs;
        public short cImplTypes;
        public short cVars;
        public int dwReserved;
        public System.Guid guid;
        public System.Runtime.InteropServices.IDLDESC idldescType;
        public int lcid;
        public System.IntPtr lpstrSchema;
        public const int MEMBER_ID_NIL = -1;
        public int memidConstructor;
        public int memidDestructor;
        public System.Runtime.InteropServices.TYPEDESC tdescAlias;
        public System.Runtime.InteropServices.TYPEKIND typekind;
        public short wMajorVerNum;
        public short wMinorVerNum;
        public System.Runtime.InteropServices.TYPEFLAGS wTypeFlags;
    }

    [System.ObsoleteAttribute]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct TYPEDESC
    {
        public System.IntPtr lpValue;
        public short vt;
    }

    [System.FlagsAttribute]
    [System.ObsoleteAttribute]
    public enum TYPEFLAGS
    {
        TYPEFLAG_FAGGREGATABLE = 1024,
        TYPEFLAG_FAPPOBJECT = 1,
        TYPEFLAG_FCANCREATE = 2,
        TYPEFLAG_FCONTROL = 32,
        TYPEFLAG_FDISPATCHABLE = 4096,
        TYPEFLAG_FDUAL = 64,
        TYPEFLAG_FHIDDEN = 16,
        TYPEFLAG_FLICENSED = 4,
        TYPEFLAG_FNONEXTENSIBLE = 128,
        TYPEFLAG_FOLEAUTOMATION = 256,
        TYPEFLAG_FPREDECLID = 8,
        TYPEFLAG_FPROXY = 16384,
        TYPEFLAG_FREPLACEABLE = 2048,
        TYPEFLAG_FRESTRICTED = 512,
        TYPEFLAG_FREVERSEBIND = 8192,
    }

    [System.AttributeUsageAttribute((System.AttributeTargets)(5144), AllowMultiple = false, Inherited = false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public sealed partial class TypeIdentifierAttribute : System.Attribute
    {
        public TypeIdentifierAttribute() { }
        public TypeIdentifierAttribute(string scope, string identifier) { }
        public string Identifier { get { return default(string); } }
        public string Scope { get { return default(string); } }
    }

    [System.ObsoleteAttribute]
    public enum TYPEKIND
    {
        TKIND_ALIAS = 6,
        TKIND_COCLASS = 5,
        TKIND_DISPATCH = 4,
        TKIND_ENUM = 0,
        TKIND_INTERFACE = 3,
        TKIND_MAX = 8,
        TKIND_MODULE = 2,
        TKIND_RECORD = 1,
        TKIND_UNION = 7,
    }

    [System.ObsoleteAttribute]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct TYPELIBATTR
    {
        public System.Guid guid;
        public int lcid;
        public System.Runtime.InteropServices.SYSKIND syskind;
        public System.Runtime.InteropServices.LIBFLAGS wLibFlags;
        public short wMajorVerNum;
        public short wMinorVerNum;
    }

    [System.AttributeUsageAttribute((System.AttributeTargets)(1024), Inherited = false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class TypeLibImportClassAttribute : System.Attribute
    {
        public TypeLibImportClassAttribute(System.Type importClass) { }
        public string Value { get { return default(string); } }
    }

    [System.AttributeUsageAttribute((System.AttributeTargets)(1), Inherited = false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class TypeLibVersionAttribute : System.Attribute
    {
        public TypeLibVersionAttribute(int major, int minor) { }
        public int MajorVersion { get { return default(int); } }
        public int MinorVersion { get { return default(int); } }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class UnknownWrapper
    {
        public UnknownWrapper(object obj) { }
        public object WrappedObject { get { return default(object); } }
    }

    [System.AttributeUsageAttribute((System.AttributeTargets)(4096), AllowMultiple = false, Inherited = false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class UnmanagedFunctionPointerAttribute : System.Attribute
    {
        public bool BestFitMapping;
        public System.Runtime.InteropServices.CharSet CharSet;
        public bool SetLastError;
        public bool ThrowOnUnmappableChar;
        public UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention callingConvention) { }
        public System.Runtime.InteropServices.CallingConvention CallingConvention { get { return default(System.Runtime.InteropServices.CallingConvention); } }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum UnmanagedType
    {
        AnsiBStr = 35,
        AsAny = 40,
        Bool = 2,
        BStr = 19,
        ByValArray = 30,
        ByValTStr = 23,
        Currency = 15,
        CustomMarshaler = 44,
        Error = 45,
        FunctionPtr = 38,
        I1 = 3,
        I2 = 5,
        I4 = 7,
        I8 = 9,
        IDispatch = 26,
        Interface = 28,
        IUnknown = 25,
        LPArray = 42,
        LPStr = 20,
        LPStruct = 43,
        LPTStr = 22,
        LPWStr = 21,
        R4 = 11,
        R8 = 12,
        SafeArray = 29,
        Struct = 27,
        SysInt = 31,
        SysUInt = 32,
        TBStr = 36,
        U1 = 4,
        U2 = 6,
        U4 = 8,
        U8 = 10,
        VariantBool = 37,
        VBByRefStr = 34,
    }

    [System.ObsoleteAttribute]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct VARDESC
    {
        public System.Runtime.InteropServices.ELEMDESC elemdescVar;
        public string lpstrSchema;
        public int memid;
        public System.Runtime.InteropServices.VarEnum varkind;
        public short wVarFlags;
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
        public partial struct DESCUNION
        {
            [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
            public System.IntPtr lpvarValue;
            [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
            public int oInst;
        }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum VarEnum
    {
        VT_ARRAY = 8192,
        VT_BLOB = 65,
        VT_BLOB_OBJECT = 70,
        VT_BOOL = 11,
        VT_BSTR = 8,
        VT_BYREF = 16384,
        VT_CARRAY = 28,
        VT_CF = 71,
        VT_CLSID = 72,
        VT_CY = 6,
        VT_DATE = 7,
        VT_DECIMAL = 14,
        VT_EMPTY = 0,
        VT_ERROR = 10,
        VT_FILETIME = 64,
        VT_HRESULT = 25,
        VT_I1 = 16,
        VT_I2 = 2,
        VT_I4 = 3,
        VT_I8 = 20,
        VT_INT = 22,
        VT_LPSTR = 30,
        VT_LPWSTR = 31,
        VT_NULL = 1,
        VT_PTR = 26,
        VT_R4 = 4,
        VT_R8 = 5,
        VT_RECORD = 36,
        VT_SAFEARRAY = 27,
        VT_STORAGE = 67,
        VT_STORED_OBJECT = 69,
        VT_STREAM = 66,
        VT_STREAMED_OBJECT = 68,
        VT_UI1 = 17,
        VT_UI2 = 18,
        VT_UI4 = 19,
        VT_UI8 = 21,
        VT_UINT = 23,
        VT_UNKNOWN = 13,
        VT_USERDEFINED = 29,
        VT_VARIANT = 12,
        VT_VECTOR = 4096,
        VT_VOID = 24,
    }

    [System.FlagsAttribute]
    [System.ObsoleteAttribute]
    public enum VARFLAGS
    {
        VARFLAG_FBINDABLE = 4,
        VARFLAG_FDEFAULTBIND = 32,
        VARFLAG_FDEFAULTCOLLELEM = 256,
        VARFLAG_FDISPLAYBIND = 16,
        VARFLAG_FHIDDEN = 64,
        VARFLAG_FIMMEDIATEBIND = 4096,
        VARFLAG_FNONBROWSABLE = 1024,
        VARFLAG_FREADONLY = 1,
        VARFLAG_FREPLACEABLE = 2048,
        VARFLAG_FREQUESTEDIT = 8,
        VARFLAG_FRESTRICTED = 128,
        VARFLAG_FSOURCE = 2,
        VARFLAG_FUIDEFAULT = 512,
    }

    public sealed partial class VariantWrapper
    {
        public VariantWrapper(object obj) { }
        public object WrappedObject { get { return default(object); } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(2048))]
    public sealed partial class DefaultParameterValueAttribute : System.Attribute
    {
        public DefaultParameterValueAttribute(object value) { }
        public object Value { get { return default(object); } }
    }

    public sealed partial class HandleCollector
    {
        public HandleCollector(string name, int initialThreshold) { }
        public HandleCollector(string name, int initialThreshold, int maximumThreshold) { }
        public int Count { get { return default(int); } }
        public int InitialThreshold { get { return default(int); } }
        public int MaximumThreshold { get { return default(int); } }
        public string Name { get { return default(string); } }
        public void Add() { }
        public void Remove() { }
    }

    // this type was manually added as we don't have a compatible (with Xamarin) implementation in CoreFx
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.ObsoleteAttribute("ComAwareEventInfo may be unavailable in future releases.")]
    public partial class ComAwareEventInfo : System.Reflection.EventInfo
    {
        public ComAwareEventInfo(System.Type type, string eventName) { }
        public override System.Reflection.EventAttributes Attributes { get { return default(System.Reflection.EventAttributes); } }
        public override System.Type DeclaringType { get { return default(System.Type); } }
        public override string Name { get { return default(string); } }

        public override Type ReflectedType
        {
            get {
                throw new NotImplementedException();
            }
        }

        public override System.Reflection.MethodInfo GetAddMethod(bool nonPublic)
        {
            throw new NotImplementedException();
        }

        public override object[] GetCustomAttributes(bool inherit)
        {
            throw new NotImplementedException();
        }

        public override object[] GetCustomAttributes(Type attributeType, bool inherit)
        {
            throw new NotImplementedException();
        }

        public override System.Reflection.MethodInfo GetRaiseMethod(bool nonPublic)
        {
            throw new NotImplementedException();
        }

        public override System.Reflection.MethodInfo GetRemoveMethod(bool nonPublic)
        {
            throw new NotImplementedException();
        }

        public override bool IsDefined(Type attributeType, bool inherit)
        {
            throw new NotImplementedException();
        }
    }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.ObsoleteAttribute("ComEventsHelper may be unavailable in future releases.")]
  public static partial class ComEventsHelper {
    [System.Security.SecurityCriticalAttribute]
    public static void Combine(object rcw, System.Guid iid, int dispid, System.Delegate d) { }
    [System.Security.SecurityCriticalAttribute]
    public static System.Delegate Remove(object rcw, System.Guid iid, int dispid, System.Delegate d) { return default(System.Delegate); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(1028), Inherited=false)]
  public sealed partial class ComImportAttribute : System.Attribute {
    public ComImportAttribute() { }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.ObsoleteAttribute("CustomQueryInterfaceMode and support for ICustomQueryInterface may be unavailable in future releases.")]
  public enum CustomQueryInterfaceMode {
    Allow = 1,
    Ignore = 0,
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.ObsoleteAttribute("CustomQueryInterfaceResult and support for ICustomQueryInterface may be unavailable in future releases.")]
  public enum CustomQueryInterfaceResult {
    Failed = 2,
    Handled = 0,
    NotHandled = 1,
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.ObsoleteAttribute("DispatchWrapper and support for marshalling to the VARIANT type may be unavailable in future releases.")]
  public sealed partial class DispatchWrapper {
    public DispatchWrapper(object obj) { }
    public object WrappedObject { get { return default(object); } }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.ObsoleteAttribute("ErrorWrapper and support for marshalling to the VARIANT type may be unavailable in future releases.")]
  public sealed partial class ErrorWrapper {
    public ErrorWrapper(System.Exception e) { }
    public ErrorWrapper(int errorCode) { }
    public ErrorWrapper(object errorCode) { }
    public int ErrorCode { get { return default(int); } }
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.ObsoleteAttribute("ICustomQueryInterface may be unavailable in future releases.")]
  public partial interface ICustomQueryInterface {
    [System.Security.SecurityCriticalAttribute]
    System.Runtime.InteropServices.CustomQueryInterfaceResult GetInterface(ref System.Guid iid, out System.IntPtr ppv);
  }
} // end of System.Runtime.InteropServices
namespace System.Runtime.InteropServices.ComTypes {
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct BIND_OPTS
    {
        public int cbStruct;
        public int dwTickCountDeadline;
        public int grfFlags;
        public int grfMode;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
    public partial struct BINDPTR
    {
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public System.IntPtr lpfuncdesc;
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public System.IntPtr lptcomp;
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public System.IntPtr lpvardesc;
    }

    public enum CALLCONV
    {
        CC_CDECL = 1,
        CC_MACPASCAL = 3,
        CC_MAX = 9,
        CC_MPWCDECL = 7,
        CC_MPWPASCAL = 8,
        CC_MSCPASCAL = 2,
        CC_PASCAL = 2,
        CC_RESERVED = 5,
        CC_STDCALL = 4,
        CC_SYSCALL = 6,
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct CONNECTDATA
    {
        public int dwCookie;
        public object pUnk;
    }

    public enum DESCKIND
    {
        DESCKIND_FUNCDESC = 1,
        DESCKIND_IMPLICITAPPOBJ = 4,
        DESCKIND_MAX = 5,
        DESCKIND_NONE = 0,
        DESCKIND_TYPECOMP = 3,
        DESCKIND_VARDESC = 2,
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct DISPPARAMS
    {
        public int cArgs;
        public int cNamedArgs;
        public System.IntPtr rgdispidNamedArgs;
        public System.IntPtr rgvarg;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct ELEMDESC
    {
        public System.Runtime.InteropServices.ComTypes.ELEMDESC.DESCUNION desc;
        public System.Runtime.InteropServices.ComTypes.TYPEDESC tdesc;
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
        public partial struct DESCUNION
        {
            [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
            public System.Runtime.InteropServices.ComTypes.IDLDESC idldesc;
            [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
            public System.Runtime.InteropServices.ComTypes.PARAMDESC paramdesc;
        }
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct EXCEPINFO
    {
        public string bstrDescription;
        public string bstrHelpFile;
        public string bstrSource;
        public int dwHelpContext;
        public System.IntPtr pfnDeferredFillIn;
        public System.IntPtr pvReserved;
        public int scode;
        public short wCode;
        public short wReserved;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct FILETIME
    {
        public int dwHighDateTime;
        public int dwLowDateTime;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct FUNCDESC
    {
        public System.Runtime.InteropServices.ComTypes.CALLCONV callconv;
        public short cParams;
        public short cParamsOpt;
        public short cScodes;
        public System.Runtime.InteropServices.ComTypes.ELEMDESC elemdescFunc;
        public System.Runtime.InteropServices.ComTypes.FUNCKIND funckind;
        public System.Runtime.InteropServices.ComTypes.INVOKEKIND invkind;
        public System.IntPtr lprgelemdescParam;
        public System.IntPtr lprgscode;
        public int memid;
        public short oVft;
        public short wFuncFlags;
    }

    [System.FlagsAttribute]
    public enum FUNCFLAGS : short
    {
        FUNCFLAG_FBINDABLE = (short)4,
        FUNCFLAG_FDEFAULTBIND = (short)32,
        FUNCFLAG_FDEFAULTCOLLELEM = (short)256,
        FUNCFLAG_FDISPLAYBIND = (short)16,
        FUNCFLAG_FHIDDEN = (short)64,
        FUNCFLAG_FIMMEDIATEBIND = (short)4096,
        FUNCFLAG_FNONBROWSABLE = (short)1024,
        FUNCFLAG_FREPLACEABLE = (short)2048,
        FUNCFLAG_FREQUESTEDIT = (short)8,
        FUNCFLAG_FRESTRICTED = (short)1,
        FUNCFLAG_FSOURCE = (short)2,
        FUNCFLAG_FUIDEFAULT = (short)512,
        FUNCFLAG_FUSESGETLASTERROR = (short)128,
    }

    public enum FUNCKIND
    {
        FUNC_DISPATCH = 4,
        FUNC_NONVIRTUAL = 2,
        FUNC_PUREVIRTUAL = 1,
        FUNC_STATIC = 3,
        FUNC_VIRTUAL = 0,
    }

    [System.Runtime.InteropServices.GuidAttribute("0000000e-0000-0000-C000-000000000046")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
    public partial interface IBindCtx
    {
        void EnumObjectParam(out System.Runtime.InteropServices.ComTypes.IEnumString ppenum);
        void GetBindOptions(ref System.Runtime.InteropServices.ComTypes.BIND_OPTS pbindopts);
        void GetObjectParam(string pszKey, out object ppunk);
        void GetRunningObjectTable(out System.Runtime.InteropServices.ComTypes.IRunningObjectTable pprot);
        void RegisterObjectBound(object punk);
        void RegisterObjectParam(string pszKey, object punk);
        void ReleaseBoundObjects();
        void RevokeObjectBound(object punk);
        int RevokeObjectParam(string pszKey);
        void SetBindOptions(ref System.Runtime.InteropServices.ComTypes.BIND_OPTS pbindopts);
    }

    [System.Runtime.InteropServices.GuidAttribute("B196B286-BAB4-101A-B69C-00AA00341D07")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
    public partial interface IConnectionPoint
    {
        void Advise(object pUnkSink, out int pdwCookie);
        void EnumConnections(out System.Runtime.InteropServices.ComTypes.IEnumConnections ppEnum);
        void GetConnectionInterface(out System.Guid pIID);
        void GetConnectionPointContainer(out System.Runtime.InteropServices.ComTypes.IConnectionPointContainer ppCPC);
        void Unadvise(int dwCookie);
    }

    [System.Runtime.InteropServices.GuidAttribute("B196B284-BAB4-101A-B69C-00AA00341D07")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
    public partial interface IConnectionPointContainer
    {
        void EnumConnectionPoints(out System.Runtime.InteropServices.ComTypes.IEnumConnectionPoints ppEnum);
        void FindConnectionPoint(ref System.Guid riid, out System.Runtime.InteropServices.ComTypes.IConnectionPoint ppCP);
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct IDLDESC
    {
        public System.IntPtr dwReserved;
        public System.Runtime.InteropServices.ComTypes.IDLFLAG wIDLFlags;
    }

    [System.FlagsAttribute]
    public enum IDLFLAG : short
    {
        IDLFLAG_FIN = (short)1,
        IDLFLAG_FLCID = (short)4,
        IDLFLAG_FOUT = (short)2,
        IDLFLAG_FRETVAL = (short)8,
        IDLFLAG_NONE = (short)0,
    }

    [System.Runtime.InteropServices.GuidAttribute("B196B285-BAB4-101A-B69C-00AA00341D07")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
    public partial interface IEnumConnectionPoints
    {
        void Clone(out System.Runtime.InteropServices.ComTypes.IEnumConnectionPoints ppenum);
        int Next(int celt, System.Runtime.InteropServices.ComTypes.IConnectionPoint[] rgelt, System.IntPtr pceltFetched);
        void Reset();
        int Skip(int celt);
    }

    [System.Runtime.InteropServices.GuidAttribute("B196B287-BAB4-101A-B69C-00AA00341D07")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
    public partial interface IEnumConnections
    {
        void Clone(out System.Runtime.InteropServices.ComTypes.IEnumConnections ppenum);
        int Next(int celt, System.Runtime.InteropServices.ComTypes.CONNECTDATA[] rgelt, System.IntPtr pceltFetched);
        void Reset();
        int Skip(int celt);
    }

    [System.Runtime.InteropServices.GuidAttribute("00000102-0000-0000-C000-000000000046")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
    public partial interface IEnumMoniker
    {
        void Clone(out System.Runtime.InteropServices.ComTypes.IEnumMoniker ppenum);
        int Next(int celt, System.Runtime.InteropServices.ComTypes.IMoniker[] rgelt, System.IntPtr pceltFetched);
        void Reset();
        int Skip(int celt);
    }

    [System.Runtime.InteropServices.GuidAttribute("00000101-0000-0000-C000-000000000046")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
    public partial interface IEnumString
    {
        void Clone(out System.Runtime.InteropServices.ComTypes.IEnumString ppenum);
        int Next(int celt, string[] rgelt, System.IntPtr pceltFetched);
        void Reset();
        int Skip(int celt);
    }

    [System.Runtime.InteropServices.GuidAttribute("00020404-0000-0000-C000-000000000046")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
    public partial interface IEnumVARIANT
    {
        System.Runtime.InteropServices.ComTypes.IEnumVARIANT Clone();
        int Next(int celt, object[] rgVar, System.IntPtr pceltFetched);
        int Reset();
        int Skip(int celt);
    }

    [System.Runtime.InteropServices.GuidAttribute("0000000f-0000-0000-C000-000000000046")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
    public partial interface IMoniker
    {
        void BindToObject(System.Runtime.InteropServices.ComTypes.IBindCtx pbc, System.Runtime.InteropServices.ComTypes.IMoniker pmkToLeft, ref System.Guid riidResult, out object ppvResult);
        void BindToStorage(System.Runtime.InteropServices.ComTypes.IBindCtx pbc, System.Runtime.InteropServices.ComTypes.IMoniker pmkToLeft, ref System.Guid riid, out object ppvObj);
        void CommonPrefixWith(System.Runtime.InteropServices.ComTypes.IMoniker pmkOther, out System.Runtime.InteropServices.ComTypes.IMoniker ppmkPrefix);
        void ComposeWith(System.Runtime.InteropServices.ComTypes.IMoniker pmkRight, bool fOnlyIfNotGeneric, out System.Runtime.InteropServices.ComTypes.IMoniker ppmkComposite);
        void Enum(bool fForward, out System.Runtime.InteropServices.ComTypes.IEnumMoniker ppenumMoniker);
        void GetClassID(out System.Guid pClassID);
        void GetDisplayName(System.Runtime.InteropServices.ComTypes.IBindCtx pbc, System.Runtime.InteropServices.ComTypes.IMoniker pmkToLeft, out string ppszDisplayName);
        void GetSizeMax(out long pcbSize);
        void GetTimeOfLastChange(System.Runtime.InteropServices.ComTypes.IBindCtx pbc, System.Runtime.InteropServices.ComTypes.IMoniker pmkToLeft, out System.Runtime.InteropServices.ComTypes.FILETIME pFileTime);
        void Hash(out int pdwHash);
        void Inverse(out System.Runtime.InteropServices.ComTypes.IMoniker ppmk);
        int IsDirty();
        int IsEqual(System.Runtime.InteropServices.ComTypes.IMoniker pmkOtherMoniker);
        int IsRunning(System.Runtime.InteropServices.ComTypes.IBindCtx pbc, System.Runtime.InteropServices.ComTypes.IMoniker pmkToLeft, System.Runtime.InteropServices.ComTypes.IMoniker pmkNewlyRunning);
        int IsSystemMoniker(out int pdwMksys);
        void Load(System.Runtime.InteropServices.ComTypes.IStream pStm);
        void ParseDisplayName(System.Runtime.InteropServices.ComTypes.IBindCtx pbc, System.Runtime.InteropServices.ComTypes.IMoniker pmkToLeft, string pszDisplayName, out int pchEaten, out System.Runtime.InteropServices.ComTypes.IMoniker ppmkOut);
        void Reduce(System.Runtime.InteropServices.ComTypes.IBindCtx pbc, int dwReduceHowFar, ref System.Runtime.InteropServices.ComTypes.IMoniker ppmkToLeft, out System.Runtime.InteropServices.ComTypes.IMoniker ppmkReduced);
        void RelativePathTo(System.Runtime.InteropServices.ComTypes.IMoniker pmkOther, out System.Runtime.InteropServices.ComTypes.IMoniker ppmkRelPath);
        void Save(System.Runtime.InteropServices.ComTypes.IStream pStm, bool fClearDirty);
    }

    [System.FlagsAttribute]
    public enum IMPLTYPEFLAGS
    {
        IMPLTYPEFLAG_FDEFAULT = 1,
        IMPLTYPEFLAG_FDEFAULTVTABLE = 8,
        IMPLTYPEFLAG_FRESTRICTED = 4,
        IMPLTYPEFLAG_FSOURCE = 2,
    }

    [System.FlagsAttribute]
    public enum INVOKEKIND
    {
        INVOKE_FUNC = 1,
        INVOKE_PROPERTYGET = 2,
        INVOKE_PROPERTYPUT = 4,
        INVOKE_PROPERTYPUTREF = 8,
    }

    [System.Runtime.InteropServices.GuidAttribute("0000010b-0000-0000-C000-000000000046")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
    public partial interface IPersistFile
    {
        void GetClassID(out System.Guid pClassID);
        void GetCurFile(out string ppszFileName);
        int IsDirty();
        void Load(string pszFileName, int dwMode);
        void Save(string pszFileName, bool fRemember);
        void SaveCompleted(string pszFileName);
    }

    [System.Runtime.InteropServices.GuidAttribute("00000010-0000-0000-C000-000000000046")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
    public partial interface IRunningObjectTable
    {
        void EnumRunning(out System.Runtime.InteropServices.ComTypes.IEnumMoniker ppenumMoniker);
        int GetObject(System.Runtime.InteropServices.ComTypes.IMoniker pmkObjectName, out object ppunkObject);
        int GetTimeOfLastChange(System.Runtime.InteropServices.ComTypes.IMoniker pmkObjectName, out System.Runtime.InteropServices.ComTypes.FILETIME pfiletime);
        int IsRunning(System.Runtime.InteropServices.ComTypes.IMoniker pmkObjectName);
        void NoteChangeTime(int dwRegister, ref System.Runtime.InteropServices.ComTypes.FILETIME pfiletime);
        int Register(int grfFlags, object punkObject, System.Runtime.InteropServices.ComTypes.IMoniker pmkObjectName);
        void Revoke(int dwRegister);
    }

    [System.Runtime.InteropServices.GuidAttribute("0000000c-0000-0000-C000-000000000046")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
    public partial interface IStream
    {
        void Clone(out System.Runtime.InteropServices.ComTypes.IStream ppstm);
        void Commit(int grfCommitFlags);
        void CopyTo(System.Runtime.InteropServices.ComTypes.IStream pstm, long cb, System.IntPtr pcbRead, System.IntPtr pcbWritten);
        void LockRegion(long libOffset, long cb, int dwLockType);
        void Read(byte[] pv, int cb, System.IntPtr pcbRead);
        void Revert();
        void Seek(long dlibMove, int dwOrigin, System.IntPtr plibNewPosition);
        void SetSize(long libNewSize);
        void Stat(out System.Runtime.InteropServices.ComTypes.STATSTG pstatstg, int grfStatFlag);
        void UnlockRegion(long libOffset, long cb, int dwLockType);
        void Write(byte[] pv, int cb, System.IntPtr pcbWritten);
    }

    [System.Runtime.InteropServices.GuidAttribute("00020403-0000-0000-C000-000000000046")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
    public partial interface ITypeComp
    {
        void Bind(string szName, int lHashVal, short wFlags, out System.Runtime.InteropServices.ComTypes.ITypeInfo ppTInfo, out System.Runtime.InteropServices.ComTypes.DESCKIND pDescKind, out System.Runtime.InteropServices.ComTypes.BINDPTR pBindPtr);
        void BindType(string szName, int lHashVal, out System.Runtime.InteropServices.ComTypes.ITypeInfo ppTInfo, out System.Runtime.InteropServices.ComTypes.ITypeComp ppTComp);
    }

    [System.Runtime.InteropServices.GuidAttribute("00020401-0000-0000-C000-000000000046")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
    public partial interface ITypeInfo
    {
        void AddressOfMember(int memid, System.Runtime.InteropServices.ComTypes.INVOKEKIND invKind, out System.IntPtr ppv);
        void CreateInstance(object pUnkOuter, ref System.Guid riid, out object ppvObj);
        void GetContainingTypeLib(out System.Runtime.InteropServices.ComTypes.ITypeLib ppTLB, out int pIndex);
        void GetDllEntry(int memid, System.Runtime.InteropServices.ComTypes.INVOKEKIND invKind, System.IntPtr pBstrDllName, System.IntPtr pBstrName, System.IntPtr pwOrdinal);
        void GetDocumentation(int index, out string strName, out string strDocString, out int dwHelpContext, out string strHelpFile);
        void GetFuncDesc(int index, out System.IntPtr ppFuncDesc);
        void GetIDsOfNames(string[] rgszNames, int cNames, int[] pMemId);
        void GetImplTypeFlags(int index, out System.Runtime.InteropServices.ComTypes.IMPLTYPEFLAGS pImplTypeFlags);
        void GetMops(int memid, out string pBstrMops);
        void GetNames(int memid, string[] rgBstrNames, int cMaxNames, out int pcNames);
        void GetRefTypeInfo(int hRef, out System.Runtime.InteropServices.ComTypes.ITypeInfo ppTI);
        void GetRefTypeOfImplType(int index, out int href);
        void GetTypeAttr(out System.IntPtr ppTypeAttr);
        void GetTypeComp(out System.Runtime.InteropServices.ComTypes.ITypeComp ppTComp);
        void GetVarDesc(int index, out System.IntPtr ppVarDesc);
        void Invoke(object pvInstance, int memid, short wFlags, ref System.Runtime.InteropServices.ComTypes.DISPPARAMS pDispParams, System.IntPtr pVarResult, System.IntPtr pExcepInfo, out int puArgErr);
        void ReleaseFuncDesc(System.IntPtr pFuncDesc);
        void ReleaseTypeAttr(System.IntPtr pTypeAttr);
        void ReleaseVarDesc(System.IntPtr pVarDesc);
    }

    [System.Runtime.InteropServices.GuidAttribute("00020412-0000-0000-C000-000000000046")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
    public partial interface ITypeInfo2 : System.Runtime.InteropServices.ComTypes.ITypeInfo
    {
        new void AddressOfMember(int memid, System.Runtime.InteropServices.ComTypes.INVOKEKIND invKind, out System.IntPtr ppv);
        new void CreateInstance(object pUnkOuter, ref System.Guid riid, out object ppvObj);
        void GetAllCustData(System.IntPtr pCustData);
        void GetAllFuncCustData(int index, System.IntPtr pCustData);
        void GetAllImplTypeCustData(int index, System.IntPtr pCustData);
        void GetAllParamCustData(int indexFunc, int indexParam, System.IntPtr pCustData);
        void GetAllVarCustData(int index, System.IntPtr pCustData);
        new void GetContainingTypeLib(out System.Runtime.InteropServices.ComTypes.ITypeLib ppTLB, out int pIndex);
        void GetCustData(ref System.Guid guid, out object pVarVal);
        new void GetDllEntry(int memid, System.Runtime.InteropServices.ComTypes.INVOKEKIND invKind, System.IntPtr pBstrDllName, System.IntPtr pBstrName, System.IntPtr pwOrdinal);
        new void GetDocumentation(int index, out string strName, out string strDocString, out int dwHelpContext, out string strHelpFile);
        [System.Runtime.InteropServices.LCIDConversionAttribute(1)]
        void GetDocumentation2(int memid, out string pbstrHelpString, out int pdwHelpStringContext, out string pbstrHelpStringDll);
        void GetFuncCustData(int index, ref System.Guid guid, out object pVarVal);
        new void GetFuncDesc(int index, out System.IntPtr ppFuncDesc);
        void GetFuncIndexOfMemId(int memid, System.Runtime.InteropServices.ComTypes.INVOKEKIND invKind, out int pFuncIndex);
        new void GetIDsOfNames(string[] rgszNames, int cNames, int[] pMemId);
        void GetImplTypeCustData(int index, ref System.Guid guid, out object pVarVal);
        new void GetImplTypeFlags(int index, out System.Runtime.InteropServices.ComTypes.IMPLTYPEFLAGS pImplTypeFlags);
        new void GetMops(int memid, out string pBstrMops);
        new void GetNames(int memid, string[] rgBstrNames, int cMaxNames, out int pcNames);
        void GetParamCustData(int indexFunc, int indexParam, ref System.Guid guid, out object pVarVal);
        new void GetRefTypeInfo(int hRef, out System.Runtime.InteropServices.ComTypes.ITypeInfo ppTI);
        new void GetRefTypeOfImplType(int index, out int href);
        new void GetTypeAttr(out System.IntPtr ppTypeAttr);
        new void GetTypeComp(out System.Runtime.InteropServices.ComTypes.ITypeComp ppTComp);
        void GetTypeFlags(out int pTypeFlags);
        void GetTypeKind(out System.Runtime.InteropServices.ComTypes.TYPEKIND pTypeKind);
        void GetVarCustData(int index, ref System.Guid guid, out object pVarVal);
        new void GetVarDesc(int index, out System.IntPtr ppVarDesc);
        void GetVarIndexOfMemId(int memid, out int pVarIndex);
        new void Invoke(object pvInstance, int memid, short wFlags, ref System.Runtime.InteropServices.ComTypes.DISPPARAMS pDispParams, System.IntPtr pVarResult, System.IntPtr pExcepInfo, out int puArgErr);
        new void ReleaseFuncDesc(System.IntPtr pFuncDesc);
        new void ReleaseTypeAttr(System.IntPtr pTypeAttr);
        new void ReleaseVarDesc(System.IntPtr pVarDesc);
    }

    [System.Runtime.InteropServices.GuidAttribute("00020402-0000-0000-C000-000000000046")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
    public partial interface ITypeLib
    {
        void FindName(string szNameBuf, int lHashVal, System.Runtime.InteropServices.ComTypes.ITypeInfo[] ppTInfo, int[] rgMemId, ref short pcFound);
        void GetDocumentation(int index, out string strName, out string strDocString, out int dwHelpContext, out string strHelpFile);
        void GetLibAttr(out System.IntPtr ppTLibAttr);
        void GetTypeComp(out System.Runtime.InteropServices.ComTypes.ITypeComp ppTComp);
        void GetTypeInfo(int index, out System.Runtime.InteropServices.ComTypes.ITypeInfo ppTI);
        int GetTypeInfoCount();
        void GetTypeInfoOfGuid(ref System.Guid guid, out System.Runtime.InteropServices.ComTypes.ITypeInfo ppTInfo);
        void GetTypeInfoType(int index, out System.Runtime.InteropServices.ComTypes.TYPEKIND pTKind);
        bool IsName(string szNameBuf, int lHashVal);
        void ReleaseTLibAttr(System.IntPtr pTLibAttr);
    }

    [System.Runtime.InteropServices.GuidAttribute("00020411-0000-0000-C000-000000000046")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
    public partial interface ITypeLib2 : System.Runtime.InteropServices.ComTypes.ITypeLib
    {
        new void FindName(string szNameBuf, int lHashVal, System.Runtime.InteropServices.ComTypes.ITypeInfo[] ppTInfo, int[] rgMemId, ref short pcFound);
        void GetAllCustData(System.IntPtr pCustData);
        void GetCustData(ref System.Guid guid, out object pVarVal);
        new void GetDocumentation(int index, out string strName, out string strDocString, out int dwHelpContext, out string strHelpFile);
        [System.Runtime.InteropServices.LCIDConversionAttribute(1)]
        void GetDocumentation2(int index, out string pbstrHelpString, out int pdwHelpStringContext, out string pbstrHelpStringDll);
        new void GetLibAttr(out System.IntPtr ppTLibAttr);
        void GetLibStatistics(System.IntPtr pcUniqueNames, out int pcchUniqueNames);
        new void GetTypeComp(out System.Runtime.InteropServices.ComTypes.ITypeComp ppTComp);
        new void GetTypeInfo(int index, out System.Runtime.InteropServices.ComTypes.ITypeInfo ppTI);
        new int GetTypeInfoCount();
        new void GetTypeInfoOfGuid(ref System.Guid guid, out System.Runtime.InteropServices.ComTypes.ITypeInfo ppTInfo);
        new void GetTypeInfoType(int index, out System.Runtime.InteropServices.ComTypes.TYPEKIND pTKind);
        new bool IsName(string szNameBuf, int lHashVal);
        new void ReleaseTLibAttr(System.IntPtr pTLibAttr);
    }

    [System.FlagsAttribute]
    public enum LIBFLAGS : short
    {
        LIBFLAG_FCONTROL = (short)2,
        LIBFLAG_FHASDISKIMAGE = (short)8,
        LIBFLAG_FHIDDEN = (short)4,
        LIBFLAG_FRESTRICTED = (short)1,
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct PARAMDESC
    {
        public System.IntPtr lpVarValue;
        public System.Runtime.InteropServices.ComTypes.PARAMFLAG wParamFlags;
    }

    [System.FlagsAttribute]
    public enum PARAMFLAG : short
    {
        PARAMFLAG_FHASCUSTDATA = (short)64,
        PARAMFLAG_FHASDEFAULT = (short)32,
        PARAMFLAG_FIN = (short)1,
        PARAMFLAG_FLCID = (short)4,
        PARAMFLAG_FOPT = (short)16,
        PARAMFLAG_FOUT = (short)2,
        PARAMFLAG_FRETVAL = (short)8,
        PARAMFLAG_NONE = (short)0,
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct STATSTG
    {
        public System.Runtime.InteropServices.ComTypes.FILETIME atime;
        public long cbSize;
        public System.Guid clsid;
        public System.Runtime.InteropServices.ComTypes.FILETIME ctime;
        public int grfLocksSupported;
        public int grfMode;
        public int grfStateBits;
        public System.Runtime.InteropServices.ComTypes.FILETIME mtime;
        public string pwcsName;
        public int reserved;
        public int type;
    }

    public enum SYSKIND
    {
        SYS_MAC = 2,
        SYS_WIN16 = 0,
        SYS_WIN32 = 1,
        SYS_WIN64 = 3,
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct TYPEATTR
    {
        public short cbAlignment;
        public int cbSizeInstance;
        public short cbSizeVft;
        public short cFuncs;
        public short cImplTypes;
        public short cVars;
        public int dwReserved;
        public System.Guid guid;
        public System.Runtime.InteropServices.ComTypes.IDLDESC idldescType;
        public int lcid;
        public System.IntPtr lpstrSchema;
        public const int MEMBER_ID_NIL = -1;
        public int memidConstructor;
        public int memidDestructor;
        public System.Runtime.InteropServices.ComTypes.TYPEDESC tdescAlias;
        public System.Runtime.InteropServices.ComTypes.TYPEKIND typekind;
        public short wMajorVerNum;
        public short wMinorVerNum;
        public System.Runtime.InteropServices.ComTypes.TYPEFLAGS wTypeFlags;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct TYPEDESC
    {
        public System.IntPtr lpValue;
        public short vt;
    }

    [System.FlagsAttribute]
    public enum TYPEFLAGS : short
    {
        TYPEFLAG_FAGGREGATABLE = (short)1024,
        TYPEFLAG_FAPPOBJECT = (short)1,
        TYPEFLAG_FCANCREATE = (short)2,
        TYPEFLAG_FCONTROL = (short)32,
        TYPEFLAG_FDISPATCHABLE = (short)4096,
        TYPEFLAG_FDUAL = (short)64,
        TYPEFLAG_FHIDDEN = (short)16,
        TYPEFLAG_FLICENSED = (short)4,
        TYPEFLAG_FNONEXTENSIBLE = (short)128,
        TYPEFLAG_FOLEAUTOMATION = (short)256,
        TYPEFLAG_FPREDECLID = (short)8,
        TYPEFLAG_FPROXY = (short)16384,
        TYPEFLAG_FREPLACEABLE = (short)2048,
        TYPEFLAG_FRESTRICTED = (short)512,
        TYPEFLAG_FREVERSEBIND = (short)8192,
    }

    public enum TYPEKIND
    {
        TKIND_ALIAS = 6,
        TKIND_COCLASS = 5,
        TKIND_DISPATCH = 4,
        TKIND_ENUM = 0,
        TKIND_INTERFACE = 3,
        TKIND_MAX = 8,
        TKIND_MODULE = 2,
        TKIND_RECORD = 1,
        TKIND_UNION = 7,
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct TYPELIBATTR
    {
        public System.Guid guid;
        public int lcid;
        public System.Runtime.InteropServices.ComTypes.SYSKIND syskind;
        public System.Runtime.InteropServices.ComTypes.LIBFLAGS wLibFlags;
        public short wMajorVerNum;
        public short wMinorVerNum;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct VARDESC
    {
        public System.Runtime.InteropServices.ComTypes.VARDESC.DESCUNION desc;
        public System.Runtime.InteropServices.ComTypes.ELEMDESC elemdescVar;
        public string lpstrSchema;
        public int memid;
        public System.Runtime.InteropServices.ComTypes.VARKIND varkind;
        public short wVarFlags;
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
        public partial struct DESCUNION
        {
            [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
            public System.IntPtr lpvarValue;
            [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
            public int oInst;
        }
    }

    [System.FlagsAttribute]
    public enum VARFLAGS : short
    {
        VARFLAG_FBINDABLE = (short)4,
        VARFLAG_FDEFAULTBIND = (short)32,
        VARFLAG_FDEFAULTCOLLELEM = (short)256,
        VARFLAG_FDISPLAYBIND = (short)16,
        VARFLAG_FHIDDEN = (short)64,
        VARFLAG_FIMMEDIATEBIND = (short)4096,
        VARFLAG_FNONBROWSABLE = (short)1024,
        VARFLAG_FREADONLY = (short)1,
        VARFLAG_FREPLACEABLE = (short)2048,
        VARFLAG_FREQUESTEDIT = (short)8,
        VARFLAG_FRESTRICTED = (short)128,
        VARFLAG_FSOURCE = (short)2,
        VARFLAG_FUIDEFAULT = (short)512,
    }

    public enum VARKIND
    {
        VAR_CONST = 2,
        VAR_DISPATCH = 3,
        VAR_PERINSTANCE = 0,
        VAR_STATIC = 1,
    }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.FlagsAttribute]
  public enum ADVF {
    ADVF_DATAONSTOP = 64,
    ADVF_NODATA = 1,
    ADVF_ONLYONCE = 4,
    ADVF_PRIMEFIRST = 2,
    ADVFCACHE_FORCEBUILTIN = 16,
    ADVFCACHE_NOHANDLER = 8,
    ADVFCACHE_ONSAVE = 32,
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public enum DATADIR {
    DATADIR_GET = 1,
    DATADIR_SET = 2,
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.FlagsAttribute]
  public enum DVASPECT {
    DVASPECT_CONTENT = 1,
    DVASPECT_DOCPRINT = 8,
    DVASPECT_ICON = 4,
    DVASPECT_THUMBNAIL = 2,
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct FORMATETC {
    public short cfFormat;
    public System.Runtime.InteropServices.ComTypes.DVASPECT dwAspect;
    public int lindex;
    public System.IntPtr ptd;
    public System.Runtime.InteropServices.ComTypes.TYMED tymed;
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
  public partial interface IAdviseSink {
    void OnClose();
    void OnDataChange(ref System.Runtime.InteropServices.ComTypes.FORMATETC format, ref System.Runtime.InteropServices.ComTypes.STGMEDIUM stgmedium);
    void OnRename(System.Runtime.InteropServices.ComTypes.IMoniker moniker);
    void OnSave();
    void OnViewChange(int aspect, int index);
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
  public partial interface IEnumFORMATETC {
    void Clone(out System.Runtime.InteropServices.ComTypes.IEnumFORMATETC newEnum);
    int Next(int celt, System.Runtime.InteropServices.ComTypes.FORMATETC[] rgelt, int[] pceltFetched);
    int Reset();
    int Skip(int celt);
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct STATDATA {
    public System.Runtime.InteropServices.ComTypes.ADVF advf;
    public System.Runtime.InteropServices.ComTypes.IAdviseSink advSink;
    public int connection;
    public System.Runtime.InteropServices.ComTypes.FORMATETC formatetc;
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct STGMEDIUM {
    public object pUnkForRelease;
    public System.Runtime.InteropServices.ComTypes.TYMED tymed;
    public System.IntPtr unionmember;
  }
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.FlagsAttribute]
  public enum TYMED {
    TYMED_ENHMF = 64,
    TYMED_FILE = 2,
    TYMED_GDI = 16,
    TYMED_HGLOBAL = 1,
    TYMED_ISTORAGE = 8,
    TYMED_ISTREAM = 4,
    TYMED_MFPICT = 32,
    TYMED_NULL = 0,
  }
} // end of System.Runtime.InteropServices.ComTypes
namespace System.Runtime.InteropServices.Expando {
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("AFBF15E6-C37C-11d2-B88E-00A0C9B471B8")]
    public partial interface IExpando : System.Reflection.IReflect
    {
        System.Reflection.FieldInfo AddField(string name);
        System.Reflection.MethodInfo AddMethod(string name, System.Delegate method);
        System.Reflection.PropertyInfo AddProperty(string name);
        void RemoveMember(System.Reflection.MemberInfo m);
    }
} // end of System.Runtime.InteropServices.Expando
namespace System.Runtime.InteropServices.WindowsRuntime {
    [System.AttributeUsageAttribute((System.AttributeTargets)(1028), AllowMultiple = false, Inherited = false)]
    public sealed partial class DefaultInterfaceAttribute : System.Attribute
    {
        public DefaultInterfaceAttribute(System.Type defaultInterface) { }
        public System.Type DefaultInterface { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public partial class DesignerNamespaceResolveEventArgs : System.EventArgs
    {
        public DesignerNamespaceResolveEventArgs(string namespaceName) { }
        public string NamespaceName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
        public System.Collections.ObjectModel.Collection<string> ResolvedAssemblyFiles { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.ObjectModel.Collection<string>); } }
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct EventRegistrationToken
    {
        public override bool Equals(object obj) { return default(bool); }
        public override int GetHashCode() { return default(int); }
        public static bool operator ==(System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken left, System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken right) { return default(bool); }
        public static bool operator !=(System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken left, System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken right) { return default(bool); }
    }
    public sealed partial class EventRegistrationTokenTable<T> where T : class
    {
        public EventRegistrationTokenTable() { }
        public T InvocationList { get { return default(T); } set { } }
        public System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken AddEventHandler(T handler) { return default(System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken); }
        public static System.Runtime.InteropServices.WindowsRuntime.EventRegistrationTokenTable<T> GetOrCreateEventRegistrationTokenTable(ref System.Runtime.InteropServices.WindowsRuntime.EventRegistrationTokenTable<T> refEventTable) { return default(System.Runtime.InteropServices.WindowsRuntime.EventRegistrationTokenTable<T>); }
        public void RemoveEventHandler(T handler) { }
        public void RemoveEventHandler(System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken token) { }
    }

    [System.Runtime.InteropServices.GuidAttribute("00000035-0000-0000-C000-000000000046")]
    public partial interface IActivationFactory
    {
        object ActivateInstance();
    }

    [System.AttributeUsageAttribute((System.AttributeTargets)(1028), AllowMultiple = true, Inherited = false)]
    public sealed partial class InterfaceImplementedInVersionAttribute : System.Attribute
    {
        public InterfaceImplementedInVersionAttribute(System.Type interfaceType, byte majorVersion, byte minorVersion, byte buildVersion, byte revisionVersion) { }
        public byte BuildVersion { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(byte); } }
        public System.Type InterfaceType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } }
        public byte MajorVersion { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(byte); } }
        public byte MinorVersion { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(byte); } }
        public byte RevisionVersion { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(byte); } }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public partial class NamespaceResolveEventArgs : System.EventArgs
    {
        public NamespaceResolveEventArgs(string namespaceName, System.Reflection.Assembly requestingAssembly) { }
        public string NamespaceName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
        public System.Reflection.Assembly RequestingAssembly { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Reflection.Assembly); } }
        public System.Collections.ObjectModel.Collection<System.Reflection.Assembly> ResolvedAssemblies { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.ObjectModel.Collection<System.Reflection.Assembly>); } }
    }

    [System.AttributeUsageAttribute((System.AttributeTargets)(2048), Inherited = false, AllowMultiple = false)]
    public sealed partial class ReadOnlyArrayAttribute : System.Attribute
    {
        public ReadOnlyArrayAttribute() { }
    }

    [System.AttributeUsageAttribute((System.AttributeTargets)(12288), AllowMultiple = false, Inherited = false)]
    public sealed partial class ReturnValueNameAttribute : System.Attribute
    {
        public ReturnValueNameAttribute(string name) { }
        public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    }
    public static partial class WindowsRuntimeMarshal
    {
        public static void AddEventHandler<T>(System.Func<T, System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken> addMethod, System.Action<System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken> removeMethod, T handler) { }
        public static void FreeHString(System.IntPtr ptr) { }
        public static System.Runtime.InteropServices.WindowsRuntime.IActivationFactory GetActivationFactory(System.Type type) { return default(System.Runtime.InteropServices.WindowsRuntime.IActivationFactory); }
        public static string PtrToStringHString(System.IntPtr ptr) { return default(string); }
        public static void RemoveAllEventHandlers(System.Action<System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken> removeMethod) { }
        public static void RemoveEventHandler<T>(System.Action<System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken> removeMethod, T handler) { }
        public static System.IntPtr StringToHString(string s) { return default(System.IntPtr); }
    }
    public static partial class WindowsRuntimeMetadata
    {
        public static event System.EventHandler<System.Runtime.InteropServices.WindowsRuntime.DesignerNamespaceResolveEventArgs> DesignerNamespaceResolve { add { } remove { } }
        public static event System.EventHandler<System.Runtime.InteropServices.WindowsRuntime.NamespaceResolveEventArgs> ReflectionOnlyNamespaceResolve { add { } remove { } }
        public static System.Collections.Generic.IEnumerable<string> ResolveNamespace(string namespaceName, System.Collections.Generic.IEnumerable<string> packageGraphFilePaths) { return default(System.Collections.Generic.IEnumerable<string>); }
        public static System.Collections.Generic.IEnumerable<string> ResolveNamespace(string namespaceName, string windowsSdkFilePath, System.Collections.Generic.IEnumerable<string> packageGraphFilePaths) { return default(System.Collections.Generic.IEnumerable<string>); }
    }

    [System.AttributeUsageAttribute((System.AttributeTargets)(2048), Inherited = false, AllowMultiple = false)]
    public sealed partial class WriteOnlyArrayAttribute : System.Attribute
    {
        public WriteOnlyArrayAttribute() { }
    }
} // end of System.Runtime.InteropServices.WindowsRuntime
namespace System.Security {

    [System.AttributeUsageAttribute((System.AttributeTargets)(5188), AllowMultiple = true, Inherited = false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SuppressUnmanagedCodeSecurityAttribute : System.Attribute
    {
        public SuppressUnmanagedCodeSecurityAttribute() { }
    }
} // end of System.Security
