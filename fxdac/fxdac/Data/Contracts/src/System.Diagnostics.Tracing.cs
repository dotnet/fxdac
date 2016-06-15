[assembly:System.CLSCompliant(true)]
namespace System.Diagnostics.Tracing {
    [System.AttributeUsageAttribute((System.AttributeTargets)(64))]
    public sealed partial class EventAttribute : System.Attribute
    {
        public EventAttribute(int eventId) { }
        public int EventId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
        public System.Diagnostics.Tracing.EventActivityOptions ActivityOptions { get { return default(System.Diagnostics.Tracing.EventActivityOptions); } set { } }
        public System.Diagnostics.Tracing.EventChannel Channel { get { return default(System.Diagnostics.Tracing.EventChannel); } set { } }
        public System.Diagnostics.Tracing.EventKeywords Keywords { get { return default(System.Diagnostics.Tracing.EventKeywords); } set { } }
        public System.Diagnostics.Tracing.EventLevel Level { get { return default(System.Diagnostics.Tracing.EventLevel); } set { } }
        public string Message { get { return default(string); } set { } }
        public System.Diagnostics.Tracing.EventOpcode Opcode { get { return default(System.Diagnostics.Tracing.EventOpcode); } set { } }
        public System.Diagnostics.Tracing.EventTags Tags { get { return default(System.Diagnostics.Tracing.EventTags); } set { } }
        public System.Diagnostics.Tracing.EventTask Task { get { return default(System.Diagnostics.Tracing.EventTask); } set { } }
        public byte Version { get { return default(byte); } set { } }
    }

    public enum EventCommand
    {
        Disable = -3,
        Enable = -2,
        SendManifest = -1,
        Update = 0,
    }

    public partial class EventCommandEventArgs : System.EventArgs
    {
        internal EventCommandEventArgs() { }
        public System.Collections.Generic.IDictionary<string, string> Arguments { get { return default(System.Collections.Generic.IDictionary<string, string>); } }
        public System.Diagnostics.Tracing.EventCommand Command { get { return default(System.Diagnostics.Tracing.EventCommand); } }
        public bool DisableEvent(int eventId) { return default(bool); }
        public bool EnableEvent(int eventId) { return default(bool); }
    }

    [System.FlagsAttribute]
    public enum EventKeywords : long
    {
        AuditFailure = (long)4503599627370496,
        AuditSuccess = (long)9007199254740992,
        CorrelationHint = (long)4503599627370496,
        EventLogClassic = (long)36028797018963968,
        None = (long)0,
        Sqm = (long)2251799813685248,
        WdiContext = (long)562949953421312,
        WdiDiagnostic = (long)1125899906842624,
    }

    public enum EventLevel
    {
        Critical = 1,
        Error = 2,
        Informational = 4,
        LogAlways = 0,
        Verbose = 5,
        Warning = 3,
    }

