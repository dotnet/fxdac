[assembly:System.CLSCompliant(true)]
namespace System.Net.WebSockets {

    public partial class HttpListenerWebSocketContext : System.Net.WebSockets.WebSocketContext
    {
        public HttpListenerWebSocketContext() { }
        public override System.Net.CookieCollection CookieCollection { get { return default(System.Net.CookieCollection); } }
        public override System.Collections.Specialized.NameValueCollection Headers { get { return default(System.Collections.Specialized.NameValueCollection); } }
        public override bool IsAuthenticated { get { return default(bool); } }
        public override bool IsLocal { get { return default(bool); } }
        public override bool IsSecureConnection { get { return default(bool); } }
        public override string Origin { get { return default(string); } }
        public override System.Uri RequestUri { get { return default(System.Uri); } }
        public override string SecWebSocketKey { get { return default(string); } }
        public override System.Collections.Generic.IEnumerable<string> SecWebSocketProtocols { get { return default(System.Collections.Generic.IEnumerable<string>); } }
        public override string SecWebSocketVersion { get { return default(string); } }
        public override System.Security.Principal.IPrincipal User { get { return default(System.Security.Principal.IPrincipal); } }
        public override System.Net.WebSockets.WebSocket WebSocket { get { return default(System.Net.WebSockets.WebSocket); } }
    }

    public abstract partial class WebSocket : System.IDisposable
    {
        protected WebSocket() { }
        public abstract System.Nullable<System.Net.WebSockets.WebSocketCloseStatus> CloseStatus { get; }
        public abstract string CloseStatusDescription { get; }
        public static System.TimeSpan DefaultKeepAliveInterval { get { return default(System.TimeSpan); } }
        public abstract System.Net.WebSockets.WebSocketState State { get; }
        public abstract string SubProtocol { get; }
        public abstract void Abort();
        public abstract System.Threading.Tasks.Task CloseAsync(System.Net.WebSockets.WebSocketCloseStatus closeStatus, string statusDescription, System.Threading.CancellationToken cancellationToken);
        public abstract System.Threading.Tasks.Task CloseOutputAsync(System.Net.WebSockets.WebSocketCloseStatus closeStatus, string statusDescription, System.Threading.CancellationToken cancellationToken);
        public static System.ArraySegment<byte> CreateClientBuffer(int receiveBufferSize, int sendBufferSize) { return default(System.ArraySegment<byte>); }
        public static System.Net.WebSockets.WebSocket CreateClientWebSocket(System.IO.Stream innerStream, string subProtocol, int receiveBufferSize, int sendBufferSize, System.TimeSpan keepAliveInterval, bool useZeroMaskingKey, System.ArraySegment<byte> internalBuffer) { return default(System.Net.WebSockets.WebSocket); }
        public static System.ArraySegment<byte> CreateServerBuffer(int receiveBufferSize) { return default(System.ArraySegment<byte>); }
        public abstract void Dispose();
        [System.ObsoleteAttribute]
        public static bool IsApplicationTargeting45() { return default(bool); }
        protected static bool IsStateTerminal(System.Net.WebSockets.WebSocketState state) { return default(bool); }
        public abstract System.Threading.Tasks.Task<System.Net.WebSockets.WebSocketReceiveResult> ReceiveAsync(System.ArraySegment<byte> buffer, System.Threading.CancellationToken cancellationToken);
        public static void RegisterPrefixes() { }
        public abstract System.Threading.Tasks.Task SendAsync(System.ArraySegment<byte> buffer, System.Net.WebSockets.WebSocketMessageType messageType, bool endOfMessage, System.Threading.CancellationToken cancellationToken);
        protected static void ThrowOnInvalidState(System.Net.WebSockets.WebSocketState state, params System.Net.WebSockets.WebSocketState[] validStates) { }
    }

