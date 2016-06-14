[assembly:System.CLSCompliant(true)]
namespace System.Timers {
    public partial class ElapsedEventArgs : System.EventArgs
    {
        internal ElapsedEventArgs() { }
        public System.DateTime SignalTime { get { return default(System.DateTime); } }
    }

    public delegate void ElapsedEventHandler(object sender, System.Timers.ElapsedEventArgs e);

    [System.ComponentModel.DefaultEventAttribute("Elapsed")]
    [System.ComponentModel.DefaultPropertyAttribute("Interval")]
    public partial class Timer : System.ComponentModel.Component, System.ComponentModel.ISupportInitialize
    {
        public Timer() { }
        public Timer(double interval) { }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        [System.Timers.TimersDescriptionAttribute("TimerAutoReset")]
        public bool AutoReset { get { return default(bool); } set { } }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Timers.TimersDescriptionAttribute("TimerEnabled")]
        public bool Enabled { get { return default(bool); } set { } }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        [System.ComponentModel.DefaultValueAttribute(100)]
        [System.ComponentModel.SettingsBindableAttribute(true)]
        [System.Timers.TimersDescriptionAttribute("TimerInterval")]
        public double Interval { get { return default(double); } set { } }
        public override System.ComponentModel.ISite Site { get { return default(System.ComponentModel.ISite); } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.Timers.TimersDescriptionAttribute("TimerSynchronizingObject")]
        public System.ComponentModel.ISynchronizeInvoke SynchronizingObject { get { return default(System.ComponentModel.ISynchronizeInvoke); } set { } }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        [System.Timers.TimersDescriptionAttribute("TimerIntervalElapsed")]
        public event System.Timers.ElapsedEventHandler Elapsed { add { } remove { } }
        public void BeginInit() { }
        public void Close() { }
        protected override void Dispose(bool disposing) { }
        public void EndInit() { }
        public void Start() { }
        public void Stop() { }
    }

    [System.AttributeUsageAttribute((System.AttributeTargets)(32767))]
    public partial class TimersDescriptionAttribute : System.ComponentModel.DescriptionAttribute
    {
        public TimersDescriptionAttribute(string description) { }
        public override string Description { get { return default(string); } }
    }
} // end of System.Timers