    public partial class EventSource : System.IDisposable
    {
        protected EventSource() { }
        protected EventSource(bool throwOnEventWriteErrors) { }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public bool IsEnabled() { return default(bool); }
        public bool IsEnabled(System.Diagnostics.Tracing.EventLevel level, System.Diagnostics.Tracing.EventKeywords keywords) { return default(bool); }
        protected virtual void OnEventCommand(System.Diagnostics.Tracing.EventCommandEventArgs command) { }
        protected void WriteEvent(int eventId, int arg1, int arg2, int arg3) { }
        protected void WriteEvent(int eventId, string arg1) { }
        protected void WriteEvent(int eventId, string arg1, int arg2) { }
        protected void WriteEvent(int eventId, string arg1, int arg2, int arg3) { }
        public event System.EventHandler<System.Diagnostics.Tracing.EventCommandEventArgs> EventCommandExecuted { add { } remove { } }
        protected EventSource(System.Diagnostics.Tracing.EventSourceSettings settings) { }
        protected EventSource(System.Diagnostics.Tracing.EventSourceSettings settings, params string[] traits) { }
        public EventSource(string eventSourceName) { }
        public EventSource(string eventSourceName, System.Diagnostics.Tracing.EventSourceSettings config) { }
        public EventSource(string eventSourceName, System.Diagnostics.Tracing.EventSourceSettings config, params string[] traits) { }
        ~EventSource() { }
        public static string GenerateManifest(System.Type eventSourceType, string assemblyPathToIncludeInManifest) { return default(string); }
        public static string GenerateManifest(System.Type eventSourceType, string assemblyPathToIncludeInManifest, System.Diagnostics.Tracing.EventManifestOptions flags) { return default(string); }
        public static System.Guid GetGuid(System.Type eventSourceType) { return default(System.Guid); }
        public static string GetName(System.Type eventSourceType) { return default(string); }
        public static System.Collections.Generic.IEnumerable<System.Diagnostics.Tracing.EventSource> GetSources() { return default(System.Collections.Generic.IEnumerable<System.Diagnostics.Tracing.EventSource>); }
        public string GetTrait(string key) { return default(string); }
        public bool IsEnabled(System.Diagnostics.Tracing.EventLevel level, System.Diagnostics.Tracing.EventKeywords keywords, System.Diagnostics.Tracing.EventChannel channel) { return default(bool); }
        public static void SendCommand(System.Diagnostics.Tracing.EventSource eventSource, System.Diagnostics.Tracing.EventCommand command, System.Collections.Generic.IDictionary<string, string> commandArguments) { }
        public static void SetCurrentThreadActivityId(System.Guid activityId) { }
        public static void SetCurrentThreadActivityId(System.Guid activityId, out System.Guid oldActivityThatWillContinue) { oldActivityThatWillContinue = default(System.Guid); }
        public override string ToString() { return default(string); }
        public void Write(string eventName) { }
        public void Write(string eventName, System.Diagnostics.Tracing.EventSourceOptions options) { }
        protected void WriteEvent(int eventId) { }
        protected void WriteEvent(int eventId, byte[] arg1) { }
        protected void WriteEvent(int eventId, int arg1) { }
        protected void WriteEvent(int eventId, int arg1, int arg2) { }
        protected void WriteEvent(int eventId, int arg1, string arg2) { }
        protected void WriteEvent(int eventId, long arg1) { }
        protected void WriteEvent(int eventId, long arg1, byte[] arg2) { }
        protected void WriteEvent(int eventId, long arg1, long arg2) { }
        protected void WriteEvent(int eventId, long arg1, long arg2, long arg3) { }
        protected void WriteEvent(int eventId, long arg1, string arg2) { }
        protected void WriteEvent(int eventId, params object[] args) { }
        protected void WriteEvent(int eventId, string arg1, long arg2) { }
        protected void WriteEvent(int eventId, string arg1, string arg2) { }
        protected void WriteEvent(int eventId, string arg1, string arg2, string arg3) { }
        [System.CLSCompliantAttribute(false)]
        protected unsafe void WriteEventCore(int eventId, int eventDataCount, System.Diagnostics.Tracing.EventSource.EventData* data) { }
        protected void WriteEventWithRelatedActivityId(int eventId, System.Guid relatedActivityId, params object[] args) { }
        [System.CLSCompliantAttribute(false)]
        protected unsafe void WriteEventWithRelatedActivityIdCore(int eventId, System.Guid* relatedActivityId, int eventDataCount, System.Diagnostics.Tracing.EventSource.EventData* data) { }
        public void Write<T>(string eventName, System.Diagnostics.Tracing.EventSourceOptions options, T data) { }
        public void Write<T>(string eventName, ref System.Diagnostics.Tracing.EventSourceOptions options, ref System.Guid activityId, ref System.Guid relatedActivityId, ref T data) { }
        public void Write<T>(string eventName, ref System.Diagnostics.Tracing.EventSourceOptions options, ref T data) { }
        public void Write<T>(string eventName, T data) { }
        public System.Exception ConstructionException { get { return default(System.Exception); } }
        public static System.Guid CurrentThreadActivityId { get { return default(System.Guid); } }
        public System.Guid Guid { get { return default(System.Guid); } }
        public string Name { get { return default(string); } }
        public System.Diagnostics.Tracing.EventSourceSettings Settings { get { return default(System.Diagnostics.Tracing.EventSourceSettings); } }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        protected internal partial struct EventData
        {
            public System.IntPtr DataPointer { get { return default(System.IntPtr); } set { } }
            public int Size { get { return default(int); } set { } }
        }
    }

    [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
    public sealed partial class EventSourceAttribute : System.Attribute
    {
        public EventSourceAttribute() { }
        public string Guid { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string LocalizationResources { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }

    [System.AttributeUsageAttribute((System.AttributeTargets)(64))]
    public sealed partial class NonEventAttribute : System.Attribute
    {
        public NonEventAttribute() { }
    }
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
    public System.Guid ActivityId { get { return default(System.Guid); } }
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
    public System.Guid RelatedActivityId { get { return default(System.Guid); } }
    public System.Diagnostics.Tracing.EventTags Tags { get { return default(System.Diagnostics.Tracing.EventTags); } }
    public System.Diagnostics.Tracing.EventTask Task { get { return default(System.Diagnostics.Tracing.EventTask); } }
    public byte Version { get { return default(byte); } }
  }
} // end of System.Diagnostics.Tracing
