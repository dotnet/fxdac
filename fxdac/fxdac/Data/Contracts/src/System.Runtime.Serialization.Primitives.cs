[assembly:System.CLSCompliant(true)]
namespace System.Runtime.Serialization {
    public partial class SerializationException : System.SystemException
    {
        public SerializationException() { }
        protected SerializationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public SerializationException(string message) { }
        public SerializationException(string message, System.Exception innerException) { }
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
} // end of System.Runtime.Serialization
