[assembly:System.CLSCompliant(true)]
namespace System.Diagnostics {
  public partial class DataReceivedEventArgs : System.EventArgs {
    internal DataReceivedEventArgs() { }
    public string Data { get { return default(string); } }
  }

  public delegate void DataReceivedEventHandler(object sender, System.Diagnostics.DataReceivedEventArgs e);

  [System.AttributeUsageAttribute((System.AttributeTargets)(32767))]
  public partial class MonitoringDescriptionAttribute : System.ComponentModel.DescriptionAttribute {
    public MonitoringDescriptionAttribute(string description) { }
    public override string Description { get { return default(string); } }
  }

  [System.ComponentModel.DefaultEventAttribute("Exited")]
  [System.ComponentModel.DefaultPropertyAttribute("StartInfo")]
  [System.ComponentModel.DesignerAttribute("System.Diagnostics.Design.ProcessDesigner, System.Design, Version=2.0.5.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [System.Diagnostics.MonitoringDescriptionAttribute("Represents a system process")]
  public partial class Process : System.ComponentModel.Component {
    public Process() { }
    [System.Diagnostics.MonitoringDescriptionAttribute("Base process priority.")]
    public int BasePriority { get { return default(int); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Diagnostics.MonitoringDescriptionAttribute("Check for exiting of the process to raise the apropriate event.")]
    public bool EnableRaisingEvents { get { return default(bool); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.Diagnostics.MonitoringDescriptionAttribute("The exit code of the process.")]
    public int ExitCode { get { return default(int); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.Diagnostics.MonitoringDescriptionAttribute("The exit time of the process.")]
    public System.DateTime ExitTime { get { return default(System.DateTime); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.Diagnostics.MonitoringDescriptionAttribute("Handle for this process.")]
    public System.IntPtr Handle { get { return default(System.IntPtr); } }
    [System.Diagnostics.MonitoringDescriptionAttribute("Handles for this process.")]
    public int HandleCount { get { return default(int); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.Diagnostics.MonitoringDescriptionAttribute("Determines if the process is still running.")]
    public bool HasExited { get { return default(bool); } }
    [System.Diagnostics.MonitoringDescriptionAttribute("Process identifier.")]
    public int Id { get { return default(int); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.Diagnostics.MonitoringDescriptionAttribute("The name of the computer running the process.")]
    public string MachineName { get { return default(string); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.Diagnostics.MonitoringDescriptionAttribute("The main module of the process.")]
    public System.Diagnostics.ProcessModule MainModule { get { return default(System.Diagnostics.ProcessModule); } }
    [System.Diagnostics.MonitoringDescriptionAttribute("The handle of the main window of the process.")]
    public System.IntPtr MainWindowHandle { get { return default(System.IntPtr); } }
    [System.Diagnostics.MonitoringDescriptionAttribute("The title of the main window of the process.")]
    public string MainWindowTitle { get { return default(string); } }
    [System.Diagnostics.MonitoringDescriptionAttribute("The maximum working set for this process.")]
    public System.IntPtr MaxWorkingSet { get { return default(System.IntPtr); } set { } }
    [System.Diagnostics.MonitoringDescriptionAttribute("The minimum working set for this process.")]
    public System.IntPtr MinWorkingSet { get { return default(System.IntPtr); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.Diagnostics.MonitoringDescriptionAttribute("The modules that are loaded as part of this process.")]
    public System.Diagnostics.ProcessModuleCollection Modules { get { return default(System.Diagnostics.ProcessModuleCollection); } }
    [System.Diagnostics.MonitoringDescriptionAttribute("The number of bytes that are not pageable.")]
    [System.ObsoleteAttribute("Use NonpagedSystemMemorySize64")]
    public int NonpagedSystemMemorySize { get { return default(int); } }
    [System.Diagnostics.MonitoringDescriptionAttribute("The number of bytes that are not pageable.")]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public long NonpagedSystemMemorySize64 { get { return default(long); } }
    [System.Diagnostics.MonitoringDescriptionAttribute("The number of bytes that are paged.")]
    [System.ObsoleteAttribute("Use PagedMemorySize64")]
    public int PagedMemorySize { get { return default(int); } }
    [System.Diagnostics.MonitoringDescriptionAttribute("The number of bytes that are paged.")]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public long PagedMemorySize64 { get { return default(long); } }
    [System.Diagnostics.MonitoringDescriptionAttribute("The amount of paged system memory in bytes.")]
    [System.ObsoleteAttribute("Use PagedSystemMemorySize64")]
    public int PagedSystemMemorySize { get { return default(int); } }
    [System.Diagnostics.MonitoringDescriptionAttribute("The amount of paged system memory in bytes.")]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public long PagedSystemMemorySize64 { get { return default(long); } }
    [System.Diagnostics.MonitoringDescriptionAttribute("The maximum amount of paged memory used by this process.")]
    [System.ObsoleteAttribute("Use PeakPagedMemorySize64")]
    public int PeakPagedMemorySize { get { return default(int); } }
    [System.Diagnostics.MonitoringDescriptionAttribute("The maximum amount of paged memory used by this process.")]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public long PeakPagedMemorySize64 { get { return default(long); } }
    [System.Diagnostics.MonitoringDescriptionAttribute("The maximum amount of virtual memory used by this process.")]
    [System.ObsoleteAttribute("Use PeakVirtualMemorySize64")]
    public int PeakVirtualMemorySize { get { return default(int); } }
    [System.Diagnostics.MonitoringDescriptionAttribute("The maximum amount of virtual memory used by this process.")]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public long PeakVirtualMemorySize64 { get { return default(long); } }
    [System.Diagnostics.MonitoringDescriptionAttribute("The maximum amount of system memory used by this process.")]
    [System.ObsoleteAttribute("Use PeakWorkingSet64")]
    public int PeakWorkingSet { get { return default(int); } }
    [System.Diagnostics.MonitoringDescriptionAttribute("The maximum amount of system memory used by this process.")]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public long PeakWorkingSet64 { get { return default(long); } }
    [System.Diagnostics.MonitoringDescriptionAttribute("Process will be of higher priority while it is actively used.")]
    public bool PriorityBoostEnabled { get { return default(bool); } set { } }
    [System.Diagnostics.MonitoringDescriptionAttribute("The relative process priority.")]
    public System.Diagnostics.ProcessPriorityClass PriorityClass { get { return default(System.Diagnostics.ProcessPriorityClass); } set { } }
    [System.Diagnostics.MonitoringDescriptionAttribute("The amount of memory exclusively used by this process.")]
    [System.ObsoleteAttribute("Use PrivateMemorySize64")]
    public int PrivateMemorySize { get { return default(int); } }
    [System.Diagnostics.MonitoringDescriptionAttribute("The amount of memory exclusively used by this process.")]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public long PrivateMemorySize64 { get { return default(long); } }
    [System.Diagnostics.MonitoringDescriptionAttribute("The amount of processing time spent in the OS core for this process.")]
    public System.TimeSpan PrivilegedProcessorTime { get { return default(System.TimeSpan); } }
    [System.Diagnostics.MonitoringDescriptionAttribute("The name of this process.")]
    public string ProcessName { get { return default(string); } }
    [System.Diagnostics.MonitoringDescriptionAttribute("Allowed processor that can be used by this process.")]
    public System.IntPtr ProcessorAffinity { get { return default(System.IntPtr); } set { } }
    [System.Diagnostics.MonitoringDescriptionAttribute("Is this process responsive.")]
    public bool Responding { get { return default(bool); } }
    [System.Diagnostics.MonitoringDescriptionAttribute("The session ID for this process.")]
    public int SessionId { get { return default(int); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.Diagnostics.MonitoringDescriptionAttribute("The standard error stream of this process.")]
    public System.IO.StreamReader StandardError { get { return default(System.IO.StreamReader); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.Diagnostics.MonitoringDescriptionAttribute("The standard input stream of this process.")]
    public System.IO.StreamWriter StandardInput { get { return default(System.IO.StreamWriter); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.Diagnostics.MonitoringDescriptionAttribute("The standard output stream of this process.")]
    public System.IO.StreamReader StandardOutput { get { return default(System.IO.StreamReader); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.Diagnostics.MonitoringDescriptionAttribute("Information for the start of this process.")]
    public System.Diagnostics.ProcessStartInfo StartInfo { get { return default(System.Diagnostics.ProcessStartInfo); } set { } }
    [System.Diagnostics.MonitoringDescriptionAttribute("The time this process started.")]
    public System.DateTime StartTime { get { return default(System.DateTime); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Diagnostics.MonitoringDescriptionAttribute("The object that is used to synchronize event handler calls for this process.")]
    public System.ComponentModel.ISynchronizeInvoke SynchronizingObject { get { return default(System.ComponentModel.ISynchronizeInvoke); } set { } }
    [System.Diagnostics.MonitoringDescriptionAttribute("The number of threads of this process.")]
    public System.Diagnostics.ProcessThreadCollection Threads { get { return default(System.Diagnostics.ProcessThreadCollection); } }
    [System.Diagnostics.MonitoringDescriptionAttribute("The total CPU time spent for this process.")]
    public System.TimeSpan TotalProcessorTime { get { return default(System.TimeSpan); } }
    [System.Diagnostics.MonitoringDescriptionAttribute("The CPU time spent for this process in user mode.")]
    public System.TimeSpan UserProcessorTime { get { return default(System.TimeSpan); } }
    [System.Diagnostics.MonitoringDescriptionAttribute("The amount of virtual memory currently used for this process.")]
    [System.ObsoleteAttribute("Use VirtualMemorySize64")]
    public int VirtualMemorySize { get { return default(int); } }
    [System.Diagnostics.MonitoringDescriptionAttribute("The amount of virtual memory currently used for this process.")]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public long VirtualMemorySize64 { get { return default(long); } }
    [System.Diagnostics.MonitoringDescriptionAttribute("The amount of physical memory currently used for this process.")]
    [System.ObsoleteAttribute("Use WorkingSet64")]
    public int WorkingSet { get { return default(int); } }
    [System.Diagnostics.MonitoringDescriptionAttribute("The amount of physical memory currently used for this process.")]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public long WorkingSet64 { get { return default(long); } }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.Diagnostics.MonitoringDescriptionAttribute("Raised when it receives error data")]
    public event System.Diagnostics.DataReceivedEventHandler ErrorDataReceived { add { } remove { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.Diagnostics.MonitoringDescriptionAttribute("Raised when this process exits.")]
    public event System.EventHandler Exited { add { } remove { } }
    [System.ComponentModel.BrowsableAttribute(true)]
    [System.Diagnostics.MonitoringDescriptionAttribute("Raised when it receives output data")]
    public event System.Diagnostics.DataReceivedEventHandler OutputDataReceived { add { } remove { } }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public void BeginErrorReadLine() { }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public void BeginOutputReadLine() { }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public void CancelErrorRead() { }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public void CancelOutputRead() { }
    public void Close() { }
    public bool CloseMainWindow() { return default(bool); }
    protected override void Dispose(bool disposing) { }
    public static void EnterDebugMode() { }
    ~Process() { }
    public static System.Diagnostics.Process GetCurrentProcess() { return default(System.Diagnostics.Process); }
    public static System.Diagnostics.Process GetProcessById(int processId) { return default(System.Diagnostics.Process); }
    public static System.Diagnostics.Process GetProcessById(int processId, string machineName) { return default(System.Diagnostics.Process); }
    public static System.Diagnostics.Process[] GetProcesses() { return default(System.Diagnostics.Process[]); }
    public static System.Diagnostics.Process[] GetProcesses(string machineName) { return default(System.Diagnostics.Process[]); }
    public static System.Diagnostics.Process[] GetProcessesByName(string processName) { return default(System.Diagnostics.Process[]); }
    public static System.Diagnostics.Process[] GetProcessesByName(string processName, string machineName) { return default(System.Diagnostics.Process[]); }
    public void Kill() { }
    public static void LeaveDebugMode() { }
    protected void OnExited() { }
    public void Refresh() { }
    public bool Start() { return default(bool); }
    public static System.Diagnostics.Process Start(System.Diagnostics.ProcessStartInfo startInfo) { return default(System.Diagnostics.Process); }
    public static System.Diagnostics.Process Start(string fileName) { return default(System.Diagnostics.Process); }
    public static System.Diagnostics.Process Start(string fileName, string arguments) { return default(System.Diagnostics.Process); }
    public static System.Diagnostics.Process Start(string fileName, string username, System.Security.SecureString password, string domain) { return default(System.Diagnostics.Process); }
    public static System.Diagnostics.Process Start(string fileName, string arguments, string username, System.Security.SecureString password, string domain) { return default(System.Diagnostics.Process); }
    public override string ToString() { return default(string); }
    public void WaitForExit() { }
    public bool WaitForExit(int milliseconds) { return default(bool); }
    public bool WaitForInputIdle() { return default(bool); }
    public bool WaitForInputIdle(int milliseconds) { return default(bool); }
  }

  [System.ComponentModel.DesignerAttribute("System.Diagnostics.Design.ProcessModuleDesigner, System.Design, Version=2.0.5.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  public partial class ProcessModule : System.ComponentModel.Component {
    internal ProcessModule() { }
    [System.Diagnostics.MonitoringDescriptionAttribute("The base memory address of this module")]
    public System.IntPtr BaseAddress { get { return default(System.IntPtr); } }
    [System.Diagnostics.MonitoringDescriptionAttribute("The base memory address of the entry point of this module")]
    public System.IntPtr EntryPointAddress { get { return default(System.IntPtr); } }
    [System.Diagnostics.MonitoringDescriptionAttribute("The file name of this module")]
    public string FileName { get { return default(string); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public System.Diagnostics.FileVersionInfo FileVersionInfo { get { return default(System.Diagnostics.FileVersionInfo); } }
    [System.Diagnostics.MonitoringDescriptionAttribute("The memory needed by this module")]
    public int ModuleMemorySize { get { return default(int); } }
    [System.Diagnostics.MonitoringDescriptionAttribute("The name of this module")]
    public string ModuleName { get { return default(string); } }
    public override string ToString() { return default(string); }
  }

  public partial class ProcessModuleCollection : System.Diagnostics.ProcessModuleCollectionBase {
    protected ProcessModuleCollection() { }
    public ProcessModuleCollection(System.Diagnostics.ProcessModule[] processModules) { }
  }

  public partial class ProcessModuleCollectionBase : System.Collections.Generic.List<System.Diagnostics.ProcessModule> {
    public ProcessModuleCollectionBase() { }
    protected System.Diagnostics.ProcessModuleCollectionBase InnerList { get { return default(System.Diagnostics.ProcessModuleCollectionBase); } }
  }

  public enum ProcessPriorityClass {
    AboveNormal = 32768,
    BelowNormal = 16384,
    High = 128,
    Idle = 64,
    Normal = 32,
    RealTime = 256,
  }

  public sealed partial class ProcessStartInfo {
    public ProcessStartInfo() { }
    public ProcessStartInfo(string filename) { }
    public ProcessStartInfo(string filename, string arguments) { }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Diagnostics.MonitoringDescriptionAttribute("Command line agruments for this process.")]
    public string Arguments { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Diagnostics.MonitoringDescriptionAttribute("Start this process with a new window.")]
    public bool CreateNoWindow { get { return default(bool); } set { } }
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    public string Domain { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.EditorAttribute("System.Diagnostics.Design.StringDictionaryEditor, System.Design, Version=2.0.5.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=2.0.5.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Diagnostics.MonitoringDescriptionAttribute("Environment variables used for this process.")]
    public System.Collections.Specialized.StringDictionary EnvironmentVariables { get { return default(System.Collections.Specialized.StringDictionary); } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Diagnostics.MonitoringDescriptionAttribute("Thread shows dialogboxes for errors.")]
    public bool ErrorDialog { get { return default(bool); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public System.IntPtr ErrorDialogParentHandle { get { return default(System.IntPtr); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute("System.Diagnostics.Design.StartFileNameEditor, System.Design, Version=2.0.5.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=2.0.5.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Diagnostics.MonitoringDescriptionAttribute("The name of the resource to start this process.")]
    public string FileName { get { return default(string); } set { } }
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    public bool LoadUserProfile { get { return default(bool); } set { } }
    public System.Security.SecureString Password { get { return default(System.Security.SecureString); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Diagnostics.MonitoringDescriptionAttribute("Errors of this process are redirected.")]
    public bool RedirectStandardError { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Diagnostics.MonitoringDescriptionAttribute("Standard input of this process is redirected.")]
    public bool RedirectStandardInput { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Diagnostics.MonitoringDescriptionAttribute("Standard output of this process is redirected.")]
    public bool RedirectStandardOutput { get { return default(bool); } set { } }
    public System.Text.Encoding StandardErrorEncoding { get { return default(System.Text.Encoding); } set { } }
    public System.Text.Encoding StandardOutputEncoding { get { return default(System.Text.Encoding); } set { } }
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    public string UserName { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Diagnostics.MonitoringDescriptionAttribute("Use the shell to start this process.")]
    public bool UseShellExecute { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Diagnostics.MonitoringDescriptionAttribute("The verb to apply to a used document.")]
    public string Verb { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public string[] Verbs { get { return default(string[]); } }
    [System.ComponentModel.DefaultValueAttribute(typeof(System.Diagnostics.ProcessWindowStyle), "Normal")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Diagnostics.MonitoringDescriptionAttribute("The window style used to start this process.")]
    public System.Diagnostics.ProcessWindowStyle WindowStyle { get { return default(System.Diagnostics.ProcessWindowStyle); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute("System.Diagnostics.Design.WorkingDirectoryEditor, System.Design, Version=2.0.5.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=2.0.5.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Diagnostics.MonitoringDescriptionAttribute("The initial directory for this process.")]
    public string WorkingDirectory { get { return default(string); } set { } }
  }

  [System.ComponentModel.DesignerAttribute("System.Diagnostics.Design.ProcessThreadDesigner, System.Design, Version=2.0.5.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  public partial class ProcessThread : System.ComponentModel.Component {
    internal ProcessThread() { }
    [System.Diagnostics.MonitoringDescriptionAttribute("The base priority of this thread.")]
    public int BasePriority { get { return default(int); } }
    [System.Diagnostics.MonitoringDescriptionAttribute("The current priority of this thread.")]
    public int CurrentPriority { get { return default(int); } }
    [System.Diagnostics.MonitoringDescriptionAttribute("The ID of this thread.")]
    public int Id { get { return default(int); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public int IdealProcessor { set { } }
    [System.Diagnostics.MonitoringDescriptionAttribute("Thread gets a priority boot when interactively used by a user.")]
    public bool PriorityBoostEnabled { get { return default(bool); } set { } }
    [System.Diagnostics.MonitoringDescriptionAttribute("The priority level of this thread.")]
    public System.Diagnostics.ThreadPriorityLevel PriorityLevel { get { return default(System.Diagnostics.ThreadPriorityLevel); } set { } }
    [System.Diagnostics.MonitoringDescriptionAttribute("The amount of CPU time used in privileged mode.")]
    public System.TimeSpan PrivilegedProcessorTime { get { return default(System.TimeSpan); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public System.IntPtr ProcessorAffinity { set { } }
    [System.Diagnostics.MonitoringDescriptionAttribute("The start address in memory of this thread.")]
    public System.IntPtr StartAddress { get { return default(System.IntPtr); } }
    [System.Diagnostics.MonitoringDescriptionAttribute("The time this thread was started.")]
    public System.DateTime StartTime { get { return default(System.DateTime); } }
    [System.Diagnostics.MonitoringDescriptionAttribute("The current state of this thread.")]
    public System.Diagnostics.ThreadState ThreadState { get { return default(System.Diagnostics.ThreadState); } }
    [System.Diagnostics.MonitoringDescriptionAttribute("The total amount of CPU time used.")]
    public System.TimeSpan TotalProcessorTime { get { return default(System.TimeSpan); } }
    [System.Diagnostics.MonitoringDescriptionAttribute("The amount of CPU time used in user mode.")]
    public System.TimeSpan UserProcessorTime { get { return default(System.TimeSpan); } }
    [System.Diagnostics.MonitoringDescriptionAttribute("The reason why this thread is waiting.")]
    public System.Diagnostics.ThreadWaitReason WaitReason { get { return default(System.Diagnostics.ThreadWaitReason); } }
    public void ResetIdealProcessor() { }
  }

  public partial class ProcessThreadCollection : System.Diagnostics.ProcessThreadCollectionBase {
    protected ProcessThreadCollection() { }
    public ProcessThreadCollection(System.Diagnostics.ProcessThread[] processThreads) { }
  }

  public partial class ProcessThreadCollectionBase : System.Collections.Generic.List<System.Diagnostics.ProcessThread> {
    public ProcessThreadCollectionBase() { }
    protected System.Diagnostics.ProcessThreadCollectionBase InnerList { get { return default(System.Diagnostics.ProcessThreadCollectionBase); } }
    public new int Add(System.Diagnostics.ProcessThread thread) { return default(int); }
  }

  public enum ProcessWindowStyle {
    Hidden = 1,
    Maximized = 3,
    Minimized = 2,
    Normal = 0,
  }

  public enum ThreadPriorityLevel {
    AboveNormal = 1,
    BelowNormal = -1,
    Highest = 2,
    Idle = -15,
    Lowest = -2,
    Normal = 0,
    TimeCritical = 15,
  }

  public enum ThreadState {
    Initialized = 0,
    Ready = 1,
    Running = 2,
    Standby = 3,
    Terminated = 4,
    Transition = 6,
    Unknown = 7,
    Wait = 5,
  }

  public enum ThreadWaitReason {
    EventPairHigh = 7,
    EventPairLow = 8,
    ExecutionDelay = 4,
    Executive = 0,
    FreePage = 1,
    LpcReceive = 9,
    LpcReply = 10,
    PageIn = 2,
    PageOut = 12,
    Suspended = 5,
    SystemAllocation = 3,
    Unknown = 13,
    UserRequest = 6,
    VirtualMemory = 11,
  }

} // end of System.Diagnostics
