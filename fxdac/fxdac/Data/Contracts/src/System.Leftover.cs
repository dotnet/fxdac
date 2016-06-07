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
namespace Microsoft.Win32.SafeHandles {
  [System.Security.SecurityCriticalAttribute]
  public sealed partial class SafeProcessHandle : System.Runtime.InteropServices.SafeHandle {
    public SafeProcessHandle(System.IntPtr existingHandle, bool ownsHandle) : base (default(System.IntPtr), default(bool)) { }
    public override bool IsInvalid { [System.Security.SecurityCriticalAttribute]get { return default(bool); } }
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
