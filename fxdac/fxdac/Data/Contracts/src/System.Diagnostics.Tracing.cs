[assembly:System.CLSCompliant(true)]
namespace System.Diagnostics.Tracing {
  [System.AttributeUsageAttribute((System.AttributeTargets)(64))]
  public sealed partial class EventAttribute : System.Attribute {
    public EventAttribute(int eventId) { }
    public int EventId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
  }

  public enum EventCommand {
    Disable = -3,
    Enable = -2,
    SendManifest = -1,
    Update = 0,
  }

  public partial class EventCommandEventArgs : System.EventArgs {
    internal EventCommandEventArgs() { }
    public System.Collections.Generic.IDictionary<string, string> Arguments { get { return default(System.Collections.Generic.IDictionary<string, string>); } }
    public System.Diagnostics.Tracing.EventCommand Command { get { return default(System.Diagnostics.Tracing.EventCommand); } }
    public bool DisableEvent(int eventId) { return default(bool); }
    public bool EnableEvent(int eventId) { return default(bool); }
  }

  [System.FlagsAttribute]
  public enum EventKeywords : long {
    AuditFailure = (long)4503599627370496,
    AuditSuccess = (long)9007199254740992,
    CorrelationHint = (long)4503599627370496,
    EventLogClassic = (long)36028797018963968,
    None = (long)0,
    Sqm = (long)2251799813685248,
    WdiContext = (long)562949953421312,
    WdiDiagnostic = (long)1125899906842624,
  }

  public enum EventLevel {
    Critical = 1,
    Error = 2,
    Informational = 4,
    LogAlways = 0,
    Verbose = 5,
    Warning = 3,
  }

  public partial class EventSource : System.IDisposable {
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
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
  public sealed partial class EventSourceAttribute : System.Attribute {
    public EventSourceAttribute() { }
    public string Guid { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string LocalizationResources { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(64))]
  public sealed partial class NonEventAttribute : System.Attribute {
    public NonEventAttribute() { }
  }

} // end of System.Diagnostics.Tracing
