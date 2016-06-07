[assembly:System.CLSCompliant(true)]
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
