[assembly:System.CLSCompliant(true)]
namespace System.Net.NetworkInformation {

    public enum IPStatus
    {
        BadDestination = 11018,
        BadHeader = 11042,
        BadOption = 11007,
        BadRoute = 11012,
        DestinationHostUnreachable = 11003,
        DestinationNetworkUnreachable = 11002,
        DestinationPortUnreachable = 11005,
        DestinationProhibited = 11004,
        DestinationProtocolUnreachable = 11004,
        DestinationScopeMismatch = 11045,
        DestinationUnreachable = 11040,
        HardwareError = 11008,
        IcmpError = 11044,
        NoResources = 11006,
        PacketTooBig = 11009,
        ParameterProblem = 11015,
        SourceQuench = 11016,
        Success = 0,
        TimedOut = 11010,
        TimeExceeded = 11041,
        TtlExpired = 11013,
        TtlReassemblyTimeExceeded = 11014,
        Unknown = -1,
        UnrecognizedNextHeader = 11043,
    }

    public partial class Ping : System.ComponentModel.Component, System.IDisposable
    {
        public Ping() { }
        public event System.Net.NetworkInformation.PingCompletedEventHandler PingCompleted { add { } remove { } }
        protected void OnPingCompleted(System.Net.NetworkInformation.PingCompletedEventArgs e) { }
        public System.Net.NetworkInformation.PingReply Send(System.Net.IPAddress address) { return default(System.Net.NetworkInformation.PingReply); }
        public System.Net.NetworkInformation.PingReply Send(System.Net.IPAddress address, int timeout) { return default(System.Net.NetworkInformation.PingReply); }
        public System.Net.NetworkInformation.PingReply Send(System.Net.IPAddress address, int timeout, byte[] buffer) { return default(System.Net.NetworkInformation.PingReply); }
        public System.Net.NetworkInformation.PingReply Send(System.Net.IPAddress address, int timeout, byte[] buffer, System.Net.NetworkInformation.PingOptions options) { return default(System.Net.NetworkInformation.PingReply); }
        public System.Net.NetworkInformation.PingReply Send(string hostNameOrAddress) { return default(System.Net.NetworkInformation.PingReply); }
        public System.Net.NetworkInformation.PingReply Send(string hostNameOrAddress, int timeout) { return default(System.Net.NetworkInformation.PingReply); }
        public System.Net.NetworkInformation.PingReply Send(string hostNameOrAddress, int timeout, byte[] buffer) { return default(System.Net.NetworkInformation.PingReply); }
        public System.Net.NetworkInformation.PingReply Send(string hostNameOrAddress, int timeout, byte[] buffer, System.Net.NetworkInformation.PingOptions options) { return default(System.Net.NetworkInformation.PingReply); }
        public void SendAsync(System.Net.IPAddress address, int timeout, byte[] buffer, System.Net.NetworkInformation.PingOptions options, object userToken) { }
        public void SendAsync(System.Net.IPAddress address, int timeout, byte[] buffer, object userToken) { }
        public void SendAsync(System.Net.IPAddress address, int timeout, object userToken) { }
        public void SendAsync(System.Net.IPAddress address, object userToken) { }
        public void SendAsync(string hostNameOrAddress, int timeout, byte[] buffer, System.Net.NetworkInformation.PingOptions options, object userToken) { }
        public void SendAsync(string hostNameOrAddress, int timeout, byte[] buffer, object userToken) { }
        public void SendAsync(string hostNameOrAddress, int timeout, object userToken) { }
        public void SendAsync(string hostNameOrAddress, object userToken) { }
        public void SendAsyncCancel() { }
        public System.Threading.Tasks.Task<System.Net.NetworkInformation.PingReply> SendPingAsync(System.Net.IPAddress address) { return default(System.Threading.Tasks.Task<System.Net.NetworkInformation.PingReply>); }
        public System.Threading.Tasks.Task<System.Net.NetworkInformation.PingReply> SendPingAsync(System.Net.IPAddress address, int timeout) { return default(System.Threading.Tasks.Task<System.Net.NetworkInformation.PingReply>); }
        public System.Threading.Tasks.Task<System.Net.NetworkInformation.PingReply> SendPingAsync(System.Net.IPAddress address, int timeout, byte[] buffer) { return default(System.Threading.Tasks.Task<System.Net.NetworkInformation.PingReply>); }
        public System.Threading.Tasks.Task<System.Net.NetworkInformation.PingReply> SendPingAsync(System.Net.IPAddress address, int timeout, byte[] buffer, System.Net.NetworkInformation.PingOptions options) { return default(System.Threading.Tasks.Task<System.Net.NetworkInformation.PingReply>); }
        public System.Threading.Tasks.Task<System.Net.NetworkInformation.PingReply> SendPingAsync(string hostNameOrAddress) { return default(System.Threading.Tasks.Task<System.Net.NetworkInformation.PingReply>); }
        public System.Threading.Tasks.Task<System.Net.NetworkInformation.PingReply> SendPingAsync(string hostNameOrAddress, int timeout) { return default(System.Threading.Tasks.Task<System.Net.NetworkInformation.PingReply>); }
        public System.Threading.Tasks.Task<System.Net.NetworkInformation.PingReply> SendPingAsync(string hostNameOrAddress, int timeout, byte[] buffer) { return default(System.Threading.Tasks.Task<System.Net.NetworkInformation.PingReply>); }
        public System.Threading.Tasks.Task<System.Net.NetworkInformation.PingReply> SendPingAsync(string hostNameOrAddress, int timeout, byte[] buffer, System.Net.NetworkInformation.PingOptions options) { return default(System.Threading.Tasks.Task<System.Net.NetworkInformation.PingReply>); }
        void System.IDisposable.Dispose() { }
        protected override void Dispose(bool disposing) { }
    }


    public partial class PingCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {
        internal PingCompletedEventArgs() { }
        public System.Net.NetworkInformation.PingReply Reply { get { return default(System.Net.NetworkInformation.PingReply); } }
    }


    public delegate void PingCompletedEventHandler(object sender, System.Net.NetworkInformation.PingCompletedEventArgs e);


    public partial class PingException : System.InvalidOperationException
    {
        protected PingException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public PingException(string message) { }
        public PingException(string message, System.Exception innerException) { }
    }


    public partial class PingOptions
    {
        public PingOptions() { }
        public PingOptions(int ttl, bool dontFragment) { }
        public bool DontFragment { get { return default(bool); } set { } }
        public int Ttl { get { return default(int); } set { } }
    }


    public partial class PingReply
    {
        internal PingReply() { }
        public System.Net.IPAddress Address { get { return default(System.Net.IPAddress); } }
        public byte[] Buffer { get { return default(byte[]); } }
        public System.Net.NetworkInformation.PingOptions Options { get { return default(System.Net.NetworkInformation.PingOptions); } }
        public long RoundtripTime { get { return default(long); } }
        public System.Net.NetworkInformation.IPStatus Status { get { return default(System.Net.NetworkInformation.IPStatus); } }
    }

} // end of System.Net.NetworkInformation
