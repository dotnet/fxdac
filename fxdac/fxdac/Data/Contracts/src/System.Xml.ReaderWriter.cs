[assembly:System.CLSCompliant(true)]
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

} // end of System.Xml
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

} // end of System.Xml.Serialization
