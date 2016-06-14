[assembly:System.CLSCompliant(true)]
namespace System.Net.WebSockets {
    public partial class ClientWebSocket : System.Net.WebSockets.WebSocket, System.IDisposable
    {
        public ClientWebSocket() { }
        public override System.Nullable<System.Net.WebSockets.WebSocketCloseStatus> CloseStatus { get { return default(System.Nullable<System.Net.WebSockets.WebSocketCloseStatus>); } }
        public override string CloseStatusDescription { get { return default(string); } }
        public System.Net.WebSockets.ClientWebSocketOptions Options { get { return default(System.Net.WebSockets.ClientWebSocketOptions); } }
        public override System.Net.WebSockets.WebSocketState State { get { return default(System.Net.WebSockets.WebSocketState); } }
        public override string SubProtocol { get { return default(string); } }
        public override void Abort() { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public override System.Threading.Tasks.Task CloseAsync(System.Net.WebSockets.WebSocketCloseStatus closeStatus, string statusDescription, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task); }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public override System.Threading.Tasks.Task CloseOutputAsync(System.Net.WebSockets.WebSocketCloseStatus closeStatus, string statusDescription, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task); }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task ConnectAsync(System.Uri uri, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task); }
        public override void Dispose() { }
        public override System.Threading.Tasks.Task<System.Net.WebSockets.WebSocketReceiveResult> ReceiveAsync(System.ArraySegment<byte> buffer, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<System.Net.WebSockets.WebSocketReceiveResult>); }
        public override System.Threading.Tasks.Task SendAsync(System.ArraySegment<byte> buffer, System.Net.WebSockets.WebSocketMessageType messageType, bool endOfMessage, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task); }
    }

    public sealed partial class ClientWebSocketOptions
    {
        public ClientWebSocketOptions() { }
        public System.Security.Cryptography.X509Certificates.X509CertificateCollection ClientCertificates { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Security.Cryptography.X509Certificates.X509CertificateCollection); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Net.CookieContainer Cookies { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Net.CookieContainer); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Net.ICredentials Credentials { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Net.ICredentials); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.TimeSpan KeepAliveInterval { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.TimeSpan); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Net.IWebProxy Proxy { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Net.IWebProxy); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool UseDefaultCredentials { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public void AddSubProtocol(string subProtocol) { }
        public void SetBuffer(int receiveBufferSize, int sendBufferSize) { }
        public void SetBuffer(int receiveBufferSize, int sendBufferSize, System.ArraySegment<byte> buffer) { }
        public void SetRequestHeader(string headerName, string headerValue) { }
    }
} // end of System.Net.WebSockets
