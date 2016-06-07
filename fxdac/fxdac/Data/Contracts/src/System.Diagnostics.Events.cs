[assembly:System.CLSCompliant(true)]
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
