[assembly:System.CLSCompliant(true)]
namespace System.Diagnostics {
  [System.Diagnostics.SwitchLevelAttribute(typeof(bool))]
  public partial class BooleanSwitch : System.Diagnostics.Switch {
    public BooleanSwitch(string displayName, string description) : base (default(string), default(string)) { }
    public BooleanSwitch(string displayName, string description, string defaultSwitchValue) : base (default(string), default(string)) { }
    public bool Enabled { get { return default(bool); } set { } }
    protected override void OnValueChanged() { }
  }

  public partial class CorrelationManager {
    internal CorrelationManager() { }
    public System.Guid ActivityId { get { return default(System.Guid); } set { } }
    public System.Collections.Stack LogicalOperationStack { get { return default(System.Collections.Stack); } }
    public void StartLogicalOperation() { }
    public void StartLogicalOperation(object operationId) { }
    public void StopLogicalOperation() { }
  }

  public partial class DefaultTraceListener : System.Diagnostics.TraceListener {
    public DefaultTraceListener() { }
    public bool AssertUiEnabled { get { return default(bool); } set { } }
    public string LogFileName { get { return default(string); } set { } }
    public override void Fail(string message) { }
    public override void Fail(string message, string detailMessage) { }
    public override void Write(string message) { }
    public override void WriteLine(string message) { }
  }

  [System.FlagsAttribute]
  public enum SourceLevels {
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    ActivityTracing = 65280,
    All = -1,
    Critical = 1,
    Error = 3,
    Information = 15,
    Off = 0,
    Verbose = 31,
    Warning = 7,
  }

  public partial class SourceSwitch : System.Diagnostics.Switch {
    public SourceSwitch(string name) : base (default(string), default(string)) { }
    public SourceSwitch(string displayName, string defaultSwitchValue) : base (default(string), default(string)) { }
    public System.Diagnostics.SourceLevels Level { get { return default(System.Diagnostics.SourceLevels); } set { } }
    protected override void OnValueChanged() { }
    public bool ShouldTrace(System.Diagnostics.TraceEventType eventType) { return default(bool); }
  }

