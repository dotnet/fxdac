[assembly:System.CLSCompliant(true)]
namespace System {
    [System.CLSCompliantAttribute(false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("05F696DC-2B29-3663-AD8B-C4389CF2A713")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
    public partial interface _AppDomain
    {
        string BaseDirectory { get; }
        string DynamicDirectory { get; }
        System.Security.Policy.Evidence Evidence { get; }
        string FriendlyName { get; }
        string RelativeSearchPath { get; }
        bool ShadowCopyFiles { get; }
        event System.AssemblyLoadEventHandler AssemblyLoad;
        event System.ResolveEventHandler AssemblyResolve;
        event System.EventHandler DomainUnload;
        event System.EventHandler ProcessExit;
        event System.ResolveEventHandler ResourceResolve;
        event System.ResolveEventHandler TypeResolve;
        event System.UnhandledExceptionEventHandler UnhandledException;
        [System.Security.SecurityCriticalAttribute]
        void AppendPrivatePath(string path);
        [System.Security.SecurityCriticalAttribute]
        void ClearPrivatePath();
        [System.Security.SecurityCriticalAttribute]
        void ClearShadowCopyPath();
        System.Runtime.Remoting.ObjectHandle CreateInstance(string assemblyName, string typeName);
        System.Runtime.Remoting.ObjectHandle CreateInstance(string assemblyName, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes, System.Security.Policy.Evidence securityAttributes);
        System.Runtime.Remoting.ObjectHandle CreateInstance(string assemblyName, string typeName, object[] activationAttributes);
        System.Runtime.Remoting.ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName);
        System.Runtime.Remoting.ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes, System.Security.Policy.Evidence securityAttributes);
        System.Runtime.Remoting.ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, object[] activationAttributes);
        void DoCallBack(System.CrossAppDomainDelegate theDelegate);
        bool Equals(object other);
        int ExecuteAssembly(string assemblyFile);
        int ExecuteAssembly(string assemblyFile, System.Security.Policy.Evidence assemblySecurity);
        int ExecuteAssembly(string assemblyFile, System.Security.Policy.Evidence assemblySecurity, string[] args);
        System.Reflection.Assembly[] GetAssemblies();
        object GetData(string name);
        int GetHashCode();
        void GetIDsOfNames(ref System.Guid riid, System.IntPtr rgszNames, uint cNames, uint lcid, System.IntPtr rgDispId);
        [System.Security.SecurityCriticalAttribute]
        object GetLifetimeService();
        System.Type GetType();
        void GetTypeInfo(uint iTInfo, uint lcid, System.IntPtr ppTInfo);
        void GetTypeInfoCount(out uint pcTInfo);
        [System.Security.SecurityCriticalAttribute]
        object InitializeLifetimeService();
        void Invoke(uint dispIdMember, ref System.Guid riid, uint lcid, short wFlags, System.IntPtr pDispParams, System.IntPtr pVarResult, System.IntPtr pExcepInfo, System.IntPtr puArgErr);
        System.Reflection.Assembly Load(byte[] rawAssembly);
        System.Reflection.Assembly Load(byte[] rawAssembly, byte[] rawSymbolStore);
        System.Reflection.Assembly Load(byte[] rawAssembly, byte[] rawSymbolStore, System.Security.Policy.Evidence securityEvidence);
        System.Reflection.Assembly Load(System.Reflection.AssemblyName assemblyRef);
        System.Reflection.Assembly Load(System.Reflection.AssemblyName assemblyRef, System.Security.Policy.Evidence assemblySecurity);
        System.Reflection.Assembly Load(string assemblyString);
        System.Reflection.Assembly Load(string assemblyString, System.Security.Policy.Evidence assemblySecurity);
        [System.Security.SecurityCriticalAttribute]
        void SetAppDomainPolicy(System.Security.Policy.PolicyLevel domainPolicy);
        [System.Security.SecurityCriticalAttribute]
        void SetCachePath(string s);
        [System.Security.SecurityCriticalAttribute]
        void SetData(string name, object data);
        void SetPrincipalPolicy(System.Security.Principal.PrincipalPolicy policy);
        [System.Security.SecurityCriticalAttribute]
        void SetShadowCopyPath(string s);
        void SetThreadPrincipal(System.Security.Principal.IPrincipal principal);
        string ToString();
    }

    [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(0))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class AppDomain : System.MarshalByRefObject
    {
        internal AppDomain() { }
        public System.ActivationContext ActivationContext { get { return default(System.ActivationContext); } }
        public System.ApplicationIdentity ApplicationIdentity { get { return default(System.ApplicationIdentity); } }
        public string BaseDirectory { get { return default(string); } }
        public static System.AppDomain CurrentDomain { get { return default(System.AppDomain); } }
        public System.AppDomainManager DomainManager { get { return default(System.AppDomainManager); } }
        public string DynamicDirectory { get { return default(string); } }
        public System.Security.Policy.Evidence Evidence { get { return default(System.Security.Policy.Evidence); } }
        public string FriendlyName { get { return default(string); } }
        public int Id { [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute((System.Runtime.ConstrainedExecution.Consistency)(3), (System.Runtime.ConstrainedExecution.Cer)(2))]get { return default(int); } }
        public bool IsFullyTrusted { get { return default(bool); } }
        public bool IsHomogenous { get { return default(bool); } }
        public static bool MonitoringIsEnabled { get { return default(bool); } set { } }
        public long MonitoringSurvivedMemorySize { get { return default(long); } }
        public static long MonitoringSurvivedProcessMemorySize { get { return default(long); } }
        public long MonitoringTotalAllocatedMemorySize { get { return default(long); } }
        public System.TimeSpan MonitoringTotalProcessorTime { get { return default(System.TimeSpan); } }
        public System.Security.PermissionSet PermissionSet { get { return default(System.Security.PermissionSet); } }
        public string RelativeSearchPath { get { return default(string); } }
        public System.AppDomainSetup SetupInformation { get { return default(System.AppDomainSetup); } }
        public bool ShadowCopyFiles { get { return default(bool); } }
        public event System.AssemblyLoadEventHandler AssemblyLoad { add { } remove { } }
        public event System.ResolveEventHandler AssemblyResolve { add { } remove { } }
        public event System.EventHandler DomainUnload { add { } remove { } }
        public event System.EventHandler<System.Runtime.ExceptionServices.FirstChanceExceptionEventArgs> FirstChanceException { add { } remove { } }
        public event System.EventHandler ProcessExit { add { } remove { } }
        public event System.ResolveEventHandler ResourceResolve { add { } remove { } }
        public event System.ResolveEventHandler TypeResolve { add { } remove { } }
        public event System.UnhandledExceptionEventHandler UnhandledException { add { } remove { } }
        [System.ObsoleteAttribute("AppDomain.AppendPrivatePath has been deprecated. Please investigate the use of AppDomainSetup.PrivateBinPath instead.")]
        public void AppendPrivatePath(string path) { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public string ApplyPolicy(string assemblyName) { return default(string); }
        [System.ObsoleteAttribute("AppDomain.ClearPrivatePath has been deprecated. Please investigate the use of AppDomainSetup.PrivateBinPath instead.")]
        public void ClearPrivatePath() { }
        [System.ObsoleteAttribute("Use AppDomainSetup.ShadowCopyDirectories")]
        public void ClearShadowCopyPath() { }
        public static System.AppDomain CreateDomain(string friendlyName) { return default(System.AppDomain); }
        public static System.AppDomain CreateDomain(string friendlyName, System.Security.Policy.Evidence securityInfo) { return default(System.AppDomain); }
        public static System.AppDomain CreateDomain(string friendlyName, System.Security.Policy.Evidence securityInfo, System.AppDomainSetup info) { return default(System.AppDomain); }
        public static System.AppDomain CreateDomain(string friendlyName, System.Security.Policy.Evidence securityInfo, string appBasePath, string appRelativeSearchPath, bool shadowCopyFiles) { return default(System.AppDomain); }
        public static System.AppDomain CreateDomain(string friendlyName, System.Security.Policy.Evidence securityInfo, string appBasePath, string appRelativeSearchPath, bool shadowCopyFiles, System.AppDomainInitializer adInit, string[] adInitArgs) { return default(System.AppDomain); }
        public System.Runtime.Remoting.ObjectHandle CreateInstance(string assemblyName, string typeName) { return default(System.Runtime.Remoting.ObjectHandle); }
        public System.Runtime.Remoting.ObjectHandle CreateInstance(string assemblyName, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes) { return default(System.Runtime.Remoting.ObjectHandle); }
        [System.ObsoleteAttribute("Use an overload that does not take an Evidence parameter")]
        public System.Runtime.Remoting.ObjectHandle CreateInstance(string assemblyName, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes, System.Security.Policy.Evidence securityAttributes) { return default(System.Runtime.Remoting.ObjectHandle); }
        public System.Runtime.Remoting.ObjectHandle CreateInstance(string assemblyName, string typeName, object[] activationAttributes) { return default(System.Runtime.Remoting.ObjectHandle); }
        public object CreateInstanceAndUnwrap(string assemblyName, string typeName) { return default(object); }
        public object CreateInstanceAndUnwrap(string assemblyName, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes) { return default(object); }
        [System.ObsoleteAttribute("Use an overload that does not take an Evidence parameter")]
        public object CreateInstanceAndUnwrap(string assemblyName, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes, System.Security.Policy.Evidence securityAttributes) { return default(object); }
        public object CreateInstanceAndUnwrap(string assemblyName, string typeName, object[] activationAttributes) { return default(object); }
        public System.Runtime.Remoting.ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName) { return default(System.Runtime.Remoting.ObjectHandle); }
        public System.Runtime.Remoting.ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes) { return default(System.Runtime.Remoting.ObjectHandle); }
        [System.ObsoleteAttribute("Use an overload that does not take an Evidence parameter")]
        public System.Runtime.Remoting.ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes, System.Security.Policy.Evidence securityAttributes) { return default(System.Runtime.Remoting.ObjectHandle); }
        public System.Runtime.Remoting.ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, object[] activationAttributes) { return default(System.Runtime.Remoting.ObjectHandle); }
        public object CreateInstanceFromAndUnwrap(string assemblyName, string typeName) { return default(object); }
        public object CreateInstanceFromAndUnwrap(string assemblyFile, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes) { return default(object); }
        [System.ObsoleteAttribute("Use an overload that does not take an Evidence parameter")]
        public object CreateInstanceFromAndUnwrap(string assemblyName, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes, System.Security.Policy.Evidence securityAttributes) { return default(object); }
        public object CreateInstanceFromAndUnwrap(string assemblyName, string typeName, object[] activationAttributes) { return default(object); }
        public void DoCallBack(System.CrossAppDomainDelegate callBackDelegate) { }
        public int ExecuteAssembly(string assemblyFile) { return default(int); }
        [System.ObsoleteAttribute("Use an overload that does not take an Evidence parameter")]
        public int ExecuteAssembly(string assemblyFile, System.Security.Policy.Evidence assemblySecurity) { return default(int); }
        [System.ObsoleteAttribute("Use an overload that does not take an Evidence parameter")]
        public int ExecuteAssembly(string assemblyFile, System.Security.Policy.Evidence assemblySecurity, string[] args) { return default(int); }
        [System.ObsoleteAttribute("Use an overload that does not take an Evidence parameter")]
        public int ExecuteAssembly(string assemblyFile, System.Security.Policy.Evidence assemblySecurity, string[] args, byte[] hashValue, System.Configuration.Assemblies.AssemblyHashAlgorithm hashAlgorithm) { return default(int); }
        public int ExecuteAssembly(string assemblyFile, string[] args) { return default(int); }
        public int ExecuteAssembly(string assemblyFile, string[] args, byte[] hashValue, System.Configuration.Assemblies.AssemblyHashAlgorithm hashAlgorithm) { return default(int); }
        [System.ObsoleteAttribute("Use an overload that does not take an Evidence parameter")]
        public int ExecuteAssemblyByName(System.Reflection.AssemblyName assemblyName, System.Security.Policy.Evidence assemblySecurity, params string[] args) { return default(int); }
        public int ExecuteAssemblyByName(System.Reflection.AssemblyName assemblyName, params string[] args) { return default(int); }
        public int ExecuteAssemblyByName(string assemblyName) { return default(int); }
        [System.ObsoleteAttribute("Use an overload that does not take an Evidence parameter")]
        public int ExecuteAssemblyByName(string assemblyName, System.Security.Policy.Evidence assemblySecurity) { return default(int); }
        [System.ObsoleteAttribute("Use an overload that does not take an Evidence parameter")]
        public int ExecuteAssemblyByName(string assemblyName, System.Security.Policy.Evidence assemblySecurity, params string[] args) { return default(int); }
        public int ExecuteAssemblyByName(string assemblyName, params string[] args) { return default(int); }
        public System.Reflection.Assembly[] GetAssemblies() { return default(System.Reflection.Assembly[]); }
        [System.ObsoleteAttribute("AppDomain.GetCurrentThreadId has been deprecated because it does not provide a stable Id when managed threads are running on fibers (aka lightweight threads). To get a stable identifier for a managed thread, use the ManagedThreadId property on Thread.'")]
        public static int GetCurrentThreadId() { return default(int); }
        public object GetData(string name) { return default(object); }
        public new System.Type GetType() { return default(System.Type); }
        public override object InitializeLifetimeService() { return default(object); }
        public System.Nullable<bool> IsCompatibilitySwitchSet(string value) { return default(System.Nullable<bool>); }
        public bool IsDefaultAppDomain() { return default(bool); }
        public bool IsFinalizingForUnload() { return default(bool); }
        public System.Reflection.Assembly Load(byte[] rawAssembly) { return default(System.Reflection.Assembly); }
        public System.Reflection.Assembly Load(byte[] rawAssembly, byte[] rawSymbolStore) { return default(System.Reflection.Assembly); }
        [System.ObsoleteAttribute("Use an overload that does not take an Evidence parameter")]
        public System.Reflection.Assembly Load(byte[] rawAssembly, byte[] rawSymbolStore, System.Security.Policy.Evidence securityEvidence) { return default(System.Reflection.Assembly); }
        public System.Reflection.Assembly Load(System.Reflection.AssemblyName assemblyRef) { return default(System.Reflection.Assembly); }
        [System.ObsoleteAttribute("Use an overload that does not take an Evidence parameter")]
        public System.Reflection.Assembly Load(System.Reflection.AssemblyName assemblyRef, System.Security.Policy.Evidence assemblySecurity) { return default(System.Reflection.Assembly); }
        public System.Reflection.Assembly Load(string assemblyString) { return default(System.Reflection.Assembly); }
        [System.ObsoleteAttribute("Use an overload that does not take an Evidence parameter")]
        public System.Reflection.Assembly Load(string assemblyString, System.Security.Policy.Evidence assemblySecurity) { return default(System.Reflection.Assembly); }
        public System.Reflection.Assembly[] ReflectionOnlyGetAssemblies() { return default(System.Reflection.Assembly[]); }
        [System.ObsoleteAttribute("AppDomain policy levels are obsolete")]
        public void SetAppDomainPolicy(System.Security.Policy.PolicyLevel domainPolicy) { }
        [System.ObsoleteAttribute("Use AppDomainSetup.SetCachePath")]
        public void SetCachePath(string path) { }
        public void SetData(string name, object data) { }
        public void SetData(string name, object data, System.Security.IPermission permission) { }
        public void SetPrincipalPolicy(System.Security.Principal.PrincipalPolicy policy) { }
        [System.ObsoleteAttribute("Use AppDomainSetup.ShadowCopyFiles")]
        public void SetShadowCopyFiles() { }
        [System.ObsoleteAttribute("Use AppDomainSetup.ShadowCopyDirectories")]
        public void SetShadowCopyPath(string path) { }
        public void SetThreadPrincipal(System.Security.Principal.IPrincipal principal) { }
        public override string ToString() { return default(string); }
        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute((System.Runtime.ConstrainedExecution.Consistency)(1), (System.Runtime.ConstrainedExecution.Cer)(1))]
        public static void Unload(System.AppDomain domain) { }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public delegate void AppDomainInitializer(string[] args);

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class AppDomainManager : System.MarshalByRefObject
    {
        public AppDomainManager() { }
        public virtual System.Runtime.Hosting.ApplicationActivator ApplicationActivator { get { return default(System.Runtime.Hosting.ApplicationActivator); } }
        public virtual System.Reflection.Assembly EntryAssembly { get { return default(System.Reflection.Assembly); } }
        public virtual System.Threading.HostExecutionContextManager HostExecutionContextManager { get { return default(System.Threading.HostExecutionContextManager); } }
        public virtual System.Security.HostSecurityManager HostSecurityManager { get { return default(System.Security.HostSecurityManager); } }
        public System.AppDomainManagerInitializationOptions InitializationFlags { get { return default(System.AppDomainManagerInitializationOptions); } set { } }
        public virtual bool CheckSecuritySettings(System.Security.SecurityState state) { return default(bool); }
        public virtual System.AppDomain CreateDomain(string friendlyName, System.Security.Policy.Evidence securityInfo, System.AppDomainSetup appDomainInfo) { return default(System.AppDomain); }
        protected static System.AppDomain CreateDomainHelper(string friendlyName, System.Security.Policy.Evidence securityInfo, System.AppDomainSetup appDomainInfo) { return default(System.AppDomain); }
        public virtual void InitializeNewDomain(System.AppDomainSetup appDomainInfo) { }
    }

    [System.FlagsAttribute]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum AppDomainManagerInitializationOptions
    {
        None = 0,
        RegisterWithHost = 1,
    }

    [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(0))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class AppDomainSetup
    {
        public AppDomainSetup() { }
        public AppDomainSetup(System.ActivationContext activationContext) { }
        public AppDomainSetup(System.Runtime.Hosting.ActivationArguments activationArguments) { }
        public System.Runtime.Hosting.ActivationArguments ActivationArguments { get { return default(System.Runtime.Hosting.ActivationArguments); } set { } }
        public System.AppDomainInitializer AppDomainInitializer { get { return default(System.AppDomainInitializer); } set { } }
        public string[] AppDomainInitializerArguments { get { return default(string[]); } set { } }
        public string ApplicationBase { get { return default(string); } set { } }
        public string ApplicationName { get { return default(string); } set { } }
        public System.Security.Policy.ApplicationTrust ApplicationTrust { get { return default(System.Security.Policy.ApplicationTrust); } set { } }
        public string CachePath { get { return default(string); } set { } }
        public string ConfigurationFile { get { return default(string); } set { } }
        public bool DisallowApplicationBaseProbing { get { return default(bool); } set { } }
        public bool DisallowBindingRedirects { get { return default(bool); } set { } }
        public bool DisallowCodeDownload { get { return default(bool); } set { } }
        public bool DisallowPublisherPolicy { get { return default(bool); } set { } }
        public string DynamicBase { get { return default(string); } set { } }
        public string LicenseFile { get { return default(string); } set { } }
        public System.LoaderOptimization LoaderOptimization { get { return default(System.LoaderOptimization); } set { } }
        public string PrivateBinPath { get { return default(string); } set { } }
        public string PrivateBinPathProbe { get { return default(string); } set { } }
        public string ShadowCopyDirectories { get { return default(string); } set { } }
        public string ShadowCopyFiles { get { return default(string); } set { } }
        public string TargetFrameworkName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public byte[] GetConfigurationBytes() { return default(byte[]); }
        public void SetCompatibilitySwitches(System.Collections.Generic.IEnumerable<string> switches) { }
        public void SetConfigurationBytes(byte[] value) { }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class AppDomainUnloadedException : System.SystemException
    {
        public AppDomainUnloadedException() { }
        protected AppDomainUnloadedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public AppDomainUnloadedException(string message) { }
        public AppDomainUnloadedException(string message, System.Exception innerException) { }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class CannotUnloadAppDomainException : System.SystemException
    {
        public CannotUnloadAppDomainException() { }
        protected CannotUnloadAppDomainException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public CannotUnloadAppDomainException(string message) { }
        public CannotUnloadAppDomainException(string message, System.Exception innerException) { }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class ContextBoundObject
    {
        protected ContextBoundObject() { }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public delegate void CrossAppDomainDelegate();

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("27FFF232-A7A8-40dd-8D4A-734AD59FCD41")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
    public partial interface IAppDomainSetup
    {
        string ApplicationBase { get; set; }
        string ApplicationName { get; set; }
        string CachePath { get; set; }
        string ConfigurationFile { get; set; }
        string DynamicBase { get; set; }
        string LicenseFile { get; set; }
        string PrivateBinPath { get; set; }
        string PrivateBinPathProbe { get; set; }
        string ShadowCopyDirectories { get; set; }
        string ShadowCopyFiles { get; set; }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class MarshalByRefObject
    {
        protected MarshalByRefObject() { }
        public virtual System.Runtime.Remoting.ObjRef CreateObjRef(System.Type requestedType) { return default(System.Runtime.Remoting.ObjRef); }
        public object GetLifetimeService() { return default(object); }
        public virtual object InitializeLifetimeService() { return default(object); }
        protected System.MarshalByRefObject MemberwiseClone(bool cloneIdentity) { return default(System.MarshalByRefObject); }
    }
} // end of System
namespace System.Runtime.Hosting {
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class ActivationArguments : System.Security.Policy.EvidenceBase
    {
        public ActivationArguments(System.ActivationContext activationData) { }
        public ActivationArguments(System.ActivationContext activationContext, string[] activationData) { }
        public ActivationArguments(System.ApplicationIdentity applicationIdentity) { }
        public ActivationArguments(System.ApplicationIdentity applicationIdentity, string[] activationData) { }
        public System.ActivationContext ActivationContext { get { return default(System.ActivationContext); } }
        public string[] ActivationData { get { return default(string[]); } }
        public System.ApplicationIdentity ApplicationIdentity { get { return default(System.ApplicationIdentity); } }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ApplicationActivator
    {
        public ApplicationActivator() { }
        public virtual System.Runtime.Remoting.ObjectHandle CreateInstance(System.ActivationContext activationContext) { return default(System.Runtime.Remoting.ObjectHandle); }
        public virtual System.Runtime.Remoting.ObjectHandle CreateInstance(System.ActivationContext activationContext, string[] activationCustomData) { return default(System.Runtime.Remoting.ObjectHandle); }
        protected static System.Runtime.Remoting.ObjectHandle CreateInstanceHelper(System.AppDomainSetup adSetup) { return default(System.Runtime.Remoting.ObjectHandle); }
    }
} // end of System.Runtime.Hosting
namespace System.Runtime.InteropServices {

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface ICustomFactory
    {
        System.MarshalByRefObject CreateInstance(System.Type serverType);
    }
} // end of System.Runtime.InteropServices
namespace System.Runtime.Remoting {
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ActivatedClientTypeEntry : System.Runtime.Remoting.TypeEntry
    {
        public ActivatedClientTypeEntry(string typeName, string assemblyName, string appUrl) { }
        public ActivatedClientTypeEntry(System.Type type, string appUrl) { }
        public string ApplicationUrl { get { return default(string); } }
        public System.Runtime.Remoting.Contexts.IContextAttribute[] ContextAttributes { get { return default(System.Runtime.Remoting.Contexts.IContextAttribute[]); } set { } }
        public System.Type ObjectType { get { return default(System.Type); } }
        public override string ToString() { return default(string); }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ActivatedServiceTypeEntry : System.Runtime.Remoting.TypeEntry
    {
        public ActivatedServiceTypeEntry(string typeName, string assemblyName) { }
        public ActivatedServiceTypeEntry(System.Type type) { }
        public System.Runtime.Remoting.Contexts.IContextAttribute[] ContextAttributes { get { return default(System.Runtime.Remoting.Contexts.IContextAttribute[]); } set { } }
        public System.Type ObjectType { get { return default(System.Type); } }
        public override string ToString() { return default(string); }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum CustomErrorsModes
    {
        Off = 1,
        On = 0,
        RemoteOnly = 2,
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IChannelInfo
    {
        object[] ChannelData { get; set; }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IEnvoyInfo
    {
        System.Runtime.Remoting.Messaging.IMessageSink EnvoySinks { get; set; }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class InternalRemotingServices
    {
        public InternalRemotingServices() { }
        [System.Diagnostics.ConditionalAttribute("_LOGGING")]
        public static void DebugOutChnl(string s) { }
        public static System.Runtime.Remoting.Metadata.SoapAttribute GetCachedSoapAttribute(object reflectionObject) { return default(System.Runtime.Remoting.Metadata.SoapAttribute); }
        [System.Diagnostics.ConditionalAttribute("_DEBUG")]
        public static void RemotingAssert(bool condition, string message) { }
        [System.Diagnostics.ConditionalAttribute("_LOGGING")]
        public static void RemotingTrace(params object[] messages) { }
        [System.CLSCompliantAttribute(false)]
        public static void SetServerIdentity(System.Runtime.Remoting.Messaging.MethodCall m, object srvID) { }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("C460E2B4-E199-412a-8456-84DC3E4838C3")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
    public partial interface IObjectHandle
    {
        object Unwrap();
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IRemotingTypeInfo
    {
        string TypeName { get; set; }
        bool CanCastTo(System.Type fromType, object o);
    }

    [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(2))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ObjectHandle : System.MarshalByRefObject, System.Runtime.Remoting.IObjectHandle
    {
        public ObjectHandle(object o) { }
        public override object InitializeLifetimeService() { return default(object); }
        public object Unwrap() { return default(object); }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ObjRef : System.Runtime.Serialization.IObjectReference, System.Runtime.Serialization.ISerializable
    {
        public ObjRef() { }
        public ObjRef(System.MarshalByRefObject o, System.Type requestedType) { }
        protected ObjRef(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public virtual System.Runtime.Remoting.IChannelInfo ChannelInfo { [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute((System.Runtime.ConstrainedExecution.Consistency)(3), (System.Runtime.ConstrainedExecution.Cer)(2))]get { return default(System.Runtime.Remoting.IChannelInfo); } set { } }
        public virtual System.Runtime.Remoting.IEnvoyInfo EnvoyInfo { get { return default(System.Runtime.Remoting.IEnvoyInfo); } set { } }
        public virtual System.Runtime.Remoting.IRemotingTypeInfo TypeInfo { get { return default(System.Runtime.Remoting.IRemotingTypeInfo); } set { } }
        public virtual string URI { get { return default(string); } set { } }
        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public virtual object GetRealObject(System.Runtime.Serialization.StreamingContext context) { return default(object); }
        public bool IsFromThisAppDomain() { return default(bool); }
        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute((System.Runtime.ConstrainedExecution.Consistency)(3), (System.Runtime.ConstrainedExecution.Cer)(2))]
        public bool IsFromThisProcess() { return default(bool); }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public static partial class RemotingConfiguration
    {
        public static string ApplicationId { get { return default(string); } }
        public static string ApplicationName { get { return default(string); } set { } }
        public static System.Runtime.Remoting.CustomErrorsModes CustomErrorsMode { get { return default(System.Runtime.Remoting.CustomErrorsModes); } set { } }
        public static string ProcessId { get { return default(string); } }
        [System.ObsoleteAttribute("Use Configure(String,Boolean)")]
        public static void Configure(string filename) { }
        public static void Configure(string filename, bool ensureSecurity) { }
        public static bool CustomErrorsEnabled(bool isLocalRequest) { return default(bool); }
        public static System.Runtime.Remoting.ActivatedClientTypeEntry[] GetRegisteredActivatedClientTypes() { return default(System.Runtime.Remoting.ActivatedClientTypeEntry[]); }
        public static System.Runtime.Remoting.ActivatedServiceTypeEntry[] GetRegisteredActivatedServiceTypes() { return default(System.Runtime.Remoting.ActivatedServiceTypeEntry[]); }
        public static System.Runtime.Remoting.WellKnownClientTypeEntry[] GetRegisteredWellKnownClientTypes() { return default(System.Runtime.Remoting.WellKnownClientTypeEntry[]); }
        public static System.Runtime.Remoting.WellKnownServiceTypeEntry[] GetRegisteredWellKnownServiceTypes() { return default(System.Runtime.Remoting.WellKnownServiceTypeEntry[]); }
        public static bool IsActivationAllowed(System.Type svrType) { return default(bool); }
        public static System.Runtime.Remoting.ActivatedClientTypeEntry IsRemotelyActivatedClientType(string typeName, string assemblyName) { return default(System.Runtime.Remoting.ActivatedClientTypeEntry); }
        public static System.Runtime.Remoting.ActivatedClientTypeEntry IsRemotelyActivatedClientType(System.Type svrType) { return default(System.Runtime.Remoting.ActivatedClientTypeEntry); }
        public static System.Runtime.Remoting.WellKnownClientTypeEntry IsWellKnownClientType(string typeName, string assemblyName) { return default(System.Runtime.Remoting.WellKnownClientTypeEntry); }
        public static System.Runtime.Remoting.WellKnownClientTypeEntry IsWellKnownClientType(System.Type svrType) { return default(System.Runtime.Remoting.WellKnownClientTypeEntry); }
        public static void RegisterActivatedClientType(System.Runtime.Remoting.ActivatedClientTypeEntry entry) { }
        public static void RegisterActivatedClientType(System.Type type, string appUrl) { }
        public static void RegisterActivatedServiceType(System.Runtime.Remoting.ActivatedServiceTypeEntry entry) { }
        public static void RegisterActivatedServiceType(System.Type type) { }
        public static void RegisterWellKnownClientType(System.Runtime.Remoting.WellKnownClientTypeEntry entry) { }
        public static void RegisterWellKnownClientType(System.Type type, string objectUrl) { }
        public static void RegisterWellKnownServiceType(System.Runtime.Remoting.WellKnownServiceTypeEntry entry) { }
        public static void RegisterWellKnownServiceType(System.Type type, string objectUri, System.Runtime.Remoting.WellKnownObjectMode mode) { }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class RemotingException : System.SystemException
    {
        public RemotingException() { }
        protected RemotingException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public RemotingException(string message) { }
        public RemotingException(string message, System.Exception InnerException) { }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public static partial class RemotingServices
    {
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public static object Connect(System.Type classToProxy, string url) { return default(object); }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public static object Connect(System.Type classToProxy, string url, object data) { return default(object); }
        public static bool Disconnect(System.MarshalByRefObject obj) { return default(bool); }
        public static System.Runtime.Remoting.Messaging.IMethodReturnMessage ExecuteMessage(System.MarshalByRefObject target, System.Runtime.Remoting.Messaging.IMethodCallMessage reqMsg) { return default(System.Runtime.Remoting.Messaging.IMethodReturnMessage); }
        public static System.Runtime.Remoting.Messaging.IMessageSink GetEnvoyChainForProxy(System.MarshalByRefObject obj) { return default(System.Runtime.Remoting.Messaging.IMessageSink); }
        public static object GetLifetimeService(System.MarshalByRefObject obj) { return default(object); }
        public static System.Reflection.MethodBase GetMethodBaseFromMethodMessage(System.Runtime.Remoting.Messaging.IMethodMessage msg) { return default(System.Reflection.MethodBase); }
        public static void GetObjectData(object obj, System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public static string GetObjectUri(System.MarshalByRefObject obj) { return default(string); }
        public static System.Runtime.Remoting.ObjRef GetObjRefForProxy(System.MarshalByRefObject obj) { return default(System.Runtime.Remoting.ObjRef); }
        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute((System.Runtime.ConstrainedExecution.Consistency)(3), (System.Runtime.ConstrainedExecution.Cer)(2))]
        public static System.Runtime.Remoting.Proxies.RealProxy GetRealProxy(object proxy) { return default(System.Runtime.Remoting.Proxies.RealProxy); }
        public static System.Type GetServerTypeForUri(string URI) { return default(System.Type); }
        public static string GetSessionIdForMethodMessage(System.Runtime.Remoting.Messaging.IMethodMessage msg) { return default(string); }
        public static bool IsMethodOverloaded(System.Runtime.Remoting.Messaging.IMethodMessage msg) { return default(bool); }
        public static bool IsObjectOutOfAppDomain(object tp) { return default(bool); }
        public static bool IsObjectOutOfContext(object tp) { return default(bool); }
        public static bool IsOneWay(System.Reflection.MethodBase method) { return default(bool); }
        public static bool IsTransparentProxy(object proxy) { return default(bool); }
        [System.Diagnostics.ConditionalAttribute("REMOTING_PERF")]
        [System.ObsoleteAttribute("It existed for only internal use in .NET and unimplemented in mono")]
        public static void LogRemotingStage(int stage) { }
        public static System.Runtime.Remoting.ObjRef Marshal(System.MarshalByRefObject Obj) { return default(System.Runtime.Remoting.ObjRef); }
        public static System.Runtime.Remoting.ObjRef Marshal(System.MarshalByRefObject Obj, string URI) { return default(System.Runtime.Remoting.ObjRef); }
        public static System.Runtime.Remoting.ObjRef Marshal(System.MarshalByRefObject Obj, string ObjURI, System.Type RequestedType) { return default(System.Runtime.Remoting.ObjRef); }
        public static void SetObjectUriForMarshal(System.MarshalByRefObject obj, string uri) { }
        public static object Unmarshal(System.Runtime.Remoting.ObjRef objectRef) { return default(object); }
        public static object Unmarshal(System.Runtime.Remoting.ObjRef objectRef, bool fRefine) { return default(object); }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class RemotingTimeoutException : System.Runtime.Remoting.RemotingException
    {
        public RemotingTimeoutException() { }
        public RemotingTimeoutException(string message) { }
        public RemotingTimeoutException(string message, System.Exception InnerException) { }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ServerException : System.SystemException
    {
        public ServerException() { }
        public ServerException(string message) { }
        public ServerException(string message, System.Exception InnerException) { }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SoapServices
    {
        internal SoapServices() { }
        public static string XmlNsForClrType { get { return default(string); } }
        public static string XmlNsForClrTypeWithAssembly { get { return default(string); } }
        public static string XmlNsForClrTypeWithNs { get { return default(string); } }
        public static string XmlNsForClrTypeWithNsAndAssembly { get { return default(string); } }
        public static string CodeXmlNamespaceForClrTypeNamespace(string typeNamespace, string assemblyName) { return default(string); }
        public static bool DecodeXmlNamespaceForClrTypeNamespace(string inNamespace, out string typeNamespace, out string assemblyName) { typeNamespace = default(string); assemblyName = default(string); return default(bool); }
        public static void GetInteropFieldTypeAndNameFromXmlAttribute(System.Type containingType, string xmlAttribute, string xmlNamespace, out System.Type type, out string name) { type = default(System.Type); name = default(string); }
        public static void GetInteropFieldTypeAndNameFromXmlElement(System.Type containingType, string xmlElement, string xmlNamespace, out System.Type type, out string name) { type = default(System.Type); name = default(string); }
        public static System.Type GetInteropTypeFromXmlElement(string xmlElement, string xmlNamespace) { return default(System.Type); }
        public static System.Type GetInteropTypeFromXmlType(string xmlType, string xmlTypeNamespace) { return default(System.Type); }
        public static string GetSoapActionFromMethodBase(System.Reflection.MethodBase mb) { return default(string); }
        public static bool GetTypeAndMethodNameFromSoapAction(string soapAction, out string typeName, out string methodName) { typeName = default(string); methodName = default(string); return default(bool); }
        public static bool GetXmlElementForInteropType(System.Type type, out string xmlElement, out string xmlNamespace) { xmlElement = default(string); xmlNamespace = default(string); return default(bool); }
        public static string GetXmlNamespaceForMethodCall(System.Reflection.MethodBase mb) { return default(string); }
        public static string GetXmlNamespaceForMethodResponse(System.Reflection.MethodBase mb) { return default(string); }
        public static bool GetXmlTypeForInteropType(System.Type type, out string xmlType, out string xmlTypeNamespace) { xmlType = default(string); xmlTypeNamespace = default(string); return default(bool); }
        public static bool IsClrTypeNamespace(string namespaceString) { return default(bool); }
        public static bool IsSoapActionValidForMethodBase(string soapAction, System.Reflection.MethodBase mb) { return default(bool); }
        public static void PreLoad(System.Reflection.Assembly assembly) { }
        public static void PreLoad(System.Type type) { }
        public static void RegisterInteropXmlElement(string xmlElement, string xmlNamespace, System.Type type) { }
        public static void RegisterInteropXmlType(string xmlType, string xmlTypeNamespace, System.Type type) { }
        public static void RegisterSoapActionForMethodBase(System.Reflection.MethodBase mb) { }
        public static void RegisterSoapActionForMethodBase(System.Reflection.MethodBase mb, string soapAction) { }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class TypeEntry
    {
        protected TypeEntry() { }
        public string AssemblyName { get { return default(string); } set { } }
        public string TypeName { get { return default(string); } set { } }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class WellKnownClientTypeEntry : System.Runtime.Remoting.TypeEntry
    {
        public WellKnownClientTypeEntry(string typeName, string assemblyName, string objectUrl) { }
        public WellKnownClientTypeEntry(System.Type type, string objectUrl) { }
        public string ApplicationUrl { get { return default(string); } set { } }
        public System.Type ObjectType { get { return default(System.Type); } }
        public string ObjectUrl { get { return default(string); } }
        public override string ToString() { return default(string); }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum WellKnownObjectMode
    {
        SingleCall = 2,
        Singleton = 1,
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class WellKnownServiceTypeEntry : System.Runtime.Remoting.TypeEntry
    {
        public WellKnownServiceTypeEntry(string typeName, string assemblyName, string objectUri, System.Runtime.Remoting.WellKnownObjectMode mode) { }
        public WellKnownServiceTypeEntry(System.Type type, string objectUri, System.Runtime.Remoting.WellKnownObjectMode mode) { }
        public System.Runtime.Remoting.Contexts.IContextAttribute[] ContextAttributes { get { return default(System.Runtime.Remoting.Contexts.IContextAttribute[]); } set { } }
        public System.Runtime.Remoting.WellKnownObjectMode Mode { get { return default(System.Runtime.Remoting.WellKnownObjectMode); } }
        public System.Type ObjectType { get { return default(System.Type); } }
        public string ObjectUri { get { return default(string); } }
        public override string ToString() { return default(string); }
    }
} // end of System.Runtime.Remoting
namespace System.Runtime.Remoting.Activation {
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum ActivatorLevel
    {
        AppDomain = 12,
        Construction = 4,
        Context = 8,
        Machine = 20,
        Process = 16,
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IActivator
    {
        System.Runtime.Remoting.Activation.ActivatorLevel Level { get; }
        System.Runtime.Remoting.Activation.IActivator NextActivator { get; set; }
        System.Runtime.Remoting.Activation.IConstructionReturnMessage Activate(System.Runtime.Remoting.Activation.IConstructionCallMessage msg);
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IConstructionCallMessage : System.Runtime.Remoting.Messaging.IMessage, System.Runtime.Remoting.Messaging.IMethodCallMessage, System.Runtime.Remoting.Messaging.IMethodMessage
    {
        System.Type ActivationType { get; }
        string ActivationTypeName { get; }
        System.Runtime.Remoting.Activation.IActivator Activator { get; set; }
        object[] CallSiteActivationAttributes { get; }
        System.Collections.IList ContextProperties { get; }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IConstructionReturnMessage : System.Runtime.Remoting.Messaging.IMessage, System.Runtime.Remoting.Messaging.IMethodMessage, System.Runtime.Remoting.Messaging.IMethodReturnMessage
    {
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class UrlAttribute : System.Runtime.Remoting.Contexts.ContextAttribute
    {
        public UrlAttribute(string callsiteURL) : base(default(string)) { }
        public string UrlValue { get { return default(string); } }
        public override bool Equals(object o) { return default(bool); }
        public override int GetHashCode() { return default(int); }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public override void GetPropertiesForNewContext(System.Runtime.Remoting.Activation.IConstructionCallMessage ctorMsg) { }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public override bool IsContextOK(System.Runtime.Remoting.Contexts.Context ctx, System.Runtime.Remoting.Activation.IConstructionCallMessage msg) { return default(bool); }
    }
} // end of System.Runtime.Remoting.Activation
namespace System.Runtime.Remoting.Channels {
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class BaseChannelObjectWithProperties : System.Collections.ICollection, System.Collections.IDictionary, System.Collections.IEnumerable
    {
        protected BaseChannelObjectWithProperties() { }
        public virtual int Count { get { return default(int); } }
        public virtual bool IsFixedSize { get { return default(bool); } }
        public virtual bool IsReadOnly { get { return default(bool); } }
        public virtual bool IsSynchronized { get { return default(bool); } }
        public virtual object this[object key] { get { return default(object); } set { } }
        public virtual System.Collections.ICollection Keys { get { return default(System.Collections.ICollection); } }
        public virtual System.Collections.IDictionary Properties { get { return default(System.Collections.IDictionary); } }
        public virtual object SyncRoot { get { return default(object); } }
        public virtual System.Collections.ICollection Values { get { return default(System.Collections.ICollection); } }
        public virtual void Add(object key, object value) { }
        public virtual void Clear() { }
        public virtual bool Contains(object key) { return default(bool); }
        public virtual void CopyTo(System.Array array, int index) { }
        public virtual System.Collections.IDictionaryEnumerator GetEnumerator() { return default(System.Collections.IDictionaryEnumerator); }
        public virtual void Remove(object key) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class BaseChannelSinkWithProperties : System.Runtime.Remoting.Channels.BaseChannelObjectWithProperties
    {
        protected BaseChannelSinkWithProperties() { }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class BaseChannelWithProperties : System.Runtime.Remoting.Channels.BaseChannelObjectWithProperties
    {
        protected System.Runtime.Remoting.Channels.IChannelSinkBase SinksWithProperties;
        protected BaseChannelWithProperties() { }
        public override System.Collections.IDictionary Properties { get { return default(System.Collections.IDictionary); } }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ChannelDataStore : System.Runtime.Remoting.Channels.IChannelDataStore
    {
        public ChannelDataStore(string[] channelURIs) { }
        public string[] ChannelUris { get { return default(string[]); } set { } }
        public object this[object key] { get { return default(object); } set { } }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class ChannelServices
    {
        internal ChannelServices() { }
        public static System.Runtime.Remoting.Channels.IChannel[] RegisteredChannels { get { return default(System.Runtime.Remoting.Channels.IChannel[]); } }
        public static System.Runtime.Remoting.Messaging.IMessageCtrl AsyncDispatchMessage(System.Runtime.Remoting.Messaging.IMessage msg, System.Runtime.Remoting.Messaging.IMessageSink replySink) { return default(System.Runtime.Remoting.Messaging.IMessageCtrl); }
        public static System.Runtime.Remoting.Channels.IServerChannelSink CreateServerChannelSinkChain(System.Runtime.Remoting.Channels.IServerChannelSinkProvider provider, System.Runtime.Remoting.Channels.IChannelReceiver channel) { return default(System.Runtime.Remoting.Channels.IServerChannelSink); }
        public static System.Runtime.Remoting.Channels.ServerProcessing DispatchMessage(System.Runtime.Remoting.Channels.IServerChannelSinkStack sinkStack, System.Runtime.Remoting.Messaging.IMessage msg, out System.Runtime.Remoting.Messaging.IMessage replyMsg) { replyMsg = default(System.Runtime.Remoting.Messaging.IMessage); return default(System.Runtime.Remoting.Channels.ServerProcessing); }
        public static System.Runtime.Remoting.Channels.IChannel GetChannel(string name) { return default(System.Runtime.Remoting.Channels.IChannel); }
        public static System.Collections.IDictionary GetChannelSinkProperties(object obj) { return default(System.Collections.IDictionary); }
        public static string[] GetUrlsForObject(System.MarshalByRefObject obj) { return default(string[]); }
        [System.ObsoleteAttribute("Use RegisterChannel(IChannel,Boolean)")]
        public static void RegisterChannel(System.Runtime.Remoting.Channels.IChannel chnl) { }
        public static void RegisterChannel(System.Runtime.Remoting.Channels.IChannel chnl, bool ensureSecurity) { }
        public static System.Runtime.Remoting.Messaging.IMessage SyncDispatchMessage(System.Runtime.Remoting.Messaging.IMessage msg) { return default(System.Runtime.Remoting.Messaging.IMessage); }
        public static void UnregisterChannel(System.Runtime.Remoting.Channels.IChannel chnl) { }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ClientChannelSinkStack : System.Runtime.Remoting.Channels.IClientChannelSinkStack, System.Runtime.Remoting.Channels.IClientResponseChannelSinkStack
    {
        public ClientChannelSinkStack() { }
        public ClientChannelSinkStack(System.Runtime.Remoting.Messaging.IMessageSink replySink) { }
        public void AsyncProcessResponse(System.Runtime.Remoting.Channels.ITransportHeaders headers, System.IO.Stream stream) { }
        public void DispatchException(System.Exception e) { }
        public void DispatchReplyMessage(System.Runtime.Remoting.Messaging.IMessage msg) { }
        public object Pop(System.Runtime.Remoting.Channels.IClientChannelSink sink) { return default(object); }
        public void Push(System.Runtime.Remoting.Channels.IClientChannelSink sink, object state) { }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IChannel
    {
        string ChannelName { get; }
        int ChannelPriority { get; }
        string Parse(string url, out string objectURI);
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IChannelDataStore
    {
        string[] ChannelUris { get; }
        object this[object key] { get; set; }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IChannelReceiver : System.Runtime.Remoting.Channels.IChannel
    {
        object ChannelData { get; }
        string[] GetUrlsForUri(string objectURI);
        void StartListening(object data);
        void StopListening(object data);
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IChannelReceiverHook
    {
        string ChannelScheme { get; }
        System.Runtime.Remoting.Channels.IServerChannelSink ChannelSinkChain { get; }
        bool WantsToListen { get; }
        void AddHookChannelUri(string channelUri);
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IChannelSender : System.Runtime.Remoting.Channels.IChannel
    {
        System.Runtime.Remoting.Messaging.IMessageSink CreateMessageSink(string url, object remoteChannelData, out string objectURI);
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IChannelSinkBase
    {
        System.Collections.IDictionary Properties { get; }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IClientChannelSink : System.Runtime.Remoting.Channels.IChannelSinkBase
    {
        System.Runtime.Remoting.Channels.IClientChannelSink NextChannelSink { get; }
        void AsyncProcessRequest(System.Runtime.Remoting.Channels.IClientChannelSinkStack sinkStack, System.Runtime.Remoting.Messaging.IMessage msg, System.Runtime.Remoting.Channels.ITransportHeaders headers, System.IO.Stream stream);
        void AsyncProcessResponse(System.Runtime.Remoting.Channels.IClientResponseChannelSinkStack sinkStack, object state, System.Runtime.Remoting.Channels.ITransportHeaders headers, System.IO.Stream stream);
        System.IO.Stream GetRequestStream(System.Runtime.Remoting.Messaging.IMessage msg, System.Runtime.Remoting.Channels.ITransportHeaders headers);
        void ProcessMessage(System.Runtime.Remoting.Messaging.IMessage msg, System.Runtime.Remoting.Channels.ITransportHeaders requestHeaders, System.IO.Stream requestStream, out System.Runtime.Remoting.Channels.ITransportHeaders responseHeaders, out System.IO.Stream responseStream);
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IClientChannelSinkProvider
    {
        System.Runtime.Remoting.Channels.IClientChannelSinkProvider Next { get; set; }
        System.Runtime.Remoting.Channels.IClientChannelSink CreateSink(System.Runtime.Remoting.Channels.IChannelSender channel, string url, object remoteChannelData);
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IClientChannelSinkStack : System.Runtime.Remoting.Channels.IClientResponseChannelSinkStack
    {
        object Pop(System.Runtime.Remoting.Channels.IClientChannelSink sink);
        void Push(System.Runtime.Remoting.Channels.IClientChannelSink sink, object state);
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IClientFormatterSink : System.Runtime.Remoting.Channels.IChannelSinkBase, System.Runtime.Remoting.Channels.IClientChannelSink, System.Runtime.Remoting.Messaging.IMessageSink
    {
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IClientFormatterSinkProvider : System.Runtime.Remoting.Channels.IClientChannelSinkProvider
    {
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IClientResponseChannelSinkStack
    {
        void AsyncProcessResponse(System.Runtime.Remoting.Channels.ITransportHeaders headers, System.IO.Stream stream);
        void DispatchException(System.Exception e);
        void DispatchReplyMessage(System.Runtime.Remoting.Messaging.IMessage msg);
    }

    public partial interface ISecurableChannel
    {
        bool IsSecured { get; set; }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IServerChannelSink : System.Runtime.Remoting.Channels.IChannelSinkBase
    {
        System.Runtime.Remoting.Channels.IServerChannelSink NextChannelSink { get; }
        void AsyncProcessResponse(System.Runtime.Remoting.Channels.IServerResponseChannelSinkStack sinkStack, object state, System.Runtime.Remoting.Messaging.IMessage msg, System.Runtime.Remoting.Channels.ITransportHeaders headers, System.IO.Stream stream);
        System.IO.Stream GetResponseStream(System.Runtime.Remoting.Channels.IServerResponseChannelSinkStack sinkStack, object state, System.Runtime.Remoting.Messaging.IMessage msg, System.Runtime.Remoting.Channels.ITransportHeaders headers);
        System.Runtime.Remoting.Channels.ServerProcessing ProcessMessage(System.Runtime.Remoting.Channels.IServerChannelSinkStack sinkStack, System.Runtime.Remoting.Messaging.IMessage requestMsg, System.Runtime.Remoting.Channels.ITransportHeaders requestHeaders, System.IO.Stream requestStream, out System.Runtime.Remoting.Messaging.IMessage responseMsg, out System.Runtime.Remoting.Channels.ITransportHeaders responseHeaders, out System.IO.Stream responseStream);
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IServerChannelSinkProvider
    {
        System.Runtime.Remoting.Channels.IServerChannelSinkProvider Next { get; set; }
        System.Runtime.Remoting.Channels.IServerChannelSink CreateSink(System.Runtime.Remoting.Channels.IChannelReceiver channel);
        void GetChannelData(System.Runtime.Remoting.Channels.IChannelDataStore channelData);
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IServerChannelSinkStack : System.Runtime.Remoting.Channels.IServerResponseChannelSinkStack
    {
        object Pop(System.Runtime.Remoting.Channels.IServerChannelSink sink);
        void Push(System.Runtime.Remoting.Channels.IServerChannelSink sink, object state);
        void ServerCallback(System.IAsyncResult ar);
        void Store(System.Runtime.Remoting.Channels.IServerChannelSink sink, object state);
        void StoreAndDispatch(System.Runtime.Remoting.Channels.IServerChannelSink sink, object state);
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IServerFormatterSinkProvider : System.Runtime.Remoting.Channels.IServerChannelSinkProvider
    {
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IServerResponseChannelSinkStack
    {
        void AsyncProcessResponse(System.Runtime.Remoting.Messaging.IMessage msg, System.Runtime.Remoting.Channels.ITransportHeaders headers, System.IO.Stream stream);
        System.IO.Stream GetResponseStream(System.Runtime.Remoting.Messaging.IMessage msg, System.Runtime.Remoting.Channels.ITransportHeaders headers);
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface ITransportHeaders
    {
        object this[object key] { get; set; }
        System.Collections.IEnumerator GetEnumerator();
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ServerChannelSinkStack : System.Runtime.Remoting.Channels.IServerChannelSinkStack, System.Runtime.Remoting.Channels.IServerResponseChannelSinkStack
    {
        public ServerChannelSinkStack() { }
        public void AsyncProcessResponse(System.Runtime.Remoting.Messaging.IMessage msg, System.Runtime.Remoting.Channels.ITransportHeaders headers, System.IO.Stream stream) { }
        public System.IO.Stream GetResponseStream(System.Runtime.Remoting.Messaging.IMessage msg, System.Runtime.Remoting.Channels.ITransportHeaders headers) { return default(System.IO.Stream); }
        public object Pop(System.Runtime.Remoting.Channels.IServerChannelSink sink) { return default(object); }
        public void Push(System.Runtime.Remoting.Channels.IServerChannelSink sink, object state) { }
        public void ServerCallback(System.IAsyncResult ar) { }
        public void Store(System.Runtime.Remoting.Channels.IServerChannelSink sink, object state) { }
        public void StoreAndDispatch(System.Runtime.Remoting.Channels.IServerChannelSink sink, object state) { }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum ServerProcessing
    {
        Async = 2,
        Complete = 0,
        OneWay = 1,
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SinkProviderData
    {
        public SinkProviderData(string name) { }
        public System.Collections.IList Children { get { return default(System.Collections.IList); } }
        public string Name { get { return default(string); } }
        public System.Collections.IDictionary Properties { get { return default(System.Collections.IDictionary); } }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class TransportHeaders : System.Runtime.Remoting.Channels.ITransportHeaders
    {
        public TransportHeaders() { }
        public object this[object key] { get { return default(object); } set { } }
        public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    }
} // end of System.Runtime.Remoting.Channels
namespace System.Runtime.Remoting.Contexts {
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class Context
    {
        public Context() { }
        public virtual int ContextID { get { return default(int); } }
        public virtual System.Runtime.Remoting.Contexts.IContextProperty[] ContextProperties { get { return default(System.Runtime.Remoting.Contexts.IContextProperty[]); } }
        public static System.Runtime.Remoting.Contexts.Context DefaultContext { get { return default(System.Runtime.Remoting.Contexts.Context); } }
        public static System.LocalDataStoreSlot AllocateDataSlot() { return default(System.LocalDataStoreSlot); }
        public static System.LocalDataStoreSlot AllocateNamedDataSlot(string name) { return default(System.LocalDataStoreSlot); }
        public void DoCallBack(System.Runtime.Remoting.Contexts.CrossContextDelegate deleg) { }
        ~Context() { }
        public static void FreeNamedDataSlot(string name) { }
        public virtual void Freeze() { }
        public static object GetData(System.LocalDataStoreSlot slot) { return default(object); }
        public static System.LocalDataStoreSlot GetNamedDataSlot(string name) { return default(System.LocalDataStoreSlot); }
        public virtual System.Runtime.Remoting.Contexts.IContextProperty GetProperty(string name) { return default(System.Runtime.Remoting.Contexts.IContextProperty); }
        public static bool RegisterDynamicProperty(System.Runtime.Remoting.Contexts.IDynamicProperty prop, System.ContextBoundObject obj, System.Runtime.Remoting.Contexts.Context ctx) { return default(bool); }
        public static void SetData(System.LocalDataStoreSlot slot, object data) { }
        public virtual void SetProperty(System.Runtime.Remoting.Contexts.IContextProperty prop) { }
        public override string ToString() { return default(string); }
        public static bool UnregisterDynamicProperty(string name, System.ContextBoundObject obj, System.Runtime.Remoting.Contexts.Context ctx) { return default(bool); }
    }

    [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ContextAttribute : System.Attribute, System.Runtime.Remoting.Contexts.IContextAttribute, System.Runtime.Remoting.Contexts.IContextProperty
    {
        protected string AttributeName;
        public ContextAttribute(string name) { }
        public virtual string Name { get { return default(string); } }
        public override bool Equals(object o) { return default(bool); }
        public virtual void Freeze(System.Runtime.Remoting.Contexts.Context newContext) { }
        public override int GetHashCode() { return default(int); }
        public virtual void GetPropertiesForNewContext(System.Runtime.Remoting.Activation.IConstructionCallMessage ctorMsg) { }
        public virtual bool IsContextOK(System.Runtime.Remoting.Contexts.Context ctx, System.Runtime.Remoting.Activation.IConstructionCallMessage ctorMsg) { return default(bool); }
        public virtual bool IsNewContextOK(System.Runtime.Remoting.Contexts.Context newCtx) { return default(bool); }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ContextProperty
    {
        internal ContextProperty() { }
        public virtual string Name { get { return default(string); } }
        public virtual object Property { get { return default(object); } }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public delegate void CrossContextDelegate();

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IContextAttribute
    {
        void GetPropertiesForNewContext(System.Runtime.Remoting.Activation.IConstructionCallMessage msg);
        bool IsContextOK(System.Runtime.Remoting.Contexts.Context ctx, System.Runtime.Remoting.Activation.IConstructionCallMessage msg);
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IContextProperty
    {
        string Name { get; }
        void Freeze(System.Runtime.Remoting.Contexts.Context newContext);
        bool IsNewContextOK(System.Runtime.Remoting.Contexts.Context newCtx);
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IContextPropertyActivator
    {
        void CollectFromClientContext(System.Runtime.Remoting.Activation.IConstructionCallMessage msg);
        void CollectFromServerContext(System.Runtime.Remoting.Activation.IConstructionReturnMessage msg);
        bool DeliverClientContextToServerContext(System.Runtime.Remoting.Activation.IConstructionCallMessage msg);
        bool DeliverServerContextToClientContext(System.Runtime.Remoting.Activation.IConstructionReturnMessage msg);
        bool IsOKToActivate(System.Runtime.Remoting.Activation.IConstructionCallMessage msg);
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IContributeClientContextSink
    {
        System.Runtime.Remoting.Messaging.IMessageSink GetClientContextSink(System.Runtime.Remoting.Messaging.IMessageSink nextSink);
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IContributeDynamicSink
    {
        System.Runtime.Remoting.Contexts.IDynamicMessageSink GetDynamicSink();
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IContributeEnvoySink
    {
        System.Runtime.Remoting.Messaging.IMessageSink GetEnvoySink(System.MarshalByRefObject obj, System.Runtime.Remoting.Messaging.IMessageSink nextSink);
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IContributeObjectSink
    {
        System.Runtime.Remoting.Messaging.IMessageSink GetObjectSink(System.MarshalByRefObject obj, System.Runtime.Remoting.Messaging.IMessageSink nextSink);
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IContributeServerContextSink
    {
        System.Runtime.Remoting.Messaging.IMessageSink GetServerContextSink(System.Runtime.Remoting.Messaging.IMessageSink nextSink);
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IDynamicMessageSink
    {
        void ProcessMessageFinish(System.Runtime.Remoting.Messaging.IMessage replyMsg, bool bCliSide, bool bAsync);
        void ProcessMessageStart(System.Runtime.Remoting.Messaging.IMessage reqMsg, bool bCliSide, bool bAsync);
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IDynamicProperty
    {
        string Name { get; }
    }

    [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SynchronizationAttribute : System.Runtime.Remoting.Contexts.ContextAttribute, System.Runtime.Remoting.Contexts.IContributeClientContextSink, System.Runtime.Remoting.Contexts.IContributeServerContextSink
    {
        public const int NOT_SUPPORTED = 1;
        public const int REQUIRED = 4;
        public const int REQUIRES_NEW = 8;
        public const int SUPPORTED = 2;
        public SynchronizationAttribute() : base(default(string)) { }
        public SynchronizationAttribute(bool reEntrant) : base(default(string)) { }
        public SynchronizationAttribute(int flag) : base(default(string)) { }
        public SynchronizationAttribute(int flag, bool reEntrant) : base(default(string)) { }
        public virtual bool IsReEntrant { get { return default(bool); } }
        public virtual bool Locked { get { return default(bool); } set { } }
        public virtual System.Runtime.Remoting.Messaging.IMessageSink GetClientContextSink(System.Runtime.Remoting.Messaging.IMessageSink nextSink) { return default(System.Runtime.Remoting.Messaging.IMessageSink); }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public override void GetPropertiesForNewContext(System.Runtime.Remoting.Activation.IConstructionCallMessage ctorMsg) { }
        public virtual System.Runtime.Remoting.Messaging.IMessageSink GetServerContextSink(System.Runtime.Remoting.Messaging.IMessageSink nextSink) { return default(System.Runtime.Remoting.Messaging.IMessageSink); }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public override bool IsContextOK(System.Runtime.Remoting.Contexts.Context ctx, System.Runtime.Remoting.Activation.IConstructionCallMessage msg) { return default(bool); }
    }
} // end of System.Runtime.Remoting.Contexts
namespace System.Runtime.Remoting.Lifetime {
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ClientSponsor : System.MarshalByRefObject, System.Runtime.Remoting.Lifetime.ISponsor
    {
        public ClientSponsor() { }
        public ClientSponsor(System.TimeSpan renewalTime) { }
        public System.TimeSpan RenewalTime { get { return default(System.TimeSpan); } set { } }
        public void Close() { }
        ~ClientSponsor() { }
        public override object InitializeLifetimeService() { return default(object); }
        public bool Register(System.MarshalByRefObject obj) { return default(bool); }
        public System.TimeSpan Renewal(System.Runtime.Remoting.Lifetime.ILease lease) { return default(System.TimeSpan); }
        public void Unregister(System.MarshalByRefObject obj) { }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface ILease
    {
        System.TimeSpan CurrentLeaseTime { get; }
        System.Runtime.Remoting.Lifetime.LeaseState CurrentState { get; }
        System.TimeSpan InitialLeaseTime { get; set; }
        System.TimeSpan RenewOnCallTime { get; set; }
        System.TimeSpan SponsorshipTimeout { get; set; }
        void Register(System.Runtime.Remoting.Lifetime.ISponsor obj);
        void Register(System.Runtime.Remoting.Lifetime.ISponsor obj, System.TimeSpan renewalTime);
        System.TimeSpan Renew(System.TimeSpan renewalTime);
        void Unregister(System.Runtime.Remoting.Lifetime.ISponsor obj);
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface ISponsor
    {
        System.TimeSpan Renewal(System.Runtime.Remoting.Lifetime.ILease lease);
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum LeaseState
    {
        Active = 2,
        Expired = 4,
        Initial = 1,
        Null = 0,
        Renewing = 3,
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class LifetimeServices
    {
        [System.ObsoleteAttribute("Call the static methods directly on this type instead", true)]
        public LifetimeServices() { }
        public static System.TimeSpan LeaseManagerPollTime { get { return default(System.TimeSpan); } set { } }
        public static System.TimeSpan LeaseTime { get { return default(System.TimeSpan); } set { } }
        public static System.TimeSpan RenewOnCallTime { get { return default(System.TimeSpan); } set { } }
        public static System.TimeSpan SponsorshipTimeout { get { return default(System.TimeSpan); } set { } }
    }
} // end of System.Runtime.Remoting.Lifetime
namespace System.Runtime.Remoting.Messaging {
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class AsyncResult : System.IAsyncResult, System.Runtime.Remoting.Messaging.IMessageSink
    {
        internal AsyncResult() { }
        public virtual object AsyncDelegate { get { return default(object); } }
        public virtual object AsyncState { get { return default(object); } }
        public virtual System.Threading.WaitHandle AsyncWaitHandle { get { return default(System.Threading.WaitHandle); } }
        public virtual bool CompletedSynchronously { get { return default(bool); } }
        public bool EndInvokeCalled { get { return default(bool); } set { } }
        public virtual bool IsCompleted { get { return default(bool); } }
        public System.Runtime.Remoting.Messaging.IMessageSink NextSink { get { return default(System.Runtime.Remoting.Messaging.IMessageSink); } }
        public virtual System.Runtime.Remoting.Messaging.IMessageCtrl AsyncProcessMessage(System.Runtime.Remoting.Messaging.IMessage msg, System.Runtime.Remoting.Messaging.IMessageSink replySink) { return default(System.Runtime.Remoting.Messaging.IMessageCtrl); }
        public virtual System.Runtime.Remoting.Messaging.IMessage GetReplyMessage() { return default(System.Runtime.Remoting.Messaging.IMessage); }
        public virtual void SetMessageCtrl(System.Runtime.Remoting.Messaging.IMessageCtrl mc) { }
        public virtual System.Runtime.Remoting.Messaging.IMessage SyncProcessMessage(System.Runtime.Remoting.Messaging.IMessage msg) { return default(System.Runtime.Remoting.Messaging.IMessage); }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Security.SecurityCriticalAttribute]
    public sealed partial class CallContext
    {
        internal CallContext() { }
        public static object HostContext { [System.Security.SecurityCriticalAttribute]get { return default(object); } [System.Security.SecurityCriticalAttribute]set { } }
        [System.Security.SecurityCriticalAttribute]
        public static void FreeNamedDataSlot(string name) { }
        [System.Security.SecurityCriticalAttribute]
        public static object GetData(string name) { return default(object); }
        [System.Security.SecurityCriticalAttribute]
        public static System.Runtime.Remoting.Messaging.Header[] GetHeaders() { return default(System.Runtime.Remoting.Messaging.Header[]); }
        [System.Security.SecurityCriticalAttribute]
        public static object LogicalGetData(string name) { return default(object); }
        [System.Security.SecurityCriticalAttribute]
        public static void LogicalSetData(string name, object data) { }
        [System.Security.SecurityCriticalAttribute]
        public static void SetData(string name, object data) { }
        [System.Security.SecurityCriticalAttribute]
        public static void SetHeaders(System.Runtime.Remoting.Messaging.Header[] headers) { }
    }

    [System.CLSCompliantAttribute(false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ConstructionCall : System.Runtime.Remoting.Messaging.MethodCall, System.Runtime.Remoting.Activation.IConstructionCallMessage, System.Runtime.Remoting.Messaging.IMessage, System.Runtime.Remoting.Messaging.IMethodCallMessage, System.Runtime.Remoting.Messaging.IMethodMessage
    {
        public ConstructionCall(System.Runtime.Remoting.Messaging.Header[] headers) : base(default(System.Runtime.Remoting.Messaging.Header[])) { }
        public ConstructionCall(System.Runtime.Remoting.Messaging.IMessage m) : base(default(System.Runtime.Remoting.Messaging.Header[])) { }
        public System.Type ActivationType { get { return default(System.Type); } }
        public string ActivationTypeName { get { return default(string); } }
        public System.Runtime.Remoting.Activation.IActivator Activator { get { return default(System.Runtime.Remoting.Activation.IActivator); } set { } }
        public object[] CallSiteActivationAttributes { get { return default(object[]); } }
        public System.Collections.IList ContextProperties { get { return default(System.Collections.IList); } }
        public override System.Collections.IDictionary Properties { get { return default(System.Collections.IDictionary); } }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }

    [System.CLSCompliantAttribute(false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ConstructionResponse : System.Runtime.Remoting.Messaging.MethodResponse, System.Runtime.Remoting.Activation.IConstructionReturnMessage, System.Runtime.Remoting.Messaging.IMessage, System.Runtime.Remoting.Messaging.IMethodMessage, System.Runtime.Remoting.Messaging.IMethodReturnMessage
    {
        public ConstructionResponse(System.Runtime.Remoting.Messaging.Header[] h, System.Runtime.Remoting.Messaging.IMethodCallMessage mcm) : base(default(System.Runtime.Remoting.Messaging.Header[]), default(System.Runtime.Remoting.Messaging.IMethodCallMessage)) { }
        public override System.Collections.IDictionary Properties { get { return default(System.Collections.IDictionary); } }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class Header
    {
        public string HeaderNamespace;
        public bool MustUnderstand;
        public string Name;
        public object Value;
        public Header(string _Name, object _Value) { }
        public Header(string _Name, object _Value, bool _MustUnderstand) { }
        public Header(string _Name, object _Value, bool _MustUnderstand, string _HeaderNamespace) { }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public delegate object HeaderHandler(System.Runtime.Remoting.Messaging.Header[] headers);

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface ILogicalThreadAffinative
    {
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IMessage
    {
        System.Collections.IDictionary Properties { get; }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IMessageCtrl
    {
        void Cancel(int msToCancel);
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IMessageSink
    {
        System.Runtime.Remoting.Messaging.IMessageSink NextSink { get; }
        System.Runtime.Remoting.Messaging.IMessageCtrl AsyncProcessMessage(System.Runtime.Remoting.Messaging.IMessage msg, System.Runtime.Remoting.Messaging.IMessageSink replySink);
        System.Runtime.Remoting.Messaging.IMessage SyncProcessMessage(System.Runtime.Remoting.Messaging.IMessage msg);
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IMethodCallMessage : System.Runtime.Remoting.Messaging.IMessage, System.Runtime.Remoting.Messaging.IMethodMessage
    {
        int InArgCount { get; }
        object[] InArgs { get; }
        object GetInArg(int argNum);
        string GetInArgName(int index);
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IMethodMessage : System.Runtime.Remoting.Messaging.IMessage
    {
        int ArgCount { get; }
        object[] Args { get; }
        bool HasVarArgs { get; }
        System.Runtime.Remoting.Messaging.LogicalCallContext LogicalCallContext { get; }
        System.Reflection.MethodBase MethodBase { get; }
        string MethodName { get; }
        object MethodSignature { get; }
        string TypeName { get; }
        string Uri { get; }
        object GetArg(int argNum);
        string GetArgName(int index);
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IMethodReturnMessage : System.Runtime.Remoting.Messaging.IMessage, System.Runtime.Remoting.Messaging.IMethodMessage
    {
        System.Exception Exception { get; }
        int OutArgCount { get; }
        object[] OutArgs { get; }
        object ReturnValue { get; }
        object GetOutArg(int argNum);
        string GetOutArgName(int index);
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class InternalMessageWrapper
    {
        protected System.Runtime.Remoting.Messaging.IMessage WrappedMessage;
        public InternalMessageWrapper(System.Runtime.Remoting.Messaging.IMessage msg) { }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IRemotingFormatter : System.Runtime.Serialization.IFormatter
    {
        object Deserialize(System.IO.Stream serializationStream, System.Runtime.Remoting.Messaging.HeaderHandler handler);
        void Serialize(System.IO.Stream serializationStream, object graph, System.Runtime.Remoting.Messaging.Header[] headers);
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Security.SecurityCriticalAttribute]
    public sealed partial class LogicalCallContext : System.ICloneable, System.Runtime.Serialization.ISerializable
    {
        internal LogicalCallContext() { }
        public bool HasInfo { [System.Security.SecurityCriticalAttribute]get { return default(bool); } }
        [System.Security.SecuritySafeCriticalAttribute]
        public object Clone() { return default(object); }
        [System.Security.SecurityCriticalAttribute]
        public void FreeNamedDataSlot(string name) { }
        [System.Security.SecurityCriticalAttribute]
        public object GetData(string name) { return default(object); }
        [System.Security.SecurityCriticalAttribute]
        public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        [System.Security.SecurityCriticalAttribute]
        public void SetData(string name, object data) { }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public delegate bool MessageSurrogateFilter(string key, object value);

    [System.CLSCompliantAttribute(false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class MethodCall : System.Runtime.Remoting.Messaging.IMessage, System.Runtime.Remoting.Messaging.IMethodCallMessage, System.Runtime.Remoting.Messaging.IMethodMessage, System.Runtime.Serialization.ISerializable
    {
        protected System.Collections.IDictionary ExternalProperties;
        protected System.Collections.IDictionary InternalProperties;
        public MethodCall(System.Runtime.Remoting.Messaging.Header[] h1) { }
        public MethodCall(System.Runtime.Remoting.Messaging.IMessage msg) { }
        public int ArgCount { get { return default(int); } }
        public object[] Args { get { return default(object[]); } }
        public bool HasVarArgs { get { return default(bool); } }
        public int InArgCount { get { return default(int); } }
        public object[] InArgs { get { return default(object[]); } }
        public System.Runtime.Remoting.Messaging.LogicalCallContext LogicalCallContext { get { return default(System.Runtime.Remoting.Messaging.LogicalCallContext); } }
        public System.Reflection.MethodBase MethodBase { get { return default(System.Reflection.MethodBase); } }
        public string MethodName { get { return default(string); } }
        public object MethodSignature { get { return default(object); } }
        public virtual System.Collections.IDictionary Properties { get { return default(System.Collections.IDictionary); } }
        public string TypeName { get { return default(string); } }
        public string Uri { get { return default(string); } set { } }
        public object GetArg(int argNum) { return default(object); }
        public string GetArgName(int index) { return default(string); }
        public object GetInArg(int argNum) { return default(object); }
        public string GetInArgName(int index) { return default(string); }
        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public virtual object HeaderHandler(System.Runtime.Remoting.Messaging.Header[] h) { return default(object); }
        public virtual void Init() { }
        public void ResolveMethod() { }
        public void RootSetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext ctx) { }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class MethodCallMessageWrapper : System.Runtime.Remoting.Messaging.InternalMessageWrapper, System.Runtime.Remoting.Messaging.IMessage, System.Runtime.Remoting.Messaging.IMethodCallMessage, System.Runtime.Remoting.Messaging.IMethodMessage
    {
        public MethodCallMessageWrapper(System.Runtime.Remoting.Messaging.IMethodCallMessage msg) : base(default(System.Runtime.Remoting.Messaging.IMessage)) { }
        public virtual int ArgCount { get { return default(int); } }
        public virtual object[] Args { get { return default(object[]); } set { } }
        public virtual bool HasVarArgs { get { return default(bool); } }
        public virtual int InArgCount { get { return default(int); } }
        public virtual object[] InArgs { get { return default(object[]); } }
        public virtual System.Runtime.Remoting.Messaging.LogicalCallContext LogicalCallContext { get { return default(System.Runtime.Remoting.Messaging.LogicalCallContext); } }
        public virtual System.Reflection.MethodBase MethodBase { get { return default(System.Reflection.MethodBase); } }
        public virtual string MethodName { get { return default(string); } }
        public virtual object MethodSignature { get { return default(object); } }
        public virtual System.Collections.IDictionary Properties { get { return default(System.Collections.IDictionary); } }
        public virtual string TypeName { get { return default(string); } }
        public virtual string Uri { get { return default(string); } set { } }
        public virtual object GetArg(int argNum) { return default(object); }
        public virtual string GetArgName(int index) { return default(string); }
        public virtual object GetInArg(int argNum) { return default(object); }
        public virtual string GetInArgName(int index) { return default(string); }
    }

    [System.CLSCompliantAttribute(false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class MethodResponse : System.Runtime.Remoting.Messaging.IMessage, System.Runtime.Remoting.Messaging.IMethodMessage, System.Runtime.Remoting.Messaging.IMethodReturnMessage, System.Runtime.Serialization.ISerializable
    {
        protected System.Collections.IDictionary ExternalProperties;
        protected System.Collections.IDictionary InternalProperties;
        public MethodResponse(System.Runtime.Remoting.Messaging.Header[] h1, System.Runtime.Remoting.Messaging.IMethodCallMessage mcm) { }
        public int ArgCount { get { return default(int); } }
        public object[] Args { get { return default(object[]); } }
        public System.Exception Exception { get { return default(System.Exception); } }
        public bool HasVarArgs { get { return default(bool); } }
        public System.Runtime.Remoting.Messaging.LogicalCallContext LogicalCallContext { get { return default(System.Runtime.Remoting.Messaging.LogicalCallContext); } }
        public System.Reflection.MethodBase MethodBase { get { return default(System.Reflection.MethodBase); } }
        public string MethodName { get { return default(string); } }
        public object MethodSignature { get { return default(object); } }
        public int OutArgCount { get { return default(int); } }
        public object[] OutArgs { get { return default(object[]); } }
        public virtual System.Collections.IDictionary Properties { get { return default(System.Collections.IDictionary); } }
        public object ReturnValue { get { return default(object); } }
        public string TypeName { get { return default(string); } }
        public string Uri { get { return default(string); } set { } }
        public object GetArg(int argNum) { return default(object); }
        public string GetArgName(int index) { return default(string); }
        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public object GetOutArg(int argNum) { return default(object); }
        public string GetOutArgName(int index) { return default(string); }
        public virtual object HeaderHandler(System.Runtime.Remoting.Messaging.Header[] h) { return default(object); }
        public void RootSetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext ctx) { }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class MethodReturnMessageWrapper : System.Runtime.Remoting.Messaging.InternalMessageWrapper, System.Runtime.Remoting.Messaging.IMessage, System.Runtime.Remoting.Messaging.IMethodMessage, System.Runtime.Remoting.Messaging.IMethodReturnMessage
    {
        public MethodReturnMessageWrapper(System.Runtime.Remoting.Messaging.IMethodReturnMessage msg) : base(default(System.Runtime.Remoting.Messaging.IMessage)) { }
        public virtual int ArgCount { get { return default(int); } }
        public virtual object[] Args { get { return default(object[]); } set { } }
        public virtual System.Exception Exception { get { return default(System.Exception); } set { } }
        public virtual bool HasVarArgs { get { return default(bool); } }
        public virtual System.Runtime.Remoting.Messaging.LogicalCallContext LogicalCallContext { get { return default(System.Runtime.Remoting.Messaging.LogicalCallContext); } }
        public virtual System.Reflection.MethodBase MethodBase { get { return default(System.Reflection.MethodBase); } }
        public virtual string MethodName { get { return default(string); } }
        public virtual object MethodSignature { get { return default(object); } }
        public virtual int OutArgCount { get { return default(int); } }
        public virtual object[] OutArgs { get { return default(object[]); } }
        public virtual System.Collections.IDictionary Properties { get { return default(System.Collections.IDictionary); } }
        public virtual object ReturnValue { get { return default(object); } set { } }
        public virtual string TypeName { get { return default(string); } }
        public string Uri { get { return default(string); } set { } }
        public virtual object GetArg(int argNum) { return default(object); }
        public virtual string GetArgName(int index) { return default(string); }
        public virtual object GetOutArg(int argNum) { return default(object); }
        public virtual string GetOutArgName(int index) { return default(string); }
    }

    [System.AttributeUsageAttribute((System.AttributeTargets)(64))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class OneWayAttribute : System.Attribute
    {
        public OneWayAttribute() { }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class RemotingSurrogateSelector : System.Runtime.Serialization.ISurrogateSelector
    {
        public RemotingSurrogateSelector() { }
        public System.Runtime.Remoting.Messaging.MessageSurrogateFilter Filter { get { return default(System.Runtime.Remoting.Messaging.MessageSurrogateFilter); } set { } }
        public virtual void ChainSelector(System.Runtime.Serialization.ISurrogateSelector selector) { }
        public virtual System.Runtime.Serialization.ISurrogateSelector GetNextSelector() { return default(System.Runtime.Serialization.ISurrogateSelector); }
        public object GetRootObject() { return default(object); }
        public virtual System.Runtime.Serialization.ISerializationSurrogate GetSurrogate(System.Type type, System.Runtime.Serialization.StreamingContext context, out System.Runtime.Serialization.ISurrogateSelector ssout) { ssout = default(System.Runtime.Serialization.ISurrogateSelector); return default(System.Runtime.Serialization.ISerializationSurrogate); }
        public void SetRootObject(object obj) { }
        public virtual void UseSoapFormat() { }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ReturnMessage : System.Runtime.Remoting.Messaging.IMessage, System.Runtime.Remoting.Messaging.IMethodMessage, System.Runtime.Remoting.Messaging.IMethodReturnMessage
    {
        public ReturnMessage(System.Exception e, System.Runtime.Remoting.Messaging.IMethodCallMessage mcm) { }
        public ReturnMessage(object ret, object[] outArgs, int outArgsCount, System.Runtime.Remoting.Messaging.LogicalCallContext callCtx, System.Runtime.Remoting.Messaging.IMethodCallMessage mcm) { }
        public int ArgCount { get { return default(int); } }
        public object[] Args { get { return default(object[]); } }
        public System.Exception Exception { get { return default(System.Exception); } }
        public bool HasVarArgs { get { return default(bool); } }
        public System.Runtime.Remoting.Messaging.LogicalCallContext LogicalCallContext { get { return default(System.Runtime.Remoting.Messaging.LogicalCallContext); } }
        public System.Reflection.MethodBase MethodBase { get { return default(System.Reflection.MethodBase); } }
        public string MethodName { get { return default(string); } }
        public object MethodSignature { get { return default(object); } }
        public int OutArgCount { get { return default(int); } }
        public object[] OutArgs { get { return default(object[]); } }
        public virtual System.Collections.IDictionary Properties { get { return default(System.Collections.IDictionary); } }
        public virtual object ReturnValue { get { return default(object); } }
        public string TypeName { get { return default(string); } }
        public string Uri { get { return default(string); } set { } }
        public object GetArg(int argNum) { return default(object); }
        public string GetArgName(int index) { return default(string); }
        public object GetOutArg(int argNum) { return default(object); }
        public string GetOutArgName(int index) { return default(string); }
    }
} // end of System.Runtime.Remoting.Messaging
namespace System.Runtime.Remoting.Metadata {
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SoapAttribute : System.Attribute
    {
        protected string ProtXmlNamespace;
        protected object ReflectInfo;
        public SoapAttribute() { }
        public virtual bool Embedded { get { return default(bool); } set { } }
        public virtual bool UseAttribute { get { return default(bool); } set { } }
        public virtual string XmlNamespace { get { return default(string); } set { } }
    }

    [System.AttributeUsageAttribute((System.AttributeTargets)(256))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapFieldAttribute : System.Runtime.Remoting.Metadata.SoapAttribute
    {
        public SoapFieldAttribute() { }
        public int Order { get { return default(int); } set { } }
        public string XmlElementName { get { return default(string); } set { } }
        public bool IsInteropXmlElement() { return default(bool); }
    }

    [System.AttributeUsageAttribute((System.AttributeTargets)(64))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapMethodAttribute : System.Runtime.Remoting.Metadata.SoapAttribute
    {
        public SoapMethodAttribute() { }
        public string ResponseXmlElementName { get { return default(string); } set { } }
        public string ResponseXmlNamespace { get { return default(string); } set { } }
        public string ReturnXmlElementName { get { return default(string); } set { } }
        public string SoapAction { get { return default(string); } set { } }
        public override bool UseAttribute { get { return default(bool); } set { } }
        public override string XmlNamespace { get { return default(string); } set { } }
    }

    [System.FlagsAttribute]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum SoapOption
    {
        AlwaysIncludeTypes = 1,
        EmbedAll = 4,
        None = 0,
        Option1 = 8,
        Option2 = 16,
        XsdString = 2,
    }

    [System.AttributeUsageAttribute((System.AttributeTargets)(2048))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapParameterAttribute : System.Runtime.Remoting.Metadata.SoapAttribute
    {
        public SoapParameterAttribute() { }
    }

    [System.AttributeUsageAttribute((System.AttributeTargets)(1052))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapTypeAttribute : System.Runtime.Remoting.Metadata.SoapAttribute
    {
        public SoapTypeAttribute() { }
        public System.Runtime.Remoting.Metadata.SoapOption SoapOptions { get { return default(System.Runtime.Remoting.Metadata.SoapOption); } set { } }
        public override bool UseAttribute { get { return default(bool); } set { } }
        public string XmlElementName { get { return default(string); } set { } }
        public System.Runtime.Remoting.Metadata.XmlFieldOrderOption XmlFieldOrder { get { return default(System.Runtime.Remoting.Metadata.XmlFieldOrderOption); } set { } }
        public override string XmlNamespace { get { return default(string); } set { } }
        public string XmlTypeName { get { return default(string); } set { } }
        public string XmlTypeNamespace { get { return default(string); } set { } }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum XmlFieldOrderOption
    {
        All = 0,
        Choice = 2,
        Sequence = 1,
    }
} // end of System.Runtime.Remoting.Metadata
namespace System.Runtime.Remoting.Metadata.W3cXsd2001 {
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface ISoapXsd
    {
        string GetXsdType();
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapAnyUri : System.Runtime.Remoting.Metadata.W3cXsd2001.ISoapXsd
    {
        public SoapAnyUri() { }
        public SoapAnyUri(string value) { }
        public string Value { get { return default(string); } set { } }
        public static string XsdType { get { return default(string); } }
        public string GetXsdType() { return default(string); }
        public static System.Runtime.Remoting.Metadata.W3cXsd2001.SoapAnyUri Parse(string value) { return default(System.Runtime.Remoting.Metadata.W3cXsd2001.SoapAnyUri); }
        public override string ToString() { return default(string); }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapBase64Binary : System.Runtime.Remoting.Metadata.W3cXsd2001.ISoapXsd
    {
        public SoapBase64Binary() { }
        public SoapBase64Binary(byte[] value) { }
        public byte[] Value { get { return default(byte[]); } set { } }
        public static string XsdType { get { return default(string); } }
        public string GetXsdType() { return default(string); }
        public static System.Runtime.Remoting.Metadata.W3cXsd2001.SoapBase64Binary Parse(string value) { return default(System.Runtime.Remoting.Metadata.W3cXsd2001.SoapBase64Binary); }
        public override string ToString() { return default(string); }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapDate : System.Runtime.Remoting.Metadata.W3cXsd2001.ISoapXsd
    {
        public SoapDate() { }
        public SoapDate(System.DateTime value) { }
        public SoapDate(System.DateTime value, int sign) { }
        public int Sign { get { return default(int); } set { } }
        public System.DateTime Value { get { return default(System.DateTime); } set { } }
        public static string XsdType { get { return default(string); } }
        public string GetXsdType() { return default(string); }
        public static System.Runtime.Remoting.Metadata.W3cXsd2001.SoapDate Parse(string value) { return default(System.Runtime.Remoting.Metadata.W3cXsd2001.SoapDate); }
        public override string ToString() { return default(string); }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapDateTime
    {
        public SoapDateTime() { }
        public static string XsdType { get { return default(string); } }
        public static System.DateTime Parse(string value) { return default(System.DateTime); }
        public static string ToString(System.DateTime value) { return default(string); }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapDay : System.Runtime.Remoting.Metadata.W3cXsd2001.ISoapXsd
    {
        public SoapDay() { }
        public SoapDay(System.DateTime value) { }
        public System.DateTime Value { get { return default(System.DateTime); } set { } }
        public static string XsdType { get { return default(string); } }
        public string GetXsdType() { return default(string); }
        public static System.Runtime.Remoting.Metadata.W3cXsd2001.SoapDay Parse(string value) { return default(System.Runtime.Remoting.Metadata.W3cXsd2001.SoapDay); }
        public override string ToString() { return default(string); }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapDuration
    {
        public SoapDuration() { }
        public static string XsdType { get { return default(string); } }
        public static System.TimeSpan Parse(string value) { return default(System.TimeSpan); }
        public static string ToString(System.TimeSpan timeSpan) { return default(string); }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapEntities : System.Runtime.Remoting.Metadata.W3cXsd2001.ISoapXsd
    {
        public SoapEntities() { }
        public SoapEntities(string value) { }
        public string Value { get { return default(string); } set { } }
        public static string XsdType { get { return default(string); } }
        public string GetXsdType() { return default(string); }
        public static System.Runtime.Remoting.Metadata.W3cXsd2001.SoapEntities Parse(string value) { return default(System.Runtime.Remoting.Metadata.W3cXsd2001.SoapEntities); }
        public override string ToString() { return default(string); }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapEntity : System.Runtime.Remoting.Metadata.W3cXsd2001.ISoapXsd
    {
        public SoapEntity() { }
        public SoapEntity(string value) { }
        public string Value { get { return default(string); } set { } }
        public static string XsdType { get { return default(string); } }
        public string GetXsdType() { return default(string); }
        public static System.Runtime.Remoting.Metadata.W3cXsd2001.SoapEntity Parse(string value) { return default(System.Runtime.Remoting.Metadata.W3cXsd2001.SoapEntity); }
        public override string ToString() { return default(string); }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapHexBinary : System.Runtime.Remoting.Metadata.W3cXsd2001.ISoapXsd
    {
        public SoapHexBinary() { }
        public SoapHexBinary(byte[] value) { }
        public byte[] Value { get { return default(byte[]); } set { } }
        public static string XsdType { get { return default(string); } }
        public string GetXsdType() { return default(string); }
        public static System.Runtime.Remoting.Metadata.W3cXsd2001.SoapHexBinary Parse(string value) { return default(System.Runtime.Remoting.Metadata.W3cXsd2001.SoapHexBinary); }
        public override string ToString() { return default(string); }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapId : System.Runtime.Remoting.Metadata.W3cXsd2001.ISoapXsd
    {
        public SoapId() { }
        public SoapId(string value) { }
        public string Value { get { return default(string); } set { } }
        public static string XsdType { get { return default(string); } }
        public string GetXsdType() { return default(string); }
        public static System.Runtime.Remoting.Metadata.W3cXsd2001.SoapId Parse(string value) { return default(System.Runtime.Remoting.Metadata.W3cXsd2001.SoapId); }
        public override string ToString() { return default(string); }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapIdref : System.Runtime.Remoting.Metadata.W3cXsd2001.ISoapXsd
    {
        public SoapIdref() { }
        public SoapIdref(string value) { }
        public string Value { get { return default(string); } set { } }
        public static string XsdType { get { return default(string); } }
        public string GetXsdType() { return default(string); }
        public static System.Runtime.Remoting.Metadata.W3cXsd2001.SoapIdref Parse(string value) { return default(System.Runtime.Remoting.Metadata.W3cXsd2001.SoapIdref); }
        public override string ToString() { return default(string); }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapIdrefs : System.Runtime.Remoting.Metadata.W3cXsd2001.ISoapXsd
    {
        public SoapIdrefs() { }
        public SoapIdrefs(string value) { }
        public string Value { get { return default(string); } set { } }
        public static string XsdType { get { return default(string); } }
        public string GetXsdType() { return default(string); }
        public static System.Runtime.Remoting.Metadata.W3cXsd2001.SoapIdrefs Parse(string value) { return default(System.Runtime.Remoting.Metadata.W3cXsd2001.SoapIdrefs); }
        public override string ToString() { return default(string); }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapInteger : System.Runtime.Remoting.Metadata.W3cXsd2001.ISoapXsd
    {
        public SoapInteger() { }
        public SoapInteger(decimal value) { }
        public decimal Value { get { return default(decimal); } set { } }
        public static string XsdType { get { return default(string); } }
        public string GetXsdType() { return default(string); }
        public static System.Runtime.Remoting.Metadata.W3cXsd2001.SoapInteger Parse(string value) { return default(System.Runtime.Remoting.Metadata.W3cXsd2001.SoapInteger); }
        public override string ToString() { return default(string); }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapLanguage : System.Runtime.Remoting.Metadata.W3cXsd2001.ISoapXsd
    {
        public SoapLanguage() { }
        public SoapLanguage(string value) { }
        public string Value { get { return default(string); } set { } }
        public static string XsdType { get { return default(string); } }
        public string GetXsdType() { return default(string); }
        public static System.Runtime.Remoting.Metadata.W3cXsd2001.SoapLanguage Parse(string value) { return default(System.Runtime.Remoting.Metadata.W3cXsd2001.SoapLanguage); }
        public override string ToString() { return default(string); }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapMonth : System.Runtime.Remoting.Metadata.W3cXsd2001.ISoapXsd
    {
        public SoapMonth() { }
        public SoapMonth(System.DateTime value) { }
        public System.DateTime Value { get { return default(System.DateTime); } set { } }
        public static string XsdType { get { return default(string); } }
        public string GetXsdType() { return default(string); }
        public static System.Runtime.Remoting.Metadata.W3cXsd2001.SoapMonth Parse(string value) { return default(System.Runtime.Remoting.Metadata.W3cXsd2001.SoapMonth); }
        public override string ToString() { return default(string); }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapMonthDay : System.Runtime.Remoting.Metadata.W3cXsd2001.ISoapXsd
    {
        public SoapMonthDay() { }
        public SoapMonthDay(System.DateTime value) { }
        public System.DateTime Value { get { return default(System.DateTime); } set { } }
        public static string XsdType { get { return default(string); } }
        public string GetXsdType() { return default(string); }
        public static System.Runtime.Remoting.Metadata.W3cXsd2001.SoapMonthDay Parse(string value) { return default(System.Runtime.Remoting.Metadata.W3cXsd2001.SoapMonthDay); }
        public override string ToString() { return default(string); }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapName : System.Runtime.Remoting.Metadata.W3cXsd2001.ISoapXsd
    {
        public SoapName() { }
        public SoapName(string value) { }
        public string Value { get { return default(string); } set { } }
        public static string XsdType { get { return default(string); } }
        public string GetXsdType() { return default(string); }
        public static System.Runtime.Remoting.Metadata.W3cXsd2001.SoapName Parse(string value) { return default(System.Runtime.Remoting.Metadata.W3cXsd2001.SoapName); }
        public override string ToString() { return default(string); }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapNcName : System.Runtime.Remoting.Metadata.W3cXsd2001.ISoapXsd
    {
        public SoapNcName() { }
        public SoapNcName(string value) { }
        public string Value { get { return default(string); } set { } }
        public static string XsdType { get { return default(string); } }
        public string GetXsdType() { return default(string); }
        public static System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNcName Parse(string value) { return default(System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNcName); }
        public override string ToString() { return default(string); }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapNegativeInteger : System.Runtime.Remoting.Metadata.W3cXsd2001.ISoapXsd
    {
        public SoapNegativeInteger() { }
        public SoapNegativeInteger(decimal value) { }
        public decimal Value { get { return default(decimal); } set { } }
        public static string XsdType { get { return default(string); } }
        public string GetXsdType() { return default(string); }
        public static System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNegativeInteger Parse(string value) { return default(System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNegativeInteger); }
        public override string ToString() { return default(string); }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapNmtoken : System.Runtime.Remoting.Metadata.W3cXsd2001.ISoapXsd
    {
        public SoapNmtoken() { }
        public SoapNmtoken(string value) { }
        public string Value { get { return default(string); } set { } }
        public static string XsdType { get { return default(string); } }
        public string GetXsdType() { return default(string); }
        public static System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNmtoken Parse(string value) { return default(System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNmtoken); }
        public override string ToString() { return default(string); }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapNmtokens : System.Runtime.Remoting.Metadata.W3cXsd2001.ISoapXsd
    {
        public SoapNmtokens() { }
        public SoapNmtokens(string value) { }
        public string Value { get { return default(string); } set { } }
        public static string XsdType { get { return default(string); } }
        public string GetXsdType() { return default(string); }
        public static System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNmtokens Parse(string value) { return default(System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNmtokens); }
        public override string ToString() { return default(string); }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapNonNegativeInteger : System.Runtime.Remoting.Metadata.W3cXsd2001.ISoapXsd
    {
        public SoapNonNegativeInteger() { }
        public SoapNonNegativeInteger(decimal value) { }
        public decimal Value { get { return default(decimal); } set { } }
        public static string XsdType { get { return default(string); } }
        public string GetXsdType() { return default(string); }
        public static System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNonNegativeInteger Parse(string value) { return default(System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNonNegativeInteger); }
        public override string ToString() { return default(string); }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapNonPositiveInteger : System.Runtime.Remoting.Metadata.W3cXsd2001.ISoapXsd
    {
        public SoapNonPositiveInteger() { }
        public SoapNonPositiveInteger(decimal value) { }
        public decimal Value { get { return default(decimal); } set { } }
        public static string XsdType { get { return default(string); } }
        public string GetXsdType() { return default(string); }
        public static System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNonPositiveInteger Parse(string value) { return default(System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNonPositiveInteger); }
        public override string ToString() { return default(string); }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapNormalizedString : System.Runtime.Remoting.Metadata.W3cXsd2001.ISoapXsd
    {
        public SoapNormalizedString() { }
        public SoapNormalizedString(string value) { }
        public string Value { get { return default(string); } set { } }
        public static string XsdType { get { return default(string); } }
        public string GetXsdType() { return default(string); }
        public static System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNormalizedString Parse(string value) { return default(System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNormalizedString); }
        public override string ToString() { return default(string); }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapNotation : System.Runtime.Remoting.Metadata.W3cXsd2001.ISoapXsd
    {
        public SoapNotation() { }
        public SoapNotation(string value) { }
        public string Value { get { return default(string); } set { } }
        public static string XsdType { get { return default(string); } }
        public string GetXsdType() { return default(string); }
        public static System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNotation Parse(string value) { return default(System.Runtime.Remoting.Metadata.W3cXsd2001.SoapNotation); }
        public override string ToString() { return default(string); }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapPositiveInteger : System.Runtime.Remoting.Metadata.W3cXsd2001.ISoapXsd
    {
        public SoapPositiveInteger() { }
        public SoapPositiveInteger(decimal value) { }
        public decimal Value { get { return default(decimal); } set { } }
        public static string XsdType { get { return default(string); } }
        public string GetXsdType() { return default(string); }
        public static System.Runtime.Remoting.Metadata.W3cXsd2001.SoapPositiveInteger Parse(string value) { return default(System.Runtime.Remoting.Metadata.W3cXsd2001.SoapPositiveInteger); }
        public override string ToString() { return default(string); }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapQName : System.Runtime.Remoting.Metadata.W3cXsd2001.ISoapXsd
    {
        public SoapQName() { }
        public SoapQName(string value) { }
        public SoapQName(string key, string name) { }
        public SoapQName(string key, string name, string namespaceValue) { }
        public string Key { get { return default(string); } set { } }
        public string Name { get { return default(string); } set { } }
        public string Namespace { get { return default(string); } set { } }
        public static string XsdType { get { return default(string); } }
        public string GetXsdType() { return default(string); }
        public static System.Runtime.Remoting.Metadata.W3cXsd2001.SoapQName Parse(string value) { return default(System.Runtime.Remoting.Metadata.W3cXsd2001.SoapQName); }
        public override string ToString() { return default(string); }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapTime : System.Runtime.Remoting.Metadata.W3cXsd2001.ISoapXsd
    {
        public SoapTime() { }
        public SoapTime(System.DateTime value) { }
        public System.DateTime Value { get { return default(System.DateTime); } set { } }
        public static string XsdType { get { return default(string); } }
        public string GetXsdType() { return default(string); }
        public static System.Runtime.Remoting.Metadata.W3cXsd2001.SoapTime Parse(string value) { return default(System.Runtime.Remoting.Metadata.W3cXsd2001.SoapTime); }
        public override string ToString() { return default(string); }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapToken : System.Runtime.Remoting.Metadata.W3cXsd2001.ISoapXsd
    {
        public SoapToken() { }
        public SoapToken(string value) { }
        public string Value { get { return default(string); } set { } }
        public static string XsdType { get { return default(string); } }
        public string GetXsdType() { return default(string); }
        public static System.Runtime.Remoting.Metadata.W3cXsd2001.SoapToken Parse(string value) { return default(System.Runtime.Remoting.Metadata.W3cXsd2001.SoapToken); }
        public override string ToString() { return default(string); }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapYear : System.Runtime.Remoting.Metadata.W3cXsd2001.ISoapXsd
    {
        public SoapYear() { }
        public SoapYear(System.DateTime value) { }
        public SoapYear(System.DateTime value, int sign) { }
        public int Sign { get { return default(int); } set { } }
        public System.DateTime Value { get { return default(System.DateTime); } set { } }
        public static string XsdType { get { return default(string); } }
        public string GetXsdType() { return default(string); }
        public static System.Runtime.Remoting.Metadata.W3cXsd2001.SoapYear Parse(string value) { return default(System.Runtime.Remoting.Metadata.W3cXsd2001.SoapYear); }
        public override string ToString() { return default(string); }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SoapYearMonth : System.Runtime.Remoting.Metadata.W3cXsd2001.ISoapXsd
    {
        public SoapYearMonth() { }
        public SoapYearMonth(System.DateTime value) { }
        public SoapYearMonth(System.DateTime value, int sign) { }
        public int Sign { get { return default(int); } set { } }
        public System.DateTime Value { get { return default(System.DateTime); } set { } }
        public static string XsdType { get { return default(string); } }
        public string GetXsdType() { return default(string); }
        public static System.Runtime.Remoting.Metadata.W3cXsd2001.SoapYearMonth Parse(string value) { return default(System.Runtime.Remoting.Metadata.W3cXsd2001.SoapYearMonth); }
        public override string ToString() { return default(string); }
    }
} // end of System.Runtime.Remoting.Metadata.W3cXsd2001
namespace System.Runtime.Remoting.Proxies {
    [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ProxyAttribute : System.Attribute, System.Runtime.Remoting.Contexts.IContextAttribute
    {
        public ProxyAttribute() { }
        public virtual System.MarshalByRefObject CreateInstance(System.Type serverType) { return default(System.MarshalByRefObject); }
        public virtual System.Runtime.Remoting.Proxies.RealProxy CreateProxy(System.Runtime.Remoting.ObjRef objRef, System.Type serverType, object serverObject, System.Runtime.Remoting.Contexts.Context serverContext) { return default(System.Runtime.Remoting.Proxies.RealProxy); }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public void GetPropertiesForNewContext(System.Runtime.Remoting.Activation.IConstructionCallMessage msg) { }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public bool IsContextOK(System.Runtime.Remoting.Contexts.Context ctx, System.Runtime.Remoting.Activation.IConstructionCallMessage msg) { return default(bool); }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class RealProxy
    {
        protected RealProxy() { }
        protected RealProxy(System.Type classToProxy) { }
        protected RealProxy(System.Type classToProxy, System.IntPtr stub, object stubData) { }
        protected void AttachServer(System.MarshalByRefObject s) { }
        public virtual System.Runtime.Remoting.ObjRef CreateObjRef(System.Type requestedType) { return default(System.Runtime.Remoting.ObjRef); }
        protected System.MarshalByRefObject DetachServer() { return default(System.MarshalByRefObject); }
        public virtual System.IntPtr GetCOMIUnknown(bool fIsMarshalled) { return default(System.IntPtr); }
        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public System.Type GetProxiedType() { return default(System.Type); }
        public static object GetStubData(System.Runtime.Remoting.Proxies.RealProxy rp) { return default(object); }
        public virtual object GetTransparentProxy() { return default(object); }
        protected System.MarshalByRefObject GetUnwrappedServer() { return default(System.MarshalByRefObject); }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public System.Runtime.Remoting.Activation.IConstructionReturnMessage InitializeServerObject(System.Runtime.Remoting.Activation.IConstructionCallMessage ctorMsg) { return default(System.Runtime.Remoting.Activation.IConstructionReturnMessage); }
        public abstract System.Runtime.Remoting.Messaging.IMessage Invoke(System.Runtime.Remoting.Messaging.IMessage msg);
        public virtual void SetCOMIUnknown(System.IntPtr i) { }
        public static void SetStubData(System.Runtime.Remoting.Proxies.RealProxy rp, object stubData) { }
        public virtual System.IntPtr SupportsInterface(ref System.Guid iid) { return default(System.IntPtr); }
    }
} // end of System.Runtime.Remoting.Proxies
namespace System.Runtime.Remoting.Services {
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class EnterpriseServicesHelper
    {
        public EnterpriseServicesHelper() { }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public static System.Runtime.Remoting.Activation.IConstructionReturnMessage CreateConstructionReturnMessage(System.Runtime.Remoting.Activation.IConstructionCallMessage ctorMsg, System.MarshalByRefObject retObj) { return default(System.Runtime.Remoting.Activation.IConstructionReturnMessage); }
        public static void SwitchWrappers(System.Runtime.Remoting.Proxies.RealProxy oldcp, System.Runtime.Remoting.Proxies.RealProxy newcp) { }
        public static object WrapIUnknownWithComObject(System.IntPtr punk) { return default(object); }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface ITrackingHandler
    {
        void DisconnectedObject(object obj);
        void MarshaledObject(object obj, System.Runtime.Remoting.ObjRef or);
        void UnmarshaledObject(object obj, System.Runtime.Remoting.ObjRef or);
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class TrackingServices
    {
        public TrackingServices() { }
        public static System.Runtime.Remoting.Services.ITrackingHandler[] RegisteredHandlers { get { return default(System.Runtime.Remoting.Services.ITrackingHandler[]); } }
        public static void RegisterTrackingHandler(System.Runtime.Remoting.Services.ITrackingHandler handler) { }
        public static void UnregisterTrackingHandler(System.Runtime.Remoting.Services.ITrackingHandler handler) { }
    }
} // end of System.Runtime.Remoting.Services
namespace System.Runtime.Serialization {
    [System.CLSCompliantAttribute(false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class Formatter : System.Runtime.Serialization.IFormatter
    {
        protected System.Runtime.Serialization.ObjectIDGenerator m_idGenerator;
        protected System.Collections.Queue m_objectQueue;
        protected Formatter() { }
        public abstract System.Runtime.Serialization.SerializationBinder Binder { get; set; }
        public abstract System.Runtime.Serialization.StreamingContext Context { get; set; }
        public abstract System.Runtime.Serialization.ISurrogateSelector SurrogateSelector { get; set; }
        public abstract object Deserialize(System.IO.Stream serializationStream);
        protected virtual object GetNext(out long objID) { objID = default(long); return default(object); }
        protected virtual long Schedule(object obj) { return default(long); }
        public abstract void Serialize(System.IO.Stream serializationStream, object graph);
        protected abstract void WriteArray(object obj, string name, System.Type memberType);
        protected abstract void WriteBoolean(bool val, string name);
        protected abstract void WriteByte(byte val, string name);
        protected abstract void WriteChar(char val, string name);
        protected abstract void WriteDateTime(System.DateTime val, string name);
        protected abstract void WriteDecimal(decimal val, string name);
        protected abstract void WriteDouble(double val, string name);
        protected abstract void WriteInt16(short val, string name);
        protected abstract void WriteInt32(int val, string name);
        protected abstract void WriteInt64(long val, string name);
        protected virtual void WriteMember(string memberName, object data) { }
        protected abstract void WriteObjectRef(object obj, string name, System.Type memberType);
        [System.CLSCompliantAttribute(false)]
        protected abstract void WriteSByte(sbyte val, string name);
        protected abstract void WriteSingle(float val, string name);
        protected abstract void WriteTimeSpan(System.TimeSpan val, string name);
        [System.CLSCompliantAttribute(false)]
        protected abstract void WriteUInt16(ushort val, string name);
        [System.CLSCompliantAttribute(false)]
        protected abstract void WriteUInt32(uint val, string name);
        [System.CLSCompliantAttribute(false)]
        protected abstract void WriteUInt64(ulong val, string name);
        protected abstract void WriteValueType(object obj, string name, System.Type memberType);
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class FormatterConverter : System.Runtime.Serialization.IFormatterConverter
    {
        public FormatterConverter() { }
        public object Convert(object value, System.Type type) { return default(object); }
        public object Convert(object value, System.TypeCode typeCode) { return default(object); }
        public bool ToBoolean(object value) { return default(bool); }
        public byte ToByte(object value) { return default(byte); }
        public char ToChar(object value) { return default(char); }
        public System.DateTime ToDateTime(object value) { return default(System.DateTime); }
        public decimal ToDecimal(object value) { return default(decimal); }
        public double ToDouble(object value) { return default(double); }
        public short ToInt16(object value) { return default(short); }
        public int ToInt32(object value) { return default(int); }
        public long ToInt64(object value) { return default(long); }
        [System.CLSCompliantAttribute(false)]
        public sbyte ToSByte(object value) { return default(sbyte); }
        public float ToSingle(object value) { return default(float); }
        public string ToString(object value) { return default(string); }
        [System.CLSCompliantAttribute(false)]
        public ushort ToUInt16(object value) { return default(ushort); }
        [System.CLSCompliantAttribute(false)]
        public uint ToUInt32(object value) { return default(uint); }
        [System.CLSCompliantAttribute(false)]
        public ulong ToUInt64(object value) { return default(ulong); }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public static partial class FormatterServices
    {
        public static void CheckTypeSecurity(System.Type t, System.Runtime.Serialization.Formatters.TypeFilterLevel securityLevel) { }
        [System.Security.SecurityCriticalAttribute]
        public static object[] GetObjectData(object obj, System.Reflection.MemberInfo[] members) { return default(object[]); }
        [System.Security.SecurityCriticalAttribute]
        public static object GetSafeUninitializedObject(System.Type type) { return default(object); }
        [System.Security.SecurityCriticalAttribute]
        public static System.Reflection.MemberInfo[] GetSerializableMembers(System.Type type) { return default(System.Reflection.MemberInfo[]); }
        [System.Security.SecurityCriticalAttribute]
        public static System.Reflection.MemberInfo[] GetSerializableMembers(System.Type type, System.Runtime.Serialization.StreamingContext context) { return default(System.Reflection.MemberInfo[]); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        [System.Security.SecurityCriticalAttribute]
        public static System.Runtime.Serialization.ISerializationSurrogate GetSurrogateForCyclicalReference(System.Runtime.Serialization.ISerializationSurrogate innerSurrogate) { return default(System.Runtime.Serialization.ISerializationSurrogate); }
        [System.Security.SecurityCriticalAttribute]
        public static System.Type GetTypeFromAssembly(System.Reflection.Assembly assem, string name) { return default(System.Type); }
        [System.Security.SecurityCriticalAttribute]
        public static object GetUninitializedObject(System.Type type) { return default(object); }
        [System.Security.SecurityCriticalAttribute]
        public static object PopulateObjectMembers(object obj, System.Reflection.MemberInfo[] members, object[] data) { return default(object); }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IFormatter
    {
        System.Runtime.Serialization.SerializationBinder Binder { get; set; }
        System.Runtime.Serialization.StreamingContext Context { get; set; }
        System.Runtime.Serialization.ISurrogateSelector SurrogateSelector { get; set; }
        object Deserialize(System.IO.Stream serializationStream);
        void Serialize(System.IO.Stream serializationStream, object graph);
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface ISerializationSurrogate
    {
        [System.Security.SecurityCriticalAttribute]
        void GetObjectData(object obj, System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
        [System.Security.SecurityCriticalAttribute]
        object SetObjectData(object obj, System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Runtime.Serialization.ISurrogateSelector selector);
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface ISurrogateSelector
    {
        [System.Security.SecurityCriticalAttribute]
        void ChainSelector(System.Runtime.Serialization.ISurrogateSelector selector);
        [System.Security.SecurityCriticalAttribute]
        System.Runtime.Serialization.ISurrogateSelector GetNextSelector();
        [System.Security.SecurityCriticalAttribute]
        System.Runtime.Serialization.ISerializationSurrogate GetSurrogate(System.Type type, System.Runtime.Serialization.StreamingContext context, out System.Runtime.Serialization.ISurrogateSelector selector);
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ObjectIDGenerator
    {
        public ObjectIDGenerator() { }
        public virtual long GetId(object obj, out bool firstTime) { firstTime = default(bool); return default(long); }
        public virtual long HasId(object obj, out bool firstTime) { firstTime = default(bool); return default(long); }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ObjectManager
    {
        [System.Security.SecuritySafeCriticalAttribute]
        public ObjectManager(System.Runtime.Serialization.ISurrogateSelector selector, System.Runtime.Serialization.StreamingContext context) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public virtual void DoFixups() { }
        public virtual object GetObject(long objectID) { return default(object); }
        public virtual void RaiseDeserializationEvent() { }
        public void RaiseOnDeserializingEvent(object obj) { }
        public virtual void RecordArrayElementFixup(long arrayToBeFixed, int index, long objectRequired) { }
        public virtual void RecordArrayElementFixup(long arrayToBeFixed, int[] indices, long objectRequired) { }
        public virtual void RecordDelayedFixup(long objectToBeFixed, string memberName, long objectRequired) { }
        public virtual void RecordFixup(long objectToBeFixed, System.Reflection.MemberInfo member, long objectRequired) { }
        [System.Security.SecurityCriticalAttribute]
        public virtual void RegisterObject(object obj, long objectID) { }
        [System.Security.SecurityCriticalAttribute]
        public void RegisterObject(object obj, long objectID, System.Runtime.Serialization.SerializationInfo info) { }
        [System.Security.SecurityCriticalAttribute]
        public void RegisterObject(object obj, long objectID, System.Runtime.Serialization.SerializationInfo info, long idOfContainingObj, System.Reflection.MemberInfo member) { }
        [System.Security.SecurityCriticalAttribute]
        public void RegisterObject(object obj, long objectID, System.Runtime.Serialization.SerializationInfo info, long idOfContainingObj, System.Reflection.MemberInfo member, int[] arrayIndex) { }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class SerializationBinder
    {
        protected SerializationBinder() { }
        public virtual void BindToName(System.Type serializedType, out string assemblyName, out string typeName) { assemblyName = default(string); typeName = default(string); }
        public abstract System.Type BindToType(string assemblyName, string typeName);
    }

    public sealed partial class SerializationObjectManager
    {
        public SerializationObjectManager(System.Runtime.Serialization.StreamingContext context) { }
        public void RaiseOnSerializedEvent() { }
        [System.Security.SecurityCriticalAttribute]
        public void RegisterObject(object obj) { }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SurrogateSelector : System.Runtime.Serialization.ISurrogateSelector
    {
        public SurrogateSelector() { }
        public virtual void AddSurrogate(System.Type type, System.Runtime.Serialization.StreamingContext context, System.Runtime.Serialization.ISerializationSurrogate surrogate) { }
        [System.Security.SecurityCriticalAttribute]
        public virtual void ChainSelector(System.Runtime.Serialization.ISurrogateSelector selector) { }
        [System.Security.SecurityCriticalAttribute]
        public virtual System.Runtime.Serialization.ISurrogateSelector GetNextSelector() { return default(System.Runtime.Serialization.ISurrogateSelector); }
        [System.Security.SecurityCriticalAttribute]
        public virtual System.Runtime.Serialization.ISerializationSurrogate GetSurrogate(System.Type type, System.Runtime.Serialization.StreamingContext context, out System.Runtime.Serialization.ISurrogateSelector selector) { selector = default(System.Runtime.Serialization.ISurrogateSelector); return default(System.Runtime.Serialization.ISerializationSurrogate); }
        public virtual void RemoveSurrogate(System.Type type, System.Runtime.Serialization.StreamingContext context) { }
    }
} // end of System.Runtime.Serialization
namespace System.Runtime.Serialization.Formatters {
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum FormatterAssemblyStyle
    {
        Full = 1,
        Simple = 0,
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum FormatterTypeStyle
    {
        TypesAlways = 1,
        TypesWhenNeeded = 0,
        XsdString = 2,
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IFieldInfo
    {
        string[] FieldNames { [System.Security.SecurityCriticalAttribute]get; [System.Security.SecurityCriticalAttribute]set; }
        System.Type[] FieldTypes { [System.Security.SecurityCriticalAttribute]get; [System.Security.SecurityCriticalAttribute]set; }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Security.SecurityCriticalAttribute]
    public sealed partial class InternalRM
    {
        public InternalRM() { }
        [System.Diagnostics.ConditionalAttribute("_LOGGING")]
        public static void InfoSoap(params object[] messages) { }
        public static bool SoapCheckEnabled() { return default(bool); }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Security.SecurityCriticalAttribute]
    public sealed partial class InternalST
    {
        internal InternalST() { }
        [System.Diagnostics.ConditionalAttribute("_LOGGING")]
        public static void InfoSoap(params object[] messages) { }
        public static System.Reflection.Assembly LoadAssemblyFromString(string assemblyString) { return default(System.Reflection.Assembly); }
        public static void SerializationSetValue(System.Reflection.FieldInfo fi, object target, object value) { }
        [System.Diagnostics.ConditionalAttribute("SER_LOGGING")]
        public static void Soap(params object[] messages) { }
        [System.Diagnostics.ConditionalAttribute("_DEBUG")]
        public static void SoapAssert(bool condition, string message) { }
        public static bool SoapCheckEnabled() { return default(bool); }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface ISoapMessage
    {
        System.Runtime.Remoting.Messaging.Header[] Headers { get; set; }
        string MethodName { get; set; }
        string[] ParamNames { get; set; }
        System.Type[] ParamTypes { get; set; }
        object[] ParamValues { get; set; }
        string XmlNameSpace { get; set; }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.Remoting.Metadata.SoapTypeAttribute(Embedded = true)]
    public sealed partial class ServerFault
    {
        public ServerFault(string exceptionType, string message, string stackTrace) { }
        public string ExceptionMessage { get { return default(string); } set { } }
        public string ExceptionType { get { return default(string); } set { } }
        public string StackTrace { get { return default(string); } set { } }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.Remoting.Metadata.SoapTypeAttribute(Embedded = true)]
    public sealed partial class SoapFault : System.Runtime.Serialization.ISerializable
    {
        public SoapFault() { }
        public SoapFault(string faultCode, string faultString, string faultActor, System.Runtime.Serialization.Formatters.ServerFault serverFault) { }
        public object Detail { get { return default(object); } set { } }
        public string FaultActor { get { return default(string); } set { } }
        public string FaultCode { get { return default(string); } set { } }
        public string FaultString { get { return default(string); } set { } }
        [System.Security.SecurityCriticalAttribute]
        public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SoapMessage : System.Runtime.Serialization.Formatters.ISoapMessage
    {
        public SoapMessage() { }
        public System.Runtime.Remoting.Messaging.Header[] Headers { get { return default(System.Runtime.Remoting.Messaging.Header[]); } set { } }
        public string MethodName { get { return default(string); } set { } }
        public string[] ParamNames { get { return default(string[]); } set { } }
        public System.Type[] ParamTypes { get { return default(System.Type[]); } set { } }
        public object[] ParamValues { get { return default(object[]); } set { } }
        public string XmlNameSpace { get { return default(string); } set { } }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum TypeFilterLevel
    {
        Full = 3,
        Low = 2,
    }
} // end of System.Runtime.Serialization.Formatters
namespace System.Runtime.Serialization.Formatters.Binary {
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class BinaryFormatter : System.Runtime.Serialization.IFormatter
    {
        public BinaryFormatter() { }
        public BinaryFormatter(System.Runtime.Serialization.ISurrogateSelector selector, System.Runtime.Serialization.StreamingContext context) { }
        public System.Runtime.Serialization.Formatters.FormatterAssemblyStyle AssemblyFormat { get { return default(System.Runtime.Serialization.Formatters.FormatterAssemblyStyle); } set { } }
        public System.Runtime.Serialization.SerializationBinder Binder { get { return default(System.Runtime.Serialization.SerializationBinder); } set { } }
        public System.Runtime.Serialization.StreamingContext Context { get { return default(System.Runtime.Serialization.StreamingContext); } set { } }
        public System.Runtime.Serialization.Formatters.TypeFilterLevel FilterLevel { get { return default(System.Runtime.Serialization.Formatters.TypeFilterLevel); } set { } }
        public System.Runtime.Serialization.ISurrogateSelector SurrogateSelector { get { return default(System.Runtime.Serialization.ISurrogateSelector); } set { } }
        public System.Runtime.Serialization.Formatters.FormatterTypeStyle TypeFormat { get { return default(System.Runtime.Serialization.Formatters.FormatterTypeStyle); } set { } }
        public object Deserialize(System.IO.Stream serializationStream) { return default(object); }
        [System.Security.SecuritySafeCriticalAttribute]
        public object Deserialize(System.IO.Stream serializationStream, System.Runtime.Remoting.Messaging.HeaderHandler handler) { return default(object); }
        [System.Security.SecuritySafeCriticalAttribute]
        public object DeserializeMethodResponse(System.IO.Stream serializationStream, System.Runtime.Remoting.Messaging.HeaderHandler handler, System.Runtime.Remoting.Messaging.IMethodCallMessage methodCallMessage) { return default(object); }
        public void Serialize(System.IO.Stream serializationStream, object graph) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public void Serialize(System.IO.Stream serializationStream, object graph, System.Runtime.Remoting.Messaging.Header[] headers) { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        [System.Security.SecurityCriticalAttribute]
        public object UnsafeDeserialize(System.IO.Stream serializationStream, System.Runtime.Remoting.Messaging.HeaderHandler handler) { return default(object); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        [System.Security.SecurityCriticalAttribute]
        public object UnsafeDeserializeMethodResponse(System.IO.Stream serializationStream, System.Runtime.Remoting.Messaging.HeaderHandler handler, System.Runtime.Remoting.Messaging.IMethodCallMessage methodCallMessage) { return default(object); }
    }
} // end of System.Runtime.Serialization.Formatters.Binary