    public enum WebSocketCloseStatus
    {
        Empty = 1004,
        EndpointUnavailable = 1001,
        InternalServerError = 1011,
        InvalidMessageType = 1003,
        InvalidPayloadData = 1007,
        MandatoryExtension = 1010,
        MessageTooBig = 1004,
        NormalClosure = 1000,
        PolicyViolation = 1008,
        ProtocolError = 1002,
    }

    public abstract partial class WebSocketContext
    {
        protected WebSocketContext() { }
        public abstract System.Net.CookieCollection CookieCollection { get; }
        public abstract System.Collections.Specialized.NameValueCollection Headers { get; }
        public abstract bool IsAuthenticated { get; }
        public abstract bool IsLocal { get; }
        public abstract bool IsSecureConnection { get; }
        public abstract string Origin { get; }
        public abstract System.Uri RequestUri { get; }
        public abstract string SecWebSocketKey { get; }
        public abstract System.Collections.Generic.IEnumerable<string> SecWebSocketProtocols { get; }
        public abstract string SecWebSocketVersion { get; }
        public abstract System.Security.Principal.IPrincipal User { get; }
        public abstract System.Net.WebSockets.WebSocket WebSocket { get; }
    }

    public enum WebSocketError
    {
        ConnectionClosedPrematurely = 8,
        Faulted = 2,
        HeaderError = 7,
        InvalidMessageType = 1,
        InvalidState = 9,
        NativeError = 3,
        NotAWebSocket = 4,
        Success = 0,
        UnsupportedProtocol = 6,
        UnsupportedVersion = 5,
    }

    public sealed partial class WebSocketException : System.ComponentModel.Win32Exception
    {
        public WebSocketException() { }
        public WebSocketException(int nativeError) { }
        public WebSocketException(int nativeError, System.Exception innerException) { }
        public WebSocketException(int nativeError, string message) { }
        public WebSocketException(System.Net.WebSockets.WebSocketError error) { }
        public WebSocketException(System.Net.WebSockets.WebSocketError error, System.Exception innerException) { }
        public WebSocketException(System.Net.WebSockets.WebSocketError error, int nativeError) { }
        public WebSocketException(System.Net.WebSockets.WebSocketError error, int nativeError, System.Exception innerException) { }
        public WebSocketException(System.Net.WebSockets.WebSocketError error, int nativeError, string message) { }
        public WebSocketException(System.Net.WebSockets.WebSocketError error, int nativeError, string message, System.Exception innerException) { }
        public WebSocketException(System.Net.WebSockets.WebSocketError error, string message) { }
        public WebSocketException(System.Net.WebSockets.WebSocketError error, string message, System.Exception innerException) { }
        public WebSocketException(string message) { }
        public WebSocketException(string message, System.Exception innerException) { }
        public System.Net.WebSockets.WebSocketError WebSocketErrorCode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Net.WebSockets.WebSocketError); } }
        public override int ErrorCode { get { return default(int); } }
    }

    public enum WebSocketMessageType
    {
        Binary = 1,
        Close = 2,
        Text = 0,
    }

    public partial class WebSocketReceiveResult
    {
        public WebSocketReceiveResult(int count, System.Net.WebSockets.WebSocketMessageType messageType, bool endOfMessage) { }
        public WebSocketReceiveResult(int count, System.Net.WebSockets.WebSocketMessageType messageType, bool endOfMessage, System.Nullable<System.Net.WebSockets.WebSocketCloseStatus> closeStatus, string closeStatusDescription) { }
        public System.Nullable<System.Net.WebSockets.WebSocketCloseStatus> CloseStatus { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<System.Net.WebSockets.WebSocketCloseStatus>); } }
        public string CloseStatusDescription { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
        public int Count { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
        public bool EndOfMessage { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
        public System.Net.WebSockets.WebSocketMessageType MessageType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Net.WebSockets.WebSocketMessageType); } }
    }

    public enum WebSocketState
    {
        Aborted = 6,
        Closed = 5,
        CloseReceived = 4,
        CloseSent = 3,
        Connecting = 1,
        None = 0,
        Open = 2,
    }
} // end of System.Net.WebSockets