  public abstract partial class Switch {
    protected Switch(string displayName, string description) { }
    protected Switch(string displayName, string description, string defaultSwitchValue) { }
    public System.Collections.Specialized.StringDictionary Attributes { get { return default(System.Collections.Specialized.StringDictionary); } }
    public string Description { get { return default(string); } }
    public string DisplayName { get { return default(string); } }
    protected int SwitchSetting { get { return default(int); } set { } }
    protected string Value { get { return default(string); } set { } }
    protected internal virtual string[] GetSupportedAttributes() { return default(string[]); }
    protected virtual void OnSwitchSettingChanged() { }
    protected virtual void OnValueChanged() { }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(741))]
  public sealed partial class SwitchAttribute : System.Attribute {
    public SwitchAttribute(string switchName, System.Type switchType) { }
    public string SwitchDescription { get { return default(string); } set { } }
    public string SwitchName { get { return default(string); } set { } }
    public System.Type SwitchType { get { return default(System.Type); } set { } }
    public static System.Diagnostics.SwitchAttribute[] GetAll(System.Reflection.Assembly assembly) { return default(System.Diagnostics.SwitchAttribute[]); }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
  public sealed partial class SwitchLevelAttribute : System.Attribute {
    public SwitchLevelAttribute(System.Type switchLevelType) { }
    public System.Type SwitchLevelType { get { return default(System.Type); } set { } }
  }

  public sealed partial class Trace {
    internal Trace() { }
    public static bool AutoFlush { get { return default(bool); } set { } }
    public static System.Diagnostics.CorrelationManager CorrelationManager { get { return default(System.Diagnostics.CorrelationManager); } }
    public static int IndentLevel { get { return default(int); } set { } }
    public static int IndentSize { get { return default(int); } set { } }
    public static System.Diagnostics.TraceListenerCollection Listeners { get { return default(System.Diagnostics.TraceListenerCollection); } }
    public static bool UseGlobalLock { get { return default(bool); } set { } }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public static void Assert(bool condition) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public static void Assert(bool condition, string message) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public static void Assert(bool condition, string message, string detailMessage) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public static void Close() { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public static void Fail(string message) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public static void Fail(string message, string detailMessage) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public static void Flush() { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public static void Indent() { }
    public static void Refresh() { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public static void TraceError(string message) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public static void TraceError(string format, params object[] args) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public static void TraceInformation(string message) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public static void TraceInformation(string format, params object[] args) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public static void TraceWarning(string message) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public static void TraceWarning(string format, params object[] args) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public static void Unindent() { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public static void Write(object value) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public static void Write(object value, string category) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public static void Write(string message) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public static void Write(string message, string category) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public static void WriteIf(bool condition, object value) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public static void WriteIf(bool condition, object value, string category) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public static void WriteIf(bool condition, string message) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public static void WriteIf(bool condition, string message, string category) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public static void WriteLine(object value) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public static void WriteLine(object value, string category) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public static void WriteLine(string message) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public static void WriteLine(string message, string category) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public static void WriteLineIf(bool condition, object value) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public static void WriteLineIf(bool condition, object value, string category) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public static void WriteLineIf(bool condition, string message) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public static void WriteLineIf(bool condition, string message, string category) { }
  }

  public partial class TraceEventCache {
    public TraceEventCache() { }
    public string Callstack { get { return default(string); } }
    public System.DateTime DateTime { get { return default(System.DateTime); } }
    public System.Collections.Stack LogicalOperationStack { get { return default(System.Collections.Stack); } }
    public int ProcessId { get { return default(int); } }
    public string ThreadId { get { return default(string); } }
    public long Timestamp { get { return default(long); } }
  }

  public enum TraceEventType {
    Critical = 1,
    Error = 2,
    Information = 8,
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    Resume = 2048,
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    Start = 256,
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    Stop = 512,
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    Suspend = 1024,
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    Transfer = 4096,
    Verbose = 16,
    Warning = 4,
  }

  public abstract partial class TraceFilter {
    protected TraceFilter() { }
    public abstract bool ShouldTrace(System.Diagnostics.TraceEventCache cache, string source, System.Diagnostics.TraceEventType eventType, int id, string formatOrMessage, object[] args, object data1, object[] data);
  }

  public enum TraceLevel {
    Error = 1,
    Info = 3,
    Off = 0,
    Verbose = 4,
    Warning = 2,
  }

  public abstract partial class TraceListener :System.IDisposable {
    protected TraceListener() { }
    protected TraceListener(string name) { }
    public System.Collections.Specialized.StringDictionary Attributes { get { return default(System.Collections.Specialized.StringDictionary); } }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public System.Diagnostics.TraceFilter Filter { get { return default(System.Diagnostics.TraceFilter); } set { } }
    public int IndentLevel { get { return default(int); } set { } }
    public int IndentSize { get { return default(int); } set { } }
    public virtual bool IsThreadSafe { get { return default(bool); } }
    public virtual string Name { get { return default(string); } set { } }
    protected bool NeedIndent { get { return default(bool); } set { } }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public System.Diagnostics.TraceOptions TraceOutputOptions { get { return default(System.Diagnostics.TraceOptions); } set { } }
    public virtual void Close() { }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public virtual void Fail(string message) { }
    public virtual void Fail(string message, string detailMessage) { }
    public virtual void Flush() { }
    protected internal virtual string[] GetSupportedAttributes() { return default(string[]); }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public virtual void TraceData(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id, object data) { }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public virtual void TraceData(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id, params object[] data) { }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public virtual void TraceEvent(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id) { }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public virtual void TraceEvent(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id, string message) { }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public virtual void TraceEvent(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id, string format, params object[] args) { }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public virtual void TraceTransfer(System.Diagnostics.TraceEventCache eventCache, string source, int id, string message, System.Guid relatedActivityId) { }
    public virtual void Write(object o) { }
    public virtual void Write(object o, string category) { }
    public abstract void Write(string message);
    public virtual void Write(string message, string category) { }
    protected virtual void WriteIndent() { }
    public virtual void WriteLine(object o) { }
    public virtual void WriteLine(object o, string category) { }
    public abstract void WriteLine(string message);
    public virtual void WriteLine(string message, string category) { }
  }

  public partial class TraceListenerCollection : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList {
    internal TraceListenerCollection() { }
    public int Count { get { return default(int); } }
    public System.Diagnostics.TraceListener this[int i] { get { return default(System.Diagnostics.TraceListener); } set { } }
    public System.Diagnostics.TraceListener this[string name] { get { return default(System.Diagnostics.TraceListener); } }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    bool System.Collections.IList.IsFixedSize { get { return default(bool); } }
    bool System.Collections.IList.IsReadOnly { get { return default(bool); } }
    object System.Collections.IList.this[int index] { get { return default(object); } set { } }
    public int Add(System.Diagnostics.TraceListener listener) { return default(int); }
    public void AddRange(System.Diagnostics.TraceListener[] value) { }
    public void AddRange(System.Diagnostics.TraceListenerCollection value) { }
    public void Clear() { }
    public bool Contains(System.Diagnostics.TraceListener listener) { return default(bool); }
    public void CopyTo(System.Diagnostics.TraceListener[] listeners, int index) { }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public int IndexOf(System.Diagnostics.TraceListener listener) { return default(int); }
    public void Insert(int index, System.Diagnostics.TraceListener listener) { }
    public void Remove(System.Diagnostics.TraceListener listener) { }
    public void Remove(string name) { }
    public void RemoveAt(int index) { }
    void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
    int System.Collections.IList.Add(object value) { return default(int); }
    bool System.Collections.IList.Contains(object value) { return default(bool); }
    int System.Collections.IList.IndexOf(object value) { return default(int); }
    void System.Collections.IList.Insert(int index, object value) { }
    void System.Collections.IList.Remove(object value) { }
  }

  [System.FlagsAttribute]
  public enum TraceOptions {
    Callstack = 32,
    DateTime = 2,
    LogicalOperationStack = 1,
    None = 0,
    ProcessId = 8,
    ThreadId = 16,
    Timestamp = 4,
  }

  public partial class TraceSource {
    public TraceSource(string name) { }
    public TraceSource(string name, System.Diagnostics.SourceLevels defaultLevel) { }
    public System.Collections.Specialized.StringDictionary Attributes { get { return default(System.Collections.Specialized.StringDictionary); } }
    public System.Diagnostics.TraceListenerCollection Listeners { get { return default(System.Diagnostics.TraceListenerCollection); } }
    public string Name { get { return default(string); } }
    public System.Diagnostics.SourceSwitch Switch { get { return default(System.Diagnostics.SourceSwitch); } set { } }
    public void Close() { }
    public void Flush() { }
    protected internal virtual string[] GetSupportedAttributes() { return default(string[]); }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public void TraceData(System.Diagnostics.TraceEventType eventType, int id, object data) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public void TraceData(System.Diagnostics.TraceEventType eventType, int id, params object[] data) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public void TraceEvent(System.Diagnostics.TraceEventType eventType, int id) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public void TraceEvent(System.Diagnostics.TraceEventType eventType, int id, string message) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public void TraceEvent(System.Diagnostics.TraceEventType eventType, int id, string format, params object[] args) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public void TraceInformation(string message) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public void TraceInformation(string format, params object[] args) { }
    [System.Diagnostics.ConditionalAttribute("TRACE")]
    public void TraceTransfer(int id, string message, System.Guid relatedActivityId) { }
  }

  [System.Diagnostics.SwitchLevelAttribute(typeof(System.Diagnostics.TraceLevel))]
  public partial class TraceSwitch : System.Diagnostics.Switch {
    public TraceSwitch(string displayName, string description) : base (default(string), default(string)) { }
    public TraceSwitch(string displayName, string description, string defaultSwitchValue) : base (default(string), default(string)) { }
    public System.Diagnostics.TraceLevel Level { get { return default(System.Diagnostics.TraceLevel); } set { } }
    public bool TraceError { get { return default(bool); } }
    public bool TraceInfo { get { return default(bool); } }
    public bool TraceVerbose { get { return default(bool); } }
    public bool TraceWarning { get { return default(bool); } }
    protected override void OnSwitchSettingChanged() { }
    protected override void OnValueChanged() { }
  }

} // end of System.Diagnostics
