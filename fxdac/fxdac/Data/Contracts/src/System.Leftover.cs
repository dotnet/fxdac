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

} // end of System.Runtime.InteropServices
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
