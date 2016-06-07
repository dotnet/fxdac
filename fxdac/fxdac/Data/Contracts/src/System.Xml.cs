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
