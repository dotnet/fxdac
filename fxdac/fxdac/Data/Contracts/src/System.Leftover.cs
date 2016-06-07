[assembly:System.CLSCompliant(true)]
namespace Mono {
  public static partial class Runtime {
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]public static string GetDisplayName() { return default(string); }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]public static bool SetGCAllowSynchronousMajor(bool flag) { return default(bool); }
  }

} // end of Mono
namespace System {
  public partial struct ArgIterator {
    public ArgIterator(System.RuntimeArgumentHandle arglist) { throw new System.NotImplementedException(); }
    [System.CLSCompliantAttribute(false)]
    public unsafe ArgIterator(System.RuntimeArgumentHandle arglist, void* ptr) { throw new System.NotImplementedException(); }
    public void End() { }
    public override bool Equals(object o) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    [System.CLSCompliantAttribute(false)]
    public System.TypedReference GetNextArg() { return default(System.TypedReference); }
    [System.CLSCompliantAttribute(false)]
    public System.TypedReference GetNextArg(System.RuntimeTypeHandle rth) { return default(System.TypedReference); }
    public System.RuntimeTypeHandle GetNextArgType() { return default(System.RuntimeTypeHandle); }
    public int GetRemainingCount() { return default(int); }
  }

  public static partial class AppContext {
    public static string BaseDirectory { get { return default(string); } }
    public static string TargetFrameworkName { get { return default(string); } }
    public static object GetData(string name) { return default(object); }
    public static void SetSwitch(string switchName, bool isEnabled) { }
    public static bool TryGetSwitch(string switchName, out bool isEnabled) { isEnabled = default(bool); return default(bool); }
  }

  public static partial class StringNormalizationExtensions {
    public static bool IsNormalized(this string value) { return default(bool); }
    [System.Security.SecurityCriticalAttribute]
    public static bool IsNormalized(this string value, System.Text.NormalizationForm normalizationForm) { return default(bool); }
    public static string Normalize(this string value) { return default(string); }
    [System.Security.SecurityCriticalAttribute]
    public static string Normalize(this string value, System.Text.NormalizationForm normalizationForm) { return default(string); }
  }

  [System.CLSCompliantAttribute(false)]
  [System.Security.SecurityCriticalAttribute]
  public static partial class WindowsRuntimeSystemExtensions {
    public static Windows.Foundation.IAsyncAction AsAsyncAction(this System.Threading.Tasks.Task source) { return default(Windows.Foundation.IAsyncAction); }
    public static Windows.Foundation.IAsyncOperation<TResult> AsAsyncOperation<TResult>(this System.Threading.Tasks.Task<TResult> source) { return default(Windows.Foundation.IAsyncOperation<TResult>); }
    public static System.Threading.Tasks.Task AsTask(this Windows.Foundation.IAsyncAction source) { return default(System.Threading.Tasks.Task); }
    public static System.Threading.Tasks.Task AsTask(this Windows.Foundation.IAsyncAction source, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task); }
    public static System.Threading.Tasks.Task AsTask<TProgress>(this Windows.Foundation.IAsyncActionWithProgress<TProgress> source) { return default(System.Threading.Tasks.Task); }
    public static System.Threading.Tasks.Task AsTask<TProgress>(this Windows.Foundation.IAsyncActionWithProgress<TProgress> source, System.IProgress<TProgress> progress) { return default(System.Threading.Tasks.Task); }
    public static System.Threading.Tasks.Task AsTask<TProgress>(this Windows.Foundation.IAsyncActionWithProgress<TProgress> source, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task); }
    public static System.Threading.Tasks.Task AsTask<TProgress>(this Windows.Foundation.IAsyncActionWithProgress<TProgress> source, System.Threading.CancellationToken cancellationToken, System.IProgress<TProgress> progress) { return default(System.Threading.Tasks.Task); }
    public static System.Threading.Tasks.Task<TResult> AsTask<TResult>(this Windows.Foundation.IAsyncOperation<TResult> source) { return default(System.Threading.Tasks.Task<TResult>); }
    public static System.Threading.Tasks.Task<TResult> AsTask<TResult>(this Windows.Foundation.IAsyncOperation<TResult> source, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<TResult>); }
    public static System.Threading.Tasks.Task<TResult> AsTask<TResult, TProgress>(this Windows.Foundation.IAsyncOperationWithProgress<TResult, TProgress> source) { return default(System.Threading.Tasks.Task<TResult>); }
    public static System.Threading.Tasks.Task<TResult> AsTask<TResult, TProgress>(this Windows.Foundation.IAsyncOperationWithProgress<TResult, TProgress> source, System.IProgress<TProgress> progress) { return default(System.Threading.Tasks.Task<TResult>); }
    public static System.Threading.Tasks.Task<TResult> AsTask<TResult, TProgress>(this Windows.Foundation.IAsyncOperationWithProgress<TResult, TProgress> source, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<TResult>); }
    public static System.Threading.Tasks.Task<TResult> AsTask<TResult, TProgress>(this Windows.Foundation.IAsyncOperationWithProgress<TResult, TProgress> source, System.Threading.CancellationToken cancellationToken, System.IProgress<TProgress> progress) { return default(System.Threading.Tasks.Task<TResult>); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public static System.Runtime.CompilerServices.TaskAwaiter GetAwaiter(this Windows.Foundation.IAsyncAction source) { return default(System.Runtime.CompilerServices.TaskAwaiter); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public static System.Runtime.CompilerServices.TaskAwaiter GetAwaiter<TProgress>(this Windows.Foundation.IAsyncActionWithProgress<TProgress> source) { return default(System.Runtime.CompilerServices.TaskAwaiter); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public static System.Runtime.CompilerServices.TaskAwaiter<TResult> GetAwaiter<TResult>(this Windows.Foundation.IAsyncOperation<TResult> source) { return default(System.Runtime.CompilerServices.TaskAwaiter<TResult>); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public static System.Runtime.CompilerServices.TaskAwaiter<TResult> GetAwaiter<TResult, TProgress>(this Windows.Foundation.IAsyncOperationWithProgress<TResult, TProgress> source) { return default(System.Runtime.CompilerServices.TaskAwaiter<TResult>); }
  }

} // end of System
namespace System.Runtime.InteropServices {
  [System.CLSCompliantAttribute(false)]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("17156360-2F1A-384A-BC52-FDE93C215C5B")]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(0))]
  public partial interface _Assembly {
    string CodeBase { get; }
    System.Reflection.MethodInfo EntryPoint { get; }
    string EscapedCodeBase { get; }
    string FullName { get; }
    string Location { get; }
    event System.Reflection.ModuleResolveEventHandler ModuleResolve;
    object CreateInstance(string typeName);
    object CreateInstance(string typeName, bool ignoreCase);
    object CreateInstance(string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes);
    bool Equals(object other);
    object[] GetCustomAttributes(bool inherit);
    object[] GetCustomAttributes(System.Type attributeType, bool inherit);
    System.Type[] GetExportedTypes();
    System.IO.FileStream GetFile(string name);
    System.IO.FileStream[] GetFiles();
    System.IO.FileStream[] GetFiles(bool getResourceModules);
    int GetHashCode();
    System.Reflection.Module[] GetLoadedModules();
    System.Reflection.Module[] GetLoadedModules(bool getResourceModules);
    System.Reflection.ManifestResourceInfo GetManifestResourceInfo(string resourceName);
    string[] GetManifestResourceNames();
    System.IO.Stream GetManifestResourceStream(string name);
    System.IO.Stream GetManifestResourceStream(System.Type type, string name);
    System.Reflection.Module GetModule(string name);
    System.Reflection.Module[] GetModules();
    System.Reflection.Module[] GetModules(bool getResourceModules);
    System.Reflection.AssemblyName GetName();
    System.Reflection.AssemblyName GetName(bool copiedName);
    void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
    System.Reflection.AssemblyName[] GetReferencedAssemblies();
    System.Reflection.Assembly GetSatelliteAssembly(System.Globalization.CultureInfo culture);
    System.Reflection.Assembly GetSatelliteAssembly(System.Globalization.CultureInfo culture, System.Version version);
    System.Type GetType();
    System.Type GetType(string name);
    System.Type GetType(string name, bool throwOnError);
    System.Type GetType(string name, bool throwOnError, bool ignoreCase);
    System.Type[] GetTypes();
    bool IsDefined(System.Type attributeType, bool inherit);
    System.Reflection.Module LoadModule(string moduleName, byte[] rawModule);
    System.Reflection.Module LoadModule(string moduleName, byte[] rawModule, byte[] rawSymbolStore);
    string ToString();
  }

  [System.CLSCompliantAttribute(false)]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("B42B6AAC-317E-34D5-9FA9-093BB4160C50")]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
  public partial interface _AssemblyName {
    void GetIDsOfNames(ref System.Guid riid, System.IntPtr rgszNames, uint cNames, uint lcid, System.IntPtr rgDispId);
    void GetTypeInfo(uint iTInfo, uint lcid, System.IntPtr ppTInfo);
    void GetTypeInfoCount(out uint pcTInfo);
    void Invoke(uint dispIdMember, ref System.Guid riid, uint lcid, short wFlags, System.IntPtr pDispParams, System.IntPtr pVarResult, System.IntPtr pExcepInfo, System.IntPtr puArgErr);
  }

  [System.CLSCompliantAttribute(false)]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("E9A19478-9646-3679-9B10-8411AE1FD57D")]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
  public partial interface _ConstructorInfo {
    System.Reflection.MethodAttributes Attributes { get; }
    System.Reflection.CallingConventions CallingConvention { get; }
    System.Type DeclaringType { get; }
    bool IsAbstract { get; }
    bool IsAssembly { get; }
    bool IsConstructor { get; }
    bool IsFamily { get; }
    bool IsFamilyAndAssembly { get; }
    bool IsFamilyOrAssembly { get; }
    bool IsFinal { get; }
    bool IsHideBySig { get; }
    bool IsPrivate { get; }
    bool IsPublic { get; }
    bool IsSpecialName { get; }
    bool IsStatic { get; }
    bool IsVirtual { get; }
    System.Reflection.MemberTypes MemberType { get; }
    System.RuntimeMethodHandle MethodHandle { get; }
    string Name { get; }
    System.Type ReflectedType { get; }
    bool Equals(object other);
    object[] GetCustomAttributes(bool inherit);
    object[] GetCustomAttributes(System.Type attributeType, bool inherit);
    int GetHashCode();
    void GetIDsOfNames(ref System.Guid riid, System.IntPtr rgszNames, uint cNames, uint lcid, System.IntPtr rgDispId);
    System.Reflection.MethodImplAttributes GetMethodImplementationFlags();
    System.Reflection.ParameterInfo[] GetParameters();
    System.Type GetType();
    void GetTypeInfo(uint iTInfo, uint lcid, System.IntPtr ppTInfo);
    void GetTypeInfoCount(out uint pcTInfo);
    void Invoke(uint dispIdMember, ref System.Guid riid, uint lcid, short wFlags, System.IntPtr pDispParams, System.IntPtr pVarResult, System.IntPtr pExcepInfo, System.IntPtr puArgErr);
    object Invoke_2(object obj, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object[] parameters, System.Globalization.CultureInfo culture);
    object Invoke_3(object obj, object[] parameters);
    object Invoke_4(System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object[] parameters, System.Globalization.CultureInfo culture);
    object Invoke_5(object[] parameters);
    bool IsDefined(System.Type attributeType, bool inherit);
    string ToString();
  }

  [System.CLSCompliantAttribute(false)]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("9DE59C64-D889-35A1-B897-587D74469E5B")]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
  public partial interface _EventInfo {
    System.Reflection.EventAttributes Attributes { get; }
    System.Type DeclaringType { get; }
    System.Type EventHandlerType { get; }
    bool IsMulticast { get; }
    bool IsSpecialName { get; }
    System.Reflection.MemberTypes MemberType { get; }
    string Name { get; }
    System.Type ReflectedType { get; }
    void AddEventHandler(object target, System.Delegate handler);
    bool Equals(object other);
    System.Reflection.MethodInfo GetAddMethod();
    System.Reflection.MethodInfo GetAddMethod(bool nonPublic);
    object[] GetCustomAttributes(bool inherit);
    object[] GetCustomAttributes(System.Type attributeType, bool inherit);
    int GetHashCode();
    void GetIDsOfNames(ref System.Guid riid, System.IntPtr rgszNames, uint cNames, uint lcid, System.IntPtr rgDispId);
    System.Reflection.MethodInfo GetRaiseMethod();
    System.Reflection.MethodInfo GetRaiseMethod(bool nonPublic);
    System.Reflection.MethodInfo GetRemoveMethod();
    System.Reflection.MethodInfo GetRemoveMethod(bool nonPublic);
    System.Type GetType();
    void GetTypeInfo(uint iTInfo, uint lcid, System.IntPtr ppTInfo);
    void GetTypeInfoCount(out uint pcTInfo);
    void Invoke(uint dispIdMember, ref System.Guid riid, uint lcid, short wFlags, System.IntPtr pDispParams, System.IntPtr pVarResult, System.IntPtr pExcepInfo, System.IntPtr puArgErr);
    bool IsDefined(System.Type attributeType, bool inherit);
    void RemoveEventHandler(object target, System.Delegate handler);
    string ToString();
  }

  [System.CLSCompliantAttribute(false)]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("b36b5c63-42ef-38bc-a07e-0b34c98f164a")]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(0))]
  public partial interface _Exception {
    string HelpLink { get; set; }
    System.Exception InnerException { get; }
    string Message { get; }
    string Source { get; set; }
    string StackTrace { get; }
    System.Reflection.MethodBase TargetSite { get; }
    bool Equals(object obj);
    System.Exception GetBaseException();
    int GetHashCode();
    void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
    System.Type GetType();
    string ToString();
  }

  [System.CLSCompliantAttribute(false)]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("8A7C1442-A9FB-366B-80D8-4939FFA6DBE0")]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
  public partial interface _FieldInfo {
    System.Reflection.FieldAttributes Attributes { get; }
    System.Type DeclaringType { get; }
    System.RuntimeFieldHandle FieldHandle { get; }
    System.Type FieldType { get; }
    bool IsAssembly { get; }
    bool IsFamily { get; }
    bool IsFamilyAndAssembly { get; }
    bool IsFamilyOrAssembly { get; }
    bool IsInitOnly { get; }
    bool IsLiteral { get; }
    bool IsNotSerialized { get; }
    bool IsPinvokeImpl { get; }
    bool IsPrivate { get; }
    bool IsPublic { get; }
    bool IsSpecialName { get; }
    bool IsStatic { get; }
    System.Reflection.MemberTypes MemberType { get; }
    string Name { get; }
    System.Type ReflectedType { get; }
    bool Equals(object other);
    object[] GetCustomAttributes(bool inherit);
    object[] GetCustomAttributes(System.Type attributeType, bool inherit);
    int GetHashCode();
    void GetIDsOfNames(ref System.Guid riid, System.IntPtr rgszNames, uint cNames, uint lcid, System.IntPtr rgDispId);
    System.Type GetType();
    void GetTypeInfo(uint iTInfo, uint lcid, System.IntPtr ppTInfo);
    void GetTypeInfoCount(out uint pcTInfo);
    object GetValue(object obj);
    object GetValueDirect(System.TypedReference obj);
    void Invoke(uint dispIdMember, ref System.Guid riid, uint lcid, short wFlags, System.IntPtr pDispParams, System.IntPtr pVarResult, System.IntPtr pExcepInfo, System.IntPtr puArgErr);
    bool IsDefined(System.Type attributeType, bool inherit);
    void SetValue(object obj, object value);
    void SetValue(object obj, object value, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, System.Globalization.CultureInfo culture);
    void SetValueDirect(System.TypedReference obj, object value);
    string ToString();
  }

  [System.CLSCompliantAttribute(false)]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("f7102fa9-cabb-3a74-a6da-b4567ef1b079")]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
  public partial interface _MemberInfo {
    System.Type DeclaringType { get; }
    System.Reflection.MemberTypes MemberType { get; }
    string Name { get; }
    System.Type ReflectedType { get; }
    bool Equals(object other);
    object[] GetCustomAttributes(bool inherit);
    object[] GetCustomAttributes(System.Type attributeType, bool inherit);
    int GetHashCode();
    void GetIDsOfNames(ref System.Guid riid, System.IntPtr rgszNames, uint cNames, uint lcid, System.IntPtr rgDispId);
    System.Type GetType();
    void GetTypeInfo(uint iTInfo, uint lcid, System.IntPtr ppTInfo);
    void GetTypeInfoCount(out uint pcTInfo);
    void Invoke(uint dispIdMember, ref System.Guid riid, uint lcid, short wFlags, System.IntPtr pDispParams, System.IntPtr pVarResult, System.IntPtr pExcepInfo, System.IntPtr puArgErr);
    bool IsDefined(System.Type attributeType, bool inherit);
    string ToString();
  }

  [System.CLSCompliantAttribute(false)]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("6240837A-707F-3181-8E98-A36AE086766B")]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
  public partial interface _MethodBase {
    System.Reflection.MethodAttributes Attributes { get; }
    System.Reflection.CallingConventions CallingConvention { get; }
    System.Type DeclaringType { get; }
    bool IsAbstract { get; }
    bool IsAssembly { get; }
    bool IsConstructor { get; }
    bool IsFamily { get; }
    bool IsFamilyAndAssembly { get; }
    bool IsFamilyOrAssembly { get; }
    bool IsFinal { get; }
    bool IsHideBySig { get; }
    bool IsPrivate { get; }
    bool IsPublic { get; }
    bool IsSpecialName { get; }
    bool IsStatic { get; }
    bool IsVirtual { get; }
    System.Reflection.MemberTypes MemberType { get; }
    System.RuntimeMethodHandle MethodHandle { get; }
    string Name { get; }
    System.Type ReflectedType { get; }
    bool Equals(object other);
    object[] GetCustomAttributes(bool inherit);
    object[] GetCustomAttributes(System.Type attributeType, bool inherit);
    int GetHashCode();
    void GetIDsOfNames(ref System.Guid riid, System.IntPtr rgszNames, uint cNames, uint lcid, System.IntPtr rgDispId);
    System.Reflection.MethodImplAttributes GetMethodImplementationFlags();
    System.Reflection.ParameterInfo[] GetParameters();
    System.Type GetType();
    void GetTypeInfo(uint iTInfo, uint lcid, System.IntPtr ppTInfo);
    void GetTypeInfoCount(out uint pcTInfo);
    object Invoke(object obj, object[] parameters);
    object Invoke(object obj, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object[] parameters, System.Globalization.CultureInfo culture);
    void Invoke(uint dispIdMember, ref System.Guid riid, uint lcid, short wFlags, System.IntPtr pDispParams, System.IntPtr pVarResult, System.IntPtr pExcepInfo, System.IntPtr puArgErr);
    bool IsDefined(System.Type attributeType, bool inherit);
    string ToString();
  }

  [System.CLSCompliantAttribute(false)]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("FFCC1B5D-ECB8-38DD-9B01-3DC8ABC2AA5F")]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
  public partial interface _MethodInfo {
    System.Reflection.MethodAttributes Attributes { get; }
    System.Reflection.CallingConventions CallingConvention { get; }
    System.Type DeclaringType { get; }
    bool IsAbstract { get; }
    bool IsAssembly { get; }
    bool IsConstructor { get; }
    bool IsFamily { get; }
    bool IsFamilyAndAssembly { get; }
    bool IsFamilyOrAssembly { get; }
    bool IsFinal { get; }
    bool IsHideBySig { get; }
    bool IsPrivate { get; }
    bool IsPublic { get; }
    bool IsSpecialName { get; }
    bool IsStatic { get; }
    bool IsVirtual { get; }
    System.Reflection.MemberTypes MemberType { get; }
    System.RuntimeMethodHandle MethodHandle { get; }
    string Name { get; }
    System.Type ReflectedType { get; }
    System.Type ReturnType { get; }
    System.Reflection.ICustomAttributeProvider ReturnTypeCustomAttributes { get; }
    bool Equals(object other);
    System.Reflection.MethodInfo GetBaseDefinition();
    object[] GetCustomAttributes(bool inherit);
    object[] GetCustomAttributes(System.Type attributeType, bool inherit);
    int GetHashCode();
    void GetIDsOfNames(ref System.Guid riid, System.IntPtr rgszNames, uint cNames, uint lcid, System.IntPtr rgDispId);
    System.Reflection.MethodImplAttributes GetMethodImplementationFlags();
    System.Reflection.ParameterInfo[] GetParameters();
    System.Type GetType();
    void GetTypeInfo(uint iTInfo, uint lcid, System.IntPtr ppTInfo);
    void GetTypeInfoCount(out uint pcTInfo);
    object Invoke(object obj, object[] parameters);
    object Invoke(object obj, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object[] parameters, System.Globalization.CultureInfo culture);
    void Invoke(uint dispIdMember, ref System.Guid riid, uint lcid, short wFlags, System.IntPtr pDispParams, System.IntPtr pVarResult, System.IntPtr pExcepInfo, System.IntPtr puArgErr);
    bool IsDefined(System.Type attributeType, bool inherit);
    string ToString();
  }

  [System.CLSCompliantAttribute(false)]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("D002E9BA-D9E3-3749-B1D3-D565A08B13E7")]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
  public partial interface _Module {
    void GetIDsOfNames(ref System.Guid riid, System.IntPtr rgszNames, uint cNames, uint lcid, System.IntPtr rgDispId);
    void GetTypeInfo(uint iTInfo, uint lcid, System.IntPtr ppTInfo);
    void GetTypeInfoCount(out uint pcTInfo);
    void Invoke(uint dispIdMember, ref System.Guid riid, uint lcid, short wFlags, System.IntPtr pDispParams, System.IntPtr pVarResult, System.IntPtr pExcepInfo, System.IntPtr puArgErr);
  }

  [System.CLSCompliantAttribute(false)]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("993634C4-E47A-32CC-BE08-85F567DC27D6")]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
  public partial interface _ParameterInfo {
    void GetIDsOfNames(ref System.Guid riid, System.IntPtr rgszNames, uint cNames, uint lcid, System.IntPtr rgDispId);
    void GetTypeInfo(uint iTInfo, uint lcid, System.IntPtr ppTInfo);
    void GetTypeInfoCount(out uint pcTInfo);
    void Invoke(uint dispIdMember, ref System.Guid riid, uint lcid, short wFlags, System.IntPtr pDispParams, System.IntPtr pVarResult, System.IntPtr pExcepInfo, System.IntPtr puArgErr);
  }

  [System.CLSCompliantAttribute(false)]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("F59ED4E4-E68F-3218-BD77-061AA82824BF")]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
  public partial interface _PropertyInfo {
    System.Reflection.PropertyAttributes Attributes { get; }
    bool CanRead { get; }
    bool CanWrite { get; }
    System.Type DeclaringType { get; }
    bool IsSpecialName { get; }
    System.Reflection.MemberTypes MemberType { get; }
    string Name { get; }
    System.Type PropertyType { get; }
    System.Type ReflectedType { get; }
    bool Equals(object other);
    System.Reflection.MethodInfo[] GetAccessors();
    System.Reflection.MethodInfo[] GetAccessors(bool nonPublic);
    object[] GetCustomAttributes(bool inherit);
    object[] GetCustomAttributes(System.Type attributeType, bool inherit);
    System.Reflection.MethodInfo GetGetMethod();
    System.Reflection.MethodInfo GetGetMethod(bool nonPublic);
    int GetHashCode();
    void GetIDsOfNames(ref System.Guid riid, System.IntPtr rgszNames, uint cNames, uint lcid, System.IntPtr rgDispId);
    System.Reflection.ParameterInfo[] GetIndexParameters();
    System.Reflection.MethodInfo GetSetMethod();
    System.Reflection.MethodInfo GetSetMethod(bool nonPublic);
    System.Type GetType();
    void GetTypeInfo(uint iTInfo, uint lcid, System.IntPtr ppTInfo);
    void GetTypeInfoCount(out uint pcTInfo);
    object GetValue(object obj, object[] index);
    object GetValue(object obj, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object[] index, System.Globalization.CultureInfo culture);
    void Invoke(uint dispIdMember, ref System.Guid riid, uint lcid, short wFlags, System.IntPtr pDispParams, System.IntPtr pVarResult, System.IntPtr pExcepInfo, System.IntPtr puArgErr);
    bool IsDefined(System.Type attributeType, bool inherit);
    void SetValue(object obj, object value, object[] index);
    void SetValue(object obj, object value, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object[] index, System.Globalization.CultureInfo culture);
    string ToString();
  }

  [System.CLSCompliantAttribute(false)]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("C281C7F1-4AA9-3517-961A-463CFED57E75")]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
  public partial interface _Thread {
    void GetIDsOfNames(ref System.Guid riid, System.IntPtr rgszNames, uint cNames, uint lcid, System.IntPtr rgDispId);
    void GetTypeInfo(uint iTInfo, uint lcid, System.IntPtr ppTInfo);
    void GetTypeInfoCount(out uint pcTInfo);
    void Invoke(uint dispIdMember, ref System.Guid riid, uint lcid, short wFlags, System.IntPtr pDispParams, System.IntPtr pVarResult, System.IntPtr pExcepInfo, System.IntPtr puArgErr);
  }

  [System.CLSCompliantAttribute(false)]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.GuidAttribute("BCA8B44D-AAD6-3A86-8AB7-03349F4F2DA2")]
  [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
  public partial interface _Type {
    System.Reflection.Assembly Assembly { get; }
    string AssemblyQualifiedName { get; }
    System.Reflection.TypeAttributes Attributes { get; }
    System.Type BaseType { get; }
    System.Type DeclaringType { get; }
    string FullName { get; }
    System.Guid GUID { get; }
    bool HasElementType { get; }
    bool IsAbstract { get; }
    bool IsAnsiClass { get; }
    bool IsArray { get; }
    bool IsAutoClass { get; }
    bool IsAutoLayout { get; }
    bool IsByRef { get; }
    bool IsClass { get; }
    bool IsCOMObject { get; }
    bool IsContextful { get; }
    bool IsEnum { get; }
    bool IsExplicitLayout { get; }
    bool IsImport { get; }
    bool IsInterface { get; }
    bool IsLayoutSequential { get; }
    bool IsMarshalByRef { get; }
    bool IsNestedAssembly { get; }
    bool IsNestedFamANDAssem { get; }
    bool IsNestedFamily { get; }
    bool IsNestedFamORAssem { get; }
    bool IsNestedPrivate { get; }
    bool IsNestedPublic { get; }
    bool IsNotPublic { get; }
    bool IsPointer { get; }
    bool IsPrimitive { get; }
    bool IsPublic { get; }
    bool IsSealed { get; }
    bool IsSerializable { get; }
    bool IsSpecialName { get; }
    bool IsUnicodeClass { get; }
    bool IsValueType { get; }
    System.Reflection.MemberTypes MemberType { get; }
    System.Reflection.Module Module { get; }
    string Name { get; }
    string Namespace { get; }
    System.Type ReflectedType { get; }
    System.RuntimeTypeHandle TypeHandle { get; }
    System.Reflection.ConstructorInfo TypeInitializer { get; }
    System.Type UnderlyingSystemType { get; }
    bool Equals(object other);
    bool Equals(System.Type o);
    System.Type[] FindInterfaces(System.Reflection.TypeFilter filter, object filterCriteria);
    System.Reflection.MemberInfo[] FindMembers(System.Reflection.MemberTypes memberType, System.Reflection.BindingFlags bindingAttr, System.Reflection.MemberFilter filter, object filterCriteria);
    int GetArrayRank();
    System.Reflection.ConstructorInfo GetConstructor(System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Reflection.CallingConventions callConvention, System.Type[] types, System.Reflection.ParameterModifier[] modifiers);
    System.Reflection.ConstructorInfo GetConstructor(System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Type[] types, System.Reflection.ParameterModifier[] modifiers);
    System.Reflection.ConstructorInfo GetConstructor(System.Type[] types);
    System.Reflection.ConstructorInfo[] GetConstructors();
    System.Reflection.ConstructorInfo[] GetConstructors(System.Reflection.BindingFlags bindingAttr);
    object[] GetCustomAttributes(bool inherit);
    object[] GetCustomAttributes(System.Type attributeType, bool inherit);
    System.Reflection.MemberInfo[] GetDefaultMembers();
    System.Type GetElementType();
    System.Reflection.EventInfo GetEvent(string name);
    System.Reflection.EventInfo GetEvent(string name, System.Reflection.BindingFlags bindingAttr);
    System.Reflection.EventInfo[] GetEvents();
    System.Reflection.EventInfo[] GetEvents(System.Reflection.BindingFlags bindingAttr);
    System.Reflection.FieldInfo GetField(string name);
    System.Reflection.FieldInfo GetField(string name, System.Reflection.BindingFlags bindingAttr);
    System.Reflection.FieldInfo[] GetFields();
    System.Reflection.FieldInfo[] GetFields(System.Reflection.BindingFlags bindingAttr);
    int GetHashCode();
    void GetIDsOfNames(ref System.Guid riid, System.IntPtr rgszNames, uint cNames, uint lcid, System.IntPtr rgDispId);
    System.Type GetInterface(string name);
    System.Type GetInterface(string name, bool ignoreCase);
    System.Reflection.InterfaceMapping GetInterfaceMap(System.Type interfaceType);
    System.Type[] GetInterfaces();
    System.Reflection.MemberInfo[] GetMember(string name);
    System.Reflection.MemberInfo[] GetMember(string name, System.Reflection.BindingFlags bindingAttr);
    System.Reflection.MemberInfo[] GetMember(string name, System.Reflection.MemberTypes type, System.Reflection.BindingFlags bindingAttr);
    System.Reflection.MemberInfo[] GetMembers();
    System.Reflection.MemberInfo[] GetMembers(System.Reflection.BindingFlags bindingAttr);
    System.Reflection.MethodInfo GetMethod(string name);
    System.Reflection.MethodInfo GetMethod(string name, System.Reflection.BindingFlags bindingAttr);
    System.Reflection.MethodInfo GetMethod(string name, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Reflection.CallingConventions callConvention, System.Type[] types, System.Reflection.ParameterModifier[] modifiers);
    System.Reflection.MethodInfo GetMethod(string name, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Type[] types, System.Reflection.ParameterModifier[] modifiers);
    System.Reflection.MethodInfo GetMethod(string name, System.Type[] types);
    System.Reflection.MethodInfo GetMethod(string name, System.Type[] types, System.Reflection.ParameterModifier[] modifiers);
    System.Reflection.MethodInfo[] GetMethods();
    System.Reflection.MethodInfo[] GetMethods(System.Reflection.BindingFlags bindingAttr);
    System.Type GetNestedType(string name);
    System.Type GetNestedType(string name, System.Reflection.BindingFlags bindingAttr);
    System.Type[] GetNestedTypes();
    System.Type[] GetNestedTypes(System.Reflection.BindingFlags bindingAttr);
    System.Reflection.PropertyInfo[] GetProperties();
    System.Reflection.PropertyInfo[] GetProperties(System.Reflection.BindingFlags bindingAttr);
    System.Reflection.PropertyInfo GetProperty(string name);
    System.Reflection.PropertyInfo GetProperty(string name, System.Reflection.BindingFlags bindingAttr);
    System.Reflection.PropertyInfo GetProperty(string name, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Type returnType, System.Type[] types, System.Reflection.ParameterModifier[] modifiers);
    System.Reflection.PropertyInfo GetProperty(string name, System.Type returnType);
    System.Reflection.PropertyInfo GetProperty(string name, System.Type returnType, System.Type[] types);
    System.Reflection.PropertyInfo GetProperty(string name, System.Type returnType, System.Type[] types, System.Reflection.ParameterModifier[] modifiers);
    System.Reflection.PropertyInfo GetProperty(string name, System.Type[] types);
    System.Type GetType();
    void GetTypeInfo(uint iTInfo, uint lcid, System.IntPtr ppTInfo);
    void GetTypeInfoCount(out uint pcTInfo);
    void Invoke(uint dispIdMember, ref System.Guid riid, uint lcid, short wFlags, System.IntPtr pDispParams, System.IntPtr pVarResult, System.IntPtr pExcepInfo, System.IntPtr puArgErr);
    object InvokeMember(string name, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object target, object[] args);
    object InvokeMember(string name, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object target, object[] args, System.Globalization.CultureInfo culture);
    object InvokeMember(string name, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object target, object[] args, System.Reflection.ParameterModifier[] modifiers, System.Globalization.CultureInfo culture, string[] namedParameters);
    bool IsAssignableFrom(System.Type c);
    bool IsDefined(System.Type attributeType, bool inherit);
    bool IsInstanceOfType(object o);
    bool IsSubclassOf(System.Type c);
    string ToString();
  }

  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.ObsoleteAttribute("ComAwareEventInfo may be unavailable in future releases.")]
  public partial class ComAwareEventInfo : System.Reflection.EventInfo {
    public ComAwareEventInfo(System.Type type, string eventName) { }
    public override System.Reflection.EventAttributes Attributes { get { return default(System.Reflection.EventAttributes); } }
    public override System.Type DeclaringType { get { return default(System.Type); } }
    public override string Name { get { return default(string); } }
    public override void AddEventHandler(object target, System.Delegate handler) { }
    public override void RemoveEventHandler(object target, System.Delegate handler) { }
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

  public enum Architecture {
    Arm = 2,
    Arm64 = 3,
    X64 = 1,
    X86 = 0,
  }

  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct OSPlatform : System.IEquatable<System.Runtime.InteropServices.OSPlatform> {
    public static System.Runtime.InteropServices.OSPlatform Linux { get { return default(System.Runtime.InteropServices.OSPlatform); } }
    public static System.Runtime.InteropServices.OSPlatform OSX { get { return default(System.Runtime.InteropServices.OSPlatform); } }
    public static System.Runtime.InteropServices.OSPlatform Windows { get { return default(System.Runtime.InteropServices.OSPlatform); } }
    public static System.Runtime.InteropServices.OSPlatform Create(string osPlatform) { return default(System.Runtime.InteropServices.OSPlatform); }
    public override bool Equals(object obj) { return default(bool); }
    public bool Equals(System.Runtime.InteropServices.OSPlatform other) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.Runtime.InteropServices.OSPlatform left, System.Runtime.InteropServices.OSPlatform right) { return default(bool); }
    public static bool operator !=(System.Runtime.InteropServices.OSPlatform left, System.Runtime.InteropServices.OSPlatform right) { return default(bool); }
    public override string ToString() { return default(string); }
  }

  public static partial class RuntimeInformation {
    public static string FrameworkDescription { get { return default(string); } }
    public static System.Runtime.InteropServices.Architecture OSArchitecture { get { return default(System.Runtime.InteropServices.Architecture); } }
    public static string OSDescription { get { return default(string); } }
    public static System.Runtime.InteropServices.Architecture ProcessArchitecture { get { return default(System.Runtime.InteropServices.Architecture); } }
    public static bool IsOSPlatform(System.Runtime.InteropServices.OSPlatform osPlatform) { return default(bool); }
  }

} // end of System.Runtime.InteropServices
namespace Microsoft.VisualBasic {
  public enum CallType {
    Get = 2,
    Let = 4,
    Method = 1,
    Set = 8,
  }

  [Microsoft.VisualBasic.CompilerServices.StandardModuleAttribute]
  public sealed partial class Constants {
    internal Constants() { }
    public const string vbBack = "\b";
    public const string vbCr = "\r";
    public const string vbCrLf = "\r\n";
    public const string vbFormFeed = "\f";
    public const string vbLf = "\n";
    [System.ObsoleteAttribute("For a carriage return and line feed, use vbCrLf.  For the current platform's newline, use System.Environment.NewLine.")]
    public const string vbNewLine = "\r\n";
    public const string vbNullChar = "\0";
    public const string vbNullString = null;
    public const string vbTab = "\t";
    public const string vbVerticalTab = "\v";
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false, Inherited=false)]
  public sealed partial class HideModuleNameAttribute : System.Attribute {
    public HideModuleNameAttribute() { }
  }

  [Microsoft.VisualBasic.CompilerServices.StandardModuleAttribute]
  public sealed partial class Strings {
    internal Strings() { }
    public static int AscW(char String) { return default(int); }
    public static int AscW(string String) { return default(int); }
    public static char ChrW(int CharCode) { return default(char); }
  }

} // end of Microsoft.VisualBasic
namespace Microsoft.VisualBasic.CompilerServices {
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class Conversions {
    internal Conversions() { }
    public static object ChangeType(object Expression, System.Type TargetType) { return default(object); }
    public static bool ToBoolean(object Value) { return default(bool); }
    public static bool ToBoolean(string Value) { return default(bool); }
    public static byte ToByte(object Value) { return default(byte); }
    public static byte ToByte(string Value) { return default(byte); }
    public static char ToChar(object Value) { return default(char); }
    public static char ToChar(string Value) { return default(char); }
    public static char[] ToCharArrayRankOne(object Value) { return default(char[]); }
    public static char[] ToCharArrayRankOne(string Value) { return default(char[]); }
    public static System.DateTime ToDate(object Value) { return default(System.DateTime); }
    public static System.DateTime ToDate(string Value) { return default(System.DateTime); }
    public static decimal ToDecimal(bool Value) { return default(decimal); }
    public static decimal ToDecimal(object Value) { return default(decimal); }
    public static decimal ToDecimal(string Value) { return default(decimal); }
    public static double ToDouble(object Value) { return default(double); }
    public static double ToDouble(string Value) { return default(double); }
    public static T ToGenericParameter<T>(object Value) { return default(T); }
    public static int ToInteger(object Value) { return default(int); }
    public static int ToInteger(string Value) { return default(int); }
    public static long ToLong(object Value) { return default(long); }
    public static long ToLong(string Value) { return default(long); }
    [System.CLSCompliantAttribute(false)]
    public static sbyte ToSByte(object Value) { return default(sbyte); }
    [System.CLSCompliantAttribute(false)]
    public static sbyte ToSByte(string Value) { return default(sbyte); }
    public static short ToShort(object Value) { return default(short); }
    public static short ToShort(string Value) { return default(short); }
    public static float ToSingle(object Value) { return default(float); }
    public static float ToSingle(string Value) { return default(float); }
    public static string ToString(bool Value) { return default(string); }
    public static string ToString(byte Value) { return default(string); }
    public static string ToString(char Value) { return default(string); }
    public static string ToString(System.DateTime Value) { return default(string); }
    public static string ToString(decimal Value) { return default(string); }
    public static string ToString(double Value) { return default(string); }
    public static string ToString(short Value) { return default(string); }
    public static string ToString(int Value) { return default(string); }
    public static string ToString(long Value) { return default(string); }
    public static string ToString(object Value) { return default(string); }
    public static string ToString(float Value) { return default(string); }
    [System.CLSCompliantAttribute(false)]
    public static string ToString(uint Value) { return default(string); }
    [System.CLSCompliantAttribute(false)]
    public static string ToString(ulong Value) { return default(string); }
    [System.CLSCompliantAttribute(false)]
    public static uint ToUInteger(object Value) { return default(uint); }
    [System.CLSCompliantAttribute(false)]
    public static uint ToUInteger(string Value) { return default(uint); }
    [System.CLSCompliantAttribute(false)]
    public static ulong ToULong(object Value) { return default(ulong); }
    [System.CLSCompliantAttribute(false)]
    public static ulong ToULong(string Value) { return default(ulong); }
    [System.CLSCompliantAttribute(false)]
    public static ushort ToUShort(object Value) { return default(ushort); }
    [System.CLSCompliantAttribute(false)]
    public static ushort ToUShort(string Value) { return default(ushort); }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false, Inherited=false)]
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class DesignerGeneratedAttribute : System.Attribute {
    public DesignerGeneratedAttribute() { }
  }

  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class IncompleteInitialization : System.Exception {
    public IncompleteInitialization() { }
  }

  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class NewLateBinding {
    internal NewLateBinding() { }
    public static object LateCall(object Instance, System.Type Type, string MemberName, object[] Arguments, string[] ArgumentNames, System.Type[] TypeArguments, bool[] CopyBack, bool IgnoreReturn) { return default(object); }
    public static object LateGet(object Instance, System.Type Type, string MemberName, object[] Arguments, string[] ArgumentNames, System.Type[] TypeArguments, bool[] CopyBack) { return default(object); }
    public static object LateIndexGet(object Instance, object[] Arguments, string[] ArgumentNames) { return default(object); }
    public static void LateIndexSet(object Instance, object[] Arguments, string[] ArgumentNames) { }
    public static void LateIndexSetComplex(object Instance, object[] Arguments, string[] ArgumentNames, bool OptimisticSet, bool RValueBase) { }
    public static void LateSet(object Instance, System.Type Type, string MemberName, object[] Arguments, string[] ArgumentNames, System.Type[] TypeArguments) { }
    public static void LateSet(object Instance, System.Type Type, string MemberName, object[] Arguments, string[] ArgumentNames, System.Type[] TypeArguments, bool OptimisticSet, bool RValueBase, Microsoft.VisualBasic.CallType CallType) { }
    public static void LateSetComplex(object Instance, System.Type Type, string MemberName, object[] Arguments, string[] ArgumentNames, System.Type[] TypeArguments, bool OptimisticSet, bool RValueBase) { }
  }

  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class ObjectFlowControl {
    internal ObjectFlowControl() { }
    public static void CheckForSyncLockOnValueType(object Expression) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public sealed partial class ForLoopControl {
      internal ForLoopControl() { }
      public static bool ForLoopInitObj(object Counter, object Start, object Limit, object StepValue, ref object LoopForResult, ref object CounterResult) { return default(bool); }
      public static bool ForNextCheckDec(decimal count, decimal limit, decimal StepValue) { return default(bool); }
      public static bool ForNextCheckObj(object Counter, object LoopObj, ref object CounterResult) { return default(bool); }
      public static bool ForNextCheckR4(float count, float limit, float StepValue) { return default(bool); }
      public static bool ForNextCheckR8(double count, double limit, double StepValue) { return default(bool); }
    }
  }

  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class Operators {
    internal Operators() { }
    public static object AddObject(object Left, object Right) { return default(object); }
    public static object AndObject(object Left, object Right) { return default(object); }
    public static object CompareObjectEqual(object Left, object Right, bool TextCompare) { return default(object); }
    public static object CompareObjectGreater(object Left, object Right, bool TextCompare) { return default(object); }
    public static object CompareObjectGreaterEqual(object Left, object Right, bool TextCompare) { return default(object); }
    public static object CompareObjectLess(object Left, object Right, bool TextCompare) { return default(object); }
    public static object CompareObjectLessEqual(object Left, object Right, bool TextCompare) { return default(object); }
    public static object CompareObjectNotEqual(object Left, object Right, bool TextCompare) { return default(object); }
    public static int CompareString(string Left, string Right, bool TextCompare) { return default(int); }
    public static object ConcatenateObject(object Left, object Right) { return default(object); }
    public static bool ConditionalCompareObjectEqual(object Left, object Right, bool TextCompare) { return default(bool); }
    public static bool ConditionalCompareObjectGreater(object Left, object Right, bool TextCompare) { return default(bool); }
    public static bool ConditionalCompareObjectGreaterEqual(object Left, object Right, bool TextCompare) { return default(bool); }
    public static bool ConditionalCompareObjectLess(object Left, object Right, bool TextCompare) { return default(bool); }
    public static bool ConditionalCompareObjectLessEqual(object Left, object Right, bool TextCompare) { return default(bool); }
    public static bool ConditionalCompareObjectNotEqual(object Left, object Right, bool TextCompare) { return default(bool); }
    public static object DivideObject(object Left, object Right) { return default(object); }
    public static object ExponentObject(object Left, object Right) { return default(object); }
    public static object IntDivideObject(object Left, object Right) { return default(object); }
    public static object LeftShiftObject(object Operand, object Amount) { return default(object); }
    public static object ModObject(object Left, object Right) { return default(object); }
    public static object MultiplyObject(object Left, object Right) { return default(object); }
    public static object NegateObject(object Operand) { return default(object); }
    public static object NotObject(object Operand) { return default(object); }
    public static object OrObject(object Left, object Right) { return default(object); }
    public static object PlusObject(object Operand) { return default(object); }
    public static object RightShiftObject(object Operand, object Amount) { return default(object); }
    public static object SubtractObject(object Left, object Right) { return default(object); }
    public static object XorObject(object Left, object Right) { return default(object); }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(2048), Inherited=false, AllowMultiple=false)]
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class OptionCompareAttribute : System.Attribute {
    public OptionCompareAttribute() { }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(4), Inherited=false, AllowMultiple=false)]
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class OptionTextAttribute : System.Attribute {
    public OptionTextAttribute() { }
  }

  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class ProjectData {
    internal ProjectData() { }
    [System.Security.SecuritySafeCriticalAttribute]
    public static void ClearProjectError() { }
    [System.Security.SecuritySafeCriticalAttribute]
    public static void SetProjectError(System.Exception ex) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public static void SetProjectError(System.Exception ex, int lErl) { }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(4), Inherited=false, AllowMultiple=false)]
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class StandardModuleAttribute : System.Attribute {
    public StandardModuleAttribute() { }
  }

  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class StaticLocalInitFlag {
    public short State;
    public StaticLocalInitFlag() { }
  }

  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public sealed partial class Utils {
    internal Utils() { }
    public static System.Array CopyArray(System.Array arySrc, System.Array aryDest) { return default(System.Array); }
  }

} // end of Microsoft.VisualBasic.CompilerServices
namespace Microsoft.Win32 {
  public static partial class Registry {
    public static readonly Microsoft.Win32.RegistryKey ClassesRoot;
    public static readonly Microsoft.Win32.RegistryKey CurrentConfig;
    public static readonly Microsoft.Win32.RegistryKey CurrentUser;
    public static readonly Microsoft.Win32.RegistryKey LocalMachine;
    public static readonly Microsoft.Win32.RegistryKey PerformanceData;
    public static readonly Microsoft.Win32.RegistryKey Users;
    public static object GetValue(string keyName, string valueName, object defaultValue) { return default(object); }
    public static void SetValue(string keyName, string valueName, object value) { }
    public static void SetValue(string keyName, string valueName, object value, Microsoft.Win32.RegistryValueKind valueKind) { }
  }

  public enum RegistryHive {
    ClassesRoot = -2147483648,
    CurrentConfig = -2147483643,
    CurrentUser = -2147483647,
    LocalMachine = -2147483646,
    PerformanceData = -2147483644,
    Users = -2147483645,
  }

  public sealed partial class RegistryKey : System.IDisposable {
    internal RegistryKey() { }
    public Microsoft.Win32.SafeHandles.SafeRegistryHandle Handle { [System.Security.SecurityCriticalAttribute]get { return default(Microsoft.Win32.SafeHandles.SafeRegistryHandle); } }
    public string Name { get { return default(string); } }
    public int SubKeyCount { get { return default(int); } }
    public int ValueCount { get { return default(int); } }
    public Microsoft.Win32.RegistryView View { get { return default(Microsoft.Win32.RegistryView); } }
    public Microsoft.Win32.RegistryKey CreateSubKey(string subkey) { return default(Microsoft.Win32.RegistryKey); }
    public Microsoft.Win32.RegistryKey CreateSubKey(string subkey, bool writable) { return default(Microsoft.Win32.RegistryKey); }
    public Microsoft.Win32.RegistryKey CreateSubKey(string subkey, bool writable, Microsoft.Win32.RegistryOptions options) { return default(Microsoft.Win32.RegistryKey); }
    public void DeleteSubKey(string subkey) { }
    public void DeleteSubKey(string subkey, bool throwOnMissingSubKey) { }
    public void DeleteSubKeyTree(string subkey) { }
    public void DeleteSubKeyTree(string subkey, bool throwOnMissingSubKey) { }
    public void DeleteValue(string name) { }
    public void DeleteValue(string name, bool throwOnMissingValue) { }
    public void Dispose() { }
    public void Flush() { }
    [System.Security.SecurityCriticalAttribute]
    public static Microsoft.Win32.RegistryKey FromHandle(Microsoft.Win32.SafeHandles.SafeRegistryHandle handle) { return default(Microsoft.Win32.RegistryKey); }
    [System.Security.SecurityCriticalAttribute]
    public static Microsoft.Win32.RegistryKey FromHandle(Microsoft.Win32.SafeHandles.SafeRegistryHandle handle, Microsoft.Win32.RegistryView view) { return default(Microsoft.Win32.RegistryKey); }
    public string[] GetSubKeyNames() { return default(string[]); }
    public object GetValue(string name) { return default(object); }
    public object GetValue(string name, object defaultValue) { return default(object); }
    public object GetValue(string name, object defaultValue, Microsoft.Win32.RegistryValueOptions options) { return default(object); }
    public Microsoft.Win32.RegistryValueKind GetValueKind(string name) { return default(Microsoft.Win32.RegistryValueKind); }
    public string[] GetValueNames() { return default(string[]); }
    public static Microsoft.Win32.RegistryKey OpenBaseKey(Microsoft.Win32.RegistryHive hKey, Microsoft.Win32.RegistryView view) { return default(Microsoft.Win32.RegistryKey); }
    public Microsoft.Win32.RegistryKey OpenSubKey(string name) { return default(Microsoft.Win32.RegistryKey); }
    public Microsoft.Win32.RegistryKey OpenSubKey(string name, bool writable) { return default(Microsoft.Win32.RegistryKey); }
    public Microsoft.Win32.RegistryKey OpenSubKey(string name, System.Security.AccessControl.RegistryRights rights) { return default(Microsoft.Win32.RegistryKey); }
    public void SetValue(string name, object value) { }
    public void SetValue(string name, object value, Microsoft.Win32.RegistryValueKind valueKind) { }
    public override string ToString() { return default(string); }
  }

  public enum RegistryValueKind {
    Binary = 3,
    DWord = 4,
    ExpandString = 2,
    MultiString = 7,
    None = -1,
    QWord = 11,
    String = 1,
    Unknown = 0,
  }

  [System.FlagsAttribute]
  public enum RegistryValueOptions {
    DoNotExpandEnvironmentNames = 1,
    None = 0,
  }

  [System.Security.SecurityCriticalAttribute]
  public static partial class RegistryAclExtensions {
    public static System.Security.AccessControl.RegistrySecurity GetAccessControl(this Microsoft.Win32.RegistryKey key) { return default(System.Security.AccessControl.RegistrySecurity); }
    public static System.Security.AccessControl.RegistrySecurity GetAccessControl(this Microsoft.Win32.RegistryKey key, System.Security.AccessControl.AccessControlSections includeSections) { return default(System.Security.AccessControl.RegistrySecurity); }
    public static void SetAccessControl(this Microsoft.Win32.RegistryKey key, System.Security.AccessControl.RegistrySecurity registrySecurity) { }
  }

} // end of Microsoft.Win32
namespace System.ComponentModel.DataAnnotations {
  [System.AttributeUsageAttribute((System.AttributeTargets)(384), AllowMultiple=false, Inherited=true)]
  [System.ObsoleteAttribute("This attribute is no longer in use and will be ignored if applied.")]
  public sealed partial class AssociationAttribute : System.Attribute {
    public AssociationAttribute(string name, string thisKey, string otherKey) { }
    public bool IsForeignKey { get { return default(bool); } set { } }
    public string Name { get { return default(string); } }
    public string OtherKey { get { return default(string); } }
    public System.Collections.Generic.IEnumerable<string> OtherKeyMembers { get { return default(System.Collections.Generic.IEnumerable<string>); } }
    public string ThisKey { get { return default(string); } }
    public System.Collections.Generic.IEnumerable<string> ThisKeyMembers { get { return default(System.Collections.Generic.IEnumerable<string>); } }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(128), AllowMultiple=false)]
  public partial class CompareAttribute : System.ComponentModel.DataAnnotations.ValidationAttribute {
    public CompareAttribute(string otherProperty) { }
    public string OtherProperty { get { return default(string); } }
    public string OtherPropertyDisplayName { get { return default(string); } }
    public override bool RequiresValidationContext { get { return default(bool); } }
    public override string FormatErrorMessage(string name) { return default(string); }
    protected override System.ComponentModel.DataAnnotations.ValidationResult IsValid(object value, System.ComponentModel.DataAnnotations.ValidationContext validationContext) { return default(System.ComponentModel.DataAnnotations.ValidationResult); }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(384), AllowMultiple=false, Inherited=true)]
  public sealed partial class ConcurrencyCheckAttribute : System.Attribute {
    public ConcurrencyCheckAttribute() { }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(2432), AllowMultiple=false)]
  public sealed partial class CreditCardAttribute : System.ComponentModel.DataAnnotations.DataTypeAttribute {
    public CreditCardAttribute() : base (default(System.ComponentModel.DataAnnotations.DataType)) { }
    public override bool IsValid(object value) { return default(bool); }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(2500), AllowMultiple=true)]
  public sealed partial class CustomValidationAttribute : System.ComponentModel.DataAnnotations.ValidationAttribute {
    public CustomValidationAttribute(System.Type validatorType, string method) { }
    public string Method { get { return default(string); } }
    public System.Type ValidatorType { get { return default(System.Type); } }
    public override string FormatErrorMessage(string name) { return default(string); }
    protected override System.ComponentModel.DataAnnotations.ValidationResult IsValid(object value, System.ComponentModel.DataAnnotations.ValidationContext validationContext) { return default(System.ComponentModel.DataAnnotations.ValidationResult); }
  }

  public enum DataType {
    CreditCard = 14,
    Currency = 6,
    Custom = 0,
    Date = 2,
    DateTime = 1,
    Duration = 4,
    EmailAddress = 10,
    Html = 8,
    ImageUrl = 13,
    MultilineText = 9,
    Password = 11,
    PhoneNumber = 5,
    PostalCode = 15,
    Text = 7,
    Time = 3,
    Upload = 16,
    Url = 12,
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(2496), AllowMultiple=false)]
  public partial class DataTypeAttribute : System.ComponentModel.DataAnnotations.ValidationAttribute {
    public DataTypeAttribute(System.ComponentModel.DataAnnotations.DataType dataType) { }
    public DataTypeAttribute(string customDataType) { }
    public string CustomDataType { get { return default(string); } }
    public System.ComponentModel.DataAnnotations.DataType DataType { get { return default(System.ComponentModel.DataAnnotations.DataType); } }
    public System.ComponentModel.DataAnnotations.DisplayFormatAttribute DisplayFormat { get { return default(System.ComponentModel.DataAnnotations.DisplayFormatAttribute); } protected set { } }
    public virtual string GetDataTypeName() { return default(string); }
    public override bool IsValid(object value) { return default(bool); }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(2496), AllowMultiple=false)]
  public sealed partial class DisplayAttribute : System.Attribute {
    public DisplayAttribute() { }
    public bool AutoGenerateField { get { return default(bool); } set { } }
    public bool AutoGenerateFilter { get { return default(bool); } set { } }
    public string Description { get { return default(string); } set { } }
    public string GroupName { get { return default(string); } set { } }
    public string Name { get { return default(string); } set { } }
    public int Order { get { return default(int); } set { } }
    public string Prompt { get { return default(string); } set { } }
    public System.Type ResourceType { get { return default(System.Type); } set { } }
    public string ShortName { get { return default(string); } set { } }
    public System.Nullable<bool> GetAutoGenerateField() { return default(System.Nullable<bool>); }
    public System.Nullable<bool> GetAutoGenerateFilter() { return default(System.Nullable<bool>); }
    public string GetDescription() { return default(string); }
    public string GetGroupName() { return default(string); }
    public string GetName() { return default(string); }
    public System.Nullable<int> GetOrder() { return default(System.Nullable<int>); }
    public string GetPrompt() { return default(string); }
    public string GetShortName() { return default(string); }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(4), Inherited=true, AllowMultiple=false)]
  public partial class DisplayColumnAttribute : System.Attribute {
    public DisplayColumnAttribute(string displayColumn) { }
    public DisplayColumnAttribute(string displayColumn, string sortColumn) { }
    public DisplayColumnAttribute(string displayColumn, string sortColumn, bool sortDescending) { }
    public string DisplayColumn { get { return default(string); } }
    public string SortColumn { get { return default(string); } }
    public bool SortDescending { get { return default(bool); } }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(384), AllowMultiple=false)]
  public partial class DisplayFormatAttribute : System.Attribute {
    public DisplayFormatAttribute() { }
    public bool ApplyFormatInEditMode { get { return default(bool); } set { } }
    public bool ConvertEmptyStringToNull { get { return default(bool); } set { } }
    public string DataFormatString { get { return default(string); } set { } }
    public bool HtmlEncode { get { return default(bool); } set { } }
    public string NullDisplayText { get { return default(string); } set { } }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(384), AllowMultiple=false, Inherited=true)]
  public sealed partial class EditableAttribute : System.Attribute {
    public EditableAttribute(bool allowEdit) { }
    public bool AllowEdit { get { return default(bool); } }
    public bool AllowInitialValue { get { return default(bool); } set { } }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(2432), AllowMultiple=false)]
  public sealed partial class EmailAddressAttribute : System.ComponentModel.DataAnnotations.DataTypeAttribute {
    public EmailAddressAttribute() : base (default(System.ComponentModel.DataAnnotations.DataType)) { }
    public override bool IsValid(object value) { return default(bool); }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(2496), AllowMultiple=false)]
  public sealed partial class EnumDataTypeAttribute : System.ComponentModel.DataAnnotations.DataTypeAttribute {
    public EnumDataTypeAttribute(System.Type enumType) : base (default(System.ComponentModel.DataAnnotations.DataType)) { }
    public System.Type EnumType { get { return default(System.Type); } }
    public override bool IsValid(object value) { return default(bool); }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(2432), AllowMultiple=false)]
  public sealed partial class FileExtensionsAttribute : System.ComponentModel.DataAnnotations.DataTypeAttribute {
    public FileExtensionsAttribute() : base (default(System.ComponentModel.DataAnnotations.DataType)) { }
    public string Extensions { get { return default(string); } set { } }
    public override string FormatErrorMessage(string name) { return default(string); }
    public override bool IsValid(object value) { return default(bool); }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(384), AllowMultiple=false)]
  [System.ObsoleteAttribute("This attribute is no longer in use and will be ignored if applied.")]
  public sealed partial class FilterUIHintAttribute : System.Attribute {
    public FilterUIHintAttribute(string filterUIHint) { }
    public FilterUIHintAttribute(string filterUIHint, string presentationLayer) { }
    public FilterUIHintAttribute(string filterUIHint, string presentationLayer, params object[] controlParameters) { }
    public System.Collections.Generic.IDictionary<string, object> ControlParameters { get { return default(System.Collections.Generic.IDictionary<string, object>); } }
    public string FilterUIHint { get { return default(string); } }
    public string PresentationLayer { get { return default(string); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }

  public partial interface IValidatableObject {
    System.Collections.Generic.IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(System.ComponentModel.DataAnnotations.ValidationContext validationContext);
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(384), AllowMultiple=false, Inherited=true)]
  public sealed partial class KeyAttribute : System.Attribute {
    public KeyAttribute() { }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(2432), AllowMultiple=false)]
  public partial class MaxLengthAttribute : System.ComponentModel.DataAnnotations.ValidationAttribute {
    public MaxLengthAttribute() { }
    public MaxLengthAttribute(int length) { }
    public int Length { get { return default(int); } }
    public override string FormatErrorMessage(string name) { return default(string); }
    public override bool IsValid(object value) { return default(bool); }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(2432), AllowMultiple=false)]
  public partial class MinLengthAttribute : System.ComponentModel.DataAnnotations.ValidationAttribute {
    public MinLengthAttribute(int length) { }
    public int Length { get { return default(int); } }
    public override string FormatErrorMessage(string name) { return default(string); }
    public override bool IsValid(object value) { return default(bool); }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(2432), AllowMultiple=false)]
  public sealed partial class PhoneAttribute : System.ComponentModel.DataAnnotations.DataTypeAttribute {
    public PhoneAttribute() : base (default(System.ComponentModel.DataAnnotations.DataType)) { }
    public override bool IsValid(object value) { return default(bool); }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(2432), AllowMultiple=false)]
  public partial class RangeAttribute : System.ComponentModel.DataAnnotations.ValidationAttribute {
    public RangeAttribute(double minimum, double maximum) { }
    public RangeAttribute(int minimum, int maximum) { }
    public RangeAttribute(System.Type type, string minimum, string maximum) { }
    public object Maximum { get { return default(object); } }
    public object Minimum { get { return default(object); } }
    public System.Type OperandType { get { return default(System.Type); } }
    public override string FormatErrorMessage(string name) { return default(string); }
    public override bool IsValid(object value) { return default(bool); }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(2432), AllowMultiple=false)]
  public partial class RegularExpressionAttribute : System.ComponentModel.DataAnnotations.ValidationAttribute {
    public RegularExpressionAttribute(string pattern) { }
    public int MatchTimeoutInMilliseconds { get { return default(int); } set { } }
    public string Pattern { get { return default(string); } }
    public override string FormatErrorMessage(string name) { return default(string); }
    public override bool IsValid(object value) { return default(bool); }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(2432), AllowMultiple=false)]
  public partial class RequiredAttribute : System.ComponentModel.DataAnnotations.ValidationAttribute {
    public RequiredAttribute() { }
    public bool AllowEmptyStrings { get { return default(bool); } set { } }
    public override bool IsValid(object value) { return default(bool); }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(384), AllowMultiple=false)]
  public partial class ScaffoldColumnAttribute : System.Attribute {
    public ScaffoldColumnAttribute(bool scaffold) { }
    public bool Scaffold { get { return default(bool); } }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(2432), AllowMultiple=false)]
  public partial class StringLengthAttribute : System.ComponentModel.DataAnnotations.ValidationAttribute {
    public StringLengthAttribute(int maximumLength) { }
    public int MaximumLength { get { return default(int); } }
    public int MinimumLength { get { return default(int); } set { } }
    public override string FormatErrorMessage(string name) { return default(string); }
    public override bool IsValid(object value) { return default(bool); }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(384), AllowMultiple=false, Inherited=true)]
  public sealed partial class TimestampAttribute : System.Attribute {
    public TimestampAttribute() { }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(384), AllowMultiple=true)]
  public partial class UIHintAttribute : System.Attribute {
    public UIHintAttribute(string uiHint) { }
    public UIHintAttribute(string uiHint, string presentationLayer) { }
    public UIHintAttribute(string uiHint, string presentationLayer, params object[] controlParameters) { }
    public System.Collections.Generic.IDictionary<string, object> ControlParameters { get { return default(System.Collections.Generic.IDictionary<string, object>); } }
    public string PresentationLayer { get { return default(string); } }
    public string UIHint { get { return default(string); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(2432), AllowMultiple=false)]
  public sealed partial class UrlAttribute : System.ComponentModel.DataAnnotations.DataTypeAttribute {
    public UrlAttribute() : base (default(System.ComponentModel.DataAnnotations.DataType)) { }
    public override bool IsValid(object value) { return default(bool); }
  }

  public abstract partial class ValidationAttribute : System.Attribute {
    protected ValidationAttribute() { }
    protected ValidationAttribute(System.Func<string> errorMessageAccessor) { }
    protected ValidationAttribute(string errorMessage) { }
    public string ErrorMessage { get { return default(string); } set { } }
    public string ErrorMessageResourceName { get { return default(string); } set { } }
    public System.Type ErrorMessageResourceType { get { return default(System.Type); } set { } }
    protected string ErrorMessageString { get { return default(string); } }
    public virtual bool RequiresValidationContext { get { return default(bool); } }
    public virtual string FormatErrorMessage(string name) { return default(string); }
    public System.ComponentModel.DataAnnotations.ValidationResult GetValidationResult(object value, System.ComponentModel.DataAnnotations.ValidationContext validationContext) { return default(System.ComponentModel.DataAnnotations.ValidationResult); }
    public virtual bool IsValid(object value) { return default(bool); }
    protected virtual System.ComponentModel.DataAnnotations.ValidationResult IsValid(object value, System.ComponentModel.DataAnnotations.ValidationContext validationContext) { return default(System.ComponentModel.DataAnnotations.ValidationResult); }
    public void Validate(object value, System.ComponentModel.DataAnnotations.ValidationContext validationContext) { }
    public void Validate(object value, string name) { }
  }

  public sealed partial class ValidationContext : System.IServiceProvider {
    public ValidationContext(object instance) { }
    public ValidationContext(object instance, System.Collections.Generic.IDictionary<object, object> items) { }
    public ValidationContext(object instance, System.IServiceProvider serviceProvider, System.Collections.Generic.IDictionary<object, object> items) { }
    public string DisplayName { get { return default(string); } set { } }
    public System.Collections.Generic.IDictionary<object, object> Items { get { return default(System.Collections.Generic.IDictionary<object, object>); } }
    public string MemberName { get { return default(string); } set { } }
    public object ObjectInstance { get { return default(object); } }
    public System.Type ObjectType { get { return default(System.Type); } }
    public object GetService(System.Type serviceType) { return default(object); }
    public void InitializeServiceProvider(System.Func<System.Type, object> serviceProvider) { }
  }

  public partial class ValidationException : System.Exception {
    public ValidationException() { }
    public ValidationException(System.ComponentModel.DataAnnotations.ValidationResult validationResult, System.ComponentModel.DataAnnotations.ValidationAttribute validatingAttribute, object value) { }
    public ValidationException(string message) { }
    public ValidationException(string errorMessage, System.ComponentModel.DataAnnotations.ValidationAttribute validatingAttribute, object value) { }
    public ValidationException(string message, System.Exception innerException) { }
    public System.ComponentModel.DataAnnotations.ValidationAttribute ValidationAttribute { get { return default(System.ComponentModel.DataAnnotations.ValidationAttribute); } }
    public System.ComponentModel.DataAnnotations.ValidationResult ValidationResult { get { return default(System.ComponentModel.DataAnnotations.ValidationResult); } }
    public object Value { get { return default(object); } }
  }

  public partial class ValidationResult {
    public static readonly System.ComponentModel.DataAnnotations.ValidationResult Success;
    protected ValidationResult(System.ComponentModel.DataAnnotations.ValidationResult validationResult) { }
    public ValidationResult(string errorMessage) { }
    public ValidationResult(string errorMessage, System.Collections.Generic.IEnumerable<string> memberNames) { }
    public string ErrorMessage { get { return default(string); } set { } }
    public System.Collections.Generic.IEnumerable<string> MemberNames { get { return default(System.Collections.Generic.IEnumerable<string>); } }
    public override string ToString() { return default(string); }
  }

  public static partial class Validator {
    public static bool TryValidateObject(object instance, System.ComponentModel.DataAnnotations.ValidationContext validationContext, System.Collections.Generic.ICollection<System.ComponentModel.DataAnnotations.ValidationResult> validationResults) { return default(bool); }
    public static bool TryValidateObject(object instance, System.ComponentModel.DataAnnotations.ValidationContext validationContext, System.Collections.Generic.ICollection<System.ComponentModel.DataAnnotations.ValidationResult> validationResults, bool validateAllProperties) { return default(bool); }
    public static bool TryValidateProperty(object value, System.ComponentModel.DataAnnotations.ValidationContext validationContext, System.Collections.Generic.ICollection<System.ComponentModel.DataAnnotations.ValidationResult> validationResults) { return default(bool); }
    public static bool TryValidateValue(object value, System.ComponentModel.DataAnnotations.ValidationContext validationContext, System.Collections.Generic.ICollection<System.ComponentModel.DataAnnotations.ValidationResult> validationResults, System.Collections.Generic.IEnumerable<System.ComponentModel.DataAnnotations.ValidationAttribute> validationAttributes) { return default(bool); }
    public static void ValidateObject(object instance, System.ComponentModel.DataAnnotations.ValidationContext validationContext) { }
    public static void ValidateObject(object instance, System.ComponentModel.DataAnnotations.ValidationContext validationContext, bool validateAllProperties) { }
    public static void ValidateProperty(object value, System.ComponentModel.DataAnnotations.ValidationContext validationContext) { }
    public static void ValidateValue(object value, System.ComponentModel.DataAnnotations.ValidationContext validationContext, System.Collections.Generic.IEnumerable<System.ComponentModel.DataAnnotations.ValidationAttribute> validationAttributes) { }
  }

} // end of System.ComponentModel.DataAnnotations
namespace System.ComponentModel.DataAnnotations.Schema {
  [System.AttributeUsageAttribute((System.AttributeTargets)(384), AllowMultiple=false)]
  public partial class ColumnAttribute : System.Attribute {
    public ColumnAttribute() { }
    public ColumnAttribute(string name) { }
    public string Name { get { return default(string); } }
    public int Order { get { return default(int); } set { } }
    public string TypeName { get { return default(string); } set { } }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false)]
  public partial class ComplexTypeAttribute : System.Attribute {
    public ComplexTypeAttribute() { }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(384), AllowMultiple=false)]
  public partial class DatabaseGeneratedAttribute : System.Attribute {
    public DatabaseGeneratedAttribute(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption databaseGeneratedOption) { }
    public System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption DatabaseGeneratedOption { get { return default(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption); } }
  }

  public enum DatabaseGeneratedOption {
    Computed = 2,
    Identity = 1,
    None = 0,
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(384), AllowMultiple=false)]
  public partial class ForeignKeyAttribute : System.Attribute {
    public ForeignKeyAttribute(string name) { }
    public string Name { get { return default(string); } }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(384), AllowMultiple=false)]
  public partial class InversePropertyAttribute : System.Attribute {
    public InversePropertyAttribute(string property) { }
    public string Property { get { return default(string); } }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(388), AllowMultiple=false)]
  public partial class NotMappedAttribute : System.Attribute {
    public NotMappedAttribute() { }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false)]
  public partial class TableAttribute : System.Attribute {
    public TableAttribute(string name) { }
    public string Name { get { return default(string); } }
    public string Schema { get { return default(string); } set { } }
  }

} // end of System.ComponentModel.DataAnnotations.Schema
namespace System.Data {
  [System.FlagsAttribute]
  public enum CommandBehavior {
    CloseConnection = 32,
    Default = 0,
    KeyInfo = 4,
    SchemaOnly = 2,
    SequentialAccess = 16,
    SingleResult = 1,
    SingleRow = 8,
  }

  public enum CommandType {
    StoredProcedure = 4,
    TableDirect = 512,
    Text = 1,
  }

  [System.FlagsAttribute]
  public enum ConnectionState {
    Broken = 16,
    Closed = 0,
    Connecting = 2,
    Executing = 4,
    Fetching = 8,
    Open = 1,
  }

  public enum DataRowVersion {
    Default = 1536,
  }

  public partial class DataTable {
    internal DataTable() { }
  }

  public enum DbType {
    AnsiString = 0,
    AnsiStringFixedLength = 22,
    Binary = 1,
    Boolean = 3,
    Byte = 2,
    Currency = 4,
    Date = 5,
    DateTime = 6,
    DateTime2 = 26,
    DateTimeOffset = 27,
    Decimal = 7,
    Double = 8,
    Guid = 9,
    Int16 = 10,
    Int32 = 11,
    Int64 = 12,
    Object = 13,
    SByte = 14,
    Single = 15,
    String = 16,
    StringFixedLength = 23,
    Time = 17,
    UInt16 = 18,
    UInt32 = 19,
    UInt64 = 20,
    VarNumeric = 21,
    Xml = 25,
  }

  public partial interface IDataParameter {
    System.Data.DbType DbType { get; set; }
    System.Data.ParameterDirection Direction { get; set; }
    bool IsNullable { get; }
    string ParameterName { get; set; }
    string SourceColumn { get; set; }
    System.Data.DataRowVersion SourceVersion { get; set; }
    object Value { get; set; }
  }

  public partial interface IDataParameterCollection : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList {
    object this[string parameterName] { get; set; }
    bool Contains(string parameterName);
    int IndexOf(string parameterName);
    void RemoveAt(string parameterName);
  }

  public partial interface IDataReader : System.Data.IDataRecord, System.IDisposable {
    int Depth { get; }
    bool IsClosed { get; }
    int RecordsAffected { get; }
    void Close();
    System.Data.DataTable GetSchemaTable();
    bool NextResult();
    bool Read();
  }

  public partial interface IDataRecord {
    int FieldCount { get; }
    object this[int i] { get; }
    object this[string name] { get; }
    bool GetBoolean(int i);
    byte GetByte(int i);
    long GetBytes(int i, long fieldOffset, byte[] buffer, int bufferoffset, int length);
    char GetChar(int i);
    long GetChars(int i, long fieldoffset, char[] buffer, int bufferoffset, int length);
    System.Data.IDataReader GetData(int i);
    string GetDataTypeName(int i);
    System.DateTime GetDateTime(int i);
    decimal GetDecimal(int i);
    double GetDouble(int i);
    System.Type GetFieldType(int i);
    float GetFloat(int i);
    System.Guid GetGuid(int i);
    short GetInt16(int i);
    int GetInt32(int i);
    long GetInt64(int i);
    string GetName(int i);
    int GetOrdinal(string name);
    string GetString(int i);
    object GetValue(int i);
    int GetValues(object[] values);
    bool IsDBNull(int i);
  }

  public partial interface IDbCommand : System.IDisposable {
    string CommandText { get; set; }
    int CommandTimeout { get; set; }
    System.Data.CommandType CommandType { get; set; }
    System.Data.IDbConnection Connection { get; set; }
    System.Data.IDataParameterCollection Parameters { get; }
    System.Data.IDbTransaction Transaction { get; set; }
    System.Data.UpdateRowSource UpdatedRowSource { get; set; }
    void Cancel();
    System.Data.IDbDataParameter CreateParameter();
    int ExecuteNonQuery();
    System.Data.IDataReader ExecuteReader();
    System.Data.IDataReader ExecuteReader(System.Data.CommandBehavior behavior);
    object ExecuteScalar();
    void Prepare();
  }

  public partial interface IDbConnection : System.IDisposable {
    string ConnectionString { get; set; }
    int ConnectionTimeout { get; }
    string Database { get; }
    System.Data.ConnectionState State { get; }
    System.Data.IDbTransaction BeginTransaction();
    System.Data.IDbTransaction BeginTransaction(System.Data.IsolationLevel il);
    void ChangeDatabase(string databaseName);
    void Close();
    System.Data.IDbCommand CreateCommand();
    void Open();
  }

  public partial interface IDbDataParameter : System.Data.IDataParameter {
    byte Precision { get; set; }
    byte Scale { get; set; }
    int Size { get; set; }
  }

  public partial interface IDbTransaction : System.IDisposable {
    System.Data.IDbConnection Connection { get; }
    System.Data.IsolationLevel IsolationLevel { get; }
    void Commit();
    void Rollback();
  }

  public enum IsolationLevel {
    Chaos = 16,
    ReadCommitted = 4096,
    ReadUncommitted = 256,
    RepeatableRead = 65536,
    Serializable = 1048576,
    Snapshot = 16777216,
    Unspecified = -1,
  }

  public enum ParameterDirection {
    Input = 1,
    InputOutput = 3,
    Output = 2,
    ReturnValue = 6,
  }

  public sealed partial class StateChangeEventArgs : System.EventArgs {
    public StateChangeEventArgs(System.Data.ConnectionState originalState, System.Data.ConnectionState currentState) { }
    public System.Data.ConnectionState CurrentState { get { return default(System.Data.ConnectionState); } }
    public System.Data.ConnectionState OriginalState { get { return default(System.Data.ConnectionState); } }
  }

  public delegate void StateChangeEventHandler(object sender, System.Data.StateChangeEventArgs e);

  public enum UpdateRowSource {
    Both = 3,
    FirstReturnedRecord = 2,
    None = 0,
    OutputParameters = 1,
  }

  public enum SqlDbType {
    BigInt = 0,
    Binary = 1,
    Bit = 2,
    Char = 3,
    Date = 31,
    DateTime = 4,
    DateTime2 = 33,
    DateTimeOffset = 34,
    Decimal = 5,
    Float = 6,
    Image = 7,
    Int = 8,
    Money = 9,
    NChar = 10,
    NText = 11,
    NVarChar = 12,
    Real = 13,
    SmallDateTime = 15,
    SmallInt = 16,
    SmallMoney = 17,
    Structured = 30,
    Text = 18,
    Time = 32,
    Timestamp = 19,
    TinyInt = 20,
    Udt = 29,
    UniqueIdentifier = 14,
    VarBinary = 21,
    VarChar = 22,
    Variant = 23,
    Xml = 25,
  }

  public sealed partial class StatementCompletedEventArgs : System.EventArgs {
    public StatementCompletedEventArgs(int recordCount) { }
    public int RecordCount { get { return default(int); } }
  }

  public delegate void StatementCompletedEventHandler(object sender, System.Data.StatementCompletedEventArgs e);

} // end of System.Data
namespace System.Data.Common {
  public abstract partial class DbColumn {
    protected DbColumn() { }
    public System.Nullable<bool> AllowDBNull { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<bool>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    public string BaseCatalogName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    public string BaseColumnName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    public string BaseSchemaName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    public string BaseServerName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    public string BaseTableName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    public string ColumnName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    public System.Nullable<int> ColumnOrdinal { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<int>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    public System.Nullable<int> ColumnSize { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<int>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    public System.Type DataType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    public string DataTypeName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    public System.Nullable<bool> IsAliased { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<bool>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    public System.Nullable<bool> IsAutoIncrement { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<bool>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    public System.Nullable<bool> IsExpression { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<bool>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    public System.Nullable<bool> IsHidden { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<bool>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    public System.Nullable<bool> IsIdentity { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<bool>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    public System.Nullable<bool> IsKey { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<bool>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    public System.Nullable<bool> IsLong { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<bool>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    public System.Nullable<bool> IsReadOnly { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<bool>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    public System.Nullable<bool> IsUnique { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<bool>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    public virtual object this[string property] { get { return default(object); } }
    public System.Nullable<int> NumericPrecision { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<int>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    public System.Nullable<int> NumericScale { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<int>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    public string UdtAssemblyQualifiedName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
  }

  public abstract partial class DbCommand : System.Data.IDbCommand, System.IDisposable {
    protected DbCommand() { }
    public abstract string CommandText { get; set; }
    public abstract int CommandTimeout { get; set; }
    public abstract System.Data.CommandType CommandType { get; set; }
    public System.Data.Common.DbConnection Connection { get { return default(System.Data.Common.DbConnection); } set { } }
    protected abstract System.Data.Common.DbConnection DbConnection { get; set; }
    protected abstract System.Data.Common.DbParameterCollection DbParameterCollection { get; }
    protected abstract System.Data.Common.DbTransaction DbTransaction { get; set; }
    public abstract bool DesignTimeVisible { get; set; }
    public System.Data.Common.DbParameterCollection Parameters { get { return default(System.Data.Common.DbParameterCollection); } }
    System.Data.IDbConnection System.Data.IDbCommand.Connection { get { return default(System.Data.IDbConnection); } set { } }
    System.Data.IDataParameterCollection System.Data.IDbCommand.Parameters { get { return default(System.Data.IDataParameterCollection); } }
    System.Data.IDbTransaction System.Data.IDbCommand.Transaction { get { return default(System.Data.IDbTransaction); } set { } }
    public System.Data.Common.DbTransaction Transaction { get { return default(System.Data.Common.DbTransaction); } set { } }
    public abstract System.Data.UpdateRowSource UpdatedRowSource { get; set; }
    public abstract void Cancel();
    protected abstract System.Data.Common.DbParameter CreateDbParameter();
    public System.Data.Common.DbParameter CreateParameter() { return default(System.Data.Common.DbParameter); }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    protected abstract System.Data.Common.DbDataReader ExecuteDbDataReader(System.Data.CommandBehavior behavior);
    protected virtual System.Threading.Tasks.Task<System.Data.Common.DbDataReader> ExecuteDbDataReaderAsync(System.Data.CommandBehavior behavior, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<System.Data.Common.DbDataReader>); }
    public abstract int ExecuteNonQuery();
    public System.Threading.Tasks.Task<int> ExecuteNonQueryAsync() { return default(System.Threading.Tasks.Task<int>); }
    public virtual System.Threading.Tasks.Task<int> ExecuteNonQueryAsync(System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<int>); }
    public System.Data.Common.DbDataReader ExecuteReader() { return default(System.Data.Common.DbDataReader); }
    public System.Data.Common.DbDataReader ExecuteReader(System.Data.CommandBehavior behavior) { return default(System.Data.Common.DbDataReader); }
    public System.Threading.Tasks.Task<System.Data.Common.DbDataReader> ExecuteReaderAsync() { return default(System.Threading.Tasks.Task<System.Data.Common.DbDataReader>); }
    public System.Threading.Tasks.Task<System.Data.Common.DbDataReader> ExecuteReaderAsync(System.Data.CommandBehavior behavior) { return default(System.Threading.Tasks.Task<System.Data.Common.DbDataReader>); }
    public System.Threading.Tasks.Task<System.Data.Common.DbDataReader> ExecuteReaderAsync(System.Data.CommandBehavior behavior, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<System.Data.Common.DbDataReader>); }
    public System.Threading.Tasks.Task<System.Data.Common.DbDataReader> ExecuteReaderAsync(System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<System.Data.Common.DbDataReader>); }
    public abstract object ExecuteScalar();
    public System.Threading.Tasks.Task<object> ExecuteScalarAsync() { return default(System.Threading.Tasks.Task<object>); }
    public virtual System.Threading.Tasks.Task<object> ExecuteScalarAsync(System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<object>); }
    public abstract void Prepare();
    System.Data.IDbDataParameter System.Data.IDbCommand.CreateParameter() { return default(System.Data.IDbDataParameter); }
    System.Data.IDataReader System.Data.IDbCommand.ExecuteReader() { return default(System.Data.IDataReader); }
    System.Data.IDataReader System.Data.IDbCommand.ExecuteReader(System.Data.CommandBehavior behavior) { return default(System.Data.IDataReader); }
  }

  public abstract partial class DbConnection : System.Data.IDbConnection, System.IDisposable {
    protected DbConnection() { }
    public abstract string ConnectionString { get; set; }
    public virtual int ConnectionTimeout { get { return default(int); } }
    public abstract string Database { get; }
    public abstract string DataSource { get; }
    public abstract string ServerVersion { get; }
    public abstract System.Data.ConnectionState State { get; }
    public virtual event System.Data.StateChangeEventHandler StateChange { add { } remove { } }
    protected abstract System.Data.Common.DbTransaction BeginDbTransaction(System.Data.IsolationLevel isolationLevel);
    public System.Data.Common.DbTransaction BeginTransaction() { return default(System.Data.Common.DbTransaction); }
    public System.Data.Common.DbTransaction BeginTransaction(System.Data.IsolationLevel isolationLevel) { return default(System.Data.Common.DbTransaction); }
    public abstract void ChangeDatabase(string databaseName);
    public abstract void Close();
    public System.Data.Common.DbCommand CreateCommand() { return default(System.Data.Common.DbCommand); }
    protected abstract System.Data.Common.DbCommand CreateDbCommand();
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    protected virtual void OnStateChange(System.Data.StateChangeEventArgs stateChange) { }
    public abstract void Open();
    public System.Threading.Tasks.Task OpenAsync() { return default(System.Threading.Tasks.Task); }
    public virtual System.Threading.Tasks.Task OpenAsync(System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task); }
    System.Data.IDbTransaction System.Data.IDbConnection.BeginTransaction() { return default(System.Data.IDbTransaction); }
    System.Data.IDbTransaction System.Data.IDbConnection.BeginTransaction(System.Data.IsolationLevel isolationLevel) { return default(System.Data.IDbTransaction); }
    System.Data.IDbCommand System.Data.IDbConnection.CreateCommand() { return default(System.Data.IDbCommand); }
  }

  public partial class DbConnectionStringBuilder : System.Collections.ICollection, System.Collections.IDictionary, System.Collections.IEnumerable {
    public DbConnectionStringBuilder() { }
    public string ConnectionString { get { return default(string); } set { } }
    public virtual int Count { get { return default(int); } }
    public virtual object this[string keyword] { get { return default(object); } set { } }
    public virtual System.Collections.ICollection Keys { get { return default(System.Collections.ICollection); } }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    bool System.Collections.IDictionary.IsFixedSize { get { return default(bool); } }
    bool System.Collections.IDictionary.IsReadOnly { get { return default(bool); } }
    object System.Collections.IDictionary.this[object keyword] { get { return default(object); } set { } }
    public virtual System.Collections.ICollection Values { get { return default(System.Collections.ICollection); } }
    public void Add(string keyword, object value) { }
    public static void AppendKeyValuePair(System.Text.StringBuilder builder, string keyword, string value) { }
    public virtual void Clear() { }
    public virtual bool ContainsKey(string keyword) { return default(bool); }
    public virtual bool EquivalentTo(System.Data.Common.DbConnectionStringBuilder connectionStringBuilder) { return default(bool); }
    public virtual bool Remove(string keyword) { return default(bool); }
    public virtual bool ShouldSerialize(string keyword) { return default(bool); }
    void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
    void System.Collections.IDictionary.Add(object keyword, object value) { }
    bool System.Collections.IDictionary.Contains(object keyword) { return default(bool); }
    System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { return default(System.Collections.IDictionaryEnumerator); }
    void System.Collections.IDictionary.Remove(object keyword) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    public override string ToString() { return default(string); }
    public virtual bool TryGetValue(string keyword, out object value) { value = default(object); return default(bool); }
  }

  public abstract partial class DbDataReader : System.Collections.IEnumerable, System.Data.IDataReader, System.Data.IDataRecord, System.IDisposable {
    protected DbDataReader() { }
    public abstract int Depth { get; }
    public abstract int FieldCount { get; }
    public abstract bool HasRows { get; }
    public abstract bool IsClosed { get; }
    public abstract object this[int ordinal] { get; }
    public abstract object this[string name] { get; }
    public abstract int RecordsAffected { get; }
    public virtual int VisibleFieldCount { get { return default(int); } }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public abstract bool GetBoolean(int ordinal);
    public abstract byte GetByte(int ordinal);
    public abstract long GetBytes(int ordinal, long dataOffset, byte[] buffer, int bufferOffset, int length);
    public abstract char GetChar(int ordinal);
    public abstract long GetChars(int ordinal, long dataOffset, char[] buffer, int bufferOffset, int length);
    public System.Data.Common.DbDataReader GetData(int ordinal) { return default(System.Data.Common.DbDataReader); }
    public abstract string GetDataTypeName(int ordinal);
    public abstract System.DateTime GetDateTime(int ordinal);
    protected virtual System.Data.Common.DbDataReader GetDbDataReader(int ordinal) { return default(System.Data.Common.DbDataReader); }
    public abstract decimal GetDecimal(int ordinal);
    public abstract double GetDouble(int ordinal);
    public abstract System.Collections.IEnumerator GetEnumerator();
    public abstract System.Type GetFieldType(int ordinal);
    public virtual T GetFieldValue<T>(int ordinal) { return default(T); }
    public System.Threading.Tasks.Task<T> GetFieldValueAsync<T>(int ordinal) { return default(System.Threading.Tasks.Task<T>); }
    public virtual System.Threading.Tasks.Task<T> GetFieldValueAsync<T>(int ordinal, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<T>); }
    public abstract float GetFloat(int ordinal);
    public abstract System.Guid GetGuid(int ordinal);
    public abstract short GetInt16(int ordinal);
    public abstract int GetInt32(int ordinal);
    public abstract long GetInt64(int ordinal);
    public abstract string GetName(int ordinal);
    public abstract int GetOrdinal(string name);
    public virtual System.Type GetProviderSpecificFieldType(int ordinal) { return default(System.Type); }
    public virtual object GetProviderSpecificValue(int ordinal) { return default(object); }
    public virtual int GetProviderSpecificValues(object[] values) { return default(int); }
    public virtual System.IO.Stream GetStream(int ordinal) { return default(System.IO.Stream); }
    public abstract string GetString(int ordinal);
    public virtual System.IO.TextReader GetTextReader(int ordinal) { return default(System.IO.TextReader); }
    public abstract object GetValue(int ordinal);
    public abstract int GetValues(object[] values);
    public abstract bool IsDBNull(int ordinal);
    public System.Threading.Tasks.Task<bool> IsDBNullAsync(int ordinal) { return default(System.Threading.Tasks.Task<bool>); }
    public virtual System.Threading.Tasks.Task<bool> IsDBNullAsync(int ordinal, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<bool>); }
    public abstract bool NextResult();
    public System.Threading.Tasks.Task<bool> NextResultAsync() { return default(System.Threading.Tasks.Task<bool>); }
    public virtual System.Threading.Tasks.Task<bool> NextResultAsync(System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<bool>); }
    public abstract bool Read();
    public System.Threading.Tasks.Task<bool> ReadAsync() { return default(System.Threading.Tasks.Task<bool>); }
    public virtual System.Threading.Tasks.Task<bool> ReadAsync(System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<bool>); }
    void System.Data.IDataReader.Close() { }
    System.Data.DataTable System.Data.IDataReader.GetSchemaTable() { return default(System.Data.DataTable); }
    System.Data.IDataReader System.Data.IDataRecord.GetData(int ordinal) { return default(System.Data.IDataReader); }
  }

  public static partial class DbDataReaderExtensions {
    public static bool CanGetColumnSchema(this System.Data.Common.DbDataReader reader) { return default(bool); }
    public static System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Common.DbColumn> GetColumnSchema(this System.Data.Common.DbDataReader reader) { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Common.DbColumn>); }
  }

  public abstract partial class DbDataRecord : System.Data.IDataRecord {
    protected DbDataRecord() { }
    public abstract int FieldCount { get; }
    public abstract object this[int i] { get; }
    public abstract object this[string name] { get; }
    public abstract bool GetBoolean(int i);
    public abstract byte GetByte(int i);
    public abstract long GetBytes(int i, long dataIndex, byte[] buffer, int bufferIndex, int length);
    public abstract char GetChar(int i);
    public abstract long GetChars(int i, long dataIndex, char[] buffer, int bufferIndex, int length);
    public System.Data.IDataReader GetData(int i) { return default(System.Data.IDataReader); }
    public abstract string GetDataTypeName(int i);
    public abstract System.DateTime GetDateTime(int i);
    protected virtual System.Data.Common.DbDataReader GetDbDataReader(int i) { return default(System.Data.Common.DbDataReader); }
    public abstract decimal GetDecimal(int i);
    public abstract double GetDouble(int i);
    public abstract System.Type GetFieldType(int i);
    public abstract float GetFloat(int i);
    public abstract System.Guid GetGuid(int i);
    public abstract short GetInt16(int i);
    public abstract int GetInt32(int i);
    public abstract long GetInt64(int i);
    public abstract string GetName(int i);
    public abstract int GetOrdinal(string name);
    public abstract string GetString(int i);
    public abstract object GetValue(int i);
    public abstract int GetValues(object[] values);
    public abstract bool IsDBNull(int i);
  }

  public partial class DbEnumerator : System.Collections.IEnumerator {
    public DbEnumerator(System.Data.IDataReader reader, bool closeReader) { }
    public object Current { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } }
    public bool MoveNext() { return default(bool); }
    public void Reset() { }
  }

  public abstract partial class DbException : System.Exception {
    protected DbException() { }
    protected DbException(string message) { }
    protected DbException(string message, System.Exception innerException) { }
  }

  public abstract partial class DbParameter : System.Data.IDataParameter, System.Data.IDbDataParameter {
    protected DbParameter() { }
    public abstract System.Data.DbType DbType { get; set; }
    public abstract System.Data.ParameterDirection Direction { get; set; }
    public abstract bool IsNullable { get; set; }
    public abstract string ParameterName { get; set; }
    public virtual byte Precision { get { return default(byte); } set { } }
    public virtual byte Scale { get { return default(byte); } set { } }
    public abstract int Size { get; set; }
    public abstract string SourceColumn { get; set; }
    public abstract bool SourceColumnNullMapping { get; set; }
    System.Data.DataRowVersion System.Data.IDataParameter.SourceVersion { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Data.DataRowVersion); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    byte System.Data.IDbDataParameter.Precision { get { return default(byte); } set { } }
    byte System.Data.IDbDataParameter.Scale { get { return default(byte); } set { } }
    public abstract object Value { get; set; }
    public abstract void ResetDbType();
  }

  public abstract partial class DbParameterCollection : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.Data.IDataParameterCollection {
    protected DbParameterCollection() { }
    public abstract int Count { get; }
    public System.Data.Common.DbParameter this[int index] { get { return default(System.Data.Common.DbParameter); } set { } }
    public System.Data.Common.DbParameter this[string parameterName] { get { return default(System.Data.Common.DbParameter); } set { } }
    public abstract object SyncRoot { get; }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    bool System.Collections.IList.IsFixedSize { get { return default(bool); } }
    bool System.Collections.IList.IsReadOnly { get { return default(bool); } }
    object System.Collections.IList.this[int index] { get { return default(object); } set { } }
    object System.Data.IDataParameterCollection.this[string parameterName] { get { return default(object); } set { } }
    public abstract int Add(object value);
    public abstract void AddRange(System.Array values);
    public abstract void Clear();
    public abstract bool Contains(object value);
    public abstract bool Contains(string value);
    public abstract void CopyTo(System.Array array, int index);
    public abstract System.Collections.IEnumerator GetEnumerator();
    protected abstract System.Data.Common.DbParameter GetParameter(int index);
    protected abstract System.Data.Common.DbParameter GetParameter(string parameterName);
    public abstract int IndexOf(object value);
    public abstract int IndexOf(string parameterName);
    public abstract void Insert(int index, object value);
    public abstract void Remove(object value);
    public abstract void RemoveAt(int index);
    public abstract void RemoveAt(string parameterName);
    protected abstract void SetParameter(int index, System.Data.Common.DbParameter value);
    protected abstract void SetParameter(string parameterName, System.Data.Common.DbParameter value);
  }

  public abstract partial class DbProviderFactory {
    protected DbProviderFactory() { }
    public virtual System.Data.Common.DbCommand CreateCommand() { return default(System.Data.Common.DbCommand); }
    public virtual System.Data.Common.DbConnection CreateConnection() { return default(System.Data.Common.DbConnection); }
    public virtual System.Data.Common.DbConnectionStringBuilder CreateConnectionStringBuilder() { return default(System.Data.Common.DbConnectionStringBuilder); }
    public virtual System.Data.Common.DbParameter CreateParameter() { return default(System.Data.Common.DbParameter); }
  }

  public abstract partial class DbTransaction : System.Data.IDbTransaction, System.IDisposable {
    protected DbTransaction() { }
    public System.Data.Common.DbConnection Connection { get { return default(System.Data.Common.DbConnection); } }
    protected abstract System.Data.Common.DbConnection DbConnection { get; }
    public abstract System.Data.IsolationLevel IsolationLevel { get; }
    System.Data.IDbConnection System.Data.IDbTransaction.Connection { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Data.IDbConnection); } }
    public abstract void Commit();
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public abstract void Rollback();
  }

  public partial interface IDbColumnSchemaGenerator {
    System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Common.DbColumn> GetColumnSchema();
  }

} // end of System.Data.Common
namespace Microsoft.SqlServer.Server {
  public partial class SqlDataRecord {
    public SqlDataRecord(params Microsoft.SqlServer.Server.SqlMetaData[] metaData) { }
    public virtual int FieldCount { get { return default(int); } }
    public virtual object this[int ordinal] { get { return default(object); } }
    public virtual object this[string name] { get { return default(object); } }
    public virtual bool GetBoolean(int ordinal) { return default(bool); }
    public virtual byte GetByte(int ordinal) { return default(byte); }
    public virtual long GetBytes(int ordinal, long fieldOffset, byte[] buffer, int bufferOffset, int length) { return default(long); }
    public virtual char GetChar(int ordinal) { return default(char); }
    public virtual long GetChars(int ordinal, long fieldOffset, char[] buffer, int bufferOffset, int length) { return default(long); }
    public virtual string GetDataTypeName(int ordinal) { return default(string); }
    public virtual System.DateTime GetDateTime(int ordinal) { return default(System.DateTime); }
    public virtual System.DateTimeOffset GetDateTimeOffset(int ordinal) { return default(System.DateTimeOffset); }
    public virtual decimal GetDecimal(int ordinal) { return default(decimal); }
    public virtual double GetDouble(int ordinal) { return default(double); }
    public virtual System.Type GetFieldType(int ordinal) { return default(System.Type); }
    public virtual float GetFloat(int ordinal) { return default(float); }
    public virtual System.Guid GetGuid(int ordinal) { return default(System.Guid); }
    public virtual short GetInt16(int ordinal) { return default(short); }
    public virtual int GetInt32(int ordinal) { return default(int); }
    public virtual long GetInt64(int ordinal) { return default(long); }
    public virtual string GetName(int ordinal) { return default(string); }
    public virtual int GetOrdinal(string name) { return default(int); }
    public virtual System.Data.SqlTypes.SqlBinary GetSqlBinary(int ordinal) { return default(System.Data.SqlTypes.SqlBinary); }
    public virtual System.Data.SqlTypes.SqlBoolean GetSqlBoolean(int ordinal) { return default(System.Data.SqlTypes.SqlBoolean); }
    public virtual System.Data.SqlTypes.SqlByte GetSqlByte(int ordinal) { return default(System.Data.SqlTypes.SqlByte); }
    public virtual System.Data.SqlTypes.SqlBytes GetSqlBytes(int ordinal) { return default(System.Data.SqlTypes.SqlBytes); }
    public virtual System.Data.SqlTypes.SqlChars GetSqlChars(int ordinal) { return default(System.Data.SqlTypes.SqlChars); }
    public virtual System.Data.SqlTypes.SqlDateTime GetSqlDateTime(int ordinal) { return default(System.Data.SqlTypes.SqlDateTime); }
    public virtual System.Data.SqlTypes.SqlDecimal GetSqlDecimal(int ordinal) { return default(System.Data.SqlTypes.SqlDecimal); }
    public virtual System.Data.SqlTypes.SqlDouble GetSqlDouble(int ordinal) { return default(System.Data.SqlTypes.SqlDouble); }
    public virtual System.Type GetSqlFieldType(int ordinal) { return default(System.Type); }
    public virtual System.Data.SqlTypes.SqlGuid GetSqlGuid(int ordinal) { return default(System.Data.SqlTypes.SqlGuid); }
    public virtual System.Data.SqlTypes.SqlInt16 GetSqlInt16(int ordinal) { return default(System.Data.SqlTypes.SqlInt16); }
    public virtual System.Data.SqlTypes.SqlInt32 GetSqlInt32(int ordinal) { return default(System.Data.SqlTypes.SqlInt32); }
    public virtual System.Data.SqlTypes.SqlInt64 GetSqlInt64(int ordinal) { return default(System.Data.SqlTypes.SqlInt64); }
    public virtual Microsoft.SqlServer.Server.SqlMetaData GetSqlMetaData(int ordinal) { return default(Microsoft.SqlServer.Server.SqlMetaData); }
    public virtual System.Data.SqlTypes.SqlMoney GetSqlMoney(int ordinal) { return default(System.Data.SqlTypes.SqlMoney); }
    public virtual System.Data.SqlTypes.SqlSingle GetSqlSingle(int ordinal) { return default(System.Data.SqlTypes.SqlSingle); }
    public virtual System.Data.SqlTypes.SqlString GetSqlString(int ordinal) { return default(System.Data.SqlTypes.SqlString); }
    public virtual object GetSqlValue(int ordinal) { return default(object); }
    public virtual int GetSqlValues(object[] values) { return default(int); }
    public virtual System.Data.SqlTypes.SqlXml GetSqlXml(int ordinal) { return default(System.Data.SqlTypes.SqlXml); }
    public virtual string GetString(int ordinal) { return default(string); }
    public virtual System.TimeSpan GetTimeSpan(int ordinal) { return default(System.TimeSpan); }
    public virtual object GetValue(int ordinal) { return default(object); }
    public virtual int GetValues(object[] values) { return default(int); }
    public virtual bool IsDBNull(int ordinal) { return default(bool); }
    public virtual void SetBoolean(int ordinal, bool value) { }
    public virtual void SetByte(int ordinal, byte value) { }
    public virtual void SetBytes(int ordinal, long fieldOffset, byte[] buffer, int bufferOffset, int length) { }
    public virtual void SetChar(int ordinal, char value) { }
    public virtual void SetChars(int ordinal, long fieldOffset, char[] buffer, int bufferOffset, int length) { }
    public virtual void SetDateTime(int ordinal, System.DateTime value) { }
    public virtual void SetDateTimeOffset(int ordinal, System.DateTimeOffset value) { }
    public virtual void SetDBNull(int ordinal) { }
    public virtual void SetDecimal(int ordinal, decimal value) { }
    public virtual void SetDouble(int ordinal, double value) { }
    public virtual void SetFloat(int ordinal, float value) { }
    public virtual void SetGuid(int ordinal, System.Guid value) { }
    public virtual void SetInt16(int ordinal, short value) { }
    public virtual void SetInt32(int ordinal, int value) { }
    public virtual void SetInt64(int ordinal, long value) { }
    public virtual void SetSqlBinary(int ordinal, System.Data.SqlTypes.SqlBinary value) { }
    public virtual void SetSqlBoolean(int ordinal, System.Data.SqlTypes.SqlBoolean value) { }
    public virtual void SetSqlByte(int ordinal, System.Data.SqlTypes.SqlByte value) { }
    public virtual void SetSqlBytes(int ordinal, System.Data.SqlTypes.SqlBytes value) { }
    public virtual void SetSqlChars(int ordinal, System.Data.SqlTypes.SqlChars value) { }
    public virtual void SetSqlDateTime(int ordinal, System.Data.SqlTypes.SqlDateTime value) { }
    public virtual void SetSqlDecimal(int ordinal, System.Data.SqlTypes.SqlDecimal value) { }
    public virtual void SetSqlDouble(int ordinal, System.Data.SqlTypes.SqlDouble value) { }
    public virtual void SetSqlGuid(int ordinal, System.Data.SqlTypes.SqlGuid value) { }
    public virtual void SetSqlInt16(int ordinal, System.Data.SqlTypes.SqlInt16 value) { }
    public virtual void SetSqlInt32(int ordinal, System.Data.SqlTypes.SqlInt32 value) { }
    public virtual void SetSqlInt64(int ordinal, System.Data.SqlTypes.SqlInt64 value) { }
    public virtual void SetSqlMoney(int ordinal, System.Data.SqlTypes.SqlMoney value) { }
    public virtual void SetSqlSingle(int ordinal, System.Data.SqlTypes.SqlSingle value) { }
    public virtual void SetSqlString(int ordinal, System.Data.SqlTypes.SqlString value) { }
    public virtual void SetSqlXml(int ordinal, System.Data.SqlTypes.SqlXml value) { }
    public virtual void SetString(int ordinal, string value) { }
    public virtual void SetTimeSpan(int ordinal, System.TimeSpan value) { }
    public virtual void SetValue(int ordinal, object value) { }
    public virtual int SetValues(params object[] values) { return default(int); }
  }

  public sealed partial class SqlMetaData {
    public SqlMetaData(string name, System.Data.SqlDbType dbType) { }
    public SqlMetaData(string name, System.Data.SqlDbType dbType, bool useServerDefault, bool isUniqueKey, System.Data.SqlClient.SortOrder columnSortOrder, int sortOrdinal) { }
    public SqlMetaData(string name, System.Data.SqlDbType dbType, byte precision, byte scale) { }
    public SqlMetaData(string name, System.Data.SqlDbType dbType, byte precision, byte scale, bool useServerDefault, bool isUniqueKey, System.Data.SqlClient.SortOrder columnSortOrder, int sortOrdinal) { }
    public SqlMetaData(string name, System.Data.SqlDbType dbType, long maxLength) { }
    public SqlMetaData(string name, System.Data.SqlDbType dbType, long maxLength, bool useServerDefault, bool isUniqueKey, System.Data.SqlClient.SortOrder columnSortOrder, int sortOrdinal) { }
    public SqlMetaData(string name, System.Data.SqlDbType dbType, long maxLength, byte precision, byte scale, long locale, System.Data.SqlTypes.SqlCompareOptions compareOptions, System.Type userDefinedType) { }
    public SqlMetaData(string name, System.Data.SqlDbType dbType, long maxLength, byte precision, byte scale, long localeId, System.Data.SqlTypes.SqlCompareOptions compareOptions, System.Type userDefinedType, bool useServerDefault, bool isUniqueKey, System.Data.SqlClient.SortOrder columnSortOrder, int sortOrdinal) { }
    public SqlMetaData(string name, System.Data.SqlDbType dbType, long maxLength, long locale, System.Data.SqlTypes.SqlCompareOptions compareOptions) { }
    public SqlMetaData(string name, System.Data.SqlDbType dbType, long maxLength, long locale, System.Data.SqlTypes.SqlCompareOptions compareOptions, bool useServerDefault, bool isUniqueKey, System.Data.SqlClient.SortOrder columnSortOrder, int sortOrdinal) { }
    public SqlMetaData(string name, System.Data.SqlDbType dbType, string database, string owningSchema, string objectName) { }
    public SqlMetaData(string name, System.Data.SqlDbType dbType, string database, string owningSchema, string objectName, bool useServerDefault, bool isUniqueKey, System.Data.SqlClient.SortOrder columnSortOrder, int sortOrdinal) { }
    public System.Data.SqlTypes.SqlCompareOptions CompareOptions { get { return default(System.Data.SqlTypes.SqlCompareOptions); } }
    public bool IsUniqueKey { get { return default(bool); } }
    public long LocaleId { get { return default(long); } }
    public static long Max { get { return default(long); } }
    public long MaxLength { get { return default(long); } }
    public string Name { get { return default(string); } }
    public byte Precision { get { return default(byte); } }
    public byte Scale { get { return default(byte); } }
    public System.Data.SqlClient.SortOrder SortOrder { get { return default(System.Data.SqlClient.SortOrder); } }
    public int SortOrdinal { get { return default(int); } }
    public System.Data.SqlDbType SqlDbType { get { return default(System.Data.SqlDbType); } }
    public string TypeName { get { return default(string); } }
    public bool UseServerDefault { get { return default(bool); } }
    public string XmlSchemaCollectionDatabase { get { return default(string); } }
    public string XmlSchemaCollectionName { get { return default(string); } }
    public string XmlSchemaCollectionOwningSchema { get { return default(string); } }
    public bool Adjust(bool value) { return default(bool); }
    public byte Adjust(byte value) { return default(byte); }
    public byte[] Adjust(byte[] value) { return default(byte[]); }
    public char Adjust(char value) { return default(char); }
    public char[] Adjust(char[] value) { return default(char[]); }
    public System.Data.SqlTypes.SqlBinary Adjust(System.Data.SqlTypes.SqlBinary value) { return default(System.Data.SqlTypes.SqlBinary); }
    public System.Data.SqlTypes.SqlBoolean Adjust(System.Data.SqlTypes.SqlBoolean value) { return default(System.Data.SqlTypes.SqlBoolean); }
    public System.Data.SqlTypes.SqlByte Adjust(System.Data.SqlTypes.SqlByte value) { return default(System.Data.SqlTypes.SqlByte); }
    public System.Data.SqlTypes.SqlBytes Adjust(System.Data.SqlTypes.SqlBytes value) { return default(System.Data.SqlTypes.SqlBytes); }
    public System.Data.SqlTypes.SqlChars Adjust(System.Data.SqlTypes.SqlChars value) { return default(System.Data.SqlTypes.SqlChars); }
    public System.Data.SqlTypes.SqlDateTime Adjust(System.Data.SqlTypes.SqlDateTime value) { return default(System.Data.SqlTypes.SqlDateTime); }
    public System.Data.SqlTypes.SqlDecimal Adjust(System.Data.SqlTypes.SqlDecimal value) { return default(System.Data.SqlTypes.SqlDecimal); }
    public System.Data.SqlTypes.SqlDouble Adjust(System.Data.SqlTypes.SqlDouble value) { return default(System.Data.SqlTypes.SqlDouble); }
    public System.Data.SqlTypes.SqlGuid Adjust(System.Data.SqlTypes.SqlGuid value) { return default(System.Data.SqlTypes.SqlGuid); }
    public System.Data.SqlTypes.SqlInt16 Adjust(System.Data.SqlTypes.SqlInt16 value) { return default(System.Data.SqlTypes.SqlInt16); }
    public System.Data.SqlTypes.SqlInt32 Adjust(System.Data.SqlTypes.SqlInt32 value) { return default(System.Data.SqlTypes.SqlInt32); }
    public System.Data.SqlTypes.SqlInt64 Adjust(System.Data.SqlTypes.SqlInt64 value) { return default(System.Data.SqlTypes.SqlInt64); }
    public System.Data.SqlTypes.SqlMoney Adjust(System.Data.SqlTypes.SqlMoney value) { return default(System.Data.SqlTypes.SqlMoney); }
    public System.Data.SqlTypes.SqlSingle Adjust(System.Data.SqlTypes.SqlSingle value) { return default(System.Data.SqlTypes.SqlSingle); }
    public System.Data.SqlTypes.SqlString Adjust(System.Data.SqlTypes.SqlString value) { return default(System.Data.SqlTypes.SqlString); }
    public System.Data.SqlTypes.SqlXml Adjust(System.Data.SqlTypes.SqlXml value) { return default(System.Data.SqlTypes.SqlXml); }
    public System.DateTime Adjust(System.DateTime value) { return default(System.DateTime); }
    public System.DateTimeOffset Adjust(System.DateTimeOffset value) { return default(System.DateTimeOffset); }
    public decimal Adjust(decimal value) { return default(decimal); }
    public double Adjust(double value) { return default(double); }
    public System.Guid Adjust(System.Guid value) { return default(System.Guid); }
    public short Adjust(short value) { return default(short); }
    public int Adjust(int value) { return default(int); }
    public long Adjust(long value) { return default(long); }
    public object Adjust(object value) { return default(object); }
    public float Adjust(float value) { return default(float); }
    public string Adjust(string value) { return default(string); }
    public System.TimeSpan Adjust(System.TimeSpan value) { return default(System.TimeSpan); }
    public static Microsoft.SqlServer.Server.SqlMetaData InferFromValue(object value, string name) { return default(Microsoft.SqlServer.Server.SqlMetaData); }
  }

} // end of Microsoft.SqlServer.Server
namespace System.Data.SqlClient {
  public enum ApplicationIntent {
    ReadOnly = 1,
    ReadWrite = 0,
  }

  public enum SortOrder {
    Ascending = 0,
    Descending = 1,
    Unspecified = -1,
  }

  public sealed partial class SqlBulkCopy : System.IDisposable {
    public SqlBulkCopy(System.Data.SqlClient.SqlConnection connection) { }
    public SqlBulkCopy(System.Data.SqlClient.SqlConnection connection, System.Data.SqlClient.SqlBulkCopyOptions copyOptions, System.Data.SqlClient.SqlTransaction externalTransaction) { }
    public SqlBulkCopy(string connectionString) { }
    public SqlBulkCopy(string connectionString, System.Data.SqlClient.SqlBulkCopyOptions copyOptions) { }
    public int BatchSize { get { return default(int); } set { } }
    public int BulkCopyTimeout { get { return default(int); } set { } }
    public System.Data.SqlClient.SqlBulkCopyColumnMappingCollection ColumnMappings { get { return default(System.Data.SqlClient.SqlBulkCopyColumnMappingCollection); } }
    public string DestinationTableName { get { return default(string); } set { } }
    public bool EnableStreaming { get { return default(bool); } set { } }
    public int NotifyAfter { get { return default(int); } set { } }
    public event System.Data.SqlClient.SqlRowsCopiedEventHandler SqlRowsCopied { add { } remove { } }
    public void Close() { }
    void System.IDisposable.Dispose() { }
    public void WriteToServer(System.Data.Common.DbDataReader reader) { }
    public System.Threading.Tasks.Task WriteToServerAsync(System.Data.Common.DbDataReader reader) { return default(System.Threading.Tasks.Task); }
    public System.Threading.Tasks.Task WriteToServerAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task); }
  }

  public sealed partial class SqlBulkCopyColumnMapping {
    public SqlBulkCopyColumnMapping() { }
    public SqlBulkCopyColumnMapping(int sourceColumnOrdinal, int destinationOrdinal) { }
    public SqlBulkCopyColumnMapping(int sourceColumnOrdinal, string destinationColumn) { }
    public SqlBulkCopyColumnMapping(string sourceColumn, int destinationOrdinal) { }
    public SqlBulkCopyColumnMapping(string sourceColumn, string destinationColumn) { }
    public string DestinationColumn { get { return default(string); } set { } }
    public int DestinationOrdinal { get { return default(int); } set { } }
    public string SourceColumn { get { return default(string); } set { } }
    public int SourceOrdinal { get { return default(int); } set { } }
  }

  public sealed partial class SqlBulkCopyColumnMappingCollection : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList {
    internal SqlBulkCopyColumnMappingCollection() { }
    public int Count { get { return default(int); } }
    public System.Data.SqlClient.SqlBulkCopyColumnMapping this[int index] { get { return default(System.Data.SqlClient.SqlBulkCopyColumnMapping); } }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    bool System.Collections.IList.IsFixedSize { get { return default(bool); } }
    bool System.Collections.IList.IsReadOnly { get { return default(bool); } }
    object System.Collections.IList.this[int index] { get { return default(object); } set { } }
    public System.Data.SqlClient.SqlBulkCopyColumnMapping Add(System.Data.SqlClient.SqlBulkCopyColumnMapping bulkCopyColumnMapping) { return default(System.Data.SqlClient.SqlBulkCopyColumnMapping); }
    public System.Data.SqlClient.SqlBulkCopyColumnMapping Add(int sourceColumnIndex, int destinationColumnIndex) { return default(System.Data.SqlClient.SqlBulkCopyColumnMapping); }
    public System.Data.SqlClient.SqlBulkCopyColumnMapping Add(int sourceColumnIndex, string destinationColumn) { return default(System.Data.SqlClient.SqlBulkCopyColumnMapping); }
    public System.Data.SqlClient.SqlBulkCopyColumnMapping Add(string sourceColumn, int destinationColumnIndex) { return default(System.Data.SqlClient.SqlBulkCopyColumnMapping); }
    public System.Data.SqlClient.SqlBulkCopyColumnMapping Add(string sourceColumn, string destinationColumn) { return default(System.Data.SqlClient.SqlBulkCopyColumnMapping); }
    public void Clear() { }
    public bool Contains(System.Data.SqlClient.SqlBulkCopyColumnMapping value) { return default(bool); }
    public void CopyTo(System.Data.SqlClient.SqlBulkCopyColumnMapping[] array, int index) { }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public int IndexOf(System.Data.SqlClient.SqlBulkCopyColumnMapping value) { return default(int); }
    public void Insert(int index, System.Data.SqlClient.SqlBulkCopyColumnMapping value) { }
    public void Remove(System.Data.SqlClient.SqlBulkCopyColumnMapping value) { }
    public void RemoveAt(int index) { }
    void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
    int System.Collections.IList.Add(object value) { return default(int); }
    bool System.Collections.IList.Contains(object value) { return default(bool); }
    int System.Collections.IList.IndexOf(object value) { return default(int); }
    void System.Collections.IList.Insert(int index, object value) { }
    void System.Collections.IList.Remove(object value) { }
  }

  [System.FlagsAttribute]
  public enum SqlBulkCopyOptions {
    CheckConstraints = 2,
    Default = 0,
    FireTriggers = 16,
    KeepIdentity = 1,
    KeepNulls = 8,
    TableLock = 4,
    UseInternalTransaction = 32,
  }

  public sealed partial class SqlClientFactory : System.Data.Common.DbProviderFactory {
    internal SqlClientFactory() { }
    public static readonly System.Data.SqlClient.SqlClientFactory Instance;
    public override System.Data.Common.DbCommand CreateCommand() { return default(System.Data.Common.DbCommand); }
    public override System.Data.Common.DbConnection CreateConnection() { return default(System.Data.Common.DbConnection); }
    public override System.Data.Common.DbConnectionStringBuilder CreateConnectionStringBuilder() { return default(System.Data.Common.DbConnectionStringBuilder); }
    public override System.Data.Common.DbParameter CreateParameter() { return default(System.Data.Common.DbParameter); }
  }

  public sealed partial class SqlCommand : System.Data.Common.DbCommand {
    public SqlCommand() { }
    public SqlCommand(string cmdText) { }
    public SqlCommand(string cmdText, System.Data.SqlClient.SqlConnection connection) { }
    public SqlCommand(string cmdText, System.Data.SqlClient.SqlConnection connection, System.Data.SqlClient.SqlTransaction transaction) { }
    public override string CommandText { get { return default(string); } set { } }
    public override int CommandTimeout { get { return default(int); } set { } }
    public override System.Data.CommandType CommandType { get { return default(System.Data.CommandType); } set { } }
    public new System.Data.SqlClient.SqlConnection Connection { get { return default(System.Data.SqlClient.SqlConnection); } set { } }
    protected override System.Data.Common.DbConnection DbConnection { get { return default(System.Data.Common.DbConnection); } set { } }
    protected override System.Data.Common.DbParameterCollection DbParameterCollection { get { return default(System.Data.Common.DbParameterCollection); } }
    protected override System.Data.Common.DbTransaction DbTransaction { get { return default(System.Data.Common.DbTransaction); } set { } }
    public override bool DesignTimeVisible { get { return default(bool); } set { } }
    public new System.Data.SqlClient.SqlParameterCollection Parameters { get { return default(System.Data.SqlClient.SqlParameterCollection); } }
    public new System.Data.SqlClient.SqlTransaction Transaction { get { return default(System.Data.SqlClient.SqlTransaction); } set { } }
    public override System.Data.UpdateRowSource UpdatedRowSource { get { return default(System.Data.UpdateRowSource); } set { } }
    public event System.Data.StatementCompletedEventHandler StatementCompleted { add { } remove { } }
    public override void Cancel() { }
    protected override System.Data.Common.DbParameter CreateDbParameter() { return default(System.Data.Common.DbParameter); }
    public new System.Data.SqlClient.SqlParameter CreateParameter() { return default(System.Data.SqlClient.SqlParameter); }
    protected override void Dispose(bool disposing) { }
    protected override System.Data.Common.DbDataReader ExecuteDbDataReader(System.Data.CommandBehavior behavior) { return default(System.Data.Common.DbDataReader); }
    protected override System.Threading.Tasks.Task<System.Data.Common.DbDataReader> ExecuteDbDataReaderAsync(System.Data.CommandBehavior behavior, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<System.Data.Common.DbDataReader>); }
    public override int ExecuteNonQuery() { return default(int); }
    public override System.Threading.Tasks.Task<int> ExecuteNonQueryAsync(System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<int>); }
    public new System.Data.SqlClient.SqlDataReader ExecuteReader() { return default(System.Data.SqlClient.SqlDataReader); }
    public new System.Data.SqlClient.SqlDataReader ExecuteReader(System.Data.CommandBehavior behavior) { return default(System.Data.SqlClient.SqlDataReader); }
    public new System.Threading.Tasks.Task<System.Data.SqlClient.SqlDataReader> ExecuteReaderAsync() { return default(System.Threading.Tasks.Task<System.Data.SqlClient.SqlDataReader>); }
    public new System.Threading.Tasks.Task<System.Data.SqlClient.SqlDataReader> ExecuteReaderAsync(System.Data.CommandBehavior behavior) { return default(System.Threading.Tasks.Task<System.Data.SqlClient.SqlDataReader>); }
    public new System.Threading.Tasks.Task<System.Data.SqlClient.SqlDataReader> ExecuteReaderAsync(System.Data.CommandBehavior behavior, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<System.Data.SqlClient.SqlDataReader>); }
    public new System.Threading.Tasks.Task<System.Data.SqlClient.SqlDataReader> ExecuteReaderAsync(System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<System.Data.SqlClient.SqlDataReader>); }
    public override object ExecuteScalar() { return default(object); }
    public override System.Threading.Tasks.Task<object> ExecuteScalarAsync(System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<object>); }
    public System.Xml.XmlReader ExecuteXmlReader() { return default(System.Xml.XmlReader); }
    public System.Threading.Tasks.Task<System.Xml.XmlReader> ExecuteXmlReaderAsync() { return default(System.Threading.Tasks.Task<System.Xml.XmlReader>); }
    public System.Threading.Tasks.Task<System.Xml.XmlReader> ExecuteXmlReaderAsync(System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<System.Xml.XmlReader>); }
    public override void Prepare() { }
  }

  public sealed partial class SqlConnection : System.Data.Common.DbConnection {
    public SqlConnection() { }
    public SqlConnection(string connectionString) { }
    public System.Guid ClientConnectionId { get { return default(System.Guid); } }
    public override string ConnectionString { get { return default(string); } set { } }
    public override int ConnectionTimeout { get { return default(int); } }
    public override string Database { get { return default(string); } }
    public override string DataSource { get { return default(string); } }
    public bool FireInfoMessageEventOnUserErrors { get { return default(bool); } set { } }
    public int PacketSize { get { return default(int); } }
    public override string ServerVersion { get { return default(string); } }
    public override System.Data.ConnectionState State { get { return default(System.Data.ConnectionState); } }
    public bool StatisticsEnabled { get { return default(bool); } set { } }
    public string WorkstationId { get { return default(string); } }
    public event System.Data.SqlClient.SqlInfoMessageEventHandler InfoMessage { add { } remove { } }
    protected override System.Data.Common.DbTransaction BeginDbTransaction(System.Data.IsolationLevel isolationLevel) { return default(System.Data.Common.DbTransaction); }
    public new System.Data.SqlClient.SqlTransaction BeginTransaction() { return default(System.Data.SqlClient.SqlTransaction); }
    public new System.Data.SqlClient.SqlTransaction BeginTransaction(System.Data.IsolationLevel iso) { return default(System.Data.SqlClient.SqlTransaction); }
    public System.Data.SqlClient.SqlTransaction BeginTransaction(System.Data.IsolationLevel iso, string transactionName) { return default(System.Data.SqlClient.SqlTransaction); }
    public System.Data.SqlClient.SqlTransaction BeginTransaction(string transactionName) { return default(System.Data.SqlClient.SqlTransaction); }
    public override void ChangeDatabase(string database) { }
    public static void ClearAllPools() { }
    public static void ClearPool(System.Data.SqlClient.SqlConnection connection) { }
    public override void Close() { }
    public new System.Data.SqlClient.SqlCommand CreateCommand() { return default(System.Data.SqlClient.SqlCommand); }
    protected override System.Data.Common.DbCommand CreateDbCommand() { return default(System.Data.Common.DbCommand); }
    protected override void Dispose(bool disposing) { }
    public override void Open() { }
    public override System.Threading.Tasks.Task OpenAsync(System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task); }
    public void ResetStatistics() { }
    public System.Collections.IDictionary RetrieveStatistics() { return default(System.Collections.IDictionary); }
  }

  public sealed partial class SqlConnectionStringBuilder : System.Data.Common.DbConnectionStringBuilder {
    public SqlConnectionStringBuilder() { }
    public SqlConnectionStringBuilder(string connectionString) { }
    public System.Data.SqlClient.ApplicationIntent ApplicationIntent { get { return default(System.Data.SqlClient.ApplicationIntent); } set { } }
    public string ApplicationName { get { return default(string); } set { } }
    public string AttachDBFilename { get { return default(string); } set { } }
    public int ConnectRetryCount { get { return default(int); } set { } }
    public int ConnectRetryInterval { get { return default(int); } set { } }
    public int ConnectTimeout { get { return default(int); } set { } }
    public string CurrentLanguage { get { return default(string); } set { } }
    public string DataSource { get { return default(string); } set { } }
    public bool Encrypt { get { return default(bool); } set { } }
    public string FailoverPartner { get { return default(string); } set { } }
    public string InitialCatalog { get { return default(string); } set { } }
    public bool IntegratedSecurity { get { return default(bool); } set { } }
    public override object this[string keyword] { get { return default(object); } set { } }
    public override System.Collections.ICollection Keys { get { return default(System.Collections.ICollection); } }
    public int LoadBalanceTimeout { get { return default(int); } set { } }
    public int MaxPoolSize { get { return default(int); } set { } }
    public int MinPoolSize { get { return default(int); } set { } }
    public bool MultipleActiveResultSets { get { return default(bool); } set { } }
    public bool MultiSubnetFailover { get { return default(bool); } set { } }
    public int PacketSize { get { return default(int); } set { } }
    public string Password { get { return default(string); } set { } }
    public bool PersistSecurityInfo { get { return default(bool); } set { } }
    public bool Pooling { get { return default(bool); } set { } }
    public bool Replication { get { return default(bool); } set { } }
    public bool TrustServerCertificate { get { return default(bool); } set { } }
    public string TypeSystemVersion { get { return default(string); } set { } }
    public string UserID { get { return default(string); } set { } }
    public bool UserInstance { get { return default(bool); } set { } }
    public override System.Collections.ICollection Values { get { return default(System.Collections.ICollection); } }
    public string WorkstationID { get { return default(string); } set { } }
    public override void Clear() { }
    public override bool ContainsKey(string keyword) { return default(bool); }
    public override bool Remove(string keyword) { return default(bool); }
    public override bool ShouldSerialize(string keyword) { return default(bool); }
    public override bool TryGetValue(string keyword, out object value) { value = default(object); return default(bool); }
  }

  public partial class SqlDataReader : System.Data.Common.DbDataReader, System.IDisposable {
    internal SqlDataReader() { }
    protected System.Data.SqlClient.SqlConnection Connection { get { return default(System.Data.SqlClient.SqlConnection); } }
    public override int Depth { get { return default(int); } }
    public override int FieldCount { get { return default(int); } }
    public override bool HasRows { get { return default(bool); } }
    public override bool IsClosed { get { return default(bool); } }
    public override object this[int i] { get { return default(object); } }
    public override object this[string name] { get { return default(object); } }
    public override int RecordsAffected { get { return default(int); } }
    public override int VisibleFieldCount { get { return default(int); } }
    public override bool GetBoolean(int i) { return default(bool); }
    public override byte GetByte(int i) { return default(byte); }
    public override long GetBytes(int i, long dataIndex, byte[] buffer, int bufferIndex, int length) { return default(long); }
    public override char GetChar(int i) { return default(char); }
    public override long GetChars(int i, long dataIndex, char[] buffer, int bufferIndex, int length) { return default(long); }
    public override string GetDataTypeName(int i) { return default(string); }
    public override System.DateTime GetDateTime(int i) { return default(System.DateTime); }
    public virtual System.DateTimeOffset GetDateTimeOffset(int i) { return default(System.DateTimeOffset); }
    public override decimal GetDecimal(int i) { return default(decimal); }
    public override double GetDouble(int i) { return default(double); }
    public override System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public override System.Type GetFieldType(int i) { return default(System.Type); }
    public override T GetFieldValue<T>(int i) { return default(T); }
    public override System.Threading.Tasks.Task<T> GetFieldValueAsync<T>(int i, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<T>); }
    public override float GetFloat(int i) { return default(float); }
    public override System.Guid GetGuid(int i) { return default(System.Guid); }
    public override short GetInt16(int i) { return default(short); }
    public override int GetInt32(int i) { return default(int); }
    public override long GetInt64(int i) { return default(long); }
    public override string GetName(int i) { return default(string); }
    public override int GetOrdinal(string name) { return default(int); }
    public override System.Type GetProviderSpecificFieldType(int i) { return default(System.Type); }
    public override object GetProviderSpecificValue(int i) { return default(object); }
    public override int GetProviderSpecificValues(object[] values) { return default(int); }
    public virtual System.Data.SqlTypes.SqlBinary GetSqlBinary(int i) { return default(System.Data.SqlTypes.SqlBinary); }
    public virtual System.Data.SqlTypes.SqlBoolean GetSqlBoolean(int i) { return default(System.Data.SqlTypes.SqlBoolean); }
    public virtual System.Data.SqlTypes.SqlByte GetSqlByte(int i) { return default(System.Data.SqlTypes.SqlByte); }
    public virtual System.Data.SqlTypes.SqlBytes GetSqlBytes(int i) { return default(System.Data.SqlTypes.SqlBytes); }
    public virtual System.Data.SqlTypes.SqlChars GetSqlChars(int i) { return default(System.Data.SqlTypes.SqlChars); }
    public virtual System.Data.SqlTypes.SqlDateTime GetSqlDateTime(int i) { return default(System.Data.SqlTypes.SqlDateTime); }
    public virtual System.Data.SqlTypes.SqlDecimal GetSqlDecimal(int i) { return default(System.Data.SqlTypes.SqlDecimal); }
    public virtual System.Data.SqlTypes.SqlDouble GetSqlDouble(int i) { return default(System.Data.SqlTypes.SqlDouble); }
    public virtual System.Data.SqlTypes.SqlGuid GetSqlGuid(int i) { return default(System.Data.SqlTypes.SqlGuid); }
    public virtual System.Data.SqlTypes.SqlInt16 GetSqlInt16(int i) { return default(System.Data.SqlTypes.SqlInt16); }
    public virtual System.Data.SqlTypes.SqlInt32 GetSqlInt32(int i) { return default(System.Data.SqlTypes.SqlInt32); }
    public virtual System.Data.SqlTypes.SqlInt64 GetSqlInt64(int i) { return default(System.Data.SqlTypes.SqlInt64); }
    public virtual System.Data.SqlTypes.SqlMoney GetSqlMoney(int i) { return default(System.Data.SqlTypes.SqlMoney); }
    public virtual System.Data.SqlTypes.SqlSingle GetSqlSingle(int i) { return default(System.Data.SqlTypes.SqlSingle); }
    public virtual System.Data.SqlTypes.SqlString GetSqlString(int i) { return default(System.Data.SqlTypes.SqlString); }
    public virtual object GetSqlValue(int i) { return default(object); }
    public virtual int GetSqlValues(object[] values) { return default(int); }
    public virtual System.Data.SqlTypes.SqlXml GetSqlXml(int i) { return default(System.Data.SqlTypes.SqlXml); }
    public override System.IO.Stream GetStream(int i) { return default(System.IO.Stream); }
    public override string GetString(int i) { return default(string); }
    public override System.IO.TextReader GetTextReader(int i) { return default(System.IO.TextReader); }
    public virtual System.TimeSpan GetTimeSpan(int i) { return default(System.TimeSpan); }
    public override object GetValue(int i) { return default(object); }
    public override int GetValues(object[] values) { return default(int); }
    public virtual System.Xml.XmlReader GetXmlReader(int i) { return default(System.Xml.XmlReader); }
    public override bool IsDBNull(int i) { return default(bool); }
    public override System.Threading.Tasks.Task<bool> IsDBNullAsync(int i, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<bool>); }
    public override bool NextResult() { return default(bool); }
    public override System.Threading.Tasks.Task<bool> NextResultAsync(System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<bool>); }
    public override bool Read() { return default(bool); }
    public override System.Threading.Tasks.Task<bool> ReadAsync(System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<bool>); }
  }

  public sealed partial class SqlError {
    internal SqlError() { }
    public byte Class { get { return default(byte); } }
    public int LineNumber { get { return default(int); } }
    public string Message { get { return default(string); } }
    public int Number { get { return default(int); } }
    public string Procedure { get { return default(string); } }
    public string Server { get { return default(string); } }
    public string Source { get { return default(string); } }
    public byte State { get { return default(byte); } }
    public override string ToString() { return default(string); }
  }

  public sealed partial class SqlErrorCollection : System.Collections.ICollection, System.Collections.IEnumerable {
    internal SqlErrorCollection() { }
    public int Count { get { return default(int); } }
    public System.Data.SqlClient.SqlError this[int index] { get { return default(System.Data.SqlClient.SqlError); } }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    public void CopyTo(System.Array array, int index) { }
    public void CopyTo(System.Data.SqlClient.SqlError[] array, int index) { }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
  }

  public sealed partial class SqlException : System.Data.Common.DbException {
    internal SqlException() { }
    public byte Class { get { return default(byte); } }
    public System.Guid ClientConnectionId { get { return default(System.Guid); } }
    public System.Data.SqlClient.SqlErrorCollection Errors { get { return default(System.Data.SqlClient.SqlErrorCollection); } }
    public int LineNumber { get { return default(int); } }
    public int Number { get { return default(int); } }
    public string Procedure { get { return default(string); } }
    public string Server { get { return default(string); } }
    public override string Source { get { return default(string); } }
    public byte State { get { return default(byte); } }
    public override string ToString() { return default(string); }
  }

  public sealed partial class SqlInfoMessageEventArgs : System.EventArgs {
    internal SqlInfoMessageEventArgs() { }
    public System.Data.SqlClient.SqlErrorCollection Errors { get { return default(System.Data.SqlClient.SqlErrorCollection); } }
    public string Message { get { return default(string); } }
    public string Source { get { return default(string); } }
    public override string ToString() { return default(string); }
  }

  public delegate void SqlInfoMessageEventHandler(object sender, System.Data.SqlClient.SqlInfoMessageEventArgs e);

  public sealed partial class SqlParameter : System.Data.Common.DbParameter {
    public SqlParameter() { }
    public SqlParameter(string parameterName, System.Data.SqlDbType dbType) { }
    public SqlParameter(string parameterName, System.Data.SqlDbType dbType, int size) { }
    public SqlParameter(string parameterName, System.Data.SqlDbType dbType, int size, string sourceColumn) { }
    public SqlParameter(string parameterName, object value) { }
    public System.Data.SqlTypes.SqlCompareOptions CompareInfo { get { return default(System.Data.SqlTypes.SqlCompareOptions); } set { } }
    public override System.Data.DbType DbType { get { return default(System.Data.DbType); } set { } }
    public override System.Data.ParameterDirection Direction { get { return default(System.Data.ParameterDirection); } set { } }
    public override bool IsNullable { get { return default(bool); } set { } }
    public int LocaleId { get { return default(int); } set { } }
    public int Offset { get { return default(int); } set { } }
    public override string ParameterName { get { return default(string); } set { } }
    public new byte Precision { get { return default(byte); } set { } }
    public new byte Scale { get { return default(byte); } set { } }
    public override int Size { get { return default(int); } set { } }
    public override string SourceColumn { get { return default(string); } set { } }
    public override bool SourceColumnNullMapping { get { return default(bool); } set { } }
    public System.Data.SqlDbType SqlDbType { get { return default(System.Data.SqlDbType); } set { } }
    public object SqlValue { get { return default(object); } set { } }
    public string TypeName { get { return default(string); } set { } }
    public override object Value { get { return default(object); } set { } }
    public string XmlSchemaCollectionDatabase { get { return default(string); } set { } }
    public string XmlSchemaCollectionName { get { return default(string); } set { } }
    public string XmlSchemaCollectionOwningSchema { get { return default(string); } set { } }
    public override void ResetDbType() { }
    public void ResetSqlDbType() { }
    public override string ToString() { return default(string); }
  }

  public sealed partial class SqlParameterCollection : System.Data.Common.DbParameterCollection {
    internal SqlParameterCollection() { }
    public override int Count { get { return default(int); } }
    public new System.Data.SqlClient.SqlParameter this[int index] { get { return default(System.Data.SqlClient.SqlParameter); } set { } }
    public new System.Data.SqlClient.SqlParameter this[string parameterName] { get { return default(System.Data.SqlClient.SqlParameter); } set { } }
    public override object SyncRoot { get { return default(object); } }
    public System.Data.SqlClient.SqlParameter Add(System.Data.SqlClient.SqlParameter value) { return default(System.Data.SqlClient.SqlParameter); }
    public override int Add(object value) { return default(int); }
    public System.Data.SqlClient.SqlParameter Add(string parameterName, System.Data.SqlDbType sqlDbType) { return default(System.Data.SqlClient.SqlParameter); }
    public System.Data.SqlClient.SqlParameter Add(string parameterName, System.Data.SqlDbType sqlDbType, int size) { return default(System.Data.SqlClient.SqlParameter); }
    public override void AddRange(System.Array values) { }
    public void AddRange(System.Data.SqlClient.SqlParameter[] values) { }
    public System.Data.SqlClient.SqlParameter AddWithValue(string parameterName, object value) { return default(System.Data.SqlClient.SqlParameter); }
    public override void Clear() { }
    public bool Contains(System.Data.SqlClient.SqlParameter value) { return default(bool); }
    public override bool Contains(object value) { return default(bool); }
    public override bool Contains(string value) { return default(bool); }
    public override void CopyTo(System.Array array, int index) { }
    public void CopyTo(System.Data.SqlClient.SqlParameter[] array, int index) { }
    public override System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    protected override System.Data.Common.DbParameter GetParameter(int index) { return default(System.Data.Common.DbParameter); }
    protected override System.Data.Common.DbParameter GetParameter(string parameterName) { return default(System.Data.Common.DbParameter); }
    public int IndexOf(System.Data.SqlClient.SqlParameter value) { return default(int); }
    public override int IndexOf(object value) { return default(int); }
    public override int IndexOf(string parameterName) { return default(int); }
    public void Insert(int index, System.Data.SqlClient.SqlParameter value) { }
    public override void Insert(int index, object value) { }
    public void Remove(System.Data.SqlClient.SqlParameter value) { }
    public override void Remove(object value) { }
    public override void RemoveAt(int index) { }
    public override void RemoveAt(string parameterName) { }
    protected override void SetParameter(int index, System.Data.Common.DbParameter value) { }
    protected override void SetParameter(string parameterName, System.Data.Common.DbParameter value) { }
  }

  public partial class SqlRowsCopiedEventArgs : System.EventArgs {
    public SqlRowsCopiedEventArgs(long rowsCopied) { }
    public bool Abort { get { return default(bool); } set { } }
    public long RowsCopied { get { return default(long); } }
  }

  public delegate void SqlRowsCopiedEventHandler(object sender, System.Data.SqlClient.SqlRowsCopiedEventArgs e);

  public sealed partial class SqlTransaction : System.Data.Common.DbTransaction {
    internal SqlTransaction() { }
    public new System.Data.SqlClient.SqlConnection Connection { get { return default(System.Data.SqlClient.SqlConnection); } }
    protected override System.Data.Common.DbConnection DbConnection { get { return default(System.Data.Common.DbConnection); } }
    public override System.Data.IsolationLevel IsolationLevel { get { return default(System.Data.IsolationLevel); } }
    public override void Commit() { }
    protected override void Dispose(bool disposing) { }
    public override void Rollback() { }
    public void Rollback(string transactionName) { }
    public void Save(string savePointName) { }
  }

} // end of System.Data.SqlClient
namespace System.Data.SqlTypes {
  public partial interface INullable {
    bool IsNull { get; }
  }

  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct SqlBinary : System.Data.SqlTypes.INullable, System.IComparable {
    public static readonly System.Data.SqlTypes.SqlBinary Null;
    public SqlBinary(byte[] value) { throw new System.NotImplementedException(); }
    public bool IsNull { get { return default(bool); } }
    public byte this[int index] { get { return default(byte); } }
    public int Length { get { return default(int); } }
    public byte[] Value { get { return default(byte[]); } }
    public static System.Data.SqlTypes.SqlBinary Add(System.Data.SqlTypes.SqlBinary x, System.Data.SqlTypes.SqlBinary y) { return default(System.Data.SqlTypes.SqlBinary); }
    public int CompareTo(System.Data.SqlTypes.SqlBinary value) { return default(int); }
    public int CompareTo(object value) { return default(int); }
    public static System.Data.SqlTypes.SqlBinary Concat(System.Data.SqlTypes.SqlBinary x, System.Data.SqlTypes.SqlBinary y) { return default(System.Data.SqlTypes.SqlBinary); }
    public static System.Data.SqlTypes.SqlBoolean Equals(System.Data.SqlTypes.SqlBinary x, System.Data.SqlTypes.SqlBinary y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public override bool Equals(object value) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlBinary x, System.Data.SqlTypes.SqlBinary y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean GreaterThanOrEqual(System.Data.SqlTypes.SqlBinary x, System.Data.SqlTypes.SqlBinary y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlBinary x, System.Data.SqlTypes.SqlBinary y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean LessThanOrEqual(System.Data.SqlTypes.SqlBinary x, System.Data.SqlTypes.SqlBinary y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean NotEquals(System.Data.SqlTypes.SqlBinary x, System.Data.SqlTypes.SqlBinary y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBinary operator +(System.Data.SqlTypes.SqlBinary x, System.Data.SqlTypes.SqlBinary y) { return default(System.Data.SqlTypes.SqlBinary); }
    public static System.Data.SqlTypes.SqlBoolean operator ==(System.Data.SqlTypes.SqlBinary x, System.Data.SqlTypes.SqlBinary y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static explicit operator byte[] (System.Data.SqlTypes.SqlBinary x) { return default(byte[]); }
    public static explicit operator System.Data.SqlTypes.SqlBinary (System.Data.SqlTypes.SqlGuid x) { return default(System.Data.SqlTypes.SqlBinary); }
    public static System.Data.SqlTypes.SqlBoolean operator >(System.Data.SqlTypes.SqlBinary x, System.Data.SqlTypes.SqlBinary y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean operator >=(System.Data.SqlTypes.SqlBinary x, System.Data.SqlTypes.SqlBinary y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static implicit operator System.Data.SqlTypes.SqlBinary (byte[] x) { return default(System.Data.SqlTypes.SqlBinary); }
    public static System.Data.SqlTypes.SqlBoolean operator !=(System.Data.SqlTypes.SqlBinary x, System.Data.SqlTypes.SqlBinary y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean operator <(System.Data.SqlTypes.SqlBinary x, System.Data.SqlTypes.SqlBinary y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean operator <=(System.Data.SqlTypes.SqlBinary x, System.Data.SqlTypes.SqlBinary y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public System.Data.SqlTypes.SqlGuid ToSqlGuid() { return default(System.Data.SqlTypes.SqlGuid); }
    public override string ToString() { return default(string); }
  }

  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct SqlBoolean : System.Data.SqlTypes.INullable, System.IComparable {
    public static readonly System.Data.SqlTypes.SqlBoolean False;
    public static readonly System.Data.SqlTypes.SqlBoolean Null;
    public static readonly System.Data.SqlTypes.SqlBoolean One;
    public static readonly System.Data.SqlTypes.SqlBoolean True;
    public static readonly System.Data.SqlTypes.SqlBoolean Zero;
    public SqlBoolean(bool value) { throw new System.NotImplementedException(); }
    public SqlBoolean(int value) { throw new System.NotImplementedException(); }
    public byte ByteValue { get { return default(byte); } }
    public bool IsFalse { get { return default(bool); } }
    public bool IsNull { get { return default(bool); } }
    public bool IsTrue { get { return default(bool); } }
    public bool Value { get { return default(bool); } }
    public static System.Data.SqlTypes.SqlBoolean And(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public int CompareTo(System.Data.SqlTypes.SqlBoolean value) { return default(int); }
    public int CompareTo(object value) { return default(int); }
    public static System.Data.SqlTypes.SqlBoolean Equals(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public override bool Equals(object value) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean GreaterThanOrEquals(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean LessThanOrEquals(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean NotEquals(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean OnesComplement(System.Data.SqlTypes.SqlBoolean x) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean operator &(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean operator |(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean operator ==(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean operator ^(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static explicit operator bool (System.Data.SqlTypes.SqlBoolean x) { return default(bool); }
    public static explicit operator System.Data.SqlTypes.SqlBoolean (System.Data.SqlTypes.SqlByte x) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static explicit operator System.Data.SqlTypes.SqlBoolean (System.Data.SqlTypes.SqlDecimal x) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static explicit operator System.Data.SqlTypes.SqlBoolean (System.Data.SqlTypes.SqlDouble x) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static explicit operator System.Data.SqlTypes.SqlBoolean (System.Data.SqlTypes.SqlInt16 x) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static explicit operator System.Data.SqlTypes.SqlBoolean (System.Data.SqlTypes.SqlInt32 x) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static explicit operator System.Data.SqlTypes.SqlBoolean (System.Data.SqlTypes.SqlInt64 x) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static explicit operator System.Data.SqlTypes.SqlBoolean (System.Data.SqlTypes.SqlMoney x) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static explicit operator System.Data.SqlTypes.SqlBoolean (System.Data.SqlTypes.SqlSingle x) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static explicit operator System.Data.SqlTypes.SqlBoolean (System.Data.SqlTypes.SqlString x) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static bool operator false(System.Data.SqlTypes.SqlBoolean x) { return default(bool); }
    public static System.Data.SqlTypes.SqlBoolean operator >(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean operator >=(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static implicit operator System.Data.SqlTypes.SqlBoolean (bool x) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean operator !=(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean operator <(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean operator <=(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean operator !(System.Data.SqlTypes.SqlBoolean x) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean operator ~(System.Data.SqlTypes.SqlBoolean x) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static bool operator true(System.Data.SqlTypes.SqlBoolean x) { return default(bool); }
    public static System.Data.SqlTypes.SqlBoolean Or(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean Parse(string s) { return default(System.Data.SqlTypes.SqlBoolean); }
    public System.Data.SqlTypes.SqlByte ToSqlByte() { return default(System.Data.SqlTypes.SqlByte); }
    public System.Data.SqlTypes.SqlDecimal ToSqlDecimal() { return default(System.Data.SqlTypes.SqlDecimal); }
    public System.Data.SqlTypes.SqlDouble ToSqlDouble() { return default(System.Data.SqlTypes.SqlDouble); }
    public System.Data.SqlTypes.SqlInt16 ToSqlInt16() { return default(System.Data.SqlTypes.SqlInt16); }
    public System.Data.SqlTypes.SqlInt32 ToSqlInt32() { return default(System.Data.SqlTypes.SqlInt32); }
    public System.Data.SqlTypes.SqlInt64 ToSqlInt64() { return default(System.Data.SqlTypes.SqlInt64); }
    public System.Data.SqlTypes.SqlMoney ToSqlMoney() { return default(System.Data.SqlTypes.SqlMoney); }
    public System.Data.SqlTypes.SqlSingle ToSqlSingle() { return default(System.Data.SqlTypes.SqlSingle); }
    public System.Data.SqlTypes.SqlString ToSqlString() { return default(System.Data.SqlTypes.SqlString); }
    public override string ToString() { return default(string); }
    public static System.Data.SqlTypes.SqlBoolean Xor(System.Data.SqlTypes.SqlBoolean x, System.Data.SqlTypes.SqlBoolean y) { return default(System.Data.SqlTypes.SqlBoolean); }
  }

  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct SqlByte : System.Data.SqlTypes.INullable, System.IComparable {
    public static readonly System.Data.SqlTypes.SqlByte MaxValue;
    public static readonly System.Data.SqlTypes.SqlByte MinValue;
    public static readonly System.Data.SqlTypes.SqlByte Null;
    public static readonly System.Data.SqlTypes.SqlByte Zero;
    public SqlByte(byte value) { throw new System.NotImplementedException(); }
    public bool IsNull { get { return default(bool); } }
    public byte Value { get { return default(byte); } }
    public static System.Data.SqlTypes.SqlByte Add(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { return default(System.Data.SqlTypes.SqlByte); }
    public static System.Data.SqlTypes.SqlByte BitwiseAnd(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { return default(System.Data.SqlTypes.SqlByte); }
    public static System.Data.SqlTypes.SqlByte BitwiseOr(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { return default(System.Data.SqlTypes.SqlByte); }
    public int CompareTo(System.Data.SqlTypes.SqlByte value) { return default(int); }
    public int CompareTo(object value) { return default(int); }
    public static System.Data.SqlTypes.SqlByte Divide(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { return default(System.Data.SqlTypes.SqlByte); }
    public static System.Data.SqlTypes.SqlBoolean Equals(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public override bool Equals(object value) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean GreaterThanOrEqual(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean LessThanOrEqual(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlByte Mod(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { return default(System.Data.SqlTypes.SqlByte); }
    public static System.Data.SqlTypes.SqlByte Modulus(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { return default(System.Data.SqlTypes.SqlByte); }
    public static System.Data.SqlTypes.SqlByte Multiply(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { return default(System.Data.SqlTypes.SqlByte); }
    public static System.Data.SqlTypes.SqlBoolean NotEquals(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlByte OnesComplement(System.Data.SqlTypes.SqlByte x) { return default(System.Data.SqlTypes.SqlByte); }
    public static System.Data.SqlTypes.SqlByte operator +(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { return default(System.Data.SqlTypes.SqlByte); }
    public static System.Data.SqlTypes.SqlByte operator &(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { return default(System.Data.SqlTypes.SqlByte); }
    public static System.Data.SqlTypes.SqlByte operator |(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { return default(System.Data.SqlTypes.SqlByte); }
    public static System.Data.SqlTypes.SqlByte operator /(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { return default(System.Data.SqlTypes.SqlByte); }
    public static System.Data.SqlTypes.SqlBoolean operator ==(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlByte operator ^(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { return default(System.Data.SqlTypes.SqlByte); }
    public static explicit operator System.Data.SqlTypes.SqlByte (System.Data.SqlTypes.SqlBoolean x) { return default(System.Data.SqlTypes.SqlByte); }
    public static explicit operator byte (System.Data.SqlTypes.SqlByte x) { return default(byte); }
    public static explicit operator System.Data.SqlTypes.SqlByte (System.Data.SqlTypes.SqlDecimal x) { return default(System.Data.SqlTypes.SqlByte); }
    public static explicit operator System.Data.SqlTypes.SqlByte (System.Data.SqlTypes.SqlDouble x) { return default(System.Data.SqlTypes.SqlByte); }
    public static explicit operator System.Data.SqlTypes.SqlByte (System.Data.SqlTypes.SqlInt16 x) { return default(System.Data.SqlTypes.SqlByte); }
    public static explicit operator System.Data.SqlTypes.SqlByte (System.Data.SqlTypes.SqlInt32 x) { return default(System.Data.SqlTypes.SqlByte); }
    public static explicit operator System.Data.SqlTypes.SqlByte (System.Data.SqlTypes.SqlInt64 x) { return default(System.Data.SqlTypes.SqlByte); }
    public static explicit operator System.Data.SqlTypes.SqlByte (System.Data.SqlTypes.SqlMoney x) { return default(System.Data.SqlTypes.SqlByte); }
    public static explicit operator System.Data.SqlTypes.SqlByte (System.Data.SqlTypes.SqlSingle x) { return default(System.Data.SqlTypes.SqlByte); }
    public static explicit operator System.Data.SqlTypes.SqlByte (System.Data.SqlTypes.SqlString x) { return default(System.Data.SqlTypes.SqlByte); }
    public static System.Data.SqlTypes.SqlBoolean operator >(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean operator >=(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static implicit operator System.Data.SqlTypes.SqlByte (byte x) { return default(System.Data.SqlTypes.SqlByte); }
    public static System.Data.SqlTypes.SqlBoolean operator !=(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean operator <(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean operator <=(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlByte operator %(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { return default(System.Data.SqlTypes.SqlByte); }
    public static System.Data.SqlTypes.SqlByte operator *(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { return default(System.Data.SqlTypes.SqlByte); }
    public static System.Data.SqlTypes.SqlByte operator ~(System.Data.SqlTypes.SqlByte x) { return default(System.Data.SqlTypes.SqlByte); }
    public static System.Data.SqlTypes.SqlByte operator -(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { return default(System.Data.SqlTypes.SqlByte); }
    public static System.Data.SqlTypes.SqlByte Parse(string s) { return default(System.Data.SqlTypes.SqlByte); }
    public static System.Data.SqlTypes.SqlByte Subtract(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { return default(System.Data.SqlTypes.SqlByte); }
    public System.Data.SqlTypes.SqlBoolean ToSqlBoolean() { return default(System.Data.SqlTypes.SqlBoolean); }
    public System.Data.SqlTypes.SqlDecimal ToSqlDecimal() { return default(System.Data.SqlTypes.SqlDecimal); }
    public System.Data.SqlTypes.SqlDouble ToSqlDouble() { return default(System.Data.SqlTypes.SqlDouble); }
    public System.Data.SqlTypes.SqlInt16 ToSqlInt16() { return default(System.Data.SqlTypes.SqlInt16); }
    public System.Data.SqlTypes.SqlInt32 ToSqlInt32() { return default(System.Data.SqlTypes.SqlInt32); }
    public System.Data.SqlTypes.SqlInt64 ToSqlInt64() { return default(System.Data.SqlTypes.SqlInt64); }
    public System.Data.SqlTypes.SqlMoney ToSqlMoney() { return default(System.Data.SqlTypes.SqlMoney); }
    public System.Data.SqlTypes.SqlSingle ToSqlSingle() { return default(System.Data.SqlTypes.SqlSingle); }
    public System.Data.SqlTypes.SqlString ToSqlString() { return default(System.Data.SqlTypes.SqlString); }
    public override string ToString() { return default(string); }
    public static System.Data.SqlTypes.SqlByte Xor(System.Data.SqlTypes.SqlByte x, System.Data.SqlTypes.SqlByte y) { return default(System.Data.SqlTypes.SqlByte); }
  }

  public sealed partial class SqlBytes : System.Data.SqlTypes.INullable {
    public SqlBytes() { }
    public SqlBytes(byte[] buffer) { }
    public SqlBytes(System.Data.SqlTypes.SqlBinary value) { }
    public SqlBytes(System.IO.Stream s) { }
    public byte[] Buffer { get { return default(byte[]); } }
    public bool IsNull { get { return default(bool); } }
    public byte this[long offset] { get { return default(byte); } set { } }
    public long Length { get { return default(long); } }
    public long MaxLength { get { return default(long); } }
    public static System.Data.SqlTypes.SqlBytes Null { get { return default(System.Data.SqlTypes.SqlBytes); } }
    public System.IO.Stream Stream { get { return default(System.IO.Stream); } set { } }
    public byte[] Value { get { return default(byte[]); } }
    public static explicit operator System.Data.SqlTypes.SqlBytes (System.Data.SqlTypes.SqlBinary value) { return default(System.Data.SqlTypes.SqlBytes); }
    public static explicit operator System.Data.SqlTypes.SqlBinary (System.Data.SqlTypes.SqlBytes value) { return default(System.Data.SqlTypes.SqlBinary); }
    public long Read(long offset, byte[] buffer, int offsetInBuffer, int count) { return default(long); }
    public void SetLength(long value) { }
    public void SetNull() { }
    public System.Data.SqlTypes.SqlBinary ToSqlBinary() { return default(System.Data.SqlTypes.SqlBinary); }
    public void Write(long offset, byte[] buffer, int offsetInBuffer, int count) { }
  }

  public sealed partial class SqlChars : System.Data.SqlTypes.INullable {
    public SqlChars() { }
    public SqlChars(char[] buffer) { }
    public SqlChars(System.Data.SqlTypes.SqlString value) { }
    public char[] Buffer { get { return default(char[]); } }
    public bool IsNull { get { return default(bool); } }
    public char this[long offset] { get { return default(char); } set { } }
    public long Length { get { return default(long); } }
    public long MaxLength { get { return default(long); } }
    public static System.Data.SqlTypes.SqlChars Null { get { return default(System.Data.SqlTypes.SqlChars); } }
    public char[] Value { get { return default(char[]); } }
    public static explicit operator System.Data.SqlTypes.SqlString (System.Data.SqlTypes.SqlChars value) { return default(System.Data.SqlTypes.SqlString); }
    public static explicit operator System.Data.SqlTypes.SqlChars (System.Data.SqlTypes.SqlString value) { return default(System.Data.SqlTypes.SqlChars); }
    public long Read(long offset, char[] buffer, int offsetInBuffer, int count) { return default(long); }
    public void SetLength(long value) { }
    public void SetNull() { }
    public System.Data.SqlTypes.SqlString ToSqlString() { return default(System.Data.SqlTypes.SqlString); }
    public void Write(long offset, char[] buffer, int offsetInBuffer, int count) { }
  }

  [System.FlagsAttribute]
  public enum SqlCompareOptions {
    BinarySort = 32768,
    BinarySort2 = 16384,
    IgnoreCase = 1,
    IgnoreKanaType = 8,
    IgnoreNonSpace = 2,
    IgnoreWidth = 16,
    None = 0,
  }

  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct SqlDateTime : System.Data.SqlTypes.INullable, System.IComparable {
    public static readonly System.Data.SqlTypes.SqlDateTime MaxValue;
    public static readonly System.Data.SqlTypes.SqlDateTime MinValue;
    public static readonly System.Data.SqlTypes.SqlDateTime Null;
    public static readonly int SQLTicksPerHour;
    public static readonly int SQLTicksPerMinute;
    public static readonly int SQLTicksPerSecond;
    public SqlDateTime(System.DateTime value) { throw new System.NotImplementedException(); }
    public SqlDateTime(int dayTicks, int timeTicks) { throw new System.NotImplementedException(); }
    public SqlDateTime(int year, int month, int day) { throw new System.NotImplementedException(); }
    public SqlDateTime(int year, int month, int day, int hour, int minute, int second) { throw new System.NotImplementedException(); }
    public SqlDateTime(int year, int month, int day, int hour, int minute, int second, double millisecond) { throw new System.NotImplementedException(); }
    public SqlDateTime(int year, int month, int day, int hour, int minute, int second, int bilisecond) { throw new System.NotImplementedException(); }
    public int DayTicks { get { return default(int); } }
    public bool IsNull { get { return default(bool); } }
    public int TimeTicks { get { return default(int); } }
    public System.DateTime Value { get { return default(System.DateTime); } }
    public static System.Data.SqlTypes.SqlDateTime Add(System.Data.SqlTypes.SqlDateTime x, System.TimeSpan t) { return default(System.Data.SqlTypes.SqlDateTime); }
    public int CompareTo(System.Data.SqlTypes.SqlDateTime value) { return default(int); }
    public int CompareTo(object value) { return default(int); }
    public static System.Data.SqlTypes.SqlBoolean Equals(System.Data.SqlTypes.SqlDateTime x, System.Data.SqlTypes.SqlDateTime y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public override bool Equals(object value) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlDateTime x, System.Data.SqlTypes.SqlDateTime y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean GreaterThanOrEqual(System.Data.SqlTypes.SqlDateTime x, System.Data.SqlTypes.SqlDateTime y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlDateTime x, System.Data.SqlTypes.SqlDateTime y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean LessThanOrEqual(System.Data.SqlTypes.SqlDateTime x, System.Data.SqlTypes.SqlDateTime y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean NotEquals(System.Data.SqlTypes.SqlDateTime x, System.Data.SqlTypes.SqlDateTime y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlDateTime operator +(System.Data.SqlTypes.SqlDateTime x, System.TimeSpan t) { return default(System.Data.SqlTypes.SqlDateTime); }
    public static System.Data.SqlTypes.SqlBoolean operator ==(System.Data.SqlTypes.SqlDateTime x, System.Data.SqlTypes.SqlDateTime y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static explicit operator System.DateTime (System.Data.SqlTypes.SqlDateTime x) { return default(System.DateTime); }
    public static explicit operator System.Data.SqlTypes.SqlDateTime (System.Data.SqlTypes.SqlString x) { return default(System.Data.SqlTypes.SqlDateTime); }
    public static System.Data.SqlTypes.SqlBoolean operator >(System.Data.SqlTypes.SqlDateTime x, System.Data.SqlTypes.SqlDateTime y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean operator >=(System.Data.SqlTypes.SqlDateTime x, System.Data.SqlTypes.SqlDateTime y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static implicit operator System.Data.SqlTypes.SqlDateTime (System.DateTime value) { return default(System.Data.SqlTypes.SqlDateTime); }
    public static System.Data.SqlTypes.SqlBoolean operator !=(System.Data.SqlTypes.SqlDateTime x, System.Data.SqlTypes.SqlDateTime y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean operator <(System.Data.SqlTypes.SqlDateTime x, System.Data.SqlTypes.SqlDateTime y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean operator <=(System.Data.SqlTypes.SqlDateTime x, System.Data.SqlTypes.SqlDateTime y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlDateTime operator -(System.Data.SqlTypes.SqlDateTime x, System.TimeSpan t) { return default(System.Data.SqlTypes.SqlDateTime); }
    public static System.Data.SqlTypes.SqlDateTime Parse(string s) { return default(System.Data.SqlTypes.SqlDateTime); }
    public static System.Data.SqlTypes.SqlDateTime Subtract(System.Data.SqlTypes.SqlDateTime x, System.TimeSpan t) { return default(System.Data.SqlTypes.SqlDateTime); }
    public System.Data.SqlTypes.SqlString ToSqlString() { return default(System.Data.SqlTypes.SqlString); }
    public override string ToString() { return default(string); }
  }

  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct SqlDecimal : System.Data.SqlTypes.INullable, System.IComparable {
    public static readonly byte MaxPrecision;
    public static readonly byte MaxScale;
    public static readonly System.Data.SqlTypes.SqlDecimal MaxValue;
    public static readonly System.Data.SqlTypes.SqlDecimal MinValue;
    public static readonly System.Data.SqlTypes.SqlDecimal Null;
    public SqlDecimal(byte bPrecision, byte bScale, bool fPositive, int data1, int data2, int data3, int data4) { throw new System.NotImplementedException(); }
    public SqlDecimal(byte bPrecision, byte bScale, bool fPositive, int[] bits) { throw new System.NotImplementedException(); }
    public SqlDecimal(decimal value) { throw new System.NotImplementedException(); }
    public SqlDecimal(double dVal) { throw new System.NotImplementedException(); }
    public SqlDecimal(int value) { throw new System.NotImplementedException(); }
    public SqlDecimal(long value) { throw new System.NotImplementedException(); }
    public byte[] BinData { get { return default(byte[]); } }
    public int[] Data { get { return default(int[]); } }
    public bool IsNull { get { return default(bool); } }
    public bool IsPositive { get { return default(bool); } }
    public byte Precision { get { return default(byte); } }
    public byte Scale { get { return default(byte); } }
    public decimal Value { get { return default(decimal); } }
    public static System.Data.SqlTypes.SqlDecimal Abs(System.Data.SqlTypes.SqlDecimal n) { return default(System.Data.SqlTypes.SqlDecimal); }
    public static System.Data.SqlTypes.SqlDecimal Add(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y) { return default(System.Data.SqlTypes.SqlDecimal); }
    public static System.Data.SqlTypes.SqlDecimal AdjustScale(System.Data.SqlTypes.SqlDecimal n, int digits, bool fRound) { return default(System.Data.SqlTypes.SqlDecimal); }
    public static System.Data.SqlTypes.SqlDecimal Ceiling(System.Data.SqlTypes.SqlDecimal n) { return default(System.Data.SqlTypes.SqlDecimal); }
    public int CompareTo(System.Data.SqlTypes.SqlDecimal value) { return default(int); }
    public int CompareTo(object value) { return default(int); }
    public static System.Data.SqlTypes.SqlDecimal ConvertToPrecScale(System.Data.SqlTypes.SqlDecimal n, int precision, int scale) { return default(System.Data.SqlTypes.SqlDecimal); }
    public static System.Data.SqlTypes.SqlDecimal Divide(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y) { return default(System.Data.SqlTypes.SqlDecimal); }
    public static System.Data.SqlTypes.SqlBoolean Equals(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public override bool Equals(object value) { return default(bool); }
    public static System.Data.SqlTypes.SqlDecimal Floor(System.Data.SqlTypes.SqlDecimal n) { return default(System.Data.SqlTypes.SqlDecimal); }
    public override int GetHashCode() { return default(int); }
    public static System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean GreaterThanOrEqual(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean LessThanOrEqual(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlDecimal Multiply(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y) { return default(System.Data.SqlTypes.SqlDecimal); }
    public static System.Data.SqlTypes.SqlBoolean NotEquals(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlDecimal operator +(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y) { return default(System.Data.SqlTypes.SqlDecimal); }
    public static System.Data.SqlTypes.SqlDecimal operator /(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y) { return default(System.Data.SqlTypes.SqlDecimal); }
    public static System.Data.SqlTypes.SqlBoolean operator ==(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static explicit operator System.Data.SqlTypes.SqlDecimal (System.Data.SqlTypes.SqlBoolean x) { return default(System.Data.SqlTypes.SqlDecimal); }
    public static explicit operator decimal (System.Data.SqlTypes.SqlDecimal x) { return default(decimal); }
    public static explicit operator System.Data.SqlTypes.SqlDecimal (System.Data.SqlTypes.SqlDouble x) { return default(System.Data.SqlTypes.SqlDecimal); }
    public static explicit operator System.Data.SqlTypes.SqlDecimal (System.Data.SqlTypes.SqlSingle x) { return default(System.Data.SqlTypes.SqlDecimal); }
    public static explicit operator System.Data.SqlTypes.SqlDecimal (System.Data.SqlTypes.SqlString x) { return default(System.Data.SqlTypes.SqlDecimal); }
    public static explicit operator System.Data.SqlTypes.SqlDecimal (double x) { return default(System.Data.SqlTypes.SqlDecimal); }
    public static System.Data.SqlTypes.SqlBoolean operator >(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean operator >=(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static implicit operator System.Data.SqlTypes.SqlDecimal (System.Data.SqlTypes.SqlByte x) { return default(System.Data.SqlTypes.SqlDecimal); }
    public static implicit operator System.Data.SqlTypes.SqlDecimal (System.Data.SqlTypes.SqlInt16 x) { return default(System.Data.SqlTypes.SqlDecimal); }
    public static implicit operator System.Data.SqlTypes.SqlDecimal (System.Data.SqlTypes.SqlInt32 x) { return default(System.Data.SqlTypes.SqlDecimal); }
    public static implicit operator System.Data.SqlTypes.SqlDecimal (System.Data.SqlTypes.SqlInt64 x) { return default(System.Data.SqlTypes.SqlDecimal); }
    public static implicit operator System.Data.SqlTypes.SqlDecimal (System.Data.SqlTypes.SqlMoney x) { return default(System.Data.SqlTypes.SqlDecimal); }
    public static implicit operator System.Data.SqlTypes.SqlDecimal (decimal x) { return default(System.Data.SqlTypes.SqlDecimal); }
    public static implicit operator System.Data.SqlTypes.SqlDecimal (long x) { return default(System.Data.SqlTypes.SqlDecimal); }
    public static System.Data.SqlTypes.SqlBoolean operator !=(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean operator <(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean operator <=(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlDecimal operator *(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y) { return default(System.Data.SqlTypes.SqlDecimal); }
    public static System.Data.SqlTypes.SqlDecimal operator -(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y) { return default(System.Data.SqlTypes.SqlDecimal); }
    public static System.Data.SqlTypes.SqlDecimal operator -(System.Data.SqlTypes.SqlDecimal x) { return default(System.Data.SqlTypes.SqlDecimal); }
    public static System.Data.SqlTypes.SqlDecimal Parse(string s) { return default(System.Data.SqlTypes.SqlDecimal); }
    public static System.Data.SqlTypes.SqlDecimal Power(System.Data.SqlTypes.SqlDecimal n, double exp) { return default(System.Data.SqlTypes.SqlDecimal); }
    public static System.Data.SqlTypes.SqlDecimal Round(System.Data.SqlTypes.SqlDecimal n, int position) { return default(System.Data.SqlTypes.SqlDecimal); }
    public static System.Data.SqlTypes.SqlInt32 Sign(System.Data.SqlTypes.SqlDecimal n) { return default(System.Data.SqlTypes.SqlInt32); }
    public static System.Data.SqlTypes.SqlDecimal Subtract(System.Data.SqlTypes.SqlDecimal x, System.Data.SqlTypes.SqlDecimal y) { return default(System.Data.SqlTypes.SqlDecimal); }
    public double ToDouble() { return default(double); }
    public System.Data.SqlTypes.SqlBoolean ToSqlBoolean() { return default(System.Data.SqlTypes.SqlBoolean); }
    public System.Data.SqlTypes.SqlByte ToSqlByte() { return default(System.Data.SqlTypes.SqlByte); }
    public System.Data.SqlTypes.SqlDouble ToSqlDouble() { return default(System.Data.SqlTypes.SqlDouble); }
    public System.Data.SqlTypes.SqlInt16 ToSqlInt16() { return default(System.Data.SqlTypes.SqlInt16); }
    public System.Data.SqlTypes.SqlInt32 ToSqlInt32() { return default(System.Data.SqlTypes.SqlInt32); }
    public System.Data.SqlTypes.SqlInt64 ToSqlInt64() { return default(System.Data.SqlTypes.SqlInt64); }
    public System.Data.SqlTypes.SqlMoney ToSqlMoney() { return default(System.Data.SqlTypes.SqlMoney); }
    public System.Data.SqlTypes.SqlSingle ToSqlSingle() { return default(System.Data.SqlTypes.SqlSingle); }
    public System.Data.SqlTypes.SqlString ToSqlString() { return default(System.Data.SqlTypes.SqlString); }
    public override string ToString() { return default(string); }
    public static System.Data.SqlTypes.SqlDecimal Truncate(System.Data.SqlTypes.SqlDecimal n, int position) { return default(System.Data.SqlTypes.SqlDecimal); }
  }

  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct SqlDouble : System.Data.SqlTypes.INullable, System.IComparable {
    public static readonly System.Data.SqlTypes.SqlDouble MaxValue;
    public static readonly System.Data.SqlTypes.SqlDouble MinValue;
    public static readonly System.Data.SqlTypes.SqlDouble Null;
    public static readonly System.Data.SqlTypes.SqlDouble Zero;
    public SqlDouble(double value) { throw new System.NotImplementedException(); }
    public bool IsNull { get { return default(bool); } }
    public double Value { get { return default(double); } }
    public static System.Data.SqlTypes.SqlDouble Add(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y) { return default(System.Data.SqlTypes.SqlDouble); }
    public int CompareTo(System.Data.SqlTypes.SqlDouble value) { return default(int); }
    public int CompareTo(object value) { return default(int); }
    public static System.Data.SqlTypes.SqlDouble Divide(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y) { return default(System.Data.SqlTypes.SqlDouble); }
    public static System.Data.SqlTypes.SqlBoolean Equals(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public override bool Equals(object value) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean GreaterThanOrEqual(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean LessThanOrEqual(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlDouble Multiply(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y) { return default(System.Data.SqlTypes.SqlDouble); }
    public static System.Data.SqlTypes.SqlBoolean NotEquals(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlDouble operator +(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y) { return default(System.Data.SqlTypes.SqlDouble); }
    public static System.Data.SqlTypes.SqlDouble operator /(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y) { return default(System.Data.SqlTypes.SqlDouble); }
    public static System.Data.SqlTypes.SqlBoolean operator ==(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static explicit operator System.Data.SqlTypes.SqlDouble (System.Data.SqlTypes.SqlBoolean x) { return default(System.Data.SqlTypes.SqlDouble); }
    public static explicit operator double (System.Data.SqlTypes.SqlDouble x) { return default(double); }
    public static explicit operator System.Data.SqlTypes.SqlDouble (System.Data.SqlTypes.SqlString x) { return default(System.Data.SqlTypes.SqlDouble); }
    public static System.Data.SqlTypes.SqlBoolean operator >(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean operator >=(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static implicit operator System.Data.SqlTypes.SqlDouble (System.Data.SqlTypes.SqlByte x) { return default(System.Data.SqlTypes.SqlDouble); }
    public static implicit operator System.Data.SqlTypes.SqlDouble (System.Data.SqlTypes.SqlDecimal x) { return default(System.Data.SqlTypes.SqlDouble); }
    public static implicit operator System.Data.SqlTypes.SqlDouble (System.Data.SqlTypes.SqlInt16 x) { return default(System.Data.SqlTypes.SqlDouble); }
    public static implicit operator System.Data.SqlTypes.SqlDouble (System.Data.SqlTypes.SqlInt32 x) { return default(System.Data.SqlTypes.SqlDouble); }
    public static implicit operator System.Data.SqlTypes.SqlDouble (System.Data.SqlTypes.SqlInt64 x) { return default(System.Data.SqlTypes.SqlDouble); }
    public static implicit operator System.Data.SqlTypes.SqlDouble (System.Data.SqlTypes.SqlMoney x) { return default(System.Data.SqlTypes.SqlDouble); }
    public static implicit operator System.Data.SqlTypes.SqlDouble (System.Data.SqlTypes.SqlSingle x) { return default(System.Data.SqlTypes.SqlDouble); }
    public static implicit operator System.Data.SqlTypes.SqlDouble (double x) { return default(System.Data.SqlTypes.SqlDouble); }
    public static System.Data.SqlTypes.SqlBoolean operator !=(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean operator <(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean operator <=(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlDouble operator *(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y) { return default(System.Data.SqlTypes.SqlDouble); }
    public static System.Data.SqlTypes.SqlDouble operator -(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y) { return default(System.Data.SqlTypes.SqlDouble); }
    public static System.Data.SqlTypes.SqlDouble operator -(System.Data.SqlTypes.SqlDouble x) { return default(System.Data.SqlTypes.SqlDouble); }
    public static System.Data.SqlTypes.SqlDouble Parse(string s) { return default(System.Data.SqlTypes.SqlDouble); }
    public static System.Data.SqlTypes.SqlDouble Subtract(System.Data.SqlTypes.SqlDouble x, System.Data.SqlTypes.SqlDouble y) { return default(System.Data.SqlTypes.SqlDouble); }
    public System.Data.SqlTypes.SqlBoolean ToSqlBoolean() { return default(System.Data.SqlTypes.SqlBoolean); }
    public System.Data.SqlTypes.SqlByte ToSqlByte() { return default(System.Data.SqlTypes.SqlByte); }
    public System.Data.SqlTypes.SqlDecimal ToSqlDecimal() { return default(System.Data.SqlTypes.SqlDecimal); }
    public System.Data.SqlTypes.SqlInt16 ToSqlInt16() { return default(System.Data.SqlTypes.SqlInt16); }
    public System.Data.SqlTypes.SqlInt32 ToSqlInt32() { return default(System.Data.SqlTypes.SqlInt32); }
    public System.Data.SqlTypes.SqlInt64 ToSqlInt64() { return default(System.Data.SqlTypes.SqlInt64); }
    public System.Data.SqlTypes.SqlMoney ToSqlMoney() { return default(System.Data.SqlTypes.SqlMoney); }
    public System.Data.SqlTypes.SqlSingle ToSqlSingle() { return default(System.Data.SqlTypes.SqlSingle); }
    public System.Data.SqlTypes.SqlString ToSqlString() { return default(System.Data.SqlTypes.SqlString); }
    public override string ToString() { return default(string); }
  }

  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct SqlGuid : System.Data.SqlTypes.INullable, System.IComparable {
    public static readonly System.Data.SqlTypes.SqlGuid Null;
    public SqlGuid(byte[] value) { throw new System.NotImplementedException(); }
    public SqlGuid(System.Guid g) { throw new System.NotImplementedException(); }
    public SqlGuid(int a, short b, short c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k) { throw new System.NotImplementedException(); }
    public SqlGuid(string s) { throw new System.NotImplementedException(); }
    public bool IsNull { get { return default(bool); } }
    public System.Guid Value { get { return default(System.Guid); } }
    public int CompareTo(System.Data.SqlTypes.SqlGuid value) { return default(int); }
    public int CompareTo(object value) { return default(int); }
    public static System.Data.SqlTypes.SqlBoolean Equals(System.Data.SqlTypes.SqlGuid x, System.Data.SqlTypes.SqlGuid y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public override bool Equals(object value) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlGuid x, System.Data.SqlTypes.SqlGuid y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean GreaterThanOrEqual(System.Data.SqlTypes.SqlGuid x, System.Data.SqlTypes.SqlGuid y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlGuid x, System.Data.SqlTypes.SqlGuid y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean LessThanOrEqual(System.Data.SqlTypes.SqlGuid x, System.Data.SqlTypes.SqlGuid y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean NotEquals(System.Data.SqlTypes.SqlGuid x, System.Data.SqlTypes.SqlGuid y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean operator ==(System.Data.SqlTypes.SqlGuid x, System.Data.SqlTypes.SqlGuid y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static explicit operator System.Data.SqlTypes.SqlGuid (System.Data.SqlTypes.SqlBinary x) { return default(System.Data.SqlTypes.SqlGuid); }
    public static explicit operator System.Guid (System.Data.SqlTypes.SqlGuid x) { return default(System.Guid); }
    public static explicit operator System.Data.SqlTypes.SqlGuid (System.Data.SqlTypes.SqlString x) { return default(System.Data.SqlTypes.SqlGuid); }
    public static System.Data.SqlTypes.SqlBoolean operator >(System.Data.SqlTypes.SqlGuid x, System.Data.SqlTypes.SqlGuid y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean operator >=(System.Data.SqlTypes.SqlGuid x, System.Data.SqlTypes.SqlGuid y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static implicit operator System.Data.SqlTypes.SqlGuid (System.Guid x) { return default(System.Data.SqlTypes.SqlGuid); }
    public static System.Data.SqlTypes.SqlBoolean operator !=(System.Data.SqlTypes.SqlGuid x, System.Data.SqlTypes.SqlGuid y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean operator <(System.Data.SqlTypes.SqlGuid x, System.Data.SqlTypes.SqlGuid y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean operator <=(System.Data.SqlTypes.SqlGuid x, System.Data.SqlTypes.SqlGuid y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlGuid Parse(string s) { return default(System.Data.SqlTypes.SqlGuid); }
    public byte[] ToByteArray() { return default(byte[]); }
    public System.Data.SqlTypes.SqlBinary ToSqlBinary() { return default(System.Data.SqlTypes.SqlBinary); }
    public System.Data.SqlTypes.SqlString ToSqlString() { return default(System.Data.SqlTypes.SqlString); }
    public override string ToString() { return default(string); }
  }

  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct SqlInt16 : System.Data.SqlTypes.INullable, System.IComparable {
    public static readonly System.Data.SqlTypes.SqlInt16 MaxValue;
    public static readonly System.Data.SqlTypes.SqlInt16 MinValue;
    public static readonly System.Data.SqlTypes.SqlInt16 Null;
    public static readonly System.Data.SqlTypes.SqlInt16 Zero;
    public SqlInt16(short value) { throw new System.NotImplementedException(); }
    public bool IsNull { get { return default(bool); } }
    public short Value { get { return default(short); } }
    public static System.Data.SqlTypes.SqlInt16 Add(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { return default(System.Data.SqlTypes.SqlInt16); }
    public static System.Data.SqlTypes.SqlInt16 BitwiseAnd(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { return default(System.Data.SqlTypes.SqlInt16); }
    public static System.Data.SqlTypes.SqlInt16 BitwiseOr(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { return default(System.Data.SqlTypes.SqlInt16); }
    public int CompareTo(System.Data.SqlTypes.SqlInt16 value) { return default(int); }
    public int CompareTo(object value) { return default(int); }
    public static System.Data.SqlTypes.SqlInt16 Divide(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { return default(System.Data.SqlTypes.SqlInt16); }
    public static System.Data.SqlTypes.SqlBoolean Equals(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public override bool Equals(object value) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean GreaterThanOrEqual(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean LessThanOrEqual(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlInt16 Mod(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { return default(System.Data.SqlTypes.SqlInt16); }
    public static System.Data.SqlTypes.SqlInt16 Modulus(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { return default(System.Data.SqlTypes.SqlInt16); }
    public static System.Data.SqlTypes.SqlInt16 Multiply(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { return default(System.Data.SqlTypes.SqlInt16); }
    public static System.Data.SqlTypes.SqlBoolean NotEquals(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlInt16 OnesComplement(System.Data.SqlTypes.SqlInt16 x) { return default(System.Data.SqlTypes.SqlInt16); }
    public static System.Data.SqlTypes.SqlInt16 operator +(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { return default(System.Data.SqlTypes.SqlInt16); }
    public static System.Data.SqlTypes.SqlInt16 operator &(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { return default(System.Data.SqlTypes.SqlInt16); }
    public static System.Data.SqlTypes.SqlInt16 operator |(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { return default(System.Data.SqlTypes.SqlInt16); }
    public static System.Data.SqlTypes.SqlInt16 operator /(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { return default(System.Data.SqlTypes.SqlInt16); }
    public static System.Data.SqlTypes.SqlBoolean operator ==(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlInt16 operator ^(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { return default(System.Data.SqlTypes.SqlInt16); }
    public static explicit operator System.Data.SqlTypes.SqlInt16 (System.Data.SqlTypes.SqlBoolean x) { return default(System.Data.SqlTypes.SqlInt16); }
    public static explicit operator System.Data.SqlTypes.SqlInt16 (System.Data.SqlTypes.SqlDecimal x) { return default(System.Data.SqlTypes.SqlInt16); }
    public static explicit operator System.Data.SqlTypes.SqlInt16 (System.Data.SqlTypes.SqlDouble x) { return default(System.Data.SqlTypes.SqlInt16); }
    public static explicit operator short (System.Data.SqlTypes.SqlInt16 x) { return default(short); }
    public static explicit operator System.Data.SqlTypes.SqlInt16 (System.Data.SqlTypes.SqlInt32 x) { return default(System.Data.SqlTypes.SqlInt16); }
    public static explicit operator System.Data.SqlTypes.SqlInt16 (System.Data.SqlTypes.SqlInt64 x) { return default(System.Data.SqlTypes.SqlInt16); }
    public static explicit operator System.Data.SqlTypes.SqlInt16 (System.Data.SqlTypes.SqlMoney x) { return default(System.Data.SqlTypes.SqlInt16); }
    public static explicit operator System.Data.SqlTypes.SqlInt16 (System.Data.SqlTypes.SqlSingle x) { return default(System.Data.SqlTypes.SqlInt16); }
    public static explicit operator System.Data.SqlTypes.SqlInt16 (System.Data.SqlTypes.SqlString x) { return default(System.Data.SqlTypes.SqlInt16); }
    public static System.Data.SqlTypes.SqlBoolean operator >(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean operator >=(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static implicit operator System.Data.SqlTypes.SqlInt16 (System.Data.SqlTypes.SqlByte x) { return default(System.Data.SqlTypes.SqlInt16); }
    public static implicit operator System.Data.SqlTypes.SqlInt16 (short x) { return default(System.Data.SqlTypes.SqlInt16); }
    public static System.Data.SqlTypes.SqlBoolean operator !=(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean operator <(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean operator <=(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlInt16 operator %(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { return default(System.Data.SqlTypes.SqlInt16); }
    public static System.Data.SqlTypes.SqlInt16 operator *(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { return default(System.Data.SqlTypes.SqlInt16); }
    public static System.Data.SqlTypes.SqlInt16 operator ~(System.Data.SqlTypes.SqlInt16 x) { return default(System.Data.SqlTypes.SqlInt16); }
    public static System.Data.SqlTypes.SqlInt16 operator -(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { return default(System.Data.SqlTypes.SqlInt16); }
    public static System.Data.SqlTypes.SqlInt16 operator -(System.Data.SqlTypes.SqlInt16 x) { return default(System.Data.SqlTypes.SqlInt16); }
    public static System.Data.SqlTypes.SqlInt16 Parse(string s) { return default(System.Data.SqlTypes.SqlInt16); }
    public static System.Data.SqlTypes.SqlInt16 Subtract(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { return default(System.Data.SqlTypes.SqlInt16); }
    public System.Data.SqlTypes.SqlBoolean ToSqlBoolean() { return default(System.Data.SqlTypes.SqlBoolean); }
    public System.Data.SqlTypes.SqlByte ToSqlByte() { return default(System.Data.SqlTypes.SqlByte); }
    public System.Data.SqlTypes.SqlDecimal ToSqlDecimal() { return default(System.Data.SqlTypes.SqlDecimal); }
    public System.Data.SqlTypes.SqlDouble ToSqlDouble() { return default(System.Data.SqlTypes.SqlDouble); }
    public System.Data.SqlTypes.SqlInt32 ToSqlInt32() { return default(System.Data.SqlTypes.SqlInt32); }
    public System.Data.SqlTypes.SqlInt64 ToSqlInt64() { return default(System.Data.SqlTypes.SqlInt64); }
    public System.Data.SqlTypes.SqlMoney ToSqlMoney() { return default(System.Data.SqlTypes.SqlMoney); }
    public System.Data.SqlTypes.SqlSingle ToSqlSingle() { return default(System.Data.SqlTypes.SqlSingle); }
    public System.Data.SqlTypes.SqlString ToSqlString() { return default(System.Data.SqlTypes.SqlString); }
    public override string ToString() { return default(string); }
    public static System.Data.SqlTypes.SqlInt16 Xor(System.Data.SqlTypes.SqlInt16 x, System.Data.SqlTypes.SqlInt16 y) { return default(System.Data.SqlTypes.SqlInt16); }
  }

  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct SqlInt32 : System.Data.SqlTypes.INullable, System.IComparable {
    public static readonly System.Data.SqlTypes.SqlInt32 MaxValue;
    public static readonly System.Data.SqlTypes.SqlInt32 MinValue;
    public static readonly System.Data.SqlTypes.SqlInt32 Null;
    public static readonly System.Data.SqlTypes.SqlInt32 Zero;
    public SqlInt32(int value) { throw new System.NotImplementedException(); }
    public bool IsNull { get { return default(bool); } }
    public int Value { get { return default(int); } }
    public static System.Data.SqlTypes.SqlInt32 Add(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { return default(System.Data.SqlTypes.SqlInt32); }
    public static System.Data.SqlTypes.SqlInt32 BitwiseAnd(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { return default(System.Data.SqlTypes.SqlInt32); }
    public static System.Data.SqlTypes.SqlInt32 BitwiseOr(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { return default(System.Data.SqlTypes.SqlInt32); }
    public int CompareTo(System.Data.SqlTypes.SqlInt32 value) { return default(int); }
    public int CompareTo(object value) { return default(int); }
    public static System.Data.SqlTypes.SqlInt32 Divide(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { return default(System.Data.SqlTypes.SqlInt32); }
    public static System.Data.SqlTypes.SqlBoolean Equals(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public override bool Equals(object value) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean GreaterThanOrEqual(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean LessThanOrEqual(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlInt32 Mod(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { return default(System.Data.SqlTypes.SqlInt32); }
    public static System.Data.SqlTypes.SqlInt32 Modulus(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { return default(System.Data.SqlTypes.SqlInt32); }
    public static System.Data.SqlTypes.SqlInt32 Multiply(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { return default(System.Data.SqlTypes.SqlInt32); }
    public static System.Data.SqlTypes.SqlBoolean NotEquals(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlInt32 OnesComplement(System.Data.SqlTypes.SqlInt32 x) { return default(System.Data.SqlTypes.SqlInt32); }
    public static System.Data.SqlTypes.SqlInt32 operator +(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { return default(System.Data.SqlTypes.SqlInt32); }
    public static System.Data.SqlTypes.SqlInt32 operator &(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { return default(System.Data.SqlTypes.SqlInt32); }
    public static System.Data.SqlTypes.SqlInt32 operator |(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { return default(System.Data.SqlTypes.SqlInt32); }
    public static System.Data.SqlTypes.SqlInt32 operator /(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { return default(System.Data.SqlTypes.SqlInt32); }
    public static System.Data.SqlTypes.SqlBoolean operator ==(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlInt32 operator ^(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { return default(System.Data.SqlTypes.SqlInt32); }
    public static explicit operator System.Data.SqlTypes.SqlInt32 (System.Data.SqlTypes.SqlBoolean x) { return default(System.Data.SqlTypes.SqlInt32); }
    public static explicit operator System.Data.SqlTypes.SqlInt32 (System.Data.SqlTypes.SqlDecimal x) { return default(System.Data.SqlTypes.SqlInt32); }
    public static explicit operator System.Data.SqlTypes.SqlInt32 (System.Data.SqlTypes.SqlDouble x) { return default(System.Data.SqlTypes.SqlInt32); }
    public static explicit operator int (System.Data.SqlTypes.SqlInt32 x) { return default(int); }
    public static explicit operator System.Data.SqlTypes.SqlInt32 (System.Data.SqlTypes.SqlInt64 x) { return default(System.Data.SqlTypes.SqlInt32); }
    public static explicit operator System.Data.SqlTypes.SqlInt32 (System.Data.SqlTypes.SqlMoney x) { return default(System.Data.SqlTypes.SqlInt32); }
    public static explicit operator System.Data.SqlTypes.SqlInt32 (System.Data.SqlTypes.SqlSingle x) { return default(System.Data.SqlTypes.SqlInt32); }
    public static explicit operator System.Data.SqlTypes.SqlInt32 (System.Data.SqlTypes.SqlString x) { return default(System.Data.SqlTypes.SqlInt32); }
    public static System.Data.SqlTypes.SqlBoolean operator >(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean operator >=(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static implicit operator System.Data.SqlTypes.SqlInt32 (System.Data.SqlTypes.SqlByte x) { return default(System.Data.SqlTypes.SqlInt32); }
    public static implicit operator System.Data.SqlTypes.SqlInt32 (System.Data.SqlTypes.SqlInt16 x) { return default(System.Data.SqlTypes.SqlInt32); }
    public static implicit operator System.Data.SqlTypes.SqlInt32 (int x) { return default(System.Data.SqlTypes.SqlInt32); }
    public static System.Data.SqlTypes.SqlBoolean operator !=(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean operator <(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean operator <=(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlInt32 operator %(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { return default(System.Data.SqlTypes.SqlInt32); }
    public static System.Data.SqlTypes.SqlInt32 operator *(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { return default(System.Data.SqlTypes.SqlInt32); }
    public static System.Data.SqlTypes.SqlInt32 operator ~(System.Data.SqlTypes.SqlInt32 x) { return default(System.Data.SqlTypes.SqlInt32); }
    public static System.Data.SqlTypes.SqlInt32 operator -(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { return default(System.Data.SqlTypes.SqlInt32); }
    public static System.Data.SqlTypes.SqlInt32 operator -(System.Data.SqlTypes.SqlInt32 x) { return default(System.Data.SqlTypes.SqlInt32); }
    public static System.Data.SqlTypes.SqlInt32 Parse(string s) { return default(System.Data.SqlTypes.SqlInt32); }
    public static System.Data.SqlTypes.SqlInt32 Subtract(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { return default(System.Data.SqlTypes.SqlInt32); }
    public System.Data.SqlTypes.SqlBoolean ToSqlBoolean() { return default(System.Data.SqlTypes.SqlBoolean); }
    public System.Data.SqlTypes.SqlByte ToSqlByte() { return default(System.Data.SqlTypes.SqlByte); }
    public System.Data.SqlTypes.SqlDecimal ToSqlDecimal() { return default(System.Data.SqlTypes.SqlDecimal); }
    public System.Data.SqlTypes.SqlDouble ToSqlDouble() { return default(System.Data.SqlTypes.SqlDouble); }
    public System.Data.SqlTypes.SqlInt16 ToSqlInt16() { return default(System.Data.SqlTypes.SqlInt16); }
    public System.Data.SqlTypes.SqlInt64 ToSqlInt64() { return default(System.Data.SqlTypes.SqlInt64); }
    public System.Data.SqlTypes.SqlMoney ToSqlMoney() { return default(System.Data.SqlTypes.SqlMoney); }
    public System.Data.SqlTypes.SqlSingle ToSqlSingle() { return default(System.Data.SqlTypes.SqlSingle); }
    public System.Data.SqlTypes.SqlString ToSqlString() { return default(System.Data.SqlTypes.SqlString); }
    public override string ToString() { return default(string); }
    public static System.Data.SqlTypes.SqlInt32 Xor(System.Data.SqlTypes.SqlInt32 x, System.Data.SqlTypes.SqlInt32 y) { return default(System.Data.SqlTypes.SqlInt32); }
  }

  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct SqlInt64 : System.Data.SqlTypes.INullable, System.IComparable {
    public static readonly System.Data.SqlTypes.SqlInt64 MaxValue;
    public static readonly System.Data.SqlTypes.SqlInt64 MinValue;
    public static readonly System.Data.SqlTypes.SqlInt64 Null;
    public static readonly System.Data.SqlTypes.SqlInt64 Zero;
    public SqlInt64(long value) { throw new System.NotImplementedException(); }
    public bool IsNull { get { return default(bool); } }
    public long Value { get { return default(long); } }
    public static System.Data.SqlTypes.SqlInt64 Add(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { return default(System.Data.SqlTypes.SqlInt64); }
    public static System.Data.SqlTypes.SqlInt64 BitwiseAnd(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { return default(System.Data.SqlTypes.SqlInt64); }
    public static System.Data.SqlTypes.SqlInt64 BitwiseOr(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { return default(System.Data.SqlTypes.SqlInt64); }
    public int CompareTo(System.Data.SqlTypes.SqlInt64 value) { return default(int); }
    public int CompareTo(object value) { return default(int); }
    public static System.Data.SqlTypes.SqlInt64 Divide(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { return default(System.Data.SqlTypes.SqlInt64); }
    public static System.Data.SqlTypes.SqlBoolean Equals(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public override bool Equals(object value) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean GreaterThanOrEqual(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean LessThanOrEqual(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlInt64 Mod(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { return default(System.Data.SqlTypes.SqlInt64); }
    public static System.Data.SqlTypes.SqlInt64 Modulus(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { return default(System.Data.SqlTypes.SqlInt64); }
    public static System.Data.SqlTypes.SqlInt64 Multiply(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { return default(System.Data.SqlTypes.SqlInt64); }
    public static System.Data.SqlTypes.SqlBoolean NotEquals(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlInt64 OnesComplement(System.Data.SqlTypes.SqlInt64 x) { return default(System.Data.SqlTypes.SqlInt64); }
    public static System.Data.SqlTypes.SqlInt64 operator +(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { return default(System.Data.SqlTypes.SqlInt64); }
    public static System.Data.SqlTypes.SqlInt64 operator &(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { return default(System.Data.SqlTypes.SqlInt64); }
    public static System.Data.SqlTypes.SqlInt64 operator |(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { return default(System.Data.SqlTypes.SqlInt64); }
    public static System.Data.SqlTypes.SqlInt64 operator /(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { return default(System.Data.SqlTypes.SqlInt64); }
    public static System.Data.SqlTypes.SqlBoolean operator ==(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlInt64 operator ^(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { return default(System.Data.SqlTypes.SqlInt64); }
    public static explicit operator System.Data.SqlTypes.SqlInt64 (System.Data.SqlTypes.SqlBoolean x) { return default(System.Data.SqlTypes.SqlInt64); }
    public static explicit operator System.Data.SqlTypes.SqlInt64 (System.Data.SqlTypes.SqlDecimal x) { return default(System.Data.SqlTypes.SqlInt64); }
    public static explicit operator System.Data.SqlTypes.SqlInt64 (System.Data.SqlTypes.SqlDouble x) { return default(System.Data.SqlTypes.SqlInt64); }
    public static explicit operator long (System.Data.SqlTypes.SqlInt64 x) { return default(long); }
    public static explicit operator System.Data.SqlTypes.SqlInt64 (System.Data.SqlTypes.SqlMoney x) { return default(System.Data.SqlTypes.SqlInt64); }
    public static explicit operator System.Data.SqlTypes.SqlInt64 (System.Data.SqlTypes.SqlSingle x) { return default(System.Data.SqlTypes.SqlInt64); }
    public static explicit operator System.Data.SqlTypes.SqlInt64 (System.Data.SqlTypes.SqlString x) { return default(System.Data.SqlTypes.SqlInt64); }
    public static System.Data.SqlTypes.SqlBoolean operator >(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean operator >=(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static implicit operator System.Data.SqlTypes.SqlInt64 (System.Data.SqlTypes.SqlByte x) { return default(System.Data.SqlTypes.SqlInt64); }
    public static implicit operator System.Data.SqlTypes.SqlInt64 (System.Data.SqlTypes.SqlInt16 x) { return default(System.Data.SqlTypes.SqlInt64); }
    public static implicit operator System.Data.SqlTypes.SqlInt64 (System.Data.SqlTypes.SqlInt32 x) { return default(System.Data.SqlTypes.SqlInt64); }
    public static implicit operator System.Data.SqlTypes.SqlInt64 (long x) { return default(System.Data.SqlTypes.SqlInt64); }
    public static System.Data.SqlTypes.SqlBoolean operator !=(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean operator <(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean operator <=(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlInt64 operator %(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { return default(System.Data.SqlTypes.SqlInt64); }
    public static System.Data.SqlTypes.SqlInt64 operator *(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { return default(System.Data.SqlTypes.SqlInt64); }
    public static System.Data.SqlTypes.SqlInt64 operator ~(System.Data.SqlTypes.SqlInt64 x) { return default(System.Data.SqlTypes.SqlInt64); }
    public static System.Data.SqlTypes.SqlInt64 operator -(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { return default(System.Data.SqlTypes.SqlInt64); }
    public static System.Data.SqlTypes.SqlInt64 operator -(System.Data.SqlTypes.SqlInt64 x) { return default(System.Data.SqlTypes.SqlInt64); }
    public static System.Data.SqlTypes.SqlInt64 Parse(string s) { return default(System.Data.SqlTypes.SqlInt64); }
    public static System.Data.SqlTypes.SqlInt64 Subtract(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { return default(System.Data.SqlTypes.SqlInt64); }
    public System.Data.SqlTypes.SqlBoolean ToSqlBoolean() { return default(System.Data.SqlTypes.SqlBoolean); }
    public System.Data.SqlTypes.SqlByte ToSqlByte() { return default(System.Data.SqlTypes.SqlByte); }
    public System.Data.SqlTypes.SqlDecimal ToSqlDecimal() { return default(System.Data.SqlTypes.SqlDecimal); }
    public System.Data.SqlTypes.SqlDouble ToSqlDouble() { return default(System.Data.SqlTypes.SqlDouble); }
    public System.Data.SqlTypes.SqlInt16 ToSqlInt16() { return default(System.Data.SqlTypes.SqlInt16); }
    public System.Data.SqlTypes.SqlInt32 ToSqlInt32() { return default(System.Data.SqlTypes.SqlInt32); }
    public System.Data.SqlTypes.SqlMoney ToSqlMoney() { return default(System.Data.SqlTypes.SqlMoney); }
    public System.Data.SqlTypes.SqlSingle ToSqlSingle() { return default(System.Data.SqlTypes.SqlSingle); }
    public System.Data.SqlTypes.SqlString ToSqlString() { return default(System.Data.SqlTypes.SqlString); }
    public override string ToString() { return default(string); }
    public static System.Data.SqlTypes.SqlInt64 Xor(System.Data.SqlTypes.SqlInt64 x, System.Data.SqlTypes.SqlInt64 y) { return default(System.Data.SqlTypes.SqlInt64); }
  }

  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct SqlMoney : System.Data.SqlTypes.INullable, System.IComparable {
    public static readonly System.Data.SqlTypes.SqlMoney MaxValue;
    public static readonly System.Data.SqlTypes.SqlMoney MinValue;
    public static readonly System.Data.SqlTypes.SqlMoney Null;
    public static readonly System.Data.SqlTypes.SqlMoney Zero;
    public SqlMoney(decimal value) { throw new System.NotImplementedException(); }
    public SqlMoney(double value) { throw new System.NotImplementedException(); }
    public SqlMoney(int value) { throw new System.NotImplementedException(); }
    public SqlMoney(long value) { throw new System.NotImplementedException(); }
    public bool IsNull { get { return default(bool); } }
    public decimal Value { get { return default(decimal); } }
    public static System.Data.SqlTypes.SqlMoney Add(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y) { return default(System.Data.SqlTypes.SqlMoney); }
    public int CompareTo(System.Data.SqlTypes.SqlMoney value) { return default(int); }
    public int CompareTo(object value) { return default(int); }
    public static System.Data.SqlTypes.SqlMoney Divide(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y) { return default(System.Data.SqlTypes.SqlMoney); }
    public static System.Data.SqlTypes.SqlBoolean Equals(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public override bool Equals(object value) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean GreaterThanOrEqual(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean LessThanOrEqual(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlMoney Multiply(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y) { return default(System.Data.SqlTypes.SqlMoney); }
    public static System.Data.SqlTypes.SqlBoolean NotEquals(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlMoney operator +(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y) { return default(System.Data.SqlTypes.SqlMoney); }
    public static System.Data.SqlTypes.SqlMoney operator /(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y) { return default(System.Data.SqlTypes.SqlMoney); }
    public static System.Data.SqlTypes.SqlBoolean operator ==(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static explicit operator System.Data.SqlTypes.SqlMoney (System.Data.SqlTypes.SqlBoolean x) { return default(System.Data.SqlTypes.SqlMoney); }
    public static explicit operator System.Data.SqlTypes.SqlMoney (System.Data.SqlTypes.SqlDecimal x) { return default(System.Data.SqlTypes.SqlMoney); }
    public static explicit operator System.Data.SqlTypes.SqlMoney (System.Data.SqlTypes.SqlDouble x) { return default(System.Data.SqlTypes.SqlMoney); }
    public static explicit operator decimal (System.Data.SqlTypes.SqlMoney x) { return default(decimal); }
    public static explicit operator System.Data.SqlTypes.SqlMoney (System.Data.SqlTypes.SqlSingle x) { return default(System.Data.SqlTypes.SqlMoney); }
    public static explicit operator System.Data.SqlTypes.SqlMoney (System.Data.SqlTypes.SqlString x) { return default(System.Data.SqlTypes.SqlMoney); }
    public static explicit operator System.Data.SqlTypes.SqlMoney (double x) { return default(System.Data.SqlTypes.SqlMoney); }
    public static System.Data.SqlTypes.SqlBoolean operator >(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean operator >=(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static implicit operator System.Data.SqlTypes.SqlMoney (System.Data.SqlTypes.SqlByte x) { return default(System.Data.SqlTypes.SqlMoney); }
    public static implicit operator System.Data.SqlTypes.SqlMoney (System.Data.SqlTypes.SqlInt16 x) { return default(System.Data.SqlTypes.SqlMoney); }
    public static implicit operator System.Data.SqlTypes.SqlMoney (System.Data.SqlTypes.SqlInt32 x) { return default(System.Data.SqlTypes.SqlMoney); }
    public static implicit operator System.Data.SqlTypes.SqlMoney (System.Data.SqlTypes.SqlInt64 x) { return default(System.Data.SqlTypes.SqlMoney); }
    public static implicit operator System.Data.SqlTypes.SqlMoney (decimal x) { return default(System.Data.SqlTypes.SqlMoney); }
    public static implicit operator System.Data.SqlTypes.SqlMoney (long x) { return default(System.Data.SqlTypes.SqlMoney); }
    public static System.Data.SqlTypes.SqlBoolean operator !=(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean operator <(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean operator <=(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlMoney operator *(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y) { return default(System.Data.SqlTypes.SqlMoney); }
    public static System.Data.SqlTypes.SqlMoney operator -(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y) { return default(System.Data.SqlTypes.SqlMoney); }
    public static System.Data.SqlTypes.SqlMoney operator -(System.Data.SqlTypes.SqlMoney x) { return default(System.Data.SqlTypes.SqlMoney); }
    public static System.Data.SqlTypes.SqlMoney Parse(string s) { return default(System.Data.SqlTypes.SqlMoney); }
    public static System.Data.SqlTypes.SqlMoney Subtract(System.Data.SqlTypes.SqlMoney x, System.Data.SqlTypes.SqlMoney y) { return default(System.Data.SqlTypes.SqlMoney); }
    public decimal ToDecimal() { return default(decimal); }
    public double ToDouble() { return default(double); }
    public int ToInt32() { return default(int); }
    public long ToInt64() { return default(long); }
    public System.Data.SqlTypes.SqlBoolean ToSqlBoolean() { return default(System.Data.SqlTypes.SqlBoolean); }
    public System.Data.SqlTypes.SqlByte ToSqlByte() { return default(System.Data.SqlTypes.SqlByte); }
    public System.Data.SqlTypes.SqlDecimal ToSqlDecimal() { return default(System.Data.SqlTypes.SqlDecimal); }
    public System.Data.SqlTypes.SqlDouble ToSqlDouble() { return default(System.Data.SqlTypes.SqlDouble); }
    public System.Data.SqlTypes.SqlInt16 ToSqlInt16() { return default(System.Data.SqlTypes.SqlInt16); }
    public System.Data.SqlTypes.SqlInt32 ToSqlInt32() { return default(System.Data.SqlTypes.SqlInt32); }
    public System.Data.SqlTypes.SqlInt64 ToSqlInt64() { return default(System.Data.SqlTypes.SqlInt64); }
    public System.Data.SqlTypes.SqlSingle ToSqlSingle() { return default(System.Data.SqlTypes.SqlSingle); }
    public System.Data.SqlTypes.SqlString ToSqlString() { return default(System.Data.SqlTypes.SqlString); }
    public override string ToString() { return default(string); }
  }

  public sealed partial class SqlNullValueException : System.Data.SqlTypes.SqlTypeException {
    public SqlNullValueException() { }
    public SqlNullValueException(string message) { }
    public SqlNullValueException(string message, System.Exception e) { }
  }

  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct SqlSingle : System.Data.SqlTypes.INullable, System.IComparable {
    public static readonly System.Data.SqlTypes.SqlSingle MaxValue;
    public static readonly System.Data.SqlTypes.SqlSingle MinValue;
    public static readonly System.Data.SqlTypes.SqlSingle Null;
    public static readonly System.Data.SqlTypes.SqlSingle Zero;
    public SqlSingle(double value) { throw new System.NotImplementedException(); }
    public SqlSingle(float value) { throw new System.NotImplementedException(); }
    public bool IsNull { get { return default(bool); } }
    public float Value { get { return default(float); } }
    public static System.Data.SqlTypes.SqlSingle Add(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y) { return default(System.Data.SqlTypes.SqlSingle); }
    public int CompareTo(System.Data.SqlTypes.SqlSingle value) { return default(int); }
    public int CompareTo(object value) { return default(int); }
    public static System.Data.SqlTypes.SqlSingle Divide(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y) { return default(System.Data.SqlTypes.SqlSingle); }
    public static System.Data.SqlTypes.SqlBoolean Equals(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public override bool Equals(object value) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean GreaterThanOrEqual(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean LessThanOrEqual(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlSingle Multiply(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y) { return default(System.Data.SqlTypes.SqlSingle); }
    public static System.Data.SqlTypes.SqlBoolean NotEquals(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlSingle operator +(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y) { return default(System.Data.SqlTypes.SqlSingle); }
    public static System.Data.SqlTypes.SqlSingle operator /(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y) { return default(System.Data.SqlTypes.SqlSingle); }
    public static System.Data.SqlTypes.SqlBoolean operator ==(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static explicit operator System.Data.SqlTypes.SqlSingle (System.Data.SqlTypes.SqlBoolean x) { return default(System.Data.SqlTypes.SqlSingle); }
    public static explicit operator System.Data.SqlTypes.SqlSingle (System.Data.SqlTypes.SqlDouble x) { return default(System.Data.SqlTypes.SqlSingle); }
    public static explicit operator float (System.Data.SqlTypes.SqlSingle x) { return default(float); }
    public static explicit operator System.Data.SqlTypes.SqlSingle (System.Data.SqlTypes.SqlString x) { return default(System.Data.SqlTypes.SqlSingle); }
    public static System.Data.SqlTypes.SqlBoolean operator >(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean operator >=(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static implicit operator System.Data.SqlTypes.SqlSingle (System.Data.SqlTypes.SqlByte x) { return default(System.Data.SqlTypes.SqlSingle); }
    public static implicit operator System.Data.SqlTypes.SqlSingle (System.Data.SqlTypes.SqlDecimal x) { return default(System.Data.SqlTypes.SqlSingle); }
    public static implicit operator System.Data.SqlTypes.SqlSingle (System.Data.SqlTypes.SqlInt16 x) { return default(System.Data.SqlTypes.SqlSingle); }
    public static implicit operator System.Data.SqlTypes.SqlSingle (System.Data.SqlTypes.SqlInt32 x) { return default(System.Data.SqlTypes.SqlSingle); }
    public static implicit operator System.Data.SqlTypes.SqlSingle (System.Data.SqlTypes.SqlInt64 x) { return default(System.Data.SqlTypes.SqlSingle); }
    public static implicit operator System.Data.SqlTypes.SqlSingle (System.Data.SqlTypes.SqlMoney x) { return default(System.Data.SqlTypes.SqlSingle); }
    public static implicit operator System.Data.SqlTypes.SqlSingle (float x) { return default(System.Data.SqlTypes.SqlSingle); }
    public static System.Data.SqlTypes.SqlBoolean operator !=(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean operator <(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean operator <=(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlSingle operator *(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y) { return default(System.Data.SqlTypes.SqlSingle); }
    public static System.Data.SqlTypes.SqlSingle operator -(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y) { return default(System.Data.SqlTypes.SqlSingle); }
    public static System.Data.SqlTypes.SqlSingle operator -(System.Data.SqlTypes.SqlSingle x) { return default(System.Data.SqlTypes.SqlSingle); }
    public static System.Data.SqlTypes.SqlSingle Parse(string s) { return default(System.Data.SqlTypes.SqlSingle); }
    public static System.Data.SqlTypes.SqlSingle Subtract(System.Data.SqlTypes.SqlSingle x, System.Data.SqlTypes.SqlSingle y) { return default(System.Data.SqlTypes.SqlSingle); }
    public System.Data.SqlTypes.SqlBoolean ToSqlBoolean() { return default(System.Data.SqlTypes.SqlBoolean); }
    public System.Data.SqlTypes.SqlByte ToSqlByte() { return default(System.Data.SqlTypes.SqlByte); }
    public System.Data.SqlTypes.SqlDecimal ToSqlDecimal() { return default(System.Data.SqlTypes.SqlDecimal); }
    public System.Data.SqlTypes.SqlDouble ToSqlDouble() { return default(System.Data.SqlTypes.SqlDouble); }
    public System.Data.SqlTypes.SqlInt16 ToSqlInt16() { return default(System.Data.SqlTypes.SqlInt16); }
    public System.Data.SqlTypes.SqlInt32 ToSqlInt32() { return default(System.Data.SqlTypes.SqlInt32); }
    public System.Data.SqlTypes.SqlInt64 ToSqlInt64() { return default(System.Data.SqlTypes.SqlInt64); }
    public System.Data.SqlTypes.SqlMoney ToSqlMoney() { return default(System.Data.SqlTypes.SqlMoney); }
    public System.Data.SqlTypes.SqlString ToSqlString() { return default(System.Data.SqlTypes.SqlString); }
    public override string ToString() { return default(string); }
  }

  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct SqlString : System.Data.SqlTypes.INullable, System.IComparable {
    public static readonly int BinarySort;
    public static readonly int BinarySort2;
    public static readonly int IgnoreCase;
    public static readonly int IgnoreKanaType;
    public static readonly int IgnoreNonSpace;
    public static readonly int IgnoreWidth;
    public static readonly System.Data.SqlTypes.SqlString Null;
    public SqlString(int lcid, System.Data.SqlTypes.SqlCompareOptions compareOptions, byte[] data) { throw new System.NotImplementedException(); }
    public SqlString(int lcid, System.Data.SqlTypes.SqlCompareOptions compareOptions, byte[] data, bool fUnicode) { throw new System.NotImplementedException(); }
    public SqlString(int lcid, System.Data.SqlTypes.SqlCompareOptions compareOptions, byte[] data, int index, int count) { throw new System.NotImplementedException(); }
    public SqlString(int lcid, System.Data.SqlTypes.SqlCompareOptions compareOptions, byte[] data, int index, int count, bool fUnicode) { throw new System.NotImplementedException(); }
    public SqlString(string data) { throw new System.NotImplementedException(); }
    public SqlString(string data, int lcid) { throw new System.NotImplementedException(); }
    public SqlString(string data, int lcid, System.Data.SqlTypes.SqlCompareOptions compareOptions) { throw new System.NotImplementedException(); }
    public System.Globalization.CompareInfo CompareInfo { get { return default(System.Globalization.CompareInfo); } }
    public System.Globalization.CultureInfo CultureInfo { get { return default(System.Globalization.CultureInfo); } }
    public bool IsNull { get { return default(bool); } }
    public int LCID { get { return default(int); } }
    public System.Data.SqlTypes.SqlCompareOptions SqlCompareOptions { get { return default(System.Data.SqlTypes.SqlCompareOptions); } }
    public string Value { get { return default(string); } }
    public static System.Data.SqlTypes.SqlString Add(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y) { return default(System.Data.SqlTypes.SqlString); }
    public System.Data.SqlTypes.SqlString Clone() { return default(System.Data.SqlTypes.SqlString); }
    public static System.Globalization.CompareOptions CompareOptionsFromSqlCompareOptions(System.Data.SqlTypes.SqlCompareOptions compareOptions) { return default(System.Globalization.CompareOptions); }
    public int CompareTo(System.Data.SqlTypes.SqlString value) { return default(int); }
    public int CompareTo(object value) { return default(int); }
    public static System.Data.SqlTypes.SqlString Concat(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y) { return default(System.Data.SqlTypes.SqlString); }
    public static System.Data.SqlTypes.SqlBoolean Equals(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public override bool Equals(object value) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public byte[] GetNonUnicodeBytes() { return default(byte[]); }
    public byte[] GetUnicodeBytes() { return default(byte[]); }
    public static System.Data.SqlTypes.SqlBoolean GreaterThan(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean GreaterThanOrEqual(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean LessThan(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean LessThanOrEqual(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean NotEquals(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlString operator +(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y) { return default(System.Data.SqlTypes.SqlString); }
    public static System.Data.SqlTypes.SqlBoolean operator ==(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static explicit operator System.Data.SqlTypes.SqlString (System.Data.SqlTypes.SqlBoolean x) { return default(System.Data.SqlTypes.SqlString); }
    public static explicit operator System.Data.SqlTypes.SqlString (System.Data.SqlTypes.SqlByte x) { return default(System.Data.SqlTypes.SqlString); }
    public static explicit operator System.Data.SqlTypes.SqlString (System.Data.SqlTypes.SqlDateTime x) { return default(System.Data.SqlTypes.SqlString); }
    public static explicit operator System.Data.SqlTypes.SqlString (System.Data.SqlTypes.SqlDecimal x) { return default(System.Data.SqlTypes.SqlString); }
    public static explicit operator System.Data.SqlTypes.SqlString (System.Data.SqlTypes.SqlDouble x) { return default(System.Data.SqlTypes.SqlString); }
    public static explicit operator System.Data.SqlTypes.SqlString (System.Data.SqlTypes.SqlGuid x) { return default(System.Data.SqlTypes.SqlString); }
    public static explicit operator System.Data.SqlTypes.SqlString (System.Data.SqlTypes.SqlInt16 x) { return default(System.Data.SqlTypes.SqlString); }
    public static explicit operator System.Data.SqlTypes.SqlString (System.Data.SqlTypes.SqlInt32 x) { return default(System.Data.SqlTypes.SqlString); }
    public static explicit operator System.Data.SqlTypes.SqlString (System.Data.SqlTypes.SqlInt64 x) { return default(System.Data.SqlTypes.SqlString); }
    public static explicit operator System.Data.SqlTypes.SqlString (System.Data.SqlTypes.SqlMoney x) { return default(System.Data.SqlTypes.SqlString); }
    public static explicit operator System.Data.SqlTypes.SqlString (System.Data.SqlTypes.SqlSingle x) { return default(System.Data.SqlTypes.SqlString); }
    public static explicit operator string (System.Data.SqlTypes.SqlString x) { return default(string); }
    public static System.Data.SqlTypes.SqlBoolean operator >(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean operator >=(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static implicit operator System.Data.SqlTypes.SqlString (string x) { return default(System.Data.SqlTypes.SqlString); }
    public static System.Data.SqlTypes.SqlBoolean operator !=(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean operator <(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public static System.Data.SqlTypes.SqlBoolean operator <=(System.Data.SqlTypes.SqlString x, System.Data.SqlTypes.SqlString y) { return default(System.Data.SqlTypes.SqlBoolean); }
    public System.Data.SqlTypes.SqlBoolean ToSqlBoolean() { return default(System.Data.SqlTypes.SqlBoolean); }
    public System.Data.SqlTypes.SqlByte ToSqlByte() { return default(System.Data.SqlTypes.SqlByte); }
    public System.Data.SqlTypes.SqlDateTime ToSqlDateTime() { return default(System.Data.SqlTypes.SqlDateTime); }
    public System.Data.SqlTypes.SqlDecimal ToSqlDecimal() { return default(System.Data.SqlTypes.SqlDecimal); }
    public System.Data.SqlTypes.SqlDouble ToSqlDouble() { return default(System.Data.SqlTypes.SqlDouble); }
    public System.Data.SqlTypes.SqlGuid ToSqlGuid() { return default(System.Data.SqlTypes.SqlGuid); }
    public System.Data.SqlTypes.SqlInt16 ToSqlInt16() { return default(System.Data.SqlTypes.SqlInt16); }
    public System.Data.SqlTypes.SqlInt32 ToSqlInt32() { return default(System.Data.SqlTypes.SqlInt32); }
    public System.Data.SqlTypes.SqlInt64 ToSqlInt64() { return default(System.Data.SqlTypes.SqlInt64); }
    public System.Data.SqlTypes.SqlMoney ToSqlMoney() { return default(System.Data.SqlTypes.SqlMoney); }
    public System.Data.SqlTypes.SqlSingle ToSqlSingle() { return default(System.Data.SqlTypes.SqlSingle); }
    public override string ToString() { return default(string); }
  }

  public sealed partial class SqlTruncateException : System.Data.SqlTypes.SqlTypeException {
    public SqlTruncateException() { }
    public SqlTruncateException(string message) { }
    public SqlTruncateException(string message, System.Exception e) { }
  }

  public partial class SqlTypeException : System.Exception {
    public SqlTypeException() { }
    public SqlTypeException(string message) { }
    public SqlTypeException(string message, System.Exception e) { }
  }

  public sealed partial class SqlXml : System.Data.SqlTypes.INullable {
    public SqlXml() { }
    public SqlXml(System.IO.Stream value) { }
    public SqlXml(System.Xml.XmlReader value) { }
    public bool IsNull { get { return default(bool); } }
    public static System.Data.SqlTypes.SqlXml Null { get { return default(System.Data.SqlTypes.SqlXml); } }
    public string Value { get { return default(string); } }
    public System.Xml.XmlReader CreateReader() { return default(System.Xml.XmlReader); }
  }

} // end of System.Data.SqlTypes
namespace Microsoft.Win32.SafeHandles {
  [System.Security.SecurityCriticalAttribute]
  public sealed partial class SafeProcessHandle : System.Runtime.InteropServices.SafeHandle {
    public SafeProcessHandle(System.IntPtr existingHandle, bool ownsHandle) : base (default(System.IntPtr), default(bool)) { }
    public override bool IsInvalid { [System.Security.SecurityCriticalAttribute]get { return default(bool); } }
    protected override bool ReleaseHandle() { return default(bool); }
  }

  public sealed partial class SafePipeHandle : System.Runtime.InteropServices.SafeHandle {
    public SafePipeHandle(System.IntPtr preexistingHandle, bool ownsHandle) : base (default(System.IntPtr), default(bool)) { }
    public override bool IsInvalid { get { return default(bool); } }
    protected override bool ReleaseHandle() { return default(bool); }
  }

  public abstract partial class SafeNCryptHandle : System.Runtime.InteropServices.SafeHandle {
    protected SafeNCryptHandle() : base (default(System.IntPtr), default(bool)) { }
    public override bool IsInvalid { get { return default(bool); } }
    protected override bool ReleaseHandle() { return default(bool); }
    protected abstract bool ReleaseNativeHandle();
  }

  public sealed partial class SafeNCryptKeyHandle : Microsoft.Win32.SafeHandles.SafeNCryptHandle {
    public SafeNCryptKeyHandle() { }
    protected override bool ReleaseNativeHandle() { return default(bool); }
  }

  public sealed partial class SafeNCryptProviderHandle : Microsoft.Win32.SafeHandles.SafeNCryptHandle {
    public SafeNCryptProviderHandle() { }
    protected override bool ReleaseNativeHandle() { return default(bool); }
  }

  public sealed partial class SafeNCryptSecretHandle : Microsoft.Win32.SafeHandles.SafeNCryptHandle {
    public SafeNCryptSecretHandle() { }
    protected override bool ReleaseNativeHandle() { return default(bool); }
  }

  public sealed partial class SafeX509ChainHandle : System.Runtime.InteropServices.SafeHandle {
    internal SafeX509ChainHandle() : base (default(System.IntPtr), default(bool)) { }
    public override bool IsInvalid { [System.Security.SecurityCriticalAttribute]get { return default(bool); } }
    protected override bool ReleaseHandle() { return default(bool); }
  }

  [System.Security.SecurityCriticalAttribute]
  public sealed partial class SafeAccessTokenHandle : System.Runtime.InteropServices.SafeHandle {
    public SafeAccessTokenHandle(System.IntPtr handle) : base (default(System.IntPtr), default(bool)) { }
    public static Microsoft.Win32.SafeHandles.SafeAccessTokenHandle InvalidHandle { [System.Security.SecurityCriticalAttribute]get { return default(Microsoft.Win32.SafeHandles.SafeAccessTokenHandle); } }
    public override bool IsInvalid { [System.Security.SecurityCriticalAttribute]get { return default(bool); } }
    [System.Security.SecurityCriticalAttribute]
    protected override bool ReleaseHandle() { return default(bool); }
  }

} // end of Microsoft.Win32.SafeHandles
namespace System.Diagnostics {
  public static partial class StackFrameExtensions {
    public static System.IntPtr GetNativeImageBase(this System.Diagnostics.StackFrame stackFrame) { return default(System.IntPtr); }
    public static System.IntPtr GetNativeIP(this System.Diagnostics.StackFrame stackFrame) { return default(System.IntPtr); }
    public static bool HasILOffset(this System.Diagnostics.StackFrame stackFrame) { return default(bool); }
    public static bool HasMethod(this System.Diagnostics.StackFrame stackFrame) { return default(bool); }
    public static bool HasNativeImage(this System.Diagnostics.StackFrame stackFrame) { return default(bool); }
    public static bool HasSource(this System.Diagnostics.StackFrame stackFrame) { return default(bool); }
  }

  public partial class DelimitedListTraceListener : System.Diagnostics.TextWriterTraceListener {
    public DelimitedListTraceListener(System.IO.Stream stream) { }
    public DelimitedListTraceListener(System.IO.Stream stream, string name) { }
    public DelimitedListTraceListener(System.IO.TextWriter writer) { }
    public DelimitedListTraceListener(System.IO.TextWriter writer, string name) { }
    public string Delimiter { get { return default(string); } set { } }
    public override void TraceData(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id, object data) { }
    public override void TraceData(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id, params object[] data) { }
    public override void TraceEvent(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id, string message) { }
    public override void TraceEvent(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id, string format, params object[] args) { }
  }

  public partial class TextWriterTraceListener : System.Diagnostics.TraceListener {
    public TextWriterTraceListener() { }
    public TextWriterTraceListener(System.IO.Stream stream) { }
    public TextWriterTraceListener(System.IO.Stream stream, string name) { }
    public TextWriterTraceListener(System.IO.TextWriter writer) { }
    public TextWriterTraceListener(System.IO.TextWriter writer, string name) { }
    public System.IO.TextWriter Writer { get { return default(System.IO.TextWriter); } set { } }
    protected override void Dispose(bool disposing) { }
    public override void Flush() { }
    public override void Write(string message) { }
    public override void WriteLine(string message) { }
  }

  public partial class EventTypeFilter : System.Diagnostics.TraceFilter {
    public EventTypeFilter(System.Diagnostics.SourceLevels level) { }
    public System.Diagnostics.SourceLevels EventType { get { return default(System.Diagnostics.SourceLevels); } set { } }
    public override bool ShouldTrace(System.Diagnostics.TraceEventCache cache, string source, System.Diagnostics.TraceEventType eventType, int id, string formatOrMessage, object[] args, object data1, object[] data) { return default(bool); }
  }

  public partial class SourceFilter : System.Diagnostics.TraceFilter {
    public SourceFilter(string source) { }
    public string Source { get { return default(string); } set { } }
    public override bool ShouldTrace(System.Diagnostics.TraceEventCache cache, string source, System.Diagnostics.TraceEventType eventType, int id, string formatOrMessage, object[] args, object data1, object[] data) { return default(bool); }
  }

} // end of System.Diagnostics
namespace System.Diagnostics.Tracing {
  [System.FlagsAttribute]
  public enum EventActivityOptions {
    Detachable = 8,
    Disable = 2,
    None = 0,
    Recursive = 4,
  }

  public enum EventChannel : byte {
    Admin = (byte)16,
    Analytic = (byte)18,
    Debug = (byte)19,
    None = (byte)0,
    Operational = (byte)17,
  }

  public partial class EventCounter {
    public EventCounter(string name, System.Diagnostics.Tracing.EventSource eventSource) { }
    public void WriteMetric(float value) { }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(12), Inherited=false)]
  public partial class EventDataAttribute : System.Attribute {
    public EventDataAttribute() { }
    public string Name { get { return default(string); } set { } }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(128))]
  public partial class EventFieldAttribute : System.Attribute {
    public EventFieldAttribute() { }
    public System.Diagnostics.Tracing.EventFieldFormat Format { get { return default(System.Diagnostics.Tracing.EventFieldFormat); } set { } }
    public System.Diagnostics.Tracing.EventFieldTags Tags { get { return default(System.Diagnostics.Tracing.EventFieldTags); } set { } }
  }

  public enum EventFieldFormat {
    Boolean = 3,
    Default = 0,
    Hexadecimal = 4,
    HResult = 15,
    Json = 12,
    String = 2,
    Xml = 11,
  }

  [System.FlagsAttribute]
  public enum EventFieldTags {
    None = 0,
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(128))]
  public partial class EventIgnoreAttribute : System.Attribute {
    public EventIgnoreAttribute() { }
  }

  public abstract partial class EventListener : System.IDisposable {
    protected EventListener() { }
    public void DisableEvents(System.Diagnostics.Tracing.EventSource eventSource) { }
    public virtual void Dispose() { }
    public void EnableEvents(System.Diagnostics.Tracing.EventSource eventSource, System.Diagnostics.Tracing.EventLevel level) { }
    public void EnableEvents(System.Diagnostics.Tracing.EventSource eventSource, System.Diagnostics.Tracing.EventLevel level, System.Diagnostics.Tracing.EventKeywords matchAnyKeyword) { }
    public void EnableEvents(System.Diagnostics.Tracing.EventSource eventSource, System.Diagnostics.Tracing.EventLevel level, System.Diagnostics.Tracing.EventKeywords matchAnyKeyword, System.Collections.Generic.IDictionary<string, string> arguments) { }
    protected static int EventSourceIndex(System.Diagnostics.Tracing.EventSource eventSource) { return default(int); }
    protected internal virtual void OnEventSourceCreated(System.Diagnostics.Tracing.EventSource eventSource) { }
    protected internal abstract void OnEventWritten(System.Diagnostics.Tracing.EventWrittenEventArgs eventData);
  }

  [System.FlagsAttribute]
  public enum EventManifestOptions {
    AllCultures = 2,
    AllowEventSourceOverride = 8,
    None = 0,
    OnlyIfNeededForRegistration = 4,
    Strict = 1,
  }

  public enum EventOpcode {
    DataCollectionStart = 3,
    DataCollectionStop = 4,
    Extension = 5,
    Info = 0,
    Receive = 240,
    Reply = 6,
    Resume = 7,
    Send = 9,
    Start = 1,
    Stop = 2,
    Suspend = 8,
  }

  public partial class EventSourceException : System.Exception {
    public EventSourceException() { }
    public EventSourceException(string message) { }
    public EventSourceException(string message, System.Exception innerException) { }
  }

  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct EventSourceOptions {
    public System.Diagnostics.Tracing.EventActivityOptions ActivityOptions { get { return default(System.Diagnostics.Tracing.EventActivityOptions); } set { } }
    public System.Diagnostics.Tracing.EventKeywords Keywords { get { return default(System.Diagnostics.Tracing.EventKeywords); } set { } }
    public System.Diagnostics.Tracing.EventLevel Level { get { return default(System.Diagnostics.Tracing.EventLevel); } set { } }
    public System.Diagnostics.Tracing.EventOpcode Opcode { get { return default(System.Diagnostics.Tracing.EventOpcode); } set { } }
    public System.Diagnostics.Tracing.EventTags Tags { get { return default(System.Diagnostics.Tracing.EventTags); } set { } }
  }

  [System.FlagsAttribute]
  public enum EventSourceSettings {
    Default = 0,
    EtwManifestEventFormat = 4,
    EtwSelfDescribingEventFormat = 8,
    ThrowOnEventWriteErrors = 1,
  }

  [System.FlagsAttribute]
  public enum EventTags {
    None = 0,
  }

  public enum EventTask {
    None = 0,
  }

  public partial class EventWrittenEventArgs : System.EventArgs {
    internal EventWrittenEventArgs() { }
    public System.Guid ActivityId { [System.Security.SecurityCriticalAttribute]get { return default(System.Guid); } }
    public System.Diagnostics.Tracing.EventChannel Channel { get { return default(System.Diagnostics.Tracing.EventChannel); } }
    public int EventId { get { return default(int); } }
    public string EventName { get { return default(string); } }
    public System.Diagnostics.Tracing.EventSource EventSource { get { return default(System.Diagnostics.Tracing.EventSource); } }
    public System.Diagnostics.Tracing.EventKeywords Keywords { get { return default(System.Diagnostics.Tracing.EventKeywords); } }
    public System.Diagnostics.Tracing.EventLevel Level { get { return default(System.Diagnostics.Tracing.EventLevel); } }
    public string Message { get { return default(string); } }
    public System.Diagnostics.Tracing.EventOpcode Opcode { get { return default(System.Diagnostics.Tracing.EventOpcode); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<object> Payload { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<object>); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<string> PayloadNames { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<string>); } }
    public System.Guid RelatedActivityId { [System.Security.SecurityCriticalAttribute]get { return default(System.Guid); } }
    public System.Diagnostics.Tracing.EventTags Tags { get { return default(System.Diagnostics.Tracing.EventTags); } }
    public System.Diagnostics.Tracing.EventTask Task { get { return default(System.Diagnostics.Tracing.EventTask); } }
    public byte Version { get { return default(byte); } }
  }

} // end of System.Diagnostics.Tracing
namespace System.Globalization {
  public static partial class GlobalizationExtensions {
    public static System.StringComparer GetStringComparer(this System.Globalization.CompareInfo compareInfo, System.Globalization.CompareOptions options) { return default(System.StringComparer); }
  }

} // end of System.Globalization
namespace System.IO.Compression {
  public partial class ZipArchive : System.IDisposable {
    public ZipArchive(System.IO.Stream stream) { }
    public ZipArchive(System.IO.Stream stream, System.IO.Compression.ZipArchiveMode mode) { }
    public ZipArchive(System.IO.Stream stream, System.IO.Compression.ZipArchiveMode mode, bool leaveOpen) { }
    public ZipArchive(System.IO.Stream stream, System.IO.Compression.ZipArchiveMode mode, bool leaveOpen, System.Text.Encoding entryNameEncoding) { }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.IO.Compression.ZipArchiveEntry> Entries { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.IO.Compression.ZipArchiveEntry>); } }
    public System.IO.Compression.ZipArchiveMode Mode { get { return default(System.IO.Compression.ZipArchiveMode); } }
    public System.IO.Compression.ZipArchiveEntry CreateEntry(string entryName) { return default(System.IO.Compression.ZipArchiveEntry); }
    public System.IO.Compression.ZipArchiveEntry CreateEntry(string entryName, System.IO.Compression.CompressionLevel compressionLevel) { return default(System.IO.Compression.ZipArchiveEntry); }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public System.IO.Compression.ZipArchiveEntry GetEntry(string entryName) { return default(System.IO.Compression.ZipArchiveEntry); }
  }

  public partial class ZipArchiveEntry {
    internal ZipArchiveEntry() { }
    public System.IO.Compression.ZipArchive Archive { get { return default(System.IO.Compression.ZipArchive); } }
    public long CompressedLength { get { return default(long); } }
    public string FullName { get { return default(string); } }
    public System.DateTimeOffset LastWriteTime { get { return default(System.DateTimeOffset); } set { } }
    public long Length { get { return default(long); } }
    public string Name { get { return default(string); } }
    public void Delete() { }
    public System.IO.Stream Open() { return default(System.IO.Stream); }
    public override string ToString() { return default(string); }
  }

  public enum ZipArchiveMode {
    Create = 1,
    Read = 0,
    Update = 2,
  }

  public static partial class ZipFile {
    public static void CreateFromDirectory(string sourceDirectoryName, string destinationArchiveFileName) { }
    public static void CreateFromDirectory(string sourceDirectoryName, string destinationArchiveFileName, System.IO.Compression.CompressionLevel compressionLevel, bool includeBaseDirectory) { }
    public static void CreateFromDirectory(string sourceDirectoryName, string destinationArchiveFileName, System.IO.Compression.CompressionLevel compressionLevel, bool includeBaseDirectory, System.Text.Encoding entryNameEncoding) { }
    public static void ExtractToDirectory(string sourceArchiveFileName, string destinationDirectoryName) { }
    public static void ExtractToDirectory(string sourceArchiveFileName, string destinationDirectoryName, System.Text.Encoding entryNameEncoding) { }
    public static System.IO.Compression.ZipArchive Open(string archiveFileName, System.IO.Compression.ZipArchiveMode mode) { return default(System.IO.Compression.ZipArchive); }
    public static System.IO.Compression.ZipArchive Open(string archiveFileName, System.IO.Compression.ZipArchiveMode mode, System.Text.Encoding entryNameEncoding) { return default(System.IO.Compression.ZipArchive); }
    public static System.IO.Compression.ZipArchive OpenRead(string archiveFileName) { return default(System.IO.Compression.ZipArchive); }
  }

  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public static partial class ZipFileExtensions {
    public static System.IO.Compression.ZipArchiveEntry CreateEntryFromFile(this System.IO.Compression.ZipArchive destination, string sourceFileName, string entryName) { return default(System.IO.Compression.ZipArchiveEntry); }
    public static System.IO.Compression.ZipArchiveEntry CreateEntryFromFile(this System.IO.Compression.ZipArchive destination, string sourceFileName, string entryName, System.IO.Compression.CompressionLevel compressionLevel) { return default(System.IO.Compression.ZipArchiveEntry); }
    public static void ExtractToDirectory(this System.IO.Compression.ZipArchive source, string destinationDirectoryName) { }
    public static void ExtractToFile(this System.IO.Compression.ZipArchiveEntry source, string destinationFileName) { }
    public static void ExtractToFile(this System.IO.Compression.ZipArchiveEntry source, string destinationFileName, bool overwrite) { }
  }

} // end of System.IO.Compression
namespace System.IO {
  [System.Security.SecurityCriticalAttribute]
  public static partial class FileSystemAclExtensions {
    public static System.Security.AccessControl.DirectorySecurity GetAccessControl(this System.IO.DirectoryInfo directoryInfo) { return default(System.Security.AccessControl.DirectorySecurity); }
    public static System.Security.AccessControl.DirectorySecurity GetAccessControl(this System.IO.DirectoryInfo directoryInfo, System.Security.AccessControl.AccessControlSections includeSections) { return default(System.Security.AccessControl.DirectorySecurity); }
    public static System.Security.AccessControl.FileSecurity GetAccessControl(this System.IO.FileInfo fileInfo) { return default(System.Security.AccessControl.FileSecurity); }
    public static System.Security.AccessControl.FileSecurity GetAccessControl(this System.IO.FileInfo fileInfo, System.Security.AccessControl.AccessControlSections includeSections) { return default(System.Security.AccessControl.FileSecurity); }
    public static System.Security.AccessControl.FileSecurity GetAccessControl(this System.IO.FileStream fileStream) { return default(System.Security.AccessControl.FileSecurity); }
    public static void SetAccessControl(this System.IO.DirectoryInfo directoryInfo, System.Security.AccessControl.DirectorySecurity directorySecurity) { }
    public static void SetAccessControl(this System.IO.FileInfo fileInfo, System.Security.AccessControl.FileSecurity fileSecurity) { }
    public static void SetAccessControl(this System.IO.FileStream fileStream, System.Security.AccessControl.FileSecurity fileSecurity) { }
  }

  public partial class ErrorEventArgs : System.EventArgs {
    public ErrorEventArgs(System.Exception exception) { }
    public virtual System.Exception GetException() { return default(System.Exception); }
  }

  public delegate void ErrorEventHandler(object sender, System.IO.ErrorEventArgs e);

  public partial class FileSystemEventArgs : System.EventArgs {
    public FileSystemEventArgs(System.IO.WatcherChangeTypes changeType, string directory, string name) { }
    public System.IO.WatcherChangeTypes ChangeType { get { return default(System.IO.WatcherChangeTypes); } }
    public string FullPath { get { return default(string); } }
    public string Name { get { return default(string); } }
  }

  public delegate void FileSystemEventHandler(object sender, System.IO.FileSystemEventArgs e);

  public partial class FileSystemWatcher : System.IDisposable {
    public FileSystemWatcher() { }
    public FileSystemWatcher(string path) { }
    public FileSystemWatcher(string path, string filter) { }
    public bool EnableRaisingEvents { get { return default(bool); } set { } }
    public string Filter { get { return default(string); } set { } }
    public bool IncludeSubdirectories { get { return default(bool); } set { } }
    public int InternalBufferSize { get { return default(int); } set { } }
    public System.IO.NotifyFilters NotifyFilter { get { return default(System.IO.NotifyFilters); } set { } }
    public string Path { get { return default(string); } set { } }
    public event System.IO.FileSystemEventHandler Changed { add { } remove { } }
    public event System.IO.FileSystemEventHandler Created { add { } remove { } }
    public event System.IO.FileSystemEventHandler Deleted { add { } remove { } }
    public event System.IO.ErrorEventHandler Error { add { } remove { } }
    public event System.IO.RenamedEventHandler Renamed { add { } remove { } }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    protected void OnChanged(System.IO.FileSystemEventArgs e) { }
    protected void OnCreated(System.IO.FileSystemEventArgs e) { }
    protected void OnDeleted(System.IO.FileSystemEventArgs e) { }
    protected void OnError(System.IO.ErrorEventArgs e) { }
    protected void OnRenamed(System.IO.RenamedEventArgs e) { }
    public System.IO.WaitForChangedResult WaitForChanged(System.IO.WatcherChangeTypes changeType) { return default(System.IO.WaitForChangedResult); }
    public System.IO.WaitForChangedResult WaitForChanged(System.IO.WatcherChangeTypes changeType, int timeout) { return default(System.IO.WaitForChangedResult); }
  }

  [System.FlagsAttribute]
  public enum NotifyFilters {
    Attributes = 4,
    CreationTime = 64,
    DirectoryName = 2,
    FileName = 1,
    LastAccess = 32,
    LastWrite = 16,
    Security = 256,
    Size = 8,
  }

  public partial class RenamedEventArgs : System.IO.FileSystemEventArgs {
    public RenamedEventArgs(System.IO.WatcherChangeTypes changeType, string directory, string name, string oldName) : base (default(System.IO.WatcherChangeTypes), default(string), default(string)) { }
    public string OldFullPath { get { return default(string); } }
    public string OldName { get { return default(string); } }
  }

  public delegate void RenamedEventHandler(object sender, System.IO.RenamedEventArgs e);

  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, Size=1)]
  public partial struct WaitForChangedResult {
    public System.IO.WatcherChangeTypes ChangeType { get { return default(System.IO.WatcherChangeTypes); } set { } }
    public string Name { get { return default(string); } set { } }
    public string OldName { get { return default(string); } set { } }
    public bool TimedOut { get { return default(bool); } set { } }
  }

  [System.FlagsAttribute]
  public enum WatcherChangeTypes {
    All = 15,
    Changed = 4,
    Created = 1,
    Deleted = 2,
    Renamed = 8,
  }

  [System.Security.SecurityCriticalAttribute]
  public static partial class WindowsRuntimeStorageExtensions {
    [System.CLSCompliantAttribute(false)]
    public static System.Threading.Tasks.Task<System.IO.Stream> OpenStreamForReadAsync(this Windows.Storage.IStorageFile windowsRuntimeFile) { return default(System.Threading.Tasks.Task<System.IO.Stream>); }
    [System.CLSCompliantAttribute(false)]
    public static System.Threading.Tasks.Task<System.IO.Stream> OpenStreamForReadAsync(this Windows.Storage.IStorageFolder rootDirectory, string relativePath) { return default(System.Threading.Tasks.Task<System.IO.Stream>); }
    [System.CLSCompliantAttribute(false)]
    public static System.Threading.Tasks.Task<System.IO.Stream> OpenStreamForWriteAsync(this Windows.Storage.IStorageFile windowsRuntimeFile) { return default(System.Threading.Tasks.Task<System.IO.Stream>); }
    [System.CLSCompliantAttribute(false)]
    public static System.Threading.Tasks.Task<System.IO.Stream> OpenStreamForWriteAsync(this Windows.Storage.IStorageFolder rootDirectory, string relativePath, Windows.Storage.CreationCollisionOption creationCollisionOption) { return default(System.Threading.Tasks.Task<System.IO.Stream>); }
  }

  [System.Security.SecurityCriticalAttribute]
  public static partial class WindowsRuntimeStreamExtensions {
    [System.CLSCompliantAttribute(false)]
    public static Windows.Storage.Streams.IInputStream AsInputStream(this System.IO.Stream stream) { return default(Windows.Storage.Streams.IInputStream); }
    [System.CLSCompliantAttribute(false)]
    public static Windows.Storage.Streams.IOutputStream AsOutputStream(this System.IO.Stream stream) { return default(Windows.Storage.Streams.IOutputStream); }
    [System.CLSCompliantAttribute(false)]
    public static Windows.Storage.Streams.IRandomAccessStream AsRandomAccessStream(this System.IO.Stream stream) { return default(Windows.Storage.Streams.IRandomAccessStream); }
    [System.CLSCompliantAttribute(false)]
    public static System.IO.Stream AsStream(this Windows.Storage.Streams.IRandomAccessStream windowsRuntimeStream) { return default(System.IO.Stream); }
    [System.CLSCompliantAttribute(false)]
    public static System.IO.Stream AsStream(this Windows.Storage.Streams.IRandomAccessStream windowsRuntimeStream, int bufferSize) { return default(System.IO.Stream); }
    [System.CLSCompliantAttribute(false)]
    public static System.IO.Stream AsStreamForRead(this Windows.Storage.Streams.IInputStream windowsRuntimeStream) { return default(System.IO.Stream); }
    [System.CLSCompliantAttribute(false)]
    public static System.IO.Stream AsStreamForRead(this Windows.Storage.Streams.IInputStream windowsRuntimeStream, int bufferSize) { return default(System.IO.Stream); }
    [System.CLSCompliantAttribute(false)]
    public static System.IO.Stream AsStreamForWrite(this Windows.Storage.Streams.IOutputStream windowsRuntimeStream) { return default(System.IO.Stream); }
    [System.CLSCompliantAttribute(false)]
    public static System.IO.Stream AsStreamForWrite(this Windows.Storage.Streams.IOutputStream windowsRuntimeStream, int bufferSize) { return default(System.IO.Stream); }
  }

} // end of System.IO
namespace System.IO.Pipes {
  public sealed partial class AnonymousPipeClientStream : System.IO.Pipes.PipeStream {
    public AnonymousPipeClientStream(System.IO.Pipes.PipeDirection direction, Microsoft.Win32.SafeHandles.SafePipeHandle safePipeHandle) : base (default(System.IO.Pipes.PipeDirection), default(int)) { }
    public AnonymousPipeClientStream(System.IO.Pipes.PipeDirection direction, string pipeHandleAsString) : base (default(System.IO.Pipes.PipeDirection), default(int)) { }
    public AnonymousPipeClientStream(string pipeHandleAsString) : base (default(System.IO.Pipes.PipeDirection), default(int)) { }
    public override System.IO.Pipes.PipeTransmissionMode ReadMode { set { } }
    public override System.IO.Pipes.PipeTransmissionMode TransmissionMode { get { return default(System.IO.Pipes.PipeTransmissionMode); } }
    ~AnonymousPipeClientStream() { }
  }

  public sealed partial class AnonymousPipeServerStream : System.IO.Pipes.PipeStream {
    public AnonymousPipeServerStream() : base (default(System.IO.Pipes.PipeDirection), default(int)) { }
    public AnonymousPipeServerStream(System.IO.Pipes.PipeDirection direction) : base (default(System.IO.Pipes.PipeDirection), default(int)) { }
    public AnonymousPipeServerStream(System.IO.Pipes.PipeDirection direction, Microsoft.Win32.SafeHandles.SafePipeHandle serverSafePipeHandle, Microsoft.Win32.SafeHandles.SafePipeHandle clientSafePipeHandle) : base (default(System.IO.Pipes.PipeDirection), default(int)) { }
    public AnonymousPipeServerStream(System.IO.Pipes.PipeDirection direction, System.IO.HandleInheritability inheritability) : base (default(System.IO.Pipes.PipeDirection), default(int)) { }
    public AnonymousPipeServerStream(System.IO.Pipes.PipeDirection direction, System.IO.HandleInheritability inheritability, int bufferSize) : base (default(System.IO.Pipes.PipeDirection), default(int)) { }
    public Microsoft.Win32.SafeHandles.SafePipeHandle ClientSafePipeHandle { get { return default(Microsoft.Win32.SafeHandles.SafePipeHandle); } }
    public override System.IO.Pipes.PipeTransmissionMode ReadMode { set { } }
    public override System.IO.Pipes.PipeTransmissionMode TransmissionMode { get { return default(System.IO.Pipes.PipeTransmissionMode); } }
    protected override void Dispose(bool disposing) { }
    public void DisposeLocalCopyOfClientHandle() { }
    ~AnonymousPipeServerStream() { }
    public string GetClientHandleAsString() { return default(string); }
  }

  public sealed partial class NamedPipeClientStream : System.IO.Pipes.PipeStream {
    public NamedPipeClientStream(System.IO.Pipes.PipeDirection direction, bool isAsync, bool isConnected, Microsoft.Win32.SafeHandles.SafePipeHandle safePipeHandle) : base (default(System.IO.Pipes.PipeDirection), default(int)) { }
    public NamedPipeClientStream(string pipeName) : base (default(System.IO.Pipes.PipeDirection), default(int)) { }
    public NamedPipeClientStream(string serverName, string pipeName) : base (default(System.IO.Pipes.PipeDirection), default(int)) { }
    public NamedPipeClientStream(string serverName, string pipeName, System.IO.Pipes.PipeDirection direction) : base (default(System.IO.Pipes.PipeDirection), default(int)) { }
    public NamedPipeClientStream(string serverName, string pipeName, System.IO.Pipes.PipeDirection direction, System.IO.Pipes.PipeOptions options) : base (default(System.IO.Pipes.PipeDirection), default(int)) { }
    public NamedPipeClientStream(string serverName, string pipeName, System.IO.Pipes.PipeDirection direction, System.IO.Pipes.PipeOptions options, System.Security.Principal.TokenImpersonationLevel impersonationLevel) : base (default(System.IO.Pipes.PipeDirection), default(int)) { }
    public int NumberOfServerInstances { get { return default(int); } }
    public void Connect() { }
    public void Connect(int timeout) { }
    public System.Threading.Tasks.Task ConnectAsync() { return default(System.Threading.Tasks.Task); }
    public System.Threading.Tasks.Task ConnectAsync(int timeout) { return default(System.Threading.Tasks.Task); }
    public System.Threading.Tasks.Task ConnectAsync(int timeout, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task); }
    public System.Threading.Tasks.Task ConnectAsync(System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task); }
    ~NamedPipeClientStream() { }
  }

  public sealed partial class NamedPipeServerStream : System.IO.Pipes.PipeStream {
    public NamedPipeServerStream(System.IO.Pipes.PipeDirection direction, bool isAsync, bool isConnected, Microsoft.Win32.SafeHandles.SafePipeHandle safePipeHandle) : base (default(System.IO.Pipes.PipeDirection), default(int)) { }
    public NamedPipeServerStream(string pipeName) : base (default(System.IO.Pipes.PipeDirection), default(int)) { }
    public NamedPipeServerStream(string pipeName, System.IO.Pipes.PipeDirection direction) : base (default(System.IO.Pipes.PipeDirection), default(int)) { }
    public NamedPipeServerStream(string pipeName, System.IO.Pipes.PipeDirection direction, int maxNumberOfServerInstances) : base (default(System.IO.Pipes.PipeDirection), default(int)) { }
    public NamedPipeServerStream(string pipeName, System.IO.Pipes.PipeDirection direction, int maxNumberOfServerInstances, System.IO.Pipes.PipeTransmissionMode transmissionMode) : base (default(System.IO.Pipes.PipeDirection), default(int)) { }
    public NamedPipeServerStream(string pipeName, System.IO.Pipes.PipeDirection direction, int maxNumberOfServerInstances, System.IO.Pipes.PipeTransmissionMode transmissionMode, System.IO.Pipes.PipeOptions options) : base (default(System.IO.Pipes.PipeDirection), default(int)) { }
    public NamedPipeServerStream(string pipeName, System.IO.Pipes.PipeDirection direction, int maxNumberOfServerInstances, System.IO.Pipes.PipeTransmissionMode transmissionMode, System.IO.Pipes.PipeOptions options, int inBufferSize, int outBufferSize) : base (default(System.IO.Pipes.PipeDirection), default(int)) { }
    public void Disconnect() { }
    ~NamedPipeServerStream() { }
    public string GetImpersonationUserName() { return default(string); }
    public void WaitForConnection() { }
    public System.Threading.Tasks.Task WaitForConnectionAsync() { return default(System.Threading.Tasks.Task); }
    public System.Threading.Tasks.Task WaitForConnectionAsync(System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task); }
  }

  public enum PipeDirection {
    In = 1,
    InOut = 3,
    Out = 2,
  }

  [System.FlagsAttribute]
  public enum PipeOptions {
    Asynchronous = 1073741824,
    None = 0,
    WriteThrough = -2147483648,
  }

  public abstract partial class PipeStream : System.IO.Stream {
    protected PipeStream(System.IO.Pipes.PipeDirection direction, int bufferSize) { }
    protected PipeStream(System.IO.Pipes.PipeDirection direction, System.IO.Pipes.PipeTransmissionMode transmissionMode, int outBufferSize) { }
    public override bool CanRead { get { return default(bool); } }
    public override bool CanSeek { get { return default(bool); } }
    public override bool CanWrite { get { return default(bool); } }
    public virtual int InBufferSize { get { return default(int); } }
    public bool IsAsync { get { return default(bool); } }
    public bool IsConnected { get { return default(bool); } protected set { } }
    public bool IsMessageComplete { get { return default(bool); } }
    public override long Length { get { return default(long); } }
    public virtual int OutBufferSize { get { return default(int); } }
    public override long Position { get { return default(long); } set { } }
    public virtual System.IO.Pipes.PipeTransmissionMode ReadMode { get { return default(System.IO.Pipes.PipeTransmissionMode); } set { } }
    public Microsoft.Win32.SafeHandles.SafePipeHandle SafePipeHandle { get { return default(Microsoft.Win32.SafeHandles.SafePipeHandle); } }
    public virtual System.IO.Pipes.PipeTransmissionMode TransmissionMode { get { return default(System.IO.Pipes.PipeTransmissionMode); } }
    protected override void Dispose(bool disposing) { }
    public override void Flush() { }
    public override int Read(byte[] buffer, int offset, int count) { return default(int); }
    public override System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<int>); }
    public override int ReadByte() { return default(int); }
    public override long Seek(long offset, System.IO.SeekOrigin origin) { return default(long); }
    public override void SetLength(long value) { }
    public void WaitForPipeDrain() { }
    public override void Write(byte[] buffer, int offset, int count) { }
    public override System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task); }
    public override void WriteByte(byte value) { }
  }

  public enum PipeTransmissionMode {
    Byte = 0,
    Message = 1,
  }

} // end of System.IO.Pipes
namespace System.Linq.Expressions {
  public partial interface IArgumentProvider {
    int ArgumentCount { get; }
    System.Linq.Expressions.Expression GetArgument(int index);
  }

  public partial interface IDynamicExpression : System.Linq.Expressions.IArgumentProvider {
    System.Type DelegateType { get; }
    object CreateCallSite();
    System.Linq.Expressions.Expression Rewrite(System.Linq.Expressions.Expression[] args);
  }

} // end of System.Linq.Expressions
namespace System.Net.Http {
  public partial class ByteArrayContent : System.Net.Http.HttpContent {
    public ByteArrayContent(byte[] content) { }
    public ByteArrayContent(byte[] content, int offset, int count) { }
    protected override System.Threading.Tasks.Task<System.IO.Stream> CreateContentReadStreamAsync() { return default(System.Threading.Tasks.Task<System.IO.Stream>); }
    protected override System.Threading.Tasks.Task SerializeToStreamAsync(System.IO.Stream stream, System.Net.TransportContext context) { return default(System.Threading.Tasks.Task); }
    protected internal override bool TryComputeLength(out long length) { length = default(long); return default(bool); }
  }

  public enum ClientCertificateOption {
    Automatic = 1,
    Manual = 0,
  }

  public abstract partial class DelegatingHandler : System.Net.Http.HttpMessageHandler {
    protected DelegatingHandler() { }
    protected DelegatingHandler(System.Net.Http.HttpMessageHandler innerHandler) { }
    public System.Net.Http.HttpMessageHandler InnerHandler { get { return default(System.Net.Http.HttpMessageHandler); } set { } }
    protected override void Dispose(bool disposing) { }
    protected internal override System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsync(System.Net.Http.HttpRequestMessage request, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>); }
  }

  public partial class FormUrlEncodedContent : System.Net.Http.ByteArrayContent {
    public FormUrlEncodedContent(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>> nameValueCollection) : base (default(byte[])) { }
  }

  public partial class HttpClient : System.Net.Http.HttpMessageInvoker {
    public HttpClient() : base (default(System.Net.Http.HttpMessageHandler)) { }
    public HttpClient(System.Net.Http.HttpMessageHandler handler) : base (default(System.Net.Http.HttpMessageHandler)) { }
    public HttpClient(System.Net.Http.HttpMessageHandler handler, bool disposeHandler) : base (default(System.Net.Http.HttpMessageHandler)) { }
    public System.Uri BaseAddress { get { return default(System.Uri); } set { } }
    public System.Net.Http.Headers.HttpRequestHeaders DefaultRequestHeaders { get { return default(System.Net.Http.Headers.HttpRequestHeaders); } }
    public long MaxResponseContentBufferSize { get { return default(long); } set { } }
    public System.TimeSpan Timeout { get { return default(System.TimeSpan); } set { } }
    public void CancelPendingRequests() { }
    public System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> DeleteAsync(string requestUri) { return default(System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>); }
    public System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> DeleteAsync(string requestUri, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>); }
    public System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> DeleteAsync(System.Uri requestUri) { return default(System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>); }
    public System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> DeleteAsync(System.Uri requestUri, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>); }
    protected override void Dispose(bool disposing) { }
    public System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> GetAsync(string requestUri) { return default(System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>); }
    public System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> GetAsync(string requestUri, System.Net.Http.HttpCompletionOption completionOption) { return default(System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>); }
    public System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> GetAsync(string requestUri, System.Net.Http.HttpCompletionOption completionOption, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>); }
    public System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> GetAsync(string requestUri, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>); }
    public System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> GetAsync(System.Uri requestUri) { return default(System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>); }
    public System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> GetAsync(System.Uri requestUri, System.Net.Http.HttpCompletionOption completionOption) { return default(System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>); }
    public System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> GetAsync(System.Uri requestUri, System.Net.Http.HttpCompletionOption completionOption, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>); }
    public System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> GetAsync(System.Uri requestUri, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>); }
    public System.Threading.Tasks.Task<byte[]> GetByteArrayAsync(string requestUri) { return default(System.Threading.Tasks.Task<byte[]>); }
    public System.Threading.Tasks.Task<byte[]> GetByteArrayAsync(System.Uri requestUri) { return default(System.Threading.Tasks.Task<byte[]>); }
    public System.Threading.Tasks.Task<System.IO.Stream> GetStreamAsync(string requestUri) { return default(System.Threading.Tasks.Task<System.IO.Stream>); }
    public System.Threading.Tasks.Task<System.IO.Stream> GetStreamAsync(System.Uri requestUri) { return default(System.Threading.Tasks.Task<System.IO.Stream>); }
    public System.Threading.Tasks.Task<string> GetStringAsync(string requestUri) { return default(System.Threading.Tasks.Task<string>); }
    public System.Threading.Tasks.Task<string> GetStringAsync(System.Uri requestUri) { return default(System.Threading.Tasks.Task<string>); }
    public System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> PostAsync(string requestUri, System.Net.Http.HttpContent content) { return default(System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>); }
    public System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> PostAsync(string requestUri, System.Net.Http.HttpContent content, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>); }
    public System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> PostAsync(System.Uri requestUri, System.Net.Http.HttpContent content) { return default(System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>); }
    public System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> PostAsync(System.Uri requestUri, System.Net.Http.HttpContent content, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>); }
    public System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> PutAsync(string requestUri, System.Net.Http.HttpContent content) { return default(System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>); }
    public System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> PutAsync(string requestUri, System.Net.Http.HttpContent content, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>); }
    public System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> PutAsync(System.Uri requestUri, System.Net.Http.HttpContent content) { return default(System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>); }
    public System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> PutAsync(System.Uri requestUri, System.Net.Http.HttpContent content, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>); }
    public System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsync(System.Net.Http.HttpRequestMessage request) { return default(System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>); }
    public System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsync(System.Net.Http.HttpRequestMessage request, System.Net.Http.HttpCompletionOption completionOption) { return default(System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>); }
    public System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsync(System.Net.Http.HttpRequestMessage request, System.Net.Http.HttpCompletionOption completionOption, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>); }
    public override System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsync(System.Net.Http.HttpRequestMessage request, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>); }
  }

  public partial class HttpClientHandler : System.Net.Http.HttpMessageHandler {
    public HttpClientHandler() { }
    public bool AllowAutoRedirect { get { return default(bool); } set { } }
    public System.Net.DecompressionMethods AutomaticDecompression { get { return default(System.Net.DecompressionMethods); } set { } }
    public bool CheckCertificateRevocationList { get { return default(bool); } set { } }
    public System.Net.Http.ClientCertificateOption ClientCertificateOptions { get { return default(System.Net.Http.ClientCertificateOption); } set { } }
    public System.Security.Cryptography.X509Certificates.X509CertificateCollection ClientCertificates { get { return default(System.Security.Cryptography.X509Certificates.X509CertificateCollection); } }
    public System.Net.CookieContainer CookieContainer { get { return default(System.Net.CookieContainer); } set { } }
    public System.Net.ICredentials Credentials { get { return default(System.Net.ICredentials); } set { } }
    public System.Net.ICredentials DefaultProxyCredentials { get { return default(System.Net.ICredentials); } set { } }
    public int MaxAutomaticRedirections { get { return default(int); } set { } }
    public int MaxConnectionsPerServer { get { return default(int); } set { } }
    public long MaxRequestContentBufferSize { get { return default(long); } set { } }
    public int MaxResponseHeadersLength { get { return default(int); } set { } }
    public bool PreAuthenticate { get { return default(bool); } set { } }
    public System.Collections.Generic.IDictionary<string, object> Properties { get { return default(System.Collections.Generic.IDictionary<string, object>); } }
    public System.Net.IWebProxy Proxy { get { return default(System.Net.IWebProxy); } set { } }
    public System.Func<System.Net.Http.HttpRequestMessage, System.Security.Cryptography.X509Certificates.X509Certificate2, System.Security.Cryptography.X509Certificates.X509Chain, System.Net.Security.SslPolicyErrors, bool> ServerCertificateCustomValidationCallback { get { return default(System.Func<System.Net.Http.HttpRequestMessage, System.Security.Cryptography.X509Certificates.X509Certificate2, System.Security.Cryptography.X509Certificates.X509Chain, System.Net.Security.SslPolicyErrors, bool>); } set { } }
    public System.Security.Authentication.SslProtocols SslProtocols { get { return default(System.Security.Authentication.SslProtocols); } set { } }
    public virtual bool SupportsAutomaticDecompression { get { return default(bool); } }
    public virtual bool SupportsProxy { get { return default(bool); } }
    public virtual bool SupportsRedirectConfiguration { get { return default(bool); } }
    public bool UseCookies { get { return default(bool); } set { } }
    public bool UseDefaultCredentials { get { return default(bool); } set { } }
    public bool UseProxy { get { return default(bool); } set { } }
    protected override void Dispose(bool disposing) { }
    protected internal override System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsync(System.Net.Http.HttpRequestMessage request, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>); }
  }

  public enum HttpCompletionOption {
    ResponseContentRead = 0,
    ResponseHeadersRead = 1,
  }

  public abstract partial class HttpContent : System.IDisposable {
    protected HttpContent() { }
    public System.Net.Http.Headers.HttpContentHeaders Headers { get { return default(System.Net.Http.Headers.HttpContentHeaders); } }
    public System.Threading.Tasks.Task CopyToAsync(System.IO.Stream stream) { return default(System.Threading.Tasks.Task); }
    public System.Threading.Tasks.Task CopyToAsync(System.IO.Stream stream, System.Net.TransportContext context) { return default(System.Threading.Tasks.Task); }
    protected virtual System.Threading.Tasks.Task<System.IO.Stream> CreateContentReadStreamAsync() { return default(System.Threading.Tasks.Task<System.IO.Stream>); }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public System.Threading.Tasks.Task LoadIntoBufferAsync() { return default(System.Threading.Tasks.Task); }
    public System.Threading.Tasks.Task LoadIntoBufferAsync(long maxBufferSize) { return default(System.Threading.Tasks.Task); }
    public System.Threading.Tasks.Task<byte[]> ReadAsByteArrayAsync() { return default(System.Threading.Tasks.Task<byte[]>); }
    public System.Threading.Tasks.Task<System.IO.Stream> ReadAsStreamAsync() { return default(System.Threading.Tasks.Task<System.IO.Stream>); }
    public System.Threading.Tasks.Task<string> ReadAsStringAsync() { return default(System.Threading.Tasks.Task<string>); }
    protected abstract System.Threading.Tasks.Task SerializeToStreamAsync(System.IO.Stream stream, System.Net.TransportContext context);
    protected internal abstract bool TryComputeLength(out long length);
  }

  public abstract partial class HttpMessageHandler : System.IDisposable {
    protected HttpMessageHandler() { }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    protected internal abstract System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsync(System.Net.Http.HttpRequestMessage request, System.Threading.CancellationToken cancellationToken);
  }

  public partial class HttpMessageInvoker : System.IDisposable {
    public HttpMessageInvoker(System.Net.Http.HttpMessageHandler handler) { }
    public HttpMessageInvoker(System.Net.Http.HttpMessageHandler handler, bool disposeHandler) { }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public virtual System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsync(System.Net.Http.HttpRequestMessage request, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>); }
  }

  public partial class HttpMethod : System.IEquatable<System.Net.Http.HttpMethod> {
    public HttpMethod(string method) { }
    public static System.Net.Http.HttpMethod Delete { get { return default(System.Net.Http.HttpMethod); } }
    public static System.Net.Http.HttpMethod Get { get { return default(System.Net.Http.HttpMethod); } }
    public static System.Net.Http.HttpMethod Head { get { return default(System.Net.Http.HttpMethod); } }
    public string Method { get { return default(string); } }
    public static System.Net.Http.HttpMethod Options { get { return default(System.Net.Http.HttpMethod); } }
    public static System.Net.Http.HttpMethod Post { get { return default(System.Net.Http.HttpMethod); } }
    public static System.Net.Http.HttpMethod Put { get { return default(System.Net.Http.HttpMethod); } }
    public static System.Net.Http.HttpMethod Trace { get { return default(System.Net.Http.HttpMethod); } }
    public bool Equals(System.Net.Http.HttpMethod other) { return default(bool); }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.Net.Http.HttpMethod left, System.Net.Http.HttpMethod right) { return default(bool); }
    public static bool operator !=(System.Net.Http.HttpMethod left, System.Net.Http.HttpMethod right) { return default(bool); }
    public override string ToString() { return default(string); }
  }

  public partial class HttpRequestException : System.Exception {
    public HttpRequestException() { }
    public HttpRequestException(string message) { }
    public HttpRequestException(string message, System.Exception inner) { }
  }

  public partial class HttpRequestMessage : System.IDisposable {
    public HttpRequestMessage() { }
    public HttpRequestMessage(System.Net.Http.HttpMethod method, string requestUri) { }
    public HttpRequestMessage(System.Net.Http.HttpMethod method, System.Uri requestUri) { }
    public System.Net.Http.HttpContent Content { get { return default(System.Net.Http.HttpContent); } set { } }
    public System.Net.Http.Headers.HttpRequestHeaders Headers { get { return default(System.Net.Http.Headers.HttpRequestHeaders); } }
    public System.Net.Http.HttpMethod Method { get { return default(System.Net.Http.HttpMethod); } set { } }
    public System.Collections.Generic.IDictionary<string, object> Properties { get { return default(System.Collections.Generic.IDictionary<string, object>); } }
    public System.Uri RequestUri { get { return default(System.Uri); } set { } }
    public System.Version Version { get { return default(System.Version); } set { } }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public override string ToString() { return default(string); }
  }

  public partial class HttpResponseMessage : System.IDisposable {
    public HttpResponseMessage() { }
    public HttpResponseMessage(System.Net.HttpStatusCode statusCode) { }
    public System.Net.Http.HttpContent Content { get { return default(System.Net.Http.HttpContent); } set { } }
    public System.Net.Http.Headers.HttpResponseHeaders Headers { get { return default(System.Net.Http.Headers.HttpResponseHeaders); } }
    public bool IsSuccessStatusCode { get { return default(bool); } }
    public string ReasonPhrase { get { return default(string); } set { } }
    public System.Net.Http.HttpRequestMessage RequestMessage { get { return default(System.Net.Http.HttpRequestMessage); } set { } }
    public System.Net.HttpStatusCode StatusCode { get { return default(System.Net.HttpStatusCode); } set { } }
    public System.Version Version { get { return default(System.Version); } set { } }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public System.Net.Http.HttpResponseMessage EnsureSuccessStatusCode() { return default(System.Net.Http.HttpResponseMessage); }
    public override string ToString() { return default(string); }
  }

  public abstract partial class MessageProcessingHandler : System.Net.Http.DelegatingHandler {
    protected MessageProcessingHandler() { }
    protected MessageProcessingHandler(System.Net.Http.HttpMessageHandler innerHandler) { }
    protected abstract System.Net.Http.HttpRequestMessage ProcessRequest(System.Net.Http.HttpRequestMessage request, System.Threading.CancellationToken cancellationToken);
    protected abstract System.Net.Http.HttpResponseMessage ProcessResponse(System.Net.Http.HttpResponseMessage response, System.Threading.CancellationToken cancellationToken);
    protected internal sealed override System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsync(System.Net.Http.HttpRequestMessage request, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>); }
  }

  public partial class MultipartContent : System.Net.Http.HttpContent, System.Collections.Generic.IEnumerable<System.Net.Http.HttpContent>, System.Collections.IEnumerable {
    public MultipartContent() { }
    public MultipartContent(string subtype) { }
    public MultipartContent(string subtype, string boundary) { }
    public virtual void Add(System.Net.Http.HttpContent content) { }
    protected override void Dispose(bool disposing) { }
    public System.Collections.Generic.IEnumerator<System.Net.Http.HttpContent> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.Net.Http.HttpContent>); }
    protected override System.Threading.Tasks.Task SerializeToStreamAsync(System.IO.Stream stream, System.Net.TransportContext context) { return default(System.Threading.Tasks.Task); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    protected internal override bool TryComputeLength(out long length) { length = default(long); return default(bool); }
  }

  public partial class MultipartFormDataContent : System.Net.Http.MultipartContent {
    public MultipartFormDataContent() { }
    public MultipartFormDataContent(string boundary) { }
    public override void Add(System.Net.Http.HttpContent content) { }
    public void Add(System.Net.Http.HttpContent content, string name) { }
    public void Add(System.Net.Http.HttpContent content, string name, string fileName) { }
  }

  public partial class StreamContent : System.Net.Http.HttpContent {
    public StreamContent(System.IO.Stream content) { }
    public StreamContent(System.IO.Stream content, int bufferSize) { }
    protected override System.Threading.Tasks.Task<System.IO.Stream> CreateContentReadStreamAsync() { return default(System.Threading.Tasks.Task<System.IO.Stream>); }
    protected override void Dispose(bool disposing) { }
    protected override System.Threading.Tasks.Task SerializeToStreamAsync(System.IO.Stream stream, System.Net.TransportContext context) { return default(System.Threading.Tasks.Task); }
    protected internal override bool TryComputeLength(out long length) { length = default(long); return default(bool); }
  }

  public partial class StringContent : System.Net.Http.ByteArrayContent {
    public StringContent(string content) : base (default(byte[])) { }
    public StringContent(string content, System.Text.Encoding encoding) : base (default(byte[])) { }
    public StringContent(string content, System.Text.Encoding encoding, string mediaType) : base (default(byte[])) { }
  }

  public enum CookieUsePolicy {
    IgnoreCookies = 0,
    UseInternalCookieStoreOnly = 1,
    UseSpecifiedCookieContainer = 2,
  }

  public enum WindowsProxyUsePolicy {
    DoNotUseProxy = 0,
    UseCustomProxy = 3,
    UseWinHttpProxy = 1,
    UseWinInetProxy = 2,
  }

  public partial class WinHttpHandler : System.Net.Http.HttpMessageHandler {
    public WinHttpHandler() { }
    public System.Net.DecompressionMethods AutomaticDecompression { get { return default(System.Net.DecompressionMethods); } set { } }
    public bool AutomaticRedirection { get { return default(bool); } set { } }
    public bool CheckCertificateRevocationList { get { return default(bool); } set { } }
    public System.Net.Http.ClientCertificateOption ClientCertificateOption { get { return default(System.Net.Http.ClientCertificateOption); } set { } }
    public System.Security.Cryptography.X509Certificates.X509Certificate2Collection ClientCertificates { get { return default(System.Security.Cryptography.X509Certificates.X509Certificate2Collection); } }
    public System.Net.CookieContainer CookieContainer { get { return default(System.Net.CookieContainer); } set { } }
    public System.Net.Http.CookieUsePolicy CookieUsePolicy { get { return default(System.Net.Http.CookieUsePolicy); } set { } }
    public System.Net.ICredentials DefaultProxyCredentials { get { return default(System.Net.ICredentials); } set { } }
    public int MaxAutomaticRedirections { get { return default(int); } set { } }
    public int MaxConnectionsPerServer { get { return default(int); } set { } }
    public int MaxResponseDrainSize { get { return default(int); } set { } }
    public int MaxResponseHeadersLength { get { return default(int); } set { } }
    public bool PreAuthenticate { get { return default(bool); } set { } }
    public System.Collections.Generic.IDictionary<string, object> Properties { get { return default(System.Collections.Generic.IDictionary<string, object>); } }
    public System.Net.IWebProxy Proxy { get { return default(System.Net.IWebProxy); } set { } }
    public System.TimeSpan ReceiveDataTimeout { get { return default(System.TimeSpan); } set { } }
    public System.TimeSpan ReceiveHeadersTimeout { get { return default(System.TimeSpan); } set { } }
    public System.TimeSpan SendTimeout { get { return default(System.TimeSpan); } set { } }
    public System.Func<System.Net.Http.HttpRequestMessage, System.Security.Cryptography.X509Certificates.X509Certificate2, System.Security.Cryptography.X509Certificates.X509Chain, System.Net.Security.SslPolicyErrors, bool> ServerCertificateValidationCallback { get { return default(System.Func<System.Net.Http.HttpRequestMessage, System.Security.Cryptography.X509Certificates.X509Certificate2, System.Security.Cryptography.X509Certificates.X509Chain, System.Net.Security.SslPolicyErrors, bool>); } set { } }
    public System.Net.ICredentials ServerCredentials { get { return default(System.Net.ICredentials); } set { } }
    public System.Security.Authentication.SslProtocols SslProtocols { get { return default(System.Security.Authentication.SslProtocols); } set { } }
    public System.Net.Http.WindowsProxyUsePolicy WindowsProxyUsePolicy { get { return default(System.Net.Http.WindowsProxyUsePolicy); } set { } }
    protected override void Dispose(bool disposing) { }
    protected override System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsync(System.Net.Http.HttpRequestMessage request, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>); }
  }

} // end of System.Net.Http
namespace System.Net.Http.Headers {
  public partial class AuthenticationHeaderValue {
    public AuthenticationHeaderValue(string scheme) { }
    public AuthenticationHeaderValue(string scheme, string parameter) { }
    public string Parameter { get { return default(string); } }
    public string Scheme { get { return default(string); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static System.Net.Http.Headers.AuthenticationHeaderValue Parse(string input) { return default(System.Net.Http.Headers.AuthenticationHeaderValue); }
    public override string ToString() { return default(string); }
    public static bool TryParse(string input, out System.Net.Http.Headers.AuthenticationHeaderValue parsedValue) { parsedValue = default(System.Net.Http.Headers.AuthenticationHeaderValue); return default(bool); }
  }

  public partial class CacheControlHeaderValue {
    public CacheControlHeaderValue() { }
    public System.Collections.Generic.ICollection<System.Net.Http.Headers.NameValueHeaderValue> Extensions { get { return default(System.Collections.Generic.ICollection<System.Net.Http.Headers.NameValueHeaderValue>); } }
    public System.Nullable<System.TimeSpan> MaxAge { get { return default(System.Nullable<System.TimeSpan>); } set { } }
    public bool MaxStale { get { return default(bool); } set { } }
    public System.Nullable<System.TimeSpan> MaxStaleLimit { get { return default(System.Nullable<System.TimeSpan>); } set { } }
    public System.Nullable<System.TimeSpan> MinFresh { get { return default(System.Nullable<System.TimeSpan>); } set { } }
    public bool MustRevalidate { get { return default(bool); } set { } }
    public bool NoCache { get { return default(bool); } set { } }
    public System.Collections.Generic.ICollection<string> NoCacheHeaders { get { return default(System.Collections.Generic.ICollection<string>); } }
    public bool NoStore { get { return default(bool); } set { } }
    public bool NoTransform { get { return default(bool); } set { } }
    public bool OnlyIfCached { get { return default(bool); } set { } }
    public bool Private { get { return default(bool); } set { } }
    public System.Collections.Generic.ICollection<string> PrivateHeaders { get { return default(System.Collections.Generic.ICollection<string>); } }
    public bool ProxyRevalidate { get { return default(bool); } set { } }
    public bool Public { get { return default(bool); } set { } }
    public System.Nullable<System.TimeSpan> SharedMaxAge { get { return default(System.Nullable<System.TimeSpan>); } set { } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static System.Net.Http.Headers.CacheControlHeaderValue Parse(string input) { return default(System.Net.Http.Headers.CacheControlHeaderValue); }
    public override string ToString() { return default(string); }
    public static bool TryParse(string input, out System.Net.Http.Headers.CacheControlHeaderValue parsedValue) { parsedValue = default(System.Net.Http.Headers.CacheControlHeaderValue); return default(bool); }
  }

  public partial class ContentDispositionHeaderValue {
    protected ContentDispositionHeaderValue(System.Net.Http.Headers.ContentDispositionHeaderValue source) { }
    public ContentDispositionHeaderValue(string dispositionType) { }
    public System.Nullable<System.DateTimeOffset> CreationDate { get { return default(System.Nullable<System.DateTimeOffset>); } set { } }
    public string DispositionType { get { return default(string); } set { } }
    public string FileName { get { return default(string); } set { } }
    public string FileNameStar { get { return default(string); } set { } }
    public System.Nullable<System.DateTimeOffset> ModificationDate { get { return default(System.Nullable<System.DateTimeOffset>); } set { } }
    public string Name { get { return default(string); } set { } }
    public System.Collections.Generic.ICollection<System.Net.Http.Headers.NameValueHeaderValue> Parameters { get { return default(System.Collections.Generic.ICollection<System.Net.Http.Headers.NameValueHeaderValue>); } }
    public System.Nullable<System.DateTimeOffset> ReadDate { get { return default(System.Nullable<System.DateTimeOffset>); } set { } }
    public System.Nullable<long> Size { get { return default(System.Nullable<long>); } set { } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static System.Net.Http.Headers.ContentDispositionHeaderValue Parse(string input) { return default(System.Net.Http.Headers.ContentDispositionHeaderValue); }
    public override string ToString() { return default(string); }
    public static bool TryParse(string input, out System.Net.Http.Headers.ContentDispositionHeaderValue parsedValue) { parsedValue = default(System.Net.Http.Headers.ContentDispositionHeaderValue); return default(bool); }
  }

  public partial class ContentRangeHeaderValue {
    public ContentRangeHeaderValue(long length) { }
    public ContentRangeHeaderValue(long from, long to) { }
    public ContentRangeHeaderValue(long from, long to, long length) { }
    public System.Nullable<long> From { get { return default(System.Nullable<long>); } }
    public bool HasLength { get { return default(bool); } }
    public bool HasRange { get { return default(bool); } }
    public System.Nullable<long> Length { get { return default(System.Nullable<long>); } }
    public System.Nullable<long> To { get { return default(System.Nullable<long>); } }
    public string Unit { get { return default(string); } set { } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static System.Net.Http.Headers.ContentRangeHeaderValue Parse(string input) { return default(System.Net.Http.Headers.ContentRangeHeaderValue); }
    public override string ToString() { return default(string); }
    public static bool TryParse(string input, out System.Net.Http.Headers.ContentRangeHeaderValue parsedValue) { parsedValue = default(System.Net.Http.Headers.ContentRangeHeaderValue); return default(bool); }
  }

  public partial class EntityTagHeaderValue {
    public EntityTagHeaderValue(string tag) { }
    public EntityTagHeaderValue(string tag, bool isWeak) { }
    public static System.Net.Http.Headers.EntityTagHeaderValue Any { get { return default(System.Net.Http.Headers.EntityTagHeaderValue); } }
    public bool IsWeak { get { return default(bool); } }
    public string Tag { get { return default(string); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static System.Net.Http.Headers.EntityTagHeaderValue Parse(string input) { return default(System.Net.Http.Headers.EntityTagHeaderValue); }
    public override string ToString() { return default(string); }
    public static bool TryParse(string input, out System.Net.Http.Headers.EntityTagHeaderValue parsedValue) { parsedValue = default(System.Net.Http.Headers.EntityTagHeaderValue); return default(bool); }
  }

  public sealed partial class HttpContentHeaders : System.Net.Http.Headers.HttpHeaders {
    internal HttpContentHeaders() { }
    public System.Collections.Generic.ICollection<string> Allow { get { return default(System.Collections.Generic.ICollection<string>); } }
    public System.Net.Http.Headers.ContentDispositionHeaderValue ContentDisposition { get { return default(System.Net.Http.Headers.ContentDispositionHeaderValue); } set { } }
    public System.Collections.Generic.ICollection<string> ContentEncoding { get { return default(System.Collections.Generic.ICollection<string>); } }
    public System.Collections.Generic.ICollection<string> ContentLanguage { get { return default(System.Collections.Generic.ICollection<string>); } }
    public System.Nullable<long> ContentLength { get { return default(System.Nullable<long>); } set { } }
    public System.Uri ContentLocation { get { return default(System.Uri); } set { } }
    public byte[] ContentMD5 { get { return default(byte[]); } set { } }
    public System.Net.Http.Headers.ContentRangeHeaderValue ContentRange { get { return default(System.Net.Http.Headers.ContentRangeHeaderValue); } set { } }
    public System.Net.Http.Headers.MediaTypeHeaderValue ContentType { get { return default(System.Net.Http.Headers.MediaTypeHeaderValue); } set { } }
    public System.Nullable<System.DateTimeOffset> Expires { get { return default(System.Nullable<System.DateTimeOffset>); } set { } }
    public System.Nullable<System.DateTimeOffset> LastModified { get { return default(System.Nullable<System.DateTimeOffset>); } set { } }
  }

  public abstract partial class HttpHeaders : System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, System.Collections.Generic.IEnumerable<string>>>, System.Collections.IEnumerable {
    protected HttpHeaders() { }
    public void Add(string name, System.Collections.Generic.IEnumerable<string> values) { }
    public void Add(string name, string value) { }
    public void Clear() { }
    public bool Contains(string name) { return default(bool); }
    public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, System.Collections.Generic.IEnumerable<string>>> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, System.Collections.Generic.IEnumerable<string>>>); }
    public System.Collections.Generic.IEnumerable<string> GetValues(string name) { return default(System.Collections.Generic.IEnumerable<string>); }
    public bool Remove(string name) { return default(bool); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    public override string ToString() { return default(string); }
    public bool TryAddWithoutValidation(string name, System.Collections.Generic.IEnumerable<string> values) { return default(bool); }
    public bool TryAddWithoutValidation(string name, string value) { return default(bool); }
    public bool TryGetValues(string name, out System.Collections.Generic.IEnumerable<string> values) { values = default(System.Collections.Generic.IEnumerable<string>); return default(bool); }
  }

  public sealed partial class HttpHeaderValueCollection<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable where T : class {
    internal HttpHeaderValueCollection() { }
    public int Count { get { return default(int); } }
    public bool IsReadOnly { get { return default(bool); } }
    public void Add(T item) { }
    public void Clear() { }
    public bool Contains(T item) { return default(bool); }
    public void CopyTo(T[] array, int arrayIndex) { }
    public System.Collections.Generic.IEnumerator<T> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<T>); }
    public void ParseAdd(string input) { }
    public bool Remove(T item) { return default(bool); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    public override string ToString() { return default(string); }
    public bool TryParseAdd(string input) { return default(bool); }
  }

  public sealed partial class HttpRequestHeaders : System.Net.Http.Headers.HttpHeaders {
    internal HttpRequestHeaders() { }
    public System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.MediaTypeWithQualityHeaderValue> Accept { get { return default(System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.MediaTypeWithQualityHeaderValue>); } }
    public System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.StringWithQualityHeaderValue> AcceptCharset { get { return default(System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.StringWithQualityHeaderValue>); } }
    public System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.StringWithQualityHeaderValue> AcceptEncoding { get { return default(System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.StringWithQualityHeaderValue>); } }
    public System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.StringWithQualityHeaderValue> AcceptLanguage { get { return default(System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.StringWithQualityHeaderValue>); } }
    public System.Net.Http.Headers.AuthenticationHeaderValue Authorization { get { return default(System.Net.Http.Headers.AuthenticationHeaderValue); } set { } }
    public System.Net.Http.Headers.CacheControlHeaderValue CacheControl { get { return default(System.Net.Http.Headers.CacheControlHeaderValue); } set { } }
    public System.Net.Http.Headers.HttpHeaderValueCollection<string> Connection { get { return default(System.Net.Http.Headers.HttpHeaderValueCollection<string>); } }
    public System.Nullable<bool> ConnectionClose { get { return default(System.Nullable<bool>); } set { } }
    public System.Nullable<System.DateTimeOffset> Date { get { return default(System.Nullable<System.DateTimeOffset>); } set { } }
    public System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.NameValueWithParametersHeaderValue> Expect { get { return default(System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.NameValueWithParametersHeaderValue>); } }
    public System.Nullable<bool> ExpectContinue { get { return default(System.Nullable<bool>); } set { } }
    public string From { get { return default(string); } set { } }
    public string Host { get { return default(string); } set { } }
    public System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.EntityTagHeaderValue> IfMatch { get { return default(System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.EntityTagHeaderValue>); } }
    public System.Nullable<System.DateTimeOffset> IfModifiedSince { get { return default(System.Nullable<System.DateTimeOffset>); } set { } }
    public System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.EntityTagHeaderValue> IfNoneMatch { get { return default(System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.EntityTagHeaderValue>); } }
    public System.Net.Http.Headers.RangeConditionHeaderValue IfRange { get { return default(System.Net.Http.Headers.RangeConditionHeaderValue); } set { } }
    public System.Nullable<System.DateTimeOffset> IfUnmodifiedSince { get { return default(System.Nullable<System.DateTimeOffset>); } set { } }
    public System.Nullable<int> MaxForwards { get { return default(System.Nullable<int>); } set { } }
    public System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.NameValueHeaderValue> Pragma { get { return default(System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.NameValueHeaderValue>); } }
    public System.Net.Http.Headers.AuthenticationHeaderValue ProxyAuthorization { get { return default(System.Net.Http.Headers.AuthenticationHeaderValue); } set { } }
    public System.Net.Http.Headers.RangeHeaderValue Range { get { return default(System.Net.Http.Headers.RangeHeaderValue); } set { } }
    public System.Uri Referrer { get { return default(System.Uri); } set { } }
    public System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.TransferCodingWithQualityHeaderValue> TE { get { return default(System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.TransferCodingWithQualityHeaderValue>); } }
    public System.Net.Http.Headers.HttpHeaderValueCollection<string> Trailer { get { return default(System.Net.Http.Headers.HttpHeaderValueCollection<string>); } }
    public System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.TransferCodingHeaderValue> TransferEncoding { get { return default(System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.TransferCodingHeaderValue>); } }
    public System.Nullable<bool> TransferEncodingChunked { get { return default(System.Nullable<bool>); } set { } }
    public System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.ProductHeaderValue> Upgrade { get { return default(System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.ProductHeaderValue>); } }
    public System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.ProductInfoHeaderValue> UserAgent { get { return default(System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.ProductInfoHeaderValue>); } }
    public System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.ViaHeaderValue> Via { get { return default(System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.ViaHeaderValue>); } }
    public System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.WarningHeaderValue> Warning { get { return default(System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.WarningHeaderValue>); } }
  }

  public sealed partial class HttpResponseHeaders : System.Net.Http.Headers.HttpHeaders {
    internal HttpResponseHeaders() { }
    public System.Net.Http.Headers.HttpHeaderValueCollection<string> AcceptRanges { get { return default(System.Net.Http.Headers.HttpHeaderValueCollection<string>); } }
    public System.Nullable<System.TimeSpan> Age { get { return default(System.Nullable<System.TimeSpan>); } set { } }
    public System.Net.Http.Headers.CacheControlHeaderValue CacheControl { get { return default(System.Net.Http.Headers.CacheControlHeaderValue); } set { } }
    public System.Net.Http.Headers.HttpHeaderValueCollection<string> Connection { get { return default(System.Net.Http.Headers.HttpHeaderValueCollection<string>); } }
    public System.Nullable<bool> ConnectionClose { get { return default(System.Nullable<bool>); } set { } }
    public System.Nullable<System.DateTimeOffset> Date { get { return default(System.Nullable<System.DateTimeOffset>); } set { } }
    public System.Net.Http.Headers.EntityTagHeaderValue ETag { get { return default(System.Net.Http.Headers.EntityTagHeaderValue); } set { } }
    public System.Uri Location { get { return default(System.Uri); } set { } }
    public System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.NameValueHeaderValue> Pragma { get { return default(System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.NameValueHeaderValue>); } }
    public System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.AuthenticationHeaderValue> ProxyAuthenticate { get { return default(System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.AuthenticationHeaderValue>); } }
    public System.Net.Http.Headers.RetryConditionHeaderValue RetryAfter { get { return default(System.Net.Http.Headers.RetryConditionHeaderValue); } set { } }
    public System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.ProductInfoHeaderValue> Server { get { return default(System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.ProductInfoHeaderValue>); } }
    public System.Net.Http.Headers.HttpHeaderValueCollection<string> Trailer { get { return default(System.Net.Http.Headers.HttpHeaderValueCollection<string>); } }
    public System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.TransferCodingHeaderValue> TransferEncoding { get { return default(System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.TransferCodingHeaderValue>); } }
    public System.Nullable<bool> TransferEncodingChunked { get { return default(System.Nullable<bool>); } set { } }
    public System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.ProductHeaderValue> Upgrade { get { return default(System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.ProductHeaderValue>); } }
    public System.Net.Http.Headers.HttpHeaderValueCollection<string> Vary { get { return default(System.Net.Http.Headers.HttpHeaderValueCollection<string>); } }
    public System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.ViaHeaderValue> Via { get { return default(System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.ViaHeaderValue>); } }
    public System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.WarningHeaderValue> Warning { get { return default(System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.WarningHeaderValue>); } }
    public System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.AuthenticationHeaderValue> WwwAuthenticate { get { return default(System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.AuthenticationHeaderValue>); } }
  }

  public partial class MediaTypeHeaderValue {
    protected MediaTypeHeaderValue(System.Net.Http.Headers.MediaTypeHeaderValue source) { }
    public MediaTypeHeaderValue(string mediaType) { }
    public string CharSet { get { return default(string); } set { } }
    public string MediaType { get { return default(string); } set { } }
    public System.Collections.Generic.ICollection<System.Net.Http.Headers.NameValueHeaderValue> Parameters { get { return default(System.Collections.Generic.ICollection<System.Net.Http.Headers.NameValueHeaderValue>); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static System.Net.Http.Headers.MediaTypeHeaderValue Parse(string input) { return default(System.Net.Http.Headers.MediaTypeHeaderValue); }
    public override string ToString() { return default(string); }
    public static bool TryParse(string input, out System.Net.Http.Headers.MediaTypeHeaderValue parsedValue) { parsedValue = default(System.Net.Http.Headers.MediaTypeHeaderValue); return default(bool); }
  }

  public sealed partial class MediaTypeWithQualityHeaderValue : System.Net.Http.Headers.MediaTypeHeaderValue {
    public MediaTypeWithQualityHeaderValue(string mediaType) : base (default(System.Net.Http.Headers.MediaTypeHeaderValue)) { }
    public MediaTypeWithQualityHeaderValue(string mediaType, double quality) : base (default(System.Net.Http.Headers.MediaTypeHeaderValue)) { }
    public System.Nullable<double> Quality { get { return default(System.Nullable<double>); } set { } }
    public static new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue Parse(string input) { return default(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue); }
    public static bool TryParse(string input, out System.Net.Http.Headers.MediaTypeWithQualityHeaderValue parsedValue) { parsedValue = default(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue); return default(bool); }
  }

  public partial class NameValueHeaderValue {
    protected NameValueHeaderValue(System.Net.Http.Headers.NameValueHeaderValue source) { }
    public NameValueHeaderValue(string name) { }
    public NameValueHeaderValue(string name, string value) { }
    public string Name { get { return default(string); } }
    public string Value { get { return default(string); } set { } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static System.Net.Http.Headers.NameValueHeaderValue Parse(string input) { return default(System.Net.Http.Headers.NameValueHeaderValue); }
    public override string ToString() { return default(string); }
    public static bool TryParse(string input, out System.Net.Http.Headers.NameValueHeaderValue parsedValue) { parsedValue = default(System.Net.Http.Headers.NameValueHeaderValue); return default(bool); }
  }

  public partial class NameValueWithParametersHeaderValue : System.Net.Http.Headers.NameValueHeaderValue {
    protected NameValueWithParametersHeaderValue(System.Net.Http.Headers.NameValueWithParametersHeaderValue source) : base (default(System.Net.Http.Headers.NameValueHeaderValue)) { }
    public NameValueWithParametersHeaderValue(string name) : base (default(System.Net.Http.Headers.NameValueHeaderValue)) { }
    public NameValueWithParametersHeaderValue(string name, string value) : base (default(System.Net.Http.Headers.NameValueHeaderValue)) { }
    public System.Collections.Generic.ICollection<System.Net.Http.Headers.NameValueHeaderValue> Parameters { get { return default(System.Collections.Generic.ICollection<System.Net.Http.Headers.NameValueHeaderValue>); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static new System.Net.Http.Headers.NameValueWithParametersHeaderValue Parse(string input) { return default(System.Net.Http.Headers.NameValueWithParametersHeaderValue); }
    public override string ToString() { return default(string); }
    public static bool TryParse(string input, out System.Net.Http.Headers.NameValueWithParametersHeaderValue parsedValue) { parsedValue = default(System.Net.Http.Headers.NameValueWithParametersHeaderValue); return default(bool); }
  }

  public partial class ProductHeaderValue {
    public ProductHeaderValue(string name) { }
    public ProductHeaderValue(string name, string version) { }
    public string Name { get { return default(string); } }
    public string Version { get { return default(string); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static System.Net.Http.Headers.ProductHeaderValue Parse(string input) { return default(System.Net.Http.Headers.ProductHeaderValue); }
    public override string ToString() { return default(string); }
    public static bool TryParse(string input, out System.Net.Http.Headers.ProductHeaderValue parsedValue) { parsedValue = default(System.Net.Http.Headers.ProductHeaderValue); return default(bool); }
  }

  public partial class ProductInfoHeaderValue {
    public ProductInfoHeaderValue(System.Net.Http.Headers.ProductHeaderValue product) { }
    public ProductInfoHeaderValue(string comment) { }
    public ProductInfoHeaderValue(string productName, string productVersion) { }
    public string Comment { get { return default(string); } }
    public System.Net.Http.Headers.ProductHeaderValue Product { get { return default(System.Net.Http.Headers.ProductHeaderValue); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static System.Net.Http.Headers.ProductInfoHeaderValue Parse(string input) { return default(System.Net.Http.Headers.ProductInfoHeaderValue); }
    public override string ToString() { return default(string); }
    public static bool TryParse(string input, out System.Net.Http.Headers.ProductInfoHeaderValue parsedValue) { parsedValue = default(System.Net.Http.Headers.ProductInfoHeaderValue); return default(bool); }
  }

  public partial class RangeConditionHeaderValue {
    public RangeConditionHeaderValue(System.DateTimeOffset date) { }
    public RangeConditionHeaderValue(System.Net.Http.Headers.EntityTagHeaderValue entityTag) { }
    public RangeConditionHeaderValue(string entityTag) { }
    public System.Nullable<System.DateTimeOffset> Date { get { return default(System.Nullable<System.DateTimeOffset>); } }
    public System.Net.Http.Headers.EntityTagHeaderValue EntityTag { get { return default(System.Net.Http.Headers.EntityTagHeaderValue); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static System.Net.Http.Headers.RangeConditionHeaderValue Parse(string input) { return default(System.Net.Http.Headers.RangeConditionHeaderValue); }
    public override string ToString() { return default(string); }
    public static bool TryParse(string input, out System.Net.Http.Headers.RangeConditionHeaderValue parsedValue) { parsedValue = default(System.Net.Http.Headers.RangeConditionHeaderValue); return default(bool); }
  }

  public partial class RangeHeaderValue {
    public RangeHeaderValue() { }
    public RangeHeaderValue(System.Nullable<long> from, System.Nullable<long> to) { }
    public System.Collections.Generic.ICollection<System.Net.Http.Headers.RangeItemHeaderValue> Ranges { get { return default(System.Collections.Generic.ICollection<System.Net.Http.Headers.RangeItemHeaderValue>); } }
    public string Unit { get { return default(string); } set { } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static System.Net.Http.Headers.RangeHeaderValue Parse(string input) { return default(System.Net.Http.Headers.RangeHeaderValue); }
    public override string ToString() { return default(string); }
    public static bool TryParse(string input, out System.Net.Http.Headers.RangeHeaderValue parsedValue) { parsedValue = default(System.Net.Http.Headers.RangeHeaderValue); return default(bool); }
  }

  public partial class RangeItemHeaderValue {
    public RangeItemHeaderValue(System.Nullable<long> from, System.Nullable<long> to) { }
    public System.Nullable<long> From { get { return default(System.Nullable<long>); } }
    public System.Nullable<long> To { get { return default(System.Nullable<long>); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override string ToString() { return default(string); }
  }

  public partial class RetryConditionHeaderValue {
    public RetryConditionHeaderValue(System.DateTimeOffset date) { }
    public RetryConditionHeaderValue(System.TimeSpan delta) { }
    public System.Nullable<System.DateTimeOffset> Date { get { return default(System.Nullable<System.DateTimeOffset>); } }
    public System.Nullable<System.TimeSpan> Delta { get { return default(System.Nullable<System.TimeSpan>); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static System.Net.Http.Headers.RetryConditionHeaderValue Parse(string input) { return default(System.Net.Http.Headers.RetryConditionHeaderValue); }
    public override string ToString() { return default(string); }
    public static bool TryParse(string input, out System.Net.Http.Headers.RetryConditionHeaderValue parsedValue) { parsedValue = default(System.Net.Http.Headers.RetryConditionHeaderValue); return default(bool); }
  }

  public partial class StringWithQualityHeaderValue {
    public StringWithQualityHeaderValue(string value) { }
    public StringWithQualityHeaderValue(string value, double quality) { }
    public System.Nullable<double> Quality { get { return default(System.Nullable<double>); } }
    public string Value { get { return default(string); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static System.Net.Http.Headers.StringWithQualityHeaderValue Parse(string input) { return default(System.Net.Http.Headers.StringWithQualityHeaderValue); }
    public override string ToString() { return default(string); }
    public static bool TryParse(string input, out System.Net.Http.Headers.StringWithQualityHeaderValue parsedValue) { parsedValue = default(System.Net.Http.Headers.StringWithQualityHeaderValue); return default(bool); }
  }

  public partial class TransferCodingHeaderValue {
    protected TransferCodingHeaderValue(System.Net.Http.Headers.TransferCodingHeaderValue source) { }
    public TransferCodingHeaderValue(string value) { }
    public System.Collections.Generic.ICollection<System.Net.Http.Headers.NameValueHeaderValue> Parameters { get { return default(System.Collections.Generic.ICollection<System.Net.Http.Headers.NameValueHeaderValue>); } }
    public string Value { get { return default(string); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static System.Net.Http.Headers.TransferCodingHeaderValue Parse(string input) { return default(System.Net.Http.Headers.TransferCodingHeaderValue); }
    public override string ToString() { return default(string); }
    public static bool TryParse(string input, out System.Net.Http.Headers.TransferCodingHeaderValue parsedValue) { parsedValue = default(System.Net.Http.Headers.TransferCodingHeaderValue); return default(bool); }
  }

  public sealed partial class TransferCodingWithQualityHeaderValue : System.Net.Http.Headers.TransferCodingHeaderValue {
    public TransferCodingWithQualityHeaderValue(string value) : base (default(System.Net.Http.Headers.TransferCodingHeaderValue)) { }
    public TransferCodingWithQualityHeaderValue(string value, double quality) : base (default(System.Net.Http.Headers.TransferCodingHeaderValue)) { }
    public System.Nullable<double> Quality { get { return default(System.Nullable<double>); } set { } }
    public static new System.Net.Http.Headers.TransferCodingWithQualityHeaderValue Parse(string input) { return default(System.Net.Http.Headers.TransferCodingWithQualityHeaderValue); }
    public static bool TryParse(string input, out System.Net.Http.Headers.TransferCodingWithQualityHeaderValue parsedValue) { parsedValue = default(System.Net.Http.Headers.TransferCodingWithQualityHeaderValue); return default(bool); }
  }

  public partial class ViaHeaderValue {
    public ViaHeaderValue(string protocolVersion, string receivedBy) { }
    public ViaHeaderValue(string protocolVersion, string receivedBy, string protocolName) { }
    public ViaHeaderValue(string protocolVersion, string receivedBy, string protocolName, string comment) { }
    public string Comment { get { return default(string); } }
    public string ProtocolName { get { return default(string); } }
    public string ProtocolVersion { get { return default(string); } }
    public string ReceivedBy { get { return default(string); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static System.Net.Http.Headers.ViaHeaderValue Parse(string input) { return default(System.Net.Http.Headers.ViaHeaderValue); }
    public override string ToString() { return default(string); }
    public static bool TryParse(string input, out System.Net.Http.Headers.ViaHeaderValue parsedValue) { parsedValue = default(System.Net.Http.Headers.ViaHeaderValue); return default(bool); }
  }

  public partial class WarningHeaderValue {
    public WarningHeaderValue(int code, string agent, string text) { }
    public WarningHeaderValue(int code, string agent, string text, System.DateTimeOffset date) { }
    public string Agent { get { return default(string); } }
    public int Code { get { return default(int); } }
    public System.Nullable<System.DateTimeOffset> Date { get { return default(System.Nullable<System.DateTimeOffset>); } }
    public string Text { get { return default(string); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static System.Net.Http.Headers.WarningHeaderValue Parse(string input) { return default(System.Net.Http.Headers.WarningHeaderValue); }
    public override string ToString() { return default(string); }
    public static bool TryParse(string input, out System.Net.Http.Headers.WarningHeaderValue parsedValue) { parsedValue = default(System.Net.Http.Headers.WarningHeaderValue); return default(bool); }
  }

} // end of System.Net.Http.Headers
namespace System.Net.Security {
  public enum EncryptionPolicy {
    AllowNoEncryption = 1,
    NoEncryption = 2,
    RequireEncryption = 0,
  }

} // end of System.Net.Security
namespace System.Net.Sockets {
  public enum IPProtectionLevel {
    EdgeRestricted = 20,
    Restricted = 30,
    Unrestricted = 10,
    Unspecified = -1,
  }

  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct SocketReceiveFromResult {
    public int ReceivedBytes;
    public System.Net.EndPoint RemoteEndPoint;
  }

  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct SocketReceiveMessageFromResult {
    public System.Net.Sockets.IPPacketInformation PacketInformation;
    public int ReceivedBytes;
    public System.Net.EndPoint RemoteEndPoint;
    public System.Net.Sockets.SocketFlags SocketFlags;
  }

  public static partial class SocketTaskExtensions {
    public static System.Threading.Tasks.Task<System.Net.Sockets.Socket> AcceptAsync(this System.Net.Sockets.Socket socket) { return default(System.Threading.Tasks.Task<System.Net.Sockets.Socket>); }
    public static System.Threading.Tasks.Task<System.Net.Sockets.Socket> AcceptAsync(this System.Net.Sockets.Socket socket, System.Net.Sockets.Socket acceptSocket) { return default(System.Threading.Tasks.Task<System.Net.Sockets.Socket>); }
    public static System.Threading.Tasks.Task ConnectAsync(this System.Net.Sockets.Socket socket, System.Net.EndPoint remoteEP) { return default(System.Threading.Tasks.Task); }
    public static System.Threading.Tasks.Task ConnectAsync(this System.Net.Sockets.Socket socket, System.Net.IPAddress address, int port) { return default(System.Threading.Tasks.Task); }
    public static System.Threading.Tasks.Task ConnectAsync(this System.Net.Sockets.Socket socket, System.Net.IPAddress[] addresses, int port) { return default(System.Threading.Tasks.Task); }
    public static System.Threading.Tasks.Task ConnectAsync(this System.Net.Sockets.Socket socket, string host, int port) { return default(System.Threading.Tasks.Task); }
    public static System.Threading.Tasks.Task<int> ReceiveAsync(this System.Net.Sockets.Socket socket, System.ArraySegment<byte> buffer, System.Net.Sockets.SocketFlags socketFlags) { return default(System.Threading.Tasks.Task<int>); }
    public static System.Threading.Tasks.Task<int> ReceiveAsync(this System.Net.Sockets.Socket socket, System.Collections.Generic.IList<System.ArraySegment<byte>> buffers, System.Net.Sockets.SocketFlags socketFlags) { return default(System.Threading.Tasks.Task<int>); }
    public static System.Threading.Tasks.Task<System.Net.Sockets.SocketReceiveFromResult> ReceiveFromAsync(this System.Net.Sockets.Socket socket, System.ArraySegment<byte> buffer, System.Net.Sockets.SocketFlags socketFlags, System.Net.EndPoint remoteEndPoint) { return default(System.Threading.Tasks.Task<System.Net.Sockets.SocketReceiveFromResult>); }
    public static System.Threading.Tasks.Task<System.Net.Sockets.SocketReceiveMessageFromResult> ReceiveMessageFromAsync(this System.Net.Sockets.Socket socket, System.ArraySegment<byte> buffer, System.Net.Sockets.SocketFlags socketFlags, System.Net.EndPoint remoteEndPoint) { return default(System.Threading.Tasks.Task<System.Net.Sockets.SocketReceiveMessageFromResult>); }
    public static System.Threading.Tasks.Task<int> SendAsync(this System.Net.Sockets.Socket socket, System.ArraySegment<byte> buffer, System.Net.Sockets.SocketFlags socketFlags) { return default(System.Threading.Tasks.Task<int>); }
    public static System.Threading.Tasks.Task<int> SendAsync(this System.Net.Sockets.Socket socket, System.Collections.Generic.IList<System.ArraySegment<byte>> buffers, System.Net.Sockets.SocketFlags socketFlags) { return default(System.Threading.Tasks.Task<int>); }
    public static System.Threading.Tasks.Task<int> SendToAsync(this System.Net.Sockets.Socket socket, System.ArraySegment<byte> buffer, System.Net.Sockets.SocketFlags socketFlags, System.Net.EndPoint remoteEP) { return default(System.Threading.Tasks.Task<int>); }
  }

} // end of System.Net.Sockets
namespace System.Numerics {
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct Matrix3x2 : System.IEquatable<System.Numerics.Matrix3x2> {
    public float M11;
    public float M12;
    public float M21;
    public float M22;
    public float M31;
    public float M32;
    public Matrix3x2(float m11, float m12, float m21, float m22, float m31, float m32) { throw new System.NotImplementedException(); }
    public static System.Numerics.Matrix3x2 Identity { get { return default(System.Numerics.Matrix3x2); } }
    public bool IsIdentity { get { return default(bool); } }
    public System.Numerics.Vector2 Translation { get { return default(System.Numerics.Vector2); } set { } }
    public static System.Numerics.Matrix3x2 Add(System.Numerics.Matrix3x2 value1, System.Numerics.Matrix3x2 value2) { return default(System.Numerics.Matrix3x2); }
    public static System.Numerics.Matrix3x2 CreateRotation(float radians) { return default(System.Numerics.Matrix3x2); }
    public static System.Numerics.Matrix3x2 CreateRotation(float radians, System.Numerics.Vector2 centerPoint) { return default(System.Numerics.Matrix3x2); }
    public static System.Numerics.Matrix3x2 CreateScale(System.Numerics.Vector2 scales) { return default(System.Numerics.Matrix3x2); }
    public static System.Numerics.Matrix3x2 CreateScale(System.Numerics.Vector2 scales, System.Numerics.Vector2 centerPoint) { return default(System.Numerics.Matrix3x2); }
    public static System.Numerics.Matrix3x2 CreateScale(float scale) { return default(System.Numerics.Matrix3x2); }
    public static System.Numerics.Matrix3x2 CreateScale(float scale, System.Numerics.Vector2 centerPoint) { return default(System.Numerics.Matrix3x2); }
    public static System.Numerics.Matrix3x2 CreateScale(float xScale, float yScale) { return default(System.Numerics.Matrix3x2); }
    public static System.Numerics.Matrix3x2 CreateScale(float xScale, float yScale, System.Numerics.Vector2 centerPoint) { return default(System.Numerics.Matrix3x2); }
    public static System.Numerics.Matrix3x2 CreateSkew(float radiansX, float radiansY) { return default(System.Numerics.Matrix3x2); }
    public static System.Numerics.Matrix3x2 CreateSkew(float radiansX, float radiansY, System.Numerics.Vector2 centerPoint) { return default(System.Numerics.Matrix3x2); }
    public static System.Numerics.Matrix3x2 CreateTranslation(System.Numerics.Vector2 position) { return default(System.Numerics.Matrix3x2); }
    public static System.Numerics.Matrix3x2 CreateTranslation(float xPosition, float yPosition) { return default(System.Numerics.Matrix3x2); }
    public bool Equals(System.Numerics.Matrix3x2 other) { return default(bool); }
    public override bool Equals(object obj) { return default(bool); }
    public float GetDeterminant() { return default(float); }
    public override int GetHashCode() { return default(int); }
    public static bool Invert(System.Numerics.Matrix3x2 matrix, out System.Numerics.Matrix3x2 result) { result = default(System.Numerics.Matrix3x2); return default(bool); }
    public static System.Numerics.Matrix3x2 Lerp(System.Numerics.Matrix3x2 matrix1, System.Numerics.Matrix3x2 matrix2, float amount) { return default(System.Numerics.Matrix3x2); }
    public static System.Numerics.Matrix3x2 Multiply(System.Numerics.Matrix3x2 value1, System.Numerics.Matrix3x2 value2) { return default(System.Numerics.Matrix3x2); }
    public static System.Numerics.Matrix3x2 Multiply(System.Numerics.Matrix3x2 value1, float value2) { return default(System.Numerics.Matrix3x2); }
    public static System.Numerics.Matrix3x2 Negate(System.Numerics.Matrix3x2 value) { return default(System.Numerics.Matrix3x2); }
    public static System.Numerics.Matrix3x2 operator +(System.Numerics.Matrix3x2 value1, System.Numerics.Matrix3x2 value2) { return default(System.Numerics.Matrix3x2); }
    public static bool operator ==(System.Numerics.Matrix3x2 value1, System.Numerics.Matrix3x2 value2) { return default(bool); }
    public static bool operator !=(System.Numerics.Matrix3x2 value1, System.Numerics.Matrix3x2 value2) { return default(bool); }
    public static System.Numerics.Matrix3x2 operator *(System.Numerics.Matrix3x2 value1, System.Numerics.Matrix3x2 value2) { return default(System.Numerics.Matrix3x2); }
    public static System.Numerics.Matrix3x2 operator *(System.Numerics.Matrix3x2 value1, float value2) { return default(System.Numerics.Matrix3x2); }
    public static System.Numerics.Matrix3x2 operator -(System.Numerics.Matrix3x2 value1, System.Numerics.Matrix3x2 value2) { return default(System.Numerics.Matrix3x2); }
    public static System.Numerics.Matrix3x2 operator -(System.Numerics.Matrix3x2 value) { return default(System.Numerics.Matrix3x2); }
    public static System.Numerics.Matrix3x2 Subtract(System.Numerics.Matrix3x2 value1, System.Numerics.Matrix3x2 value2) { return default(System.Numerics.Matrix3x2); }
    public override string ToString() { return default(string); }
  }

  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct Matrix4x4 : System.IEquatable<System.Numerics.Matrix4x4> {
    public float M11;
    public float M12;
    public float M13;
    public float M14;
    public float M21;
    public float M22;
    public float M23;
    public float M24;
    public float M31;
    public float M32;
    public float M33;
    public float M34;
    public float M41;
    public float M42;
    public float M43;
    public float M44;
    public Matrix4x4(System.Numerics.Matrix3x2 value) { throw new System.NotImplementedException(); }
    public Matrix4x4(float m11, float m12, float m13, float m14, float m21, float m22, float m23, float m24, float m31, float m32, float m33, float m34, float m41, float m42, float m43, float m44) { throw new System.NotImplementedException(); }
    public static System.Numerics.Matrix4x4 Identity { get { return default(System.Numerics.Matrix4x4); } }
    public bool IsIdentity { get { return default(bool); } }
    public System.Numerics.Vector3 Translation { get { return default(System.Numerics.Vector3); } set { } }
    public static System.Numerics.Matrix4x4 Add(System.Numerics.Matrix4x4 value1, System.Numerics.Matrix4x4 value2) { return default(System.Numerics.Matrix4x4); }
    public static System.Numerics.Matrix4x4 CreateBillboard(System.Numerics.Vector3 objectPosition, System.Numerics.Vector3 cameraPosition, System.Numerics.Vector3 cameraUpVector, System.Numerics.Vector3 cameraForwardVector) { return default(System.Numerics.Matrix4x4); }
    public static System.Numerics.Matrix4x4 CreateConstrainedBillboard(System.Numerics.Vector3 objectPosition, System.Numerics.Vector3 cameraPosition, System.Numerics.Vector3 rotateAxis, System.Numerics.Vector3 cameraForwardVector, System.Numerics.Vector3 objectForwardVector) { return default(System.Numerics.Matrix4x4); }
    public static System.Numerics.Matrix4x4 CreateFromAxisAngle(System.Numerics.Vector3 axis, float angle) { return default(System.Numerics.Matrix4x4); }
    public static System.Numerics.Matrix4x4 CreateFromQuaternion(System.Numerics.Quaternion quaternion) { return default(System.Numerics.Matrix4x4); }
    public static System.Numerics.Matrix4x4 CreateFromYawPitchRoll(float yaw, float pitch, float roll) { return default(System.Numerics.Matrix4x4); }
    public static System.Numerics.Matrix4x4 CreateLookAt(System.Numerics.Vector3 cameraPosition, System.Numerics.Vector3 cameraTarget, System.Numerics.Vector3 cameraUpVector) { return default(System.Numerics.Matrix4x4); }
    public static System.Numerics.Matrix4x4 CreateOrthographic(float width, float height, float zNearPlane, float zFarPlane) { return default(System.Numerics.Matrix4x4); }
    public static System.Numerics.Matrix4x4 CreateOrthographicOffCenter(float left, float right, float bottom, float top, float zNearPlane, float zFarPlane) { return default(System.Numerics.Matrix4x4); }
    public static System.Numerics.Matrix4x4 CreatePerspective(float width, float height, float nearPlaneDistance, float farPlaneDistance) { return default(System.Numerics.Matrix4x4); }
    public static System.Numerics.Matrix4x4 CreatePerspectiveFieldOfView(float fieldOfView, float aspectRatio, float nearPlaneDistance, float farPlaneDistance) { return default(System.Numerics.Matrix4x4); }
    public static System.Numerics.Matrix4x4 CreatePerspectiveOffCenter(float left, float right, float bottom, float top, float nearPlaneDistance, float farPlaneDistance) { return default(System.Numerics.Matrix4x4); }
    public static System.Numerics.Matrix4x4 CreateReflection(System.Numerics.Plane value) { return default(System.Numerics.Matrix4x4); }
    public static System.Numerics.Matrix4x4 CreateRotationX(float radians) { return default(System.Numerics.Matrix4x4); }
    public static System.Numerics.Matrix4x4 CreateRotationX(float radians, System.Numerics.Vector3 centerPoint) { return default(System.Numerics.Matrix4x4); }
    public static System.Numerics.Matrix4x4 CreateRotationY(float radians) { return default(System.Numerics.Matrix4x4); }
    public static System.Numerics.Matrix4x4 CreateRotationY(float radians, System.Numerics.Vector3 centerPoint) { return default(System.Numerics.Matrix4x4); }
    public static System.Numerics.Matrix4x4 CreateRotationZ(float radians) { return default(System.Numerics.Matrix4x4); }
    public static System.Numerics.Matrix4x4 CreateRotationZ(float radians, System.Numerics.Vector3 centerPoint) { return default(System.Numerics.Matrix4x4); }
    public static System.Numerics.Matrix4x4 CreateScale(System.Numerics.Vector3 scales) { return default(System.Numerics.Matrix4x4); }
    public static System.Numerics.Matrix4x4 CreateScale(System.Numerics.Vector3 scales, System.Numerics.Vector3 centerPoint) { return default(System.Numerics.Matrix4x4); }
    public static System.Numerics.Matrix4x4 CreateScale(float scale) { return default(System.Numerics.Matrix4x4); }
    public static System.Numerics.Matrix4x4 CreateScale(float scale, System.Numerics.Vector3 centerPoint) { return default(System.Numerics.Matrix4x4); }
    public static System.Numerics.Matrix4x4 CreateScale(float xScale, float yScale, float zScale) { return default(System.Numerics.Matrix4x4); }
    public static System.Numerics.Matrix4x4 CreateScale(float xScale, float yScale, float zScale, System.Numerics.Vector3 centerPoint) { return default(System.Numerics.Matrix4x4); }
    public static System.Numerics.Matrix4x4 CreateShadow(System.Numerics.Vector3 lightDirection, System.Numerics.Plane plane) { return default(System.Numerics.Matrix4x4); }
    public static System.Numerics.Matrix4x4 CreateTranslation(System.Numerics.Vector3 position) { return default(System.Numerics.Matrix4x4); }
    public static System.Numerics.Matrix4x4 CreateTranslation(float xPosition, float yPosition, float zPosition) { return default(System.Numerics.Matrix4x4); }
    public static System.Numerics.Matrix4x4 CreateWorld(System.Numerics.Vector3 position, System.Numerics.Vector3 forward, System.Numerics.Vector3 up) { return default(System.Numerics.Matrix4x4); }
    public static bool Decompose(System.Numerics.Matrix4x4 matrix, out System.Numerics.Vector3 scale, out System.Numerics.Quaternion rotation, out System.Numerics.Vector3 translation) { scale = default(System.Numerics.Vector3); rotation = default(System.Numerics.Quaternion); translation = default(System.Numerics.Vector3); return default(bool); }
    public bool Equals(System.Numerics.Matrix4x4 other) { return default(bool); }
    public override bool Equals(object obj) { return default(bool); }
    public float GetDeterminant() { return default(float); }
    public override int GetHashCode() { return default(int); }
    public static bool Invert(System.Numerics.Matrix4x4 matrix, out System.Numerics.Matrix4x4 result) { result = default(System.Numerics.Matrix4x4); return default(bool); }
    public static System.Numerics.Matrix4x4 Lerp(System.Numerics.Matrix4x4 matrix1, System.Numerics.Matrix4x4 matrix2, float amount) { return default(System.Numerics.Matrix4x4); }
    public static System.Numerics.Matrix4x4 Multiply(System.Numerics.Matrix4x4 value1, System.Numerics.Matrix4x4 value2) { return default(System.Numerics.Matrix4x4); }
    public static System.Numerics.Matrix4x4 Multiply(System.Numerics.Matrix4x4 value1, float value2) { return default(System.Numerics.Matrix4x4); }
    public static System.Numerics.Matrix4x4 Negate(System.Numerics.Matrix4x4 value) { return default(System.Numerics.Matrix4x4); }
    public static System.Numerics.Matrix4x4 operator +(System.Numerics.Matrix4x4 value1, System.Numerics.Matrix4x4 value2) { return default(System.Numerics.Matrix4x4); }
    public static bool operator ==(System.Numerics.Matrix4x4 value1, System.Numerics.Matrix4x4 value2) { return default(bool); }
    public static bool operator !=(System.Numerics.Matrix4x4 value1, System.Numerics.Matrix4x4 value2) { return default(bool); }
    public static System.Numerics.Matrix4x4 operator *(System.Numerics.Matrix4x4 value1, System.Numerics.Matrix4x4 value2) { return default(System.Numerics.Matrix4x4); }
    public static System.Numerics.Matrix4x4 operator *(System.Numerics.Matrix4x4 value1, float value2) { return default(System.Numerics.Matrix4x4); }
    public static System.Numerics.Matrix4x4 operator -(System.Numerics.Matrix4x4 value1, System.Numerics.Matrix4x4 value2) { return default(System.Numerics.Matrix4x4); }
    public static System.Numerics.Matrix4x4 operator -(System.Numerics.Matrix4x4 value) { return default(System.Numerics.Matrix4x4); }
    public static System.Numerics.Matrix4x4 Subtract(System.Numerics.Matrix4x4 value1, System.Numerics.Matrix4x4 value2) { return default(System.Numerics.Matrix4x4); }
    public override string ToString() { return default(string); }
    public static System.Numerics.Matrix4x4 Transform(System.Numerics.Matrix4x4 value, System.Numerics.Quaternion rotation) { return default(System.Numerics.Matrix4x4); }
    public static System.Numerics.Matrix4x4 Transpose(System.Numerics.Matrix4x4 matrix) { return default(System.Numerics.Matrix4x4); }
  }

  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct Plane : System.IEquatable<System.Numerics.Plane> {
    public float D;
    public System.Numerics.Vector3 Normal;
    public Plane(System.Numerics.Vector3 normal, float d) { throw new System.NotImplementedException(); }
    public Plane(System.Numerics.Vector4 value) { throw new System.NotImplementedException(); }
    public Plane(float x, float y, float z, float d) { throw new System.NotImplementedException(); }
    public static System.Numerics.Plane CreateFromVertices(System.Numerics.Vector3 point1, System.Numerics.Vector3 point2, System.Numerics.Vector3 point3) { return default(System.Numerics.Plane); }
    public static float Dot(System.Numerics.Plane plane, System.Numerics.Vector4 value) { return default(float); }
    public static float DotCoordinate(System.Numerics.Plane plane, System.Numerics.Vector3 value) { return default(float); }
    public static float DotNormal(System.Numerics.Plane plane, System.Numerics.Vector3 value) { return default(float); }
    public bool Equals(System.Numerics.Plane other) { return default(bool); }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static System.Numerics.Plane Normalize(System.Numerics.Plane value) { return default(System.Numerics.Plane); }
    public static bool operator ==(System.Numerics.Plane value1, System.Numerics.Plane value2) { return default(bool); }
    public static bool operator !=(System.Numerics.Plane value1, System.Numerics.Plane value2) { return default(bool); }
    public override string ToString() { return default(string); }
    public static System.Numerics.Plane Transform(System.Numerics.Plane plane, System.Numerics.Matrix4x4 matrix) { return default(System.Numerics.Plane); }
    public static System.Numerics.Plane Transform(System.Numerics.Plane plane, System.Numerics.Quaternion rotation) { return default(System.Numerics.Plane); }
  }

  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct Quaternion : System.IEquatable<System.Numerics.Quaternion> {
    public float W;
    public float X;
    public float Y;
    public float Z;
    public Quaternion(System.Numerics.Vector3 vectorPart, float scalarPart) { throw new System.NotImplementedException(); }
    public Quaternion(float x, float y, float z, float w) { throw new System.NotImplementedException(); }
    public static System.Numerics.Quaternion Identity { get { return default(System.Numerics.Quaternion); } }
    public bool IsIdentity { get { return default(bool); } }
    public static System.Numerics.Quaternion Add(System.Numerics.Quaternion value1, System.Numerics.Quaternion value2) { return default(System.Numerics.Quaternion); }
    public static System.Numerics.Quaternion Concatenate(System.Numerics.Quaternion value1, System.Numerics.Quaternion value2) { return default(System.Numerics.Quaternion); }
    public static System.Numerics.Quaternion Conjugate(System.Numerics.Quaternion value) { return default(System.Numerics.Quaternion); }
    public static System.Numerics.Quaternion CreateFromAxisAngle(System.Numerics.Vector3 axis, float angle) { return default(System.Numerics.Quaternion); }
    public static System.Numerics.Quaternion CreateFromRotationMatrix(System.Numerics.Matrix4x4 matrix) { return default(System.Numerics.Quaternion); }
    public static System.Numerics.Quaternion CreateFromYawPitchRoll(float yaw, float pitch, float roll) { return default(System.Numerics.Quaternion); }
    public static System.Numerics.Quaternion Divide(System.Numerics.Quaternion value1, System.Numerics.Quaternion value2) { return default(System.Numerics.Quaternion); }
    public static float Dot(System.Numerics.Quaternion quaternion1, System.Numerics.Quaternion quaternion2) { return default(float); }
    public bool Equals(System.Numerics.Quaternion other) { return default(bool); }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static System.Numerics.Quaternion Inverse(System.Numerics.Quaternion value) { return default(System.Numerics.Quaternion); }
    public float Length() { return default(float); }
    public float LengthSquared() { return default(float); }
    public static System.Numerics.Quaternion Lerp(System.Numerics.Quaternion quaternion1, System.Numerics.Quaternion quaternion2, float amount) { return default(System.Numerics.Quaternion); }
    public static System.Numerics.Quaternion Multiply(System.Numerics.Quaternion value1, System.Numerics.Quaternion value2) { return default(System.Numerics.Quaternion); }
    public static System.Numerics.Quaternion Multiply(System.Numerics.Quaternion value1, float value2) { return default(System.Numerics.Quaternion); }
    public static System.Numerics.Quaternion Negate(System.Numerics.Quaternion value) { return default(System.Numerics.Quaternion); }
    public static System.Numerics.Quaternion Normalize(System.Numerics.Quaternion value) { return default(System.Numerics.Quaternion); }
    public static System.Numerics.Quaternion operator +(System.Numerics.Quaternion value1, System.Numerics.Quaternion value2) { return default(System.Numerics.Quaternion); }
    public static System.Numerics.Quaternion operator /(System.Numerics.Quaternion value1, System.Numerics.Quaternion value2) { return default(System.Numerics.Quaternion); }
    public static bool operator ==(System.Numerics.Quaternion value1, System.Numerics.Quaternion value2) { return default(bool); }
    public static bool operator !=(System.Numerics.Quaternion value1, System.Numerics.Quaternion value2) { return default(bool); }
    public static System.Numerics.Quaternion operator *(System.Numerics.Quaternion value1, System.Numerics.Quaternion value2) { return default(System.Numerics.Quaternion); }
    public static System.Numerics.Quaternion operator *(System.Numerics.Quaternion value1, float value2) { return default(System.Numerics.Quaternion); }
    public static System.Numerics.Quaternion operator -(System.Numerics.Quaternion value1, System.Numerics.Quaternion value2) { return default(System.Numerics.Quaternion); }
    public static System.Numerics.Quaternion operator -(System.Numerics.Quaternion value) { return default(System.Numerics.Quaternion); }
    public static System.Numerics.Quaternion Slerp(System.Numerics.Quaternion quaternion1, System.Numerics.Quaternion quaternion2, float amount) { return default(System.Numerics.Quaternion); }
    public static System.Numerics.Quaternion Subtract(System.Numerics.Quaternion value1, System.Numerics.Quaternion value2) { return default(System.Numerics.Quaternion); }
    public override string ToString() { return default(string); }
  }

  public static partial class Vector {
    public static bool IsHardwareAccelerated { get { return default(bool); } }
    public static System.Numerics.Vector<T> Abs<T>(System.Numerics.Vector<T> value) where T : struct { return default(System.Numerics.Vector<T>); }
    public static System.Numerics.Vector<T> Add<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { return default(System.Numerics.Vector<T>); }
    public static System.Numerics.Vector<T> AndNot<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { return default(System.Numerics.Vector<T>); }
    public static System.Numerics.Vector<byte> AsVectorByte<T>(System.Numerics.Vector<T> value) where T : struct { return default(System.Numerics.Vector<byte>); }
    public static System.Numerics.Vector<double> AsVectorDouble<T>(System.Numerics.Vector<T> value) where T : struct { return default(System.Numerics.Vector<double>); }
    public static System.Numerics.Vector<short> AsVectorInt16<T>(System.Numerics.Vector<T> value) where T : struct { return default(System.Numerics.Vector<short>); }
    public static System.Numerics.Vector<int> AsVectorInt32<T>(System.Numerics.Vector<T> value) where T : struct { return default(System.Numerics.Vector<int>); }
    public static System.Numerics.Vector<long> AsVectorInt64<T>(System.Numerics.Vector<T> value) where T : struct { return default(System.Numerics.Vector<long>); }
    [System.CLSCompliantAttribute(false)]
    public static System.Numerics.Vector<sbyte> AsVectorSByte<T>(System.Numerics.Vector<T> value) where T : struct { return default(System.Numerics.Vector<sbyte>); }
    public static System.Numerics.Vector<float> AsVectorSingle<T>(System.Numerics.Vector<T> value) where T : struct { return default(System.Numerics.Vector<float>); }
    [System.CLSCompliantAttribute(false)]
    public static System.Numerics.Vector<ushort> AsVectorUInt16<T>(System.Numerics.Vector<T> value) where T : struct { return default(System.Numerics.Vector<ushort>); }
    [System.CLSCompliantAttribute(false)]
    public static System.Numerics.Vector<uint> AsVectorUInt32<T>(System.Numerics.Vector<T> value) where T : struct { return default(System.Numerics.Vector<uint>); }
    [System.CLSCompliantAttribute(false)]
    public static System.Numerics.Vector<ulong> AsVectorUInt64<T>(System.Numerics.Vector<T> value) where T : struct { return default(System.Numerics.Vector<ulong>); }
    public static System.Numerics.Vector<T> BitwiseAnd<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { return default(System.Numerics.Vector<T>); }
    public static System.Numerics.Vector<T> BitwiseOr<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { return default(System.Numerics.Vector<T>); }
    public static System.Numerics.Vector<float> ConditionalSelect(System.Numerics.Vector<int> condition, System.Numerics.Vector<float> left, System.Numerics.Vector<float> right) { return default(System.Numerics.Vector<float>); }
    public static System.Numerics.Vector<double> ConditionalSelect(System.Numerics.Vector<long> condition, System.Numerics.Vector<double> left, System.Numerics.Vector<double> right) { return default(System.Numerics.Vector<double>); }
    public static System.Numerics.Vector<T> ConditionalSelect<T>(System.Numerics.Vector<T> condition, System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { return default(System.Numerics.Vector<T>); }
    public static System.Numerics.Vector<T> Divide<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { return default(System.Numerics.Vector<T>); }
    public static T Dot<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { return default(T); }
    public static System.Numerics.Vector<long> Equals(System.Numerics.Vector<double> left, System.Numerics.Vector<double> right) { return default(System.Numerics.Vector<long>); }
    public static System.Numerics.Vector<int> Equals(System.Numerics.Vector<int> left, System.Numerics.Vector<int> right) { return default(System.Numerics.Vector<int>); }
    public static System.Numerics.Vector<long> Equals(System.Numerics.Vector<long> left, System.Numerics.Vector<long> right) { return default(System.Numerics.Vector<long>); }
    public static System.Numerics.Vector<int> Equals(System.Numerics.Vector<float> left, System.Numerics.Vector<float> right) { return default(System.Numerics.Vector<int>); }
    public static System.Numerics.Vector<T> Equals<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { return default(System.Numerics.Vector<T>); }
    public static bool EqualsAll<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { return default(bool); }
    public static bool EqualsAny<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { return default(bool); }
    public static System.Numerics.Vector<long> GreaterThan(System.Numerics.Vector<double> left, System.Numerics.Vector<double> right) { return default(System.Numerics.Vector<long>); }
    public static System.Numerics.Vector<int> GreaterThan(System.Numerics.Vector<int> left, System.Numerics.Vector<int> right) { return default(System.Numerics.Vector<int>); }
    public static System.Numerics.Vector<long> GreaterThan(System.Numerics.Vector<long> left, System.Numerics.Vector<long> right) { return default(System.Numerics.Vector<long>); }
    public static System.Numerics.Vector<int> GreaterThan(System.Numerics.Vector<float> left, System.Numerics.Vector<float> right) { return default(System.Numerics.Vector<int>); }
    public static System.Numerics.Vector<T> GreaterThan<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { return default(System.Numerics.Vector<T>); }
    public static bool GreaterThanAll<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { return default(bool); }
    public static bool GreaterThanAny<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { return default(bool); }
    public static System.Numerics.Vector<long> GreaterThanOrEqual(System.Numerics.Vector<double> left, System.Numerics.Vector<double> right) { return default(System.Numerics.Vector<long>); }
    public static System.Numerics.Vector<int> GreaterThanOrEqual(System.Numerics.Vector<int> left, System.Numerics.Vector<int> right) { return default(System.Numerics.Vector<int>); }
    public static System.Numerics.Vector<long> GreaterThanOrEqual(System.Numerics.Vector<long> left, System.Numerics.Vector<long> right) { return default(System.Numerics.Vector<long>); }
    public static System.Numerics.Vector<int> GreaterThanOrEqual(System.Numerics.Vector<float> left, System.Numerics.Vector<float> right) { return default(System.Numerics.Vector<int>); }
    public static System.Numerics.Vector<T> GreaterThanOrEqual<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { return default(System.Numerics.Vector<T>); }
    public static bool GreaterThanOrEqualAll<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { return default(bool); }
    public static bool GreaterThanOrEqualAny<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { return default(bool); }
    public static System.Numerics.Vector<long> LessThan(System.Numerics.Vector<double> left, System.Numerics.Vector<double> right) { return default(System.Numerics.Vector<long>); }
    public static System.Numerics.Vector<int> LessThan(System.Numerics.Vector<int> left, System.Numerics.Vector<int> right) { return default(System.Numerics.Vector<int>); }
    public static System.Numerics.Vector<long> LessThan(System.Numerics.Vector<long> left, System.Numerics.Vector<long> right) { return default(System.Numerics.Vector<long>); }
    public static System.Numerics.Vector<int> LessThan(System.Numerics.Vector<float> left, System.Numerics.Vector<float> right) { return default(System.Numerics.Vector<int>); }
    public static System.Numerics.Vector<T> LessThan<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { return default(System.Numerics.Vector<T>); }
    public static bool LessThanAll<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { return default(bool); }
    public static bool LessThanAny<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { return default(bool); }
    public static System.Numerics.Vector<long> LessThanOrEqual(System.Numerics.Vector<double> left, System.Numerics.Vector<double> right) { return default(System.Numerics.Vector<long>); }
    public static System.Numerics.Vector<int> LessThanOrEqual(System.Numerics.Vector<int> left, System.Numerics.Vector<int> right) { return default(System.Numerics.Vector<int>); }
    public static System.Numerics.Vector<long> LessThanOrEqual(System.Numerics.Vector<long> left, System.Numerics.Vector<long> right) { return default(System.Numerics.Vector<long>); }
    public static System.Numerics.Vector<int> LessThanOrEqual(System.Numerics.Vector<float> left, System.Numerics.Vector<float> right) { return default(System.Numerics.Vector<int>); }
    public static System.Numerics.Vector<T> LessThanOrEqual<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { return default(System.Numerics.Vector<T>); }
    public static bool LessThanOrEqualAll<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { return default(bool); }
    public static bool LessThanOrEqualAny<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { return default(bool); }
    public static System.Numerics.Vector<T> Max<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { return default(System.Numerics.Vector<T>); }
    public static System.Numerics.Vector<T> Min<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { return default(System.Numerics.Vector<T>); }
    public static System.Numerics.Vector<T> Multiply<T>(T left, System.Numerics.Vector<T> right) where T : struct { return default(System.Numerics.Vector<T>); }
    public static System.Numerics.Vector<T> Multiply<T>(System.Numerics.Vector<T> left, T right) where T : struct { return default(System.Numerics.Vector<T>); }
    public static System.Numerics.Vector<T> Multiply<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { return default(System.Numerics.Vector<T>); }
    public static System.Numerics.Vector<T> Negate<T>(System.Numerics.Vector<T> value) where T : struct { return default(System.Numerics.Vector<T>); }
    public static System.Numerics.Vector<T> OnesComplement<T>(System.Numerics.Vector<T> value) where T : struct { return default(System.Numerics.Vector<T>); }
    public static System.Numerics.Vector<T> SquareRoot<T>(System.Numerics.Vector<T> value) where T : struct { return default(System.Numerics.Vector<T>); }
    public static System.Numerics.Vector<T> Subtract<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { return default(System.Numerics.Vector<T>); }
    public static System.Numerics.Vector<T> Xor<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) where T : struct { return default(System.Numerics.Vector<T>); }
  }

  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct Vector<T> : System.IEquatable<System.Numerics.Vector<T>>, System.IFormattable where T : struct {
    public Vector(T value) { throw new System.NotImplementedException(); }
    public Vector(T[] values) { throw new System.NotImplementedException(); }
    public Vector(T[] values, int index) { throw new System.NotImplementedException(); }
    public static int Count { get { return default(int); } }
    public T this[int index] { get { return default(T); } }
    public static System.Numerics.Vector<T> One { get { return default(System.Numerics.Vector<T>); } }
    public static System.Numerics.Vector<T> Zero { get { return default(System.Numerics.Vector<T>); } }
    public void CopyTo(T[] destination) { }
    public void CopyTo(T[] destination, int startIndex) { }
    public bool Equals(System.Numerics.Vector<T> other) { return default(bool); }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static System.Numerics.Vector<T> operator +(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { return default(System.Numerics.Vector<T>); }
    public static System.Numerics.Vector<T> operator &(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { return default(System.Numerics.Vector<T>); }
    public static System.Numerics.Vector<T> operator |(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { return default(System.Numerics.Vector<T>); }
    public static System.Numerics.Vector<T> operator /(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { return default(System.Numerics.Vector<T>); }
    public static bool operator ==(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { return default(bool); }
    public static System.Numerics.Vector<T> operator ^(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { return default(System.Numerics.Vector<T>); }
    public static explicit operator System.Numerics.Vector<byte> (System.Numerics.Vector<T> value) { return default(System.Numerics.Vector<byte>); }
    public static explicit operator System.Numerics.Vector<double> (System.Numerics.Vector<T> value) { return default(System.Numerics.Vector<double>); }
    public static explicit operator System.Numerics.Vector<short> (System.Numerics.Vector<T> value) { return default(System.Numerics.Vector<short>); }
    public static explicit operator System.Numerics.Vector<int> (System.Numerics.Vector<T> value) { return default(System.Numerics.Vector<int>); }
    public static explicit operator System.Numerics.Vector<long> (System.Numerics.Vector<T> value) { return default(System.Numerics.Vector<long>); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator System.Numerics.Vector<sbyte> (System.Numerics.Vector<T> value) { return default(System.Numerics.Vector<sbyte>); }
    public static explicit operator System.Numerics.Vector<float> (System.Numerics.Vector<T> value) { return default(System.Numerics.Vector<float>); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator System.Numerics.Vector<ushort> (System.Numerics.Vector<T> value) { return default(System.Numerics.Vector<ushort>); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator System.Numerics.Vector<uint> (System.Numerics.Vector<T> value) { return default(System.Numerics.Vector<uint>); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator System.Numerics.Vector<ulong> (System.Numerics.Vector<T> value) { return default(System.Numerics.Vector<ulong>); }
    public static bool operator !=(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { return default(bool); }
    public static System.Numerics.Vector<T> operator *(T factor, System.Numerics.Vector<T> value) { return default(System.Numerics.Vector<T>); }
    public static System.Numerics.Vector<T> operator *(System.Numerics.Vector<T> value, T factor) { return default(System.Numerics.Vector<T>); }
    public static System.Numerics.Vector<T> operator *(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { return default(System.Numerics.Vector<T>); }
    public static System.Numerics.Vector<T> operator ~(System.Numerics.Vector<T> value) { return default(System.Numerics.Vector<T>); }
    public static System.Numerics.Vector<T> operator -(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { return default(System.Numerics.Vector<T>); }
    public static System.Numerics.Vector<T> operator -(System.Numerics.Vector<T> value) { return default(System.Numerics.Vector<T>); }
    public override string ToString() { return default(string); }
    public string ToString(string format) { return default(string); }
    public string ToString(string format, System.IFormatProvider formatProvider) { return default(string); }
  }

  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct Vector2 : System.IEquatable<System.Numerics.Vector2>, System.IFormattable {
    public float X;
    public float Y;
    public Vector2(float value) { throw new System.NotImplementedException(); }
    public Vector2(float x, float y) { throw new System.NotImplementedException(); }
    public static System.Numerics.Vector2 One { get { return default(System.Numerics.Vector2); } }
    public static System.Numerics.Vector2 UnitX { get { return default(System.Numerics.Vector2); } }
    public static System.Numerics.Vector2 UnitY { get { return default(System.Numerics.Vector2); } }
    public static System.Numerics.Vector2 Zero { get { return default(System.Numerics.Vector2); } }
    public static System.Numerics.Vector2 Abs(System.Numerics.Vector2 value) { return default(System.Numerics.Vector2); }
    public static System.Numerics.Vector2 Add(System.Numerics.Vector2 left, System.Numerics.Vector2 right) { return default(System.Numerics.Vector2); }
    public static System.Numerics.Vector2 Clamp(System.Numerics.Vector2 value1, System.Numerics.Vector2 min, System.Numerics.Vector2 max) { return default(System.Numerics.Vector2); }
    public void CopyTo(float[] array) { }
    public void CopyTo(float[] array, int index) { }
    public static float Distance(System.Numerics.Vector2 value1, System.Numerics.Vector2 value2) { return default(float); }
    public static float DistanceSquared(System.Numerics.Vector2 value1, System.Numerics.Vector2 value2) { return default(float); }
    public static System.Numerics.Vector2 Divide(System.Numerics.Vector2 left, System.Numerics.Vector2 right) { return default(System.Numerics.Vector2); }
    public static System.Numerics.Vector2 Divide(System.Numerics.Vector2 left, float divisor) { return default(System.Numerics.Vector2); }
    public static float Dot(System.Numerics.Vector2 value1, System.Numerics.Vector2 value2) { return default(float); }
    public bool Equals(System.Numerics.Vector2 other) { return default(bool); }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public float Length() { return default(float); }
    public float LengthSquared() { return default(float); }
    public static System.Numerics.Vector2 Lerp(System.Numerics.Vector2 value1, System.Numerics.Vector2 value2, float amount) { return default(System.Numerics.Vector2); }
    public static System.Numerics.Vector2 Max(System.Numerics.Vector2 value1, System.Numerics.Vector2 value2) { return default(System.Numerics.Vector2); }
    public static System.Numerics.Vector2 Min(System.Numerics.Vector2 value1, System.Numerics.Vector2 value2) { return default(System.Numerics.Vector2); }
    public static System.Numerics.Vector2 Multiply(System.Numerics.Vector2 left, System.Numerics.Vector2 right) { return default(System.Numerics.Vector2); }
    public static System.Numerics.Vector2 Multiply(System.Numerics.Vector2 left, float right) { return default(System.Numerics.Vector2); }
    public static System.Numerics.Vector2 Multiply(float left, System.Numerics.Vector2 right) { return default(System.Numerics.Vector2); }
    public static System.Numerics.Vector2 Negate(System.Numerics.Vector2 value) { return default(System.Numerics.Vector2); }
    public static System.Numerics.Vector2 Normalize(System.Numerics.Vector2 value) { return default(System.Numerics.Vector2); }
    public static System.Numerics.Vector2 operator +(System.Numerics.Vector2 left, System.Numerics.Vector2 right) { return default(System.Numerics.Vector2); }
    public static System.Numerics.Vector2 operator /(System.Numerics.Vector2 left, System.Numerics.Vector2 right) { return default(System.Numerics.Vector2); }
    public static System.Numerics.Vector2 operator /(System.Numerics.Vector2 value1, float value2) { return default(System.Numerics.Vector2); }
    public static bool operator ==(System.Numerics.Vector2 left, System.Numerics.Vector2 right) { return default(bool); }
    public static bool operator !=(System.Numerics.Vector2 left, System.Numerics.Vector2 right) { return default(bool); }
    public static System.Numerics.Vector2 operator *(System.Numerics.Vector2 left, System.Numerics.Vector2 right) { return default(System.Numerics.Vector2); }
    public static System.Numerics.Vector2 operator *(System.Numerics.Vector2 left, float right) { return default(System.Numerics.Vector2); }
    public static System.Numerics.Vector2 operator *(float left, System.Numerics.Vector2 right) { return default(System.Numerics.Vector2); }
    public static System.Numerics.Vector2 operator -(System.Numerics.Vector2 left, System.Numerics.Vector2 right) { return default(System.Numerics.Vector2); }
    public static System.Numerics.Vector2 operator -(System.Numerics.Vector2 value) { return default(System.Numerics.Vector2); }
    public static System.Numerics.Vector2 Reflect(System.Numerics.Vector2 vector, System.Numerics.Vector2 normal) { return default(System.Numerics.Vector2); }
    public static System.Numerics.Vector2 SquareRoot(System.Numerics.Vector2 value) { return default(System.Numerics.Vector2); }
    public static System.Numerics.Vector2 Subtract(System.Numerics.Vector2 left, System.Numerics.Vector2 right) { return default(System.Numerics.Vector2); }
    public override string ToString() { return default(string); }
    public string ToString(string format) { return default(string); }
    public string ToString(string format, System.IFormatProvider formatProvider) { return default(string); }
    public static System.Numerics.Vector2 Transform(System.Numerics.Vector2 position, System.Numerics.Matrix3x2 matrix) { return default(System.Numerics.Vector2); }
    public static System.Numerics.Vector2 Transform(System.Numerics.Vector2 position, System.Numerics.Matrix4x4 matrix) { return default(System.Numerics.Vector2); }
    public static System.Numerics.Vector2 Transform(System.Numerics.Vector2 value, System.Numerics.Quaternion rotation) { return default(System.Numerics.Vector2); }
    public static System.Numerics.Vector2 TransformNormal(System.Numerics.Vector2 normal, System.Numerics.Matrix3x2 matrix) { return default(System.Numerics.Vector2); }
    public static System.Numerics.Vector2 TransformNormal(System.Numerics.Vector2 normal, System.Numerics.Matrix4x4 matrix) { return default(System.Numerics.Vector2); }
  }

  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct Vector3 : System.IEquatable<System.Numerics.Vector3>, System.IFormattable {
    public float X;
    public float Y;
    public float Z;
    public Vector3(System.Numerics.Vector2 value, float z) { throw new System.NotImplementedException(); }
    public Vector3(float value) { throw new System.NotImplementedException(); }
    public Vector3(float x, float y, float z) { throw new System.NotImplementedException(); }
    public static System.Numerics.Vector3 One { get { return default(System.Numerics.Vector3); } }
    public static System.Numerics.Vector3 UnitX { get { return default(System.Numerics.Vector3); } }
    public static System.Numerics.Vector3 UnitY { get { return default(System.Numerics.Vector3); } }
    public static System.Numerics.Vector3 UnitZ { get { return default(System.Numerics.Vector3); } }
    public static System.Numerics.Vector3 Zero { get { return default(System.Numerics.Vector3); } }
    public static System.Numerics.Vector3 Abs(System.Numerics.Vector3 value) { return default(System.Numerics.Vector3); }
    public static System.Numerics.Vector3 Add(System.Numerics.Vector3 left, System.Numerics.Vector3 right) { return default(System.Numerics.Vector3); }
    public static System.Numerics.Vector3 Clamp(System.Numerics.Vector3 value1, System.Numerics.Vector3 min, System.Numerics.Vector3 max) { return default(System.Numerics.Vector3); }
    public void CopyTo(float[] array) { }
    public void CopyTo(float[] array, int index) { }
    public static System.Numerics.Vector3 Cross(System.Numerics.Vector3 vector1, System.Numerics.Vector3 vector2) { return default(System.Numerics.Vector3); }
    public static float Distance(System.Numerics.Vector3 value1, System.Numerics.Vector3 value2) { return default(float); }
    public static float DistanceSquared(System.Numerics.Vector3 value1, System.Numerics.Vector3 value2) { return default(float); }
    public static System.Numerics.Vector3 Divide(System.Numerics.Vector3 left, System.Numerics.Vector3 right) { return default(System.Numerics.Vector3); }
    public static System.Numerics.Vector3 Divide(System.Numerics.Vector3 left, float divisor) { return default(System.Numerics.Vector3); }
    public static float Dot(System.Numerics.Vector3 vector1, System.Numerics.Vector3 vector2) { return default(float); }
    public bool Equals(System.Numerics.Vector3 other) { return default(bool); }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public float Length() { return default(float); }
    public float LengthSquared() { return default(float); }
    public static System.Numerics.Vector3 Lerp(System.Numerics.Vector3 value1, System.Numerics.Vector3 value2, float amount) { return default(System.Numerics.Vector3); }
    public static System.Numerics.Vector3 Max(System.Numerics.Vector3 value1, System.Numerics.Vector3 value2) { return default(System.Numerics.Vector3); }
    public static System.Numerics.Vector3 Min(System.Numerics.Vector3 value1, System.Numerics.Vector3 value2) { return default(System.Numerics.Vector3); }
    public static System.Numerics.Vector3 Multiply(System.Numerics.Vector3 left, System.Numerics.Vector3 right) { return default(System.Numerics.Vector3); }
    public static System.Numerics.Vector3 Multiply(System.Numerics.Vector3 left, float right) { return default(System.Numerics.Vector3); }
    public static System.Numerics.Vector3 Multiply(float left, System.Numerics.Vector3 right) { return default(System.Numerics.Vector3); }
    public static System.Numerics.Vector3 Negate(System.Numerics.Vector3 value) { return default(System.Numerics.Vector3); }
    public static System.Numerics.Vector3 Normalize(System.Numerics.Vector3 value) { return default(System.Numerics.Vector3); }
    public static System.Numerics.Vector3 operator +(System.Numerics.Vector3 left, System.Numerics.Vector3 right) { return default(System.Numerics.Vector3); }
    public static System.Numerics.Vector3 operator /(System.Numerics.Vector3 left, System.Numerics.Vector3 right) { return default(System.Numerics.Vector3); }
    public static System.Numerics.Vector3 operator /(System.Numerics.Vector3 value1, float value2) { return default(System.Numerics.Vector3); }
    public static bool operator ==(System.Numerics.Vector3 left, System.Numerics.Vector3 right) { return default(bool); }
    public static bool operator !=(System.Numerics.Vector3 left, System.Numerics.Vector3 right) { return default(bool); }
    public static System.Numerics.Vector3 operator *(System.Numerics.Vector3 left, System.Numerics.Vector3 right) { return default(System.Numerics.Vector3); }
    public static System.Numerics.Vector3 operator *(System.Numerics.Vector3 left, float right) { return default(System.Numerics.Vector3); }
    public static System.Numerics.Vector3 operator *(float left, System.Numerics.Vector3 right) { return default(System.Numerics.Vector3); }
    public static System.Numerics.Vector3 operator -(System.Numerics.Vector3 left, System.Numerics.Vector3 right) { return default(System.Numerics.Vector3); }
    public static System.Numerics.Vector3 operator -(System.Numerics.Vector3 value) { return default(System.Numerics.Vector3); }
    public static System.Numerics.Vector3 Reflect(System.Numerics.Vector3 vector, System.Numerics.Vector3 normal) { return default(System.Numerics.Vector3); }
    public static System.Numerics.Vector3 SquareRoot(System.Numerics.Vector3 value) { return default(System.Numerics.Vector3); }
    public static System.Numerics.Vector3 Subtract(System.Numerics.Vector3 left, System.Numerics.Vector3 right) { return default(System.Numerics.Vector3); }
    public override string ToString() { return default(string); }
    public string ToString(string format) { return default(string); }
    public string ToString(string format, System.IFormatProvider formatProvider) { return default(string); }
    public static System.Numerics.Vector3 Transform(System.Numerics.Vector3 position, System.Numerics.Matrix4x4 matrix) { return default(System.Numerics.Vector3); }
    public static System.Numerics.Vector3 Transform(System.Numerics.Vector3 value, System.Numerics.Quaternion rotation) { return default(System.Numerics.Vector3); }
    public static System.Numerics.Vector3 TransformNormal(System.Numerics.Vector3 normal, System.Numerics.Matrix4x4 matrix) { return default(System.Numerics.Vector3); }
  }

  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct Vector4 : System.IEquatable<System.Numerics.Vector4>, System.IFormattable {
    public float W;
    public float X;
    public float Y;
    public float Z;
    public Vector4(System.Numerics.Vector2 value, float z, float w) { throw new System.NotImplementedException(); }
    public Vector4(System.Numerics.Vector3 value, float w) { throw new System.NotImplementedException(); }
    public Vector4(float value) { throw new System.NotImplementedException(); }
    public Vector4(float x, float y, float z, float w) { throw new System.NotImplementedException(); }
    public static System.Numerics.Vector4 One { get { return default(System.Numerics.Vector4); } }
    public static System.Numerics.Vector4 UnitW { get { return default(System.Numerics.Vector4); } }
    public static System.Numerics.Vector4 UnitX { get { return default(System.Numerics.Vector4); } }
    public static System.Numerics.Vector4 UnitY { get { return default(System.Numerics.Vector4); } }
    public static System.Numerics.Vector4 UnitZ { get { return default(System.Numerics.Vector4); } }
    public static System.Numerics.Vector4 Zero { get { return default(System.Numerics.Vector4); } }
    public static System.Numerics.Vector4 Abs(System.Numerics.Vector4 value) { return default(System.Numerics.Vector4); }
    public static System.Numerics.Vector4 Add(System.Numerics.Vector4 left, System.Numerics.Vector4 right) { return default(System.Numerics.Vector4); }
    public static System.Numerics.Vector4 Clamp(System.Numerics.Vector4 value1, System.Numerics.Vector4 min, System.Numerics.Vector4 max) { return default(System.Numerics.Vector4); }
    public void CopyTo(float[] array) { }
    public void CopyTo(float[] array, int index) { }
    public static float Distance(System.Numerics.Vector4 value1, System.Numerics.Vector4 value2) { return default(float); }
    public static float DistanceSquared(System.Numerics.Vector4 value1, System.Numerics.Vector4 value2) { return default(float); }
    public static System.Numerics.Vector4 Divide(System.Numerics.Vector4 left, System.Numerics.Vector4 right) { return default(System.Numerics.Vector4); }
    public static System.Numerics.Vector4 Divide(System.Numerics.Vector4 left, float divisor) { return default(System.Numerics.Vector4); }
    public static float Dot(System.Numerics.Vector4 vector1, System.Numerics.Vector4 vector2) { return default(float); }
    public bool Equals(System.Numerics.Vector4 other) { return default(bool); }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public float Length() { return default(float); }
    public float LengthSquared() { return default(float); }
    public static System.Numerics.Vector4 Lerp(System.Numerics.Vector4 value1, System.Numerics.Vector4 value2, float amount) { return default(System.Numerics.Vector4); }
    public static System.Numerics.Vector4 Max(System.Numerics.Vector4 value1, System.Numerics.Vector4 value2) { return default(System.Numerics.Vector4); }
    public static System.Numerics.Vector4 Min(System.Numerics.Vector4 value1, System.Numerics.Vector4 value2) { return default(System.Numerics.Vector4); }
    public static System.Numerics.Vector4 Multiply(System.Numerics.Vector4 left, System.Numerics.Vector4 right) { return default(System.Numerics.Vector4); }
    public static System.Numerics.Vector4 Multiply(System.Numerics.Vector4 left, float right) { return default(System.Numerics.Vector4); }
    public static System.Numerics.Vector4 Multiply(float left, System.Numerics.Vector4 right) { return default(System.Numerics.Vector4); }
    public static System.Numerics.Vector4 Negate(System.Numerics.Vector4 value) { return default(System.Numerics.Vector4); }
    public static System.Numerics.Vector4 Normalize(System.Numerics.Vector4 vector) { return default(System.Numerics.Vector4); }
    public static System.Numerics.Vector4 operator +(System.Numerics.Vector4 left, System.Numerics.Vector4 right) { return default(System.Numerics.Vector4); }
    public static System.Numerics.Vector4 operator /(System.Numerics.Vector4 left, System.Numerics.Vector4 right) { return default(System.Numerics.Vector4); }
    public static System.Numerics.Vector4 operator /(System.Numerics.Vector4 value1, float value2) { return default(System.Numerics.Vector4); }
    public static bool operator ==(System.Numerics.Vector4 left, System.Numerics.Vector4 right) { return default(bool); }
    public static bool operator !=(System.Numerics.Vector4 left, System.Numerics.Vector4 right) { return default(bool); }
    public static System.Numerics.Vector4 operator *(System.Numerics.Vector4 left, System.Numerics.Vector4 right) { return default(System.Numerics.Vector4); }
    public static System.Numerics.Vector4 operator *(System.Numerics.Vector4 left, float right) { return default(System.Numerics.Vector4); }
    public static System.Numerics.Vector4 operator *(float left, System.Numerics.Vector4 right) { return default(System.Numerics.Vector4); }
    public static System.Numerics.Vector4 operator -(System.Numerics.Vector4 left, System.Numerics.Vector4 right) { return default(System.Numerics.Vector4); }
    public static System.Numerics.Vector4 operator -(System.Numerics.Vector4 value) { return default(System.Numerics.Vector4); }
    public static System.Numerics.Vector4 SquareRoot(System.Numerics.Vector4 value) { return default(System.Numerics.Vector4); }
    public static System.Numerics.Vector4 Subtract(System.Numerics.Vector4 left, System.Numerics.Vector4 right) { return default(System.Numerics.Vector4); }
    public override string ToString() { return default(string); }
    public string ToString(string format) { return default(string); }
    public string ToString(string format, System.IFormatProvider formatProvider) { return default(string); }
    public static System.Numerics.Vector4 Transform(System.Numerics.Vector2 position, System.Numerics.Matrix4x4 matrix) { return default(System.Numerics.Vector4); }
    public static System.Numerics.Vector4 Transform(System.Numerics.Vector2 value, System.Numerics.Quaternion rotation) { return default(System.Numerics.Vector4); }
    public static System.Numerics.Vector4 Transform(System.Numerics.Vector3 position, System.Numerics.Matrix4x4 matrix) { return default(System.Numerics.Vector4); }
    public static System.Numerics.Vector4 Transform(System.Numerics.Vector3 value, System.Numerics.Quaternion rotation) { return default(System.Numerics.Vector4); }
    public static System.Numerics.Vector4 Transform(System.Numerics.Vector4 vector, System.Numerics.Matrix4x4 matrix) { return default(System.Numerics.Vector4); }
    public static System.Numerics.Vector4 Transform(System.Numerics.Vector4 value, System.Numerics.Quaternion rotation) { return default(System.Numerics.Vector4); }
  }

  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct BigInteger : System.IComparable, System.IComparable<System.Numerics.BigInteger>, System.IEquatable<System.Numerics.BigInteger>, System.IFormattable {
    [System.CLSCompliantAttribute(false)]
    public BigInteger(byte[] value) { throw new System.NotImplementedException(); }
    public BigInteger(decimal value) { throw new System.NotImplementedException(); }
    public BigInteger(double value) { throw new System.NotImplementedException(); }
    public BigInteger(int value) { throw new System.NotImplementedException(); }
    public BigInteger(long value) { throw new System.NotImplementedException(); }
    public BigInteger(float value) { throw new System.NotImplementedException(); }
    [System.CLSCompliantAttribute(false)]
    public BigInteger(uint value) { throw new System.NotImplementedException(); }
    [System.CLSCompliantAttribute(false)]
    public BigInteger(ulong value) { throw new System.NotImplementedException(); }
    public bool IsEven { get { return default(bool); } }
    public bool IsOne { get { return default(bool); } }
    public bool IsPowerOfTwo { get { return default(bool); } }
    public bool IsZero { get { return default(bool); } }
    public static System.Numerics.BigInteger MinusOne { get { return default(System.Numerics.BigInteger); } }
    public static System.Numerics.BigInteger One { get { return default(System.Numerics.BigInteger); } }
    public int Sign { get { return default(int); } }
    public static System.Numerics.BigInteger Zero { get { return default(System.Numerics.BigInteger); } }
    public static System.Numerics.BigInteger Abs(System.Numerics.BigInteger value) { return default(System.Numerics.BigInteger); }
    public static System.Numerics.BigInteger Add(System.Numerics.BigInteger left, System.Numerics.BigInteger right) { return default(System.Numerics.BigInteger); }
    public static int Compare(System.Numerics.BigInteger left, System.Numerics.BigInteger right) { return default(int); }
    public int CompareTo(long other) { return default(int); }
    public int CompareTo(System.Numerics.BigInteger other) { return default(int); }
    [System.CLSCompliantAttribute(false)]
    public int CompareTo(ulong other) { return default(int); }
    public static System.Numerics.BigInteger Divide(System.Numerics.BigInteger dividend, System.Numerics.BigInteger divisor) { return default(System.Numerics.BigInteger); }
    public static System.Numerics.BigInteger DivRem(System.Numerics.BigInteger dividend, System.Numerics.BigInteger divisor, out System.Numerics.BigInteger remainder) { remainder = default(System.Numerics.BigInteger); return default(System.Numerics.BigInteger); }
    public bool Equals(long other) { return default(bool); }
    public bool Equals(System.Numerics.BigInteger other) { return default(bool); }
    public override bool Equals(object obj) { return default(bool); }
    [System.CLSCompliantAttribute(false)]
    public bool Equals(ulong other) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static System.Numerics.BigInteger GreatestCommonDivisor(System.Numerics.BigInteger left, System.Numerics.BigInteger right) { return default(System.Numerics.BigInteger); }
    public static double Log(System.Numerics.BigInteger value) { return default(double); }
    public static double Log(System.Numerics.BigInteger value, double baseValue) { return default(double); }
    public static double Log10(System.Numerics.BigInteger value) { return default(double); }
    public static System.Numerics.BigInteger Max(System.Numerics.BigInteger left, System.Numerics.BigInteger right) { return default(System.Numerics.BigInteger); }
    public static System.Numerics.BigInteger Min(System.Numerics.BigInteger left, System.Numerics.BigInteger right) { return default(System.Numerics.BigInteger); }
    public static System.Numerics.BigInteger ModPow(System.Numerics.BigInteger value, System.Numerics.BigInteger exponent, System.Numerics.BigInteger modulus) { return default(System.Numerics.BigInteger); }
    public static System.Numerics.BigInteger Multiply(System.Numerics.BigInteger left, System.Numerics.BigInteger right) { return default(System.Numerics.BigInteger); }
    public static System.Numerics.BigInteger Negate(System.Numerics.BigInteger value) { return default(System.Numerics.BigInteger); }
    public static System.Numerics.BigInteger operator +(System.Numerics.BigInteger left, System.Numerics.BigInteger right) { return default(System.Numerics.BigInteger); }
    public static System.Numerics.BigInteger operator &(System.Numerics.BigInteger left, System.Numerics.BigInteger right) { return default(System.Numerics.BigInteger); }
    public static System.Numerics.BigInteger operator |(System.Numerics.BigInteger left, System.Numerics.BigInteger right) { return default(System.Numerics.BigInteger); }
    public static System.Numerics.BigInteger operator --(System.Numerics.BigInteger value) { return default(System.Numerics.BigInteger); }
    public static System.Numerics.BigInteger operator /(System.Numerics.BigInteger dividend, System.Numerics.BigInteger divisor) { return default(System.Numerics.BigInteger); }
    public static bool operator ==(long left, System.Numerics.BigInteger right) { return default(bool); }
    public static bool operator ==(System.Numerics.BigInteger left, long right) { return default(bool); }
    public static bool operator ==(System.Numerics.BigInteger left, System.Numerics.BigInteger right) { return default(bool); }
    [System.CLSCompliantAttribute(false)]
    public static bool operator ==(System.Numerics.BigInteger left, ulong right) { return default(bool); }
    [System.CLSCompliantAttribute(false)]
    public static bool operator ==(ulong left, System.Numerics.BigInteger right) { return default(bool); }
    public static System.Numerics.BigInteger operator ^(System.Numerics.BigInteger left, System.Numerics.BigInteger right) { return default(System.Numerics.BigInteger); }
    public static explicit operator System.Numerics.BigInteger (decimal value) { return default(System.Numerics.BigInteger); }
    public static explicit operator System.Numerics.BigInteger (double value) { return default(System.Numerics.BigInteger); }
    public static explicit operator byte (System.Numerics.BigInteger value) { return default(byte); }
    public static explicit operator decimal (System.Numerics.BigInteger value) { return default(decimal); }
    public static explicit operator double (System.Numerics.BigInteger value) { return default(double); }
    public static explicit operator short (System.Numerics.BigInteger value) { return default(short); }
    public static explicit operator int (System.Numerics.BigInteger value) { return default(int); }
    public static explicit operator long (System.Numerics.BigInteger value) { return default(long); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator sbyte (System.Numerics.BigInteger value) { return default(sbyte); }
    public static explicit operator float (System.Numerics.BigInteger value) { return default(float); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator ushort (System.Numerics.BigInteger value) { return default(ushort); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator uint (System.Numerics.BigInteger value) { return default(uint); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator ulong (System.Numerics.BigInteger value) { return default(ulong); }
    public static explicit operator System.Numerics.BigInteger (float value) { return default(System.Numerics.BigInteger); }
    public static bool operator >(long left, System.Numerics.BigInteger right) { return default(bool); }
    public static bool operator >(System.Numerics.BigInteger left, long right) { return default(bool); }
    public static bool operator >(System.Numerics.BigInteger left, System.Numerics.BigInteger right) { return default(bool); }
    [System.CLSCompliantAttribute(false)]
    public static bool operator >(System.Numerics.BigInteger left, ulong right) { return default(bool); }
    [System.CLSCompliantAttribute(false)]
    public static bool operator >(ulong left, System.Numerics.BigInteger right) { return default(bool); }
    public static bool operator >=(long left, System.Numerics.BigInteger right) { return default(bool); }
    public static bool operator >=(System.Numerics.BigInteger left, long right) { return default(bool); }
    public static bool operator >=(System.Numerics.BigInteger left, System.Numerics.BigInteger right) { return default(bool); }
    [System.CLSCompliantAttribute(false)]
    public static bool operator >=(System.Numerics.BigInteger left, ulong right) { return default(bool); }
    [System.CLSCompliantAttribute(false)]
    public static bool operator >=(ulong left, System.Numerics.BigInteger right) { return default(bool); }
    public static implicit operator System.Numerics.BigInteger (byte value) { return default(System.Numerics.BigInteger); }
    public static implicit operator System.Numerics.BigInteger (short value) { return default(System.Numerics.BigInteger); }
    public static implicit operator System.Numerics.BigInteger (int value) { return default(System.Numerics.BigInteger); }
    public static implicit operator System.Numerics.BigInteger (long value) { return default(System.Numerics.BigInteger); }
    [System.CLSCompliantAttribute(false)]
    public static implicit operator System.Numerics.BigInteger (sbyte value) { return default(System.Numerics.BigInteger); }
    [System.CLSCompliantAttribute(false)]
    public static implicit operator System.Numerics.BigInteger (ushort value) { return default(System.Numerics.BigInteger); }
    [System.CLSCompliantAttribute(false)]
    public static implicit operator System.Numerics.BigInteger (uint value) { return default(System.Numerics.BigInteger); }
    [System.CLSCompliantAttribute(false)]
    public static implicit operator System.Numerics.BigInteger (ulong value) { return default(System.Numerics.BigInteger); }
    public static System.Numerics.BigInteger operator ++(System.Numerics.BigInteger value) { return default(System.Numerics.BigInteger); }
    public static bool operator !=(long left, System.Numerics.BigInteger right) { return default(bool); }
    public static bool operator !=(System.Numerics.BigInteger left, long right) { return default(bool); }
    public static bool operator !=(System.Numerics.BigInteger left, System.Numerics.BigInteger right) { return default(bool); }
    [System.CLSCompliantAttribute(false)]
    public static bool operator !=(System.Numerics.BigInteger left, ulong right) { return default(bool); }
    [System.CLSCompliantAttribute(false)]
    public static bool operator !=(ulong left, System.Numerics.BigInteger right) { return default(bool); }
    public static System.Numerics.BigInteger operator <<(System.Numerics.BigInteger value, int shift) { return default(System.Numerics.BigInteger); }
    public static bool operator <(long left, System.Numerics.BigInteger right) { return default(bool); }
    public static bool operator <(System.Numerics.BigInteger left, long right) { return default(bool); }
    public static bool operator <(System.Numerics.BigInteger left, System.Numerics.BigInteger right) { return default(bool); }
    [System.CLSCompliantAttribute(false)]
    public static bool operator <(System.Numerics.BigInteger left, ulong right) { return default(bool); }
    [System.CLSCompliantAttribute(false)]
    public static bool operator <(ulong left, System.Numerics.BigInteger right) { return default(bool); }
    public static bool operator <=(long left, System.Numerics.BigInteger right) { return default(bool); }
    public static bool operator <=(System.Numerics.BigInteger left, long right) { return default(bool); }
    public static bool operator <=(System.Numerics.BigInteger left, System.Numerics.BigInteger right) { return default(bool); }
    [System.CLSCompliantAttribute(false)]
    public static bool operator <=(System.Numerics.BigInteger left, ulong right) { return default(bool); }
    [System.CLSCompliantAttribute(false)]
    public static bool operator <=(ulong left, System.Numerics.BigInteger right) { return default(bool); }
    public static System.Numerics.BigInteger operator %(System.Numerics.BigInteger dividend, System.Numerics.BigInteger divisor) { return default(System.Numerics.BigInteger); }
    public static System.Numerics.BigInteger operator *(System.Numerics.BigInteger left, System.Numerics.BigInteger right) { return default(System.Numerics.BigInteger); }
    public static System.Numerics.BigInteger operator ~(System.Numerics.BigInteger value) { return default(System.Numerics.BigInteger); }
    public static System.Numerics.BigInteger operator >>(System.Numerics.BigInteger value, int shift) { return default(System.Numerics.BigInteger); }
    public static System.Numerics.BigInteger operator -(System.Numerics.BigInteger left, System.Numerics.BigInteger right) { return default(System.Numerics.BigInteger); }
    public static System.Numerics.BigInteger operator -(System.Numerics.BigInteger value) { return default(System.Numerics.BigInteger); }
    public static System.Numerics.BigInteger operator +(System.Numerics.BigInteger value) { return default(System.Numerics.BigInteger); }
    public static System.Numerics.BigInteger Parse(string value) { return default(System.Numerics.BigInteger); }
    public static System.Numerics.BigInteger Parse(string value, System.Globalization.NumberStyles style) { return default(System.Numerics.BigInteger); }
    public static System.Numerics.BigInteger Parse(string value, System.Globalization.NumberStyles style, System.IFormatProvider provider) { return default(System.Numerics.BigInteger); }
    public static System.Numerics.BigInteger Parse(string value, System.IFormatProvider provider) { return default(System.Numerics.BigInteger); }
    public static System.Numerics.BigInteger Pow(System.Numerics.BigInteger value, int exponent) { return default(System.Numerics.BigInteger); }
    public static System.Numerics.BigInteger Remainder(System.Numerics.BigInteger dividend, System.Numerics.BigInteger divisor) { return default(System.Numerics.BigInteger); }
    public static System.Numerics.BigInteger Subtract(System.Numerics.BigInteger left, System.Numerics.BigInteger right) { return default(System.Numerics.BigInteger); }
    int System.IComparable.CompareTo(object obj) { return default(int); }
    public byte[] ToByteArray() { return default(byte[]); }
    public override string ToString() { return default(string); }
    public string ToString(System.IFormatProvider provider) { return default(string); }
    public string ToString(string format) { return default(string); }
    public string ToString(string format, System.IFormatProvider provider) { return default(string); }
    public static bool TryParse(string value, System.Globalization.NumberStyles style, System.IFormatProvider provider, out System.Numerics.BigInteger result) { result = default(System.Numerics.BigInteger); return default(bool); }
    public static bool TryParse(string value, out System.Numerics.BigInteger result) { result = default(System.Numerics.BigInteger); return default(bool); }
  }

  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct Complex : System.IEquatable<System.Numerics.Complex>, System.IFormattable {
    public static readonly System.Numerics.Complex ImaginaryOne;
    public static readonly System.Numerics.Complex One;
    public static readonly System.Numerics.Complex Zero;
    public Complex(double real, double imaginary) { throw new System.NotImplementedException(); }
    public double Imaginary { get { return default(double); } }
    public double Magnitude { get { return default(double); } }
    public double Phase { get { return default(double); } }
    public double Real { get { return default(double); } }
    public static double Abs(System.Numerics.Complex value) { return default(double); }
    public static System.Numerics.Complex Acos(System.Numerics.Complex value) { return default(System.Numerics.Complex); }
    public static System.Numerics.Complex Add(System.Numerics.Complex left, System.Numerics.Complex right) { return default(System.Numerics.Complex); }
    public static System.Numerics.Complex Asin(System.Numerics.Complex value) { return default(System.Numerics.Complex); }
    public static System.Numerics.Complex Atan(System.Numerics.Complex value) { return default(System.Numerics.Complex); }
    public static System.Numerics.Complex Conjugate(System.Numerics.Complex value) { return default(System.Numerics.Complex); }
    public static System.Numerics.Complex Cos(System.Numerics.Complex value) { return default(System.Numerics.Complex); }
    public static System.Numerics.Complex Cosh(System.Numerics.Complex value) { return default(System.Numerics.Complex); }
    public static System.Numerics.Complex Divide(System.Numerics.Complex dividend, System.Numerics.Complex divisor) { return default(System.Numerics.Complex); }
    public bool Equals(System.Numerics.Complex value) { return default(bool); }
    public override bool Equals(object obj) { return default(bool); }
    public static System.Numerics.Complex Exp(System.Numerics.Complex value) { return default(System.Numerics.Complex); }
    public static System.Numerics.Complex FromPolarCoordinates(double magnitude, double phase) { return default(System.Numerics.Complex); }
    public override int GetHashCode() { return default(int); }
    public static System.Numerics.Complex Log(System.Numerics.Complex value) { return default(System.Numerics.Complex); }
    public static System.Numerics.Complex Log(System.Numerics.Complex value, double baseValue) { return default(System.Numerics.Complex); }
    public static System.Numerics.Complex Log10(System.Numerics.Complex value) { return default(System.Numerics.Complex); }
    public static System.Numerics.Complex Multiply(System.Numerics.Complex left, System.Numerics.Complex right) { return default(System.Numerics.Complex); }
    public static System.Numerics.Complex Negate(System.Numerics.Complex value) { return default(System.Numerics.Complex); }
    public static System.Numerics.Complex operator +(System.Numerics.Complex left, System.Numerics.Complex right) { return default(System.Numerics.Complex); }
    public static System.Numerics.Complex operator /(System.Numerics.Complex left, System.Numerics.Complex right) { return default(System.Numerics.Complex); }
    public static bool operator ==(System.Numerics.Complex left, System.Numerics.Complex right) { return default(bool); }
    public static explicit operator System.Numerics.Complex (decimal value) { return default(System.Numerics.Complex); }
    public static explicit operator System.Numerics.Complex (System.Numerics.BigInteger value) { return default(System.Numerics.Complex); }
    public static implicit operator System.Numerics.Complex (byte value) { return default(System.Numerics.Complex); }
    public static implicit operator System.Numerics.Complex (double value) { return default(System.Numerics.Complex); }
    public static implicit operator System.Numerics.Complex (short value) { return default(System.Numerics.Complex); }
    public static implicit operator System.Numerics.Complex (int value) { return default(System.Numerics.Complex); }
    public static implicit operator System.Numerics.Complex (long value) { return default(System.Numerics.Complex); }
    [System.CLSCompliantAttribute(false)]
    public static implicit operator System.Numerics.Complex (sbyte value) { return default(System.Numerics.Complex); }
    public static implicit operator System.Numerics.Complex (float value) { return default(System.Numerics.Complex); }
    [System.CLSCompliantAttribute(false)]
    public static implicit operator System.Numerics.Complex (ushort value) { return default(System.Numerics.Complex); }
    [System.CLSCompliantAttribute(false)]
    public static implicit operator System.Numerics.Complex (uint value) { return default(System.Numerics.Complex); }
    [System.CLSCompliantAttribute(false)]
    public static implicit operator System.Numerics.Complex (ulong value) { return default(System.Numerics.Complex); }
    public static bool operator !=(System.Numerics.Complex left, System.Numerics.Complex right) { return default(bool); }
    public static System.Numerics.Complex operator *(System.Numerics.Complex left, System.Numerics.Complex right) { return default(System.Numerics.Complex); }
    public static System.Numerics.Complex operator -(System.Numerics.Complex left, System.Numerics.Complex right) { return default(System.Numerics.Complex); }
    public static System.Numerics.Complex operator -(System.Numerics.Complex value) { return default(System.Numerics.Complex); }
    public static System.Numerics.Complex Pow(System.Numerics.Complex value, double power) { return default(System.Numerics.Complex); }
    public static System.Numerics.Complex Pow(System.Numerics.Complex value, System.Numerics.Complex power) { return default(System.Numerics.Complex); }
    public static System.Numerics.Complex Reciprocal(System.Numerics.Complex value) { return default(System.Numerics.Complex); }
    public static System.Numerics.Complex Sin(System.Numerics.Complex value) { return default(System.Numerics.Complex); }
    public static System.Numerics.Complex Sinh(System.Numerics.Complex value) { return default(System.Numerics.Complex); }
    public static System.Numerics.Complex Sqrt(System.Numerics.Complex value) { return default(System.Numerics.Complex); }
    public static System.Numerics.Complex Subtract(System.Numerics.Complex left, System.Numerics.Complex right) { return default(System.Numerics.Complex); }
    public static System.Numerics.Complex Tan(System.Numerics.Complex value) { return default(System.Numerics.Complex); }
    public static System.Numerics.Complex Tanh(System.Numerics.Complex value) { return default(System.Numerics.Complex); }
    public override string ToString() { return default(string); }
    public string ToString(System.IFormatProvider provider) { return default(string); }
    public string ToString(string format) { return default(string); }
    public string ToString(string format, System.IFormatProvider provider) { return default(string); }
  }

} // end of System.Numerics
namespace System.Reflection {
  public abstract partial class DispatchProxy {
    protected DispatchProxy() { }
    public static T Create<T, TProxy>() where TProxy : System.Reflection.DispatchProxy { return default(T); }
    protected abstract object Invoke(System.Reflection.MethodInfo targetMethod, object[] args);
  }

  public static partial class AssemblyExtensions {
    public static System.Type[] GetExportedTypes(this System.Reflection.Assembly assembly) { return default(System.Type[]); }
    public static System.Reflection.Module[] GetModules(this System.Reflection.Assembly assembly) { return default(System.Reflection.Module[]); }
    public static System.Type[] GetTypes(this System.Reflection.Assembly assembly) { return default(System.Type[]); }
  }

  public static partial class EventInfoExtensions {
    public static System.Reflection.MethodInfo GetAddMethod(this System.Reflection.EventInfo eventInfo) { return default(System.Reflection.MethodInfo); }
    public static System.Reflection.MethodInfo GetAddMethod(this System.Reflection.EventInfo eventInfo, bool nonPublic) { return default(System.Reflection.MethodInfo); }
    public static System.Reflection.MethodInfo GetRaiseMethod(this System.Reflection.EventInfo eventInfo) { return default(System.Reflection.MethodInfo); }
    public static System.Reflection.MethodInfo GetRaiseMethod(this System.Reflection.EventInfo eventInfo, bool nonPublic) { return default(System.Reflection.MethodInfo); }
    public static System.Reflection.MethodInfo GetRemoveMethod(this System.Reflection.EventInfo eventInfo) { return default(System.Reflection.MethodInfo); }
    public static System.Reflection.MethodInfo GetRemoveMethod(this System.Reflection.EventInfo eventInfo, bool nonPublic) { return default(System.Reflection.MethodInfo); }
  }

  public static partial class MemberInfoExtensions {
    public static int GetMetadataToken(this System.Reflection.MemberInfo member) { return default(int); }
    public static bool HasMetadataToken(this System.Reflection.MemberInfo member) { return default(bool); }
  }

  public static partial class MethodInfoExtensions {
    public static System.Reflection.MethodInfo GetBaseDefinition(this System.Reflection.MethodInfo method) { return default(System.Reflection.MethodInfo); }
  }

  public static partial class ModuleExtensions {
    public static System.Guid GetModuleVersionId(this System.Reflection.Module module) { return default(System.Guid); }
    public static bool HasModuleVersionId(this System.Reflection.Module module) { return default(bool); }
  }

  public static partial class PropertyInfoExtensions {
    public static System.Reflection.MethodInfo[] GetAccessors(this System.Reflection.PropertyInfo property) { return default(System.Reflection.MethodInfo[]); }
    public static System.Reflection.MethodInfo[] GetAccessors(this System.Reflection.PropertyInfo property, bool nonPublic) { return default(System.Reflection.MethodInfo[]); }
    public static System.Reflection.MethodInfo GetGetMethod(this System.Reflection.PropertyInfo property) { return default(System.Reflection.MethodInfo); }
    public static System.Reflection.MethodInfo GetGetMethod(this System.Reflection.PropertyInfo property, bool nonPublic) { return default(System.Reflection.MethodInfo); }
    public static System.Reflection.MethodInfo GetSetMethod(this System.Reflection.PropertyInfo property) { return default(System.Reflection.MethodInfo); }
    public static System.Reflection.MethodInfo GetSetMethod(this System.Reflection.PropertyInfo property, bool nonPublic) { return default(System.Reflection.MethodInfo); }
  }

  public static partial class TypeExtensions {
    public static System.Reflection.ConstructorInfo GetConstructor(this System.Type type, System.Type[] types) { return default(System.Reflection.ConstructorInfo); }
    public static System.Reflection.ConstructorInfo[] GetConstructors(this System.Type type) { return default(System.Reflection.ConstructorInfo[]); }
    public static System.Reflection.ConstructorInfo[] GetConstructors(this System.Type type, System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.ConstructorInfo[]); }
    public static System.Reflection.MemberInfo[] GetDefaultMembers(this System.Type type) { return default(System.Reflection.MemberInfo[]); }
    public static System.Reflection.EventInfo GetEvent(this System.Type type, string name) { return default(System.Reflection.EventInfo); }
    public static System.Reflection.EventInfo GetEvent(this System.Type type, string name, System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.EventInfo); }
    public static System.Reflection.EventInfo[] GetEvents(this System.Type type) { return default(System.Reflection.EventInfo[]); }
    public static System.Reflection.EventInfo[] GetEvents(this System.Type type, System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.EventInfo[]); }
    public static System.Reflection.FieldInfo GetField(this System.Type type, string name) { return default(System.Reflection.FieldInfo); }
    public static System.Reflection.FieldInfo GetField(this System.Type type, string name, System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.FieldInfo); }
    public static System.Reflection.FieldInfo[] GetFields(this System.Type type) { return default(System.Reflection.FieldInfo[]); }
    public static System.Reflection.FieldInfo[] GetFields(this System.Type type, System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.FieldInfo[]); }
    public static System.Type[] GetGenericArguments(this System.Type type) { return default(System.Type[]); }
    public static System.Type[] GetInterfaces(this System.Type type) { return default(System.Type[]); }
    public static System.Reflection.MemberInfo[] GetMember(this System.Type type, string name) { return default(System.Reflection.MemberInfo[]); }
    public static System.Reflection.MemberInfo[] GetMember(this System.Type type, string name, System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.MemberInfo[]); }
    public static System.Reflection.MemberInfo[] GetMembers(this System.Type type) { return default(System.Reflection.MemberInfo[]); }
    public static System.Reflection.MemberInfo[] GetMembers(this System.Type type, System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.MemberInfo[]); }
    public static System.Reflection.MethodInfo GetMethod(this System.Type type, string name) { return default(System.Reflection.MethodInfo); }
    public static System.Reflection.MethodInfo GetMethod(this System.Type type, string name, System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.MethodInfo); }
    public static System.Reflection.MethodInfo GetMethod(this System.Type type, string name, System.Type[] types) { return default(System.Reflection.MethodInfo); }
    public static System.Reflection.MethodInfo[] GetMethods(this System.Type type) { return default(System.Reflection.MethodInfo[]); }
    public static System.Reflection.MethodInfo[] GetMethods(this System.Type type, System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.MethodInfo[]); }
    public static System.Type GetNestedType(this System.Type type, string name, System.Reflection.BindingFlags bindingAttr) { return default(System.Type); }
    public static System.Type[] GetNestedTypes(this System.Type type, System.Reflection.BindingFlags bindingAttr) { return default(System.Type[]); }
    public static System.Reflection.PropertyInfo[] GetProperties(this System.Type type) { return default(System.Reflection.PropertyInfo[]); }
    public static System.Reflection.PropertyInfo[] GetProperties(this System.Type type, System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.PropertyInfo[]); }
    public static System.Reflection.PropertyInfo GetProperty(this System.Type type, string name) { return default(System.Reflection.PropertyInfo); }
    public static System.Reflection.PropertyInfo GetProperty(this System.Type type, string name, System.Reflection.BindingFlags bindingAttr) { return default(System.Reflection.PropertyInfo); }
    public static System.Reflection.PropertyInfo GetProperty(this System.Type type, string name, System.Type returnType) { return default(System.Reflection.PropertyInfo); }
    public static System.Reflection.PropertyInfo GetProperty(this System.Type type, string name, System.Type returnType, System.Type[] types) { return default(System.Reflection.PropertyInfo); }
    public static bool IsAssignableFrom(this System.Type type, System.Type c) { return default(bool); }
    public static bool IsInstanceOfType(this System.Type type, object o) { return default(bool); }
  }

} // end of System.Reflection
namespace System.Reflection.Emit {
  public sealed partial class AssemblyBuilder : System.Reflection.Assembly {
    internal AssemblyBuilder() { }
    public override System.Collections.Generic.IEnumerable<System.Reflection.TypeInfo> DefinedTypes { get { return default(System.Collections.Generic.IEnumerable<System.Reflection.TypeInfo>); } }
    public override string FullName { get { return default(string); } }
    public override bool IsDynamic { get { return default(bool); } }
    public override System.Reflection.Module ManifestModule { get { return default(System.Reflection.Module); } }
    public override System.Collections.Generic.IEnumerable<System.Reflection.Module> Modules { get { return default(System.Collections.Generic.IEnumerable<System.Reflection.Module>); } }
    public static System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access) { return default(System.Reflection.Emit.AssemblyBuilder); }
    public static System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access, System.Collections.Generic.IEnumerable<System.Reflection.Emit.CustomAttributeBuilder> assemblyAttributes) { return default(System.Reflection.Emit.AssemblyBuilder); }
    public System.Reflection.Emit.ModuleBuilder DefineDynamicModule(string name) { return default(System.Reflection.Emit.ModuleBuilder); }
    public override bool Equals(object obj) { return default(bool); }
    public System.Reflection.Emit.ModuleBuilder GetDynamicModule(string name) { return default(System.Reflection.Emit.ModuleBuilder); }
    public override int GetHashCode() { return default(int); }
    public override System.Reflection.ManifestResourceInfo GetManifestResourceInfo(string resourceName) { return default(System.Reflection.ManifestResourceInfo); }
    public override string[] GetManifestResourceNames() { return default(string[]); }
    public override System.IO.Stream GetManifestResourceStream(string name) { return default(System.IO.Stream); }
    public void SetCustomAttribute(System.Reflection.ConstructorInfo con, byte[] binaryAttribute) { }
    public void SetCustomAttribute(System.Reflection.Emit.CustomAttributeBuilder customBuilder) { }
  }

  [System.FlagsAttribute]
  public enum AssemblyBuilderAccess {
    Run = 1,
    RunAndCollect = 9,
  }

  public sealed partial class ConstructorBuilder : System.Reflection.ConstructorInfo {
    internal ConstructorBuilder() { }
    public override System.Reflection.MethodAttributes Attributes { get { return default(System.Reflection.MethodAttributes); } }
    public override System.Reflection.CallingConventions CallingConvention { get { return default(System.Reflection.CallingConventions); } }
    public override System.Type DeclaringType { get { return default(System.Type); } }
    public bool InitLocals { get { return default(bool); } set { } }
    public override System.Reflection.MethodImplAttributes MethodImplementationFlags { get { return default(System.Reflection.MethodImplAttributes); } }
    public override string Name { get { return default(string); } }
    public System.Reflection.Emit.ParameterBuilder DefineParameter(int iSequence, System.Reflection.ParameterAttributes attributes, string strParamName) { return default(System.Reflection.Emit.ParameterBuilder); }
    public System.Reflection.Emit.ILGenerator GetILGenerator() { return default(System.Reflection.Emit.ILGenerator); }
    public System.Reflection.Emit.ILGenerator GetILGenerator(int streamSize) { return default(System.Reflection.Emit.ILGenerator); }
    public override System.Reflection.ParameterInfo[] GetParameters() { return default(System.Reflection.ParameterInfo[]); }
    public void SetCustomAttribute(System.Reflection.ConstructorInfo con, byte[] binaryAttribute) { }
    public void SetCustomAttribute(System.Reflection.Emit.CustomAttributeBuilder customBuilder) { }
    public void SetImplementationFlags(System.Reflection.MethodImplAttributes attributes) { }
    public override string ToString() { return default(string); }
  }

  public sealed partial class EnumBuilder : System.Reflection.TypeInfo {
    internal EnumBuilder() { }
    public override System.Reflection.Assembly Assembly { get { return default(System.Reflection.Assembly); } }
    public override string AssemblyQualifiedName { get { return default(string); } }
    public override System.Reflection.TypeAttributes Attributes { get { return default(System.Reflection.TypeAttributes); } }
    public override System.Type BaseType { get { return default(System.Type); } }
    public override bool ContainsGenericParameters { get { return default(bool); } }
    public override System.Reflection.MethodBase DeclaringMethod { get { return default(System.Reflection.MethodBase); } }
    public override System.Type DeclaringType { get { return default(System.Type); } }
    public override string FullName { get { return default(string); } }
    public override System.Reflection.GenericParameterAttributes GenericParameterAttributes { get { return default(System.Reflection.GenericParameterAttributes); } }
    public override int GenericParameterPosition { get { return default(int); } }
    public override System.Type[] GenericTypeArguments { get { return default(System.Type[]); } }
    public override System.Guid GUID { get { return default(System.Guid); } }
    public override bool IsEnum { get { return default(bool); } }
    public override bool IsGenericParameter { get { return default(bool); } }
    public override bool IsGenericType { get { return default(bool); } }
    public override bool IsGenericTypeDefinition { get { return default(bool); } }
    public override bool IsSerializable { get { return default(bool); } }
    public override System.Reflection.Module Module { get { return default(System.Reflection.Module); } }
    public override string Name { get { return default(string); } }
    public override string Namespace { get { return default(string); } }
    public System.Reflection.Emit.FieldBuilder UnderlyingField { get { return default(System.Reflection.Emit.FieldBuilder); } }
    public System.Reflection.TypeInfo CreateTypeInfo() { return default(System.Reflection.TypeInfo); }
    public System.Reflection.Emit.FieldBuilder DefineLiteral(string literalName, object literalValue) { return default(System.Reflection.Emit.FieldBuilder); }
    public override int GetArrayRank() { return default(int); }
    public override System.Type GetElementType() { return default(System.Type); }
    public override System.Type[] GetGenericParameterConstraints() { return default(System.Type[]); }
    public override System.Type GetGenericTypeDefinition() { return default(System.Type); }
    public override bool IsAssignableFrom(System.Reflection.TypeInfo typeInfo) { return default(bool); }
    public override System.Type MakeArrayType() { return default(System.Type); }
    public override System.Type MakeArrayType(int rank) { return default(System.Type); }
    public override System.Type MakeByRefType() { return default(System.Type); }
    public override System.Type MakeGenericType(params System.Type[] typeArguments) { return default(System.Type); }
    public override System.Type MakePointerType() { return default(System.Type); }
    public void SetCustomAttribute(System.Reflection.ConstructorInfo con, byte[] binaryAttribute) { }
    public void SetCustomAttribute(System.Reflection.Emit.CustomAttributeBuilder customBuilder) { }
  }

  public sealed partial class EventBuilder {
    internal EventBuilder() { }
    public void AddOtherMethod(System.Reflection.Emit.MethodBuilder mdBuilder) { }
    public void SetAddOnMethod(System.Reflection.Emit.MethodBuilder mdBuilder) { }
    public void SetCustomAttribute(System.Reflection.ConstructorInfo con, byte[] binaryAttribute) { }
    public void SetCustomAttribute(System.Reflection.Emit.CustomAttributeBuilder customBuilder) { }
    public void SetRaiseMethod(System.Reflection.Emit.MethodBuilder mdBuilder) { }
    public void SetRemoveOnMethod(System.Reflection.Emit.MethodBuilder mdBuilder) { }
  }

  public sealed partial class FieldBuilder : System.Reflection.FieldInfo {
    internal FieldBuilder() { }
    public override System.Reflection.FieldAttributes Attributes { get { return default(System.Reflection.FieldAttributes); } }
    public override System.Type DeclaringType { get { return default(System.Type); } }
    public override System.Type FieldType { get { return default(System.Type); } }
    public override string Name { get { return default(string); } }
    public override object GetValue(object obj) { return default(object); }
    public void SetConstant(object defaultValue) { }
    public void SetCustomAttribute(System.Reflection.ConstructorInfo con, byte[] binaryAttribute) { }
    public void SetCustomAttribute(System.Reflection.Emit.CustomAttributeBuilder customBuilder) { }
    public void SetOffset(int iOffset) { }
  }

  public sealed partial class GenericTypeParameterBuilder : System.Reflection.TypeInfo {
    internal GenericTypeParameterBuilder() { }
    public override System.Reflection.Assembly Assembly { get { return default(System.Reflection.Assembly); } }
    public override string AssemblyQualifiedName { get { return default(string); } }
    public override System.Reflection.TypeAttributes Attributes { get { return default(System.Reflection.TypeAttributes); } }
    public override System.Type BaseType { get { return default(System.Type); } }
    public override bool ContainsGenericParameters { get { return default(bool); } }
    public override System.Reflection.MethodBase DeclaringMethod { get { return default(System.Reflection.MethodBase); } }
    public override System.Type DeclaringType { get { return default(System.Type); } }
    public override string FullName { get { return default(string); } }
    public override System.Reflection.GenericParameterAttributes GenericParameterAttributes { get { return default(System.Reflection.GenericParameterAttributes); } }
    public override int GenericParameterPosition { get { return default(int); } }
    public override System.Type[] GenericTypeArguments { get { return default(System.Type[]); } }
    public override System.Guid GUID { get { return default(System.Guid); } }
    public override bool IsEnum { get { return default(bool); } }
    public override bool IsGenericParameter { get { return default(bool); } }
    public override bool IsGenericType { get { return default(bool); } }
    public override bool IsGenericTypeDefinition { get { return default(bool); } }
    public override bool IsSerializable { get { return default(bool); } }
    public override System.Reflection.Module Module { get { return default(System.Reflection.Module); } }
    public override string Name { get { return default(string); } }
    public override string Namespace { get { return default(string); } }
    public override bool Equals(object o) { return default(bool); }
    public override int GetArrayRank() { return default(int); }
    public override System.Type GetElementType() { return default(System.Type); }
    public override System.Type[] GetGenericParameterConstraints() { return default(System.Type[]); }
    public override System.Type GetGenericTypeDefinition() { return default(System.Type); }
    public override int GetHashCode() { return default(int); }
    public override bool IsAssignableFrom(System.Reflection.TypeInfo typeInfo) { return default(bool); }
    public override bool IsSubclassOf(System.Type c) { return default(bool); }
    public override System.Type MakeArrayType() { return default(System.Type); }
    public override System.Type MakeArrayType(int rank) { return default(System.Type); }
    public override System.Type MakeByRefType() { return default(System.Type); }
    public override System.Type MakeGenericType(params System.Type[] typeArguments) { return default(System.Type); }
    public override System.Type MakePointerType() { return default(System.Type); }
    public void SetBaseTypeConstraint(System.Type baseTypeConstraint) { }
    public void SetCustomAttribute(System.Reflection.ConstructorInfo con, byte[] binaryAttribute) { }
    public void SetCustomAttribute(System.Reflection.Emit.CustomAttributeBuilder customBuilder) { }
    public void SetGenericParameterAttributes(System.Reflection.GenericParameterAttributes genericParameterAttributes) { }
    public void SetInterfaceConstraints(params System.Type[] interfaceConstraints) { }
    public override string ToString() { return default(string); }
  }

  public sealed partial class MethodBuilder : System.Reflection.MethodInfo {
    internal MethodBuilder() { }
    public override System.Reflection.MethodAttributes Attributes { get { return default(System.Reflection.MethodAttributes); } }
    public override System.Reflection.CallingConventions CallingConvention { get { return default(System.Reflection.CallingConventions); } }
    public override bool ContainsGenericParameters { get { return default(bool); } }
    public override System.Type DeclaringType { get { return default(System.Type); } }
    public bool InitLocals { get { return default(bool); } set { } }
    public override bool IsGenericMethod { get { return default(bool); } }
    public override bool IsGenericMethodDefinition { get { return default(bool); } }
    public override System.Reflection.MethodImplAttributes MethodImplementationFlags { get { return default(System.Reflection.MethodImplAttributes); } }
    public override string Name { get { return default(string); } }
    public override System.Reflection.ParameterInfo ReturnParameter { get { return default(System.Reflection.ParameterInfo); } }
    public override System.Type ReturnType { get { return default(System.Type); } }
    public System.Reflection.Emit.GenericTypeParameterBuilder[] DefineGenericParameters(params string[] names) { return default(System.Reflection.Emit.GenericTypeParameterBuilder[]); }
    public System.Reflection.Emit.ParameterBuilder DefineParameter(int position, System.Reflection.ParameterAttributes attributes, string strParamName) { return default(System.Reflection.Emit.ParameterBuilder); }
    public override bool Equals(object obj) { return default(bool); }
    public override System.Type[] GetGenericArguments() { return default(System.Type[]); }
    public override System.Reflection.MethodInfo GetGenericMethodDefinition() { return default(System.Reflection.MethodInfo); }
    public override int GetHashCode() { return default(int); }
    public System.Reflection.Emit.ILGenerator GetILGenerator() { return default(System.Reflection.Emit.ILGenerator); }
    public System.Reflection.Emit.ILGenerator GetILGenerator(int size) { return default(System.Reflection.Emit.ILGenerator); }
    public override System.Reflection.ParameterInfo[] GetParameters() { return default(System.Reflection.ParameterInfo[]); }
    public override System.Reflection.MethodInfo MakeGenericMethod(params System.Type[] typeArguments) { return default(System.Reflection.MethodInfo); }
    public void SetCustomAttribute(System.Reflection.ConstructorInfo con, byte[] binaryAttribute) { }
    public void SetCustomAttribute(System.Reflection.Emit.CustomAttributeBuilder customBuilder) { }
    public void SetImplementationFlags(System.Reflection.MethodImplAttributes attributes) { }
    public void SetParameters(params System.Type[] parameterTypes) { }
    public void SetReturnType(System.Type returnType) { }
    public void SetSignature(System.Type returnType, System.Type[] returnTypeRequiredCustomModifiers, System.Type[] returnTypeOptionalCustomModifiers, System.Type[] parameterTypes, System.Type[][] parameterTypeRequiredCustomModifiers, System.Type[][] parameterTypeOptionalCustomModifiers) { }
    public override string ToString() { return default(string); }
  }

  public partial class ModuleBuilder : System.Reflection.Module {
    internal ModuleBuilder() { }
    public override System.Reflection.Assembly Assembly { get { return default(System.Reflection.Assembly); } }
    public override string FullyQualifiedName { get { return default(string); } }
    public override string Name { get { return default(string); } }
    public void CreateGlobalFunctions() { }
    public System.Reflection.Emit.EnumBuilder DefineEnum(string name, System.Reflection.TypeAttributes visibility, System.Type underlyingType) { return default(System.Reflection.Emit.EnumBuilder); }
    public System.Reflection.Emit.MethodBuilder DefineGlobalMethod(string name, System.Reflection.MethodAttributes attributes, System.Reflection.CallingConventions callingConvention, System.Type returnType, System.Type[] parameterTypes) { return default(System.Reflection.Emit.MethodBuilder); }
    public System.Reflection.Emit.MethodBuilder DefineGlobalMethod(string name, System.Reflection.MethodAttributes attributes, System.Reflection.CallingConventions callingConvention, System.Type returnType, System.Type[] requiredReturnTypeCustomModifiers, System.Type[] optionalReturnTypeCustomModifiers, System.Type[] parameterTypes, System.Type[][] requiredParameterTypeCustomModifiers, System.Type[][] optionalParameterTypeCustomModifiers) { return default(System.Reflection.Emit.MethodBuilder); }
    public System.Reflection.Emit.MethodBuilder DefineGlobalMethod(string name, System.Reflection.MethodAttributes attributes, System.Type returnType, System.Type[] parameterTypes) { return default(System.Reflection.Emit.MethodBuilder); }
    public System.Reflection.Emit.FieldBuilder DefineInitializedData(string name, byte[] data, System.Reflection.FieldAttributes attributes) { return default(System.Reflection.Emit.FieldBuilder); }
    public System.Reflection.Emit.TypeBuilder DefineType(string name) { return default(System.Reflection.Emit.TypeBuilder); }
    public System.Reflection.Emit.TypeBuilder DefineType(string name, System.Reflection.TypeAttributes attr) { return default(System.Reflection.Emit.TypeBuilder); }
    public System.Reflection.Emit.TypeBuilder DefineType(string name, System.Reflection.TypeAttributes attr, System.Type parent) { return default(System.Reflection.Emit.TypeBuilder); }
    public System.Reflection.Emit.TypeBuilder DefineType(string name, System.Reflection.TypeAttributes attr, System.Type parent, int typesize) { return default(System.Reflection.Emit.TypeBuilder); }
    public System.Reflection.Emit.TypeBuilder DefineType(string name, System.Reflection.TypeAttributes attr, System.Type parent, System.Reflection.Emit.PackingSize packsize) { return default(System.Reflection.Emit.TypeBuilder); }
    public System.Reflection.Emit.TypeBuilder DefineType(string name, System.Reflection.TypeAttributes attr, System.Type parent, System.Reflection.Emit.PackingSize packingSize, int typesize) { return default(System.Reflection.Emit.TypeBuilder); }
    public System.Reflection.Emit.TypeBuilder DefineType(string name, System.Reflection.TypeAttributes attr, System.Type parent, System.Type[] interfaces) { return default(System.Reflection.Emit.TypeBuilder); }
    public System.Reflection.Emit.FieldBuilder DefineUninitializedData(string name, int size, System.Reflection.FieldAttributes attributes) { return default(System.Reflection.Emit.FieldBuilder); }
    public override bool Equals(object obj) { return default(bool); }
    public System.Reflection.MethodInfo GetArrayMethod(System.Type arrayClass, string methodName, System.Reflection.CallingConventions callingConvention, System.Type returnType, System.Type[] parameterTypes) { return default(System.Reflection.MethodInfo); }
    public override int GetHashCode() { return default(int); }
    public void SetCustomAttribute(System.Reflection.ConstructorInfo con, byte[] binaryAttribute) { }
    public void SetCustomAttribute(System.Reflection.Emit.CustomAttributeBuilder customBuilder) { }
  }

  public sealed partial class PropertyBuilder : System.Reflection.PropertyInfo {
    internal PropertyBuilder() { }
    public override System.Reflection.PropertyAttributes Attributes { get { return default(System.Reflection.PropertyAttributes); } }
    public override bool CanRead { get { return default(bool); } }
    public override bool CanWrite { get { return default(bool); } }
    public override System.Type DeclaringType { get { return default(System.Type); } }
    public override string Name { get { return default(string); } }
    public override System.Type PropertyType { get { return default(System.Type); } }
    public void AddOtherMethod(System.Reflection.Emit.MethodBuilder mdBuilder) { }
    public override System.Reflection.ParameterInfo[] GetIndexParameters() { return default(System.Reflection.ParameterInfo[]); }
    public override object GetValue(object obj, object[] index) { return default(object); }
    public void SetConstant(object defaultValue) { }
    public void SetCustomAttribute(System.Reflection.ConstructorInfo con, byte[] binaryAttribute) { }
    public void SetCustomAttribute(System.Reflection.Emit.CustomAttributeBuilder customBuilder) { }
    public void SetGetMethod(System.Reflection.Emit.MethodBuilder mdBuilder) { }
    public void SetSetMethod(System.Reflection.Emit.MethodBuilder mdBuilder) { }
    public override void SetValue(object obj, object value, object[] index) { }
  }

  public sealed partial class TypeBuilder : System.Reflection.TypeInfo {
    internal TypeBuilder() { }
    public const int UnspecifiedTypeSize = 0;
    public override System.Reflection.Assembly Assembly { get { return default(System.Reflection.Assembly); } }
    public override string AssemblyQualifiedName { get { return default(string); } }
    public override System.Reflection.TypeAttributes Attributes { get { return default(System.Reflection.TypeAttributes); } }
    public override System.Type BaseType { get { return default(System.Type); } }
    public override bool ContainsGenericParameters { get { return default(bool); } }
    public override System.Reflection.MethodBase DeclaringMethod { get { return default(System.Reflection.MethodBase); } }
    public override System.Type DeclaringType { get { return default(System.Type); } }
    public override string FullName { get { return default(string); } }
    public override System.Reflection.GenericParameterAttributes GenericParameterAttributes { get { return default(System.Reflection.GenericParameterAttributes); } }
    public override int GenericParameterPosition { get { return default(int); } }
    public override System.Type[] GenericTypeArguments { get { return default(System.Type[]); } }
    public override System.Guid GUID { get { return default(System.Guid); } }
    public override bool IsEnum { get { return default(bool); } }
    public override bool IsGenericParameter { get { return default(bool); } }
    public override bool IsGenericType { get { return default(bool); } }
    public override bool IsGenericTypeDefinition { get { return default(bool); } }
    public override bool IsSerializable { get { return default(bool); } }
    public override System.Reflection.Module Module { get { return default(System.Reflection.Module); } }
    public override string Name { get { return default(string); } }
    public override string Namespace { get { return default(string); } }
    public System.Reflection.Emit.PackingSize PackingSize { get { return default(System.Reflection.Emit.PackingSize); } }
    public int Size { get { return default(int); } }
    public void AddInterfaceImplementation(System.Type interfaceType) { }
    public System.Reflection.TypeInfo CreateTypeInfo() { return default(System.Reflection.TypeInfo); }
    public System.Reflection.Emit.ConstructorBuilder DefineConstructor(System.Reflection.MethodAttributes attributes, System.Reflection.CallingConventions callingConvention, System.Type[] parameterTypes) { return default(System.Reflection.Emit.ConstructorBuilder); }
    public System.Reflection.Emit.ConstructorBuilder DefineConstructor(System.Reflection.MethodAttributes attributes, System.Reflection.CallingConventions callingConvention, System.Type[] parameterTypes, System.Type[][] requiredCustomModifiers, System.Type[][] optionalCustomModifiers) { return default(System.Reflection.Emit.ConstructorBuilder); }
    public System.Reflection.Emit.ConstructorBuilder DefineDefaultConstructor(System.Reflection.MethodAttributes attributes) { return default(System.Reflection.Emit.ConstructorBuilder); }
    public System.Reflection.Emit.EventBuilder DefineEvent(string name, System.Reflection.EventAttributes attributes, System.Type eventtype) { return default(System.Reflection.Emit.EventBuilder); }
    public System.Reflection.Emit.FieldBuilder DefineField(string fieldName, System.Type type, System.Reflection.FieldAttributes attributes) { return default(System.Reflection.Emit.FieldBuilder); }
    public System.Reflection.Emit.FieldBuilder DefineField(string fieldName, System.Type type, System.Type[] requiredCustomModifiers, System.Type[] optionalCustomModifiers, System.Reflection.FieldAttributes attributes) { return default(System.Reflection.Emit.FieldBuilder); }
    public System.Reflection.Emit.GenericTypeParameterBuilder[] DefineGenericParameters(params string[] names) { return default(System.Reflection.Emit.GenericTypeParameterBuilder[]); }
    public System.Reflection.Emit.FieldBuilder DefineInitializedData(string name, byte[] data, System.Reflection.FieldAttributes attributes) { return default(System.Reflection.Emit.FieldBuilder); }
    public System.Reflection.Emit.MethodBuilder DefineMethod(string name, System.Reflection.MethodAttributes attributes) { return default(System.Reflection.Emit.MethodBuilder); }
    public System.Reflection.Emit.MethodBuilder DefineMethod(string name, System.Reflection.MethodAttributes attributes, System.Reflection.CallingConventions callingConvention) { return default(System.Reflection.Emit.MethodBuilder); }
    public System.Reflection.Emit.MethodBuilder DefineMethod(string name, System.Reflection.MethodAttributes attributes, System.Reflection.CallingConventions callingConvention, System.Type returnType, System.Type[] parameterTypes) { return default(System.Reflection.Emit.MethodBuilder); }
    public System.Reflection.Emit.MethodBuilder DefineMethod(string name, System.Reflection.MethodAttributes attributes, System.Reflection.CallingConventions callingConvention, System.Type returnType, System.Type[] returnTypeRequiredCustomModifiers, System.Type[] returnTypeOptionalCustomModifiers, System.Type[] parameterTypes, System.Type[][] parameterTypeRequiredCustomModifiers, System.Type[][] parameterTypeOptionalCustomModifiers) { return default(System.Reflection.Emit.MethodBuilder); }
    public System.Reflection.Emit.MethodBuilder DefineMethod(string name, System.Reflection.MethodAttributes attributes, System.Type returnType, System.Type[] parameterTypes) { return default(System.Reflection.Emit.MethodBuilder); }
    public void DefineMethodOverride(System.Reflection.MethodInfo methodInfoBody, System.Reflection.MethodInfo methodInfoDeclaration) { }
    public System.Reflection.Emit.TypeBuilder DefineNestedType(string name) { return default(System.Reflection.Emit.TypeBuilder); }
    public System.Reflection.Emit.TypeBuilder DefineNestedType(string name, System.Reflection.TypeAttributes attr) { return default(System.Reflection.Emit.TypeBuilder); }
    public System.Reflection.Emit.TypeBuilder DefineNestedType(string name, System.Reflection.TypeAttributes attr, System.Type parent) { return default(System.Reflection.Emit.TypeBuilder); }
    public System.Reflection.Emit.TypeBuilder DefineNestedType(string name, System.Reflection.TypeAttributes attr, System.Type parent, int typeSize) { return default(System.Reflection.Emit.TypeBuilder); }
    public System.Reflection.Emit.TypeBuilder DefineNestedType(string name, System.Reflection.TypeAttributes attr, System.Type parent, System.Reflection.Emit.PackingSize packSize) { return default(System.Reflection.Emit.TypeBuilder); }
    public System.Reflection.Emit.TypeBuilder DefineNestedType(string name, System.Reflection.TypeAttributes attr, System.Type parent, System.Reflection.Emit.PackingSize packSize, int typeSize) { return default(System.Reflection.Emit.TypeBuilder); }
    public System.Reflection.Emit.TypeBuilder DefineNestedType(string name, System.Reflection.TypeAttributes attr, System.Type parent, System.Type[] interfaces) { return default(System.Reflection.Emit.TypeBuilder); }
    public System.Reflection.Emit.PropertyBuilder DefineProperty(string name, System.Reflection.PropertyAttributes attributes, System.Reflection.CallingConventions callingConvention, System.Type returnType, System.Type[] parameterTypes) { return default(System.Reflection.Emit.PropertyBuilder); }
    public System.Reflection.Emit.PropertyBuilder DefineProperty(string name, System.Reflection.PropertyAttributes attributes, System.Reflection.CallingConventions callingConvention, System.Type returnType, System.Type[] returnTypeRequiredCustomModifiers, System.Type[] returnTypeOptionalCustomModifiers, System.Type[] parameterTypes, System.Type[][] parameterTypeRequiredCustomModifiers, System.Type[][] parameterTypeOptionalCustomModifiers) { return default(System.Reflection.Emit.PropertyBuilder); }
    public System.Reflection.Emit.PropertyBuilder DefineProperty(string name, System.Reflection.PropertyAttributes attributes, System.Type returnType, System.Type[] parameterTypes) { return default(System.Reflection.Emit.PropertyBuilder); }
    public System.Reflection.Emit.PropertyBuilder DefineProperty(string name, System.Reflection.PropertyAttributes attributes, System.Type returnType, System.Type[] returnTypeRequiredCustomModifiers, System.Type[] returnTypeOptionalCustomModifiers, System.Type[] parameterTypes, System.Type[][] parameterTypeRequiredCustomModifiers, System.Type[][] parameterTypeOptionalCustomModifiers) { return default(System.Reflection.Emit.PropertyBuilder); }
    public System.Reflection.Emit.ConstructorBuilder DefineTypeInitializer() { return default(System.Reflection.Emit.ConstructorBuilder); }
    public System.Reflection.Emit.FieldBuilder DefineUninitializedData(string name, int size, System.Reflection.FieldAttributes attributes) { return default(System.Reflection.Emit.FieldBuilder); }
    public override int GetArrayRank() { return default(int); }
    public static System.Reflection.ConstructorInfo GetConstructor(System.Type type, System.Reflection.ConstructorInfo constructor) { return default(System.Reflection.ConstructorInfo); }
    public override System.Type GetElementType() { return default(System.Type); }
    public static System.Reflection.FieldInfo GetField(System.Type type, System.Reflection.FieldInfo field) { return default(System.Reflection.FieldInfo); }
    public override System.Type[] GetGenericParameterConstraints() { return default(System.Type[]); }
    public override System.Type GetGenericTypeDefinition() { return default(System.Type); }
    public static System.Reflection.MethodInfo GetMethod(System.Type type, System.Reflection.MethodInfo method) { return default(System.Reflection.MethodInfo); }
    public override bool IsAssignableFrom(System.Reflection.TypeInfo typeInfo) { return default(bool); }
    public bool IsCreated() { return default(bool); }
    public override System.Type MakeArrayType() { return default(System.Type); }
    public override System.Type MakeArrayType(int rank) { return default(System.Type); }
    public override System.Type MakeByRefType() { return default(System.Type); }
    public override System.Type MakeGenericType(params System.Type[] typeArguments) { return default(System.Type); }
    public override System.Type MakePointerType() { return default(System.Type); }
    public void SetCustomAttribute(System.Reflection.ConstructorInfo con, byte[] binaryAttribute) { }
    public void SetCustomAttribute(System.Reflection.Emit.CustomAttributeBuilder customBuilder) { }
    public void SetParent(System.Type parent) { }
    public override string ToString() { return default(string); }
  }

  public partial class CustomAttributeBuilder {
    public CustomAttributeBuilder(System.Reflection.ConstructorInfo con, object[] constructorArgs) { }
    public CustomAttributeBuilder(System.Reflection.ConstructorInfo con, object[] constructorArgs, System.Reflection.FieldInfo[] namedFields, object[] fieldValues) { }
    public CustomAttributeBuilder(System.Reflection.ConstructorInfo con, object[] constructorArgs, System.Reflection.PropertyInfo[] namedProperties, object[] propertyValues) { }
    public CustomAttributeBuilder(System.Reflection.ConstructorInfo con, object[] constructorArgs, System.Reflection.PropertyInfo[] namedProperties, object[] propertyValues, System.Reflection.FieldInfo[] namedFields, object[] fieldValues) { }
  }

  public partial class ILGenerator {
    internal ILGenerator() { }
    public virtual int ILOffset { get { return default(int); } }
    public virtual void BeginCatchBlock(System.Type exceptionType) { }
    public virtual void BeginExceptFilterBlock() { }
    public virtual System.Reflection.Emit.Label BeginExceptionBlock() { return default(System.Reflection.Emit.Label); }
    public virtual void BeginFaultBlock() { }
    public virtual void BeginFinallyBlock() { }
    public virtual void BeginScope() { }
    public virtual System.Reflection.Emit.LocalBuilder DeclareLocal(System.Type localType) { return default(System.Reflection.Emit.LocalBuilder); }
    public virtual System.Reflection.Emit.LocalBuilder DeclareLocal(System.Type localType, bool pinned) { return default(System.Reflection.Emit.LocalBuilder); }
    public virtual System.Reflection.Emit.Label DefineLabel() { return default(System.Reflection.Emit.Label); }
    public virtual void Emit(System.Reflection.Emit.OpCode opcode) { }
    public virtual void Emit(System.Reflection.Emit.OpCode opcode, byte arg) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public virtual void Emit(System.Reflection.Emit.OpCode opcode, double arg) { }
    public virtual void Emit(System.Reflection.Emit.OpCode opcode, short arg) { }
    public virtual void Emit(System.Reflection.Emit.OpCode opcode, int arg) { }
    public virtual void Emit(System.Reflection.Emit.OpCode opcode, long arg) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public virtual void Emit(System.Reflection.Emit.OpCode opcode, System.Reflection.ConstructorInfo con) { }
    public virtual void Emit(System.Reflection.Emit.OpCode opcode, System.Reflection.Emit.Label label) { }
    public virtual void Emit(System.Reflection.Emit.OpCode opcode, System.Reflection.Emit.Label[] labels) { }
    public virtual void Emit(System.Reflection.Emit.OpCode opcode, System.Reflection.Emit.LocalBuilder local) { }
    public virtual void Emit(System.Reflection.Emit.OpCode opcode, System.Reflection.Emit.SignatureHelper signature) { }
    public virtual void Emit(System.Reflection.Emit.OpCode opcode, System.Reflection.FieldInfo field) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public virtual void Emit(System.Reflection.Emit.OpCode opcode, System.Reflection.MethodInfo meth) { }
    [System.CLSCompliantAttribute(false)]
    public void Emit(System.Reflection.Emit.OpCode opcode, sbyte arg) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public virtual void Emit(System.Reflection.Emit.OpCode opcode, float arg) { }
    public virtual void Emit(System.Reflection.Emit.OpCode opcode, string str) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public virtual void Emit(System.Reflection.Emit.OpCode opcode, System.Type cls) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public virtual void EmitCall(System.Reflection.Emit.OpCode opcode, System.Reflection.MethodInfo methodInfo, System.Type[] optionalParameterTypes) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public virtual void EmitCalli(System.Reflection.Emit.OpCode opcode, System.Reflection.CallingConventions callingConvention, System.Type returnType, System.Type[] parameterTypes, System.Type[] optionalParameterTypes) { }
    public virtual void EmitWriteLine(System.Reflection.Emit.LocalBuilder localBuilder) { }
    public virtual void EmitWriteLine(System.Reflection.FieldInfo fld) { }
    public virtual void EmitWriteLine(string value) { }
    public virtual void EndExceptionBlock() { }
    public virtual void EndScope() { }
    public virtual void MarkLabel(System.Reflection.Emit.Label loc) { }
    public virtual void ThrowException(System.Type excType) { }
    public virtual void UsingNamespace(string usingNamespace) { }
  }

  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct Label {
    public override bool Equals(object obj) { return default(bool); }
    public bool Equals(System.Reflection.Emit.Label obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.Reflection.Emit.Label a, System.Reflection.Emit.Label b) { return default(bool); }
    public static bool operator !=(System.Reflection.Emit.Label a, System.Reflection.Emit.Label b) { return default(bool); }
  }

  public sealed partial class LocalBuilder : System.Reflection.LocalVariableInfo {
    internal LocalBuilder() { }
    public override bool IsPinned { get { return default(bool); } }
    public override int LocalIndex { get { return default(int); } }
    public override System.Type LocalType { get { return default(System.Type); } }
  }

  public partial class ParameterBuilder {
    internal ParameterBuilder() { }
    public virtual int Attributes { get { return default(int); } }
    public bool IsIn { get { return default(bool); } }
    public bool IsOptional { get { return default(bool); } }
    public bool IsOut { get { return default(bool); } }
    public virtual string Name { get { return default(string); } }
    public virtual int Position { get { return default(int); } }
    [System.Security.SecuritySafeCriticalAttribute]
    public virtual void SetConstant(object defaultValue) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public void SetCustomAttribute(System.Reflection.ConstructorInfo con, byte[] binaryAttribute) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public void SetCustomAttribute(System.Reflection.Emit.CustomAttributeBuilder customBuilder) { }
  }

  public sealed partial class SignatureHelper {
    internal SignatureHelper() { }
    public void AddArgument(System.Type clsArgument) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public void AddArgument(System.Type argument, bool pinned) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public void AddArgument(System.Type argument, System.Type[] requiredCustomModifiers, System.Type[] optionalCustomModifiers) { }
    public void AddArguments(System.Type[] arguments, System.Type[][] requiredCustomModifiers, System.Type[][] optionalCustomModifiers) { }
    public void AddSentinel() { }
    public override bool Equals(object obj) { return default(bool); }
    public static System.Reflection.Emit.SignatureHelper GetFieldSigHelper(System.Reflection.Module mod) { return default(System.Reflection.Emit.SignatureHelper); }
    public override int GetHashCode() { return default(int); }
    public static System.Reflection.Emit.SignatureHelper GetLocalVarSigHelper() { return default(System.Reflection.Emit.SignatureHelper); }
    public static System.Reflection.Emit.SignatureHelper GetLocalVarSigHelper(System.Reflection.Module mod) { return default(System.Reflection.Emit.SignatureHelper); }
    public static System.Reflection.Emit.SignatureHelper GetMethodSigHelper(System.Reflection.CallingConventions callingConvention, System.Type returnType) { return default(System.Reflection.Emit.SignatureHelper); }
    [System.Security.SecuritySafeCriticalAttribute]
    public static System.Reflection.Emit.SignatureHelper GetMethodSigHelper(System.Reflection.Module mod, System.Reflection.CallingConventions callingConvention, System.Type returnType) { return default(System.Reflection.Emit.SignatureHelper); }
    [System.Security.SecuritySafeCriticalAttribute]
    public static System.Reflection.Emit.SignatureHelper GetMethodSigHelper(System.Reflection.Module mod, System.Type returnType, System.Type[] parameterTypes) { return default(System.Reflection.Emit.SignatureHelper); }
    [System.Security.SecuritySafeCriticalAttribute]
    public static System.Reflection.Emit.SignatureHelper GetPropertySigHelper(System.Reflection.Module mod, System.Reflection.CallingConventions callingConvention, System.Type returnType, System.Type[] requiredReturnTypeCustomModifiers, System.Type[] optionalReturnTypeCustomModifiers, System.Type[] parameterTypes, System.Type[][] requiredParameterTypeCustomModifiers, System.Type[][] optionalParameterTypeCustomModifiers) { return default(System.Reflection.Emit.SignatureHelper); }
    public static System.Reflection.Emit.SignatureHelper GetPropertySigHelper(System.Reflection.Module mod, System.Type returnType, System.Type[] parameterTypes) { return default(System.Reflection.Emit.SignatureHelper); }
    public static System.Reflection.Emit.SignatureHelper GetPropertySigHelper(System.Reflection.Module mod, System.Type returnType, System.Type[] requiredReturnTypeCustomModifiers, System.Type[] optionalReturnTypeCustomModifiers, System.Type[] parameterTypes, System.Type[][] requiredParameterTypeCustomModifiers, System.Type[][] optionalParameterTypeCustomModifiers) { return default(System.Reflection.Emit.SignatureHelper); }
    public byte[] GetSignature() { return default(byte[]); }
    public override string ToString() { return default(string); }
  }

  public sealed partial class DynamicMethod : System.Reflection.MethodInfo {
    [System.Security.SecuritySafeCriticalAttribute]
    public DynamicMethod(string name, System.Reflection.MethodAttributes attributes, System.Reflection.CallingConventions callingConvention, System.Type returnType, System.Type[] parameterTypes, System.Reflection.Module m, bool skipVisibility) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public DynamicMethod(string name, System.Reflection.MethodAttributes attributes, System.Reflection.CallingConventions callingConvention, System.Type returnType, System.Type[] parameterTypes, System.Type owner, bool skipVisibility) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public DynamicMethod(string name, System.Type returnType, System.Type[] parameterTypes) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public DynamicMethod(string name, System.Type returnType, System.Type[] parameterTypes, bool restrictedSkipVisibility) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public DynamicMethod(string name, System.Type returnType, System.Type[] parameterTypes, System.Reflection.Module m) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public DynamicMethod(string name, System.Type returnType, System.Type[] parameterTypes, System.Reflection.Module m, bool skipVisibility) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public DynamicMethod(string name, System.Type returnType, System.Type[] parameterTypes, System.Type owner) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public DynamicMethod(string name, System.Type returnType, System.Type[] parameterTypes, System.Type owner, bool skipVisibility) { }
    public override System.Reflection.MethodAttributes Attributes { get { return default(System.Reflection.MethodAttributes); } }
    public override System.Reflection.CallingConventions CallingConvention { get { return default(System.Reflection.CallingConventions); } }
    public override System.Type DeclaringType { get { return default(System.Type); } }
    public bool InitLocals { get { return default(bool); } set { } }
    public override System.Reflection.MethodImplAttributes MethodImplementationFlags { get { return default(System.Reflection.MethodImplAttributes); } }
    public override string Name { get { return default(string); } }
    public override System.Reflection.ParameterInfo ReturnParameter { get { return default(System.Reflection.ParameterInfo); } }
    public override System.Type ReturnType { get { return default(System.Type); } }
    [System.Security.SecuritySafeCriticalAttribute]
    public sealed override System.Delegate CreateDelegate(System.Type delegateType) { return default(System.Delegate); }
    [System.Security.SecuritySafeCriticalAttribute]
    public sealed override System.Delegate CreateDelegate(System.Type delegateType, object target) { return default(System.Delegate); }
    public System.Reflection.Emit.ILGenerator GetILGenerator() { return default(System.Reflection.Emit.ILGenerator); }
    [System.Security.SecuritySafeCriticalAttribute]
    public System.Reflection.Emit.ILGenerator GetILGenerator(int streamSize) { return default(System.Reflection.Emit.ILGenerator); }
    public override System.Reflection.ParameterInfo[] GetParameters() { return default(System.Reflection.ParameterInfo[]); }
    public override string ToString() { return default(string); }
  }

  public enum FlowControl {
    Branch = 0,
    Break = 1,
    Call = 2,
    Cond_Branch = 3,
    Meta = 4,
    Next = 5,
    Return = 7,
    Throw = 8,
  }

  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct OpCode {
    public System.Reflection.Emit.FlowControl FlowControl { get { return default(System.Reflection.Emit.FlowControl); } }
    public string Name { get { return default(string); } }
    public System.Reflection.Emit.OpCodeType OpCodeType { get { return default(System.Reflection.Emit.OpCodeType); } }
    public System.Reflection.Emit.OperandType OperandType { get { return default(System.Reflection.Emit.OperandType); } }
    public int Size { get { return default(int); } }
    public System.Reflection.Emit.StackBehaviour StackBehaviourPop { get { return default(System.Reflection.Emit.StackBehaviour); } }
    public System.Reflection.Emit.StackBehaviour StackBehaviourPush { get { return default(System.Reflection.Emit.StackBehaviour); } }
    public short Value { get { return default(short); } }
    public override bool Equals(object obj) { return default(bool); }
    public bool Equals(System.Reflection.Emit.OpCode obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.Reflection.Emit.OpCode a, System.Reflection.Emit.OpCode b) { return default(bool); }
    public static bool operator !=(System.Reflection.Emit.OpCode a, System.Reflection.Emit.OpCode b) { return default(bool); }
    public override string ToString() { return default(string); }
  }

  public partial class OpCodes {
    internal OpCodes() { }
    public static readonly System.Reflection.Emit.OpCode Add;
    public static readonly System.Reflection.Emit.OpCode Add_Ovf;
    public static readonly System.Reflection.Emit.OpCode Add_Ovf_Un;
    public static readonly System.Reflection.Emit.OpCode And;
    public static readonly System.Reflection.Emit.OpCode Arglist;
    public static readonly System.Reflection.Emit.OpCode Beq;
    public static readonly System.Reflection.Emit.OpCode Beq_S;
    public static readonly System.Reflection.Emit.OpCode Bge;
    public static readonly System.Reflection.Emit.OpCode Bge_S;
    public static readonly System.Reflection.Emit.OpCode Bge_Un;
    public static readonly System.Reflection.Emit.OpCode Bge_Un_S;
    public static readonly System.Reflection.Emit.OpCode Bgt;
    public static readonly System.Reflection.Emit.OpCode Bgt_S;
    public static readonly System.Reflection.Emit.OpCode Bgt_Un;
    public static readonly System.Reflection.Emit.OpCode Bgt_Un_S;
    public static readonly System.Reflection.Emit.OpCode Ble;
    public static readonly System.Reflection.Emit.OpCode Ble_S;
    public static readonly System.Reflection.Emit.OpCode Ble_Un;
    public static readonly System.Reflection.Emit.OpCode Ble_Un_S;
    public static readonly System.Reflection.Emit.OpCode Blt;
    public static readonly System.Reflection.Emit.OpCode Blt_S;
    public static readonly System.Reflection.Emit.OpCode Blt_Un;
    public static readonly System.Reflection.Emit.OpCode Blt_Un_S;
    public static readonly System.Reflection.Emit.OpCode Bne_Un;
    public static readonly System.Reflection.Emit.OpCode Bne_Un_S;
    public static readonly System.Reflection.Emit.OpCode Box;
    public static readonly System.Reflection.Emit.OpCode Br;
    public static readonly System.Reflection.Emit.OpCode Br_S;
    public static readonly System.Reflection.Emit.OpCode Break;
    public static readonly System.Reflection.Emit.OpCode Brfalse;
    public static readonly System.Reflection.Emit.OpCode Brfalse_S;
    public static readonly System.Reflection.Emit.OpCode Brtrue;
    public static readonly System.Reflection.Emit.OpCode Brtrue_S;
    public static readonly System.Reflection.Emit.OpCode Call;
    public static readonly System.Reflection.Emit.OpCode Calli;
    public static readonly System.Reflection.Emit.OpCode Callvirt;
    public static readonly System.Reflection.Emit.OpCode Castclass;
    public static readonly System.Reflection.Emit.OpCode Ceq;
    public static readonly System.Reflection.Emit.OpCode Cgt;
    public static readonly System.Reflection.Emit.OpCode Cgt_Un;
    public static readonly System.Reflection.Emit.OpCode Ckfinite;
    public static readonly System.Reflection.Emit.OpCode Clt;
    public static readonly System.Reflection.Emit.OpCode Clt_Un;
    public static readonly System.Reflection.Emit.OpCode Constrained;
    public static readonly System.Reflection.Emit.OpCode Conv_I;
    public static readonly System.Reflection.Emit.OpCode Conv_I1;
    public static readonly System.Reflection.Emit.OpCode Conv_I2;
    public static readonly System.Reflection.Emit.OpCode Conv_I4;
    public static readonly System.Reflection.Emit.OpCode Conv_I8;
    public static readonly System.Reflection.Emit.OpCode Conv_Ovf_I;
    public static readonly System.Reflection.Emit.OpCode Conv_Ovf_I_Un;
    public static readonly System.Reflection.Emit.OpCode Conv_Ovf_I1;
    public static readonly System.Reflection.Emit.OpCode Conv_Ovf_I1_Un;
    public static readonly System.Reflection.Emit.OpCode Conv_Ovf_I2;
    public static readonly System.Reflection.Emit.OpCode Conv_Ovf_I2_Un;
    public static readonly System.Reflection.Emit.OpCode Conv_Ovf_I4;
    public static readonly System.Reflection.Emit.OpCode Conv_Ovf_I4_Un;
    public static readonly System.Reflection.Emit.OpCode Conv_Ovf_I8;
    public static readonly System.Reflection.Emit.OpCode Conv_Ovf_I8_Un;
    public static readonly System.Reflection.Emit.OpCode Conv_Ovf_U;
    public static readonly System.Reflection.Emit.OpCode Conv_Ovf_U_Un;
    public static readonly System.Reflection.Emit.OpCode Conv_Ovf_U1;
    public static readonly System.Reflection.Emit.OpCode Conv_Ovf_U1_Un;
    public static readonly System.Reflection.Emit.OpCode Conv_Ovf_U2;
    public static readonly System.Reflection.Emit.OpCode Conv_Ovf_U2_Un;
    public static readonly System.Reflection.Emit.OpCode Conv_Ovf_U4;
    public static readonly System.Reflection.Emit.OpCode Conv_Ovf_U4_Un;
    public static readonly System.Reflection.Emit.OpCode Conv_Ovf_U8;
    public static readonly System.Reflection.Emit.OpCode Conv_Ovf_U8_Un;
    public static readonly System.Reflection.Emit.OpCode Conv_R_Un;
    public static readonly System.Reflection.Emit.OpCode Conv_R4;
    public static readonly System.Reflection.Emit.OpCode Conv_R8;
    public static readonly System.Reflection.Emit.OpCode Conv_U;
    public static readonly System.Reflection.Emit.OpCode Conv_U1;
    public static readonly System.Reflection.Emit.OpCode Conv_U2;
    public static readonly System.Reflection.Emit.OpCode Conv_U4;
    public static readonly System.Reflection.Emit.OpCode Conv_U8;
    public static readonly System.Reflection.Emit.OpCode Cpblk;
    public static readonly System.Reflection.Emit.OpCode Cpobj;
    public static readonly System.Reflection.Emit.OpCode Div;
    public static readonly System.Reflection.Emit.OpCode Div_Un;
    public static readonly System.Reflection.Emit.OpCode Dup;
    public static readonly System.Reflection.Emit.OpCode Endfilter;
    public static readonly System.Reflection.Emit.OpCode Endfinally;
    public static readonly System.Reflection.Emit.OpCode Initblk;
    public static readonly System.Reflection.Emit.OpCode Initobj;
    public static readonly System.Reflection.Emit.OpCode Isinst;
    public static readonly System.Reflection.Emit.OpCode Jmp;
    public static readonly System.Reflection.Emit.OpCode Ldarg;
    public static readonly System.Reflection.Emit.OpCode Ldarg_0;
    public static readonly System.Reflection.Emit.OpCode Ldarg_1;
    public static readonly System.Reflection.Emit.OpCode Ldarg_2;
    public static readonly System.Reflection.Emit.OpCode Ldarg_3;
    public static readonly System.Reflection.Emit.OpCode Ldarg_S;
    public static readonly System.Reflection.Emit.OpCode Ldarga;
    public static readonly System.Reflection.Emit.OpCode Ldarga_S;
    public static readonly System.Reflection.Emit.OpCode Ldc_I4;
    public static readonly System.Reflection.Emit.OpCode Ldc_I4_0;
    public static readonly System.Reflection.Emit.OpCode Ldc_I4_1;
    public static readonly System.Reflection.Emit.OpCode Ldc_I4_2;
    public static readonly System.Reflection.Emit.OpCode Ldc_I4_3;
    public static readonly System.Reflection.Emit.OpCode Ldc_I4_4;
    public static readonly System.Reflection.Emit.OpCode Ldc_I4_5;
    public static readonly System.Reflection.Emit.OpCode Ldc_I4_6;
    public static readonly System.Reflection.Emit.OpCode Ldc_I4_7;
    public static readonly System.Reflection.Emit.OpCode Ldc_I4_8;
    public static readonly System.Reflection.Emit.OpCode Ldc_I4_M1;
    public static readonly System.Reflection.Emit.OpCode Ldc_I4_S;
    public static readonly System.Reflection.Emit.OpCode Ldc_I8;
    public static readonly System.Reflection.Emit.OpCode Ldc_R4;
    public static readonly System.Reflection.Emit.OpCode Ldc_R8;
    public static readonly System.Reflection.Emit.OpCode Ldelem;
    public static readonly System.Reflection.Emit.OpCode Ldelem_I;
    public static readonly System.Reflection.Emit.OpCode Ldelem_I1;
    public static readonly System.Reflection.Emit.OpCode Ldelem_I2;
    public static readonly System.Reflection.Emit.OpCode Ldelem_I4;
    public static readonly System.Reflection.Emit.OpCode Ldelem_I8;
    public static readonly System.Reflection.Emit.OpCode Ldelem_R4;
    public static readonly System.Reflection.Emit.OpCode Ldelem_R8;
    public static readonly System.Reflection.Emit.OpCode Ldelem_Ref;
    public static readonly System.Reflection.Emit.OpCode Ldelem_U1;
    public static readonly System.Reflection.Emit.OpCode Ldelem_U2;
    public static readonly System.Reflection.Emit.OpCode Ldelem_U4;
    public static readonly System.Reflection.Emit.OpCode Ldelema;
    public static readonly System.Reflection.Emit.OpCode Ldfld;
    public static readonly System.Reflection.Emit.OpCode Ldflda;
    public static readonly System.Reflection.Emit.OpCode Ldftn;
    public static readonly System.Reflection.Emit.OpCode Ldind_I;
    public static readonly System.Reflection.Emit.OpCode Ldind_I1;
    public static readonly System.Reflection.Emit.OpCode Ldind_I2;
    public static readonly System.Reflection.Emit.OpCode Ldind_I4;
    public static readonly System.Reflection.Emit.OpCode Ldind_I8;
    public static readonly System.Reflection.Emit.OpCode Ldind_R4;
    public static readonly System.Reflection.Emit.OpCode Ldind_R8;
    public static readonly System.Reflection.Emit.OpCode Ldind_Ref;
    public static readonly System.Reflection.Emit.OpCode Ldind_U1;
    public static readonly System.Reflection.Emit.OpCode Ldind_U2;
    public static readonly System.Reflection.Emit.OpCode Ldind_U4;
    public static readonly System.Reflection.Emit.OpCode Ldlen;
    public static readonly System.Reflection.Emit.OpCode Ldloc;
    public static readonly System.Reflection.Emit.OpCode Ldloc_0;
    public static readonly System.Reflection.Emit.OpCode Ldloc_1;
    public static readonly System.Reflection.Emit.OpCode Ldloc_2;
    public static readonly System.Reflection.Emit.OpCode Ldloc_3;
    public static readonly System.Reflection.Emit.OpCode Ldloc_S;
    public static readonly System.Reflection.Emit.OpCode Ldloca;
    public static readonly System.Reflection.Emit.OpCode Ldloca_S;
    public static readonly System.Reflection.Emit.OpCode Ldnull;
    public static readonly System.Reflection.Emit.OpCode Ldobj;
    public static readonly System.Reflection.Emit.OpCode Ldsfld;
    public static readonly System.Reflection.Emit.OpCode Ldsflda;
    public static readonly System.Reflection.Emit.OpCode Ldstr;
    public static readonly System.Reflection.Emit.OpCode Ldtoken;
    public static readonly System.Reflection.Emit.OpCode Ldvirtftn;
    public static readonly System.Reflection.Emit.OpCode Leave;
    public static readonly System.Reflection.Emit.OpCode Leave_S;
    public static readonly System.Reflection.Emit.OpCode Localloc;
    public static readonly System.Reflection.Emit.OpCode Mkrefany;
    public static readonly System.Reflection.Emit.OpCode Mul;
    public static readonly System.Reflection.Emit.OpCode Mul_Ovf;
    public static readonly System.Reflection.Emit.OpCode Mul_Ovf_Un;
    public static readonly System.Reflection.Emit.OpCode Neg;
    public static readonly System.Reflection.Emit.OpCode Newarr;
    public static readonly System.Reflection.Emit.OpCode Newobj;
    public static readonly System.Reflection.Emit.OpCode Nop;
    public static readonly System.Reflection.Emit.OpCode Not;
    public static readonly System.Reflection.Emit.OpCode Or;
    public static readonly System.Reflection.Emit.OpCode Pop;
    public static readonly System.Reflection.Emit.OpCode Prefix1;
    public static readonly System.Reflection.Emit.OpCode Prefix2;
    public static readonly System.Reflection.Emit.OpCode Prefix3;
    public static readonly System.Reflection.Emit.OpCode Prefix4;
    public static readonly System.Reflection.Emit.OpCode Prefix5;
    public static readonly System.Reflection.Emit.OpCode Prefix6;
    public static readonly System.Reflection.Emit.OpCode Prefix7;
    public static readonly System.Reflection.Emit.OpCode Prefixref;
    public static readonly System.Reflection.Emit.OpCode Readonly;
    public static readonly System.Reflection.Emit.OpCode Refanytype;
    public static readonly System.Reflection.Emit.OpCode Refanyval;
    public static readonly System.Reflection.Emit.OpCode Rem;
    public static readonly System.Reflection.Emit.OpCode Rem_Un;
    public static readonly System.Reflection.Emit.OpCode Ret;
    public static readonly System.Reflection.Emit.OpCode Rethrow;
    public static readonly System.Reflection.Emit.OpCode Shl;
    public static readonly System.Reflection.Emit.OpCode Shr;
    public static readonly System.Reflection.Emit.OpCode Shr_Un;
    public static readonly System.Reflection.Emit.OpCode Sizeof;
    public static readonly System.Reflection.Emit.OpCode Starg;
    public static readonly System.Reflection.Emit.OpCode Starg_S;
    public static readonly System.Reflection.Emit.OpCode Stelem;
    public static readonly System.Reflection.Emit.OpCode Stelem_I;
    public static readonly System.Reflection.Emit.OpCode Stelem_I1;
    public static readonly System.Reflection.Emit.OpCode Stelem_I2;
    public static readonly System.Reflection.Emit.OpCode Stelem_I4;
    public static readonly System.Reflection.Emit.OpCode Stelem_I8;
    public static readonly System.Reflection.Emit.OpCode Stelem_R4;
    public static readonly System.Reflection.Emit.OpCode Stelem_R8;
    public static readonly System.Reflection.Emit.OpCode Stelem_Ref;
    public static readonly System.Reflection.Emit.OpCode Stfld;
    public static readonly System.Reflection.Emit.OpCode Stind_I;
    public static readonly System.Reflection.Emit.OpCode Stind_I1;
    public static readonly System.Reflection.Emit.OpCode Stind_I2;
    public static readonly System.Reflection.Emit.OpCode Stind_I4;
    public static readonly System.Reflection.Emit.OpCode Stind_I8;
    public static readonly System.Reflection.Emit.OpCode Stind_R4;
    public static readonly System.Reflection.Emit.OpCode Stind_R8;
    public static readonly System.Reflection.Emit.OpCode Stind_Ref;
    public static readonly System.Reflection.Emit.OpCode Stloc;
    public static readonly System.Reflection.Emit.OpCode Stloc_0;
    public static readonly System.Reflection.Emit.OpCode Stloc_1;
    public static readonly System.Reflection.Emit.OpCode Stloc_2;
    public static readonly System.Reflection.Emit.OpCode Stloc_3;
    public static readonly System.Reflection.Emit.OpCode Stloc_S;
    public static readonly System.Reflection.Emit.OpCode Stobj;
    public static readonly System.Reflection.Emit.OpCode Stsfld;
    public static readonly System.Reflection.Emit.OpCode Sub;
    public static readonly System.Reflection.Emit.OpCode Sub_Ovf;
    public static readonly System.Reflection.Emit.OpCode Sub_Ovf_Un;
    public static readonly System.Reflection.Emit.OpCode Switch;
    public static readonly System.Reflection.Emit.OpCode Tailcall;
    public static readonly System.Reflection.Emit.OpCode Throw;
    public static readonly System.Reflection.Emit.OpCode Unaligned;
    public static readonly System.Reflection.Emit.OpCode Unbox;
    public static readonly System.Reflection.Emit.OpCode Unbox_Any;
    public static readonly System.Reflection.Emit.OpCode Volatile;
    public static readonly System.Reflection.Emit.OpCode Xor;
    public static bool TakesSingleByteArgument(System.Reflection.Emit.OpCode inst) { return default(bool); }
  }

  public enum OpCodeType {
    Macro = 1,
    Nternal = 2,
    Objmodel = 3,
    Prefix = 4,
    Primitive = 5,
  }

  public enum OperandType {
    InlineBrTarget = 0,
    InlineField = 1,
    InlineI = 2,
    InlineI8 = 3,
    InlineMethod = 4,
    InlineNone = 5,
    InlineR = 7,
    InlineSig = 9,
    InlineString = 10,
    InlineSwitch = 11,
    InlineTok = 12,
    InlineType = 13,
    InlineVar = 14,
    ShortInlineBrTarget = 15,
    ShortInlineI = 16,
    ShortInlineR = 17,
    ShortInlineVar = 18,
  }

  public enum PackingSize {
    Size1 = 1,
    Size128 = 128,
    Size16 = 16,
    Size2 = 2,
    Size32 = 32,
    Size4 = 4,
    Size64 = 64,
    Size8 = 8,
    Unspecified = 0,
  }

  public enum StackBehaviour {
    Pop0 = 0,
    Pop1 = 1,
    Pop1_pop1 = 2,
    Popi = 3,
    Popi_pop1 = 4,
    Popi_popi = 5,
    Popi_popi_popi = 7,
    Popi_popi8 = 6,
    Popi_popr4 = 8,
    Popi_popr8 = 9,
    Popref = 10,
    Popref_pop1 = 11,
    Popref_popi = 12,
    Popref_popi_pop1 = 28,
    Popref_popi_popi = 13,
    Popref_popi_popi8 = 14,
    Popref_popi_popr4 = 15,
    Popref_popi_popr8 = 16,
    Popref_popi_popref = 17,
    Push0 = 18,
    Push1 = 19,
    Push1_push1 = 20,
    Pushi = 21,
    Pushi8 = 22,
    Pushr4 = 23,
    Pushr8 = 24,
    Pushref = 25,
    Varpop = 26,
    Varpush = 27,
  }

} // end of System.Reflection.Emit
namespace System.Runtime.Versioning {
  public sealed partial class FrameworkName : System.IEquatable<System.Runtime.Versioning.FrameworkName> {
    public FrameworkName(string frameworkName) { }
    public FrameworkName(string identifier, System.Version version) { }
    public FrameworkName(string identifier, System.Version version, string profile) { }
    public string FullName { get { return default(string); } }
    public string Identifier { get { return default(string); } }
    public string Profile { get { return default(string); } }
    public System.Version Version { get { return default(System.Version); } }
    public override bool Equals(object obj) { return default(bool); }
    public bool Equals(System.Runtime.Versioning.FrameworkName other) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.Runtime.Versioning.FrameworkName left, System.Runtime.Versioning.FrameworkName right) { return default(bool); }
    public static bool operator !=(System.Runtime.Versioning.FrameworkName left, System.Runtime.Versioning.FrameworkName right) { return default(bool); }
    public override string ToString() { return default(string); }
  }

} // end of System.Runtime.Versioning
namespace System.Threading {
  public static partial class WaitHandleExtensions {
    [System.Security.SecurityCriticalAttribute]
    public static Microsoft.Win32.SafeHandles.SafeWaitHandle GetSafeWaitHandle(this System.Threading.WaitHandle waitHandle) { return default(Microsoft.Win32.SafeHandles.SafeWaitHandle); }
    [System.Security.SecurityCriticalAttribute]
    public static void SetSafeWaitHandle(this System.Threading.WaitHandle waitHandle, Microsoft.Win32.SafeHandles.SafeWaitHandle value) { }
  }

  public sealed partial class AsyncLocal<T> {
    public AsyncLocal() { }
    [System.Security.SecurityCriticalAttribute]
    public AsyncLocal(System.Action<System.Threading.AsyncLocalValueChangedArgs<T>> valueChangedHandler) { }
    public T Value { get { return default(T); } set { } }
  }

  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct AsyncLocalValueChangedArgs<T> {
    public T CurrentValue { get { return default(T); } }
    public T PreviousValue { get { return default(T); } }
    public bool ThreadContextChanged { get { return default(bool); } }
  }

  [System.Security.SecurityCriticalAttribute]
  public static partial class ThreadingAclExtensions {
    public static System.Security.AccessControl.EventWaitHandleSecurity GetAccessControl(this System.Threading.EventWaitHandle handle) { return default(System.Security.AccessControl.EventWaitHandleSecurity); }
    public static System.Security.AccessControl.MutexSecurity GetAccessControl(this System.Threading.Mutex mutex) { return default(System.Security.AccessControl.MutexSecurity); }
    public static System.Security.AccessControl.SemaphoreSecurity GetAccessControl(this System.Threading.Semaphore semaphore) { return default(System.Security.AccessControl.SemaphoreSecurity); }
    public static void SetAccessControl(this System.Threading.EventWaitHandle handle, System.Security.AccessControl.EventWaitHandleSecurity eventSecurity) { }
    public static void SetAccessControl(this System.Threading.Mutex mutex, System.Security.AccessControl.MutexSecurity mutexSecurity) { }
    public static void SetAccessControl(this System.Threading.Semaphore semaphore, System.Security.AccessControl.SemaphoreSecurity semaphoreSecurity) { }
  }

  public sealed partial class PreAllocatedOverlapped : System.IDisposable {
    [System.CLSCompliantAttribute(false)]
    public PreAllocatedOverlapped(System.Threading.IOCompletionCallback callback, object state, object pinData) { }
    public void Dispose() { }
  }

  public sealed partial class ThreadPoolBoundHandle : System.IDisposable {
    internal ThreadPoolBoundHandle() { }
    public System.Runtime.InteropServices.SafeHandle Handle { get { return default(System.Runtime.InteropServices.SafeHandle); } }
    [System.CLSCompliantAttribute(false)]
    public unsafe System.Threading.NativeOverlapped* AllocateNativeOverlapped(System.Threading.IOCompletionCallback callback, object state, object pinData) { return default(System.Threading.NativeOverlapped*); }
    [System.CLSCompliantAttribute(false)]
    public unsafe System.Threading.NativeOverlapped* AllocateNativeOverlapped(System.Threading.PreAllocatedOverlapped preAllocated) { return default(System.Threading.NativeOverlapped*); }
    public static System.Threading.ThreadPoolBoundHandle BindHandle(System.Runtime.InteropServices.SafeHandle handle) { return default(System.Threading.ThreadPoolBoundHandle); }
    public void Dispose() { }
    [System.CLSCompliantAttribute(false)]
    public unsafe void FreeNativeOverlapped(System.Threading.NativeOverlapped* overlapped) { }
    [System.CLSCompliantAttribute(false)]
    public unsafe static object GetNativeOverlappedState(System.Threading.NativeOverlapped* overlapped) { return default(object); }
  }

} // end of System.Threading
namespace System.Runtime.InteropServices.ComTypes {
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
namespace System.Reflection.Metadata {
  public static partial class AssemblyExtensions {
    [System.CLSCompliantAttribute(false)]
    public unsafe static bool TryGetRawMetadata(this System.Reflection.Assembly assembly, out byte* blob, out int length) { blob = default(byte*); length = default(int); return default(bool); }
  }

} // end of System.Reflection.Metadata
namespace System.Runtime.Loader {
  public abstract partial class AssemblyLoadContext {
    protected AssemblyLoadContext() { }
    public static System.Runtime.Loader.AssemblyLoadContext Default { get { return default(System.Runtime.Loader.AssemblyLoadContext); } }
    public event System.Func<System.Runtime.Loader.AssemblyLoadContext, System.Reflection.AssemblyName, System.Reflection.Assembly> Resolving { add { } remove { } }
    public event System.Action<System.Runtime.Loader.AssemblyLoadContext> Unloading { add { } remove { } }
    public static System.Reflection.AssemblyName GetAssemblyName(string assemblyPath) { return default(System.Reflection.AssemblyName); }
    public static System.Runtime.Loader.AssemblyLoadContext GetLoadContext(System.Reflection.Assembly assembly) { return default(System.Runtime.Loader.AssemblyLoadContext); }
    protected abstract System.Reflection.Assembly Load(System.Reflection.AssemblyName assemblyName);
    public System.Reflection.Assembly LoadFromAssemblyName(System.Reflection.AssemblyName assemblyName) { return default(System.Reflection.Assembly); }
    public System.Reflection.Assembly LoadFromAssemblyPath(string assemblyPath) { return default(System.Reflection.Assembly); }
    public System.Reflection.Assembly LoadFromNativeImagePath(string nativeImagePath, string assemblyPath) { return default(System.Reflection.Assembly); }
    public System.Reflection.Assembly LoadFromStream(System.IO.Stream assembly) { return default(System.Reflection.Assembly); }
    public System.Reflection.Assembly LoadFromStream(System.IO.Stream assembly, System.IO.Stream assemblySymbols) { return default(System.Reflection.Assembly); }
    protected virtual System.IntPtr LoadUnmanagedDll(string unmanagedDllName) { return default(System.IntPtr); }
    protected System.IntPtr LoadUnmanagedDllFromPath(string unmanagedDllPath) { return default(System.IntPtr); }
    public void SetProfileOptimizationRoot(string directoryPath) { }
    public void StartProfileOptimization(string profile) { }
  }

} // end of System.Runtime.Loader
namespace System.Runtime.Serialization {
  public partial class DateTimeFormat {
    public DateTimeFormat(string formatString) { }
    public DateTimeFormat(string formatString, System.IFormatProvider formatProvider) { }
    public System.Globalization.DateTimeStyles DateTimeStyles { get { return default(System.Globalization.DateTimeStyles); } set { } }
    public System.IFormatProvider FormatProvider { get { return default(System.IFormatProvider); } }
    public string FormatString { get { return default(string); } }
  }

  public enum EmitTypeInformation {
    Always = 1,
    AsNeeded = 0,
    Never = 2,
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(12), Inherited=false, AllowMultiple=false)]
  public sealed partial class CollectionDataContractAttribute : System.Attribute {
    public CollectionDataContractAttribute() { }
    public bool IsItemNameSetExplicitly { get { return default(bool); } }
    public bool IsKeyNameSetExplicitly { get { return default(bool); } }
    public bool IsNameSetExplicitly { get { return default(bool); } }
    public bool IsNamespaceSetExplicitly { get { return default(bool); } }
    public bool IsReference { get { return default(bool); } set { } }
    public bool IsReferenceSetExplicitly { get { return default(bool); } }
    public bool IsValueNameSetExplicitly { get { return default(bool); } }
    public string ItemName { get { return default(string); } set { } }
    public string KeyName { get { return default(string); } set { } }
    public string Name { get { return default(string); } set { } }
    public string Namespace { get { return default(string); } set { } }
    public string ValueName { get { return default(string); } set { } }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(3), Inherited=false, AllowMultiple=true)]
  public sealed partial class ContractNamespaceAttribute : System.Attribute {
    public ContractNamespaceAttribute(string contractNamespace) { }
    public string ClrNamespace { get { return default(string); } set { } }
    public string ContractNamespace { get { return default(string); } }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(28), Inherited=false, AllowMultiple=false)]
  public sealed partial class DataContractAttribute : System.Attribute {
    public DataContractAttribute() { }
    public bool IsNameSetExplicitly { get { return default(bool); } }
    public bool IsNamespaceSetExplicitly { get { return default(bool); } }
    public bool IsReference { get { return default(bool); } set { } }
    public bool IsReferenceSetExplicitly { get { return default(bool); } }
    public string Name { get { return default(string); } set { } }
    public string Namespace { get { return default(string); } set { } }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(384), Inherited=false, AllowMultiple=false)]
  public sealed partial class DataMemberAttribute : System.Attribute {
    public DataMemberAttribute() { }
    public bool EmitDefaultValue { get { return default(bool); } set { } }
    public bool IsNameSetExplicitly { get { return default(bool); } }
    public bool IsRequired { get { return default(bool); } set { } }
    public string Name { get { return default(string); } set { } }
    public int Order { get { return default(int); } set { } }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(256), Inherited=false, AllowMultiple=false)]
  public sealed partial class EnumMemberAttribute : System.Attribute {
    public EnumMemberAttribute() { }
    public bool IsValueSetExplicitly { get { return default(bool); } }
    public string Value { get { return default(string); } set { } }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(384), Inherited=false, AllowMultiple=false)]
  public sealed partial class IgnoreDataMemberAttribute : System.Attribute {
    public IgnoreDataMemberAttribute() { }
  }

  public partial class InvalidDataContractException : System.Exception {
    public InvalidDataContractException() { }
    public InvalidDataContractException(string message) { }
    public InvalidDataContractException(string message, System.Exception innerException) { }
  }

  public partial interface ISerializationSurrogateProvider {
    object GetDeserializedObject(object obj, System.Type targetType);
    object GetObjectToSerialize(object obj, System.Type targetType);
    System.Type GetSurrogateType(System.Type type);
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(12), Inherited=true, AllowMultiple=true)]
  public sealed partial class KnownTypeAttribute : System.Attribute {
    public KnownTypeAttribute(string methodName) { }
    public KnownTypeAttribute(System.Type type) { }
    public string MethodName { get { return default(string); } }
    public System.Type Type { get { return default(System.Type); } }
  }

  public abstract partial class DataContractResolver {
    protected DataContractResolver() { }
    public abstract System.Type ResolveName(string typeName, string typeNamespace, System.Type declaredType, System.Runtime.Serialization.DataContractResolver knownTypeResolver);
    public abstract bool TryResolveType(System.Type type, System.Type declaredType, System.Runtime.Serialization.DataContractResolver knownTypeResolver, out System.Xml.XmlDictionaryString typeName, out System.Xml.XmlDictionaryString typeNamespace);
  }

  public sealed partial class DataContractSerializer : System.Runtime.Serialization.XmlObjectSerializer {
    public DataContractSerializer(System.Type type) { }
    public DataContractSerializer(System.Type type, System.Collections.Generic.IEnumerable<System.Type> knownTypes) { }
    public DataContractSerializer(System.Type type, System.Runtime.Serialization.DataContractSerializerSettings settings) { }
    public DataContractSerializer(System.Type type, string rootName, string rootNamespace) { }
    public DataContractSerializer(System.Type type, string rootName, string rootNamespace, System.Collections.Generic.IEnumerable<System.Type> knownTypes) { }
    public DataContractSerializer(System.Type type, System.Xml.XmlDictionaryString rootName, System.Xml.XmlDictionaryString rootNamespace) { }
    public DataContractSerializer(System.Type type, System.Xml.XmlDictionaryString rootName, System.Xml.XmlDictionaryString rootNamespace, System.Collections.Generic.IEnumerable<System.Type> knownTypes) { }
    public bool IgnoreExtensionDataObject { get { return default(bool); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Type> KnownTypes { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Type>); } }
    public int MaxItemsInObjectGraph { get { return default(int); } }
    public bool PreserveObjectReferences { get { return default(bool); } }
    public bool SerializeReadOnlyTypes { get { return default(bool); } }
    public override bool IsStartObject(System.Xml.XmlDictionaryReader reader) { return default(bool); }
    public override bool IsStartObject(System.Xml.XmlReader reader) { return default(bool); }
    public override object ReadObject(System.Xml.XmlDictionaryReader reader, bool verifyObjectName) { return default(object); }
    public override object ReadObject(System.Xml.XmlReader reader) { return default(object); }
    public override object ReadObject(System.Xml.XmlReader reader, bool verifyObjectName) { return default(object); }
    public override void WriteEndObject(System.Xml.XmlDictionaryWriter writer) { }
    public override void WriteEndObject(System.Xml.XmlWriter writer) { }
    public override void WriteObject(System.Xml.XmlWriter writer, object graph) { }
    public override void WriteObjectContent(System.Xml.XmlDictionaryWriter writer, object graph) { }
    public override void WriteObjectContent(System.Xml.XmlWriter writer, object graph) { }
    public override void WriteStartObject(System.Xml.XmlDictionaryWriter writer, object graph) { }
    public override void WriteStartObject(System.Xml.XmlWriter writer, object graph) { }
  }

  public static partial class DataContractSerializerExtensions {
    public static System.Runtime.Serialization.ISerializationSurrogateProvider GetSerializationSurrogateProvider(this System.Runtime.Serialization.DataContractSerializer serializer) { return default(System.Runtime.Serialization.ISerializationSurrogateProvider); }
    public static void SetSerializationSurrogateProvider(this System.Runtime.Serialization.DataContractSerializer serializer, System.Runtime.Serialization.ISerializationSurrogateProvider provider) { }
  }

  public partial class DataContractSerializerSettings {
    public DataContractSerializerSettings() { }
    public System.Runtime.Serialization.DataContractResolver DataContractResolver { get { return default(System.Runtime.Serialization.DataContractResolver); } set { } }
    public System.Collections.Generic.IEnumerable<System.Type> KnownTypes { get { return default(System.Collections.Generic.IEnumerable<System.Type>); } set { } }
    public int MaxItemsInObjectGraph { get { return default(int); } set { } }
    public bool PreserveObjectReferences { get { return default(bool); } set { } }
    public System.Xml.XmlDictionaryString RootName { get { return default(System.Xml.XmlDictionaryString); } set { } }
    public System.Xml.XmlDictionaryString RootNamespace { get { return default(System.Xml.XmlDictionaryString); } set { } }
    public bool SerializeReadOnlyTypes { get { return default(bool); } set { } }
  }

  public abstract partial class XmlObjectSerializer {
    protected XmlObjectSerializer() { }
    public abstract bool IsStartObject(System.Xml.XmlDictionaryReader reader);
    public virtual bool IsStartObject(System.Xml.XmlReader reader) { return default(bool); }
    public virtual object ReadObject(System.IO.Stream stream) { return default(object); }
    public virtual object ReadObject(System.Xml.XmlDictionaryReader reader) { return default(object); }
    public abstract object ReadObject(System.Xml.XmlDictionaryReader reader, bool verifyObjectName);
    public virtual object ReadObject(System.Xml.XmlReader reader) { return default(object); }
    public virtual object ReadObject(System.Xml.XmlReader reader, bool verifyObjectName) { return default(object); }
    public abstract void WriteEndObject(System.Xml.XmlDictionaryWriter writer);
    public virtual void WriteEndObject(System.Xml.XmlWriter writer) { }
    public virtual void WriteObject(System.IO.Stream stream, object graph) { }
    public virtual void WriteObject(System.Xml.XmlDictionaryWriter writer, object graph) { }
    public virtual void WriteObject(System.Xml.XmlWriter writer, object graph) { }
    public abstract void WriteObjectContent(System.Xml.XmlDictionaryWriter writer, object graph);
    public virtual void WriteObjectContent(System.Xml.XmlWriter writer, object graph) { }
    public abstract void WriteStartObject(System.Xml.XmlDictionaryWriter writer, object graph);
    public virtual void WriteStartObject(System.Xml.XmlWriter writer, object graph) { }
  }

} // end of System.Runtime.Serialization
namespace System.Runtime.Serialization.Json {
  public sealed partial class DataContractJsonSerializer {
    public DataContractJsonSerializer(System.Type type) { }
    public DataContractJsonSerializer(System.Type type, System.Collections.Generic.IEnumerable<System.Type> knownTypes) { }
    public DataContractJsonSerializer(System.Type type, System.Runtime.Serialization.Json.DataContractJsonSerializerSettings settings) { }
    public System.Runtime.Serialization.DateTimeFormat DateTimeFormat { get { return default(System.Runtime.Serialization.DateTimeFormat); } }
    public System.Runtime.Serialization.EmitTypeInformation EmitTypeInformation { get { return default(System.Runtime.Serialization.EmitTypeInformation); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Type> KnownTypes { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Type>); } }
    public bool SerializeReadOnlyTypes { get { return default(bool); } }
    public bool UseSimpleDictionaryFormat { get { return default(bool); } }
    public object ReadObject(System.IO.Stream stream) { return default(object); }
    public void WriteObject(System.IO.Stream stream, object graph) { }
  }

  public partial class DataContractJsonSerializerSettings {
    public DataContractJsonSerializerSettings() { }
    public System.Runtime.Serialization.DateTimeFormat DateTimeFormat { get { return default(System.Runtime.Serialization.DateTimeFormat); } set { } }
    public System.Runtime.Serialization.EmitTypeInformation EmitTypeInformation { get { return default(System.Runtime.Serialization.EmitTypeInformation); } set { } }
    public System.Collections.Generic.IEnumerable<System.Type> KnownTypes { get { return default(System.Collections.Generic.IEnumerable<System.Type>); } set { } }
    public int MaxItemsInObjectGraph { get { return default(int); } set { } }
    public string RootName { get { return default(string); } set { } }
    public bool SerializeReadOnlyTypes { get { return default(bool); } set { } }
    public bool UseSimpleDictionaryFormat { get { return default(bool); } set { } }
  }

} // end of System.Runtime.Serialization.Json
namespace System.Xml {
  public partial interface IXmlDictionary {
    bool TryLookup(int key, out System.Xml.XmlDictionaryString result);
    bool TryLookup(string value, out System.Xml.XmlDictionaryString result);
    bool TryLookup(System.Xml.XmlDictionaryString value, out System.Xml.XmlDictionaryString result);
  }

  public delegate void OnXmlDictionaryReaderClose(System.Xml.XmlDictionaryReader reader);

  public partial class UniqueId {
    public UniqueId() { }
    public UniqueId(byte[] guid) { }
    public UniqueId(byte[] guid, int offset) { }
    public UniqueId(char[] chars, int offset, int count) { }
    public UniqueId(System.Guid guid) { }
    public UniqueId(string value) { }
    public int CharArrayLength { get { return default(int); } }
    public bool IsGuid { get { return default(bool); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.Xml.UniqueId id1, System.Xml.UniqueId id2) { return default(bool); }
    public static bool operator !=(System.Xml.UniqueId id1, System.Xml.UniqueId id2) { return default(bool); }
    public int ToCharArray(char[] chars, int offset) { return default(int); }
    public override string ToString() { return default(string); }
    public bool TryGetGuid(byte[] buffer, int offset) { return default(bool); }
    public bool TryGetGuid(out System.Guid guid) { guid = default(System.Guid); return default(bool); }
  }

  public partial class XmlBinaryReaderSession : System.Xml.IXmlDictionary {
    public XmlBinaryReaderSession() { }
    public System.Xml.XmlDictionaryString Add(int id, string value) { return default(System.Xml.XmlDictionaryString); }
    public void Clear() { }
    public bool TryLookup(int key, out System.Xml.XmlDictionaryString result) { result = default(System.Xml.XmlDictionaryString); return default(bool); }
    public bool TryLookup(string value, out System.Xml.XmlDictionaryString result) { result = default(System.Xml.XmlDictionaryString); return default(bool); }
    public bool TryLookup(System.Xml.XmlDictionaryString value, out System.Xml.XmlDictionaryString result) { result = default(System.Xml.XmlDictionaryString); return default(bool); }
  }

  public partial class XmlBinaryWriterSession {
    public XmlBinaryWriterSession() { }
    public void Reset() { }
    public virtual bool TryAdd(System.Xml.XmlDictionaryString value, out int key) { key = default(int); return default(bool); }
  }

  public partial class XmlDictionary : System.Xml.IXmlDictionary {
    public XmlDictionary() { }
    public XmlDictionary(int capacity) { }
    public static System.Xml.IXmlDictionary Empty { get { return default(System.Xml.IXmlDictionary); } }
    public virtual System.Xml.XmlDictionaryString Add(string value) { return default(System.Xml.XmlDictionaryString); }
    public virtual bool TryLookup(int key, out System.Xml.XmlDictionaryString result) { result = default(System.Xml.XmlDictionaryString); return default(bool); }
    public virtual bool TryLookup(string value, out System.Xml.XmlDictionaryString result) { result = default(System.Xml.XmlDictionaryString); return default(bool); }
    public virtual bool TryLookup(System.Xml.XmlDictionaryString value, out System.Xml.XmlDictionaryString result) { result = default(System.Xml.XmlDictionaryString); return default(bool); }
  }

  public abstract partial class XmlDictionaryReader : System.Xml.XmlReader {
    protected XmlDictionaryReader() { }
    public virtual bool CanCanonicalize { get { return default(bool); } }
    public virtual System.Xml.XmlDictionaryReaderQuotas Quotas { get { return default(System.Xml.XmlDictionaryReaderQuotas); } }
    public static System.Xml.XmlDictionaryReader CreateBinaryReader(byte[] buffer, int offset, int count, System.Xml.IXmlDictionary dictionary, System.Xml.XmlDictionaryReaderQuotas quotas) { return default(System.Xml.XmlDictionaryReader); }
    public static System.Xml.XmlDictionaryReader CreateBinaryReader(byte[] buffer, int offset, int count, System.Xml.IXmlDictionary dictionary, System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.XmlBinaryReaderSession session) { return default(System.Xml.XmlDictionaryReader); }
    public static System.Xml.XmlDictionaryReader CreateBinaryReader(byte[] buffer, int offset, int count, System.Xml.XmlDictionaryReaderQuotas quotas) { return default(System.Xml.XmlDictionaryReader); }
    public static System.Xml.XmlDictionaryReader CreateBinaryReader(byte[] buffer, System.Xml.XmlDictionaryReaderQuotas quotas) { return default(System.Xml.XmlDictionaryReader); }
    public static System.Xml.XmlDictionaryReader CreateBinaryReader(System.IO.Stream stream, System.Xml.IXmlDictionary dictionary, System.Xml.XmlDictionaryReaderQuotas quotas) { return default(System.Xml.XmlDictionaryReader); }
    public static System.Xml.XmlDictionaryReader CreateBinaryReader(System.IO.Stream stream, System.Xml.IXmlDictionary dictionary, System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.XmlBinaryReaderSession session) { return default(System.Xml.XmlDictionaryReader); }
    public static System.Xml.XmlDictionaryReader CreateBinaryReader(System.IO.Stream stream, System.Xml.XmlDictionaryReaderQuotas quotas) { return default(System.Xml.XmlDictionaryReader); }
    public static System.Xml.XmlDictionaryReader CreateDictionaryReader(System.Xml.XmlReader reader) { return default(System.Xml.XmlDictionaryReader); }
    public static System.Xml.XmlDictionaryReader CreateTextReader(byte[] buffer, int offset, int count, System.Xml.XmlDictionaryReaderQuotas quotas) { return default(System.Xml.XmlDictionaryReader); }
    public static System.Xml.XmlDictionaryReader CreateTextReader(byte[] buffer, System.Xml.XmlDictionaryReaderQuotas quotas) { return default(System.Xml.XmlDictionaryReader); }
    public static System.Xml.XmlDictionaryReader CreateTextReader(System.IO.Stream stream, System.Text.Encoding encoding, System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.OnXmlDictionaryReaderClose onClose) { return default(System.Xml.XmlDictionaryReader); }
    public static System.Xml.XmlDictionaryReader CreateTextReader(System.IO.Stream stream, System.Xml.XmlDictionaryReaderQuotas quotas) { return default(System.Xml.XmlDictionaryReader); }
    public virtual void EndCanonicalization() { }
    public virtual string GetAttribute(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { return default(string); }
    public virtual int IndexOfLocalName(string[] localNames, string namespaceUri) { return default(int); }
    public virtual int IndexOfLocalName(System.Xml.XmlDictionaryString[] localNames, System.Xml.XmlDictionaryString namespaceUri) { return default(int); }
    public virtual bool IsLocalName(string localName) { return default(bool); }
    public virtual bool IsLocalName(System.Xml.XmlDictionaryString localName) { return default(bool); }
    public virtual bool IsNamespaceUri(string namespaceUri) { return default(bool); }
    public virtual bool IsNamespaceUri(System.Xml.XmlDictionaryString namespaceUri) { return default(bool); }
    public virtual bool IsStartArray(out System.Type type) { type = default(System.Type); return default(bool); }
    public virtual bool IsStartElement(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { return default(bool); }
    protected bool IsTextNode(System.Xml.XmlNodeType nodeType) { return default(bool); }
    public virtual void MoveToStartElement() { }
    public virtual void MoveToStartElement(string name) { }
    public virtual void MoveToStartElement(string localName, string namespaceUri) { }
    public virtual void MoveToStartElement(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { }
    public virtual int ReadArray(string localName, string namespaceUri, bool[] array, int offset, int count) { return default(int); }
    public virtual int ReadArray(string localName, string namespaceUri, System.DateTime[] array, int offset, int count) { return default(int); }
    public virtual int ReadArray(string localName, string namespaceUri, decimal[] array, int offset, int count) { return default(int); }
    public virtual int ReadArray(string localName, string namespaceUri, double[] array, int offset, int count) { return default(int); }
    public virtual int ReadArray(string localName, string namespaceUri, System.Guid[] array, int offset, int count) { return default(int); }
    public virtual int ReadArray(string localName, string namespaceUri, short[] array, int offset, int count) { return default(int); }
    public virtual int ReadArray(string localName, string namespaceUri, int[] array, int offset, int count) { return default(int); }
    public virtual int ReadArray(string localName, string namespaceUri, long[] array, int offset, int count) { return default(int); }
    public virtual int ReadArray(string localName, string namespaceUri, float[] array, int offset, int count) { return default(int); }
    public virtual int ReadArray(string localName, string namespaceUri, System.TimeSpan[] array, int offset, int count) { return default(int); }
    public virtual int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, bool[] array, int offset, int count) { return default(int); }
    public virtual int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.DateTime[] array, int offset, int count) { return default(int); }
    public virtual int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, decimal[] array, int offset, int count) { return default(int); }
    public virtual int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, double[] array, int offset, int count) { return default(int); }
    public virtual int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.Guid[] array, int offset, int count) { return default(int); }
    public virtual int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, short[] array, int offset, int count) { return default(int); }
    public virtual int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, int[] array, int offset, int count) { return default(int); }
    public virtual int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, long[] array, int offset, int count) { return default(int); }
    public virtual int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, float[] array, int offset, int count) { return default(int); }
    public virtual int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.TimeSpan[] array, int offset, int count) { return default(int); }
    public virtual bool[] ReadBooleanArray(string localName, string namespaceUri) { return default(bool[]); }
    public virtual bool[] ReadBooleanArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { return default(bool[]); }
    public override object ReadContentAs(System.Type type, System.Xml.IXmlNamespaceResolver namespaceResolver) { return default(object); }
    public virtual byte[] ReadContentAsBase64() { return default(byte[]); }
    public virtual byte[] ReadContentAsBinHex() { return default(byte[]); }
    protected byte[] ReadContentAsBinHex(int maxByteArrayContentLength) { return default(byte[]); }
    public virtual int ReadContentAsChars(char[] chars, int offset, int count) { return default(int); }
    public override decimal ReadContentAsDecimal() { return default(decimal); }
    public override float ReadContentAsFloat() { return default(float); }
    public virtual System.Guid ReadContentAsGuid() { return default(System.Guid); }
    public virtual void ReadContentAsQualifiedName(out string localName, out string namespaceUri) { localName = default(string); namespaceUri = default(string); }
    public override string ReadContentAsString() { return default(string); }
    protected string ReadContentAsString(int maxStringContentLength) { return default(string); }
    public virtual string ReadContentAsString(string[] strings, out int index) { index = default(int); return default(string); }
    public virtual string ReadContentAsString(System.Xml.XmlDictionaryString[] strings, out int index) { index = default(int); return default(string); }
    public virtual System.TimeSpan ReadContentAsTimeSpan() { return default(System.TimeSpan); }
    public virtual System.Xml.UniqueId ReadContentAsUniqueId() { return default(System.Xml.UniqueId); }
    public virtual System.DateTime[] ReadDateTimeArray(string localName, string namespaceUri) { return default(System.DateTime[]); }
    public virtual System.DateTime[] ReadDateTimeArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { return default(System.DateTime[]); }
    public virtual decimal[] ReadDecimalArray(string localName, string namespaceUri) { return default(decimal[]); }
    public virtual decimal[] ReadDecimalArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { return default(decimal[]); }
    public virtual double[] ReadDoubleArray(string localName, string namespaceUri) { return default(double[]); }
    public virtual double[] ReadDoubleArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { return default(double[]); }
    public virtual byte[] ReadElementContentAsBase64() { return default(byte[]); }
    public virtual byte[] ReadElementContentAsBinHex() { return default(byte[]); }
    public override bool ReadElementContentAsBoolean() { return default(bool); }
    public override decimal ReadElementContentAsDecimal() { return default(decimal); }
    public override double ReadElementContentAsDouble() { return default(double); }
    public override float ReadElementContentAsFloat() { return default(float); }
    public virtual System.Guid ReadElementContentAsGuid() { return default(System.Guid); }
    public override int ReadElementContentAsInt() { return default(int); }
    public override long ReadElementContentAsLong() { return default(long); }
    public override string ReadElementContentAsString() { return default(string); }
    public virtual System.TimeSpan ReadElementContentAsTimeSpan() { return default(System.TimeSpan); }
    public virtual System.Xml.UniqueId ReadElementContentAsUniqueId() { return default(System.Xml.UniqueId); }
    public virtual void ReadFullStartElement() { }
    public virtual void ReadFullStartElement(string name) { }
    public virtual void ReadFullStartElement(string localName, string namespaceUri) { }
    public virtual void ReadFullStartElement(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { }
    public virtual System.Guid[] ReadGuidArray(string localName, string namespaceUri) { return default(System.Guid[]); }
    public virtual System.Guid[] ReadGuidArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { return default(System.Guid[]); }
    public virtual short[] ReadInt16Array(string localName, string namespaceUri) { return default(short[]); }
    public virtual short[] ReadInt16Array(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { return default(short[]); }
    public virtual int[] ReadInt32Array(string localName, string namespaceUri) { return default(int[]); }
    public virtual int[] ReadInt32Array(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { return default(int[]); }
    public virtual long[] ReadInt64Array(string localName, string namespaceUri) { return default(long[]); }
    public virtual long[] ReadInt64Array(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { return default(long[]); }
    public virtual float[] ReadSingleArray(string localName, string namespaceUri) { return default(float[]); }
    public virtual float[] ReadSingleArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { return default(float[]); }
    public virtual void ReadStartElement(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { }
    public virtual System.TimeSpan[] ReadTimeSpanArray(string localName, string namespaceUri) { return default(System.TimeSpan[]); }
    public virtual System.TimeSpan[] ReadTimeSpanArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { return default(System.TimeSpan[]); }
    public virtual int ReadValueAsBase64(byte[] buffer, int offset, int count) { return default(int); }
    public virtual void StartCanonicalization(System.IO.Stream stream, bool includeComments, string[] inclusivePrefixes) { }
    public virtual bool TryGetArrayLength(out int count) { count = default(int); return default(bool); }
    public virtual bool TryGetBase64ContentLength(out int length) { length = default(int); return default(bool); }
    public virtual bool TryGetLocalNameAsDictionaryString(out System.Xml.XmlDictionaryString localName) { localName = default(System.Xml.XmlDictionaryString); return default(bool); }
    public virtual bool TryGetNamespaceUriAsDictionaryString(out System.Xml.XmlDictionaryString namespaceUri) { namespaceUri = default(System.Xml.XmlDictionaryString); return default(bool); }
    public virtual bool TryGetValueAsDictionaryString(out System.Xml.XmlDictionaryString value) { value = default(System.Xml.XmlDictionaryString); return default(bool); }
  }

  public sealed partial class XmlDictionaryReaderQuotas {
    public XmlDictionaryReaderQuotas() { }
    public static System.Xml.XmlDictionaryReaderQuotas Max { get { return default(System.Xml.XmlDictionaryReaderQuotas); } }
    [System.ComponentModel.DefaultValueAttribute(16384)]
    public int MaxArrayLength { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute(4096)]
    public int MaxBytesPerRead { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute(32)]
    public int MaxDepth { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute(16384)]
    public int MaxNameTableCharCount { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute(8192)]
    public int MaxStringContentLength { get { return default(int); } set { } }
    public System.Xml.XmlDictionaryReaderQuotaTypes ModifiedQuotas { get { return default(System.Xml.XmlDictionaryReaderQuotaTypes); } }
    public void CopyTo(System.Xml.XmlDictionaryReaderQuotas quotas) { }
  }

  [System.FlagsAttribute]
  public enum XmlDictionaryReaderQuotaTypes {
    MaxArrayLength = 4,
    MaxBytesPerRead = 8,
    MaxDepth = 1,
    MaxNameTableCharCount = 16,
    MaxStringContentLength = 2,
  }

  public partial class XmlDictionaryString {
    public XmlDictionaryString(System.Xml.IXmlDictionary dictionary, string value, int key) { }
    public System.Xml.IXmlDictionary Dictionary { get { return default(System.Xml.IXmlDictionary); } }
    public static System.Xml.XmlDictionaryString Empty { get { return default(System.Xml.XmlDictionaryString); } }
    public int Key { get { return default(int); } }
    public string Value { get { return default(string); } }
    public override string ToString() { return default(string); }
  }

  public abstract partial class XmlDictionaryWriter : System.Xml.XmlWriter {
    protected XmlDictionaryWriter() { }
    public virtual bool CanCanonicalize { get { return default(bool); } }
    public static System.Xml.XmlDictionaryWriter CreateBinaryWriter(System.IO.Stream stream) { return default(System.Xml.XmlDictionaryWriter); }
    public static System.Xml.XmlDictionaryWriter CreateBinaryWriter(System.IO.Stream stream, System.Xml.IXmlDictionary dictionary) { return default(System.Xml.XmlDictionaryWriter); }
    public static System.Xml.XmlDictionaryWriter CreateBinaryWriter(System.IO.Stream stream, System.Xml.IXmlDictionary dictionary, System.Xml.XmlBinaryWriterSession session) { return default(System.Xml.XmlDictionaryWriter); }
    public static System.Xml.XmlDictionaryWriter CreateBinaryWriter(System.IO.Stream stream, System.Xml.IXmlDictionary dictionary, System.Xml.XmlBinaryWriterSession session, bool ownsStream) { return default(System.Xml.XmlDictionaryWriter); }
    public static System.Xml.XmlDictionaryWriter CreateDictionaryWriter(System.Xml.XmlWriter writer) { return default(System.Xml.XmlDictionaryWriter); }
    public static System.Xml.XmlDictionaryWriter CreateTextWriter(System.IO.Stream stream) { return default(System.Xml.XmlDictionaryWriter); }
    public static System.Xml.XmlDictionaryWriter CreateTextWriter(System.IO.Stream stream, System.Text.Encoding encoding) { return default(System.Xml.XmlDictionaryWriter); }
    public static System.Xml.XmlDictionaryWriter CreateTextWriter(System.IO.Stream stream, System.Text.Encoding encoding, bool ownsStream) { return default(System.Xml.XmlDictionaryWriter); }
    public virtual void EndCanonicalization() { }
    public virtual void StartCanonicalization(System.IO.Stream stream, bool includeComments, string[] inclusivePrefixes) { }
    public virtual void WriteArray(string prefix, string localName, string namespaceUri, bool[] array, int offset, int count) { }
    public virtual void WriteArray(string prefix, string localName, string namespaceUri, System.DateTime[] array, int offset, int count) { }
    public virtual void WriteArray(string prefix, string localName, string namespaceUri, decimal[] array, int offset, int count) { }
    public virtual void WriteArray(string prefix, string localName, string namespaceUri, double[] array, int offset, int count) { }
    public virtual void WriteArray(string prefix, string localName, string namespaceUri, System.Guid[] array, int offset, int count) { }
    public virtual void WriteArray(string prefix, string localName, string namespaceUri, short[] array, int offset, int count) { }
    public virtual void WriteArray(string prefix, string localName, string namespaceUri, int[] array, int offset, int count) { }
    public virtual void WriteArray(string prefix, string localName, string namespaceUri, long[] array, int offset, int count) { }
    public virtual void WriteArray(string prefix, string localName, string namespaceUri, float[] array, int offset, int count) { }
    public virtual void WriteArray(string prefix, string localName, string namespaceUri, System.TimeSpan[] array, int offset, int count) { }
    public virtual void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, bool[] array, int offset, int count) { }
    public virtual void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.DateTime[] array, int offset, int count) { }
    public virtual void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, decimal[] array, int offset, int count) { }
    public virtual void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, double[] array, int offset, int count) { }
    public virtual void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.Guid[] array, int offset, int count) { }
    public virtual void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, short[] array, int offset, int count) { }
    public virtual void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, int[] array, int offset, int count) { }
    public virtual void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, long[] array, int offset, int count) { }
    public virtual void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, float[] array, int offset, int count) { }
    public virtual void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.TimeSpan[] array, int offset, int count) { }
    public void WriteAttributeString(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, string value) { }
    public void WriteAttributeString(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, string value) { }
    public void WriteElementString(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, string value) { }
    public void WriteElementString(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, string value) { }
    public virtual void WriteNode(System.Xml.XmlDictionaryReader reader, bool defattr) { }
    public override void WriteNode(System.Xml.XmlReader reader, bool defattr) { }
    public virtual void WriteQualifiedName(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { }
    public virtual void WriteStartAttribute(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { }
    public void WriteStartAttribute(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { }
    public virtual void WriteStartElement(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { }
    public void WriteStartElement(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { }
    public virtual void WriteString(System.Xml.XmlDictionaryString value) { }
    protected virtual void WriteTextNode(System.Xml.XmlDictionaryReader reader, bool isAttribute) { }
    public virtual void WriteValue(System.Guid value) { }
    public virtual void WriteValue(System.TimeSpan value) { }
    public virtual void WriteValue(System.Xml.UniqueId value) { }
    public virtual void WriteValue(System.Xml.XmlDictionaryString value) { }
    public virtual void WriteXmlAttribute(string localName, string value) { }
    public virtual void WriteXmlAttribute(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString value) { }
    public virtual void WriteXmlnsAttribute(string prefix, string namespaceUri) { }
    public virtual void WriteXmlnsAttribute(string prefix, System.Xml.XmlDictionaryString namespaceUri) { }
  }

  public enum ConformanceLevel {
    Auto = 0,
    Document = 2,
    Fragment = 1,
  }

  public enum DtdProcessing {
    Ignore = 1,
    Prohibit = 0,
  }

  public partial interface IXmlLineInfo {
    int LineNumber { get; }
    int LinePosition { get; }
    bool HasLineInfo();
  }

  public partial interface IXmlNamespaceResolver {
    System.Collections.Generic.IDictionary<string, string> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
    string LookupNamespace(string prefix);
    string LookupPrefix(string namespaceName);
  }

  [System.FlagsAttribute]
  public enum NamespaceHandling {
    Default = 0,
    OmitDuplicates = 1,
  }

  public partial class NameTable : System.Xml.XmlNameTable {
    public NameTable() { }
    public override string Add(char[] key, int start, int len) { return default(string); }
    public override string Add(string key) { return default(string); }
    public override string Get(char[] key, int start, int len) { return default(string); }
    public override string Get(string value) { return default(string); }
  }

  public enum NewLineHandling {
    Entitize = 1,
    None = 2,
    Replace = 0,
  }

  public enum ReadState {
    Closed = 4,
    EndOfFile = 3,
    Error = 2,
    Initial = 0,
    Interactive = 1,
  }

  public enum WriteState {
    Attribute = 3,
    Closed = 5,
    Content = 4,
    Element = 2,
    Error = 6,
    Prolog = 1,
    Start = 0,
  }

  public static partial class XmlConvert {
    public static string DecodeName(string name) { return default(string); }
    public static string EncodeLocalName(string name) { return default(string); }
    public static string EncodeName(string name) { return default(string); }
    public static string EncodeNmToken(string name) { return default(string); }
    public static bool ToBoolean(string s) { return default(bool); }
    public static byte ToByte(string s) { return default(byte); }
    public static char ToChar(string s) { return default(char); }
    public static System.DateTime ToDateTime(string s, System.Xml.XmlDateTimeSerializationMode dateTimeOption) { return default(System.DateTime); }
    public static System.DateTimeOffset ToDateTimeOffset(string s) { return default(System.DateTimeOffset); }
    public static System.DateTimeOffset ToDateTimeOffset(string s, string format) { return default(System.DateTimeOffset); }
    public static System.DateTimeOffset ToDateTimeOffset(string s, string[] formats) { return default(System.DateTimeOffset); }
    public static decimal ToDecimal(string s) { return default(decimal); }
    public static double ToDouble(string s) { return default(double); }
    public static System.Guid ToGuid(string s) { return default(System.Guid); }
    public static short ToInt16(string s) { return default(short); }
    public static int ToInt32(string s) { return default(int); }
    public static long ToInt64(string s) { return default(long); }
    [System.CLSCompliantAttribute(false)]
    public static sbyte ToSByte(string s) { return default(sbyte); }
    public static float ToSingle(string s) { return default(float); }
    public static string ToString(bool value) { return default(string); }
    public static string ToString(byte value) { return default(string); }
    public static string ToString(char value) { return default(string); }
    public static string ToString(System.DateTime value, System.Xml.XmlDateTimeSerializationMode dateTimeOption) { return default(string); }
    public static string ToString(System.DateTimeOffset value) { return default(string); }
    public static string ToString(System.DateTimeOffset value, string format) { return default(string); }
    public static string ToString(decimal value) { return default(string); }
    public static string ToString(double value) { return default(string); }
    public static string ToString(System.Guid value) { return default(string); }
    public static string ToString(short value) { return default(string); }
    public static string ToString(int value) { return default(string); }
    public static string ToString(long value) { return default(string); }
    [System.CLSCompliantAttribute(false)]
    public static string ToString(sbyte value) { return default(string); }
    public static string ToString(float value) { return default(string); }
    public static string ToString(System.TimeSpan value) { return default(string); }
    [System.CLSCompliantAttribute(false)]
    public static string ToString(ushort value) { return default(string); }
    [System.CLSCompliantAttribute(false)]
    public static string ToString(uint value) { return default(string); }
    [System.CLSCompliantAttribute(false)]
    public static string ToString(ulong value) { return default(string); }
    public static System.TimeSpan ToTimeSpan(string s) { return default(System.TimeSpan); }
    [System.CLSCompliantAttribute(false)]
    public static ushort ToUInt16(string s) { return default(ushort); }
    [System.CLSCompliantAttribute(false)]
    public static uint ToUInt32(string s) { return default(uint); }
    [System.CLSCompliantAttribute(false)]
    public static ulong ToUInt64(string s) { return default(ulong); }
    public static string VerifyName(string name) { return default(string); }
    public static string VerifyNCName(string name) { return default(string); }
    public static string VerifyNMTOKEN(string name) { return default(string); }
    public static string VerifyPublicId(string publicId) { return default(string); }
    public static string VerifyWhitespace(string content) { return default(string); }
    public static string VerifyXmlChars(string content) { return default(string); }
  }

  public enum XmlDateTimeSerializationMode {
    Local = 0,
    RoundtripKind = 3,
    Unspecified = 2,
    Utc = 1,
  }

  public partial class XmlException : System.Exception {
    public XmlException() { }
    public XmlException(string message) { }
    public XmlException(string message, System.Exception innerException) { }
    public XmlException(string message, System.Exception innerException, int lineNumber, int linePosition) { }
    public int LineNumber { get { return default(int); } }
    public int LinePosition { get { return default(int); } }
    public override string Message { get { return default(string); } }
  }

  public partial class XmlNamespaceManager : System.Collections.IEnumerable, System.Xml.IXmlNamespaceResolver {
    public XmlNamespaceManager(System.Xml.XmlNameTable nameTable) { }
    public virtual string DefaultNamespace { get { return default(string); } }
    public virtual System.Xml.XmlNameTable NameTable { get { return default(System.Xml.XmlNameTable); } }
    public virtual void AddNamespace(string prefix, string uri) { }
    public virtual System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public virtual System.Collections.Generic.IDictionary<string, string> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope) { return default(System.Collections.Generic.IDictionary<string, string>); }
    public virtual bool HasNamespace(string prefix) { return default(bool); }
    public virtual string LookupNamespace(string prefix) { return default(string); }
    public virtual string LookupPrefix(string uri) { return default(string); }
    public virtual bool PopScope() { return default(bool); }
    public virtual void PushScope() { }
    public virtual void RemoveNamespace(string prefix, string uri) { }
  }

  public enum XmlNamespaceScope {
    All = 0,
    ExcludeXml = 1,
    Local = 2,
  }

  public abstract partial class XmlNameTable {
    protected XmlNameTable() { }
    public abstract string Add(char[] array, int offset, int length);
    public abstract string Add(string array);
    public abstract string Get(char[] array, int offset, int length);
    public abstract string Get(string array);
  }

  public enum XmlNodeType {
    Attribute = 2,
    CDATA = 4,
    Comment = 8,
    Document = 9,
    DocumentFragment = 11,
    DocumentType = 10,
    Element = 1,
    EndElement = 15,
    EndEntity = 16,
    Entity = 6,
    EntityReference = 5,
    None = 0,
    Notation = 12,
    ProcessingInstruction = 7,
    SignificantWhitespace = 14,
    Text = 3,
    Whitespace = 13,
    XmlDeclaration = 17,
  }

  public partial class XmlParserContext {
    public XmlParserContext(System.Xml.XmlNameTable nt, System.Xml.XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, System.Xml.XmlSpace xmlSpace) { }
    public XmlParserContext(System.Xml.XmlNameTable nt, System.Xml.XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, System.Xml.XmlSpace xmlSpace, System.Text.Encoding enc) { }
    public XmlParserContext(System.Xml.XmlNameTable nt, System.Xml.XmlNamespaceManager nsMgr, string xmlLang, System.Xml.XmlSpace xmlSpace) { }
    public XmlParserContext(System.Xml.XmlNameTable nt, System.Xml.XmlNamespaceManager nsMgr, string xmlLang, System.Xml.XmlSpace xmlSpace, System.Text.Encoding enc) { }
    public string BaseURI { get { return default(string); } set { } }
    public string DocTypeName { get { return default(string); } set { } }
    public System.Text.Encoding Encoding { get { return default(System.Text.Encoding); } set { } }
    public string InternalSubset { get { return default(string); } set { } }
    public System.Xml.XmlNamespaceManager NamespaceManager { get { return default(System.Xml.XmlNamespaceManager); } set { } }
    public System.Xml.XmlNameTable NameTable { get { return default(System.Xml.XmlNameTable); } set { } }
    public string PublicId { get { return default(string); } set { } }
    public string SystemId { get { return default(string); } set { } }
    public string XmlLang { get { return default(string); } set { } }
    public System.Xml.XmlSpace XmlSpace { get { return default(System.Xml.XmlSpace); } set { } }
  }

  public partial class XmlQualifiedName {
    public static readonly System.Xml.XmlQualifiedName Empty;
    public XmlQualifiedName() { }
    public XmlQualifiedName(string name) { }
    public XmlQualifiedName(string name, string ns) { }
    public bool IsEmpty { get { return default(bool); } }
    public string Name { get { return default(string); } }
    public string Namespace { get { return default(string); } }
    public override bool Equals(object other) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.Xml.XmlQualifiedName a, System.Xml.XmlQualifiedName b) { return default(bool); }
    public static bool operator !=(System.Xml.XmlQualifiedName a, System.Xml.XmlQualifiedName b) { return default(bool); }
    public override string ToString() { return default(string); }
    public static string ToString(string name, string ns) { return default(string); }
  }

  public abstract partial class XmlReader : System.IDisposable {
    protected XmlReader() { }
    public abstract int AttributeCount { get; }
    public abstract string BaseURI { get; }
    public virtual bool CanReadBinaryContent { get { return default(bool); } }
    public virtual bool CanReadValueChunk { get { return default(bool); } }
    public virtual bool CanResolveEntity { get { return default(bool); } }
    public abstract int Depth { get; }
    public abstract bool EOF { get; }
    public virtual bool HasAttributes { get { return default(bool); } }
    public virtual bool HasValue { get { return default(bool); } }
    public virtual bool IsDefault { get { return default(bool); } }
    public abstract bool IsEmptyElement { get; }
    public virtual string this[int i] { get { return default(string); } }
    public virtual string this[string name] { get { return default(string); } }
    public virtual string this[string name, string namespaceURI] { get { return default(string); } }
    public abstract string LocalName { get; }
    public virtual string Name { get { return default(string); } }
    public abstract string NamespaceURI { get; }
    public abstract System.Xml.XmlNameTable NameTable { get; }
    public abstract System.Xml.XmlNodeType NodeType { get; }
    public abstract string Prefix { get; }
    public abstract System.Xml.ReadState ReadState { get; }
    public virtual System.Xml.XmlReaderSettings Settings { get { return default(System.Xml.XmlReaderSettings); } }
    public abstract string Value { get; }
    public virtual System.Type ValueType { get { return default(System.Type); } }
    public virtual string XmlLang { get { return default(string); } }
    public virtual System.Xml.XmlSpace XmlSpace { get { return default(System.Xml.XmlSpace); } }
    public static System.Xml.XmlReader Create(System.IO.Stream input) { return default(System.Xml.XmlReader); }
    public static System.Xml.XmlReader Create(System.IO.Stream input, System.Xml.XmlReaderSettings settings) { return default(System.Xml.XmlReader); }
    public static System.Xml.XmlReader Create(System.IO.Stream input, System.Xml.XmlReaderSettings settings, System.Xml.XmlParserContext inputContext) { return default(System.Xml.XmlReader); }
    public static System.Xml.XmlReader Create(System.IO.TextReader input) { return default(System.Xml.XmlReader); }
    public static System.Xml.XmlReader Create(System.IO.TextReader input, System.Xml.XmlReaderSettings settings) { return default(System.Xml.XmlReader); }
    public static System.Xml.XmlReader Create(System.IO.TextReader input, System.Xml.XmlReaderSettings settings, System.Xml.XmlParserContext inputContext) { return default(System.Xml.XmlReader); }
    public static System.Xml.XmlReader Create(string inputUri) { return default(System.Xml.XmlReader); }
    public static System.Xml.XmlReader Create(string inputUri, System.Xml.XmlReaderSettings settings) { return default(System.Xml.XmlReader); }
    public static System.Xml.XmlReader Create(System.Xml.XmlReader reader, System.Xml.XmlReaderSettings settings) { return default(System.Xml.XmlReader); }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public abstract string GetAttribute(int i);
    public abstract string GetAttribute(string name);
    public abstract string GetAttribute(string name, string namespaceURI);
    public virtual System.Threading.Tasks.Task<string> GetValueAsync() { return default(System.Threading.Tasks.Task<string>); }
    public static bool IsName(string str) { return default(bool); }
    public static bool IsNameToken(string str) { return default(bool); }
    public virtual bool IsStartElement() { return default(bool); }
    public virtual bool IsStartElement(string name) { return default(bool); }
    public virtual bool IsStartElement(string localname, string ns) { return default(bool); }
    public abstract string LookupNamespace(string prefix);
    public virtual void MoveToAttribute(int i) { }
    public abstract bool MoveToAttribute(string name);
    public abstract bool MoveToAttribute(string name, string ns);
    public virtual System.Xml.XmlNodeType MoveToContent() { return default(System.Xml.XmlNodeType); }
    public virtual System.Threading.Tasks.Task<System.Xml.XmlNodeType> MoveToContentAsync() { return default(System.Threading.Tasks.Task<System.Xml.XmlNodeType>); }
    public abstract bool MoveToElement();
    public abstract bool MoveToFirstAttribute();
    public abstract bool MoveToNextAttribute();
    public abstract bool Read();
    public virtual System.Threading.Tasks.Task<bool> ReadAsync() { return default(System.Threading.Tasks.Task<bool>); }
    public abstract bool ReadAttributeValue();
    public virtual object ReadContentAs(System.Type returnType, System.Xml.IXmlNamespaceResolver namespaceResolver) { return default(object); }
    public virtual System.Threading.Tasks.Task<object> ReadContentAsAsync(System.Type returnType, System.Xml.IXmlNamespaceResolver namespaceResolver) { return default(System.Threading.Tasks.Task<object>); }
    public virtual int ReadContentAsBase64(byte[] buffer, int index, int count) { return default(int); }
    public virtual System.Threading.Tasks.Task<int> ReadContentAsBase64Async(byte[] buffer, int index, int count) { return default(System.Threading.Tasks.Task<int>); }
    public virtual int ReadContentAsBinHex(byte[] buffer, int index, int count) { return default(int); }
    public virtual System.Threading.Tasks.Task<int> ReadContentAsBinHexAsync(byte[] buffer, int index, int count) { return default(System.Threading.Tasks.Task<int>); }
    public virtual bool ReadContentAsBoolean() { return default(bool); }
    public virtual System.DateTimeOffset ReadContentAsDateTimeOffset() { return default(System.DateTimeOffset); }
    public virtual decimal ReadContentAsDecimal() { return default(decimal); }
    public virtual double ReadContentAsDouble() { return default(double); }
    public virtual float ReadContentAsFloat() { return default(float); }
    public virtual int ReadContentAsInt() { return default(int); }
    public virtual long ReadContentAsLong() { return default(long); }
    public virtual object ReadContentAsObject() { return default(object); }
    public virtual System.Threading.Tasks.Task<object> ReadContentAsObjectAsync() { return default(System.Threading.Tasks.Task<object>); }
    public virtual string ReadContentAsString() { return default(string); }
    public virtual System.Threading.Tasks.Task<string> ReadContentAsStringAsync() { return default(System.Threading.Tasks.Task<string>); }
    public virtual object ReadElementContentAs(System.Type returnType, System.Xml.IXmlNamespaceResolver namespaceResolver) { return default(object); }
    public virtual object ReadElementContentAs(System.Type returnType, System.Xml.IXmlNamespaceResolver namespaceResolver, string localName, string namespaceURI) { return default(object); }
    public virtual System.Threading.Tasks.Task<object> ReadElementContentAsAsync(System.Type returnType, System.Xml.IXmlNamespaceResolver namespaceResolver) { return default(System.Threading.Tasks.Task<object>); }
    public virtual int ReadElementContentAsBase64(byte[] buffer, int index, int count) { return default(int); }
    public virtual System.Threading.Tasks.Task<int> ReadElementContentAsBase64Async(byte[] buffer, int index, int count) { return default(System.Threading.Tasks.Task<int>); }
    public virtual int ReadElementContentAsBinHex(byte[] buffer, int index, int count) { return default(int); }
    public virtual System.Threading.Tasks.Task<int> ReadElementContentAsBinHexAsync(byte[] buffer, int index, int count) { return default(System.Threading.Tasks.Task<int>); }
    public virtual bool ReadElementContentAsBoolean() { return default(bool); }
    public virtual bool ReadElementContentAsBoolean(string localName, string namespaceURI) { return default(bool); }
    public virtual decimal ReadElementContentAsDecimal() { return default(decimal); }
    public virtual decimal ReadElementContentAsDecimal(string localName, string namespaceURI) { return default(decimal); }
    public virtual double ReadElementContentAsDouble() { return default(double); }
    public virtual double ReadElementContentAsDouble(string localName, string namespaceURI) { return default(double); }
    public virtual float ReadElementContentAsFloat() { return default(float); }
    public virtual float ReadElementContentAsFloat(string localName, string namespaceURI) { return default(float); }
    public virtual int ReadElementContentAsInt() { return default(int); }
    public virtual int ReadElementContentAsInt(string localName, string namespaceURI) { return default(int); }
    public virtual long ReadElementContentAsLong() { return default(long); }
    public virtual long ReadElementContentAsLong(string localName, string namespaceURI) { return default(long); }
    public virtual object ReadElementContentAsObject() { return default(object); }
    public virtual object ReadElementContentAsObject(string localName, string namespaceURI) { return default(object); }
    public virtual System.Threading.Tasks.Task<object> ReadElementContentAsObjectAsync() { return default(System.Threading.Tasks.Task<object>); }
    public virtual string ReadElementContentAsString() { return default(string); }
    public virtual string ReadElementContentAsString(string localName, string namespaceURI) { return default(string); }
    public virtual System.Threading.Tasks.Task<string> ReadElementContentAsStringAsync() { return default(System.Threading.Tasks.Task<string>); }
    public virtual void ReadEndElement() { }
    public virtual string ReadInnerXml() { return default(string); }
    public virtual System.Threading.Tasks.Task<string> ReadInnerXmlAsync() { return default(System.Threading.Tasks.Task<string>); }
    public virtual string ReadOuterXml() { return default(string); }
    public virtual System.Threading.Tasks.Task<string> ReadOuterXmlAsync() { return default(System.Threading.Tasks.Task<string>); }
    public virtual void ReadStartElement() { }
    public virtual void ReadStartElement(string name) { }
    public virtual void ReadStartElement(string localname, string ns) { }
    public virtual System.Xml.XmlReader ReadSubtree() { return default(System.Xml.XmlReader); }
    public virtual bool ReadToDescendant(string name) { return default(bool); }
    public virtual bool ReadToDescendant(string localName, string namespaceURI) { return default(bool); }
    public virtual bool ReadToFollowing(string name) { return default(bool); }
    public virtual bool ReadToFollowing(string localName, string namespaceURI) { return default(bool); }
    public virtual bool ReadToNextSibling(string name) { return default(bool); }
    public virtual bool ReadToNextSibling(string localName, string namespaceURI) { return default(bool); }
    public virtual int ReadValueChunk(char[] buffer, int index, int count) { return default(int); }
    public virtual System.Threading.Tasks.Task<int> ReadValueChunkAsync(char[] buffer, int index, int count) { return default(System.Threading.Tasks.Task<int>); }
    public abstract void ResolveEntity();
    public virtual void Skip() { }
    public virtual System.Threading.Tasks.Task SkipAsync() { return default(System.Threading.Tasks.Task); }
  }

  public sealed partial class XmlReaderSettings {
    public XmlReaderSettings() { }
    public bool Async { get { return default(bool); } set { } }
    public bool CheckCharacters { get { return default(bool); } set { } }
    public bool CloseInput { get { return default(bool); } set { } }
    public System.Xml.ConformanceLevel ConformanceLevel { get { return default(System.Xml.ConformanceLevel); } set { } }
    public System.Xml.DtdProcessing DtdProcessing { get { return default(System.Xml.DtdProcessing); } set { } }
    public bool IgnoreComments { get { return default(bool); } set { } }
    public bool IgnoreProcessingInstructions { get { return default(bool); } set { } }
    public bool IgnoreWhitespace { get { return default(bool); } set { } }
    public int LineNumberOffset { get { return default(int); } set { } }
    public int LinePositionOffset { get { return default(int); } set { } }
    public long MaxCharactersFromEntities { get { return default(long); } set { } }
    public long MaxCharactersInDocument { get { return default(long); } set { } }
    public System.Xml.XmlNameTable NameTable { get { return default(System.Xml.XmlNameTable); } set { } }
    public System.Xml.XmlReaderSettings Clone() { return default(System.Xml.XmlReaderSettings); }
    public void Reset() { }
  }

  public enum XmlSpace {
    Default = 1,
    None = 0,
    Preserve = 2,
  }

  public abstract partial class XmlWriter : System.IDisposable {
    protected XmlWriter() { }
    public virtual System.Xml.XmlWriterSettings Settings { get { return default(System.Xml.XmlWriterSettings); } }
    public abstract System.Xml.WriteState WriteState { get; }
    public virtual string XmlLang { get { return default(string); } }
    public virtual System.Xml.XmlSpace XmlSpace { get { return default(System.Xml.XmlSpace); } }
    public static System.Xml.XmlWriter Create(System.IO.Stream output) { return default(System.Xml.XmlWriter); }
    public static System.Xml.XmlWriter Create(System.IO.Stream output, System.Xml.XmlWriterSettings settings) { return default(System.Xml.XmlWriter); }
    public static System.Xml.XmlWriter Create(System.IO.TextWriter output) { return default(System.Xml.XmlWriter); }
    public static System.Xml.XmlWriter Create(System.IO.TextWriter output, System.Xml.XmlWriterSettings settings) { return default(System.Xml.XmlWriter); }
    public static System.Xml.XmlWriter Create(System.Text.StringBuilder output) { return default(System.Xml.XmlWriter); }
    public static System.Xml.XmlWriter Create(System.Text.StringBuilder output, System.Xml.XmlWriterSettings settings) { return default(System.Xml.XmlWriter); }
    public static System.Xml.XmlWriter Create(System.Xml.XmlWriter output) { return default(System.Xml.XmlWriter); }
    public static System.Xml.XmlWriter Create(System.Xml.XmlWriter output, System.Xml.XmlWriterSettings settings) { return default(System.Xml.XmlWriter); }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public abstract void Flush();
    public virtual System.Threading.Tasks.Task FlushAsync() { return default(System.Threading.Tasks.Task); }
    public abstract string LookupPrefix(string ns);
    public virtual void WriteAttributes(System.Xml.XmlReader reader, bool defattr) { }
    public virtual System.Threading.Tasks.Task WriteAttributesAsync(System.Xml.XmlReader reader, bool defattr) { return default(System.Threading.Tasks.Task); }
    public void WriteAttributeString(string localName, string value) { }
    public void WriteAttributeString(string localName, string ns, string value) { }
    public void WriteAttributeString(string prefix, string localName, string ns, string value) { }
    public System.Threading.Tasks.Task WriteAttributeStringAsync(string prefix, string localName, string ns, string value) { return default(System.Threading.Tasks.Task); }
    public abstract void WriteBase64(byte[] buffer, int index, int count);
    public virtual System.Threading.Tasks.Task WriteBase64Async(byte[] buffer, int index, int count) { return default(System.Threading.Tasks.Task); }
    public virtual void WriteBinHex(byte[] buffer, int index, int count) { }
    public virtual System.Threading.Tasks.Task WriteBinHexAsync(byte[] buffer, int index, int count) { return default(System.Threading.Tasks.Task); }
    public abstract void WriteCData(string text);
    public virtual System.Threading.Tasks.Task WriteCDataAsync(string text) { return default(System.Threading.Tasks.Task); }
    public abstract void WriteCharEntity(char ch);
    public virtual System.Threading.Tasks.Task WriteCharEntityAsync(char ch) { return default(System.Threading.Tasks.Task); }
    public abstract void WriteChars(char[] buffer, int index, int count);
    public virtual System.Threading.Tasks.Task WriteCharsAsync(char[] buffer, int index, int count) { return default(System.Threading.Tasks.Task); }
    public abstract void WriteComment(string text);
    public virtual System.Threading.Tasks.Task WriteCommentAsync(string text) { return default(System.Threading.Tasks.Task); }
    public abstract void WriteDocType(string name, string pubid, string sysid, string subset);
    public virtual System.Threading.Tasks.Task WriteDocTypeAsync(string name, string pubid, string sysid, string subset) { return default(System.Threading.Tasks.Task); }
    public void WriteElementString(string localName, string value) { }
    public void WriteElementString(string localName, string ns, string value) { }
    public void WriteElementString(string prefix, string localName, string ns, string value) { }
    public System.Threading.Tasks.Task WriteElementStringAsync(string prefix, string localName, string ns, string value) { return default(System.Threading.Tasks.Task); }
    public abstract void WriteEndAttribute();
    protected internal virtual System.Threading.Tasks.Task WriteEndAttributeAsync() { return default(System.Threading.Tasks.Task); }
    public abstract void WriteEndDocument();
    public virtual System.Threading.Tasks.Task WriteEndDocumentAsync() { return default(System.Threading.Tasks.Task); }
    public abstract void WriteEndElement();
    public virtual System.Threading.Tasks.Task WriteEndElementAsync() { return default(System.Threading.Tasks.Task); }
    public abstract void WriteEntityRef(string name);
    public virtual System.Threading.Tasks.Task WriteEntityRefAsync(string name) { return default(System.Threading.Tasks.Task); }
    public abstract void WriteFullEndElement();
    public virtual System.Threading.Tasks.Task WriteFullEndElementAsync() { return default(System.Threading.Tasks.Task); }
    public virtual void WriteName(string name) { }
    public virtual System.Threading.Tasks.Task WriteNameAsync(string name) { return default(System.Threading.Tasks.Task); }
    public virtual void WriteNmToken(string name) { }
    public virtual System.Threading.Tasks.Task WriteNmTokenAsync(string name) { return default(System.Threading.Tasks.Task); }
    public virtual void WriteNode(System.Xml.XmlReader reader, bool defattr) { }
    public virtual System.Threading.Tasks.Task WriteNodeAsync(System.Xml.XmlReader reader, bool defattr) { return default(System.Threading.Tasks.Task); }
    public abstract void WriteProcessingInstruction(string name, string text);
    public virtual System.Threading.Tasks.Task WriteProcessingInstructionAsync(string name, string text) { return default(System.Threading.Tasks.Task); }
    public virtual void WriteQualifiedName(string localName, string ns) { }
    public virtual System.Threading.Tasks.Task WriteQualifiedNameAsync(string localName, string ns) { return default(System.Threading.Tasks.Task); }
    public abstract void WriteRaw(char[] buffer, int index, int count);
    public abstract void WriteRaw(string data);
    public virtual System.Threading.Tasks.Task WriteRawAsync(char[] buffer, int index, int count) { return default(System.Threading.Tasks.Task); }
    public virtual System.Threading.Tasks.Task WriteRawAsync(string data) { return default(System.Threading.Tasks.Task); }
    public void WriteStartAttribute(string localName) { }
    public void WriteStartAttribute(string localName, string ns) { }
    public abstract void WriteStartAttribute(string prefix, string localName, string ns);
    protected internal virtual System.Threading.Tasks.Task WriteStartAttributeAsync(string prefix, string localName, string ns) { return default(System.Threading.Tasks.Task); }
    public abstract void WriteStartDocument();
    public abstract void WriteStartDocument(bool standalone);
    public virtual System.Threading.Tasks.Task WriteStartDocumentAsync() { return default(System.Threading.Tasks.Task); }
    public virtual System.Threading.Tasks.Task WriteStartDocumentAsync(bool standalone) { return default(System.Threading.Tasks.Task); }
    public void WriteStartElement(string localName) { }
    public void WriteStartElement(string localName, string ns) { }
    public abstract void WriteStartElement(string prefix, string localName, string ns);
    public virtual System.Threading.Tasks.Task WriteStartElementAsync(string prefix, string localName, string ns) { return default(System.Threading.Tasks.Task); }
    public abstract void WriteString(string text);
    public virtual System.Threading.Tasks.Task WriteStringAsync(string text) { return default(System.Threading.Tasks.Task); }
    public abstract void WriteSurrogateCharEntity(char lowChar, char highChar);
    public virtual System.Threading.Tasks.Task WriteSurrogateCharEntityAsync(char lowChar, char highChar) { return default(System.Threading.Tasks.Task); }
    public virtual void WriteValue(bool value) { }
    public virtual void WriteValue(System.DateTime value) { }
    public virtual void WriteValue(System.DateTimeOffset value) { }
    public virtual void WriteValue(decimal value) { }
    public virtual void WriteValue(double value) { }
    public virtual void WriteValue(int value) { }
    public virtual void WriteValue(long value) { }
    public virtual void WriteValue(object value) { }
    public virtual void WriteValue(float value) { }
    public virtual void WriteValue(string value) { }
    public abstract void WriteWhitespace(string ws);
    public virtual System.Threading.Tasks.Task WriteWhitespaceAsync(string ws) { return default(System.Threading.Tasks.Task); }
  }

  public sealed partial class XmlWriterSettings {
    public XmlWriterSettings() { }
    public bool Async { get { return default(bool); } set { } }
    public bool CheckCharacters { get { return default(bool); } set { } }
    public bool CloseOutput { get { return default(bool); } set { } }
    public System.Xml.ConformanceLevel ConformanceLevel { get { return default(System.Xml.ConformanceLevel); } set { } }
    public System.Text.Encoding Encoding { get { return default(System.Text.Encoding); } set { } }
    public bool Indent { get { return default(bool); } set { } }
    public string IndentChars { get { return default(string); } set { } }
    public System.Xml.NamespaceHandling NamespaceHandling { get { return default(System.Xml.NamespaceHandling); } set { } }
    public string NewLineChars { get { return default(string); } set { } }
    public System.Xml.NewLineHandling NewLineHandling { get { return default(System.Xml.NewLineHandling); } set { } }
    public bool NewLineOnAttributes { get { return default(bool); } set { } }
    public bool OmitXmlDeclaration { get { return default(bool); } set { } }
    public bool WriteEndDocumentOnClose { get { return default(bool); } set { } }
    public System.Xml.XmlWriterSettings Clone() { return default(System.Xml.XmlWriterSettings); }
    public void Reset() { }
  }

  public partial class XmlAttribute : System.Xml.XmlNode {
    protected internal XmlAttribute(string prefix, string localName, string namespaceURI, System.Xml.XmlDocument doc) { }
    public override string BaseURI { get { return default(string); } }
    public override string InnerText { set { } }
    public override string InnerXml { set { } }
    public override string LocalName { get { return default(string); } }
    public override string Name { get { return default(string); } }
    public override string NamespaceURI { get { return default(string); } }
    public override System.Xml.XmlNodeType NodeType { get { return default(System.Xml.XmlNodeType); } }
    public override System.Xml.XmlDocument OwnerDocument { get { return default(System.Xml.XmlDocument); } }
    public virtual System.Xml.XmlElement OwnerElement { get { return default(System.Xml.XmlElement); } }
    public override System.Xml.XmlNode ParentNode { get { return default(System.Xml.XmlNode); } }
    public override string Prefix { get { return default(string); } set { } }
    public virtual bool Specified { get { return default(bool); } }
    public override string Value { get { return default(string); } set { } }
    public override System.Xml.XmlNode AppendChild(System.Xml.XmlNode newChild) { return default(System.Xml.XmlNode); }
    public override System.Xml.XmlNode CloneNode(bool deep) { return default(System.Xml.XmlNode); }
    public override System.Xml.XmlNode InsertAfter(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild) { return default(System.Xml.XmlNode); }
    public override System.Xml.XmlNode InsertBefore(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild) { return default(System.Xml.XmlNode); }
    public override System.Xml.XmlNode PrependChild(System.Xml.XmlNode newChild) { return default(System.Xml.XmlNode); }
    public override System.Xml.XmlNode RemoveChild(System.Xml.XmlNode oldChild) { return default(System.Xml.XmlNode); }
    public override System.Xml.XmlNode ReplaceChild(System.Xml.XmlNode newChild, System.Xml.XmlNode oldChild) { return default(System.Xml.XmlNode); }
    public override void WriteContentTo(System.Xml.XmlWriter w) { }
    public override void WriteTo(System.Xml.XmlWriter w) { }
  }

  public sealed partial class XmlAttributeCollection : System.Xml.XmlNamedNodeMap, System.Collections.ICollection, System.Collections.IEnumerable {
    internal XmlAttributeCollection() { }
    [System.Runtime.CompilerServices.IndexerName("ItemOf")]
    public System.Xml.XmlAttribute this[int i] { get { return default(System.Xml.XmlAttribute); } }
    [System.Runtime.CompilerServices.IndexerName("ItemOf")]
    public System.Xml.XmlAttribute this[string name] { get { return default(System.Xml.XmlAttribute); } }
    [System.Runtime.CompilerServices.IndexerName("ItemOf")]
    public System.Xml.XmlAttribute this[string localName, string namespaceURI] { get { return default(System.Xml.XmlAttribute); } }
    int System.Collections.ICollection.Count { get { return default(int); } }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    public System.Xml.XmlAttribute Append(System.Xml.XmlAttribute node) { return default(System.Xml.XmlAttribute); }
    public void CopyTo(System.Xml.XmlAttribute[] array, int index) { }
    public System.Xml.XmlAttribute InsertAfter(System.Xml.XmlAttribute newNode, System.Xml.XmlAttribute refNode) { return default(System.Xml.XmlAttribute); }
    public System.Xml.XmlAttribute InsertBefore(System.Xml.XmlAttribute newNode, System.Xml.XmlAttribute refNode) { return default(System.Xml.XmlAttribute); }
    public System.Xml.XmlAttribute Prepend(System.Xml.XmlAttribute node) { return default(System.Xml.XmlAttribute); }
    public System.Xml.XmlAttribute Remove(System.Xml.XmlAttribute node) { return default(System.Xml.XmlAttribute); }
    public void RemoveAll() { }
    public System.Xml.XmlAttribute RemoveAt(int i) { return default(System.Xml.XmlAttribute); }
    public override System.Xml.XmlNode SetNamedItem(System.Xml.XmlNode node) { return default(System.Xml.XmlNode); }
    void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
  }

  public partial class XmlCDataSection : System.Xml.XmlCharacterData {
    protected internal XmlCDataSection(string data, System.Xml.XmlDocument doc) : base (default(string), default(System.Xml.XmlDocument)) { }
    public override string LocalName { get { return default(string); } }
    public override string Name { get { return default(string); } }
    public override System.Xml.XmlNodeType NodeType { get { return default(System.Xml.XmlNodeType); } }
    public override System.Xml.XmlNode ParentNode { get { return default(System.Xml.XmlNode); } }
    public override System.Xml.XmlNode PreviousText { get { return default(System.Xml.XmlNode); } }
    public override System.Xml.XmlNode CloneNode(bool deep) { return default(System.Xml.XmlNode); }
    public override void WriteContentTo(System.Xml.XmlWriter w) { }
    public override void WriteTo(System.Xml.XmlWriter w) { }
  }

  public abstract partial class XmlCharacterData : System.Xml.XmlLinkedNode {
    protected internal XmlCharacterData(string data, System.Xml.XmlDocument doc) { }
    public virtual string Data { get { return default(string); } set { } }
    public virtual int Length { get { return default(int); } }
    public override string Value { get { return default(string); } set { } }
    public virtual void AppendData(string strData) { }
    public virtual void DeleteData(int offset, int count) { }
    public virtual void InsertData(int offset, string strData) { }
    public virtual void ReplaceData(int offset, int count, string strData) { }
    public virtual string Substring(int offset, int count) { return default(string); }
  }

  public partial class XmlComment : System.Xml.XmlCharacterData {
    protected internal XmlComment(string comment, System.Xml.XmlDocument doc) : base (default(string), default(System.Xml.XmlDocument)) { }
    public override string LocalName { get { return default(string); } }
    public override string Name { get { return default(string); } }
    public override System.Xml.XmlNodeType NodeType { get { return default(System.Xml.XmlNodeType); } }
    public override System.Xml.XmlNode CloneNode(bool deep) { return default(System.Xml.XmlNode); }
    public override void WriteContentTo(System.Xml.XmlWriter w) { }
    public override void WriteTo(System.Xml.XmlWriter w) { }
  }

  public partial class XmlDeclaration : System.Xml.XmlLinkedNode {
    protected internal XmlDeclaration(string version, string encoding, string standalone, System.Xml.XmlDocument doc) { }
    public string Encoding { get { return default(string); } set { } }
    public override string InnerText { get { return default(string); } set { } }
    public override string LocalName { get { return default(string); } }
    public override string Name { get { return default(string); } }
    public override System.Xml.XmlNodeType NodeType { get { return default(System.Xml.XmlNodeType); } }
    public string Standalone { get { return default(string); } set { } }
    public override string Value { get { return default(string); } set { } }
    public string Version { get { return default(string); } }
    public override System.Xml.XmlNode CloneNode(bool deep) { return default(System.Xml.XmlNode); }
    public override void WriteContentTo(System.Xml.XmlWriter w) { }
    public override void WriteTo(System.Xml.XmlWriter w) { }
  }

  public partial class XmlDocument : System.Xml.XmlNode {
    public XmlDocument() { }
    protected internal XmlDocument(System.Xml.XmlImplementation imp) { }
    public XmlDocument(System.Xml.XmlNameTable nt) { }
    public override string BaseURI { get { return default(string); } }
    public System.Xml.XmlElement DocumentElement { get { return default(System.Xml.XmlElement); } }
    public System.Xml.XmlImplementation Implementation { get { return default(System.Xml.XmlImplementation); } }
    public override string InnerText { set { } }
    public override string InnerXml { get { return default(string); } set { } }
    public override bool IsReadOnly { get { return default(bool); } }
    public override string LocalName { get { return default(string); } }
    public override string Name { get { return default(string); } }
    public System.Xml.XmlNameTable NameTable { get { return default(System.Xml.XmlNameTable); } }
    public override System.Xml.XmlNodeType NodeType { get { return default(System.Xml.XmlNodeType); } }
    public override System.Xml.XmlDocument OwnerDocument { get { return default(System.Xml.XmlDocument); } }
    public override System.Xml.XmlNode ParentNode { get { return default(System.Xml.XmlNode); } }
    public bool PreserveWhitespace { get { return default(bool); } set { } }
    public event System.Xml.XmlNodeChangedEventHandler NodeChanged { add { } remove { } }
    public event System.Xml.XmlNodeChangedEventHandler NodeChanging { add { } remove { } }
    public event System.Xml.XmlNodeChangedEventHandler NodeInserted { add { } remove { } }
    public event System.Xml.XmlNodeChangedEventHandler NodeInserting { add { } remove { } }
    public event System.Xml.XmlNodeChangedEventHandler NodeRemoved { add { } remove { } }
    public event System.Xml.XmlNodeChangedEventHandler NodeRemoving { add { } remove { } }
    public override System.Xml.XmlNode CloneNode(bool deep) { return default(System.Xml.XmlNode); }
    public System.Xml.XmlAttribute CreateAttribute(string name) { return default(System.Xml.XmlAttribute); }
    public System.Xml.XmlAttribute CreateAttribute(string qualifiedName, string namespaceURI) { return default(System.Xml.XmlAttribute); }
    public virtual System.Xml.XmlAttribute CreateAttribute(string prefix, string localName, string namespaceURI) { return default(System.Xml.XmlAttribute); }
    public virtual System.Xml.XmlCDataSection CreateCDataSection(string data) { return default(System.Xml.XmlCDataSection); }
    public virtual System.Xml.XmlComment CreateComment(string data) { return default(System.Xml.XmlComment); }
    public virtual System.Xml.XmlDocumentFragment CreateDocumentFragment() { return default(System.Xml.XmlDocumentFragment); }
    public System.Xml.XmlElement CreateElement(string name) { return default(System.Xml.XmlElement); }
    public System.Xml.XmlElement CreateElement(string qualifiedName, string namespaceURI) { return default(System.Xml.XmlElement); }
    public virtual System.Xml.XmlElement CreateElement(string prefix, string localName, string namespaceURI) { return default(System.Xml.XmlElement); }
    public virtual System.Xml.XmlNode CreateNode(string nodeTypeString, string name, string namespaceURI) { return default(System.Xml.XmlNode); }
    public virtual System.Xml.XmlNode CreateNode(System.Xml.XmlNodeType type, string name, string namespaceURI) { return default(System.Xml.XmlNode); }
    public virtual System.Xml.XmlNode CreateNode(System.Xml.XmlNodeType type, string prefix, string name, string namespaceURI) { return default(System.Xml.XmlNode); }
    public virtual System.Xml.XmlProcessingInstruction CreateProcessingInstruction(string target, string data) { return default(System.Xml.XmlProcessingInstruction); }
    public virtual System.Xml.XmlSignificantWhitespace CreateSignificantWhitespace(string text) { return default(System.Xml.XmlSignificantWhitespace); }
    public virtual System.Xml.XmlText CreateTextNode(string text) { return default(System.Xml.XmlText); }
    public virtual System.Xml.XmlWhitespace CreateWhitespace(string text) { return default(System.Xml.XmlWhitespace); }
    public virtual System.Xml.XmlDeclaration CreateXmlDeclaration(string version, string encoding, string standalone) { return default(System.Xml.XmlDeclaration); }
    public virtual System.Xml.XmlNodeList GetElementsByTagName(string name) { return default(System.Xml.XmlNodeList); }
    public virtual System.Xml.XmlNodeList GetElementsByTagName(string localName, string namespaceURI) { return default(System.Xml.XmlNodeList); }
    public virtual System.Xml.XmlNode ImportNode(System.Xml.XmlNode node, bool deep) { return default(System.Xml.XmlNode); }
    public virtual void Load(System.IO.Stream inStream) { }
    public virtual void Load(System.IO.TextReader txtReader) { }
    public virtual void Load(System.Xml.XmlReader reader) { }
    public virtual void LoadXml(string xml) { }
    public virtual System.Xml.XmlNode ReadNode(System.Xml.XmlReader reader) { return default(System.Xml.XmlNode); }
    public virtual void Save(System.IO.Stream outStream) { }
    public virtual void Save(System.IO.TextWriter writer) { }
    public virtual void Save(System.Xml.XmlWriter w) { }
    public override void WriteContentTo(System.Xml.XmlWriter xw) { }
    public override void WriteTo(System.Xml.XmlWriter w) { }
  }

  public partial class XmlDocumentFragment : System.Xml.XmlNode {
    protected internal XmlDocumentFragment(System.Xml.XmlDocument ownerDocument) { }
    public override string InnerXml { get { return default(string); } set { } }
    public override string LocalName { get { return default(string); } }
    public override string Name { get { return default(string); } }
    public override System.Xml.XmlNodeType NodeType { get { return default(System.Xml.XmlNodeType); } }
    public override System.Xml.XmlDocument OwnerDocument { get { return default(System.Xml.XmlDocument); } }
    public override System.Xml.XmlNode ParentNode { get { return default(System.Xml.XmlNode); } }
    public override System.Xml.XmlNode CloneNode(bool deep) { return default(System.Xml.XmlNode); }
    public override void WriteContentTo(System.Xml.XmlWriter w) { }
    public override void WriteTo(System.Xml.XmlWriter w) { }
  }

  public partial class XmlElement : System.Xml.XmlLinkedNode {
    protected internal XmlElement(string prefix, string localName, string namespaceURI, System.Xml.XmlDocument doc) { }
    public override System.Xml.XmlAttributeCollection Attributes { get { return default(System.Xml.XmlAttributeCollection); } }
    public virtual bool HasAttributes { get { return default(bool); } }
    public override string InnerText { get { return default(string); } set { } }
    public override string InnerXml { get { return default(string); } set { } }
    public bool IsEmpty { get { return default(bool); } set { } }
    public override string LocalName { get { return default(string); } }
    public override string Name { get { return default(string); } }
    public override string NamespaceURI { get { return default(string); } }
    public override System.Xml.XmlNode NextSibling { get { return default(System.Xml.XmlNode); } }
    public override System.Xml.XmlNodeType NodeType { get { return default(System.Xml.XmlNodeType); } }
    public override System.Xml.XmlDocument OwnerDocument { get { return default(System.Xml.XmlDocument); } }
    public override System.Xml.XmlNode ParentNode { get { return default(System.Xml.XmlNode); } }
    public override string Prefix { get { return default(string); } set { } }
    public override System.Xml.XmlNode CloneNode(bool deep) { return default(System.Xml.XmlNode); }
    public virtual string GetAttribute(string name) { return default(string); }
    public virtual string GetAttribute(string localName, string namespaceURI) { return default(string); }
    public virtual System.Xml.XmlAttribute GetAttributeNode(string name) { return default(System.Xml.XmlAttribute); }
    public virtual System.Xml.XmlAttribute GetAttributeNode(string localName, string namespaceURI) { return default(System.Xml.XmlAttribute); }
    public virtual System.Xml.XmlNodeList GetElementsByTagName(string name) { return default(System.Xml.XmlNodeList); }
    public virtual System.Xml.XmlNodeList GetElementsByTagName(string localName, string namespaceURI) { return default(System.Xml.XmlNodeList); }
    public virtual bool HasAttribute(string name) { return default(bool); }
    public virtual bool HasAttribute(string localName, string namespaceURI) { return default(bool); }
    public override void RemoveAll() { }
    public virtual void RemoveAllAttributes() { }
    public virtual void RemoveAttribute(string name) { }
    public virtual void RemoveAttribute(string localName, string namespaceURI) { }
    public virtual System.Xml.XmlNode RemoveAttributeAt(int i) { return default(System.Xml.XmlNode); }
    public virtual System.Xml.XmlAttribute RemoveAttributeNode(string localName, string namespaceURI) { return default(System.Xml.XmlAttribute); }
    public virtual System.Xml.XmlAttribute RemoveAttributeNode(System.Xml.XmlAttribute oldAttr) { return default(System.Xml.XmlAttribute); }
    public virtual void SetAttribute(string name, string value) { }
    public virtual string SetAttribute(string localName, string namespaceURI, string value) { return default(string); }
    public virtual System.Xml.XmlAttribute SetAttributeNode(string localName, string namespaceURI) { return default(System.Xml.XmlAttribute); }
    public virtual System.Xml.XmlAttribute SetAttributeNode(System.Xml.XmlAttribute newAttr) { return default(System.Xml.XmlAttribute); }
    public override void WriteContentTo(System.Xml.XmlWriter w) { }
    public override void WriteTo(System.Xml.XmlWriter w) { }
  }

  public partial class XmlImplementation {
    public XmlImplementation() { }
    public XmlImplementation(System.Xml.XmlNameTable nt) { }
    public virtual System.Xml.XmlDocument CreateDocument() { return default(System.Xml.XmlDocument); }
    public bool HasFeature(string strFeature, string strVersion) { return default(bool); }
  }

  public abstract partial class XmlLinkedNode : System.Xml.XmlNode {
    internal XmlLinkedNode() { }
    public override System.Xml.XmlNode NextSibling { get { return default(System.Xml.XmlNode); } }
    public override System.Xml.XmlNode PreviousSibling { get { return default(System.Xml.XmlNode); } }
  }

  public partial class XmlNamedNodeMap : System.Collections.IEnumerable {
    internal XmlNamedNodeMap() { }
    public virtual int Count { get { return default(int); } }
    public virtual System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public virtual System.Xml.XmlNode GetNamedItem(string name) { return default(System.Xml.XmlNode); }
    public virtual System.Xml.XmlNode GetNamedItem(string localName, string namespaceURI) { return default(System.Xml.XmlNode); }
    public virtual System.Xml.XmlNode Item(int index) { return default(System.Xml.XmlNode); }
    public virtual System.Xml.XmlNode RemoveNamedItem(string name) { return default(System.Xml.XmlNode); }
    public virtual System.Xml.XmlNode RemoveNamedItem(string localName, string namespaceURI) { return default(System.Xml.XmlNode); }
    public virtual System.Xml.XmlNode SetNamedItem(System.Xml.XmlNode node) { return default(System.Xml.XmlNode); }
  }

  public abstract partial class XmlNode : System.Collections.IEnumerable {
    internal XmlNode() { }
    public virtual System.Xml.XmlAttributeCollection Attributes { get { return default(System.Xml.XmlAttributeCollection); } }
    public virtual string BaseURI { get { return default(string); } }
    public virtual System.Xml.XmlNodeList ChildNodes { get { return default(System.Xml.XmlNodeList); } }
    public virtual System.Xml.XmlNode FirstChild { get { return default(System.Xml.XmlNode); } }
    public virtual bool HasChildNodes { get { return default(bool); } }
    public virtual string InnerText { get { return default(string); } set { } }
    public virtual string InnerXml { get { return default(string); } set { } }
    public virtual bool IsReadOnly { get { return default(bool); } }
    public virtual System.Xml.XmlElement this[string name] { get { return default(System.Xml.XmlElement); } }
    public virtual System.Xml.XmlElement this[string localname, string ns] { get { return default(System.Xml.XmlElement); } }
    public virtual System.Xml.XmlNode LastChild { get { return default(System.Xml.XmlNode); } }
    public abstract string LocalName { get; }
    public abstract string Name { get; }
    public virtual string NamespaceURI { get { return default(string); } }
    public virtual System.Xml.XmlNode NextSibling { get { return default(System.Xml.XmlNode); } }
    public abstract System.Xml.XmlNodeType NodeType { get; }
    public virtual string OuterXml { get { return default(string); } }
    public virtual System.Xml.XmlDocument OwnerDocument { get { return default(System.Xml.XmlDocument); } }
    public virtual System.Xml.XmlNode ParentNode { get { return default(System.Xml.XmlNode); } }
    public virtual string Prefix { get { return default(string); } set { } }
    public virtual System.Xml.XmlNode PreviousSibling { get { return default(System.Xml.XmlNode); } }
    public virtual System.Xml.XmlNode PreviousText { get { return default(System.Xml.XmlNode); } }
    public virtual string Value { get { return default(string); } set { } }
    public virtual System.Xml.XmlNode AppendChild(System.Xml.XmlNode newChild) { return default(System.Xml.XmlNode); }
    public abstract System.Xml.XmlNode CloneNode(bool deep);
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public virtual string GetNamespaceOfPrefix(string prefix) { return default(string); }
    public virtual string GetPrefixOfNamespace(string namespaceURI) { return default(string); }
    public virtual System.Xml.XmlNode InsertAfter(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild) { return default(System.Xml.XmlNode); }
    public virtual System.Xml.XmlNode InsertBefore(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild) { return default(System.Xml.XmlNode); }
    public virtual void Normalize() { }
    public virtual System.Xml.XmlNode PrependChild(System.Xml.XmlNode newChild) { return default(System.Xml.XmlNode); }
    public virtual void RemoveAll() { }
    public virtual System.Xml.XmlNode RemoveChild(System.Xml.XmlNode oldChild) { return default(System.Xml.XmlNode); }
    public virtual System.Xml.XmlNode ReplaceChild(System.Xml.XmlNode newChild, System.Xml.XmlNode oldChild) { return default(System.Xml.XmlNode); }
    public virtual bool Supports(string feature, string version) { return default(bool); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    public abstract void WriteContentTo(System.Xml.XmlWriter w);
    public abstract void WriteTo(System.Xml.XmlWriter w);
  }

  public enum XmlNodeChangedAction {
    Change = 2,
    Insert = 0,
    Remove = 1,
  }

  public partial class XmlNodeChangedEventArgs : System.EventArgs {
    public XmlNodeChangedEventArgs(System.Xml.XmlNode node, System.Xml.XmlNode oldParent, System.Xml.XmlNode newParent, string oldValue, string newValue, System.Xml.XmlNodeChangedAction action) { }
    public System.Xml.XmlNodeChangedAction Action { get { return default(System.Xml.XmlNodeChangedAction); } }
    public System.Xml.XmlNode NewParent { get { return default(System.Xml.XmlNode); } }
    public string NewValue { get { return default(string); } }
    public System.Xml.XmlNode Node { get { return default(System.Xml.XmlNode); } }
    public System.Xml.XmlNode OldParent { get { return default(System.Xml.XmlNode); } }
    public string OldValue { get { return default(string); } }
  }

  public delegate void XmlNodeChangedEventHandler(object sender, System.Xml.XmlNodeChangedEventArgs e);

  public abstract partial class XmlNodeList : System.Collections.IEnumerable, System.IDisposable {
    protected XmlNodeList() { }
    public abstract int Count { get; }
    [System.Runtime.CompilerServices.IndexerName("ItemOf")]
    public virtual System.Xml.XmlNode this[int i] { get { return default(System.Xml.XmlNode); } }
    public abstract System.Collections.IEnumerator GetEnumerator();
    public abstract System.Xml.XmlNode Item(int index);
    protected virtual void PrivateDisposeNodeList() { }
    void System.IDisposable.Dispose() { }
  }

  public partial class XmlProcessingInstruction : System.Xml.XmlLinkedNode {
    protected internal XmlProcessingInstruction(string target, string data, System.Xml.XmlDocument doc) { }
    public string Data { get { return default(string); } set { } }
    public override string InnerText { get { return default(string); } set { } }
    public override string LocalName { get { return default(string); } }
    public override string Name { get { return default(string); } }
    public override System.Xml.XmlNodeType NodeType { get { return default(System.Xml.XmlNodeType); } }
    public string Target { get { return default(string); } }
    public override string Value { get { return default(string); } set { } }
    public override System.Xml.XmlNode CloneNode(bool deep) { return default(System.Xml.XmlNode); }
    public override void WriteContentTo(System.Xml.XmlWriter w) { }
    public override void WriteTo(System.Xml.XmlWriter w) { }
  }

  public partial class XmlSignificantWhitespace : System.Xml.XmlCharacterData {
    protected internal XmlSignificantWhitespace(string strData, System.Xml.XmlDocument doc) : base (default(string), default(System.Xml.XmlDocument)) { }
    public override string LocalName { get { return default(string); } }
    public override string Name { get { return default(string); } }
    public override System.Xml.XmlNodeType NodeType { get { return default(System.Xml.XmlNodeType); } }
    public override System.Xml.XmlNode ParentNode { get { return default(System.Xml.XmlNode); } }
    public override System.Xml.XmlNode PreviousText { get { return default(System.Xml.XmlNode); } }
    public override string Value { get { return default(string); } set { } }
    public override System.Xml.XmlNode CloneNode(bool deep) { return default(System.Xml.XmlNode); }
    public override void WriteContentTo(System.Xml.XmlWriter w) { }
    public override void WriteTo(System.Xml.XmlWriter w) { }
  }

  public partial class XmlText : System.Xml.XmlCharacterData {
    protected internal XmlText(string strData, System.Xml.XmlDocument doc) : base (default(string), default(System.Xml.XmlDocument)) { }
    public override string LocalName { get { return default(string); } }
    public override string Name { get { return default(string); } }
    public override System.Xml.XmlNodeType NodeType { get { return default(System.Xml.XmlNodeType); } }
    public override System.Xml.XmlNode ParentNode { get { return default(System.Xml.XmlNode); } }
    public override System.Xml.XmlNode PreviousText { get { return default(System.Xml.XmlNode); } }
    public override string Value { get { return default(string); } set { } }
    public override System.Xml.XmlNode CloneNode(bool deep) { return default(System.Xml.XmlNode); }
    public virtual System.Xml.XmlText SplitText(int offset) { return default(System.Xml.XmlText); }
    public override void WriteContentTo(System.Xml.XmlWriter w) { }
    public override void WriteTo(System.Xml.XmlWriter w) { }
  }

  public partial class XmlWhitespace : System.Xml.XmlCharacterData {
    protected internal XmlWhitespace(string strData, System.Xml.XmlDocument doc) : base (default(string), default(System.Xml.XmlDocument)) { }
    public override string LocalName { get { return default(string); } }
    public override string Name { get { return default(string); } }
    public override System.Xml.XmlNodeType NodeType { get { return default(System.Xml.XmlNodeType); } }
    public override System.Xml.XmlNode ParentNode { get { return default(System.Xml.XmlNode); } }
    public override System.Xml.XmlNode PreviousText { get { return default(System.Xml.XmlNode); } }
    public override string Value { get { return default(string); } set { } }
    public override System.Xml.XmlNode CloneNode(bool deep) { return default(System.Xml.XmlNode); }
    public override void WriteContentTo(System.Xml.XmlWriter w) { }
    public override void WriteTo(System.Xml.XmlWriter w) { }
  }

  public enum XmlNodeOrder {
    After = 1,
    Before = 0,
    Same = 2,
    Unknown = 3,
  }

  public static partial class XmlDocumentXPathExtensions {
    public static System.Xml.XPath.XPathNavigator CreateNavigator(this System.Xml.XmlDocument document) { return default(System.Xml.XPath.XPathNavigator); }
    public static System.Xml.XPath.XPathNavigator CreateNavigator(this System.Xml.XmlDocument document, System.Xml.XmlNode node) { return default(System.Xml.XPath.XPathNavigator); }
    public static System.Xml.XPath.XPathNavigator CreateNavigator(this System.Xml.XmlNode node) { return default(System.Xml.XPath.XPathNavigator); }
    public static System.Xml.XmlNodeList SelectNodes(this System.Xml.XmlNode node, string xpath) { return default(System.Xml.XmlNodeList); }
    public static System.Xml.XmlNodeList SelectNodes(this System.Xml.XmlNode node, string xpath, System.Xml.XmlNamespaceManager nsmgr) { return default(System.Xml.XmlNodeList); }
    public static System.Xml.XmlNode SelectSingleNode(this System.Xml.XmlNode node, string xpath) { return default(System.Xml.XmlNode); }
    public static System.Xml.XmlNode SelectSingleNode(this System.Xml.XmlNode node, string xpath, System.Xml.XmlNamespaceManager nsmgr) { return default(System.Xml.XmlNode); }
    public static System.Xml.XPath.IXPathNavigable ToXPathNavigable(this System.Xml.XmlNode node) { return default(System.Xml.XPath.IXPathNavigable); }
  }

} // end of System.Xml
namespace System.Runtime.InteropServices.WindowsRuntime {
  [System.CLSCompliantAttribute(false)]
  [System.Security.SecurityCriticalAttribute]
  public static partial class AsyncInfo {
    public static Windows.Foundation.IAsyncAction Run(System.Func<System.Threading.CancellationToken, System.Threading.Tasks.Task> taskProvider) { return default(Windows.Foundation.IAsyncAction); }
    public static Windows.Foundation.IAsyncActionWithProgress<TProgress> Run<TProgress>(System.Func<System.Threading.CancellationToken, System.IProgress<TProgress>, System.Threading.Tasks.Task> taskProvider) { return default(Windows.Foundation.IAsyncActionWithProgress<TProgress>); }
    public static Windows.Foundation.IAsyncOperation<TResult> Run<TResult>(System.Func<System.Threading.CancellationToken, System.Threading.Tasks.Task<TResult>> taskProvider) { return default(Windows.Foundation.IAsyncOperation<TResult>); }
    public static Windows.Foundation.IAsyncOperationWithProgress<TResult, TProgress> Run<TResult, TProgress>(System.Func<System.Threading.CancellationToken, System.IProgress<TProgress>, System.Threading.Tasks.Task<TResult>> taskProvider) { return default(Windows.Foundation.IAsyncOperationWithProgress<TResult, TProgress>); }
  }

  [System.Security.SecurityCriticalAttribute]
  public sealed partial class WindowsRuntimeBuffer {
    internal WindowsRuntimeBuffer() { }
    [System.CLSCompliantAttribute(false)]
    public static Windows.Storage.Streams.IBuffer Create(byte[] data, int offset, int length, int capacity) { return default(Windows.Storage.Streams.IBuffer); }
    [System.CLSCompliantAttribute(false)]
    public static Windows.Storage.Streams.IBuffer Create(int capacity) { return default(Windows.Storage.Streams.IBuffer); }
  }

  [System.Security.SecurityCriticalAttribute]
  public static partial class WindowsRuntimeBufferExtensions {
    [System.CLSCompliantAttribute(false)]
    public static Windows.Storage.Streams.IBuffer AsBuffer(this byte[] source) { return default(Windows.Storage.Streams.IBuffer); }
    [System.CLSCompliantAttribute(false)]
    public static Windows.Storage.Streams.IBuffer AsBuffer(this byte[] source, int offset, int length) { return default(Windows.Storage.Streams.IBuffer); }
    [System.CLSCompliantAttribute(false)]
    public static Windows.Storage.Streams.IBuffer AsBuffer(this byte[] source, int offset, int length, int capacity) { return default(Windows.Storage.Streams.IBuffer); }
    [System.CLSCompliantAttribute(false)]
    public static System.IO.Stream AsStream(this Windows.Storage.Streams.IBuffer source) { return default(System.IO.Stream); }
    [System.CLSCompliantAttribute(false)]
    public static void CopyTo(this byte[] source, int sourceIndex, Windows.Storage.Streams.IBuffer destination, uint destinationIndex, int count) { }
    [System.CLSCompliantAttribute(false)]
    public static void CopyTo(this byte[] source, Windows.Storage.Streams.IBuffer destination) { }
    [System.CLSCompliantAttribute(false)]
    public static void CopyTo(this Windows.Storage.Streams.IBuffer source, byte[] destination) { }
    [System.CLSCompliantAttribute(false)]
    public static void CopyTo(this Windows.Storage.Streams.IBuffer source, uint sourceIndex, byte[] destination, int destinationIndex, int count) { }
    [System.CLSCompliantAttribute(false)]
    public static void CopyTo(this Windows.Storage.Streams.IBuffer source, uint sourceIndex, Windows.Storage.Streams.IBuffer destination, uint destinationIndex, uint count) { }
    [System.CLSCompliantAttribute(false)]
    public static void CopyTo(this Windows.Storage.Streams.IBuffer source, Windows.Storage.Streams.IBuffer destination) { }
    [System.CLSCompliantAttribute(false)]
    public static byte GetByte(this Windows.Storage.Streams.IBuffer source, uint byteOffset) { return default(byte); }
    [System.CLSCompliantAttribute(false)]
    public static Windows.Storage.Streams.IBuffer GetWindowsRuntimeBuffer(this System.IO.MemoryStream underlyingStream) { return default(Windows.Storage.Streams.IBuffer); }
    [System.CLSCompliantAttribute(false)]
    public static Windows.Storage.Streams.IBuffer GetWindowsRuntimeBuffer(this System.IO.MemoryStream underlyingStream, int positionInStream, int length) { return default(Windows.Storage.Streams.IBuffer); }
    [System.CLSCompliantAttribute(false)]
    public static bool IsSameData(this Windows.Storage.Streams.IBuffer buffer, Windows.Storage.Streams.IBuffer otherBuffer) { return default(bool); }
    [System.CLSCompliantAttribute(false)]
    public static byte[] ToArray(this Windows.Storage.Streams.IBuffer source) { return default(byte[]); }
    [System.CLSCompliantAttribute(false)]
    public static byte[] ToArray(this Windows.Storage.Streams.IBuffer source, uint sourceIndex, int count) { return default(byte[]); }
  }

} // end of System.Runtime.InteropServices.WindowsRuntime
namespace Windows.Foundation {
  [System.Security.SecurityCriticalAttribute]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct Point : System.IFormattable {
    public Point(double x, double y) { throw new System.NotImplementedException(); }
    public double X { get { return default(double); } set { } }
    public double Y { get { return default(double); } set { } }
    [System.Security.SecuritySafeCriticalAttribute]
    public override bool Equals(object o) { return default(bool); }
    public bool Equals(Windows.Foundation.Point value) { return default(bool); }
    [System.Security.SecuritySafeCriticalAttribute]
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(Windows.Foundation.Point point1, Windows.Foundation.Point point2) { return default(bool); }
    public static bool operator !=(Windows.Foundation.Point point1, Windows.Foundation.Point point2) { return default(bool); }
    [System.Security.SecuritySafeCriticalAttribute]
    string System.IFormattable.ToString(string format, System.IFormatProvider provider) { return default(string); }
    [System.Security.SecuritySafeCriticalAttribute]
    public override string ToString() { return default(string); }
    public string ToString(System.IFormatProvider provider) { return default(string); }
  }

  [System.Security.SecurityCriticalAttribute]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct Rect : System.IFormattable {
    public Rect(double x, double y, double width, double height) { throw new System.NotImplementedException(); }
    public Rect(Windows.Foundation.Point point1, Windows.Foundation.Point point2) { throw new System.NotImplementedException(); }
    public Rect(Windows.Foundation.Point location, Windows.Foundation.Size size) { throw new System.NotImplementedException(); }
    public double Bottom { get { return default(double); } }
    public static Windows.Foundation.Rect Empty { get { return default(Windows.Foundation.Rect); } }
    public double Height { get { return default(double); } set { } }
    public bool IsEmpty { get { return default(bool); } }
    public double Left { get { return default(double); } }
    public double Right { get { return default(double); } }
    public double Top { get { return default(double); } }
    public double Width { get { return default(double); } set { } }
    public double X { get { return default(double); } set { } }
    public double Y { get { return default(double); } set { } }
    public bool Contains(Windows.Foundation.Point point) { return default(bool); }
    [System.Security.SecuritySafeCriticalAttribute]
    public override bool Equals(object o) { return default(bool); }
    public bool Equals(Windows.Foundation.Rect value) { return default(bool); }
    [System.Security.SecuritySafeCriticalAttribute]
    public override int GetHashCode() { return default(int); }
    public void Intersect(Windows.Foundation.Rect rect) { }
    public static bool operator ==(Windows.Foundation.Rect rect1, Windows.Foundation.Rect rect2) { return default(bool); }
    public static bool operator !=(Windows.Foundation.Rect rect1, Windows.Foundation.Rect rect2) { return default(bool); }
    [System.Security.SecuritySafeCriticalAttribute]
    string System.IFormattable.ToString(string format, System.IFormatProvider provider) { return default(string); }
    [System.Security.SecuritySafeCriticalAttribute]
    public override string ToString() { return default(string); }
    public string ToString(System.IFormatProvider provider) { return default(string); }
    public void Union(Windows.Foundation.Point point) { }
    public void Union(Windows.Foundation.Rect rect) { }
  }

  [System.Security.SecurityCriticalAttribute]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct Size {
    public Size(double width, double height) { throw new System.NotImplementedException(); }
    public static Windows.Foundation.Size Empty { get { return default(Windows.Foundation.Size); } }
    public double Height { get { return default(double); } set { } }
    public bool IsEmpty { get { return default(bool); } }
    public double Width { get { return default(double); } set { } }
    [System.Security.SecuritySafeCriticalAttribute]
    public override bool Equals(object o) { return default(bool); }
    public bool Equals(Windows.Foundation.Size value) { return default(bool); }
    [System.Security.SecuritySafeCriticalAttribute]
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(Windows.Foundation.Size size1, Windows.Foundation.Size size2) { return default(bool); }
    public static bool operator !=(Windows.Foundation.Size size1, Windows.Foundation.Size size2) { return default(bool); }
    [System.Security.SecuritySafeCriticalAttribute]
    public override string ToString() { return default(string); }
  }

} // end of Windows.Foundation
namespace Windows.UI {
  [System.Security.SecurityCriticalAttribute]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct Color : System.IFormattable {
    public byte A { get { return default(byte); } set { } }
    public byte B { get { return default(byte); } set { } }
    public byte G { get { return default(byte); } set { } }
    public byte R { get { return default(byte); } set { } }
    [System.Security.SecuritySafeCriticalAttribute]
    public override bool Equals(object o) { return default(bool); }
    public bool Equals(Windows.UI.Color color) { return default(bool); }
    public static Windows.UI.Color FromArgb(byte a, byte r, byte g, byte b) { return default(Windows.UI.Color); }
    [System.Security.SecuritySafeCriticalAttribute]
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(Windows.UI.Color color1, Windows.UI.Color color2) { return default(bool); }
    public static bool operator !=(Windows.UI.Color color1, Windows.UI.Color color2) { return default(bool); }
    [System.Security.SecuritySafeCriticalAttribute]
    string System.IFormattable.ToString(string format, System.IFormatProvider provider) { return default(string); }
    [System.Security.SecuritySafeCriticalAttribute]
    public override string ToString() { return default(string); }
    public string ToString(System.IFormatProvider provider) { return default(string); }
  }

} // end of Windows.UI
namespace Windows.UI.Xaml {
  [System.Security.SecurityCriticalAttribute]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct CornerRadius {
    public CornerRadius(double uniformRadius) { throw new System.NotImplementedException(); }
    public CornerRadius(double topLeft, double topRight, double bottomRight, double bottomLeft) { throw new System.NotImplementedException(); }
    public double BottomLeft { get { return default(double); } set { } }
    public double BottomRight { get { return default(double); } set { } }
    public double TopLeft { get { return default(double); } set { } }
    public double TopRight { get { return default(double); } set { } }
    [System.Security.SecuritySafeCriticalAttribute]
    public override bool Equals(object obj) { return default(bool); }
    public bool Equals(Windows.UI.Xaml.CornerRadius cornerRadius) { return default(bool); }
    [System.Security.SecuritySafeCriticalAttribute]
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(Windows.UI.Xaml.CornerRadius cr1, Windows.UI.Xaml.CornerRadius cr2) { return default(bool); }
    public static bool operator !=(Windows.UI.Xaml.CornerRadius cr1, Windows.UI.Xaml.CornerRadius cr2) { return default(bool); }
    [System.Security.SecuritySafeCriticalAttribute]
    public override string ToString() { return default(string); }
  }

  [System.Security.SecurityCriticalAttribute]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct Duration {
    public Duration(System.TimeSpan timeSpan) { throw new System.NotImplementedException(); }
    public static Windows.UI.Xaml.Duration Automatic { get { return default(Windows.UI.Xaml.Duration); } }
    public static Windows.UI.Xaml.Duration Forever { get { return default(Windows.UI.Xaml.Duration); } }
    public bool HasTimeSpan { get { return default(bool); } }
    public System.TimeSpan TimeSpan { get { return default(System.TimeSpan); } }
    public Windows.UI.Xaml.Duration Add(Windows.UI.Xaml.Duration duration) { return default(Windows.UI.Xaml.Duration); }
    public static int Compare(Windows.UI.Xaml.Duration t1, Windows.UI.Xaml.Duration t2) { return default(int); }
    [System.Security.SecuritySafeCriticalAttribute]
    public override bool Equals(object value) { return default(bool); }
    public bool Equals(Windows.UI.Xaml.Duration duration) { return default(bool); }
    public static bool Equals(Windows.UI.Xaml.Duration t1, Windows.UI.Xaml.Duration t2) { return default(bool); }
    [System.Security.SecuritySafeCriticalAttribute]
    public override int GetHashCode() { return default(int); }
    public static Windows.UI.Xaml.Duration operator +(Windows.UI.Xaml.Duration t1, Windows.UI.Xaml.Duration t2) { return default(Windows.UI.Xaml.Duration); }
    public static bool operator ==(Windows.UI.Xaml.Duration t1, Windows.UI.Xaml.Duration t2) { return default(bool); }
    public static bool operator >(Windows.UI.Xaml.Duration t1, Windows.UI.Xaml.Duration t2) { return default(bool); }
    public static bool operator >=(Windows.UI.Xaml.Duration t1, Windows.UI.Xaml.Duration t2) { return default(bool); }
    public static implicit operator Windows.UI.Xaml.Duration (System.TimeSpan timeSpan) { return default(Windows.UI.Xaml.Duration); }
    public static bool operator !=(Windows.UI.Xaml.Duration t1, Windows.UI.Xaml.Duration t2) { return default(bool); }
    public static bool operator <(Windows.UI.Xaml.Duration t1, Windows.UI.Xaml.Duration t2) { return default(bool); }
    public static bool operator <=(Windows.UI.Xaml.Duration t1, Windows.UI.Xaml.Duration t2) { return default(bool); }
    public static Windows.UI.Xaml.Duration operator -(Windows.UI.Xaml.Duration t1, Windows.UI.Xaml.Duration t2) { return default(Windows.UI.Xaml.Duration); }
    public static Windows.UI.Xaml.Duration operator +(Windows.UI.Xaml.Duration duration) { return default(Windows.UI.Xaml.Duration); }
    public Windows.UI.Xaml.Duration Subtract(Windows.UI.Xaml.Duration duration) { return default(Windows.UI.Xaml.Duration); }
    [System.Security.SecuritySafeCriticalAttribute]
    public override string ToString() { return default(string); }
  }

  [System.Security.SecurityCriticalAttribute]
  public enum DurationType {
    Automatic = 0,
    Forever = 2,
    TimeSpan = 1,
  }

  [System.Security.SecurityCriticalAttribute]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct GridLength {
    public GridLength(double pixels) { throw new System.NotImplementedException(); }
    public GridLength(double value, Windows.UI.Xaml.GridUnitType type) { throw new System.NotImplementedException(); }
    public static Windows.UI.Xaml.GridLength Auto { get { return default(Windows.UI.Xaml.GridLength); } }
    public Windows.UI.Xaml.GridUnitType GridUnitType { get { return default(Windows.UI.Xaml.GridUnitType); } }
    public bool IsAbsolute { get { return default(bool); } }
    public bool IsAuto { get { return default(bool); } }
    public bool IsStar { get { return default(bool); } }
    public double Value { get { return default(double); } }
    [System.Security.SecuritySafeCriticalAttribute]
    public override bool Equals(object oCompare) { return default(bool); }
    public bool Equals(Windows.UI.Xaml.GridLength gridLength) { return default(bool); }
    [System.Security.SecuritySafeCriticalAttribute]
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(Windows.UI.Xaml.GridLength gl1, Windows.UI.Xaml.GridLength gl2) { return default(bool); }
    public static bool operator !=(Windows.UI.Xaml.GridLength gl1, Windows.UI.Xaml.GridLength gl2) { return default(bool); }
    [System.Security.SecuritySafeCriticalAttribute]
    public override string ToString() { return default(string); }
  }

  [System.Security.SecurityCriticalAttribute]
  public enum GridUnitType {
    Auto = 0,
    Pixel = 1,
    Star = 2,
  }

  [System.Security.SecurityCriticalAttribute]
  public partial class LayoutCycleException : System.Exception {
    public LayoutCycleException() { }
    public LayoutCycleException(string message) { }
    public LayoutCycleException(string message, System.Exception innerException) { }
  }

  [System.Security.SecurityCriticalAttribute]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct Thickness {
    public Thickness(double uniformLength) { throw new System.NotImplementedException(); }
    public Thickness(double left, double top, double right, double bottom) { throw new System.NotImplementedException(); }
    public double Bottom { get { return default(double); } set { } }
    public double Left { get { return default(double); } set { } }
    public double Right { get { return default(double); } set { } }
    public double Top { get { return default(double); } set { } }
    [System.Security.SecuritySafeCriticalAttribute]
    public override bool Equals(object obj) { return default(bool); }
    public bool Equals(Windows.UI.Xaml.Thickness thickness) { return default(bool); }
    [System.Security.SecuritySafeCriticalAttribute]
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(Windows.UI.Xaml.Thickness t1, Windows.UI.Xaml.Thickness t2) { return default(bool); }
    public static bool operator !=(Windows.UI.Xaml.Thickness t1, Windows.UI.Xaml.Thickness t2) { return default(bool); }
    [System.Security.SecuritySafeCriticalAttribute]
    public override string ToString() { return default(string); }
  }

} // end of Windows.UI.Xaml
namespace Windows.UI.Xaml.Automation {
  [System.Security.SecurityCriticalAttribute]
  public partial class ElementNotAvailableException : System.Exception {
    public ElementNotAvailableException() { }
    public ElementNotAvailableException(string message) { }
    public ElementNotAvailableException(string message, System.Exception innerException) { }
  }

  [System.Security.SecurityCriticalAttribute]
  public partial class ElementNotEnabledException : System.Exception {
    public ElementNotEnabledException() { }
    public ElementNotEnabledException(string message) { }
    public ElementNotEnabledException(string message, System.Exception innerException) { }
  }

} // end of Windows.UI.Xaml.Automation
namespace Windows.UI.Xaml.Controls.Primitives {
  [System.Security.SecurityCriticalAttribute]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct GeneratorPosition {
    public GeneratorPosition(int index, int offset) { throw new System.NotImplementedException(); }
    public int Index { get { return default(int); } set { } }
    public int Offset { get { return default(int); } set { } }
    [System.Security.SecuritySafeCriticalAttribute]
    public override bool Equals(object o) { return default(bool); }
    [System.Security.SecuritySafeCriticalAttribute]
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(Windows.UI.Xaml.Controls.Primitives.GeneratorPosition gp1, Windows.UI.Xaml.Controls.Primitives.GeneratorPosition gp2) { return default(bool); }
    public static bool operator !=(Windows.UI.Xaml.Controls.Primitives.GeneratorPosition gp1, Windows.UI.Xaml.Controls.Primitives.GeneratorPosition gp2) { return default(bool); }
    [System.Security.SecuritySafeCriticalAttribute]
    public override string ToString() { return default(string); }
  }

} // end of Windows.UI.Xaml.Controls.Primitives
namespace Windows.UI.Xaml.Markup {
  [System.Security.SecurityCriticalAttribute]
  public partial class XamlParseException : System.Exception {
    public XamlParseException() { }
    public XamlParseException(string message) { }
    public XamlParseException(string message, System.Exception innerException) { }
  }

} // end of Windows.UI.Xaml.Markup
namespace Windows.UI.Xaml.Media {
  [System.Security.SecurityCriticalAttribute]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct Matrix : System.IFormattable {
    public Matrix(double m11, double m12, double m21, double m22, double offsetX, double offsetY) { throw new System.NotImplementedException(); }
    public static Windows.UI.Xaml.Media.Matrix Identity { get { return default(Windows.UI.Xaml.Media.Matrix); } }
    public bool IsIdentity { get { return default(bool); } }
    public double M11 { get { return default(double); } set { } }
    public double M12 { get { return default(double); } set { } }
    public double M21 { get { return default(double); } set { } }
    public double M22 { get { return default(double); } set { } }
    public double OffsetX { get { return default(double); } set { } }
    public double OffsetY { get { return default(double); } set { } }
    [System.Security.SecuritySafeCriticalAttribute]
    public override bool Equals(object o) { return default(bool); }
    public bool Equals(Windows.UI.Xaml.Media.Matrix value) { return default(bool); }
    [System.Security.SecuritySafeCriticalAttribute]
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(Windows.UI.Xaml.Media.Matrix matrix1, Windows.UI.Xaml.Media.Matrix matrix2) { return default(bool); }
    public static bool operator !=(Windows.UI.Xaml.Media.Matrix matrix1, Windows.UI.Xaml.Media.Matrix matrix2) { return default(bool); }
    [System.Security.SecuritySafeCriticalAttribute]
    string System.IFormattable.ToString(string format, System.IFormatProvider provider) { return default(string); }
    [System.Security.SecuritySafeCriticalAttribute]
    public override string ToString() { return default(string); }
    public string ToString(System.IFormatProvider provider) { return default(string); }
    public Windows.Foundation.Point Transform(Windows.Foundation.Point point) { return default(Windows.Foundation.Point); }
  }

} // end of Windows.UI.Xaml.Media
namespace Windows.UI.Xaml.Media.Animation {
  [System.Security.SecurityCriticalAttribute]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct KeyTime {
    public System.TimeSpan TimeSpan { get { return default(System.TimeSpan); } }
    [System.Security.SecuritySafeCriticalAttribute]
    public override bool Equals(object value) { return default(bool); }
    public bool Equals(Windows.UI.Xaml.Media.Animation.KeyTime value) { return default(bool); }
    public static bool Equals(Windows.UI.Xaml.Media.Animation.KeyTime keyTime1, Windows.UI.Xaml.Media.Animation.KeyTime keyTime2) { return default(bool); }
    public static Windows.UI.Xaml.Media.Animation.KeyTime FromTimeSpan(System.TimeSpan timeSpan) { return default(Windows.UI.Xaml.Media.Animation.KeyTime); }
    [System.Security.SecuritySafeCriticalAttribute]
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(Windows.UI.Xaml.Media.Animation.KeyTime keyTime1, Windows.UI.Xaml.Media.Animation.KeyTime keyTime2) { return default(bool); }
    public static implicit operator Windows.UI.Xaml.Media.Animation.KeyTime (System.TimeSpan timeSpan) { return default(Windows.UI.Xaml.Media.Animation.KeyTime); }
    public static bool operator !=(Windows.UI.Xaml.Media.Animation.KeyTime keyTime1, Windows.UI.Xaml.Media.Animation.KeyTime keyTime2) { return default(bool); }
    [System.Security.SecuritySafeCriticalAttribute]
    public override string ToString() { return default(string); }
  }

  [System.Security.SecurityCriticalAttribute]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct RepeatBehavior : System.IFormattable {
    public RepeatBehavior(double count) { throw new System.NotImplementedException(); }
    public RepeatBehavior(System.TimeSpan duration) { throw new System.NotImplementedException(); }
    public double Count { get { return default(double); } set { } }
    public System.TimeSpan Duration { get { return default(System.TimeSpan); } set { } }
    public static Windows.UI.Xaml.Media.Animation.RepeatBehavior Forever { get { return default(Windows.UI.Xaml.Media.Animation.RepeatBehavior); } }
    public bool HasCount { get { return default(bool); } }
    public bool HasDuration { get { return default(bool); } }
    public Windows.UI.Xaml.Media.Animation.RepeatBehaviorType Type { get { return default(Windows.UI.Xaml.Media.Animation.RepeatBehaviorType); } set { } }
    [System.Security.SecuritySafeCriticalAttribute]
    public override bool Equals(object value) { return default(bool); }
    public bool Equals(Windows.UI.Xaml.Media.Animation.RepeatBehavior repeatBehavior) { return default(bool); }
    public static bool Equals(Windows.UI.Xaml.Media.Animation.RepeatBehavior repeatBehavior1, Windows.UI.Xaml.Media.Animation.RepeatBehavior repeatBehavior2) { return default(bool); }
    [System.Security.SecuritySafeCriticalAttribute]
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(Windows.UI.Xaml.Media.Animation.RepeatBehavior repeatBehavior1, Windows.UI.Xaml.Media.Animation.RepeatBehavior repeatBehavior2) { return default(bool); }
    public static bool operator !=(Windows.UI.Xaml.Media.Animation.RepeatBehavior repeatBehavior1, Windows.UI.Xaml.Media.Animation.RepeatBehavior repeatBehavior2) { return default(bool); }
    [System.Security.SecuritySafeCriticalAttribute]
    string System.IFormattable.ToString(string format, System.IFormatProvider formatProvider) { return default(string); }
    [System.Security.SecuritySafeCriticalAttribute]
    public override string ToString() { return default(string); }
    public string ToString(System.IFormatProvider formatProvider) { return default(string); }
  }

  [System.Security.SecurityCriticalAttribute]
  public enum RepeatBehaviorType {
    Count = 0,
    Duration = 1,
    Forever = 2,
  }

} // end of Windows.UI.Xaml.Media.Animation
namespace Windows.UI.Xaml.Media.Media3D {
  [System.Security.SecurityCriticalAttribute]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct Matrix3D : System.IFormattable {
    public Matrix3D(double m11, double m12, double m13, double m14, double m21, double m22, double m23, double m24, double m31, double m32, double m33, double m34, double offsetX, double offsetY, double offsetZ, double m44) { throw new System.NotImplementedException(); }
    public bool HasInverse { get { return default(bool); } }
    public static Windows.UI.Xaml.Media.Media3D.Matrix3D Identity { get { return default(Windows.UI.Xaml.Media.Media3D.Matrix3D); } }
    public bool IsIdentity { get { return default(bool); } }
    public double M11 { get { return default(double); } set { } }
    public double M12 { get { return default(double); } set { } }
    public double M13 { get { return default(double); } set { } }
    public double M14 { get { return default(double); } set { } }
    public double M21 { get { return default(double); } set { } }
    public double M22 { get { return default(double); } set { } }
    public double M23 { get { return default(double); } set { } }
    public double M24 { get { return default(double); } set { } }
    public double M31 { get { return default(double); } set { } }
    public double M32 { get { return default(double); } set { } }
    public double M33 { get { return default(double); } set { } }
    public double M34 { get { return default(double); } set { } }
    public double M44 { get { return default(double); } set { } }
    public double OffsetX { get { return default(double); } set { } }
    public double OffsetY { get { return default(double); } set { } }
    public double OffsetZ { get { return default(double); } set { } }
    [System.Security.SecuritySafeCriticalAttribute]
    public override bool Equals(object o) { return default(bool); }
    public bool Equals(Windows.UI.Xaml.Media.Media3D.Matrix3D value) { return default(bool); }
    [System.Security.SecuritySafeCriticalAttribute]
    public override int GetHashCode() { return default(int); }
    public void Invert() { }
    public static bool operator ==(Windows.UI.Xaml.Media.Media3D.Matrix3D matrix1, Windows.UI.Xaml.Media.Media3D.Matrix3D matrix2) { return default(bool); }
    public static bool operator !=(Windows.UI.Xaml.Media.Media3D.Matrix3D matrix1, Windows.UI.Xaml.Media.Media3D.Matrix3D matrix2) { return default(bool); }
    public static Windows.UI.Xaml.Media.Media3D.Matrix3D operator *(Windows.UI.Xaml.Media.Media3D.Matrix3D matrix1, Windows.UI.Xaml.Media.Media3D.Matrix3D matrix2) { return default(Windows.UI.Xaml.Media.Media3D.Matrix3D); }
    [System.Security.SecuritySafeCriticalAttribute]
    string System.IFormattable.ToString(string format, System.IFormatProvider provider) { return default(string); }
    [System.Security.SecuritySafeCriticalAttribute]
    public override string ToString() { return default(string); }
    public string ToString(System.IFormatProvider provider) { return default(string); }
  }

} // end of Windows.UI.Xaml.Media.Media3D
namespace System.Security.Cryptography {
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct ECCurve {
    public byte[] A;
    public byte[] B;
    public byte[] Cofactor;
    public System.Security.Cryptography.ECCurve.ECCurveType CurveType;
    public System.Security.Cryptography.ECPoint G;
    public System.Nullable<System.Security.Cryptography.HashAlgorithmName> Hash;
    public byte[] Order;
    public byte[] Polynomial;
    public byte[] Prime;
    public byte[] Seed;
    public bool IsCharacteristic2 { get { return default(bool); } }
    public bool IsExplicit { get { return default(bool); } }
    public bool IsNamed { get { return default(bool); } }
    public bool IsPrime { get { return default(bool); } }
    public System.Security.Cryptography.Oid Oid { get { return default(System.Security.Cryptography.Oid); } }
    public static System.Security.Cryptography.ECCurve CreateFromFriendlyName(string oidFriendlyName) { return default(System.Security.Cryptography.ECCurve); }
    public static System.Security.Cryptography.ECCurve CreateFromOid(System.Security.Cryptography.Oid curveOid) { return default(System.Security.Cryptography.ECCurve); }
    public static System.Security.Cryptography.ECCurve CreateFromValue(string oidValue) { return default(System.Security.Cryptography.ECCurve); }
    public void Validate() { }
    public enum ECCurveType {
      Characteristic2 = 4,
      Implicit = 0,
      Named = 5,
      PrimeMontgomery = 3,
      PrimeShortWeierstrass = 1,
      PrimeTwistedEdwards = 2,
    }
    public static partial class NamedCurves {
      public static System.Security.Cryptography.ECCurve brainpoolP160r1 { get { return default(System.Security.Cryptography.ECCurve); } }
      public static System.Security.Cryptography.ECCurve brainpoolP160t1 { get { return default(System.Security.Cryptography.ECCurve); } }
      public static System.Security.Cryptography.ECCurve brainpoolP192r1 { get { return default(System.Security.Cryptography.ECCurve); } }
      public static System.Security.Cryptography.ECCurve brainpoolP192t1 { get { return default(System.Security.Cryptography.ECCurve); } }
      public static System.Security.Cryptography.ECCurve brainpoolP224r1 { get { return default(System.Security.Cryptography.ECCurve); } }
      public static System.Security.Cryptography.ECCurve brainpoolP224t1 { get { return default(System.Security.Cryptography.ECCurve); } }
      public static System.Security.Cryptography.ECCurve brainpoolP256r1 { get { return default(System.Security.Cryptography.ECCurve); } }
      public static System.Security.Cryptography.ECCurve brainpoolP256t1 { get { return default(System.Security.Cryptography.ECCurve); } }
      public static System.Security.Cryptography.ECCurve brainpoolP320r1 { get { return default(System.Security.Cryptography.ECCurve); } }
      public static System.Security.Cryptography.ECCurve brainpoolP320t1 { get { return default(System.Security.Cryptography.ECCurve); } }
      public static System.Security.Cryptography.ECCurve brainpoolP384r1 { get { return default(System.Security.Cryptography.ECCurve); } }
      public static System.Security.Cryptography.ECCurve brainpoolP384t1 { get { return default(System.Security.Cryptography.ECCurve); } }
      public static System.Security.Cryptography.ECCurve brainpoolP512r1 { get { return default(System.Security.Cryptography.ECCurve); } }
      public static System.Security.Cryptography.ECCurve brainpoolP512t1 { get { return default(System.Security.Cryptography.ECCurve); } }
      public static System.Security.Cryptography.ECCurve nistP256 { get { return default(System.Security.Cryptography.ECCurve); } }
      public static System.Security.Cryptography.ECCurve nistP384 { get { return default(System.Security.Cryptography.ECCurve); } }
      public static System.Security.Cryptography.ECCurve nistP521 { get { return default(System.Security.Cryptography.ECCurve); } }
    }
  }

  public abstract partial class ECDsa : System.Security.Cryptography.AsymmetricAlgorithm {
    protected ECDsa() { }
    public static System.Security.Cryptography.ECDsa Create() { return default(System.Security.Cryptography.ECDsa); }
    public static System.Security.Cryptography.ECDsa Create(System.Security.Cryptography.ECCurve curve) { return default(System.Security.Cryptography.ECDsa); }
    public static System.Security.Cryptography.ECDsa Create(System.Security.Cryptography.ECParameters parameters) { return default(System.Security.Cryptography.ECDsa); }
    public virtual System.Security.Cryptography.ECParameters ExportExplicitParameters(bool includePrivateParameters) { return default(System.Security.Cryptography.ECParameters); }
    public virtual System.Security.Cryptography.ECParameters ExportParameters(bool includePrivateParameters) { return default(System.Security.Cryptography.ECParameters); }
    public virtual void GenerateKey(System.Security.Cryptography.ECCurve curve) { }
    protected abstract byte[] HashData(byte[] data, int offset, int count, System.Security.Cryptography.HashAlgorithmName hashAlgorithm);
    protected abstract byte[] HashData(System.IO.Stream data, System.Security.Cryptography.HashAlgorithmName hashAlgorithm);
    public virtual void ImportParameters(System.Security.Cryptography.ECParameters parameters) { }
    public virtual byte[] SignData(byte[] data, int offset, int count, System.Security.Cryptography.HashAlgorithmName hashAlgorithm) { return default(byte[]); }
    public virtual byte[] SignData(byte[] data, System.Security.Cryptography.HashAlgorithmName hashAlgorithm) { return default(byte[]); }
    public virtual byte[] SignData(System.IO.Stream data, System.Security.Cryptography.HashAlgorithmName hashAlgorithm) { return default(byte[]); }
    public abstract byte[] SignHash(byte[] hash);
    public bool VerifyData(byte[] data, byte[] signature, System.Security.Cryptography.HashAlgorithmName hashAlgorithm) { return default(bool); }
    public virtual bool VerifyData(byte[] data, int offset, int count, byte[] signature, System.Security.Cryptography.HashAlgorithmName hashAlgorithm) { return default(bool); }
    public bool VerifyData(System.IO.Stream data, byte[] signature, System.Security.Cryptography.HashAlgorithmName hashAlgorithm) { return default(bool); }
    public abstract bool VerifyHash(byte[] hash, byte[] signature);
  }

  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct ECParameters {
    public System.Security.Cryptography.ECCurve Curve;
    public byte[] D;
    public System.Security.Cryptography.ECPoint Q;
    public void Validate() { }
  }

  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct ECPoint {
    public byte[] X;
    public byte[] Y;
  }

  public sealed partial class IncrementalHash : System.IDisposable {
    internal IncrementalHash() { }
    public System.Security.Cryptography.HashAlgorithmName AlgorithmName { get { return default(System.Security.Cryptography.HashAlgorithmName); } }
    public void AppendData(byte[] data) { }
    public void AppendData(byte[] data, int offset, int count) { }
    public static System.Security.Cryptography.IncrementalHash CreateHash(System.Security.Cryptography.HashAlgorithmName hashAlgorithm) { return default(System.Security.Cryptography.IncrementalHash); }
    public static System.Security.Cryptography.IncrementalHash CreateHMAC(System.Security.Cryptography.HashAlgorithmName hashAlgorithm, byte[] key) { return default(System.Security.Cryptography.IncrementalHash); }
    public void Dispose() { }
    public byte[] GetHashAndReset() { return default(byte[]); }
  }

  public sealed partial class RSAEncryptionPadding : System.IEquatable<System.Security.Cryptography.RSAEncryptionPadding> {
    internal RSAEncryptionPadding() { }
    public System.Security.Cryptography.RSAEncryptionPaddingMode Mode { get { return default(System.Security.Cryptography.RSAEncryptionPaddingMode); } }
    public System.Security.Cryptography.HashAlgorithmName OaepHashAlgorithm { get { return default(System.Security.Cryptography.HashAlgorithmName); } }
    public static System.Security.Cryptography.RSAEncryptionPadding OaepSHA1 { get { return default(System.Security.Cryptography.RSAEncryptionPadding); } }
    public static System.Security.Cryptography.RSAEncryptionPadding OaepSHA256 { get { return default(System.Security.Cryptography.RSAEncryptionPadding); } }
    public static System.Security.Cryptography.RSAEncryptionPadding OaepSHA384 { get { return default(System.Security.Cryptography.RSAEncryptionPadding); } }
    public static System.Security.Cryptography.RSAEncryptionPadding OaepSHA512 { get { return default(System.Security.Cryptography.RSAEncryptionPadding); } }
    public static System.Security.Cryptography.RSAEncryptionPadding Pkcs1 { get { return default(System.Security.Cryptography.RSAEncryptionPadding); } }
    public static System.Security.Cryptography.RSAEncryptionPadding CreateOaep(System.Security.Cryptography.HashAlgorithmName hashAlgorithm) { return default(System.Security.Cryptography.RSAEncryptionPadding); }
    public override bool Equals(object obj) { return default(bool); }
    public bool Equals(System.Security.Cryptography.RSAEncryptionPadding other) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.Security.Cryptography.RSAEncryptionPadding left, System.Security.Cryptography.RSAEncryptionPadding right) { return default(bool); }
    public static bool operator !=(System.Security.Cryptography.RSAEncryptionPadding left, System.Security.Cryptography.RSAEncryptionPadding right) { return default(bool); }
    public override string ToString() { return default(string); }
  }

  public enum RSAEncryptionPaddingMode {
    Oaep = 1,
    Pkcs1 = 0,
  }

  public sealed partial class RSASignaturePadding : System.IEquatable<System.Security.Cryptography.RSASignaturePadding> {
    internal RSASignaturePadding() { }
    public System.Security.Cryptography.RSASignaturePaddingMode Mode { get { return default(System.Security.Cryptography.RSASignaturePaddingMode); } }
    public static System.Security.Cryptography.RSASignaturePadding Pkcs1 { get { return default(System.Security.Cryptography.RSASignaturePadding); } }
    public static System.Security.Cryptography.RSASignaturePadding Pss { get { return default(System.Security.Cryptography.RSASignaturePadding); } }
    public override bool Equals(object obj) { return default(bool); }
    public bool Equals(System.Security.Cryptography.RSASignaturePadding other) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.Security.Cryptography.RSASignaturePadding left, System.Security.Cryptography.RSASignaturePadding right) { return default(bool); }
    public static bool operator !=(System.Security.Cryptography.RSASignaturePadding left, System.Security.Cryptography.RSASignaturePadding right) { return default(bool); }
    public override string ToString() { return default(string); }
  }

  public enum RSASignaturePaddingMode {
    Pkcs1 = 0,
    Pss = 1,
  }

  public sealed partial class CngAlgorithm : System.IEquatable<System.Security.Cryptography.CngAlgorithm> {
    public CngAlgorithm(string algorithm) { }
    public string Algorithm { get { return default(string); } }
    public static System.Security.Cryptography.CngAlgorithm ECDiffieHellmanP256 { get { return default(System.Security.Cryptography.CngAlgorithm); } }
    public static System.Security.Cryptography.CngAlgorithm ECDiffieHellmanP384 { get { return default(System.Security.Cryptography.CngAlgorithm); } }
    public static System.Security.Cryptography.CngAlgorithm ECDiffieHellmanP521 { get { return default(System.Security.Cryptography.CngAlgorithm); } }
    public static System.Security.Cryptography.CngAlgorithm ECDsaP256 { get { return default(System.Security.Cryptography.CngAlgorithm); } }
    public static System.Security.Cryptography.CngAlgorithm ECDsaP384 { get { return default(System.Security.Cryptography.CngAlgorithm); } }
    public static System.Security.Cryptography.CngAlgorithm ECDsaP521 { get { return default(System.Security.Cryptography.CngAlgorithm); } }
    public static System.Security.Cryptography.CngAlgorithm MD5 { get { return default(System.Security.Cryptography.CngAlgorithm); } }
    public static System.Security.Cryptography.CngAlgorithm Rsa { get { return default(System.Security.Cryptography.CngAlgorithm); } }
    public static System.Security.Cryptography.CngAlgorithm Sha1 { get { return default(System.Security.Cryptography.CngAlgorithm); } }
    public static System.Security.Cryptography.CngAlgorithm Sha256 { get { return default(System.Security.Cryptography.CngAlgorithm); } }
    public static System.Security.Cryptography.CngAlgorithm Sha384 { get { return default(System.Security.Cryptography.CngAlgorithm); } }
    public static System.Security.Cryptography.CngAlgorithm Sha512 { get { return default(System.Security.Cryptography.CngAlgorithm); } }
    public override bool Equals(object obj) { return default(bool); }
    public bool Equals(System.Security.Cryptography.CngAlgorithm other) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.Security.Cryptography.CngAlgorithm left, System.Security.Cryptography.CngAlgorithm right) { return default(bool); }
    public static bool operator !=(System.Security.Cryptography.CngAlgorithm left, System.Security.Cryptography.CngAlgorithm right) { return default(bool); }
    public override string ToString() { return default(string); }
  }

  public sealed partial class CngAlgorithmGroup : System.IEquatable<System.Security.Cryptography.CngAlgorithmGroup> {
    public CngAlgorithmGroup(string algorithmGroup) { }
    public string AlgorithmGroup { get { return default(string); } }
    public static System.Security.Cryptography.CngAlgorithmGroup DiffieHellman { get { return default(System.Security.Cryptography.CngAlgorithmGroup); } }
    public static System.Security.Cryptography.CngAlgorithmGroup Dsa { get { return default(System.Security.Cryptography.CngAlgorithmGroup); } }
    public static System.Security.Cryptography.CngAlgorithmGroup ECDiffieHellman { get { return default(System.Security.Cryptography.CngAlgorithmGroup); } }
    public static System.Security.Cryptography.CngAlgorithmGroup ECDsa { get { return default(System.Security.Cryptography.CngAlgorithmGroup); } }
    public static System.Security.Cryptography.CngAlgorithmGroup Rsa { get { return default(System.Security.Cryptography.CngAlgorithmGroup); } }
    public override bool Equals(object obj) { return default(bool); }
    public bool Equals(System.Security.Cryptography.CngAlgorithmGroup other) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.Security.Cryptography.CngAlgorithmGroup left, System.Security.Cryptography.CngAlgorithmGroup right) { return default(bool); }
    public static bool operator !=(System.Security.Cryptography.CngAlgorithmGroup left, System.Security.Cryptography.CngAlgorithmGroup right) { return default(bool); }
    public override string ToString() { return default(string); }
  }

  [System.FlagsAttribute]
  public enum CngExportPolicies {
    AllowArchiving = 4,
    AllowExport = 1,
    AllowPlaintextArchiving = 8,
    AllowPlaintextExport = 2,
    None = 0,
  }

  public sealed partial class CngKey : System.IDisposable {
    internal CngKey() { }
    public System.Security.Cryptography.CngAlgorithm Algorithm { get { return default(System.Security.Cryptography.CngAlgorithm); } }
    public System.Security.Cryptography.CngAlgorithmGroup AlgorithmGroup { get { return default(System.Security.Cryptography.CngAlgorithmGroup); } }
    public System.Security.Cryptography.CngExportPolicies ExportPolicy { get { return default(System.Security.Cryptography.CngExportPolicies); } }
    public Microsoft.Win32.SafeHandles.SafeNCryptKeyHandle Handle { get { return default(Microsoft.Win32.SafeHandles.SafeNCryptKeyHandle); } }
    public bool IsEphemeral { get { return default(bool); } }
    public bool IsMachineKey { get { return default(bool); } }
    public string KeyName { get { return default(string); } }
    public int KeySize { get { return default(int); } }
    public System.Security.Cryptography.CngKeyUsages KeyUsage { get { return default(System.Security.Cryptography.CngKeyUsages); } }
    public System.IntPtr ParentWindowHandle { get { return default(System.IntPtr); } set { } }
    public System.Security.Cryptography.CngProvider Provider { get { return default(System.Security.Cryptography.CngProvider); } }
    public Microsoft.Win32.SafeHandles.SafeNCryptProviderHandle ProviderHandle { get { return default(Microsoft.Win32.SafeHandles.SafeNCryptProviderHandle); } }
    public System.Security.Cryptography.CngUIPolicy UIPolicy { get { return default(System.Security.Cryptography.CngUIPolicy); } }
    public string UniqueName { get { return default(string); } }
    public static System.Security.Cryptography.CngKey Create(System.Security.Cryptography.CngAlgorithm algorithm) { return default(System.Security.Cryptography.CngKey); }
    public static System.Security.Cryptography.CngKey Create(System.Security.Cryptography.CngAlgorithm algorithm, string keyName) { return default(System.Security.Cryptography.CngKey); }
    public static System.Security.Cryptography.CngKey Create(System.Security.Cryptography.CngAlgorithm algorithm, string keyName, System.Security.Cryptography.CngKeyCreationParameters creationParameters) { return default(System.Security.Cryptography.CngKey); }
    public void Delete() { }
    public void Dispose() { }
    public static bool Exists(string keyName) { return default(bool); }
    public static bool Exists(string keyName, System.Security.Cryptography.CngProvider provider) { return default(bool); }
    public static bool Exists(string keyName, System.Security.Cryptography.CngProvider provider, System.Security.Cryptography.CngKeyOpenOptions options) { return default(bool); }
    public byte[] Export(System.Security.Cryptography.CngKeyBlobFormat format) { return default(byte[]); }
    public System.Security.Cryptography.CngProperty GetProperty(string name, System.Security.Cryptography.CngPropertyOptions options) { return default(System.Security.Cryptography.CngProperty); }
    public bool HasProperty(string name, System.Security.Cryptography.CngPropertyOptions options) { return default(bool); }
    public static System.Security.Cryptography.CngKey Import(byte[] keyBlob, System.Security.Cryptography.CngKeyBlobFormat format) { return default(System.Security.Cryptography.CngKey); }
    public static System.Security.Cryptography.CngKey Import(byte[] keyBlob, System.Security.Cryptography.CngKeyBlobFormat format, System.Security.Cryptography.CngProvider provider) { return default(System.Security.Cryptography.CngKey); }
    public static System.Security.Cryptography.CngKey Open(Microsoft.Win32.SafeHandles.SafeNCryptKeyHandle keyHandle, System.Security.Cryptography.CngKeyHandleOpenOptions keyHandleOpenOptions) { return default(System.Security.Cryptography.CngKey); }
    public static System.Security.Cryptography.CngKey Open(string keyName) { return default(System.Security.Cryptography.CngKey); }
    public static System.Security.Cryptography.CngKey Open(string keyName, System.Security.Cryptography.CngProvider provider) { return default(System.Security.Cryptography.CngKey); }
    public static System.Security.Cryptography.CngKey Open(string keyName, System.Security.Cryptography.CngProvider provider, System.Security.Cryptography.CngKeyOpenOptions openOptions) { return default(System.Security.Cryptography.CngKey); }
    public void SetProperty(System.Security.Cryptography.CngProperty property) { }
  }

  public sealed partial class CngKeyBlobFormat : System.IEquatable<System.Security.Cryptography.CngKeyBlobFormat> {
    public CngKeyBlobFormat(string format) { }
    public static System.Security.Cryptography.CngKeyBlobFormat EccPrivateBlob { get { return default(System.Security.Cryptography.CngKeyBlobFormat); } }
    public static System.Security.Cryptography.CngKeyBlobFormat EccPublicBlob { get { return default(System.Security.Cryptography.CngKeyBlobFormat); } }
    public string Format { get { return default(string); } }
    public static System.Security.Cryptography.CngKeyBlobFormat GenericPrivateBlob { get { return default(System.Security.Cryptography.CngKeyBlobFormat); } }
    public static System.Security.Cryptography.CngKeyBlobFormat GenericPublicBlob { get { return default(System.Security.Cryptography.CngKeyBlobFormat); } }
    public static System.Security.Cryptography.CngKeyBlobFormat OpaqueTransportBlob { get { return default(System.Security.Cryptography.CngKeyBlobFormat); } }
    public static System.Security.Cryptography.CngKeyBlobFormat Pkcs8PrivateBlob { get { return default(System.Security.Cryptography.CngKeyBlobFormat); } }
    public override bool Equals(object obj) { return default(bool); }
    public bool Equals(System.Security.Cryptography.CngKeyBlobFormat other) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.Security.Cryptography.CngKeyBlobFormat left, System.Security.Cryptography.CngKeyBlobFormat right) { return default(bool); }
    public static bool operator !=(System.Security.Cryptography.CngKeyBlobFormat left, System.Security.Cryptography.CngKeyBlobFormat right) { return default(bool); }
    public override string ToString() { return default(string); }
  }

  [System.FlagsAttribute]
  public enum CngKeyCreationOptions {
    MachineKey = 32,
    None = 0,
    OverwriteExistingKey = 128,
  }

  public sealed partial class CngKeyCreationParameters {
    public CngKeyCreationParameters() { }
    public System.Nullable<System.Security.Cryptography.CngExportPolicies> ExportPolicy { get { return default(System.Nullable<System.Security.Cryptography.CngExportPolicies>); } set { } }
    public System.Security.Cryptography.CngKeyCreationOptions KeyCreationOptions { get { return default(System.Security.Cryptography.CngKeyCreationOptions); } set { } }
    public System.Nullable<System.Security.Cryptography.CngKeyUsages> KeyUsage { get { return default(System.Nullable<System.Security.Cryptography.CngKeyUsages>); } set { } }
    public System.Security.Cryptography.CngPropertyCollection Parameters { get { return default(System.Security.Cryptography.CngPropertyCollection); } }
    public System.IntPtr ParentWindowHandle { get { return default(System.IntPtr); } set { } }
    public System.Security.Cryptography.CngProvider Provider { get { return default(System.Security.Cryptography.CngProvider); } set { } }
    public System.Security.Cryptography.CngUIPolicy UIPolicy { get { return default(System.Security.Cryptography.CngUIPolicy); } set { } }
  }

  [System.FlagsAttribute]
  public enum CngKeyHandleOpenOptions {
    EphemeralKey = 1,
    None = 0,
  }

  [System.FlagsAttribute]
  public enum CngKeyOpenOptions {
    MachineKey = 32,
    None = 0,
    Silent = 64,
    UserKey = 0,
  }

  [System.FlagsAttribute]
  public enum CngKeyUsages {
    AllUsages = 16777215,
    Decryption = 1,
    KeyAgreement = 4,
    None = 0,
    Signing = 2,
  }

  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct CngProperty : System.IEquatable<System.Security.Cryptography.CngProperty> {
    public CngProperty(string name, byte[] value, System.Security.Cryptography.CngPropertyOptions options) { throw new System.NotImplementedException(); }
    public string Name { get { return default(string); } }
    public System.Security.Cryptography.CngPropertyOptions Options { get { return default(System.Security.Cryptography.CngPropertyOptions); } }
    public override bool Equals(object obj) { return default(bool); }
    public bool Equals(System.Security.Cryptography.CngProperty other) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public byte[] GetValue() { return default(byte[]); }
    public static bool operator ==(System.Security.Cryptography.CngProperty left, System.Security.Cryptography.CngProperty right) { return default(bool); }
    public static bool operator !=(System.Security.Cryptography.CngProperty left, System.Security.Cryptography.CngProperty right) { return default(bool); }
  }

  public sealed partial class CngPropertyCollection : System.Collections.ObjectModel.Collection<System.Security.Cryptography.CngProperty> {
    public CngPropertyCollection() { }
  }

  [System.FlagsAttribute]
  public enum CngPropertyOptions {
    CustomProperty = 1073741824,
    None = 0,
    Persist = -2147483648,
  }

  public sealed partial class CngProvider : System.IEquatable<System.Security.Cryptography.CngProvider> {
    public CngProvider(string provider) { }
    public static System.Security.Cryptography.CngProvider MicrosoftSmartCardKeyStorageProvider { get { return default(System.Security.Cryptography.CngProvider); } }
    public static System.Security.Cryptography.CngProvider MicrosoftSoftwareKeyStorageProvider { get { return default(System.Security.Cryptography.CngProvider); } }
    public string Provider { get { return default(string); } }
    public override bool Equals(object obj) { return default(bool); }
    public bool Equals(System.Security.Cryptography.CngProvider other) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.Security.Cryptography.CngProvider left, System.Security.Cryptography.CngProvider right) { return default(bool); }
    public static bool operator !=(System.Security.Cryptography.CngProvider left, System.Security.Cryptography.CngProvider right) { return default(bool); }
    public override string ToString() { return default(string); }
  }

  public sealed partial class CngUIPolicy {
    public CngUIPolicy(System.Security.Cryptography.CngUIProtectionLevels protectionLevel) { }
    public CngUIPolicy(System.Security.Cryptography.CngUIProtectionLevels protectionLevel, string friendlyName) { }
    public CngUIPolicy(System.Security.Cryptography.CngUIProtectionLevels protectionLevel, string friendlyName, string description) { }
    public CngUIPolicy(System.Security.Cryptography.CngUIProtectionLevels protectionLevel, string friendlyName, string description, string useContext) { }
    public CngUIPolicy(System.Security.Cryptography.CngUIProtectionLevels protectionLevel, string friendlyName, string description, string useContext, string creationTitle) { }
    public string CreationTitle { get { return default(string); } }
    public string Description { get { return default(string); } }
    public string FriendlyName { get { return default(string); } }
    public System.Security.Cryptography.CngUIProtectionLevels ProtectionLevel { get { return default(System.Security.Cryptography.CngUIProtectionLevels); } }
    public string UseContext { get { return default(string); } }
  }

  [System.FlagsAttribute]
  public enum CngUIProtectionLevels {
    ForceHighProtection = 2,
    None = 0,
    ProtectKey = 1,
  }

  public sealed partial class ECDsaCng : System.Security.Cryptography.ECDsa {
    public ECDsaCng() { }
    public ECDsaCng(int keySize) { }
    public ECDsaCng(System.Security.Cryptography.CngKey key) { }
    public System.Security.Cryptography.CngKey Key { get { return default(System.Security.Cryptography.CngKey); } }
    public override System.Security.Cryptography.KeySizes[] LegalKeySizes { get { return default(System.Security.Cryptography.KeySizes[]); } }
    protected override void Dispose(bool disposing) { }
    protected override byte[] HashData(byte[] data, int offset, int count, System.Security.Cryptography.HashAlgorithmName hashAlgorithm) { return default(byte[]); }
    protected override byte[] HashData(System.IO.Stream data, System.Security.Cryptography.HashAlgorithmName hashAlgorithm) { return default(byte[]); }
    public override byte[] SignHash(byte[] hash) { return default(byte[]); }
    public override bool VerifyHash(byte[] hash, byte[] signature) { return default(bool); }
  }

  public sealed partial class RSACng : System.Security.Cryptography.RSA {
    public RSACng() { }
    public RSACng(int keySize) { }
    public RSACng(System.Security.Cryptography.CngKey key) { }
    public System.Security.Cryptography.CngKey Key { get { return default(System.Security.Cryptography.CngKey); } }
    public override System.Security.Cryptography.KeySizes[] LegalKeySizes { get { return default(System.Security.Cryptography.KeySizes[]); } }
    public override byte[] Decrypt(byte[] data, System.Security.Cryptography.RSAEncryptionPadding padding) { return default(byte[]); }
    protected override void Dispose(bool disposing) { }
    public override byte[] Encrypt(byte[] data, System.Security.Cryptography.RSAEncryptionPadding padding) { return default(byte[]); }
    public override System.Security.Cryptography.RSAParameters ExportParameters(bool includePrivateParameters) { return default(System.Security.Cryptography.RSAParameters); }
    protected override byte[] HashData(byte[] data, int offset, int count, System.Security.Cryptography.HashAlgorithmName hashAlgorithm) { return default(byte[]); }
    protected override byte[] HashData(System.IO.Stream data, System.Security.Cryptography.HashAlgorithmName hashAlgorithm) { return default(byte[]); }
    public override void ImportParameters(System.Security.Cryptography.RSAParameters parameters) { }
    public override byte[] SignHash(byte[] hash, System.Security.Cryptography.HashAlgorithmName hashAlgorithm, System.Security.Cryptography.RSASignaturePadding padding) { return default(byte[]); }
    public override bool VerifyHash(byte[] hash, byte[] signature, System.Security.Cryptography.HashAlgorithmName hashAlgorithm, System.Security.Cryptography.RSASignaturePadding padding) { return default(bool); }
  }

  public enum OidGroup {
    All = 0,
    Attribute = 5,
    EncryptionAlgorithm = 2,
    EnhancedKeyUsage = 7,
    ExtensionOrAttribute = 6,
    HashAlgorithm = 1,
    KeyDerivationFunction = 10,
    Policy = 8,
    PublicKeyAlgorithm = 3,
    SignatureAlgorithm = 4,
    Template = 9,
  }

  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct HashAlgorithmName : System.IEquatable<System.Security.Cryptography.HashAlgorithmName> {
    public HashAlgorithmName(string name) { throw new System.NotImplementedException(); }
    public static System.Security.Cryptography.HashAlgorithmName MD5 { get { return default(System.Security.Cryptography.HashAlgorithmName); } }
    public string Name { get { return default(string); } }
    public static System.Security.Cryptography.HashAlgorithmName SHA1 { get { return default(System.Security.Cryptography.HashAlgorithmName); } }
    public static System.Security.Cryptography.HashAlgorithmName SHA256 { get { return default(System.Security.Cryptography.HashAlgorithmName); } }
    public static System.Security.Cryptography.HashAlgorithmName SHA384 { get { return default(System.Security.Cryptography.HashAlgorithmName); } }
    public static System.Security.Cryptography.HashAlgorithmName SHA512 { get { return default(System.Security.Cryptography.HashAlgorithmName); } }
    public override bool Equals(object obj) { return default(bool); }
    public bool Equals(System.Security.Cryptography.HashAlgorithmName other) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.Security.Cryptography.HashAlgorithmName left, System.Security.Cryptography.HashAlgorithmName right) { return default(bool); }
    public static bool operator !=(System.Security.Cryptography.HashAlgorithmName left, System.Security.Cryptography.HashAlgorithmName right) { return default(bool); }
    public override string ToString() { return default(string); }
  }

} // end of System.Security.Cryptography
namespace System.Security.Cryptography.X509Certificates {
  public static partial class ECDsaCertificateExtensions {
    public static System.Security.Cryptography.ECDsa GetECDsaPrivateKey(this System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { return default(System.Security.Cryptography.ECDsa); }
    public static System.Security.Cryptography.ECDsa GetECDsaPublicKey(this System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { return default(System.Security.Cryptography.ECDsa); }
  }

  public static partial class RSACertificateExtensions {
    public static System.Security.Cryptography.RSA GetRSAPrivateKey(this System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { return default(System.Security.Cryptography.RSA); }
    public static System.Security.Cryptography.RSA GetRSAPublicKey(this System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { return default(System.Security.Cryptography.RSA); }
  }

} // end of System.Security.Cryptography.X509Certificates
namespace System.Security {
  public static partial class SecureStringMarshal {
    public static System.IntPtr SecureStringToCoTaskMemAnsi(System.Security.SecureString s) { return default(System.IntPtr); }
    public static System.IntPtr SecureStringToCoTaskMemUnicode(System.Security.SecureString s) { return default(System.IntPtr); }
    public static System.IntPtr SecureStringToGlobalAllocAnsi(System.Security.SecureString s) { return default(System.IntPtr); }
    public static System.IntPtr SecureStringToGlobalAllocUnicode(System.Security.SecureString s) { return default(System.IntPtr); }
  }

} // end of System.Security
namespace System.ServiceModel {
  [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
  public sealed partial class CallbackBehaviorAttribute : System.Attribute, System.ServiceModel.Description.IEndpointBehavior {
    public CallbackBehaviorAttribute() { }
    public bool AutomaticSessionShutdown { get { return default(bool); } set { } }
    public bool UseSynchronizationContext { get { return default(bool); } set { } }
    void System.ServiceModel.Description.IEndpointBehavior.AddBindingParameters(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Channels.BindingParameterCollection parameters) { }
    void System.ServiceModel.Description.IEndpointBehavior.ApplyClientBehavior(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Dispatcher.ClientRuntime clientRuntime) { }
    void System.ServiceModel.Description.IEndpointBehavior.ApplyDispatchBehavior(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Dispatcher.EndpointDispatcher endpointDispatcher) { }
    void System.ServiceModel.Description.IEndpointBehavior.Validate(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint) { }
  }

  public partial class DuplexChannelFactory<TChannel> : System.ServiceModel.ChannelFactory<TChannel> {
    public DuplexChannelFactory(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding) : base (default(System.ServiceModel.Channels.Binding), default(System.ServiceModel.EndpointAddress)) { }
    public DuplexChannelFactory(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : base (default(System.ServiceModel.Channels.Binding), default(System.ServiceModel.EndpointAddress)) { }
    public DuplexChannelFactory(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, string remoteAddress) : base (default(System.ServiceModel.Channels.Binding), default(System.ServiceModel.EndpointAddress)) { }
    public DuplexChannelFactory(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : base (default(System.ServiceModel.Channels.Binding), default(System.ServiceModel.EndpointAddress)) { }
    public DuplexChannelFactory(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : base (default(System.ServiceModel.Channels.Binding), default(System.ServiceModel.EndpointAddress)) { }
    public override TChannel CreateChannel(System.ServiceModel.EndpointAddress address, System.Uri via) { return default(TChannel); }
    public TChannel CreateChannel(System.ServiceModel.InstanceContext callbackInstance) { return default(TChannel); }
    public TChannel CreateChannel(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.EndpointAddress address) { return default(TChannel); }
    public virtual TChannel CreateChannel(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.EndpointAddress address, System.Uri via) { return default(TChannel); }
  }

  public abstract partial class DuplexClientBase<TChannel> : System.ServiceModel.ClientBase<TChannel> where TChannel : class {
    protected DuplexClientBase(System.ServiceModel.InstanceContext callbackInstance) { }
    protected DuplexClientBase(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) { }
    protected DuplexClientBase(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) { }
    protected DuplexClientBase(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) { }
    protected DuplexClientBase(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) { }
  }

  public sealed partial class InstanceContext : System.ServiceModel.Channels.CommunicationObject, System.ServiceModel.IExtensibleObject<System.ServiceModel.InstanceContext> {
    public InstanceContext(object implementation) { }
    protected override System.TimeSpan DefaultCloseTimeout { get { return default(System.TimeSpan); } }
    protected override System.TimeSpan DefaultOpenTimeout { get { return default(System.TimeSpan); } }
    public System.Threading.SynchronizationContext SynchronizationContext { get { return default(System.Threading.SynchronizationContext); } set { } }
    System.ServiceModel.IExtensionCollection<System.ServiceModel.InstanceContext> System.ServiceModel.IExtensibleObject<System.ServiceModel.InstanceContext>.Extensions { get { return default(System.ServiceModel.IExtensionCollection<System.ServiceModel.InstanceContext>); } }
    public object GetServiceInstance(System.ServiceModel.Channels.Message message) { return default(object); }
    protected override void OnAbort() { }
    protected override System.IAsyncResult OnBeginClose(System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    protected override System.IAsyncResult OnBeginOpen(System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    protected override void OnClose(System.TimeSpan timeout) { }
    protected override void OnClosed() { }
    protected override void OnEndClose(System.IAsyncResult result) { }
    protected override void OnEndOpen(System.IAsyncResult result) { }
    protected override void OnFaulted() { }
    protected override void OnOpen(System.TimeSpan timeout) { }
    protected override void OnOpened() { }
    protected override void OnOpening() { }
  }

  public partial class BasicHttpBinding : System.ServiceModel.HttpBindingBase {
    public BasicHttpBinding() { }
    public BasicHttpBinding(System.ServiceModel.BasicHttpSecurityMode securityMode) { }
    public System.ServiceModel.BasicHttpSecurity Security { get { return default(System.ServiceModel.BasicHttpSecurity); } set { } }
    public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingParameterCollection parameters) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    public override System.ServiceModel.Channels.BindingElementCollection CreateBindingElements() { return default(System.ServiceModel.Channels.BindingElementCollection); }
  }

  public enum BasicHttpMessageCredentialType {
    Certificate = 1,
    UserName = 0,
  }

  public partial class BasicHttpsBinding : System.ServiceModel.HttpBindingBase {
    public BasicHttpsBinding() { }
    public BasicHttpsBinding(System.ServiceModel.BasicHttpsSecurityMode securityMode) { }
    public System.ServiceModel.BasicHttpsSecurity Security { get { return default(System.ServiceModel.BasicHttpsSecurity); } set { } }
    public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingParameterCollection parameters) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    public override System.ServiceModel.Channels.BindingElementCollection CreateBindingElements() { return default(System.ServiceModel.Channels.BindingElementCollection); }
  }

  public sealed partial class BasicHttpSecurity {
    internal BasicHttpSecurity() { }
    public System.ServiceModel.BasicHttpSecurityMode Mode { get { return default(System.ServiceModel.BasicHttpSecurityMode); } set { } }
    public System.ServiceModel.HttpTransportSecurity Transport { get { return default(System.ServiceModel.HttpTransportSecurity); } set { } }
  }

  public enum BasicHttpSecurityMode {
    Message = 2,
    None = 0,
    Transport = 1,
    TransportCredentialOnly = 4,
    TransportWithMessageCredential = 3,
  }

  public sealed partial class BasicHttpsSecurity {
    internal BasicHttpsSecurity() { }
    public System.ServiceModel.BasicHttpsSecurityMode Mode { get { return default(System.ServiceModel.BasicHttpsSecurityMode); } set { } }
    public System.ServiceModel.HttpTransportSecurity Transport { get { return default(System.ServiceModel.HttpTransportSecurity); } set { } }
  }

  public enum BasicHttpsSecurityMode {
    Transport = 0,
    TransportWithMessageCredential = 1,
  }

  public abstract partial class HttpBindingBase : System.ServiceModel.Channels.Binding {
    internal HttpBindingBase() { }
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool AllowCookies { get { return default(bool); } set { } }
    public System.ServiceModel.EnvelopeVersion EnvelopeVersion { get { return default(System.ServiceModel.EnvelopeVersion); } }
    [System.ComponentModel.DefaultValueAttribute((long)524288)]
    public long MaxBufferPoolSize { get { return default(long); } set { } }
    [System.ComponentModel.DefaultValueAttribute(65536)]
    public int MaxBufferSize { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute((long)65536)]
    public long MaxReceivedMessageSize { get { return default(long); } set { } }
    public System.Xml.XmlDictionaryReaderQuotas ReaderQuotas { get { return default(System.Xml.XmlDictionaryReaderQuotas); } set { } }
    public override string Scheme { get { return default(string); } }
    public System.Text.Encoding TextEncoding { get { return default(System.Text.Encoding); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.ServiceModel.TransferMode)(0))]
    public System.ServiceModel.TransferMode TransferMode { get { return default(System.ServiceModel.TransferMode); } set { } }
  }

  public enum HttpClientCredentialType {
    Basic = 1,
    Certificate = 5,
    Digest = 2,
    InheritedFromHost = 6,
    None = 0,
    Ntlm = 3,
    Windows = 4,
  }

  public sealed partial class HttpTransportSecurity {
    public HttpTransportSecurity() { }
    public System.ServiceModel.HttpClientCredentialType ClientCredentialType { get { return default(System.ServiceModel.HttpClientCredentialType); } set { } }
  }

  public partial class NetHttpBinding : System.ServiceModel.HttpBindingBase {
    public NetHttpBinding() { }
    public NetHttpBinding(System.ServiceModel.BasicHttpSecurityMode securityMode) { }
    public NetHttpBinding(string configurationName) { }
    [System.ComponentModel.DefaultValueAttribute((System.ServiceModel.NetHttpMessageEncoding)(0))]
    public System.ServiceModel.NetHttpMessageEncoding MessageEncoding { get { return default(System.ServiceModel.NetHttpMessageEncoding); } set { } }
    public System.ServiceModel.BasicHttpSecurity Security { get { return default(System.ServiceModel.BasicHttpSecurity); } set { } }
    public System.ServiceModel.Channels.WebSocketTransportSettings WebSocketSettings { get { return default(System.ServiceModel.Channels.WebSocketTransportSettings); } }
    public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingParameterCollection parameters) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    public override System.ServiceModel.Channels.BindingElementCollection CreateBindingElements() { return default(System.ServiceModel.Channels.BindingElementCollection); }
  }

  public enum NetHttpMessageEncoding {
    Binary = 0,
    Mtom = 2,
    Text = 1,
  }

  public partial class NetHttpsBinding : System.ServiceModel.HttpBindingBase {
    public NetHttpsBinding() { }
    public NetHttpsBinding(System.ServiceModel.BasicHttpsSecurityMode securityMode) { }
    [System.ComponentModel.DefaultValueAttribute((System.ServiceModel.NetHttpMessageEncoding)(0))]
    public System.ServiceModel.NetHttpMessageEncoding MessageEncoding { get { return default(System.ServiceModel.NetHttpMessageEncoding); } set { } }
    public System.ServiceModel.BasicHttpsSecurity Security { get { return default(System.ServiceModel.BasicHttpsSecurity); } set { } }
    public System.ServiceModel.Channels.WebSocketTransportSettings WebSocketSettings { get { return default(System.ServiceModel.Channels.WebSocketTransportSettings); } }
    public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingParameterCollection parameters) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    public override System.ServiceModel.Channels.BindingElementCollection CreateBindingElements() { return default(System.ServiceModel.Channels.BindingElementCollection); }
  }

  public sealed partial class MessageSecurityOverTcp {
    public MessageSecurityOverTcp() { }
    [System.ComponentModel.DefaultValueAttribute((System.ServiceModel.MessageCredentialType)(1))]
    public System.ServiceModel.MessageCredentialType ClientCredentialType { get { return default(System.ServiceModel.MessageCredentialType); } set { } }
  }

  public partial class NetTcpBinding : System.ServiceModel.Channels.Binding {
    public NetTcpBinding() { }
    public NetTcpBinding(System.ServiceModel.SecurityMode securityMode) { }
    public NetTcpBinding(string configurationName) { }
    public System.ServiceModel.EnvelopeVersion EnvelopeVersion { get { return default(System.ServiceModel.EnvelopeVersion); } }
    [System.ComponentModel.DefaultValueAttribute((long)524288)]
    public long MaxBufferPoolSize { get { return default(long); } set { } }
    [System.ComponentModel.DefaultValueAttribute(65536)]
    public int MaxBufferSize { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute((long)65536)]
    public long MaxReceivedMessageSize { get { return default(long); } set { } }
    public System.Xml.XmlDictionaryReaderQuotas ReaderQuotas { get { return default(System.Xml.XmlDictionaryReaderQuotas); } set { } }
    public override string Scheme { get { return default(string); } }
    public System.ServiceModel.NetTcpSecurity Security { get { return default(System.ServiceModel.NetTcpSecurity); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.ServiceModel.TransferMode)(0))]
    public System.ServiceModel.TransferMode TransferMode { get { return default(System.ServiceModel.TransferMode); } set { } }
    public override System.ServiceModel.Channels.BindingElementCollection CreateBindingElements() { return default(System.ServiceModel.Channels.BindingElementCollection); }
  }

  public sealed partial class NetTcpSecurity {
    public NetTcpSecurity() { }
    public System.ServiceModel.MessageSecurityOverTcp Message { get { return default(System.ServiceModel.MessageSecurityOverTcp); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.ServiceModel.SecurityMode)(1))]
    public System.ServiceModel.SecurityMode Mode { get { return default(System.ServiceModel.SecurityMode); } set { } }
    public System.ServiceModel.TcpTransportSecurity Transport { get { return default(System.ServiceModel.TcpTransportSecurity); } set { } }
  }

  public enum TcpClientCredentialType {
    Certificate = 2,
    None = 0,
    Windows = 1,
  }

  public sealed partial class TcpTransportSecurity {
    public TcpTransportSecurity() { }
    [System.ComponentModel.DefaultValueAttribute((System.ServiceModel.TcpClientCredentialType)(1))]
    public System.ServiceModel.TcpClientCredentialType ClientCredentialType { get { return default(System.ServiceModel.TcpClientCredentialType); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.Security.Authentication.SslProtocols)(4080))]
    public System.Security.Authentication.SslProtocols SslProtocols { get { return default(System.Security.Authentication.SslProtocols); } set { } }
  }

  public partial class ActionNotSupportedException : System.ServiceModel.CommunicationException {
    public ActionNotSupportedException() { }
    public ActionNotSupportedException(string message) { }
    public ActionNotSupportedException(string message, System.Exception innerException) { }
  }

  public abstract partial class ChannelFactory : System.ServiceModel.Channels.CommunicationObject, System.IDisposable, System.ServiceModel.Channels.IChannelFactory, System.ServiceModel.ICommunicationObject {
    protected ChannelFactory() { }
    public System.ServiceModel.Description.ClientCredentials Credentials { get { return default(System.ServiceModel.Description.ClientCredentials); } }
    protected override System.TimeSpan DefaultCloseTimeout { get { return default(System.TimeSpan); } }
    protected override System.TimeSpan DefaultOpenTimeout { get { return default(System.TimeSpan); } }
    public System.ServiceModel.Description.ServiceEndpoint Endpoint { get { return default(System.ServiceModel.Description.ServiceEndpoint); } }
    protected virtual void ApplyConfiguration(string configurationName) { }
    protected abstract System.ServiceModel.Description.ServiceEndpoint CreateDescription();
    protected virtual System.ServiceModel.Channels.IChannelFactory CreateFactory() { return default(System.ServiceModel.Channels.IChannelFactory); }
    protected internal void EnsureOpened() { }
    public T GetProperty<T>() where T : class { return default(T); }
    protected void InitializeEndpoint(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress address) { }
    protected void InitializeEndpoint(System.ServiceModel.Description.ServiceEndpoint endpoint) { }
    protected void InitializeEndpoint(string configurationName, System.ServiceModel.EndpointAddress address) { }
    protected override void OnAbort() { }
    protected override System.IAsyncResult OnBeginClose(System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    protected override System.IAsyncResult OnBeginOpen(System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    protected override void OnClose(System.TimeSpan timeout) { }
    protected override void OnEndClose(System.IAsyncResult result) { }
    protected override void OnEndOpen(System.IAsyncResult result) { }
    protected override void OnOpen(System.TimeSpan timeout) { }
    protected override void OnOpened() { }
    protected override void OnOpening() { }
    void System.IDisposable.Dispose() { }
  }

  public partial class ChannelFactory<TChannel> : System.ServiceModel.ChannelFactory, System.ServiceModel.Channels.IChannelFactory, System.ServiceModel.Channels.IChannelFactory<TChannel>, System.ServiceModel.ICommunicationObject {
    public ChannelFactory(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) { }
    public ChannelFactory(string endpointConfigurationName) { }
    public ChannelFactory(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) { }
    protected ChannelFactory(System.Type channelType) { }
    public TChannel CreateChannel() { return default(TChannel); }
    public TChannel CreateChannel(System.ServiceModel.EndpointAddress address) { return default(TChannel); }
    public virtual TChannel CreateChannel(System.ServiceModel.EndpointAddress address, System.Uri via) { return default(TChannel); }
    protected override System.ServiceModel.Description.ServiceEndpoint CreateDescription() { return default(System.ServiceModel.Description.ServiceEndpoint); }
  }

  public abstract partial class ClientBase<TChannel> : System.ServiceModel.ICommunicationObject where TChannel : class {
    protected ClientBase() { }
    protected ClientBase(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) { }
    protected ClientBase(string endpointConfigurationName) { }
    protected ClientBase(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) { }
    protected ClientBase(string endpointConfigurationName, string remoteAddress) { }
    protected TChannel Channel { get { return default(TChannel); } }
    public System.ServiceModel.ChannelFactory<TChannel> ChannelFactory { get { return default(System.ServiceModel.ChannelFactory<TChannel>); } }
    public System.ServiceModel.Description.ClientCredentials ClientCredentials { get { return default(System.ServiceModel.Description.ClientCredentials); } }
    public System.ServiceModel.Description.ServiceEndpoint Endpoint { get { return default(System.ServiceModel.Description.ServiceEndpoint); } }
    public System.ServiceModel.IClientChannel InnerChannel { get { return default(System.ServiceModel.IClientChannel); } }
    public System.ServiceModel.CommunicationState State { get { return default(System.ServiceModel.CommunicationState); } }
    event System.EventHandler System.ServiceModel.ICommunicationObject.Closed { add { } remove { } }
    event System.EventHandler System.ServiceModel.ICommunicationObject.Closing { add { } remove { } }
    event System.EventHandler System.ServiceModel.ICommunicationObject.Faulted { add { } remove { } }
    event System.EventHandler System.ServiceModel.ICommunicationObject.Opened { add { } remove { } }
    event System.EventHandler System.ServiceModel.ICommunicationObject.Opening { add { } remove { } }
    public void Abort() { }
    protected virtual TChannel CreateChannel() { return default(TChannel); }
    protected T GetDefaultValueForInitialization<T>() { return default(T); }
    protected void InvokeAsync(System.ServiceModel.ClientBase<TChannel>.BeginOperationDelegate beginOperationDelegate, object[] inValues, System.ServiceModel.ClientBase<TChannel>.EndOperationDelegate endOperationDelegate, System.Threading.SendOrPostCallback operationCompletedCallback, object userState) { }
    System.IAsyncResult System.ServiceModel.ICommunicationObject.BeginClose(System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    System.IAsyncResult System.ServiceModel.ICommunicationObject.BeginClose(System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    System.IAsyncResult System.ServiceModel.ICommunicationObject.BeginOpen(System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    System.IAsyncResult System.ServiceModel.ICommunicationObject.BeginOpen(System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    void System.ServiceModel.ICommunicationObject.Close() { }
    void System.ServiceModel.ICommunicationObject.Close(System.TimeSpan timeout) { }
    void System.ServiceModel.ICommunicationObject.EndClose(System.IAsyncResult result) { }
    void System.ServiceModel.ICommunicationObject.EndOpen(System.IAsyncResult result) { }
    void System.ServiceModel.ICommunicationObject.Open() { }
    void System.ServiceModel.ICommunicationObject.Open(System.TimeSpan timeout) { }
    protected delegate System.IAsyncResult BeginOperationDelegate(object[] inValues, System.AsyncCallback asyncCallback, object state);
    protected partial class ChannelBase<T> : System.IDisposable, System.ServiceModel.Channels.IChannel, System.ServiceModel.Channels.IOutputChannel, System.ServiceModel.Channels.IRequestChannel, System.ServiceModel.IClientChannel, System.ServiceModel.ICommunicationObject, System.ServiceModel.IContextChannel, System.ServiceModel.IExtensibleObject<System.ServiceModel.IContextChannel> where T : class {
      protected ChannelBase(System.ServiceModel.ClientBase<T> client) { }
      System.ServiceModel.EndpointAddress System.ServiceModel.Channels.IOutputChannel.RemoteAddress { get { return default(System.ServiceModel.EndpointAddress); } }
      System.Uri System.ServiceModel.Channels.IOutputChannel.Via { get { return default(System.Uri); } }
      System.ServiceModel.EndpointAddress System.ServiceModel.Channels.IRequestChannel.RemoteAddress { get { return default(System.ServiceModel.EndpointAddress); } }
      System.Uri System.ServiceModel.Channels.IRequestChannel.Via { get { return default(System.Uri); } }
      bool System.ServiceModel.IClientChannel.AllowInitializationUI { get { return default(bool); } set { } }
      bool System.ServiceModel.IClientChannel.DidInteractiveInitialization { get { return default(bool); } }
      System.Uri System.ServiceModel.IClientChannel.Via { get { return default(System.Uri); } }
      System.ServiceModel.CommunicationState System.ServiceModel.ICommunicationObject.State { get { return default(System.ServiceModel.CommunicationState); } }
      bool System.ServiceModel.IContextChannel.AllowOutputBatching { get { return default(bool); } set { } }
      System.ServiceModel.Channels.IInputSession System.ServiceModel.IContextChannel.InputSession { get { return default(System.ServiceModel.Channels.IInputSession); } }
      System.ServiceModel.EndpointAddress System.ServiceModel.IContextChannel.LocalAddress { get { return default(System.ServiceModel.EndpointAddress); } }
      System.TimeSpan System.ServiceModel.IContextChannel.OperationTimeout { get { return default(System.TimeSpan); } set { } }
      System.ServiceModel.Channels.IOutputSession System.ServiceModel.IContextChannel.OutputSession { get { return default(System.ServiceModel.Channels.IOutputSession); } }
      System.ServiceModel.EndpointAddress System.ServiceModel.IContextChannel.RemoteAddress { get { return default(System.ServiceModel.EndpointAddress); } }
      string System.ServiceModel.IContextChannel.SessionId { get { return default(string); } }
      System.ServiceModel.IExtensionCollection<System.ServiceModel.IContextChannel> System.ServiceModel.IExtensibleObject<System.ServiceModel.IContextChannel>.Extensions { get { return default(System.ServiceModel.IExtensionCollection<System.ServiceModel.IContextChannel>); } }
      event System.EventHandler<System.ServiceModel.UnknownMessageReceivedEventArgs> System.ServiceModel.IClientChannel.UnknownMessageReceived { add { } remove { } }
      event System.EventHandler System.ServiceModel.ICommunicationObject.Closed { add { } remove { } }
      event System.EventHandler System.ServiceModel.ICommunicationObject.Closing { add { } remove { } }
      event System.EventHandler System.ServiceModel.ICommunicationObject.Faulted { add { } remove { } }
      event System.EventHandler System.ServiceModel.ICommunicationObject.Opened { add { } remove { } }
      event System.EventHandler System.ServiceModel.ICommunicationObject.Opening { add { } remove { } }
      [System.Security.SecuritySafeCriticalAttribute]
      protected System.IAsyncResult BeginInvoke(string methodName, object[] args, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
      [System.Security.SecuritySafeCriticalAttribute]
      protected object EndInvoke(string methodName, object[] args, System.IAsyncResult result) { return default(object); }
      void System.IDisposable.Dispose() { }
      TProperty System.ServiceModel.Channels.IChannel.GetProperty<TProperty>() { return default(TProperty); }
      System.IAsyncResult System.ServiceModel.Channels.IOutputChannel.BeginSend(System.ServiceModel.Channels.Message message, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
      System.IAsyncResult System.ServiceModel.Channels.IOutputChannel.BeginSend(System.ServiceModel.Channels.Message message, System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
      void System.ServiceModel.Channels.IOutputChannel.EndSend(System.IAsyncResult result) { }
      void System.ServiceModel.Channels.IOutputChannel.Send(System.ServiceModel.Channels.Message message) { }
      void System.ServiceModel.Channels.IOutputChannel.Send(System.ServiceModel.Channels.Message message, System.TimeSpan timeout) { }
      System.IAsyncResult System.ServiceModel.Channels.IRequestChannel.BeginRequest(System.ServiceModel.Channels.Message message, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
      System.IAsyncResult System.ServiceModel.Channels.IRequestChannel.BeginRequest(System.ServiceModel.Channels.Message message, System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
      System.ServiceModel.Channels.Message System.ServiceModel.Channels.IRequestChannel.EndRequest(System.IAsyncResult result) { return default(System.ServiceModel.Channels.Message); }
      System.ServiceModel.Channels.Message System.ServiceModel.Channels.IRequestChannel.Request(System.ServiceModel.Channels.Message message) { return default(System.ServiceModel.Channels.Message); }
      System.ServiceModel.Channels.Message System.ServiceModel.Channels.IRequestChannel.Request(System.ServiceModel.Channels.Message message, System.TimeSpan timeout) { return default(System.ServiceModel.Channels.Message); }
      System.IAsyncResult System.ServiceModel.IClientChannel.BeginDisplayInitializationUI(System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
      void System.ServiceModel.IClientChannel.DisplayInitializationUI() { }
      void System.ServiceModel.IClientChannel.EndDisplayInitializationUI(System.IAsyncResult result) { }
      void System.ServiceModel.ICommunicationObject.Abort() { }
      System.IAsyncResult System.ServiceModel.ICommunicationObject.BeginClose(System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
      System.IAsyncResult System.ServiceModel.ICommunicationObject.BeginClose(System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
      System.IAsyncResult System.ServiceModel.ICommunicationObject.BeginOpen(System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
      System.IAsyncResult System.ServiceModel.ICommunicationObject.BeginOpen(System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
      void System.ServiceModel.ICommunicationObject.Close() { }
      void System.ServiceModel.ICommunicationObject.Close(System.TimeSpan timeout) { }
      void System.ServiceModel.ICommunicationObject.EndClose(System.IAsyncResult result) { }
      void System.ServiceModel.ICommunicationObject.EndOpen(System.IAsyncResult result) { }
      void System.ServiceModel.ICommunicationObject.Open() { }
      void System.ServiceModel.ICommunicationObject.Open(System.TimeSpan timeout) { }
    }
    protected delegate object[] EndOperationDelegate(System.IAsyncResult result);
    protected partial class InvokeAsyncCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
      internal InvokeAsyncCompletedEventArgs() : base (default(System.Exception), default(bool), default(object)) { }
      public object[] Results { get { return default(object[]); } }
    }
  }

  public partial class CommunicationException : System.Exception {
    public CommunicationException() { }
    public CommunicationException(string message) { }
    public CommunicationException(string message, System.Exception innerException) { }
  }

  public partial class CommunicationObjectAbortedException : System.ServiceModel.CommunicationException {
    public CommunicationObjectAbortedException() { }
    public CommunicationObjectAbortedException(string message) { }
    public CommunicationObjectAbortedException(string message, System.Exception innerException) { }
  }

  public partial class CommunicationObjectFaultedException : System.ServiceModel.CommunicationException {
    public CommunicationObjectFaultedException() { }
    public CommunicationObjectFaultedException(string message) { }
    public CommunicationObjectFaultedException(string message, System.Exception innerException) { }
  }

  public enum CommunicationState {
    Closed = 4,
    Closing = 3,
    Created = 0,
    Faulted = 5,
    Opened = 2,
    Opening = 1,
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(1092), Inherited=false, AllowMultiple=false)]
  public sealed partial class DataContractFormatAttribute : System.Attribute {
    public DataContractFormatAttribute() { }
    public System.ServiceModel.OperationFormatStyle Style { get { return default(System.ServiceModel.OperationFormatStyle); } set { } }
  }

  public partial class EndpointAddress {
    public EndpointAddress(string uri) { }
    public EndpointAddress(System.Uri uri, params System.ServiceModel.Channels.AddressHeader[] addressHeaders) { }
    public EndpointAddress(System.Uri uri, System.ServiceModel.EndpointIdentity identity, params System.ServiceModel.Channels.AddressHeader[] addressHeaders) { }
    public static System.Uri AnonymousUri { get { return default(System.Uri); } }
    public System.ServiceModel.Channels.AddressHeaderCollection Headers { get { return default(System.ServiceModel.Channels.AddressHeaderCollection); } }
    public System.ServiceModel.EndpointIdentity Identity { get { return default(System.ServiceModel.EndpointIdentity); } }
    public bool IsAnonymous { get { return default(bool); } }
    public bool IsNone { get { return default(bool); } }
    public static System.Uri NoneUri { get { return default(System.Uri); } }
    public System.Uri Uri { get { return default(System.Uri); } }
    public void ApplyTo(System.ServiceModel.Channels.Message message) { }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.ServiceModel.EndpointAddress address1, System.ServiceModel.EndpointAddress address2) { return default(bool); }
    public static bool operator !=(System.ServiceModel.EndpointAddress address1, System.ServiceModel.EndpointAddress address2) { return default(bool); }
    public static System.ServiceModel.EndpointAddress ReadFrom(System.ServiceModel.Channels.AddressingVersion addressingVersion, System.Xml.XmlDictionaryReader reader) { return default(System.ServiceModel.EndpointAddress); }
    public override string ToString() { return default(string); }
    public void WriteContentsTo(System.ServiceModel.Channels.AddressingVersion addressingVersion, System.Xml.XmlDictionaryWriter writer) { }
  }

  public partial class EndpointAddressBuilder {
    public EndpointAddressBuilder() { }
    public EndpointAddressBuilder(System.ServiceModel.EndpointAddress address) { }
    public System.Collections.ObjectModel.Collection<System.ServiceModel.Channels.AddressHeader> Headers { get { return default(System.Collections.ObjectModel.Collection<System.ServiceModel.Channels.AddressHeader>); } }
    public System.ServiceModel.EndpointIdentity Identity { get { return default(System.ServiceModel.EndpointIdentity); } set { } }
    public System.Uri Uri { get { return default(System.Uri); } set { } }
    public System.ServiceModel.EndpointAddress ToEndpointAddress() { return default(System.ServiceModel.EndpointAddress); }
  }

  public abstract partial class EndpointIdentity {
    protected EndpointIdentity() { }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override string ToString() { return default(string); }
  }

  public partial class EndpointNotFoundException : System.ServiceModel.CommunicationException {
    public EndpointNotFoundException(string message) { }
    public EndpointNotFoundException(string message, System.Exception innerException) { }
  }

  public sealed partial class EnvelopeVersion {
    internal EnvelopeVersion() { }
    public string NextDestinationActorValue { get { return default(string); } }
    public static System.ServiceModel.EnvelopeVersion None { get { return default(System.ServiceModel.EnvelopeVersion); } }
    public static System.ServiceModel.EnvelopeVersion Soap11 { get { return default(System.ServiceModel.EnvelopeVersion); } }
    public static System.ServiceModel.EnvelopeVersion Soap12 { get { return default(System.ServiceModel.EnvelopeVersion); } }
    public string[] GetUltimateDestinationActorValues() { return default(string[]); }
    public override string ToString() { return default(string); }
  }

  [System.Runtime.Serialization.DataContractAttribute]
  public partial class ExceptionDetail {
    public ExceptionDetail(System.Exception exception) { }
    [System.Runtime.Serialization.DataMemberAttribute]
    public string HelpLink { get { return default(string); } set { } }
    [System.Runtime.Serialization.DataMemberAttribute]
    public System.ServiceModel.ExceptionDetail InnerException { get { return default(System.ServiceModel.ExceptionDetail); } set { } }
    [System.Runtime.Serialization.DataMemberAttribute]
    public string Message { get { return default(string); } set { } }
    [System.Runtime.Serialization.DataMemberAttribute]
    public string StackTrace { get { return default(string); } set { } }
    [System.Runtime.Serialization.DataMemberAttribute]
    public string Type { get { return default(string); } set { } }
    public override string ToString() { return default(string); }
  }

  public partial class FaultCode {
    public FaultCode(string name) { }
    public FaultCode(string name, System.ServiceModel.FaultCode subCode) { }
    public FaultCode(string name, string ns) { }
    public FaultCode(string name, string ns, System.ServiceModel.FaultCode subCode) { }
    public bool IsPredefinedFault { get { return default(bool); } }
    public bool IsReceiverFault { get { return default(bool); } }
    public bool IsSenderFault { get { return default(bool); } }
    public string Name { get { return default(string); } }
    public string Namespace { get { return default(string); } }
    public System.ServiceModel.FaultCode SubCode { get { return default(System.ServiceModel.FaultCode); } }
    public static System.ServiceModel.FaultCode CreateSenderFaultCode(System.ServiceModel.FaultCode subCode) { return default(System.ServiceModel.FaultCode); }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(64), AllowMultiple=true, Inherited=false)]
  public sealed partial class FaultContractAttribute : System.Attribute {
    public FaultContractAttribute(System.Type detailType) { }
    public string Action { get { return default(string); } set { } }
    public System.Type DetailType { get { return default(System.Type); } }
    public string Name { get { return default(string); } set { } }
    public string Namespace { get { return default(string); } set { } }
  }

  public partial class FaultException : System.ServiceModel.CommunicationException {
    public FaultException() { }
    public FaultException(System.ServiceModel.Channels.MessageFault fault, string action) { }
    public FaultException(System.ServiceModel.FaultReason reason, System.ServiceModel.FaultCode code, string action) { }
    public string Action { get { return default(string); } }
    public System.ServiceModel.FaultCode Code { get { return default(System.ServiceModel.FaultCode); } }
    public override string Message { get { return default(string); } }
    public System.ServiceModel.FaultReason Reason { get { return default(System.ServiceModel.FaultReason); } }
    public static System.ServiceModel.FaultException CreateFault(System.ServiceModel.Channels.MessageFault messageFault, string action, params System.Type[] faultDetailTypes) { return default(System.ServiceModel.FaultException); }
    public static System.ServiceModel.FaultException CreateFault(System.ServiceModel.Channels.MessageFault messageFault, params System.Type[] faultDetailTypes) { return default(System.ServiceModel.FaultException); }
    public virtual System.ServiceModel.Channels.MessageFault CreateMessageFault() { return default(System.ServiceModel.Channels.MessageFault); }
  }

  public partial class FaultException<TDetail> : System.ServiceModel.FaultException {
    public FaultException(TDetail detail, System.ServiceModel.FaultReason reason, System.ServiceModel.FaultCode code, string action) { }
    public TDetail Detail { get { return default(TDetail); } }
    public override System.ServiceModel.Channels.MessageFault CreateMessageFault() { return default(System.ServiceModel.Channels.MessageFault); }
    public override string ToString() { return default(string); }
  }

  public partial class FaultReason {
    public FaultReason(System.Collections.Generic.IEnumerable<System.ServiceModel.FaultReasonText> translations) { }
    public FaultReason(System.ServiceModel.FaultReasonText translation) { }
    public FaultReason(string text) { }
    public System.ServiceModel.FaultReasonText GetMatchingTranslation() { return default(System.ServiceModel.FaultReasonText); }
    public System.ServiceModel.FaultReasonText GetMatchingTranslation(System.Globalization.CultureInfo cultureInfo) { return default(System.ServiceModel.FaultReasonText); }
    public override string ToString() { return default(string); }
  }

  public partial class FaultReasonText {
    public FaultReasonText(string text) { }
    public FaultReasonText(string text, string xmlLang) { }
    public string Text { get { return default(string); } }
    public string XmlLang { get { return default(string); } }
    public bool Matches(System.Globalization.CultureInfo cultureInfo) { return default(bool); }
  }

  public partial interface IClientChannel : System.IDisposable, System.ServiceModel.Channels.IChannel, System.ServiceModel.ICommunicationObject, System.ServiceModel.IContextChannel, System.ServiceModel.IExtensibleObject<System.ServiceModel.IContextChannel> {
    bool AllowInitializationUI { get; set; }
    bool DidInteractiveInitialization { get; }
    System.Uri Via { get; }
    event System.EventHandler<System.ServiceModel.UnknownMessageReceivedEventArgs> UnknownMessageReceived;
    System.IAsyncResult BeginDisplayInitializationUI(System.AsyncCallback callback, object state);
    void DisplayInitializationUI();
    void EndDisplayInitializationUI(System.IAsyncResult result);
  }

  public partial interface ICommunicationObject {
    System.ServiceModel.CommunicationState State { get; }
    event System.EventHandler Closed;
    event System.EventHandler Closing;
    event System.EventHandler Faulted;
    event System.EventHandler Opened;
    event System.EventHandler Opening;
    void Abort();
    System.IAsyncResult BeginClose(System.AsyncCallback callback, object state);
    System.IAsyncResult BeginClose(System.TimeSpan timeout, System.AsyncCallback callback, object state);
    System.IAsyncResult BeginOpen(System.AsyncCallback callback, object state);
    System.IAsyncResult BeginOpen(System.TimeSpan timeout, System.AsyncCallback callback, object state);
    void Close();
    void Close(System.TimeSpan timeout);
    void EndClose(System.IAsyncResult result);
    void EndOpen(System.IAsyncResult result);
    void Open();
    void Open(System.TimeSpan timeout);
  }

  public partial interface IContextChannel : System.ServiceModel.Channels.IChannel, System.ServiceModel.ICommunicationObject, System.ServiceModel.IExtensibleObject<System.ServiceModel.IContextChannel> {
    bool AllowOutputBatching { get; set; }
    System.ServiceModel.Channels.IInputSession InputSession { get; }
    System.ServiceModel.EndpointAddress LocalAddress { get; }
    System.TimeSpan OperationTimeout { get; set; }
    System.ServiceModel.Channels.IOutputSession OutputSession { get; }
    System.ServiceModel.EndpointAddress RemoteAddress { get; }
    string SessionId { get; }
  }

  public partial interface IDefaultCommunicationTimeouts {
    System.TimeSpan CloseTimeout { get; }
    System.TimeSpan OpenTimeout { get; }
    System.TimeSpan ReceiveTimeout { get; }
    System.TimeSpan SendTimeout { get; }
  }

  public partial interface IExtensibleObject<T> where T : System.ServiceModel.IExtensibleObject<T> {
    System.ServiceModel.IExtensionCollection<T> Extensions { get; }
  }

  public partial interface IExtension<T> where T : System.ServiceModel.IExtensibleObject<T> {
    void Attach(T owner);
    void Detach(T owner);
  }

  public partial interface IExtensionCollection<T> : System.Collections.Generic.ICollection<System.ServiceModel.IExtension<T>>, System.Collections.Generic.IEnumerable<System.ServiceModel.IExtension<T>>, System.Collections.IEnumerable where T : System.ServiceModel.IExtensibleObject<T> {
    E Find<E>();
    System.Collections.ObjectModel.Collection<E> FindAll<E>();
  }

  public partial class InvalidMessageContractException : System.Exception {
    public InvalidMessageContractException() { }
    public InvalidMessageContractException(string message) { }
    public InvalidMessageContractException(string message, System.Exception innerException) { }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(384), Inherited=false)]
  public partial class MessageBodyMemberAttribute : System.ServiceModel.MessageContractMemberAttribute {
    public MessageBodyMemberAttribute() { }
    public int Order { get { return default(int); } set { } }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(12), AllowMultiple=false)]
  public sealed partial class MessageContractAttribute : System.Attribute {
    public MessageContractAttribute() { }
    public bool IsWrapped { get { return default(bool); } set { } }
    public string WrapperName { get { return default(string); } set { } }
    public string WrapperNamespace { get { return default(string); } set { } }
  }

  public abstract partial class MessageContractMemberAttribute : System.Attribute {
    protected MessageContractMemberAttribute() { }
    public string Name { get { return default(string); } set { } }
    public string Namespace { get { return default(string); } set { } }
  }

  public enum MessageCredentialType {
    Certificate = 3,
    IssuedToken = 4,
    None = 0,
    UserName = 2,
    Windows = 1,
  }

  public partial class MessageHeader<T> {
    public MessageHeader() { }
    public MessageHeader(T content) { }
    public MessageHeader(T content, bool mustUnderstand, string actor, bool relay) { }
    public string Actor { get { return default(string); } set { } }
    public T Content { get { return default(T); } set { } }
    public bool MustUnderstand { get { return default(bool); } set { } }
    public bool Relay { get { return default(bool); } set { } }
    public System.ServiceModel.Channels.MessageHeader GetUntypedHeader(string name, string ns) { return default(System.ServiceModel.Channels.MessageHeader); }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(384), AllowMultiple=false, Inherited=false)]
  public partial class MessageHeaderAttribute : System.ServiceModel.MessageContractMemberAttribute {
    public MessageHeaderAttribute() { }
    public bool MustUnderstand { get { return default(bool); } set { } }
  }

  public partial class MessageHeaderException : System.ServiceModel.ProtocolException {
    public MessageHeaderException(string message) : base (default(string)) { }
    public MessageHeaderException(string message, bool isDuplicate) : base (default(string)) { }
    public MessageHeaderException(string message, System.Exception innerException) : base (default(string)) { }
    public MessageHeaderException(string message, string headerName, string ns) : base (default(string)) { }
    public MessageHeaderException(string message, string headerName, string ns, bool isDuplicate) : base (default(string)) { }
    public MessageHeaderException(string message, string headerName, string ns, bool isDuplicate, System.Exception innerException) : base (default(string)) { }
    public MessageHeaderException(string message, string headerName, string ns, System.Exception innerException) : base (default(string)) { }
    public string HeaderName { get { return default(string); } }
    public string HeaderNamespace { get { return default(string); } }
    public bool IsDuplicate { get { return default(bool); } }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(10240), Inherited=false)]
  public sealed partial class MessageParameterAttribute : System.Attribute {
    public MessageParameterAttribute() { }
    public string Name { get { return default(string); } set { } }
  }

  public sealed partial class OperationContext : System.ServiceModel.IExtensibleObject<System.ServiceModel.OperationContext> {
    public OperationContext(System.ServiceModel.IContextChannel channel) { }
    public static System.ServiceModel.OperationContext Current { get { return default(System.ServiceModel.OperationContext); } set { } }
    public System.ServiceModel.IExtensionCollection<System.ServiceModel.OperationContext> Extensions { get { return default(System.ServiceModel.IExtensionCollection<System.ServiceModel.OperationContext>); } }
    public System.ServiceModel.Channels.MessageHeaders IncomingMessageHeaders { get { return default(System.ServiceModel.Channels.MessageHeaders); } }
    public System.ServiceModel.Channels.MessageProperties IncomingMessageProperties { get { return default(System.ServiceModel.Channels.MessageProperties); } }
    public System.ServiceModel.Channels.MessageVersion IncomingMessageVersion { get { return default(System.ServiceModel.Channels.MessageVersion); } }
    public bool IsUserContext { get { return default(bool); } }
    public System.ServiceModel.Channels.MessageHeaders OutgoingMessageHeaders { get { return default(System.ServiceModel.Channels.MessageHeaders); } }
    public System.ServiceModel.Channels.MessageProperties OutgoingMessageProperties { get { return default(System.ServiceModel.Channels.MessageProperties); } }
    public System.ServiceModel.Channels.RequestContext RequestContext { get { return default(System.ServiceModel.Channels.RequestContext); } set { } }
    public event System.EventHandler OperationCompleted { add { } remove { } }
  }

  public sealed partial class OperationContextScope : System.IDisposable {
    public OperationContextScope(System.ServiceModel.IContextChannel channel) { }
    public OperationContextScope(System.ServiceModel.OperationContext context) { }
    public void Dispose() { }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(64))]
  public sealed partial class OperationContractAttribute : System.Attribute {
    public OperationContractAttribute() { }
    public string Action { get { return default(string); } set { } }
    public bool AsyncPattern { get { return default(bool); } set { } }
    public bool IsOneWay { get { return default(bool); } set { } }
    public string Name { get { return default(string); } set { } }
    public string ReplyAction { get { return default(string); } set { } }
  }

  public enum OperationFormatStyle {
    Document = 0,
    Rpc = 1,
  }

  public partial class ProtocolException : System.ServiceModel.CommunicationException {
    public ProtocolException(string message) { }
    public ProtocolException(string message, System.Exception innerException) { }
  }

  public partial class QuotaExceededException : System.Exception {
    public QuotaExceededException(string message) { }
    public QuotaExceededException(string message, System.Exception innerException) { }
  }

  public enum SecurityMode {
    Message = 2,
    None = 0,
    Transport = 1,
    TransportWithMessageCredential = 3,
  }

  public partial class ServerTooBusyException : System.ServiceModel.CommunicationException {
    public ServerTooBusyException(string message) { }
    public ServerTooBusyException(string message, System.Exception innerException) { }
  }

  public partial class ServiceActivationException : System.ServiceModel.CommunicationException {
    public ServiceActivationException(string message) { }
    public ServiceActivationException(string message, System.Exception innerException) { }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(1028), Inherited=false, AllowMultiple=false)]
  public sealed partial class ServiceContractAttribute : System.Attribute {
    public ServiceContractAttribute() { }
    public System.Type CallbackContract { get { return default(System.Type); } set { } }
    public string ConfigurationName { get { return default(string); } set { } }
    public string Name { get { return default(string); } set { } }
    public string Namespace { get { return default(string); } set { } }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(1092), Inherited=true, AllowMultiple=true)]
  public sealed partial class ServiceKnownTypeAttribute : System.Attribute {
    public ServiceKnownTypeAttribute(string methodName) { }
    public ServiceKnownTypeAttribute(string methodName, System.Type declaringType) { }
    public ServiceKnownTypeAttribute(System.Type type) { }
    public System.Type DeclaringType { get { return default(System.Type); } }
    public string MethodName { get { return default(string); } }
    public System.Type Type { get { return default(System.Type); } }
  }

  public enum TransferMode {
    Buffered = 0,
    Streamed = 1,
    StreamedRequest = 2,
    StreamedResponse = 3,
  }

  public sealed partial class UnknownMessageReceivedEventArgs : System.EventArgs {
    internal UnknownMessageReceivedEventArgs() { }
    public System.ServiceModel.Channels.Message Message { get { return default(System.ServiceModel.Channels.Message); } }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(1092), Inherited=false, AllowMultiple=false)]
  public sealed partial class XmlSerializerFormatAttribute : System.Attribute {
    public XmlSerializerFormatAttribute() { }
    public System.ServiceModel.OperationFormatStyle Style { get { return default(System.ServiceModel.OperationFormatStyle); } set { } }
    public bool SupportFaults { get { return default(bool); } set { } }
  }

  public partial class DnsEndpointIdentity : System.ServiceModel.EndpointIdentity {
    public DnsEndpointIdentity(string dnsName) { }
  }

  public abstract partial class MessageSecurityVersion {
    internal MessageSecurityVersion() { }
    public abstract System.ServiceModel.Security.BasicSecurityProfileVersion BasicSecurityProfileVersion { get; }
    public System.ServiceModel.Security.SecureConversationVersion SecureConversationVersion { get { return default(System.ServiceModel.Security.SecureConversationVersion); } }
    public abstract System.ServiceModel.Security.SecurityPolicyVersion SecurityPolicyVersion { get; }
    public System.ServiceModel.Security.SecurityVersion SecurityVersion { get { return default(System.ServiceModel.Security.SecurityVersion); } }
    public System.ServiceModel.Security.TrustVersion TrustVersion { get { return default(System.ServiceModel.Security.TrustVersion); } }
    public static System.ServiceModel.MessageSecurityVersion WSSecurity10WSTrustFebruary2005WSSecureConversationFebruary2005WSSecurityPolicy11BasicSecurityProfile10 { get { return default(System.ServiceModel.MessageSecurityVersion); } }
    public static System.ServiceModel.MessageSecurityVersion WSSecurity11WSTrustFebruary2005WSSecureConversationFebruary2005WSSecurityPolicy11 { get { return default(System.ServiceModel.MessageSecurityVersion); } }
    public static System.ServiceModel.MessageSecurityVersion WSSecurity11WSTrustFebruary2005WSSecureConversationFebruary2005WSSecurityPolicy11BasicSecurityProfile10 { get { return default(System.ServiceModel.MessageSecurityVersion); } }
  }

  public partial class SpnEndpointIdentity : System.ServiceModel.EndpointIdentity {
    public SpnEndpointIdentity(string spnName) { }
    public static System.TimeSpan SpnLookupTime { get { return default(System.TimeSpan); } set { } }
  }

  public partial class UpnEndpointIdentity : System.ServiceModel.EndpointIdentity {
    public UpnEndpointIdentity(string upnName) { }
  }

} // end of System.ServiceModel
namespace System.ServiceModel.Channels {
  public sealed partial class HttpRequestMessageProperty : System.ServiceModel.Channels.IMessageProperty {
    public HttpRequestMessageProperty() { }
    public System.Net.WebHeaderCollection Headers { get { return default(System.Net.WebHeaderCollection); } }
    public string Method { get { return default(string); } set { } }
    public static string Name { get { return default(string); } }
    public string QueryString { get { return default(string); } set { } }
    public bool SuppressEntityBody { get { return default(bool); } set { } }
    System.ServiceModel.Channels.IMessageProperty System.ServiceModel.Channels.IMessageProperty.CreateCopy() { return default(System.ServiceModel.Channels.IMessageProperty); }
  }

  public sealed partial class HttpResponseMessageProperty : System.ServiceModel.Channels.IMessageProperty {
    public HttpResponseMessageProperty() { }
    public System.Net.WebHeaderCollection Headers { get { return default(System.Net.WebHeaderCollection); } }
    public static string Name { get { return default(string); } }
    public System.Net.HttpStatusCode StatusCode { get { return default(System.Net.HttpStatusCode); } set { } }
    public string StatusDescription { get { return default(string); } set { } }
    System.ServiceModel.Channels.IMessageProperty System.ServiceModel.Channels.IMessageProperty.CreateCopy() { return default(System.ServiceModel.Channels.IMessageProperty); }
  }

  public partial class HttpsTransportBindingElement : System.ServiceModel.Channels.HttpTransportBindingElement {
    public HttpsTransportBindingElement() { }
    protected HttpsTransportBindingElement(System.ServiceModel.Channels.HttpsTransportBindingElement elementToBeCloned) { }
    public bool RequireClientCertificate { get { return default(bool); } set { } }
    public override string Scheme { get { return default(string); } }
    public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    public override System.ServiceModel.Channels.BindingElement Clone() { return default(System.ServiceModel.Channels.BindingElement); }
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
  }

  public partial class HttpTransportBindingElement : System.ServiceModel.Channels.TransportBindingElement {
    public HttpTransportBindingElement() { }
    protected HttpTransportBindingElement(System.ServiceModel.Channels.HttpTransportBindingElement elementToBeCloned) { }
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool AllowCookies { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.Net.AuthenticationSchemes)(32768))]
    public System.Net.AuthenticationSchemes AuthenticationScheme { get { return default(System.Net.AuthenticationSchemes); } set { } }
    [System.ComponentModel.DefaultValueAttribute(65536)]
    public int MaxBufferSize { get { return default(int); } set { } }
    public override string Scheme { get { return default(string); } }
    [System.ComponentModel.DefaultValueAttribute((System.ServiceModel.TransferMode)(0))]
    public System.ServiceModel.TransferMode TransferMode { get { return default(System.ServiceModel.TransferMode); } set { } }
    public System.ServiceModel.Channels.WebSocketTransportSettings WebSocketSettings { get { return default(System.ServiceModel.Channels.WebSocketTransportSettings); } set { } }
    public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    public override bool CanBuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public override System.ServiceModel.Channels.BindingElement Clone() { return default(System.ServiceModel.Channels.BindingElement); }
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
  }

  public partial interface IHttpCookieContainerManager {
    System.Net.CookieContainer CookieContainer { get; set; }
  }

  public sealed partial class WebSocketTransportSettings : System.IEquatable<System.ServiceModel.Channels.WebSocketTransportSettings> {
    public const string BinaryMessageReceivedAction = "http://schemas.microsoft.com/2011/02/websockets/onbinarymessage";
    public const string TextMessageReceivedAction = "http://schemas.microsoft.com/2011/02/websockets/ontextmessage";
    public WebSocketTransportSettings() { }
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool DisablePayloadMasking { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.TimeSpan), "00:00:00")]
    public System.TimeSpan KeepAliveInterval { get { return default(System.TimeSpan); } set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public string SubProtocol { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.ServiceModel.Channels.WebSocketTransportUsage)(2))]
    public System.ServiceModel.Channels.WebSocketTransportUsage TransportUsage { get { return default(System.ServiceModel.Channels.WebSocketTransportUsage); } set { } }
    public override bool Equals(object obj) { return default(bool); }
    public bool Equals(System.ServiceModel.Channels.WebSocketTransportSettings other) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }

  public enum WebSocketTransportUsage {
    Always = 1,
    Never = 2,
    WhenDuplex = 0,
  }

  public abstract partial class ConnectionOrientedTransportBindingElement : System.ServiceModel.Channels.TransportBindingElement {
    internal ConnectionOrientedTransportBindingElement() { }
    [System.ComponentModel.DefaultValueAttribute(8192)]
    public int ConnectionBufferSize { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute(65536)]
    public int MaxBufferSize { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute((System.ServiceModel.TransferMode)(0))]
    public System.ServiceModel.TransferMode TransferMode { get { return default(System.ServiceModel.TransferMode); } set { } }
    public override bool CanBuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
  }

  public partial class SslStreamSecurityBindingElement : System.ServiceModel.Channels.BindingElement {
    public SslStreamSecurityBindingElement() { }
    [System.ComponentModel.DefaultValueAttribute((System.Security.Authentication.SslProtocols)(4080))]
    public System.Security.Authentication.SslProtocols SslProtocols { get { return default(System.Security.Authentication.SslProtocols); } set { } }
    public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    public override bool CanBuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public override System.ServiceModel.Channels.BindingElement Clone() { return default(System.ServiceModel.Channels.BindingElement); }
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
  }

  public sealed partial class TcpConnectionPoolSettings {
    internal TcpConnectionPoolSettings() { }
    public string GroupName { get { return default(string); } set { } }
    public System.TimeSpan IdleTimeout { get { return default(System.TimeSpan); } set { } }
    public System.TimeSpan LeaseTimeout { get { return default(System.TimeSpan); } set { } }
    public int MaxOutboundConnectionsPerEndpoint { get { return default(int); } set { } }
  }

  public partial class TcpTransportBindingElement : System.ServiceModel.Channels.ConnectionOrientedTransportBindingElement {
    public TcpTransportBindingElement() { }
    protected TcpTransportBindingElement(System.ServiceModel.Channels.TcpTransportBindingElement elementToBeCloned) { }
    public System.ServiceModel.Channels.TcpConnectionPoolSettings ConnectionPoolSettings { get { return default(System.ServiceModel.Channels.TcpConnectionPoolSettings); } }
    public override string Scheme { get { return default(string); } }
    public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    public override System.ServiceModel.Channels.BindingElement Clone() { return default(System.ServiceModel.Channels.BindingElement); }
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
  }

  public partial class WindowsStreamSecurityBindingElement : System.ServiceModel.Channels.BindingElement {
    public WindowsStreamSecurityBindingElement() { }
    public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    public override bool CanBuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public override System.ServiceModel.Channels.BindingElement Clone() { return default(System.ServiceModel.Channels.BindingElement); }
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
  }

  public abstract partial class AddressHeader {
    protected AddressHeader() { }
    public abstract string Name { get; }
    public abstract string Namespace { get; }
    public static System.ServiceModel.Channels.AddressHeader CreateAddressHeader(string name, string ns, object value) { return default(System.ServiceModel.Channels.AddressHeader); }
    public static System.ServiceModel.Channels.AddressHeader CreateAddressHeader(string name, string ns, object value, System.Runtime.Serialization.XmlObjectSerializer serializer) { return default(System.ServiceModel.Channels.AddressHeader); }
    public override bool Equals(object obj) { return default(bool); }
    public virtual System.Xml.XmlDictionaryReader GetAddressHeaderReader() { return default(System.Xml.XmlDictionaryReader); }
    public override int GetHashCode() { return default(int); }
    public T GetValue<T>() { return default(T); }
    public T GetValue<T>(System.Runtime.Serialization.XmlObjectSerializer serializer) { return default(T); }
    protected abstract void OnWriteAddressHeaderContents(System.Xml.XmlDictionaryWriter writer);
    protected virtual void OnWriteStartAddressHeader(System.Xml.XmlDictionaryWriter writer) { }
    public System.ServiceModel.Channels.MessageHeader ToMessageHeader() { return default(System.ServiceModel.Channels.MessageHeader); }
    public void WriteAddressHeader(System.Xml.XmlDictionaryWriter writer) { }
    public void WriteAddressHeader(System.Xml.XmlWriter writer) { }
    public void WriteAddressHeaderContents(System.Xml.XmlDictionaryWriter writer) { }
    public void WriteStartAddressHeader(System.Xml.XmlDictionaryWriter writer) { }
  }

  public sealed partial class AddressHeaderCollection : System.Collections.ObjectModel.ReadOnlyCollection<System.ServiceModel.Channels.AddressHeader> {
    public AddressHeaderCollection() : base (default(System.Collections.Generic.IList<System.ServiceModel.Channels.AddressHeader>)) { }
    public AddressHeaderCollection(System.Collections.Generic.IEnumerable<System.ServiceModel.Channels.AddressHeader> addressHeaders) : base (default(System.Collections.Generic.IList<System.ServiceModel.Channels.AddressHeader>)) { }
    public void AddHeadersTo(System.ServiceModel.Channels.Message message) { }
    public System.ServiceModel.Channels.AddressHeader[] FindAll(string name, string ns) { return default(System.ServiceModel.Channels.AddressHeader[]); }
    public System.ServiceModel.Channels.AddressHeader FindHeader(string name, string ns) { return default(System.ServiceModel.Channels.AddressHeader); }
  }

  public sealed partial class AddressingVersion {
    internal AddressingVersion() { }
    public static System.ServiceModel.Channels.AddressingVersion None { get { return default(System.ServiceModel.Channels.AddressingVersion); } }
    public static System.ServiceModel.Channels.AddressingVersion WSAddressing10 { get { return default(System.ServiceModel.Channels.AddressingVersion); } }
    public override string ToString() { return default(string); }
  }

  public sealed partial class BinaryMessageEncodingBindingElement : System.ServiceModel.Channels.MessageEncodingBindingElement {
    public BinaryMessageEncodingBindingElement() { }
    [System.ComponentModel.DefaultValueAttribute((System.ServiceModel.Channels.CompressionFormat)(0))]
    public System.ServiceModel.Channels.CompressionFormat CompressionFormat { get { return default(System.ServiceModel.Channels.CompressionFormat); } set { } }
    [System.ComponentModel.DefaultValueAttribute(2048)]
    public int MaxSessionSize { get { return default(int); } set { } }
    public override System.ServiceModel.Channels.MessageVersion MessageVersion { get { return default(System.ServiceModel.Channels.MessageVersion); } set { } }
    public System.Xml.XmlDictionaryReaderQuotas ReaderQuotas { get { return default(System.Xml.XmlDictionaryReaderQuotas); } set { } }
    public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    public override System.ServiceModel.Channels.BindingElement Clone() { return default(System.ServiceModel.Channels.BindingElement); }
    public override System.ServiceModel.Channels.MessageEncoderFactory CreateMessageEncoderFactory() { return default(System.ServiceModel.Channels.MessageEncoderFactory); }
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
  }

  public abstract partial class Binding : System.ServiceModel.IDefaultCommunicationTimeouts {
    protected Binding() { }
    protected Binding(string name, string ns) { }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.TimeSpan), "00:01:00")]
    public System.TimeSpan CloseTimeout { get { return default(System.TimeSpan); } set { } }
    public System.ServiceModel.Channels.MessageVersion MessageVersion { get { return default(System.ServiceModel.Channels.MessageVersion); } }
    public string Name { get { return default(string); } set { } }
    public string Namespace { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.TimeSpan), "00:01:00")]
    public System.TimeSpan OpenTimeout { get { return default(System.TimeSpan); } set { } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.TimeSpan), "00:10:00")]
    public System.TimeSpan ReceiveTimeout { get { return default(System.TimeSpan); } set { } }
    public abstract string Scheme { get; }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.TimeSpan), "00:01:00")]
    public System.TimeSpan SendTimeout { get { return default(System.TimeSpan); } set { } }
    public System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(params object[] parameters) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    public virtual System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingParameterCollection parameters) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    public bool CanBuildChannelFactory<TChannel>(params object[] parameters) { return default(bool); }
    public virtual bool CanBuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingParameterCollection parameters) { return default(bool); }
    public abstract System.ServiceModel.Channels.BindingElementCollection CreateBindingElements();
    public T GetProperty<T>(System.ServiceModel.Channels.BindingParameterCollection parameters) where T : class { return default(T); }
  }

  public partial class BindingContext {
    public BindingContext(System.ServiceModel.Channels.CustomBinding binding, System.ServiceModel.Channels.BindingParameterCollection parameters) { }
    public System.ServiceModel.Channels.CustomBinding Binding { get { return default(System.ServiceModel.Channels.CustomBinding); } }
    public System.ServiceModel.Channels.BindingParameterCollection BindingParameters { get { return default(System.ServiceModel.Channels.BindingParameterCollection); } }
    public System.ServiceModel.Channels.BindingElementCollection RemainingBindingElements { get { return default(System.ServiceModel.Channels.BindingElementCollection); } }
    public System.ServiceModel.Channels.IChannelFactory<TChannel> BuildInnerChannelFactory<TChannel>() { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    public bool CanBuildInnerChannelFactory<TChannel>() { return default(bool); }
    public System.ServiceModel.Channels.BindingContext Clone() { return default(System.ServiceModel.Channels.BindingContext); }
    public T GetInnerProperty<T>() where T : class { return default(T); }
  }

  public abstract partial class BindingElement {
    protected BindingElement() { }
    protected BindingElement(System.ServiceModel.Channels.BindingElement elementToBeCloned) { }
    public virtual System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    public virtual bool CanBuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public abstract System.ServiceModel.Channels.BindingElement Clone();
    public abstract T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) where T : class;
  }

  public partial class BindingElementCollection : System.Collections.ObjectModel.Collection<System.ServiceModel.Channels.BindingElement> {
    public BindingElementCollection() { }
    public BindingElementCollection(System.Collections.Generic.IEnumerable<System.ServiceModel.Channels.BindingElement> elements) { }
    public BindingElementCollection(System.ServiceModel.Channels.BindingElement[] elements) { }
    public void AddRange(params System.ServiceModel.Channels.BindingElement[] elements) { }
    public System.ServiceModel.Channels.BindingElementCollection Clone() { return default(System.ServiceModel.Channels.BindingElementCollection); }
    public bool Contains(System.Type bindingElementType) { return default(bool); }
    public T Find<T>() { return default(T); }
    public System.Collections.ObjectModel.Collection<T> FindAll<T>() { return default(System.Collections.ObjectModel.Collection<T>); }
    protected override void InsertItem(int index, System.ServiceModel.Channels.BindingElement item) { }
    public T Remove<T>() { return default(T); }
    public System.Collections.ObjectModel.Collection<T> RemoveAll<T>() { return default(System.Collections.ObjectModel.Collection<T>); }
    protected override void SetItem(int index, System.ServiceModel.Channels.BindingElement item) { }
  }

  public partial class BindingParameterCollection : System.Collections.ObjectModel.KeyedCollection<System.Type, object> {
    public BindingParameterCollection() { }
    protected override System.Type GetKeyForItem(object item) { return default(System.Type); }
    protected override void InsertItem(int index, object item) { }
    protected override void SetItem(int index, object item) { }
  }

  public abstract partial class BodyWriter {
    protected BodyWriter(bool isBuffered) { }
    public bool IsBuffered { get { return default(bool); } }
    public System.ServiceModel.Channels.BodyWriter CreateBufferedCopy(int maxBufferSize) { return default(System.ServiceModel.Channels.BodyWriter); }
    protected virtual System.ServiceModel.Channels.BodyWriter OnCreateBufferedCopy(int maxBufferSize) { return default(System.ServiceModel.Channels.BodyWriter); }
    protected abstract void OnWriteBodyContents(System.Xml.XmlDictionaryWriter writer);
    public void WriteBodyContents(System.Xml.XmlDictionaryWriter writer) { }
  }

  public abstract partial class BufferManager {
    protected BufferManager() { }
    public abstract void Clear();
    public static System.ServiceModel.Channels.BufferManager CreateBufferManager(long maxBufferPoolSize, int maxBufferSize) { return default(System.ServiceModel.Channels.BufferManager); }
    public abstract void ReturnBuffer(byte[] buffer);
    public abstract byte[] TakeBuffer(int bufferSize);
  }

  public abstract partial class ChannelBase : System.ServiceModel.Channels.CommunicationObject, System.ServiceModel.Channels.IChannel, System.ServiceModel.ICommunicationObject, System.ServiceModel.IDefaultCommunicationTimeouts {
    protected ChannelBase(System.ServiceModel.Channels.ChannelManagerBase channelManager) { }
    protected override System.TimeSpan DefaultCloseTimeout { get { return default(System.TimeSpan); } }
    protected override System.TimeSpan DefaultOpenTimeout { get { return default(System.TimeSpan); } }
    protected System.TimeSpan DefaultReceiveTimeout { get { return default(System.TimeSpan); } }
    protected System.TimeSpan DefaultSendTimeout { get { return default(System.TimeSpan); } }
    protected System.ServiceModel.Channels.ChannelManagerBase Manager { get { return default(System.ServiceModel.Channels.ChannelManagerBase); } }
    System.TimeSpan System.ServiceModel.IDefaultCommunicationTimeouts.CloseTimeout { get { return default(System.TimeSpan); } }
    System.TimeSpan System.ServiceModel.IDefaultCommunicationTimeouts.OpenTimeout { get { return default(System.TimeSpan); } }
    System.TimeSpan System.ServiceModel.IDefaultCommunicationTimeouts.ReceiveTimeout { get { return default(System.TimeSpan); } }
    System.TimeSpan System.ServiceModel.IDefaultCommunicationTimeouts.SendTimeout { get { return default(System.TimeSpan); } }
    public virtual T GetProperty<T>() where T : class { return default(T); }
    protected override void OnClosed() { }
  }

  public abstract partial class ChannelFactoryBase : System.ServiceModel.Channels.ChannelManagerBase, System.ServiceModel.Channels.IChannelFactory, System.ServiceModel.ICommunicationObject {
    protected ChannelFactoryBase() { }
    protected ChannelFactoryBase(System.ServiceModel.IDefaultCommunicationTimeouts timeouts) { }
    protected override System.TimeSpan DefaultCloseTimeout { get { return default(System.TimeSpan); } }
    protected override System.TimeSpan DefaultOpenTimeout { get { return default(System.TimeSpan); } }
    protected override System.TimeSpan DefaultReceiveTimeout { get { return default(System.TimeSpan); } }
    protected override System.TimeSpan DefaultSendTimeout { get { return default(System.TimeSpan); } }
    public virtual T GetProperty<T>() where T : class { return default(T); }
    protected override void OnAbort() { }
    protected override System.IAsyncResult OnBeginClose(System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    protected override void OnClose(System.TimeSpan timeout) { }
    protected override void OnEndClose(System.IAsyncResult result) { }
  }

  public abstract partial class ChannelFactoryBase<TChannel> : System.ServiceModel.Channels.ChannelFactoryBase, System.ServiceModel.Channels.IChannelFactory, System.ServiceModel.Channels.IChannelFactory<TChannel>, System.ServiceModel.ICommunicationObject {
    protected ChannelFactoryBase() { }
    protected ChannelFactoryBase(System.ServiceModel.IDefaultCommunicationTimeouts timeouts) { }
    public TChannel CreateChannel(System.ServiceModel.EndpointAddress address) { return default(TChannel); }
    public TChannel CreateChannel(System.ServiceModel.EndpointAddress address, System.Uri via) { return default(TChannel); }
    protected override void OnAbort() { }
    protected override System.IAsyncResult OnBeginClose(System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    protected override void OnClose(System.TimeSpan timeout) { }
    protected abstract TChannel OnCreateChannel(System.ServiceModel.EndpointAddress address, System.Uri via);
    protected override void OnEndClose(System.IAsyncResult result) { }
    protected void ValidateCreateChannel() { }
  }

  public abstract partial class ChannelManagerBase : System.ServiceModel.Channels.CommunicationObject, System.ServiceModel.IDefaultCommunicationTimeouts {
    protected ChannelManagerBase() { }
    protected abstract System.TimeSpan DefaultReceiveTimeout { get; }
    protected abstract System.TimeSpan DefaultSendTimeout { get; }
    System.TimeSpan System.ServiceModel.IDefaultCommunicationTimeouts.CloseTimeout { get { return default(System.TimeSpan); } }
    System.TimeSpan System.ServiceModel.IDefaultCommunicationTimeouts.OpenTimeout { get { return default(System.TimeSpan); } }
    System.TimeSpan System.ServiceModel.IDefaultCommunicationTimeouts.ReceiveTimeout { get { return default(System.TimeSpan); } }
    System.TimeSpan System.ServiceModel.IDefaultCommunicationTimeouts.SendTimeout { get { return default(System.TimeSpan); } }
  }

  public partial class ChannelParameterCollection : System.Collections.ObjectModel.Collection<object> {
    public ChannelParameterCollection() { }
    public ChannelParameterCollection(System.ServiceModel.Channels.IChannel channel) { }
    protected virtual System.ServiceModel.Channels.IChannel Channel { get { return default(System.ServiceModel.Channels.IChannel); } }
    protected override void ClearItems() { }
    protected override void InsertItem(int index, object item) { }
    public void PropagateChannelParameters(System.ServiceModel.Channels.IChannel innerChannel) { }
    protected override void RemoveItem(int index) { }
    protected override void SetItem(int index, object item) { }
  }

  public abstract partial class CommunicationObject : System.ServiceModel.ICommunicationObject {
    protected CommunicationObject() { }
    protected CommunicationObject(object mutex) { }
    protected abstract System.TimeSpan DefaultCloseTimeout { get; }
    protected abstract System.TimeSpan DefaultOpenTimeout { get; }
    protected bool IsDisposed { get { return default(bool); } }
    public System.ServiceModel.CommunicationState State { get { return default(System.ServiceModel.CommunicationState); } }
    protected object ThisLock { get { return default(object); } }
    public event System.EventHandler Closed { add { } remove { } }
    public event System.EventHandler Closing { add { } remove { } }
    public event System.EventHandler Faulted { add { } remove { } }
    public event System.EventHandler Opened { add { } remove { } }
    public event System.EventHandler Opening { add { } remove { } }
    public void Abort() { }
    public System.IAsyncResult BeginClose(System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginClose(System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginOpen(System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginOpen(System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public void Close() { }
    public void Close(System.TimeSpan timeout) { }
    public void EndClose(System.IAsyncResult result) { }
    public void EndOpen(System.IAsyncResult result) { }
    protected void Fault() { }
    protected virtual System.Type GetCommunicationObjectType() { return default(System.Type); }
    protected abstract void OnAbort();
    protected abstract System.IAsyncResult OnBeginClose(System.TimeSpan timeout, System.AsyncCallback callback, object state);
    protected abstract System.IAsyncResult OnBeginOpen(System.TimeSpan timeout, System.AsyncCallback callback, object state);
    protected abstract void OnClose(System.TimeSpan timeout);
    protected virtual void OnClosed() { }
    protected virtual void OnClosing() { }
    protected abstract void OnEndClose(System.IAsyncResult result);
    protected abstract void OnEndOpen(System.IAsyncResult result);
    protected virtual void OnFaulted() { }
    protected abstract void OnOpen(System.TimeSpan timeout);
    protected virtual void OnOpened() { }
    protected virtual void OnOpening() { }
    public void Open() { }
    public void Open(System.TimeSpan timeout) { }
  }

  public enum CompressionFormat {
    Deflate = 2,
    GZip = 1,
    None = 0,
  }

  public partial class CustomBinding : System.ServiceModel.Channels.Binding {
    public CustomBinding() { }
    public CustomBinding(System.Collections.Generic.IEnumerable<System.ServiceModel.Channels.BindingElement> bindingElementsInTopDownChannelStackOrder) { }
    public CustomBinding(System.ServiceModel.Channels.Binding binding) { }
    public CustomBinding(params System.ServiceModel.Channels.BindingElement[] bindingElementsInTopDownChannelStackOrder) { }
    public CustomBinding(string name, string ns, params System.ServiceModel.Channels.BindingElement[] bindingElementsInTopDownChannelStackOrder) { }
    public System.ServiceModel.Channels.BindingElementCollection Elements { get { return default(System.ServiceModel.Channels.BindingElementCollection); } }
    public override string Scheme { get { return default(string); } }
    public override System.ServiceModel.Channels.BindingElementCollection CreateBindingElements() { return default(System.ServiceModel.Channels.BindingElementCollection); }
  }

  public abstract partial class FaultConverter {
    protected FaultConverter() { }
    public static System.ServiceModel.Channels.FaultConverter GetDefaultFaultConverter(System.ServiceModel.Channels.MessageVersion version) { return default(System.ServiceModel.Channels.FaultConverter); }
    protected abstract bool OnTryCreateException(System.ServiceModel.Channels.Message message, System.ServiceModel.Channels.MessageFault fault, out System.Exception exception);
    protected abstract bool OnTryCreateFaultMessage(System.Exception exception, out System.ServiceModel.Channels.Message message);
    public bool TryCreateException(System.ServiceModel.Channels.Message message, System.ServiceModel.Channels.MessageFault fault, out System.Exception exception) { exception = default(System.Exception); return default(bool); }
  }

  public partial interface IChannel : System.ServiceModel.ICommunicationObject {
    T GetProperty<T>() where T : class;
  }

  public partial interface IChannelFactory : System.ServiceModel.ICommunicationObject {
    T GetProperty<T>() where T : class;
  }

  public partial interface IChannelFactory<TChannel> : System.ServiceModel.Channels.IChannelFactory, System.ServiceModel.ICommunicationObject {
    TChannel CreateChannel(System.ServiceModel.EndpointAddress to);
    TChannel CreateChannel(System.ServiceModel.EndpointAddress to, System.Uri via);
  }

  public partial interface IDuplexChannel : System.ServiceModel.Channels.IChannel, System.ServiceModel.Channels.IInputChannel, System.ServiceModel.Channels.IOutputChannel, System.ServiceModel.ICommunicationObject {
  }

  public partial interface IDuplexSession : System.ServiceModel.Channels.IInputSession, System.ServiceModel.Channels.IOutputSession, System.ServiceModel.Channels.ISession {
    System.IAsyncResult BeginCloseOutputSession(System.AsyncCallback callback, object state);
    System.IAsyncResult BeginCloseOutputSession(System.TimeSpan timeout, System.AsyncCallback callback, object state);
    void CloseOutputSession();
    void CloseOutputSession(System.TimeSpan timeout);
    void EndCloseOutputSession(System.IAsyncResult result);
  }

  public partial interface IDuplexSessionChannel : System.ServiceModel.Channels.IChannel, System.ServiceModel.Channels.IDuplexChannel, System.ServiceModel.Channels.IInputChannel, System.ServiceModel.Channels.IOutputChannel, System.ServiceModel.Channels.ISessionChannel<System.ServiceModel.Channels.IDuplexSession>, System.ServiceModel.ICommunicationObject {
  }

  public partial interface IInputChannel : System.ServiceModel.Channels.IChannel, System.ServiceModel.ICommunicationObject {
    System.ServiceModel.EndpointAddress LocalAddress { get; }
    System.IAsyncResult BeginReceive(System.AsyncCallback callback, object state);
    System.IAsyncResult BeginReceive(System.TimeSpan timeout, System.AsyncCallback callback, object state);
    System.IAsyncResult BeginTryReceive(System.TimeSpan timeout, System.AsyncCallback callback, object state);
    System.IAsyncResult BeginWaitForMessage(System.TimeSpan timeout, System.AsyncCallback callback, object state);
    System.ServiceModel.Channels.Message EndReceive(System.IAsyncResult result);
    bool EndTryReceive(System.IAsyncResult result, out System.ServiceModel.Channels.Message message);
    bool EndWaitForMessage(System.IAsyncResult result);
    System.ServiceModel.Channels.Message Receive();
    System.ServiceModel.Channels.Message Receive(System.TimeSpan timeout);
    bool TryReceive(System.TimeSpan timeout, out System.ServiceModel.Channels.Message message);
    bool WaitForMessage(System.TimeSpan timeout);
  }

  public partial interface IInputSession : System.ServiceModel.Channels.ISession {
  }

  public partial interface IInputSessionChannel : System.ServiceModel.Channels.IChannel, System.ServiceModel.Channels.IInputChannel, System.ServiceModel.Channels.ISessionChannel<System.ServiceModel.Channels.IInputSession>, System.ServiceModel.ICommunicationObject {
  }

  public partial interface IMessageProperty {
    System.ServiceModel.Channels.IMessageProperty CreateCopy();
  }

  public partial interface IOutputChannel : System.ServiceModel.Channels.IChannel, System.ServiceModel.ICommunicationObject {
    System.ServiceModel.EndpointAddress RemoteAddress { get; }
    System.Uri Via { get; }
    System.IAsyncResult BeginSend(System.ServiceModel.Channels.Message message, System.AsyncCallback callback, object state);
    System.IAsyncResult BeginSend(System.ServiceModel.Channels.Message message, System.TimeSpan timeout, System.AsyncCallback callback, object state);
    void EndSend(System.IAsyncResult result);
    void Send(System.ServiceModel.Channels.Message message);
    void Send(System.ServiceModel.Channels.Message message, System.TimeSpan timeout);
  }

  public partial interface IOutputSession : System.ServiceModel.Channels.ISession {
  }

  public partial interface IOutputSessionChannel : System.ServiceModel.Channels.IChannel, System.ServiceModel.Channels.IOutputChannel, System.ServiceModel.Channels.ISessionChannel<System.ServiceModel.Channels.IOutputSession>, System.ServiceModel.ICommunicationObject {
  }

  public partial interface IRequestChannel : System.ServiceModel.Channels.IChannel, System.ServiceModel.ICommunicationObject {
    System.ServiceModel.EndpointAddress RemoteAddress { get; }
    System.Uri Via { get; }
    System.IAsyncResult BeginRequest(System.ServiceModel.Channels.Message message, System.AsyncCallback callback, object state);
    System.IAsyncResult BeginRequest(System.ServiceModel.Channels.Message message, System.TimeSpan timeout, System.AsyncCallback callback, object state);
    System.ServiceModel.Channels.Message EndRequest(System.IAsyncResult result);
    System.ServiceModel.Channels.Message Request(System.ServiceModel.Channels.Message message);
    System.ServiceModel.Channels.Message Request(System.ServiceModel.Channels.Message message, System.TimeSpan timeout);
  }

  public partial interface IRequestSessionChannel : System.ServiceModel.Channels.IChannel, System.ServiceModel.Channels.IRequestChannel, System.ServiceModel.Channels.ISessionChannel<System.ServiceModel.Channels.IOutputSession>, System.ServiceModel.ICommunicationObject {
  }

  public partial interface ISession {
    string Id { get; }
  }

  public partial interface ISessionChannel<TSession> where TSession : System.ServiceModel.Channels.ISession {
    TSession Session { get; }
  }

  public abstract partial class Message : System.IDisposable {
    protected Message() { }
    public abstract System.ServiceModel.Channels.MessageHeaders Headers { get; }
    protected bool IsDisposed { get { return default(bool); } }
    public virtual bool IsEmpty { get { return default(bool); } }
    public virtual bool IsFault { get { return default(bool); } }
    public abstract System.ServiceModel.Channels.MessageProperties Properties { get; }
    public System.ServiceModel.Channels.MessageState State { get { return default(System.ServiceModel.Channels.MessageState); } }
    public abstract System.ServiceModel.Channels.MessageVersion Version { get; }
    public void Close() { }
    public System.ServiceModel.Channels.MessageBuffer CreateBufferedCopy(int maxBufferSize) { return default(System.ServiceModel.Channels.MessageBuffer); }
    public static System.ServiceModel.Channels.Message CreateMessage(System.ServiceModel.Channels.MessageVersion version, string action) { return default(System.ServiceModel.Channels.Message); }
    public static System.ServiceModel.Channels.Message CreateMessage(System.ServiceModel.Channels.MessageVersion version, string action, object body) { return default(System.ServiceModel.Channels.Message); }
    public static System.ServiceModel.Channels.Message CreateMessage(System.ServiceModel.Channels.MessageVersion version, string action, object body, System.Runtime.Serialization.XmlObjectSerializer serializer) { return default(System.ServiceModel.Channels.Message); }
    public static System.ServiceModel.Channels.Message CreateMessage(System.ServiceModel.Channels.MessageVersion version, string action, System.ServiceModel.Channels.BodyWriter body) { return default(System.ServiceModel.Channels.Message); }
    public static System.ServiceModel.Channels.Message CreateMessage(System.ServiceModel.Channels.MessageVersion version, string action, System.Xml.XmlDictionaryReader body) { return default(System.ServiceModel.Channels.Message); }
    public static System.ServiceModel.Channels.Message CreateMessage(System.ServiceModel.Channels.MessageVersion version, string action, System.Xml.XmlReader body) { return default(System.ServiceModel.Channels.Message); }
    public static System.ServiceModel.Channels.Message CreateMessage(System.Xml.XmlDictionaryReader envelopeReader, int maxSizeOfHeaders, System.ServiceModel.Channels.MessageVersion version) { return default(System.ServiceModel.Channels.Message); }
    public static System.ServiceModel.Channels.Message CreateMessage(System.Xml.XmlReader envelopeReader, int maxSizeOfHeaders, System.ServiceModel.Channels.MessageVersion version) { return default(System.ServiceModel.Channels.Message); }
    public T GetBody<T>() { return default(T); }
    public T GetBody<T>(System.Runtime.Serialization.XmlObjectSerializer serializer) { return default(T); }
    public string GetBodyAttribute(string localName, string ns) { return default(string); }
    public System.Xml.XmlDictionaryReader GetReaderAtBodyContents() { return default(System.Xml.XmlDictionaryReader); }
    protected virtual void OnBodyToString(System.Xml.XmlDictionaryWriter writer) { }
    protected virtual void OnClose() { }
    protected virtual System.ServiceModel.Channels.MessageBuffer OnCreateBufferedCopy(int maxBufferSize) { return default(System.ServiceModel.Channels.MessageBuffer); }
    protected virtual T OnGetBody<T>(System.Xml.XmlDictionaryReader reader) { return default(T); }
    protected virtual string OnGetBodyAttribute(string localName, string ns) { return default(string); }
    protected virtual System.Xml.XmlDictionaryReader OnGetReaderAtBodyContents() { return default(System.Xml.XmlDictionaryReader); }
    protected abstract void OnWriteBodyContents(System.Xml.XmlDictionaryWriter writer);
    protected virtual void OnWriteMessage(System.Xml.XmlDictionaryWriter writer) { }
    protected virtual void OnWriteStartBody(System.Xml.XmlDictionaryWriter writer) { }
    protected virtual void OnWriteStartEnvelope(System.Xml.XmlDictionaryWriter writer) { }
    protected virtual void OnWriteStartHeaders(System.Xml.XmlDictionaryWriter writer) { }
    void System.IDisposable.Dispose() { }
    public override string ToString() { return default(string); }
    public void WriteBody(System.Xml.XmlDictionaryWriter writer) { }
    public void WriteBody(System.Xml.XmlWriter writer) { }
    public void WriteBodyContents(System.Xml.XmlDictionaryWriter writer) { }
    public void WriteMessage(System.Xml.XmlDictionaryWriter writer) { }
    public void WriteMessage(System.Xml.XmlWriter writer) { }
    public void WriteStartBody(System.Xml.XmlDictionaryWriter writer) { }
    public void WriteStartBody(System.Xml.XmlWriter writer) { }
    public void WriteStartEnvelope(System.Xml.XmlDictionaryWriter writer) { }
  }

  public abstract partial class MessageBuffer : System.IDisposable {
    protected MessageBuffer() { }
    public abstract int BufferSize { get; }
    public virtual string MessageContentType { get { return default(string); } }
    public abstract void Close();
    public abstract System.ServiceModel.Channels.Message CreateMessage();
    void System.IDisposable.Dispose() { }
    public virtual void WriteMessage(System.IO.Stream stream) { }
  }

  public abstract partial class MessageEncoder {
    protected MessageEncoder() { }
    public abstract string ContentType { get; }
    public abstract string MediaType { get; }
    public abstract System.ServiceModel.Channels.MessageVersion MessageVersion { get; }
    public virtual T GetProperty<T>() where T : class { return default(T); }
    public virtual bool IsContentTypeSupported(string contentType) { return default(bool); }
    public System.ServiceModel.Channels.Message ReadMessage(System.ArraySegment<byte> buffer, System.ServiceModel.Channels.BufferManager bufferManager) { return default(System.ServiceModel.Channels.Message); }
    public abstract System.ServiceModel.Channels.Message ReadMessage(System.ArraySegment<byte> buffer, System.ServiceModel.Channels.BufferManager bufferManager, string contentType);
    public System.ServiceModel.Channels.Message ReadMessage(System.IO.Stream stream, int maxSizeOfHeaders) { return default(System.ServiceModel.Channels.Message); }
    public abstract System.ServiceModel.Channels.Message ReadMessage(System.IO.Stream stream, int maxSizeOfHeaders, string contentType);
    public override string ToString() { return default(string); }
    public System.ArraySegment<byte> WriteMessage(System.ServiceModel.Channels.Message message, int maxMessageSize, System.ServiceModel.Channels.BufferManager bufferManager) { return default(System.ArraySegment<byte>); }
    public abstract System.ArraySegment<byte> WriteMessage(System.ServiceModel.Channels.Message message, int maxMessageSize, System.ServiceModel.Channels.BufferManager bufferManager, int messageOffset);
    public abstract void WriteMessage(System.ServiceModel.Channels.Message message, System.IO.Stream stream);
  }

  public abstract partial class MessageEncoderFactory {
    protected MessageEncoderFactory() { }
    public abstract System.ServiceModel.Channels.MessageEncoder Encoder { get; }
    public abstract System.ServiceModel.Channels.MessageVersion MessageVersion { get; }
    public virtual System.ServiceModel.Channels.MessageEncoder CreateSessionEncoder() { return default(System.ServiceModel.Channels.MessageEncoder); }
  }

  public abstract partial class MessageEncodingBindingElement : System.ServiceModel.Channels.BindingElement {
    protected MessageEncodingBindingElement() { }
    protected MessageEncodingBindingElement(System.ServiceModel.Channels.MessageEncodingBindingElement elementToBeCloned) { }
    public abstract System.ServiceModel.Channels.MessageVersion MessageVersion { get; set; }
    public abstract System.ServiceModel.Channels.MessageEncoderFactory CreateMessageEncoderFactory();
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
  }

  public abstract partial class MessageFault {
    protected MessageFault() { }
    public virtual string Actor { get { return default(string); } }
    public abstract System.ServiceModel.FaultCode Code { get; }
    public abstract bool HasDetail { get; }
    public virtual string Node { get { return default(string); } }
    public abstract System.ServiceModel.FaultReason Reason { get; }
    public static System.ServiceModel.Channels.MessageFault CreateFault(System.ServiceModel.Channels.Message message, int maxBufferSize) { return default(System.ServiceModel.Channels.MessageFault); }
    public T GetDetail<T>() { return default(T); }
    public T GetDetail<T>(System.Runtime.Serialization.XmlObjectSerializer serializer) { return default(T); }
    public System.Xml.XmlDictionaryReader GetReaderAtDetailContents() { return default(System.Xml.XmlDictionaryReader); }
    protected virtual System.Xml.XmlDictionaryReader OnGetReaderAtDetailContents() { return default(System.Xml.XmlDictionaryReader); }
    protected virtual void OnWriteDetail(System.Xml.XmlDictionaryWriter writer, System.ServiceModel.EnvelopeVersion version) { }
    protected abstract void OnWriteDetailContents(System.Xml.XmlDictionaryWriter writer);
    protected virtual void OnWriteStartDetail(System.Xml.XmlDictionaryWriter writer, System.ServiceModel.EnvelopeVersion version) { }
  }

  public abstract partial class MessageHeader : System.ServiceModel.Channels.MessageHeaderInfo {
    protected MessageHeader() { }
    public override string Actor { get { return default(string); } }
    public override bool IsReferenceParameter { get { return default(bool); } }
    public override bool MustUnderstand { get { return default(bool); } }
    public override bool Relay { get { return default(bool); } }
    public static System.ServiceModel.Channels.MessageHeader CreateHeader(string name, string ns, object value) { return default(System.ServiceModel.Channels.MessageHeader); }
    public static System.ServiceModel.Channels.MessageHeader CreateHeader(string name, string ns, object value, bool mustUnderstand) { return default(System.ServiceModel.Channels.MessageHeader); }
    public static System.ServiceModel.Channels.MessageHeader CreateHeader(string name, string ns, object value, bool mustUnderstand, string actor) { return default(System.ServiceModel.Channels.MessageHeader); }
    public static System.ServiceModel.Channels.MessageHeader CreateHeader(string name, string ns, object value, bool mustUnderstand, string actor, bool relay) { return default(System.ServiceModel.Channels.MessageHeader); }
    public static System.ServiceModel.Channels.MessageHeader CreateHeader(string name, string ns, object value, System.Runtime.Serialization.XmlObjectSerializer serializer) { return default(System.ServiceModel.Channels.MessageHeader); }
    public static System.ServiceModel.Channels.MessageHeader CreateHeader(string name, string ns, object value, System.Runtime.Serialization.XmlObjectSerializer serializer, bool mustUnderstand) { return default(System.ServiceModel.Channels.MessageHeader); }
    public static System.ServiceModel.Channels.MessageHeader CreateHeader(string name, string ns, object value, System.Runtime.Serialization.XmlObjectSerializer serializer, bool mustUnderstand, string actor) { return default(System.ServiceModel.Channels.MessageHeader); }
    public static System.ServiceModel.Channels.MessageHeader CreateHeader(string name, string ns, object value, System.Runtime.Serialization.XmlObjectSerializer serializer, bool mustUnderstand, string actor, bool relay) { return default(System.ServiceModel.Channels.MessageHeader); }
    public virtual bool IsMessageVersionSupported(System.ServiceModel.Channels.MessageVersion messageVersion) { return default(bool); }
    protected abstract void OnWriteHeaderContents(System.Xml.XmlDictionaryWriter writer, System.ServiceModel.Channels.MessageVersion messageVersion);
    protected virtual void OnWriteStartHeader(System.Xml.XmlDictionaryWriter writer, System.ServiceModel.Channels.MessageVersion messageVersion) { }
    public override string ToString() { return default(string); }
    public void WriteHeader(System.Xml.XmlDictionaryWriter writer, System.ServiceModel.Channels.MessageVersion messageVersion) { }
    public void WriteHeader(System.Xml.XmlWriter writer, System.ServiceModel.Channels.MessageVersion messageVersion) { }
    protected void WriteHeaderAttributes(System.Xml.XmlDictionaryWriter writer, System.ServiceModel.Channels.MessageVersion messageVersion) { }
    public void WriteHeaderContents(System.Xml.XmlDictionaryWriter writer, System.ServiceModel.Channels.MessageVersion messageVersion) { }
    public void WriteStartHeader(System.Xml.XmlDictionaryWriter writer, System.ServiceModel.Channels.MessageVersion messageVersion) { }
  }

  public abstract partial class MessageHeaderInfo {
    protected MessageHeaderInfo() { }
    public abstract string Actor { get; }
    public abstract bool IsReferenceParameter { get; }
    public abstract bool MustUnderstand { get; }
    public abstract string Name { get; }
    public abstract string Namespace { get; }
    public abstract bool Relay { get; }
  }

  public sealed partial class MessageHeaders : System.Collections.Generic.IEnumerable<System.ServiceModel.Channels.MessageHeaderInfo>, System.Collections.IEnumerable {
    public MessageHeaders(System.ServiceModel.Channels.MessageHeaders collection) { }
    public MessageHeaders(System.ServiceModel.Channels.MessageVersion version) { }
    public MessageHeaders(System.ServiceModel.Channels.MessageVersion version, int initialSize) { }
    public string Action { get { return default(string); } set { } }
    public int Count { get { return default(int); } }
    public System.ServiceModel.EndpointAddress FaultTo { get { return default(System.ServiceModel.EndpointAddress); } set { } }
    public System.ServiceModel.EndpointAddress From { get { return default(System.ServiceModel.EndpointAddress); } set { } }
    public System.ServiceModel.Channels.MessageHeaderInfo this[int index] { get { return default(System.ServiceModel.Channels.MessageHeaderInfo); } }
    public System.Xml.UniqueId MessageId { get { return default(System.Xml.UniqueId); } set { } }
    public System.ServiceModel.Channels.MessageVersion MessageVersion { get { return default(System.ServiceModel.Channels.MessageVersion); } }
    public System.Xml.UniqueId RelatesTo { get { return default(System.Xml.UniqueId); } set { } }
    public System.ServiceModel.EndpointAddress ReplyTo { get { return default(System.ServiceModel.EndpointAddress); } set { } }
    public System.Uri To { get { return default(System.Uri); } set { } }
    public void Add(System.ServiceModel.Channels.MessageHeader header) { }
    public void Clear() { }
    public void CopyHeaderFrom(System.ServiceModel.Channels.Message message, int headerIndex) { }
    public void CopyHeaderFrom(System.ServiceModel.Channels.MessageHeaders collection, int headerIndex) { }
    public void CopyHeadersFrom(System.ServiceModel.Channels.Message message) { }
    public void CopyHeadersFrom(System.ServiceModel.Channels.MessageHeaders collection) { }
    public void CopyTo(System.ServiceModel.Channels.MessageHeaderInfo[] array, int index) { }
    public int FindHeader(string name, string ns) { return default(int); }
    public int FindHeader(string name, string ns, params string[] actors) { return default(int); }
    public System.Collections.Generic.IEnumerator<System.ServiceModel.Channels.MessageHeaderInfo> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.ServiceModel.Channels.MessageHeaderInfo>); }
    public T GetHeader<T>(int index) { return default(T); }
    public T GetHeader<T>(int index, System.Runtime.Serialization.XmlObjectSerializer serializer) { return default(T); }
    public T GetHeader<T>(string name, string ns) { return default(T); }
    public T GetHeader<T>(string name, string ns, System.Runtime.Serialization.XmlObjectSerializer serializer) { return default(T); }
    public T GetHeader<T>(string name, string ns, params string[] actors) { return default(T); }
    public System.Xml.XmlDictionaryReader GetReaderAtHeader(int headerIndex) { return default(System.Xml.XmlDictionaryReader); }
    public bool HaveMandatoryHeadersBeenUnderstood() { return default(bool); }
    public bool HaveMandatoryHeadersBeenUnderstood(params string[] actors) { return default(bool); }
    public void Insert(int headerIndex, System.ServiceModel.Channels.MessageHeader header) { }
    public void RemoveAll(string name, string ns) { }
    public void RemoveAt(int headerIndex) { }
    public void SetAction(System.Xml.XmlDictionaryString action) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    public void WriteHeader(int headerIndex, System.Xml.XmlDictionaryWriter writer) { }
    public void WriteHeader(int headerIndex, System.Xml.XmlWriter writer) { }
    public void WriteHeaderContents(int headerIndex, System.Xml.XmlDictionaryWriter writer) { }
    public void WriteHeaderContents(int headerIndex, System.Xml.XmlWriter writer) { }
    public void WriteStartHeader(int headerIndex, System.Xml.XmlDictionaryWriter writer) { }
    public void WriteStartHeader(int headerIndex, System.Xml.XmlWriter writer) { }
  }

  public sealed partial class MessageProperties : System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, object>>, System.Collections.Generic.IDictionary<string, object>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object>>, System.Collections.IEnumerable, System.IDisposable {
    public MessageProperties() { }
    public MessageProperties(System.ServiceModel.Channels.MessageProperties properties) { }
    public bool AllowOutputBatching { get { return default(bool); } set { } }
    public int Count { get { return default(int); } }
    public System.ServiceModel.Channels.MessageEncoder Encoder { get { return default(System.ServiceModel.Channels.MessageEncoder); } set { } }
    public bool IsFixedSize { get { return default(bool); } }
    public object this[string name] { get { return default(object); } set { } }
    public System.Collections.Generic.ICollection<string> Keys { get { return default(System.Collections.Generic.ICollection<string>); } }
    bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.IsReadOnly { get { return default(bool); } }
    public System.Collections.Generic.ICollection<object> Values { get { return default(System.Collections.Generic.ICollection<object>); } }
    public System.Uri Via { get { return default(System.Uri); } set { } }
    public void Add(string name, object property) { }
    public void Clear() { }
    public bool ContainsKey(string name) { return default(bool); }
    public void CopyProperties(System.ServiceModel.Channels.MessageProperties properties) { }
    public void Dispose() { }
    public bool Remove(string name) { return default(bool); }
    void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Add(System.Collections.Generic.KeyValuePair<string, object> pair) { }
    bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Contains(System.Collections.Generic.KeyValuePair<string, object> pair) { return default(bool); }
    void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.CopyTo(System.Collections.Generic.KeyValuePair<string, object>[] array, int index) { }
    bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Remove(System.Collections.Generic.KeyValuePair<string, object> pair) { return default(bool); }
    System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object>>); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    public bool TryGetValue(string name, out object value) { value = default(object); return default(bool); }
  }

  public enum MessageState {
    Closed = 4,
    Copied = 3,
    Created = 0,
    Read = 1,
    Written = 2,
  }

  public sealed partial class MessageVersion {
    internal MessageVersion() { }
    public System.ServiceModel.Channels.AddressingVersion Addressing { get { return default(System.ServiceModel.Channels.AddressingVersion); } }
    public static System.ServiceModel.Channels.MessageVersion Default { get { return default(System.ServiceModel.Channels.MessageVersion); } }
    public System.ServiceModel.EnvelopeVersion Envelope { get { return default(System.ServiceModel.EnvelopeVersion); } }
    public static System.ServiceModel.Channels.MessageVersion None { get { return default(System.ServiceModel.Channels.MessageVersion); } }
    public static System.ServiceModel.Channels.MessageVersion Soap11 { get { return default(System.ServiceModel.Channels.MessageVersion); } }
    public static System.ServiceModel.Channels.MessageVersion Soap12WSAddressing10 { get { return default(System.ServiceModel.Channels.MessageVersion); } }
    public static System.ServiceModel.Channels.MessageVersion CreateVersion(System.ServiceModel.EnvelopeVersion envelopeVersion) { return default(System.ServiceModel.Channels.MessageVersion); }
    public static System.ServiceModel.Channels.MessageVersion CreateVersion(System.ServiceModel.EnvelopeVersion envelopeVersion, System.ServiceModel.Channels.AddressingVersion addressingVersion) { return default(System.ServiceModel.Channels.MessageVersion); }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override string ToString() { return default(string); }
  }

  public abstract partial class RequestContext : System.IDisposable {
    protected RequestContext() { }
    public abstract System.ServiceModel.Channels.Message RequestMessage { get; }
    public abstract void Abort();
    public abstract System.IAsyncResult BeginReply(System.ServiceModel.Channels.Message message, System.AsyncCallback callback, object state);
    public abstract System.IAsyncResult BeginReply(System.ServiceModel.Channels.Message message, System.TimeSpan timeout, System.AsyncCallback callback, object state);
    public abstract void Close();
    public abstract void Close(System.TimeSpan timeout);
    protected virtual void Dispose(bool disposing) { }
    public abstract void EndReply(System.IAsyncResult result);
    public abstract void Reply(System.ServiceModel.Channels.Message message);
    public abstract void Reply(System.ServiceModel.Channels.Message message, System.TimeSpan timeout);
    void System.IDisposable.Dispose() { }
  }

  public sealed partial class TextMessageEncodingBindingElement : System.ServiceModel.Channels.MessageEncodingBindingElement {
    public TextMessageEncodingBindingElement() { }
    public TextMessageEncodingBindingElement(System.ServiceModel.Channels.MessageVersion messageVersion, System.Text.Encoding writeEncoding) { }
    public override System.ServiceModel.Channels.MessageVersion MessageVersion { get { return default(System.ServiceModel.Channels.MessageVersion); } set { } }
    public System.Xml.XmlDictionaryReaderQuotas ReaderQuotas { get { return default(System.Xml.XmlDictionaryReaderQuotas); } set { } }
    public System.Text.Encoding WriteEncoding { get { return default(System.Text.Encoding); } set { } }
    public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    public override System.ServiceModel.Channels.BindingElement Clone() { return default(System.ServiceModel.Channels.BindingElement); }
    public override System.ServiceModel.Channels.MessageEncoderFactory CreateMessageEncoderFactory() { return default(System.ServiceModel.Channels.MessageEncoderFactory); }
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
  }

  public abstract partial class TransportBindingElement : System.ServiceModel.Channels.BindingElement {
    protected TransportBindingElement() { }
    protected TransportBindingElement(System.ServiceModel.Channels.TransportBindingElement elementToBeCloned) { }
    [System.ComponentModel.DefaultValueAttribute(false)]
    public virtual bool ManualAddressing { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute((long)65536)]
    public virtual long MaxReceivedMessageSize { get { return default(long); } set { } }
    public abstract string Scheme { get; }
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
  }

  public sealed partial class LocalClientSecuritySettings {
    public LocalClientSecuritySettings() { }
    public System.TimeSpan MaxClockSkew { get { return default(System.TimeSpan); } set { } }
    public System.TimeSpan ReplayWindow { get { return default(System.TimeSpan); } set { } }
    public System.TimeSpan TimestampValidityDuration { get { return default(System.TimeSpan); } set { } }
    public System.ServiceModel.Channels.LocalClientSecuritySettings Clone() { return default(System.ServiceModel.Channels.LocalClientSecuritySettings); }
  }

  public abstract partial class SecurityBindingElement : System.ServiceModel.Channels.BindingElement {
    internal SecurityBindingElement() { }
    public System.ServiceModel.Security.Tokens.SupportingTokenParameters EndpointSupportingTokenParameters { get { return default(System.ServiceModel.Security.Tokens.SupportingTokenParameters); } }
    public bool IncludeTimestamp { get { return default(bool); } set { } }
    public System.ServiceModel.Channels.LocalClientSecuritySettings LocalClientSettings { get { return default(System.ServiceModel.Channels.LocalClientSecuritySettings); } }
    public System.ServiceModel.MessageSecurityVersion MessageSecurityVersion { get { return default(System.ServiceModel.MessageSecurityVersion); } set { } }
    public System.ServiceModel.Channels.SecurityHeaderLayout SecurityHeaderLayout { get { return default(System.ServiceModel.Channels.SecurityHeaderLayout); } set { } }
    public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    protected abstract System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactoryCore<TChannel>(System.ServiceModel.Channels.BindingContext context);
    public override bool CanBuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public static System.ServiceModel.Channels.SecurityBindingElement CreateSecureConversationBindingElement(System.ServiceModel.Channels.SecurityBindingElement bootstrapSecurity) { return default(System.ServiceModel.Channels.SecurityBindingElement); }
    public static System.ServiceModel.Channels.TransportSecurityBindingElement CreateUserNameOverTransportBindingElement() { return default(System.ServiceModel.Channels.TransportSecurityBindingElement); }
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
    public override string ToString() { return default(string); }
  }

  public enum SecurityHeaderLayout {
    Lax = 1,
    Strict = 0,
  }

  public sealed partial class TransportSecurityBindingElement : System.ServiceModel.Channels.SecurityBindingElement {
    public TransportSecurityBindingElement() { }
    protected override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactoryCore<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    public override System.ServiceModel.Channels.BindingElement Clone() { return default(System.ServiceModel.Channels.BindingElement); }
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
  }

} // end of System.ServiceModel.Channels
namespace System.IdentityModel.Selectors {
  public abstract partial class X509CertificateValidator {
    protected X509CertificateValidator() { }
    public abstract void Validate(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
  }

} // end of System.IdentityModel.Selectors
namespace System.ServiceModel.Description {
  public partial class ClientCredentials : System.ServiceModel.Description.IEndpointBehavior {
    public ClientCredentials() { }
    protected ClientCredentials(System.ServiceModel.Description.ClientCredentials other) { }
    public System.ServiceModel.Security.X509CertificateInitiatorClientCredential ClientCertificate { get { return default(System.ServiceModel.Security.X509CertificateInitiatorClientCredential); } }
    public System.ServiceModel.Security.HttpDigestClientCredential HttpDigest { get { return default(System.ServiceModel.Security.HttpDigestClientCredential); } }
    public System.ServiceModel.Security.X509CertificateRecipientClientCredential ServiceCertificate { get { return default(System.ServiceModel.Security.X509CertificateRecipientClientCredential); } }
    public System.ServiceModel.Security.UserNamePasswordClientCredential UserName { get { return default(System.ServiceModel.Security.UserNamePasswordClientCredential); } }
    public System.ServiceModel.Security.WindowsClientCredential Windows { get { return default(System.ServiceModel.Security.WindowsClientCredential); } }
    public virtual void ApplyClientBehavior(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Dispatcher.ClientRuntime behavior) { }
    public System.ServiceModel.Description.ClientCredentials Clone() { return default(System.ServiceModel.Description.ClientCredentials); }
    protected virtual System.ServiceModel.Description.ClientCredentials CloneCore() { return default(System.ServiceModel.Description.ClientCredentials); }
    void System.ServiceModel.Description.IEndpointBehavior.AddBindingParameters(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Channels.BindingParameterCollection bindingParameters) { }
    void System.ServiceModel.Description.IEndpointBehavior.ApplyDispatchBehavior(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Dispatcher.EndpointDispatcher endpointDispatcher) { }
    void System.ServiceModel.Description.IEndpointBehavior.Validate(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint) { }
  }

  public partial class ContractDescription {
    public ContractDescription(string name) { }
    public ContractDescription(string name, string ns) { }
    public System.Type CallbackContractType { get { return default(System.Type); } set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public string ConfigurationName { get { return default(string); } set { } }
    public System.Collections.ObjectModel.KeyedCollection<System.Type, System.ServiceModel.Description.IContractBehavior> ContractBehaviors { get { return default(System.Collections.ObjectModel.KeyedCollection<System.Type, System.ServiceModel.Description.IContractBehavior>); } }
    public System.Type ContractType { get { return default(System.Type); } set { } }
    public string Name { get { return default(string); } set { } }
    public string Namespace { get { return default(string); } set { } }
    public System.ServiceModel.Description.OperationDescriptionCollection Operations { get { return default(System.ServiceModel.Description.OperationDescriptionCollection); } }
  }

  public partial class DataContractSerializerOperationBehavior : System.ServiceModel.Description.IOperationBehavior {
    public DataContractSerializerOperationBehavior(System.ServiceModel.Description.OperationDescription operation) { }
    public DataContractSerializerOperationBehavior(System.ServiceModel.Description.OperationDescription operation, System.ServiceModel.DataContractFormatAttribute dataContractFormatAttribute) { }
    public System.ServiceModel.DataContractFormatAttribute DataContractFormatAttribute { get { return default(System.ServiceModel.DataContractFormatAttribute); } }
    public System.Runtime.Serialization.DataContractResolver DataContractResolver { get { return default(System.Runtime.Serialization.DataContractResolver); } set { } }
    public int MaxItemsInObjectGraph { get { return default(int); } set { } }
    public virtual System.Runtime.Serialization.XmlObjectSerializer CreateSerializer(System.Type type, string name, string ns, System.Collections.Generic.IList<System.Type> knownTypes) { return default(System.Runtime.Serialization.XmlObjectSerializer); }
    public virtual System.Runtime.Serialization.XmlObjectSerializer CreateSerializer(System.Type type, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns, System.Collections.Generic.IList<System.Type> knownTypes) { return default(System.Runtime.Serialization.XmlObjectSerializer); }
    void System.ServiceModel.Description.IOperationBehavior.AddBindingParameters(System.ServiceModel.Description.OperationDescription description, System.ServiceModel.Channels.BindingParameterCollection parameters) { }
    void System.ServiceModel.Description.IOperationBehavior.ApplyClientBehavior(System.ServiceModel.Description.OperationDescription description, System.ServiceModel.Dispatcher.ClientOperation proxy) { }
    void System.ServiceModel.Description.IOperationBehavior.ApplyDispatchBehavior(System.ServiceModel.Description.OperationDescription description, System.ServiceModel.Dispatcher.DispatchOperation dispatch) { }
    void System.ServiceModel.Description.IOperationBehavior.Validate(System.ServiceModel.Description.OperationDescription description) { }
  }

  public partial class FaultDescription {
    public FaultDescription(string action) { }
    public string Action { get { return default(string); } }
    public System.Type DetailType { get { return default(System.Type); } set { } }
    public string Name { get { return default(string); } set { } }
    public string Namespace { get { return default(string); } set { } }
  }

  public partial class FaultDescriptionCollection : System.Collections.ObjectModel.Collection<System.ServiceModel.Description.FaultDescription> {
    internal FaultDescriptionCollection() { }
  }

  public partial interface IContractBehavior {
    void AddBindingParameters(System.ServiceModel.Description.ContractDescription contractDescription, System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Channels.BindingParameterCollection bindingParameters);
    void ApplyClientBehavior(System.ServiceModel.Description.ContractDescription contractDescription, System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.ClientRuntime clientRuntime);
    void ApplyDispatchBehavior(System.ServiceModel.Description.ContractDescription contractDescription, System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.DispatchRuntime dispatchRuntime);
    void Validate(System.ServiceModel.Description.ContractDescription contractDescription, System.ServiceModel.Description.ServiceEndpoint endpoint);
  }

  public partial interface IEndpointBehavior {
    void AddBindingParameters(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Channels.BindingParameterCollection bindingParameters);
    void ApplyClientBehavior(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.ClientRuntime clientRuntime);
    void ApplyDispatchBehavior(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.EndpointDispatcher endpointDispatcher);
    void Validate(System.ServiceModel.Description.ServiceEndpoint endpoint);
  }

  public partial interface IOperationBehavior {
    void AddBindingParameters(System.ServiceModel.Description.OperationDescription operationDescription, System.ServiceModel.Channels.BindingParameterCollection bindingParameters);
    void ApplyClientBehavior(System.ServiceModel.Description.OperationDescription operationDescription, System.ServiceModel.Dispatcher.ClientOperation clientOperation);
    void ApplyDispatchBehavior(System.ServiceModel.Description.OperationDescription operationDescription, System.ServiceModel.Dispatcher.DispatchOperation dispatchOperation);
    void Validate(System.ServiceModel.Description.OperationDescription operationDescription);
  }

  public partial class MessageBodyDescription {
    public MessageBodyDescription() { }
    public System.ServiceModel.Description.MessagePartDescriptionCollection Parts { get { return default(System.ServiceModel.Description.MessagePartDescriptionCollection); } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.ServiceModel.Description.MessagePartDescription ReturnValue { get { return default(System.ServiceModel.Description.MessagePartDescription); } set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public string WrapperName { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public string WrapperNamespace { get { return default(string); } set { } }
  }

  public partial class MessageDescription {
    public MessageDescription(string action, System.ServiceModel.Description.MessageDirection direction) { }
    public string Action { get { return default(string); } }
    public System.ServiceModel.Description.MessageBodyDescription Body { get { return default(System.ServiceModel.Description.MessageBodyDescription); } }
    public System.ServiceModel.Description.MessageDirection Direction { get { return default(System.ServiceModel.Description.MessageDirection); } }
    public System.ServiceModel.Description.MessageHeaderDescriptionCollection Headers { get { return default(System.ServiceModel.Description.MessageHeaderDescriptionCollection); } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public System.Type MessageType { get { return default(System.Type); } set { } }
    public System.ServiceModel.Description.MessagePropertyDescriptionCollection Properties { get { return default(System.ServiceModel.Description.MessagePropertyDescriptionCollection); } }
  }

  public partial class MessageDescriptionCollection : System.Collections.ObjectModel.Collection<System.ServiceModel.Description.MessageDescription> {
    internal MessageDescriptionCollection() { }
    public System.ServiceModel.Description.MessageDescription Find(string action) { return default(System.ServiceModel.Description.MessageDescription); }
    public System.Collections.ObjectModel.Collection<System.ServiceModel.Description.MessageDescription> FindAll(string action) { return default(System.Collections.ObjectModel.Collection<System.ServiceModel.Description.MessageDescription>); }
  }

  public enum MessageDirection {
    Input = 0,
    Output = 1,
  }

  public partial class MessageHeaderDescription : System.ServiceModel.Description.MessagePartDescription {
    public MessageHeaderDescription(string name, string ns) : base (default(string), default(string)) { }
    [System.ComponentModel.DefaultValueAttribute(null)]
    public string Actor { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool MustUnderstand { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool Relay { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool TypedHeader { get { return default(bool); } set { } }
  }

  public partial class MessageHeaderDescriptionCollection : System.Collections.ObjectModel.KeyedCollection<System.Xml.XmlQualifiedName, System.ServiceModel.Description.MessageHeaderDescription> {
    internal MessageHeaderDescriptionCollection() { }
    protected override System.Xml.XmlQualifiedName GetKeyForItem(System.ServiceModel.Description.MessageHeaderDescription item) { return default(System.Xml.XmlQualifiedName); }
  }

  public partial class MessagePartDescription {
    public MessagePartDescription(string name, string ns) { }
    public int Index { get { return default(int); } set { } }
    public System.Reflection.MemberInfo MemberInfo { get { return default(System.Reflection.MemberInfo); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool Multiple { get { return default(bool); } set { } }
    public string Name { get { return default(string); } }
    public string Namespace { get { return default(string); } }
    public System.Type Type { get { return default(System.Type); } set { } }
  }

  public partial class MessagePartDescriptionCollection : System.Collections.ObjectModel.KeyedCollection<System.Xml.XmlQualifiedName, System.ServiceModel.Description.MessagePartDescription> {
    internal MessagePartDescriptionCollection() { }
    protected override System.Xml.XmlQualifiedName GetKeyForItem(System.ServiceModel.Description.MessagePartDescription item) { return default(System.Xml.XmlQualifiedName); }
  }

  public partial class MessagePropertyDescription : System.ServiceModel.Description.MessagePartDescription {
    public MessagePropertyDescription(string name) : base (default(string), default(string)) { }
  }

  public partial class MessagePropertyDescriptionCollection : System.Collections.ObjectModel.KeyedCollection<string, System.ServiceModel.Description.MessagePropertyDescription> {
    internal MessagePropertyDescriptionCollection() { }
    protected override string GetKeyForItem(System.ServiceModel.Description.MessagePropertyDescription item) { return default(string); }
  }

  public partial class OperationDescription {
    public OperationDescription(string name, System.ServiceModel.Description.ContractDescription declaringContract) { }
    public System.ServiceModel.Description.ContractDescription DeclaringContract { get { return default(System.ServiceModel.Description.ContractDescription); } set { } }
    public System.ServiceModel.Description.FaultDescriptionCollection Faults { get { return default(System.ServiceModel.Description.FaultDescriptionCollection); } }
    public bool IsOneWay { get { return default(bool); } }
    public System.Collections.ObjectModel.Collection<System.Type> KnownTypes { get { return default(System.Collections.ObjectModel.Collection<System.Type>); } }
    public System.ServiceModel.Description.MessageDescriptionCollection Messages { get { return default(System.ServiceModel.Description.MessageDescriptionCollection); } }
    public string Name { get { return default(string); } }
    public System.Collections.ObjectModel.KeyedCollection<System.Type, System.ServiceModel.Description.IOperationBehavior> OperationBehaviors { get { return default(System.Collections.ObjectModel.KeyedCollection<System.Type, System.ServiceModel.Description.IOperationBehavior>); } }
    public System.Reflection.MethodInfo TaskMethod { get { return default(System.Reflection.MethodInfo); } set { } }
  }

  public partial class OperationDescriptionCollection : System.Collections.ObjectModel.Collection<System.ServiceModel.Description.OperationDescription> {
    internal OperationDescriptionCollection() { }
    public System.ServiceModel.Description.OperationDescription Find(string name) { return default(System.ServiceModel.Description.OperationDescription); }
    public System.Collections.ObjectModel.Collection<System.ServiceModel.Description.OperationDescription> FindAll(string name) { return default(System.Collections.ObjectModel.Collection<System.ServiceModel.Description.OperationDescription>); }
    protected override void InsertItem(int index, System.ServiceModel.Description.OperationDescription item) { }
    protected override void SetItem(int index, System.ServiceModel.Description.OperationDescription item) { }
  }

  public partial class ServiceEndpoint {
    public ServiceEndpoint(System.ServiceModel.Description.ContractDescription contract) { }
    public ServiceEndpoint(System.ServiceModel.Description.ContractDescription contract, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress address) { }
    public System.ServiceModel.EndpointAddress Address { get { return default(System.ServiceModel.EndpointAddress); } set { } }
    public System.ServiceModel.Channels.Binding Binding { get { return default(System.ServiceModel.Channels.Binding); } set { } }
    public System.ServiceModel.Description.ContractDescription Contract { get { return default(System.ServiceModel.Description.ContractDescription); } set { } }
    public System.Collections.ObjectModel.KeyedCollection<System.Type, System.ServiceModel.Description.IEndpointBehavior> EndpointBehaviors { get { return default(System.Collections.ObjectModel.KeyedCollection<System.Type, System.ServiceModel.Description.IEndpointBehavior>); } }
    public string Name { get { return default(string); } set { } }
  }

} // end of System.ServiceModel.Description
namespace System.ServiceModel.Dispatcher {
  public sealed partial class ClientOperation {
    public ClientOperation(System.ServiceModel.Dispatcher.ClientRuntime parent, string name, string action) { }
    public ClientOperation(System.ServiceModel.Dispatcher.ClientRuntime parent, string name, string action, string replyAction) { }
    public string Action { get { return default(string); } }
    public System.Collections.Generic.ICollection<System.ServiceModel.Dispatcher.IParameterInspector> ClientParameterInspectors { get { return default(System.Collections.Generic.ICollection<System.ServiceModel.Dispatcher.IParameterInspector>); } }
    public bool DeserializeReply { get { return default(bool); } set { } }
    public System.ServiceModel.Dispatcher.IClientMessageFormatter Formatter { get { return default(System.ServiceModel.Dispatcher.IClientMessageFormatter); } set { } }
    public bool IsOneWay { get { return default(bool); } set { } }
    public string Name { get { return default(string); } }
    public System.ServiceModel.Dispatcher.ClientRuntime Parent { get { return default(System.ServiceModel.Dispatcher.ClientRuntime); } }
    public string ReplyAction { get { return default(string); } }
    public bool SerializeRequest { get { return default(bool); } set { } }
    public System.Reflection.MethodInfo TaskMethod { get { return default(System.Reflection.MethodInfo); } set { } }
    public System.Type TaskTResult { get { return default(System.Type); } set { } }
  }

  public sealed partial class ClientRuntime {
    internal ClientRuntime() { }
    public System.Collections.Generic.ICollection<System.ServiceModel.Dispatcher.IClientMessageInspector> ClientMessageInspectors { get { return default(System.Collections.Generic.ICollection<System.ServiceModel.Dispatcher.IClientMessageInspector>); } }
    public System.Collections.Generic.ICollection<System.ServiceModel.Dispatcher.ClientOperation> ClientOperations { get { return default(System.Collections.Generic.ICollection<System.ServiceModel.Dispatcher.ClientOperation>); } }
    public System.Type ContractClientType { get { return default(System.Type); } set { } }
    public string ContractName { get { return default(string); } }
    public string ContractNamespace { get { return default(string); } }
    public bool ManualAddressing { get { return default(bool); } set { } }
    public int MaxFaultSize { get { return default(int); } set { } }
    public System.ServiceModel.Dispatcher.IClientOperationSelector OperationSelector { get { return default(System.ServiceModel.Dispatcher.IClientOperationSelector); } set { } }
    public System.ServiceModel.Dispatcher.ClientOperation UnhandledClientOperation { get { return default(System.ServiceModel.Dispatcher.ClientOperation); } }
    public System.Uri Via { get { return default(System.Uri); } set { } }
  }

  public sealed partial class DispatchOperation {
    public DispatchOperation(System.ServiceModel.Dispatcher.DispatchRuntime parent, string name, string action) { }
    public string Action { get { return default(string); } }
    public bool AutoDisposeParameters { get { return default(bool); } set { } }
    public bool DeserializeRequest { get { return default(bool); } set { } }
    public bool IsOneWay { get { return default(bool); } }
    public string Name { get { return default(string); } }
    public System.ServiceModel.Dispatcher.DispatchRuntime Parent { get { return default(System.ServiceModel.Dispatcher.DispatchRuntime); } }
    public bool SerializeReply { get { return default(bool); } set { } }
  }

  public sealed partial class DispatchRuntime {
    internal DispatchRuntime() { }
  }

  public partial class EndpointDispatcher {
    internal EndpointDispatcher() { }
  }

  public partial interface IClientMessageFormatter {
    object DeserializeReply(System.ServiceModel.Channels.Message message, object[] parameters);
    System.ServiceModel.Channels.Message SerializeRequest(System.ServiceModel.Channels.MessageVersion messageVersion, object[] parameters);
  }

  public partial interface IClientMessageInspector {
    void AfterReceiveReply(ref System.ServiceModel.Channels.Message reply, object correlationState);
    object BeforeSendRequest(ref System.ServiceModel.Channels.Message request, System.ServiceModel.IClientChannel channel);
  }

  public partial interface IClientOperationSelector {
    bool AreParametersRequiredForSelection { get; }
    string SelectOperation(System.Reflection.MethodBase method, object[] parameters);
  }

  public partial interface IParameterInspector {
    void AfterCall(string operationName, object[] outputs, object returnValue, object correlationState);
    object BeforeCall(string operationName, object[] inputs);
  }

} // end of System.ServiceModel.Dispatcher
namespace System.ServiceModel.Security {
  public sealed partial class HttpDigestClientCredential {
    internal HttpDigestClientCredential() { }
    public System.Net.NetworkCredential ClientCredential { get { return default(System.Net.NetworkCredential); } set { } }
  }

  public partial class MessageSecurityException : System.ServiceModel.CommunicationException {
    public MessageSecurityException(string message) { }
    public MessageSecurityException(string message, System.Exception innerException) { }
  }

  public partial class SecurityAccessDeniedException : System.ServiceModel.CommunicationException {
    public SecurityAccessDeniedException(string message) { }
    public SecurityAccessDeniedException(string message, System.Exception innerException) { }
  }

  public sealed partial class UserNamePasswordClientCredential {
    internal UserNamePasswordClientCredential() { }
    public string Password { get { return default(string); } set { } }
    public string UserName { get { return default(string); } set { } }
  }

  public sealed partial class WindowsClientCredential {
    internal WindowsClientCredential() { }
    public System.Security.Principal.TokenImpersonationLevel AllowedImpersonationLevel { get { return default(System.Security.Principal.TokenImpersonationLevel); } set { } }
    public System.Net.NetworkCredential ClientCredential { get { return default(System.Net.NetworkCredential); } set { } }
  }

  public sealed partial class X509CertificateInitiatorClientCredential {
    internal X509CertificateInitiatorClientCredential() { }
    public System.Security.Cryptography.X509Certificates.X509Certificate2 Certificate { get { return default(System.Security.Cryptography.X509Certificates.X509Certificate2); } set { } }
    public void SetCertificate(System.Security.Cryptography.X509Certificates.StoreLocation storeLocation, System.Security.Cryptography.X509Certificates.StoreName storeName, System.Security.Cryptography.X509Certificates.X509FindType findType, object findValue) { }
    public void SetCertificate(string subjectName, System.Security.Cryptography.X509Certificates.StoreLocation storeLocation, System.Security.Cryptography.X509Certificates.StoreName storeName) { }
  }

  public sealed partial class X509CertificateRecipientClientCredential {
    internal X509CertificateRecipientClientCredential() { }
    public System.ServiceModel.Security.X509ServiceCertificateAuthentication Authentication { get { return default(System.ServiceModel.Security.X509ServiceCertificateAuthentication); } }
    public System.Security.Cryptography.X509Certificates.X509Certificate2 DefaultCertificate { get { return default(System.Security.Cryptography.X509Certificates.X509Certificate2); } set { } }
    public System.Collections.Generic.Dictionary<System.Uri, System.Security.Cryptography.X509Certificates.X509Certificate2> ScopedCertificates { get { return default(System.Collections.Generic.Dictionary<System.Uri, System.Security.Cryptography.X509Certificates.X509Certificate2>); } }
    public System.ServiceModel.Security.X509ServiceCertificateAuthentication SslCertificateAuthentication { get { return default(System.ServiceModel.Security.X509ServiceCertificateAuthentication); } set { } }
    public void SetDefaultCertificate(System.Security.Cryptography.X509Certificates.StoreLocation storeLocation, System.Security.Cryptography.X509Certificates.StoreName storeName, System.Security.Cryptography.X509Certificates.X509FindType findType, object findValue) { }
    public void SetDefaultCertificate(string subjectName, System.Security.Cryptography.X509Certificates.StoreLocation storeLocation, System.Security.Cryptography.X509Certificates.StoreName storeName) { }
    public void SetScopedCertificate(System.Security.Cryptography.X509Certificates.StoreLocation storeLocation, System.Security.Cryptography.X509Certificates.StoreName storeName, System.Security.Cryptography.X509Certificates.X509FindType findType, object findValue, System.Uri targetService) { }
    public void SetScopedCertificate(string subjectName, System.Security.Cryptography.X509Certificates.StoreLocation storeLocation, System.Security.Cryptography.X509Certificates.StoreName storeName, System.Uri targetService) { }
  }

  public enum X509CertificateValidationMode {
    ChainTrust = 2,
    Custom = 4,
    None = 0,
    PeerOrChainTrust = 3,
    PeerTrust = 1,
  }

  public sealed partial class X509ServiceCertificateAuthentication {
    public X509ServiceCertificateAuthentication() { }
    public System.ServiceModel.Security.X509CertificateValidationMode CertificateValidationMode { get { return default(System.ServiceModel.Security.X509CertificateValidationMode); } set { } }
    public System.IdentityModel.Selectors.X509CertificateValidator CustomCertificateValidator { get { return default(System.IdentityModel.Selectors.X509CertificateValidator); } set { } }
    public System.Security.Cryptography.X509Certificates.X509RevocationMode RevocationMode { get { return default(System.Security.Cryptography.X509Certificates.X509RevocationMode); } set { } }
    public System.Security.Cryptography.X509Certificates.StoreLocation TrustedStoreLocation { get { return default(System.Security.Cryptography.X509Certificates.StoreLocation); } set { } }
  }

  public abstract partial class BasicSecurityProfileVersion {
    internal BasicSecurityProfileVersion() { }
    public static System.ServiceModel.Security.BasicSecurityProfileVersion BasicSecurityProfile10 { get { return default(System.ServiceModel.Security.BasicSecurityProfileVersion); } }
  }

  public abstract partial class SecureConversationVersion {
    internal SecureConversationVersion() { }
    public static System.ServiceModel.Security.SecureConversationVersion Default { get { return default(System.ServiceModel.Security.SecureConversationVersion); } }
    public System.Xml.XmlDictionaryString Namespace { get { return default(System.Xml.XmlDictionaryString); } }
    public System.Xml.XmlDictionaryString Prefix { get { return default(System.Xml.XmlDictionaryString); } }
    public static System.ServiceModel.Security.SecureConversationVersion WSSecureConversationFeb2005 { get { return default(System.ServiceModel.Security.SecureConversationVersion); } }
  }

  public abstract partial class SecurityPolicyVersion {
    internal SecurityPolicyVersion() { }
    public string Namespace { get { return default(string); } }
    public string Prefix { get { return default(string); } }
    public static System.ServiceModel.Security.SecurityPolicyVersion WSSecurityPolicy11 { get { return default(System.ServiceModel.Security.SecurityPolicyVersion); } }
  }

  public abstract partial class SecurityVersion {
    internal SecurityVersion() { }
    public static System.ServiceModel.Security.SecurityVersion WSSecurity10 { get { return default(System.ServiceModel.Security.SecurityVersion); } }
    public static System.ServiceModel.Security.SecurityVersion WSSecurity11 { get { return default(System.ServiceModel.Security.SecurityVersion); } }
  }

  public abstract partial class TrustVersion {
    internal TrustVersion() { }
    public static System.ServiceModel.Security.TrustVersion Default { get { return default(System.ServiceModel.Security.TrustVersion); } }
    public System.Xml.XmlDictionaryString Namespace { get { return default(System.Xml.XmlDictionaryString); } }
    public System.Xml.XmlDictionaryString Prefix { get { return default(System.Xml.XmlDictionaryString); } }
    public static System.ServiceModel.Security.TrustVersion WSTrustFeb2005 { get { return default(System.ServiceModel.Security.TrustVersion); } }
  }

} // end of System.ServiceModel.Security
namespace System.ServiceModel.Security.Tokens {
  public partial class SecureConversationSecurityTokenParameters : System.ServiceModel.Security.Tokens.SecurityTokenParameters {
    public SecureConversationSecurityTokenParameters() { }
    public SecureConversationSecurityTokenParameters(System.ServiceModel.Channels.SecurityBindingElement bootstrapSecurityBindingElement) { }
    public System.ServiceModel.Channels.SecurityBindingElement BootstrapSecurityBindingElement { get { return default(System.ServiceModel.Channels.SecurityBindingElement); } set { } }
  }

  public abstract partial class SecurityTokenParameters {
    internal SecurityTokenParameters() { }
    public System.ServiceModel.Security.Tokens.SecurityTokenParameters Clone() { return default(System.ServiceModel.Security.Tokens.SecurityTokenParameters); }
  }

  public partial class SupportingTokenParameters {
    public SupportingTokenParameters() { }
    public System.Collections.ObjectModel.Collection<System.ServiceModel.Security.Tokens.SecurityTokenParameters> Endorsing { get { return default(System.Collections.ObjectModel.Collection<System.ServiceModel.Security.Tokens.SecurityTokenParameters>); } }
    public System.Collections.ObjectModel.Collection<System.ServiceModel.Security.Tokens.SecurityTokenParameters> SignedEncrypted { get { return default(System.Collections.ObjectModel.Collection<System.ServiceModel.Security.Tokens.SecurityTokenParameters>); } }
    public System.ServiceModel.Security.Tokens.SupportingTokenParameters Clone() { return default(System.ServiceModel.Security.Tokens.SupportingTokenParameters); }
  }

  public partial class UserNameSecurityTokenParameters : System.ServiceModel.Security.Tokens.SecurityTokenParameters {
    public UserNameSecurityTokenParameters() { }
  }

} // end of System.ServiceModel.Security.Tokens
namespace System.ServiceProcess {
  public partial class ServiceController : System.IDisposable {
    public ServiceController(string name) { }
    public ServiceController(string name, string machineName) { }
    public bool CanPauseAndContinue { get { return default(bool); } }
    public bool CanShutdown { get { return default(bool); } }
    public bool CanStop { get { return default(bool); } }
    public System.ServiceProcess.ServiceController[] DependentServices { get { return default(System.ServiceProcess.ServiceController[]); } }
    public string DisplayName { get { return default(string); } }
    public string MachineName { get { return default(string); } }
    public System.Runtime.InteropServices.SafeHandle ServiceHandle { get { return default(System.Runtime.InteropServices.SafeHandle); } }
    public string ServiceName { get { return default(string); } }
    public System.ServiceProcess.ServiceController[] ServicesDependedOn { get { return default(System.ServiceProcess.ServiceController[]); } }
    public System.ServiceProcess.ServiceType ServiceType { get { return default(System.ServiceProcess.ServiceType); } }
    public System.ServiceProcess.ServiceStartMode StartType { get { return default(System.ServiceProcess.ServiceStartMode); } }
    public System.ServiceProcess.ServiceControllerStatus Status { get { return default(System.ServiceProcess.ServiceControllerStatus); } }
    public void Continue() { }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public static System.ServiceProcess.ServiceController[] GetDevices() { return default(System.ServiceProcess.ServiceController[]); }
    public static System.ServiceProcess.ServiceController[] GetDevices(string machineName) { return default(System.ServiceProcess.ServiceController[]); }
    public static System.ServiceProcess.ServiceController[] GetServices() { return default(System.ServiceProcess.ServiceController[]); }
    public static System.ServiceProcess.ServiceController[] GetServices(string machineName) { return default(System.ServiceProcess.ServiceController[]); }
    public void Pause() { }
    public void Refresh() { }
    public void Start() { }
    public void Start(string[] args) { }
    public void Stop() { }
    public void WaitForStatus(System.ServiceProcess.ServiceControllerStatus desiredStatus) { }
    public void WaitForStatus(System.ServiceProcess.ServiceControllerStatus desiredStatus, System.TimeSpan timeout) { }
  }

  public enum ServiceControllerStatus {
    ContinuePending = 5,
    Paused = 7,
    PausePending = 6,
    Running = 4,
    StartPending = 2,
    Stopped = 1,
    StopPending = 3,
  }

  public enum ServiceStartMode {
    Automatic = 2,
    Boot = 0,
    Disabled = 4,
    Manual = 3,
    System = 1,
  }

  [System.FlagsAttribute]
  public enum ServiceType {
    Adapter = 4,
    FileSystemDriver = 2,
    InteractiveProcess = 256,
    KernelDriver = 1,
    RecognizerDriver = 8,
    Win32OwnProcess = 16,
    Win32ShareProcess = 32,
  }

  public partial class TimeoutException : System.Exception {
    public TimeoutException() { }
    public TimeoutException(string message) { }
    public TimeoutException(string message, System.Exception innerException) { }
  }

} // end of System.ServiceProcess
namespace System.Text {
  public abstract partial class EncodingProvider {
    public EncodingProvider() { }
    public abstract System.Text.Encoding GetEncoding(int codepage);
    public virtual System.Text.Encoding GetEncoding(int codepage, System.Text.EncoderFallback encoderFallback, System.Text.DecoderFallback decoderFallback) { return default(System.Text.Encoding); }
    public abstract System.Text.Encoding GetEncoding(string name);
    public virtual System.Text.Encoding GetEncoding(string name, System.Text.EncoderFallback encoderFallback, System.Text.DecoderFallback decoderFallback) { return default(System.Text.Encoding); }
  }

  [System.Security.SecurityCriticalAttribute]
  public sealed partial class CodePagesEncodingProvider {
    internal CodePagesEncodingProvider() { }
    public static System.Text.EncodingProvider Instance { get { return default(System.Text.EncodingProvider); } }
  }

} // end of System.Text
namespace System.Xml.Schema {
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public partial class XmlSchema {
    internal XmlSchema() { }
  }

  public enum XmlSchemaForm {
    None = 0,
    Qualified = 1,
    Unqualified = 2,
  }

} // end of System.Xml.Schema
namespace System.Xml.Serialization {
  public partial interface IXmlSerializable {
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    System.Xml.Schema.XmlSchema GetSchema();
    void ReadXml(System.Xml.XmlReader reader);
    void WriteXml(System.Xml.XmlWriter writer);
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(1036))]
  public sealed partial class XmlSchemaProviderAttribute : System.Attribute {
    public XmlSchemaProviderAttribute(string methodName) { }
    public bool IsAny { get { return default(bool); } set { } }
    public string MethodName { get { return default(string); } }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(10624), AllowMultiple=false)]
  public partial class XmlAnyAttributeAttribute : System.Attribute {
    public XmlAnyAttributeAttribute() { }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(10624), AllowMultiple=true)]
  public partial class XmlAnyElementAttribute : System.Attribute {
    public XmlAnyElementAttribute() { }
    public XmlAnyElementAttribute(string name) { }
    public XmlAnyElementAttribute(string name, string ns) { }
    public string Name { get { return default(string); } set { } }
    public string Namespace { get { return default(string); } set { } }
    public int Order { get { return default(int); } set { } }
  }

  public partial class XmlAnyElementAttributes : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList {
    public XmlAnyElementAttributes() { }
    public int Count { get { return default(int); } }
    public System.Xml.Serialization.XmlAnyElementAttribute this[int index] { get { return default(System.Xml.Serialization.XmlAnyElementAttribute); } set { } }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    bool System.Collections.IList.IsFixedSize { get { return default(bool); } }
    bool System.Collections.IList.IsReadOnly { get { return default(bool); } }
    object System.Collections.IList.this[int index] { get { return default(object); } set { } }
    public int Add(System.Xml.Serialization.XmlAnyElementAttribute attribute) { return default(int); }
    public void Clear() { }
    public bool Contains(System.Xml.Serialization.XmlAnyElementAttribute attribute) { return default(bool); }
    public void CopyTo(System.Xml.Serialization.XmlAnyElementAttribute[] array, int index) { }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public int IndexOf(System.Xml.Serialization.XmlAnyElementAttribute attribute) { return default(int); }
    public void Insert(int index, System.Xml.Serialization.XmlAnyElementAttribute attribute) { }
    public void Remove(System.Xml.Serialization.XmlAnyElementAttribute attribute) { }
    public void RemoveAt(int index) { }
    void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
    int System.Collections.IList.Add(object value) { return default(int); }
    bool System.Collections.IList.Contains(object value) { return default(bool); }
    int System.Collections.IList.IndexOf(object value) { return default(int); }
    void System.Collections.IList.Insert(int index, object value) { }
    void System.Collections.IList.Remove(object value) { }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(10624), AllowMultiple=false)]
  public partial class XmlArrayAttribute : System.Attribute {
    public XmlArrayAttribute() { }
    public XmlArrayAttribute(string elementName) { }
    public string ElementName { get { return default(string); } set { } }
    public System.Xml.Schema.XmlSchemaForm Form { get { return default(System.Xml.Schema.XmlSchemaForm); } set { } }
    public bool IsNullable { get { return default(bool); } set { } }
    public string Namespace { get { return default(string); } set { } }
    public int Order { get { return default(int); } set { } }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(10624), AllowMultiple=true)]
  public partial class XmlArrayItemAttribute : System.Attribute {
    public XmlArrayItemAttribute() { }
    public XmlArrayItemAttribute(string elementName) { }
    public XmlArrayItemAttribute(string elementName, System.Type type) { }
    public XmlArrayItemAttribute(System.Type type) { }
    public string DataType { get { return default(string); } set { } }
    public string ElementName { get { return default(string); } set { } }
    public System.Xml.Schema.XmlSchemaForm Form { get { return default(System.Xml.Schema.XmlSchemaForm); } set { } }
    public bool IsNullable { get { return default(bool); } set { } }
    public string Namespace { get { return default(string); } set { } }
    public int NestingLevel { get { return default(int); } set { } }
    public System.Type Type { get { return default(System.Type); } set { } }
  }

  public partial class XmlArrayItemAttributes : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList {
    public XmlArrayItemAttributes() { }
    public int Count { get { return default(int); } }
    public System.Xml.Serialization.XmlArrayItemAttribute this[int index] { get { return default(System.Xml.Serialization.XmlArrayItemAttribute); } set { } }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    bool System.Collections.IList.IsFixedSize { get { return default(bool); } }
    bool System.Collections.IList.IsReadOnly { get { return default(bool); } }
    object System.Collections.IList.this[int index] { get { return default(object); } set { } }
    public int Add(System.Xml.Serialization.XmlArrayItemAttribute attribute) { return default(int); }
    public void Clear() { }
    public bool Contains(System.Xml.Serialization.XmlArrayItemAttribute attribute) { return default(bool); }
    public void CopyTo(System.Xml.Serialization.XmlArrayItemAttribute[] array, int index) { }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public int IndexOf(System.Xml.Serialization.XmlArrayItemAttribute attribute) { return default(int); }
    public void Insert(int index, System.Xml.Serialization.XmlArrayItemAttribute attribute) { }
    public void Remove(System.Xml.Serialization.XmlArrayItemAttribute attribute) { }
    public void RemoveAt(int index) { }
    void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
    int System.Collections.IList.Add(object value) { return default(int); }
    bool System.Collections.IList.Contains(object value) { return default(bool); }
    int System.Collections.IList.IndexOf(object value) { return default(int); }
    void System.Collections.IList.Insert(int index, object value) { }
    void System.Collections.IList.Remove(object value) { }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(10624))]
  public partial class XmlAttributeAttribute : System.Attribute {
    public XmlAttributeAttribute() { }
    public XmlAttributeAttribute(string attributeName) { }
    public XmlAttributeAttribute(string attributeName, System.Type type) { }
    public XmlAttributeAttribute(System.Type type) { }
    public string AttributeName { get { return default(string); } set { } }
    public string DataType { get { return default(string); } set { } }
    public System.Xml.Schema.XmlSchemaForm Form { get { return default(System.Xml.Schema.XmlSchemaForm); } set { } }
    public string Namespace { get { return default(string); } set { } }
    public System.Type Type { get { return default(System.Type); } set { } }
  }

  public partial class XmlAttributeOverrides {
    public XmlAttributeOverrides() { }
    public System.Xml.Serialization.XmlAttributes this[System.Type type] { get { return default(System.Xml.Serialization.XmlAttributes); } }
    public System.Xml.Serialization.XmlAttributes this[System.Type type, string member] { get { return default(System.Xml.Serialization.XmlAttributes); } }
    public void Add(System.Type type, string member, System.Xml.Serialization.XmlAttributes attributes) { }
    public void Add(System.Type type, System.Xml.Serialization.XmlAttributes attributes) { }
  }

  public partial class XmlAttributes {
    public XmlAttributes() { }
    public System.Xml.Serialization.XmlAnyAttributeAttribute XmlAnyAttribute { get { return default(System.Xml.Serialization.XmlAnyAttributeAttribute); } set { } }
    public System.Xml.Serialization.XmlAnyElementAttributes XmlAnyElements { get { return default(System.Xml.Serialization.XmlAnyElementAttributes); } }
    public System.Xml.Serialization.XmlArrayAttribute XmlArray { get { return default(System.Xml.Serialization.XmlArrayAttribute); } set { } }
    public System.Xml.Serialization.XmlArrayItemAttributes XmlArrayItems { get { return default(System.Xml.Serialization.XmlArrayItemAttributes); } }
    public System.Xml.Serialization.XmlAttributeAttribute XmlAttribute { get { return default(System.Xml.Serialization.XmlAttributeAttribute); } set { } }
    public System.Xml.Serialization.XmlChoiceIdentifierAttribute XmlChoiceIdentifier { get { return default(System.Xml.Serialization.XmlChoiceIdentifierAttribute); } }
    public object XmlDefaultValue { get { return default(object); } set { } }
    public System.Xml.Serialization.XmlElementAttributes XmlElements { get { return default(System.Xml.Serialization.XmlElementAttributes); } }
    public System.Xml.Serialization.XmlEnumAttribute XmlEnum { get { return default(System.Xml.Serialization.XmlEnumAttribute); } set { } }
    public bool XmlIgnore { get { return default(bool); } set { } }
    public bool Xmlns { get { return default(bool); } set { } }
    public System.Xml.Serialization.XmlRootAttribute XmlRoot { get { return default(System.Xml.Serialization.XmlRootAttribute); } set { } }
    public System.Xml.Serialization.XmlTextAttribute XmlText { get { return default(System.Xml.Serialization.XmlTextAttribute); } set { } }
    public System.Xml.Serialization.XmlTypeAttribute XmlType { get { return default(System.Xml.Serialization.XmlTypeAttribute); } set { } }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(10624), AllowMultiple=false)]
  public partial class XmlChoiceIdentifierAttribute : System.Attribute {
    public XmlChoiceIdentifierAttribute() { }
    public XmlChoiceIdentifierAttribute(string name) { }
    public string MemberName { get { return default(string); } set { } }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(10624), AllowMultiple=true)]
  public partial class XmlElementAttribute : System.Attribute {
    public XmlElementAttribute() { }
    public XmlElementAttribute(string elementName) { }
    public XmlElementAttribute(string elementName, System.Type type) { }
    public XmlElementAttribute(System.Type type) { }
    public string DataType { get { return default(string); } set { } }
    public string ElementName { get { return default(string); } set { } }
    public System.Xml.Schema.XmlSchemaForm Form { get { return default(System.Xml.Schema.XmlSchemaForm); } set { } }
    public bool IsNullable { get { return default(bool); } set { } }
    public string Namespace { get { return default(string); } set { } }
    public int Order { get { return default(int); } set { } }
    public System.Type Type { get { return default(System.Type); } set { } }
  }

  public partial class XmlElementAttributes : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList {
    public XmlElementAttributes() { }
    public int Count { get { return default(int); } }
    public System.Xml.Serialization.XmlElementAttribute this[int index] { get { return default(System.Xml.Serialization.XmlElementAttribute); } set { } }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    bool System.Collections.IList.IsFixedSize { get { return default(bool); } }
    bool System.Collections.IList.IsReadOnly { get { return default(bool); } }
    object System.Collections.IList.this[int index] { get { return default(object); } set { } }
    public int Add(System.Xml.Serialization.XmlElementAttribute attribute) { return default(int); }
    public void Clear() { }
    public bool Contains(System.Xml.Serialization.XmlElementAttribute attribute) { return default(bool); }
    public void CopyTo(System.Xml.Serialization.XmlElementAttribute[] array, int index) { }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public int IndexOf(System.Xml.Serialization.XmlElementAttribute attribute) { return default(int); }
    public void Insert(int index, System.Xml.Serialization.XmlElementAttribute attribute) { }
    public void Remove(System.Xml.Serialization.XmlElementAttribute attribute) { }
    public void RemoveAt(int index) { }
    void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
    int System.Collections.IList.Add(object value) { return default(int); }
    bool System.Collections.IList.Contains(object value) { return default(bool); }
    int System.Collections.IList.IndexOf(object value) { return default(int); }
    void System.Collections.IList.Insert(int index, object value) { }
    void System.Collections.IList.Remove(object value) { }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(256))]
  public partial class XmlEnumAttribute : System.Attribute {
    public XmlEnumAttribute() { }
    public XmlEnumAttribute(string name) { }
    public string Name { get { return default(string); } set { } }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(1100), AllowMultiple=true)]
  public partial class XmlIncludeAttribute : System.Attribute {
    public XmlIncludeAttribute(System.Type type) { }
    public System.Type Type { get { return default(System.Type); } set { } }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(10624), AllowMultiple=false)]
  public partial class XmlNamespaceDeclarationsAttribute : System.Attribute {
    public XmlNamespaceDeclarationsAttribute() { }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(9244))]
  public partial class XmlRootAttribute : System.Attribute {
    public XmlRootAttribute() { }
    public XmlRootAttribute(string elementName) { }
    public string DataType { get { return default(string); } set { } }
    public string ElementName { get { return default(string); } set { } }
    public bool IsNullable { get { return default(bool); } set { } }
    public string Namespace { get { return default(string); } set { } }
  }

  public partial class XmlSerializer {
    protected XmlSerializer() { }
    public XmlSerializer(System.Type type) { }
    public XmlSerializer(System.Type type, string defaultNamespace) { }
    public XmlSerializer(System.Type type, System.Type[] extraTypes) { }
    public XmlSerializer(System.Type type, System.Xml.Serialization.XmlAttributeOverrides overrides) { }
    public XmlSerializer(System.Type type, System.Xml.Serialization.XmlAttributeOverrides overrides, System.Type[] extraTypes, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace) { }
    public XmlSerializer(System.Type type, System.Xml.Serialization.XmlRootAttribute root) { }
    public virtual bool CanDeserialize(System.Xml.XmlReader xmlReader) { return default(bool); }
    public object Deserialize(System.IO.Stream stream) { return default(object); }
    public object Deserialize(System.IO.TextReader textReader) { return default(object); }
    public object Deserialize(System.Xml.XmlReader xmlReader) { return default(object); }
    public static System.Xml.Serialization.XmlSerializer[] FromTypes(System.Type[] types) { return default(System.Xml.Serialization.XmlSerializer[]); }
    public void Serialize(System.IO.Stream stream, object o) { }
    public void Serialize(System.IO.Stream stream, object o, System.Xml.Serialization.XmlSerializerNamespaces namespaces) { }
    public void Serialize(System.IO.TextWriter textWriter, object o) { }
    public void Serialize(System.IO.TextWriter textWriter, object o, System.Xml.Serialization.XmlSerializerNamespaces namespaces) { }
    public void Serialize(System.Xml.XmlWriter xmlWriter, object o) { }
    public void Serialize(System.Xml.XmlWriter xmlWriter, object o, System.Xml.Serialization.XmlSerializerNamespaces namespaces) { }
  }

  public partial class XmlSerializerNamespaces {
    public XmlSerializerNamespaces() { }
    public XmlSerializerNamespaces(System.Xml.Serialization.XmlSerializerNamespaces namespaces) { }
    public XmlSerializerNamespaces(System.Xml.XmlQualifiedName[] namespaces) { }
    public int Count { get { return default(int); } }
    public void Add(string prefix, string ns) { }
    public System.Xml.XmlQualifiedName[] ToArray() { return default(System.Xml.XmlQualifiedName[]); }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(10624))]
  public partial class XmlTextAttribute : System.Attribute {
    public XmlTextAttribute() { }
    public XmlTextAttribute(System.Type type) { }
    public string DataType { get { return default(string); } set { } }
    public System.Type Type { get { return default(System.Type); } set { } }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(1052))]
  public partial class XmlTypeAttribute : System.Attribute {
    public XmlTypeAttribute() { }
    public XmlTypeAttribute(string typeName) { }
    public bool AnonymousType { get { return default(bool); } set { } }
    public bool IncludeInSchema { get { return default(bool); } set { } }
    public string Namespace { get { return default(string); } set { } }
    public string TypeName { get { return default(string); } set { } }
  }

} // end of System.Xml.Serialization
namespace System.Xml.Linq {
  public static partial class Extensions {
    public static System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> Ancestors<T>(this System.Collections.Generic.IEnumerable<T> source) where T : System.Xml.Linq.XNode { return default(System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>); }
    public static System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> Ancestors<T>(this System.Collections.Generic.IEnumerable<T> source, System.Xml.Linq.XName name) where T : System.Xml.Linq.XNode { return default(System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>); }
    public static System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> AncestorsAndSelf(this System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> source) { return default(System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>); }
    public static System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> AncestorsAndSelf(this System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> source, System.Xml.Linq.XName name) { return default(System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>); }
    public static System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute> Attributes(this System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> source) { return default(System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute>); }
    public static System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute> Attributes(this System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> source, System.Xml.Linq.XName name) { return default(System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute>); }
    public static System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode> DescendantNodes<T>(this System.Collections.Generic.IEnumerable<T> source) where T : System.Xml.Linq.XContainer { return default(System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode>); }
    public static System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode> DescendantNodesAndSelf(this System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> source) { return default(System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode>); }
    public static System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> Descendants<T>(this System.Collections.Generic.IEnumerable<T> source) where T : System.Xml.Linq.XContainer { return default(System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>); }
    public static System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> Descendants<T>(this System.Collections.Generic.IEnumerable<T> source, System.Xml.Linq.XName name) where T : System.Xml.Linq.XContainer { return default(System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>); }
    public static System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> DescendantsAndSelf(this System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> source) { return default(System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>); }
    public static System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> DescendantsAndSelf(this System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> source, System.Xml.Linq.XName name) { return default(System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>); }
    public static System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> Elements<T>(this System.Collections.Generic.IEnumerable<T> source) where T : System.Xml.Linq.XContainer { return default(System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>); }
    public static System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> Elements<T>(this System.Collections.Generic.IEnumerable<T> source, System.Xml.Linq.XName name) where T : System.Xml.Linq.XContainer { return default(System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>); }
    public static System.Collections.Generic.IEnumerable<T> InDocumentOrder<T>(this System.Collections.Generic.IEnumerable<T> source) where T : System.Xml.Linq.XNode { return default(System.Collections.Generic.IEnumerable<T>); }
    public static System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode> Nodes<T>(this System.Collections.Generic.IEnumerable<T> source) where T : System.Xml.Linq.XContainer { return default(System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode>); }
    public static void Remove(this System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute> source) { }
    public static void Remove<T>(this System.Collections.Generic.IEnumerable<T> source) where T : System.Xml.Linq.XNode { }
  }

  [System.FlagsAttribute]
  public enum LoadOptions {
    None = 0,
    PreserveWhitespace = 1,
    SetBaseUri = 2,
    SetLineInfo = 4,
  }

  [System.FlagsAttribute]
  public enum ReaderOptions {
    None = 0,
    OmitDuplicateNamespaces = 1,
  }

  [System.FlagsAttribute]
  public enum SaveOptions {
    DisableFormatting = 1,
    None = 0,
    OmitDuplicateNamespaces = 2,
  }

  public partial class XAttribute : System.Xml.Linq.XObject {
    public XAttribute(System.Xml.Linq.XAttribute other) { }
    public XAttribute(System.Xml.Linq.XName name, object value) { }
    public static System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute> EmptySequence { get { return default(System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute>); } }
    public bool IsNamespaceDeclaration { get { return default(bool); } }
    public System.Xml.Linq.XName Name { get { return default(System.Xml.Linq.XName); } }
    public System.Xml.Linq.XAttribute NextAttribute { get { return default(System.Xml.Linq.XAttribute); } }
    public override System.Xml.XmlNodeType NodeType { get { return default(System.Xml.XmlNodeType); } }
    public System.Xml.Linq.XAttribute PreviousAttribute { get { return default(System.Xml.Linq.XAttribute); } }
    public string Value { get { return default(string); } set { } }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator bool (System.Xml.Linq.XAttribute attribute) { return default(bool); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator System.DateTime (System.Xml.Linq.XAttribute attribute) { return default(System.DateTime); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator System.DateTimeOffset (System.Xml.Linq.XAttribute attribute) { return default(System.DateTimeOffset); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator decimal (System.Xml.Linq.XAttribute attribute) { return default(decimal); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator double (System.Xml.Linq.XAttribute attribute) { return default(double); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator System.Guid (System.Xml.Linq.XAttribute attribute) { return default(System.Guid); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator int (System.Xml.Linq.XAttribute attribute) { return default(int); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator long (System.Xml.Linq.XAttribute attribute) { return default(long); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator System.Nullable<bool> (System.Xml.Linq.XAttribute attribute) { return default(System.Nullable<bool>); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator System.Nullable<System.DateTime> (System.Xml.Linq.XAttribute attribute) { return default(System.Nullable<System.DateTime>); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator System.Nullable<System.DateTimeOffset> (System.Xml.Linq.XAttribute attribute) { return default(System.Nullable<System.DateTimeOffset>); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator System.Nullable<decimal> (System.Xml.Linq.XAttribute attribute) { return default(System.Nullable<decimal>); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator System.Nullable<double> (System.Xml.Linq.XAttribute attribute) { return default(System.Nullable<double>); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator System.Nullable<System.Guid> (System.Xml.Linq.XAttribute attribute) { return default(System.Nullable<System.Guid>); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator System.Nullable<int> (System.Xml.Linq.XAttribute attribute) { return default(System.Nullable<int>); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator System.Nullable<long> (System.Xml.Linq.XAttribute attribute) { return default(System.Nullable<long>); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator System.Nullable<float> (System.Xml.Linq.XAttribute attribute) { return default(System.Nullable<float>); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator System.Nullable<System.TimeSpan> (System.Xml.Linq.XAttribute attribute) { return default(System.Nullable<System.TimeSpan>); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator System.Nullable<uint> (System.Xml.Linq.XAttribute attribute) { return default(System.Nullable<uint>); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator System.Nullable<ulong> (System.Xml.Linq.XAttribute attribute) { return default(System.Nullable<ulong>); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator float (System.Xml.Linq.XAttribute attribute) { return default(float); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator string (System.Xml.Linq.XAttribute attribute) { return default(string); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator System.TimeSpan (System.Xml.Linq.XAttribute attribute) { return default(System.TimeSpan); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator uint (System.Xml.Linq.XAttribute attribute) { return default(uint); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator ulong (System.Xml.Linq.XAttribute attribute) { return default(ulong); }
    public void Remove() { }
    public void SetValue(object value) { }
    public override string ToString() { return default(string); }
  }

  public partial class XCData : System.Xml.Linq.XText {
    public XCData(string value) : base (default(string)) { }
    public XCData(System.Xml.Linq.XCData other) : base (default(string)) { }
    public override System.Xml.XmlNodeType NodeType { get { return default(System.Xml.XmlNodeType); } }
    public override void WriteTo(System.Xml.XmlWriter writer) { }
  }

  public partial class XComment : System.Xml.Linq.XNode {
    public XComment(string value) { }
    public XComment(System.Xml.Linq.XComment other) { }
    public override System.Xml.XmlNodeType NodeType { get { return default(System.Xml.XmlNodeType); } }
    public string Value { get { return default(string); } set { } }
    public override void WriteTo(System.Xml.XmlWriter writer) { }
  }

  public abstract partial class XContainer : System.Xml.Linq.XNode {
    internal XContainer() { }
    public System.Xml.Linq.XNode FirstNode { get { return default(System.Xml.Linq.XNode); } }
    public System.Xml.Linq.XNode LastNode { get { return default(System.Xml.Linq.XNode); } }
    public void Add(object content) { }
    public void Add(params object[] content) { }
    public void AddFirst(object content) { }
    public void AddFirst(params object[] content) { }
    public System.Xml.XmlWriter CreateWriter() { return default(System.Xml.XmlWriter); }
    public System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode> DescendantNodes() { return default(System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode>); }
    public System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> Descendants() { return default(System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>); }
    public System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> Descendants(System.Xml.Linq.XName name) { return default(System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>); }
    public System.Xml.Linq.XElement Element(System.Xml.Linq.XName name) { return default(System.Xml.Linq.XElement); }
    public System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> Elements() { return default(System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>); }
    public System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> Elements(System.Xml.Linq.XName name) { return default(System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>); }
    public System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode> Nodes() { return default(System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode>); }
    public void RemoveNodes() { }
    public void ReplaceNodes(object content) { }
    public void ReplaceNodes(params object[] content) { }
  }

  public partial class XDeclaration {
    public XDeclaration(string version, string encoding, string standalone) { }
    public XDeclaration(System.Xml.Linq.XDeclaration other) { }
    public string Encoding { get { return default(string); } set { } }
    public string Standalone { get { return default(string); } set { } }
    public string Version { get { return default(string); } set { } }
    public override string ToString() { return default(string); }
  }

  public partial class XDocument : System.Xml.Linq.XContainer {
    public XDocument() { }
    public XDocument(params object[] content) { }
    public XDocument(System.Xml.Linq.XDeclaration declaration, params object[] content) { }
    public XDocument(System.Xml.Linq.XDocument other) { }
    public System.Xml.Linq.XDeclaration Declaration { get { return default(System.Xml.Linq.XDeclaration); } set { } }
    public System.Xml.Linq.XDocumentType DocumentType { get { return default(System.Xml.Linq.XDocumentType); } }
    public override System.Xml.XmlNodeType NodeType { get { return default(System.Xml.XmlNodeType); } }
    public System.Xml.Linq.XElement Root { get { return default(System.Xml.Linq.XElement); } }
    public static System.Xml.Linq.XDocument Load(System.IO.Stream stream) { return default(System.Xml.Linq.XDocument); }
    public static System.Xml.Linq.XDocument Load(System.IO.Stream stream, System.Xml.Linq.LoadOptions options) { return default(System.Xml.Linq.XDocument); }
    public static System.Xml.Linq.XDocument Load(System.IO.TextReader textReader) { return default(System.Xml.Linq.XDocument); }
    public static System.Xml.Linq.XDocument Load(System.IO.TextReader textReader, System.Xml.Linq.LoadOptions options) { return default(System.Xml.Linq.XDocument); }
    public static System.Xml.Linq.XDocument Load(string uri) { return default(System.Xml.Linq.XDocument); }
    public static System.Xml.Linq.XDocument Load(string uri, System.Xml.Linq.LoadOptions options) { return default(System.Xml.Linq.XDocument); }
    public static System.Xml.Linq.XDocument Load(System.Xml.XmlReader reader) { return default(System.Xml.Linq.XDocument); }
    public static System.Xml.Linq.XDocument Load(System.Xml.XmlReader reader, System.Xml.Linq.LoadOptions options) { return default(System.Xml.Linq.XDocument); }
    public static System.Xml.Linq.XDocument Parse(string text) { return default(System.Xml.Linq.XDocument); }
    public static System.Xml.Linq.XDocument Parse(string text, System.Xml.Linq.LoadOptions options) { return default(System.Xml.Linq.XDocument); }
    public void Save(System.IO.Stream stream) { }
    public void Save(System.IO.Stream stream, System.Xml.Linq.SaveOptions options) { }
    public void Save(System.IO.TextWriter textWriter) { }
    public void Save(System.IO.TextWriter textWriter, System.Xml.Linq.SaveOptions options) { }
    public void Save(System.Xml.XmlWriter writer) { }
    public override void WriteTo(System.Xml.XmlWriter writer) { }
  }

  public partial class XDocumentType : System.Xml.Linq.XNode {
    public XDocumentType(string name, string publicId, string systemId, string internalSubset) { }
    public XDocumentType(System.Xml.Linq.XDocumentType other) { }
    public string InternalSubset { get { return default(string); } set { } }
    public string Name { get { return default(string); } set { } }
    public override System.Xml.XmlNodeType NodeType { get { return default(System.Xml.XmlNodeType); } }
    public string PublicId { get { return default(string); } set { } }
    public string SystemId { get { return default(string); } set { } }
    public override void WriteTo(System.Xml.XmlWriter writer) { }
  }

  public partial class XElement : System.Xml.Linq.XContainer, System.Xml.Serialization.IXmlSerializable {
    public XElement(System.Xml.Linq.XElement other) { }
    public XElement(System.Xml.Linq.XName name) { }
    public XElement(System.Xml.Linq.XName name, object content) { }
    public XElement(System.Xml.Linq.XName name, params object[] content) { }
    public XElement(System.Xml.Linq.XStreamingElement other) { }
    public static System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> EmptySequence { get { return default(System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>); } }
    public System.Xml.Linq.XAttribute FirstAttribute { get { return default(System.Xml.Linq.XAttribute); } }
    public bool HasAttributes { get { return default(bool); } }
    public bool HasElements { get { return default(bool); } }
    public bool IsEmpty { get { return default(bool); } }
    public System.Xml.Linq.XAttribute LastAttribute { get { return default(System.Xml.Linq.XAttribute); } }
    public System.Xml.Linq.XName Name { get { return default(System.Xml.Linq.XName); } set { } }
    public override System.Xml.XmlNodeType NodeType { get { return default(System.Xml.XmlNodeType); } }
    public string Value { get { return default(string); } set { } }
    public System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> AncestorsAndSelf() { return default(System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>); }
    public System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> AncestorsAndSelf(System.Xml.Linq.XName name) { return default(System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>); }
    public System.Xml.Linq.XAttribute Attribute(System.Xml.Linq.XName name) { return default(System.Xml.Linq.XAttribute); }
    public System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute> Attributes() { return default(System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute>); }
    public System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute> Attributes(System.Xml.Linq.XName name) { return default(System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute>); }
    public System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode> DescendantNodesAndSelf() { return default(System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode>); }
    public System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> DescendantsAndSelf() { return default(System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>); }
    public System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> DescendantsAndSelf(System.Xml.Linq.XName name) { return default(System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>); }
    public System.Xml.Linq.XNamespace GetDefaultNamespace() { return default(System.Xml.Linq.XNamespace); }
    public System.Xml.Linq.XNamespace GetNamespaceOfPrefix(string prefix) { return default(System.Xml.Linq.XNamespace); }
    public string GetPrefixOfNamespace(System.Xml.Linq.XNamespace ns) { return default(string); }
    public static System.Xml.Linq.XElement Load(System.IO.Stream stream) { return default(System.Xml.Linq.XElement); }
    public static System.Xml.Linq.XElement Load(System.IO.Stream stream, System.Xml.Linq.LoadOptions options) { return default(System.Xml.Linq.XElement); }
    public static System.Xml.Linq.XElement Load(System.IO.TextReader textReader) { return default(System.Xml.Linq.XElement); }
    public static System.Xml.Linq.XElement Load(System.IO.TextReader textReader, System.Xml.Linq.LoadOptions options) { return default(System.Xml.Linq.XElement); }
    public static System.Xml.Linq.XElement Load(string uri) { return default(System.Xml.Linq.XElement); }
    public static System.Xml.Linq.XElement Load(string uri, System.Xml.Linq.LoadOptions options) { return default(System.Xml.Linq.XElement); }
    public static System.Xml.Linq.XElement Load(System.Xml.XmlReader reader) { return default(System.Xml.Linq.XElement); }
    public static System.Xml.Linq.XElement Load(System.Xml.XmlReader reader, System.Xml.Linq.LoadOptions options) { return default(System.Xml.Linq.XElement); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator bool (System.Xml.Linq.XElement element) { return default(bool); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator System.DateTime (System.Xml.Linq.XElement element) { return default(System.DateTime); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator System.DateTimeOffset (System.Xml.Linq.XElement element) { return default(System.DateTimeOffset); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator decimal (System.Xml.Linq.XElement element) { return default(decimal); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator double (System.Xml.Linq.XElement element) { return default(double); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator System.Guid (System.Xml.Linq.XElement element) { return default(System.Guid); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator int (System.Xml.Linq.XElement element) { return default(int); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator long (System.Xml.Linq.XElement element) { return default(long); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator System.Nullable<bool> (System.Xml.Linq.XElement element) { return default(System.Nullable<bool>); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator System.Nullable<System.DateTime> (System.Xml.Linq.XElement element) { return default(System.Nullable<System.DateTime>); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator System.Nullable<System.DateTimeOffset> (System.Xml.Linq.XElement element) { return default(System.Nullable<System.DateTimeOffset>); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator System.Nullable<decimal> (System.Xml.Linq.XElement element) { return default(System.Nullable<decimal>); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator System.Nullable<double> (System.Xml.Linq.XElement element) { return default(System.Nullable<double>); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator System.Nullable<System.Guid> (System.Xml.Linq.XElement element) { return default(System.Nullable<System.Guid>); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator System.Nullable<int> (System.Xml.Linq.XElement element) { return default(System.Nullable<int>); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator System.Nullable<long> (System.Xml.Linq.XElement element) { return default(System.Nullable<long>); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator System.Nullable<float> (System.Xml.Linq.XElement element) { return default(System.Nullable<float>); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator System.Nullable<System.TimeSpan> (System.Xml.Linq.XElement element) { return default(System.Nullable<System.TimeSpan>); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator System.Nullable<uint> (System.Xml.Linq.XElement element) { return default(System.Nullable<uint>); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator System.Nullable<ulong> (System.Xml.Linq.XElement element) { return default(System.Nullable<ulong>); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator float (System.Xml.Linq.XElement element) { return default(float); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator string (System.Xml.Linq.XElement element) { return default(string); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator System.TimeSpan (System.Xml.Linq.XElement element) { return default(System.TimeSpan); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator uint (System.Xml.Linq.XElement element) { return default(uint); }
    [System.CLSCompliantAttribute(false)]
    public static explicit operator ulong (System.Xml.Linq.XElement element) { return default(ulong); }
    public static System.Xml.Linq.XElement Parse(string text) { return default(System.Xml.Linq.XElement); }
    public static System.Xml.Linq.XElement Parse(string text, System.Xml.Linq.LoadOptions options) { return default(System.Xml.Linq.XElement); }
    public void RemoveAll() { }
    public void RemoveAttributes() { }
    public void ReplaceAll(object content) { }
    public void ReplaceAll(params object[] content) { }
    public void ReplaceAttributes(object content) { }
    public void ReplaceAttributes(params object[] content) { }
    public void Save(System.IO.Stream stream) { }
    public void Save(System.IO.Stream stream, System.Xml.Linq.SaveOptions options) { }
    public void Save(System.IO.TextWriter textWriter) { }
    public void Save(System.IO.TextWriter textWriter, System.Xml.Linq.SaveOptions options) { }
    public void Save(System.Xml.XmlWriter writer) { }
    public void SetAttributeValue(System.Xml.Linq.XName name, object value) { }
    public void SetElementValue(System.Xml.Linq.XName name, object value) { }
    public void SetValue(object value) { }
    System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { return default(System.Xml.Schema.XmlSchema); }
    void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader) { }
    void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer) { }
    public override void WriteTo(System.Xml.XmlWriter writer) { }
  }

  public sealed partial class XName : System.IEquatable<System.Xml.Linq.XName> {
    internal XName() { }
    public string LocalName { get { return default(string); } }
    public System.Xml.Linq.XNamespace Namespace { get { return default(System.Xml.Linq.XNamespace); } }
    public string NamespaceName { get { return default(string); } }
    public override bool Equals(object obj) { return default(bool); }
    public static System.Xml.Linq.XName Get(string expandedName) { return default(System.Xml.Linq.XName); }
    public static System.Xml.Linq.XName Get(string localName, string namespaceName) { return default(System.Xml.Linq.XName); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.Xml.Linq.XName left, System.Xml.Linq.XName right) { return default(bool); }
    [System.CLSCompliantAttribute(false)]
    public static implicit operator System.Xml.Linq.XName (string expandedName) { return default(System.Xml.Linq.XName); }
    public static bool operator !=(System.Xml.Linq.XName left, System.Xml.Linq.XName right) { return default(bool); }
    bool System.IEquatable<System.Xml.Linq.XName>.Equals(System.Xml.Linq.XName other) { return default(bool); }
    public override string ToString() { return default(string); }
  }

  public sealed partial class XNamespace {
    internal XNamespace() { }
    public string NamespaceName { get { return default(string); } }
    public static System.Xml.Linq.XNamespace None { get { return default(System.Xml.Linq.XNamespace); } }
    public static System.Xml.Linq.XNamespace Xml { get { return default(System.Xml.Linq.XNamespace); } }
    public static System.Xml.Linq.XNamespace Xmlns { get { return default(System.Xml.Linq.XNamespace); } }
    public override bool Equals(object obj) { return default(bool); }
    public static System.Xml.Linq.XNamespace Get(string namespaceName) { return default(System.Xml.Linq.XNamespace); }
    public override int GetHashCode() { return default(int); }
    public System.Xml.Linq.XName GetName(string localName) { return default(System.Xml.Linq.XName); }
    public static System.Xml.Linq.XName operator +(System.Xml.Linq.XNamespace ns, string localName) { return default(System.Xml.Linq.XName); }
    public static bool operator ==(System.Xml.Linq.XNamespace left, System.Xml.Linq.XNamespace right) { return default(bool); }
    [System.CLSCompliantAttribute(false)]
    public static implicit operator System.Xml.Linq.XNamespace (string namespaceName) { return default(System.Xml.Linq.XNamespace); }
    public static bool operator !=(System.Xml.Linq.XNamespace left, System.Xml.Linq.XNamespace right) { return default(bool); }
    public override string ToString() { return default(string); }
  }

  public abstract partial class XNode : System.Xml.Linq.XObject {
    internal XNode() { }
    public static System.Xml.Linq.XNodeDocumentOrderComparer DocumentOrderComparer { get { return default(System.Xml.Linq.XNodeDocumentOrderComparer); } }
    public static System.Xml.Linq.XNodeEqualityComparer EqualityComparer { get { return default(System.Xml.Linq.XNodeEqualityComparer); } }
    public System.Xml.Linq.XNode NextNode { get { return default(System.Xml.Linq.XNode); } }
    public System.Xml.Linq.XNode PreviousNode { get { return default(System.Xml.Linq.XNode); } }
    public void AddAfterSelf(object content) { }
    public void AddAfterSelf(params object[] content) { }
    public void AddBeforeSelf(object content) { }
    public void AddBeforeSelf(params object[] content) { }
    public System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> Ancestors() { return default(System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>); }
    public System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> Ancestors(System.Xml.Linq.XName name) { return default(System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>); }
    public static int CompareDocumentOrder(System.Xml.Linq.XNode n1, System.Xml.Linq.XNode n2) { return default(int); }
    public System.Xml.XmlReader CreateReader() { return default(System.Xml.XmlReader); }
    public System.Xml.XmlReader CreateReader(System.Xml.Linq.ReaderOptions readerOptions) { return default(System.Xml.XmlReader); }
    public static bool DeepEquals(System.Xml.Linq.XNode n1, System.Xml.Linq.XNode n2) { return default(bool); }
    public System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> ElementsAfterSelf() { return default(System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>); }
    public System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> ElementsAfterSelf(System.Xml.Linq.XName name) { return default(System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>); }
    public System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> ElementsBeforeSelf() { return default(System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>); }
    public System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> ElementsBeforeSelf(System.Xml.Linq.XName name) { return default(System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>); }
    public bool IsAfter(System.Xml.Linq.XNode node) { return default(bool); }
    public bool IsBefore(System.Xml.Linq.XNode node) { return default(bool); }
    public System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode> NodesAfterSelf() { return default(System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode>); }
    public System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode> NodesBeforeSelf() { return default(System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode>); }
    public static System.Xml.Linq.XNode ReadFrom(System.Xml.XmlReader reader) { return default(System.Xml.Linq.XNode); }
    public void Remove() { }
    public void ReplaceWith(object content) { }
    public void ReplaceWith(params object[] content) { }
    public override string ToString() { return default(string); }
    public string ToString(System.Xml.Linq.SaveOptions options) { return default(string); }
    public abstract void WriteTo(System.Xml.XmlWriter writer);
  }

  public sealed partial class XNodeDocumentOrderComparer : System.Collections.Generic.IComparer<System.Xml.Linq.XNode>, System.Collections.IComparer {
    public XNodeDocumentOrderComparer() { }
    public int Compare(System.Xml.Linq.XNode x, System.Xml.Linq.XNode y) { return default(int); }
    int System.Collections.IComparer.Compare(object x, object y) { return default(int); }
  }

  public sealed partial class XNodeEqualityComparer : System.Collections.Generic.IEqualityComparer<System.Xml.Linq.XNode>, System.Collections.IEqualityComparer {
    public XNodeEqualityComparer() { }
    public bool Equals(System.Xml.Linq.XNode x, System.Xml.Linq.XNode y) { return default(bool); }
    public int GetHashCode(System.Xml.Linq.XNode obj) { return default(int); }
    bool System.Collections.IEqualityComparer.Equals(object x, object y) { return default(bool); }
    int System.Collections.IEqualityComparer.GetHashCode(object obj) { return default(int); }
  }

  public abstract partial class XObject : System.Xml.IXmlLineInfo {
    internal XObject() { }
    public string BaseUri { get { return default(string); } }
    public System.Xml.Linq.XDocument Document { get { return default(System.Xml.Linq.XDocument); } }
    public abstract System.Xml.XmlNodeType NodeType { get; }
    public System.Xml.Linq.XElement Parent { get { return default(System.Xml.Linq.XElement); } }
    int System.Xml.IXmlLineInfo.LineNumber { get { return default(int); } }
    int System.Xml.IXmlLineInfo.LinePosition { get { return default(int); } }
    public event System.EventHandler<System.Xml.Linq.XObjectChangeEventArgs> Changed { add { } remove { } }
    public event System.EventHandler<System.Xml.Linq.XObjectChangeEventArgs> Changing { add { } remove { } }
    public void AddAnnotation(object annotation) { }
    public object Annotation(System.Type type) { return default(object); }
    public T Annotation<T>() where T : class { return default(T); }
    public System.Collections.Generic.IEnumerable<object> Annotations(System.Type type) { return default(System.Collections.Generic.IEnumerable<object>); }
    public System.Collections.Generic.IEnumerable<T> Annotations<T>() where T : class { return default(System.Collections.Generic.IEnumerable<T>); }
    public void RemoveAnnotations(System.Type type) { }
    public void RemoveAnnotations<T>() where T : class { }
    bool System.Xml.IXmlLineInfo.HasLineInfo() { return default(bool); }
  }

  public enum XObjectChange {
    Add = 0,
    Name = 2,
    Remove = 1,
    Value = 3,
  }

  public partial class XObjectChangeEventArgs : System.EventArgs {
    public static readonly System.Xml.Linq.XObjectChangeEventArgs Add;
    public static readonly System.Xml.Linq.XObjectChangeEventArgs Name;
    public static readonly System.Xml.Linq.XObjectChangeEventArgs Remove;
    public static readonly System.Xml.Linq.XObjectChangeEventArgs Value;
    public XObjectChangeEventArgs(System.Xml.Linq.XObjectChange objectChange) { }
    public System.Xml.Linq.XObjectChange ObjectChange { get { return default(System.Xml.Linq.XObjectChange); } }
  }

  public partial class XProcessingInstruction : System.Xml.Linq.XNode {
    public XProcessingInstruction(string target, string data) { }
    public XProcessingInstruction(System.Xml.Linq.XProcessingInstruction other) { }
    public string Data { get { return default(string); } set { } }
    public override System.Xml.XmlNodeType NodeType { get { return default(System.Xml.XmlNodeType); } }
    public string Target { get { return default(string); } set { } }
    public override void WriteTo(System.Xml.XmlWriter writer) { }
  }

  public partial class XStreamingElement {
    public XStreamingElement(System.Xml.Linq.XName name) { }
    public XStreamingElement(System.Xml.Linq.XName name, object content) { }
    public XStreamingElement(System.Xml.Linq.XName name, params object[] content) { }
    public System.Xml.Linq.XName Name { get { return default(System.Xml.Linq.XName); } set { } }
    public void Add(object content) { }
    public void Add(params object[] content) { }
    public void Save(System.IO.Stream stream) { }
    public void Save(System.IO.Stream stream, System.Xml.Linq.SaveOptions options) { }
    public void Save(System.IO.TextWriter textWriter) { }
    public void Save(System.IO.TextWriter textWriter, System.Xml.Linq.SaveOptions options) { }
    public void Save(System.Xml.XmlWriter writer) { }
    public override string ToString() { return default(string); }
    public string ToString(System.Xml.Linq.SaveOptions options) { return default(string); }
    public void WriteTo(System.Xml.XmlWriter writer) { }
  }

  public partial class XText : System.Xml.Linq.XNode {
    public XText(string value) { }
    public XText(System.Xml.Linq.XText other) { }
    public override System.Xml.XmlNodeType NodeType { get { return default(System.Xml.XmlNodeType); } }
    public string Value { get { return default(string); } set { } }
    public override void WriteTo(System.Xml.XmlWriter writer) { }
  }

} // end of System.Xml.Linq
namespace System.Xml.XPath {
  public partial interface IXPathNavigable {
    System.Xml.XPath.XPathNavigator CreateNavigator();
  }

  public enum XmlCaseOrder {
    LowerFirst = 2,
    None = 0,
    UpperFirst = 1,
  }

  public enum XmlDataType {
    Number = 2,
    Text = 1,
  }

  public enum XmlSortOrder {
    Ascending = 1,
    Descending = 2,
  }

  public partial class XPathDocument : System.Xml.XPath.IXPathNavigable {
    public XPathDocument(System.IO.Stream stream) { }
    public XPathDocument(System.IO.TextReader textReader) { }
    public XPathDocument(string uri) { }
    public XPathDocument(string uri, System.Xml.XmlSpace space) { }
    public XPathDocument(System.Xml.XmlReader reader) { }
    public XPathDocument(System.Xml.XmlReader reader, System.Xml.XmlSpace space) { }
    public System.Xml.XPath.XPathNavigator CreateNavigator() { return default(System.Xml.XPath.XPathNavigator); }
  }

  public partial class XPathException : System.Exception {
    public XPathException() { }
    public XPathException(string message) { }
    public XPathException(string message, System.Exception innerException) { }
  }

  public abstract partial class XPathExpression {
    internal XPathExpression() { }
    public abstract string Expression { get; }
    public abstract System.Xml.XPath.XPathResultType ReturnType { get; }
    public abstract void AddSort(object expr, System.Collections.IComparer comparer);
    public abstract void AddSort(object expr, System.Xml.XPath.XmlSortOrder order, System.Xml.XPath.XmlCaseOrder caseOrder, string lang, System.Xml.XPath.XmlDataType dataType);
    public abstract System.Xml.XPath.XPathExpression Clone();
    public static System.Xml.XPath.XPathExpression Compile(string xpath) { return default(System.Xml.XPath.XPathExpression); }
    public static System.Xml.XPath.XPathExpression Compile(string xpath, System.Xml.IXmlNamespaceResolver nsResolver) { return default(System.Xml.XPath.XPathExpression); }
    public abstract void SetContext(System.Xml.IXmlNamespaceResolver nsResolver);
    public abstract void SetContext(System.Xml.XmlNamespaceManager nsManager);
  }

  public abstract partial class XPathItem {
    internal XPathItem() { }
    public abstract bool IsNode { get; }
    public abstract object TypedValue { get; }
    public abstract string Value { get; }
    public abstract bool ValueAsBoolean { get; }
    public abstract System.DateTime ValueAsDateTime { get; }
    public abstract double ValueAsDouble { get; }
    public abstract int ValueAsInt { get; }
    public abstract long ValueAsLong { get; }
    public abstract System.Type ValueType { get; }
    public virtual object ValueAs(System.Type returnType) { return default(object); }
    public abstract object ValueAs(System.Type returnType, System.Xml.IXmlNamespaceResolver nsResolver);
  }

  public enum XPathNamespaceScope {
    All = 0,
    ExcludeXml = 1,
    Local = 2,
  }

  public abstract partial class XPathNavigator : System.Xml.XPath.XPathItem, System.Xml.IXmlNamespaceResolver, System.Xml.XPath.IXPathNavigable {
    protected XPathNavigator() { }
    public abstract string BaseURI { get; }
    public virtual bool CanEdit { get { return default(bool); } }
    public virtual bool HasAttributes { get { return default(bool); } }
    public virtual bool HasChildren { get { return default(bool); } }
    public virtual string InnerXml { get { return default(string); } set { } }
    public abstract bool IsEmptyElement { get; }
    public sealed override bool IsNode { get { return default(bool); } }
    public abstract string LocalName { get; }
    public abstract string Name { get; }
    public abstract string NamespaceURI { get; }
    public abstract System.Xml.XmlNameTable NameTable { get; }
    public static System.Collections.IEqualityComparer NavigatorComparer { get { return default(System.Collections.IEqualityComparer); } }
    public abstract System.Xml.XPath.XPathNodeType NodeType { get; }
    public virtual string OuterXml { get { return default(string); } set { } }
    public abstract string Prefix { get; }
    public override object TypedValue { get { return default(object); } }
    public virtual object UnderlyingObject { get { return default(object); } }
    public override bool ValueAsBoolean { get { return default(bool); } }
    public override System.DateTime ValueAsDateTime { get { return default(System.DateTime); } }
    public override double ValueAsDouble { get { return default(double); } }
    public override int ValueAsInt { get { return default(int); } }
    public override long ValueAsLong { get { return default(long); } }
    public override System.Type ValueType { get { return default(System.Type); } }
    public virtual string XmlLang { get { return default(string); } }
    public virtual System.Xml.XmlWriter AppendChild() { return default(System.Xml.XmlWriter); }
    public virtual void AppendChild(string newChild) { }
    public virtual void AppendChild(System.Xml.XmlReader newChild) { }
    public virtual void AppendChild(System.Xml.XPath.XPathNavigator newChild) { }
    public virtual void AppendChildElement(string prefix, string localName, string namespaceURI, string value) { }
    public abstract System.Xml.XPath.XPathNavigator Clone();
    public virtual System.Xml.XmlNodeOrder ComparePosition(System.Xml.XPath.XPathNavigator nav) { return default(System.Xml.XmlNodeOrder); }
    public virtual System.Xml.XPath.XPathExpression Compile(string xpath) { return default(System.Xml.XPath.XPathExpression); }
    public virtual void CreateAttribute(string prefix, string localName, string namespaceURI, string value) { }
    public virtual System.Xml.XmlWriter CreateAttributes() { return default(System.Xml.XmlWriter); }
    public virtual System.Xml.XPath.XPathNavigator CreateNavigator() { return default(System.Xml.XPath.XPathNavigator); }
    public virtual void DeleteRange(System.Xml.XPath.XPathNavigator lastSiblingToDelete) { }
    public virtual void DeleteSelf() { }
    public virtual object Evaluate(string xpath) { return default(object); }
    public virtual object Evaluate(string xpath, System.Xml.IXmlNamespaceResolver resolver) { return default(object); }
    public virtual object Evaluate(System.Xml.XPath.XPathExpression expr) { return default(object); }
    public virtual object Evaluate(System.Xml.XPath.XPathExpression expr, System.Xml.XPath.XPathNodeIterator context) { return default(object); }
    public virtual string GetAttribute(string localName, string namespaceURI) { return default(string); }
    public virtual string GetNamespace(string name) { return default(string); }
    public virtual System.Collections.Generic.IDictionary<string, string> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope) { return default(System.Collections.Generic.IDictionary<string, string>); }
    public virtual System.Xml.XmlWriter InsertAfter() { return default(System.Xml.XmlWriter); }
    public virtual void InsertAfter(string newSibling) { }
    public virtual void InsertAfter(System.Xml.XmlReader newSibling) { }
    public virtual void InsertAfter(System.Xml.XPath.XPathNavigator newSibling) { }
    public virtual System.Xml.XmlWriter InsertBefore() { return default(System.Xml.XmlWriter); }
    public virtual void InsertBefore(string newSibling) { }
    public virtual void InsertBefore(System.Xml.XmlReader newSibling) { }
    public virtual void InsertBefore(System.Xml.XPath.XPathNavigator newSibling) { }
    public virtual void InsertElementAfter(string prefix, string localName, string namespaceURI, string value) { }
    public virtual void InsertElementBefore(string prefix, string localName, string namespaceURI, string value) { }
    public virtual bool IsDescendant(System.Xml.XPath.XPathNavigator nav) { return default(bool); }
    public abstract bool IsSamePosition(System.Xml.XPath.XPathNavigator other);
    public virtual string LookupNamespace(string prefix) { return default(string); }
    public virtual string LookupPrefix(string namespaceURI) { return default(string); }
    public virtual bool Matches(string xpath) { return default(bool); }
    public virtual bool Matches(System.Xml.XPath.XPathExpression expr) { return default(bool); }
    public abstract bool MoveTo(System.Xml.XPath.XPathNavigator other);
    public virtual bool MoveToAttribute(string localName, string namespaceURI) { return default(bool); }
    public virtual bool MoveToChild(string localName, string namespaceURI) { return default(bool); }
    public virtual bool MoveToChild(System.Xml.XPath.XPathNodeType type) { return default(bool); }
    public virtual bool MoveToFirst() { return default(bool); }
    public abstract bool MoveToFirstAttribute();
    public abstract bool MoveToFirstChild();
    public bool MoveToFirstNamespace() { return default(bool); }
    public abstract bool MoveToFirstNamespace(System.Xml.XPath.XPathNamespaceScope namespaceScope);
    public virtual bool MoveToFollowing(string localName, string namespaceURI) { return default(bool); }
    public virtual bool MoveToFollowing(string localName, string namespaceURI, System.Xml.XPath.XPathNavigator end) { return default(bool); }
    public virtual bool MoveToFollowing(System.Xml.XPath.XPathNodeType type) { return default(bool); }
    public virtual bool MoveToFollowing(System.Xml.XPath.XPathNodeType type, System.Xml.XPath.XPathNavigator end) { return default(bool); }
    public abstract bool MoveToId(string id);
    public virtual bool MoveToNamespace(string name) { return default(bool); }
    public abstract bool MoveToNext();
    public virtual bool MoveToNext(string localName, string namespaceURI) { return default(bool); }
    public virtual bool MoveToNext(System.Xml.XPath.XPathNodeType type) { return default(bool); }
    public abstract bool MoveToNextAttribute();
    public bool MoveToNextNamespace() { return default(bool); }
    public abstract bool MoveToNextNamespace(System.Xml.XPath.XPathNamespaceScope namespaceScope);
    public abstract bool MoveToParent();
    public abstract bool MoveToPrevious();
    public virtual void MoveToRoot() { }
    public virtual System.Xml.XmlWriter PrependChild() { return default(System.Xml.XmlWriter); }
    public virtual void PrependChild(string newChild) { }
    public virtual void PrependChild(System.Xml.XmlReader newChild) { }
    public virtual void PrependChild(System.Xml.XPath.XPathNavigator newChild) { }
    public virtual void PrependChildElement(string prefix, string localName, string namespaceURI, string value) { }
    public virtual System.Xml.XmlReader ReadSubtree() { return default(System.Xml.XmlReader); }
    public virtual System.Xml.XmlWriter ReplaceRange(System.Xml.XPath.XPathNavigator lastSiblingToReplace) { return default(System.Xml.XmlWriter); }
    public virtual void ReplaceSelf(string newNode) { }
    public virtual void ReplaceSelf(System.Xml.XmlReader newNode) { }
    public virtual void ReplaceSelf(System.Xml.XPath.XPathNavigator newNode) { }
    public virtual System.Xml.XPath.XPathNodeIterator Select(string xpath) { return default(System.Xml.XPath.XPathNodeIterator); }
    public virtual System.Xml.XPath.XPathNodeIterator Select(string xpath, System.Xml.IXmlNamespaceResolver resolver) { return default(System.Xml.XPath.XPathNodeIterator); }
    public virtual System.Xml.XPath.XPathNodeIterator Select(System.Xml.XPath.XPathExpression expr) { return default(System.Xml.XPath.XPathNodeIterator); }
    public virtual System.Xml.XPath.XPathNodeIterator SelectAncestors(string name, string namespaceURI, bool matchSelf) { return default(System.Xml.XPath.XPathNodeIterator); }
    public virtual System.Xml.XPath.XPathNodeIterator SelectAncestors(System.Xml.XPath.XPathNodeType type, bool matchSelf) { return default(System.Xml.XPath.XPathNodeIterator); }
    public virtual System.Xml.XPath.XPathNodeIterator SelectChildren(string name, string namespaceURI) { return default(System.Xml.XPath.XPathNodeIterator); }
    public virtual System.Xml.XPath.XPathNodeIterator SelectChildren(System.Xml.XPath.XPathNodeType type) { return default(System.Xml.XPath.XPathNodeIterator); }
    public virtual System.Xml.XPath.XPathNodeIterator SelectDescendants(string name, string namespaceURI, bool matchSelf) { return default(System.Xml.XPath.XPathNodeIterator); }
    public virtual System.Xml.XPath.XPathNodeIterator SelectDescendants(System.Xml.XPath.XPathNodeType type, bool matchSelf) { return default(System.Xml.XPath.XPathNodeIterator); }
    public virtual System.Xml.XPath.XPathNavigator SelectSingleNode(string xpath) { return default(System.Xml.XPath.XPathNavigator); }
    public virtual System.Xml.XPath.XPathNavigator SelectSingleNode(string xpath, System.Xml.IXmlNamespaceResolver resolver) { return default(System.Xml.XPath.XPathNavigator); }
    public virtual System.Xml.XPath.XPathNavigator SelectSingleNode(System.Xml.XPath.XPathExpression expression) { return default(System.Xml.XPath.XPathNavigator); }
    public virtual void SetTypedValue(object typedValue) { }
    public virtual void SetValue(string value) { }
    public override string ToString() { return default(string); }
    public override object ValueAs(System.Type returnType, System.Xml.IXmlNamespaceResolver nsResolver) { return default(object); }
    public virtual void WriteSubtree(System.Xml.XmlWriter writer) { }
  }

  public abstract partial class XPathNodeIterator : System.Collections.IEnumerable {
    protected XPathNodeIterator() { }
    public virtual int Count { get { return default(int); } }
    public abstract System.Xml.XPath.XPathNavigator Current { get; }
    public abstract int CurrentPosition { get; }
    public abstract System.Xml.XPath.XPathNodeIterator Clone();
    public virtual System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public abstract bool MoveNext();
  }

  public enum XPathNodeType {
    All = 9,
    Attribute = 2,
    Comment = 8,
    Element = 1,
    Namespace = 3,
    ProcessingInstruction = 7,
    Root = 0,
    SignificantWhitespace = 5,
    Text = 4,
    Whitespace = 6,
  }

  public enum XPathResultType {
    Any = 5,
    Boolean = 2,
    Error = 6,
    Navigator = 1,
    NodeSet = 3,
    Number = 0,
    String = 1,
  }

  public static partial class Extensions {
    public static System.Xml.XPath.XPathNavigator CreateNavigator(this System.Xml.Linq.XNode node) { return default(System.Xml.XPath.XPathNavigator); }
    public static System.Xml.XPath.XPathNavigator CreateNavigator(this System.Xml.Linq.XNode node, System.Xml.XmlNameTable nameTable) { return default(System.Xml.XPath.XPathNavigator); }
    public static object XPathEvaluate(this System.Xml.Linq.XNode node, string expression) { return default(object); }
    public static object XPathEvaluate(this System.Xml.Linq.XNode node, string expression, System.Xml.IXmlNamespaceResolver resolver) { return default(object); }
    public static System.Xml.Linq.XElement XPathSelectElement(this System.Xml.Linq.XNode node, string expression) { return default(System.Xml.Linq.XElement); }
    public static System.Xml.Linq.XElement XPathSelectElement(this System.Xml.Linq.XNode node, string expression, System.Xml.IXmlNamespaceResolver resolver) { return default(System.Xml.Linq.XElement); }
    public static System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> XPathSelectElements(this System.Xml.Linq.XNode node, string expression) { return default(System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>); }
    public static System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> XPathSelectElements(this System.Xml.Linq.XNode node, string expression, System.Xml.IXmlNamespaceResolver resolver) { return default(System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>); }
  }

  public static partial class XDocumentExtensions {
    public static System.Xml.XPath.IXPathNavigable ToXPathNavigable(this System.Xml.Linq.XNode node) { return default(System.Xml.XPath.IXPathNavigable); }
  }

} // end of System.Xml.XPath
