[assembly:System.CLSCompliant(true)]
namespace System.Net {

    public partial class DownloadDataCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {
        internal DownloadDataCompletedEventArgs() { }
        public byte[] Result { get { return default(byte[]); } }
    }


    public delegate void DownloadDataCompletedEventHandler(object sender, System.Net.DownloadDataCompletedEventArgs e);


    public partial class DownloadProgressChangedEventArgs : System.ComponentModel.ProgressChangedEventArgs
    {
        internal DownloadProgressChangedEventArgs() : base(default(int), default(object)) { }
        public long BytesReceived { get { return default(long); } }
        public long TotalBytesToReceive { get { return default(long); } }
    }


    public delegate void DownloadProgressChangedEventHandler(object sender, System.Net.DownloadProgressChangedEventArgs e);


    public partial class DownloadStringCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {
        internal DownloadStringCompletedEventArgs() { }
        public string Result { get { return default(string); } }
    }


    public delegate void DownloadStringCompletedEventHandler(object sender, System.Net.DownloadStringCompletedEventArgs e);


    public partial class OpenReadCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {
        internal OpenReadCompletedEventArgs() { }
        public System.IO.Stream Result { get { return default(System.IO.Stream); } }
    }


    public delegate void OpenReadCompletedEventHandler(object sender, System.Net.OpenReadCompletedEventArgs e);


    public partial class OpenWriteCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {
        internal OpenWriteCompletedEventArgs() { }
        public System.IO.Stream Result { get { return default(System.IO.Stream); } }
    }


    public delegate void OpenWriteCompletedEventHandler(object sender, System.Net.OpenWriteCompletedEventArgs e);


    public partial class UploadDataCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {
        internal UploadDataCompletedEventArgs() { }
        public byte[] Result { get { return default(byte[]); } }
    }


    public delegate void UploadDataCompletedEventHandler(object sender, System.Net.UploadDataCompletedEventArgs e);


    public partial class UploadFileCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {
        internal UploadFileCompletedEventArgs() { }
        public byte[] Result { get { return default(byte[]); } }
    }


    public delegate void UploadFileCompletedEventHandler(object sender, System.Net.UploadFileCompletedEventArgs e);


    public partial class UploadProgressChangedEventArgs : System.ComponentModel.ProgressChangedEventArgs
    {
        internal UploadProgressChangedEventArgs() : base(default(int), default(object)) { }
        public long BytesReceived { get { return default(long); } }
        public long BytesSent { get { return default(long); } }
        public long TotalBytesToReceive { get { return default(long); } }
        public long TotalBytesToSend { get { return default(long); } }
    }


    public delegate void UploadProgressChangedEventHandler(object sender, System.Net.UploadProgressChangedEventArgs e);


    public partial class UploadStringCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {
        internal UploadStringCompletedEventArgs() { }
        public string Result { get { return default(string); } }
    }


    public delegate void UploadStringCompletedEventHandler(object sender, System.Net.UploadStringCompletedEventArgs e);


    public partial class UploadValuesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {
        internal UploadValuesCompletedEventArgs() { }
        public byte[] Result { get { return default(byte[]); } }
    }


    public delegate void UploadValuesCompletedEventHandler(object sender, System.Net.UploadValuesCompletedEventArgs e);


    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class WebClient : System.ComponentModel.Component
    {
        public WebClient() { }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        public bool AllowReadStreamBuffering { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        public bool AllowWriteStreamBuffering { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string BaseAddress { get { return default(string); } set { } }
        public System.Net.Cache.RequestCachePolicy CachePolicy { get { return default(System.Net.Cache.RequestCachePolicy); } set { } }
        public System.Net.ICredentials Credentials { get { return default(System.Net.ICredentials); } set { } }
        public System.Text.Encoding Encoding { get { return default(System.Text.Encoding); } set { } }
        public System.Net.WebHeaderCollection Headers { get { return default(System.Net.WebHeaderCollection); } set { } }
        public bool IsBusy { get { return default(bool); } }
        public System.Net.IWebProxy Proxy { get { return default(System.Net.IWebProxy); } set { } }
        public System.Collections.Specialized.NameValueCollection QueryString { get { return default(System.Collections.Specialized.NameValueCollection); } set { } }
        public System.Net.WebHeaderCollection ResponseHeaders { get { return default(System.Net.WebHeaderCollection); } }
        public bool UseDefaultCredentials { get { return default(bool); } set { } }
        public event System.Net.DownloadDataCompletedEventHandler DownloadDataCompleted { add { } remove { } }
        public event System.ComponentModel.AsyncCompletedEventHandler DownloadFileCompleted { add { } remove { } }
        public event System.Net.DownloadProgressChangedEventHandler DownloadProgressChanged { add { } remove { } }
        public event System.Net.DownloadStringCompletedEventHandler DownloadStringCompleted { add { } remove { } }
        public event System.Net.OpenReadCompletedEventHandler OpenReadCompleted { add { } remove { } }
        public event System.Net.OpenWriteCompletedEventHandler OpenWriteCompleted { add { } remove { } }
        public event System.Net.UploadDataCompletedEventHandler UploadDataCompleted { add { } remove { } }
        public event System.Net.UploadFileCompletedEventHandler UploadFileCompleted { add { } remove { } }
        public event System.Net.UploadProgressChangedEventHandler UploadProgressChanged { add { } remove { } }
        public event System.Net.UploadStringCompletedEventHandler UploadStringCompleted { add { } remove { } }
        public event System.Net.UploadValuesCompletedEventHandler UploadValuesCompleted { add { } remove { } }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        public event System.Net.WriteStreamClosedEventHandler WriteStreamClosed { add { } remove { } }
        public void CancelAsync() { }
        public byte[] DownloadData(string address) { return default(byte[]); }
        public byte[] DownloadData(System.Uri address) { return default(byte[]); }
        public void DownloadDataAsync(System.Uri address) { }
        public void DownloadDataAsync(System.Uri address, object userToken) { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.Threading.Tasks.Task<byte[]> DownloadDataTaskAsync(string address) { return default(System.Threading.Tasks.Task<byte[]>); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.Threading.Tasks.Task<byte[]> DownloadDataTaskAsync(System.Uri address) { return default(System.Threading.Tasks.Task<byte[]>); }
        public void DownloadFile(string address, string fileName) { }
        public void DownloadFile(System.Uri address, string fileName) { }
        public void DownloadFileAsync(System.Uri address, string fileName) { }
        public void DownloadFileAsync(System.Uri address, string fileName, object userToken) { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.Threading.Tasks.Task DownloadFileTaskAsync(string address, string fileName) { return default(System.Threading.Tasks.Task); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.Threading.Tasks.Task DownloadFileTaskAsync(System.Uri address, string fileName) { return default(System.Threading.Tasks.Task); }
        public string DownloadString(string address) { return default(string); }
        public string DownloadString(System.Uri address) { return default(string); }
        public void DownloadStringAsync(System.Uri address) { }
        public void DownloadStringAsync(System.Uri address, object userToken) { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.Threading.Tasks.Task<string> DownloadStringTaskAsync(string address) { return default(System.Threading.Tasks.Task<string>); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.Threading.Tasks.Task<string> DownloadStringTaskAsync(System.Uri address) { return default(System.Threading.Tasks.Task<string>); }
        protected virtual System.Net.WebRequest GetWebRequest(System.Uri address) { return default(System.Net.WebRequest); }
        protected virtual System.Net.WebResponse GetWebResponse(System.Net.WebRequest request) { return default(System.Net.WebResponse); }
        protected virtual System.Net.WebResponse GetWebResponse(System.Net.WebRequest request, System.IAsyncResult result) { return default(System.Net.WebResponse); }
        protected virtual void OnDownloadDataCompleted(System.Net.DownloadDataCompletedEventArgs e) { }
        protected virtual void OnDownloadFileCompleted(System.ComponentModel.AsyncCompletedEventArgs e) { }
        protected virtual void OnDownloadProgressChanged(System.Net.DownloadProgressChangedEventArgs e) { }
        protected virtual void OnDownloadStringCompleted(System.Net.DownloadStringCompletedEventArgs e) { }
        protected virtual void OnOpenReadCompleted(System.Net.OpenReadCompletedEventArgs e) { }
        protected virtual void OnOpenWriteCompleted(System.Net.OpenWriteCompletedEventArgs e) { }
        protected virtual void OnUploadDataCompleted(System.Net.UploadDataCompletedEventArgs e) { }
        protected virtual void OnUploadFileCompleted(System.Net.UploadFileCompletedEventArgs e) { }
        protected virtual void OnUploadProgressChanged(System.Net.UploadProgressChangedEventArgs e) { }
        protected virtual void OnUploadStringCompleted(System.Net.UploadStringCompletedEventArgs e) { }
        protected virtual void OnUploadValuesCompleted(System.Net.UploadValuesCompletedEventArgs e) { }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        protected virtual void OnWriteStreamClosed(System.Net.WriteStreamClosedEventArgs e) { }
        public System.IO.Stream OpenRead(string address) { return default(System.IO.Stream); }
        public System.IO.Stream OpenRead(System.Uri address) { return default(System.IO.Stream); }
        public void OpenReadAsync(System.Uri address) { }
        public void OpenReadAsync(System.Uri address, object userToken) { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.Threading.Tasks.Task<System.IO.Stream> OpenReadTaskAsync(string address) { return default(System.Threading.Tasks.Task<System.IO.Stream>); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.Threading.Tasks.Task<System.IO.Stream> OpenReadTaskAsync(System.Uri address) { return default(System.Threading.Tasks.Task<System.IO.Stream>); }
        public System.IO.Stream OpenWrite(string address) { return default(System.IO.Stream); }
        public System.IO.Stream OpenWrite(string address, string method) { return default(System.IO.Stream); }
        public System.IO.Stream OpenWrite(System.Uri address) { return default(System.IO.Stream); }
        public System.IO.Stream OpenWrite(System.Uri address, string method) { return default(System.IO.Stream); }
        public void OpenWriteAsync(System.Uri address) { }
        public void OpenWriteAsync(System.Uri address, string method) { }
        public void OpenWriteAsync(System.Uri address, string method, object userToken) { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.Threading.Tasks.Task<System.IO.Stream> OpenWriteTaskAsync(string address) { return default(System.Threading.Tasks.Task<System.IO.Stream>); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.Threading.Tasks.Task<System.IO.Stream> OpenWriteTaskAsync(string address, string method) { return default(System.Threading.Tasks.Task<System.IO.Stream>); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.Threading.Tasks.Task<System.IO.Stream> OpenWriteTaskAsync(System.Uri address) { return default(System.Threading.Tasks.Task<System.IO.Stream>); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.Threading.Tasks.Task<System.IO.Stream> OpenWriteTaskAsync(System.Uri address, string method) { return default(System.Threading.Tasks.Task<System.IO.Stream>); }
        public byte[] UploadData(string address, byte[] data) { return default(byte[]); }
        public byte[] UploadData(string address, string method, byte[] data) { return default(byte[]); }
        public byte[] UploadData(System.Uri address, byte[] data) { return default(byte[]); }
        public byte[] UploadData(System.Uri address, string method, byte[] data) { return default(byte[]); }
        public void UploadDataAsync(System.Uri address, byte[] data) { }
        public void UploadDataAsync(System.Uri address, string method, byte[] data) { }
        public void UploadDataAsync(System.Uri address, string method, byte[] data, object userToken) { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.Threading.Tasks.Task<byte[]> UploadDataTaskAsync(string address, byte[] data) { return default(System.Threading.Tasks.Task<byte[]>); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.Threading.Tasks.Task<byte[]> UploadDataTaskAsync(string address, string method, byte[] data) { return default(System.Threading.Tasks.Task<byte[]>); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.Threading.Tasks.Task<byte[]> UploadDataTaskAsync(System.Uri address, byte[] data) { return default(System.Threading.Tasks.Task<byte[]>); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.Threading.Tasks.Task<byte[]> UploadDataTaskAsync(System.Uri address, string method, byte[] data) { return default(System.Threading.Tasks.Task<byte[]>); }
        public byte[] UploadFile(string address, string fileName) { return default(byte[]); }
        public byte[] UploadFile(string address, string method, string fileName) { return default(byte[]); }
        public byte[] UploadFile(System.Uri address, string fileName) { return default(byte[]); }
        public byte[] UploadFile(System.Uri address, string method, string fileName) { return default(byte[]); }
        public void UploadFileAsync(System.Uri address, string fileName) { }
        public void UploadFileAsync(System.Uri address, string method, string fileName) { }
        public void UploadFileAsync(System.Uri address, string method, string fileName, object userToken) { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.Threading.Tasks.Task<byte[]> UploadFileTaskAsync(string address, string fileName) { return default(System.Threading.Tasks.Task<byte[]>); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.Threading.Tasks.Task<byte[]> UploadFileTaskAsync(string address, string method, string fileName) { return default(System.Threading.Tasks.Task<byte[]>); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.Threading.Tasks.Task<byte[]> UploadFileTaskAsync(System.Uri address, string fileName) { return default(System.Threading.Tasks.Task<byte[]>); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.Threading.Tasks.Task<byte[]> UploadFileTaskAsync(System.Uri address, string method, string fileName) { return default(System.Threading.Tasks.Task<byte[]>); }
        public string UploadString(string address, string data) { return default(string); }
        public string UploadString(string address, string method, string data) { return default(string); }
        public string UploadString(System.Uri address, string data) { return default(string); }
        public string UploadString(System.Uri address, string method, string data) { return default(string); }
        public void UploadStringAsync(System.Uri address, string data) { }
        public void UploadStringAsync(System.Uri address, string method, string data) { }
        public void UploadStringAsync(System.Uri address, string method, string data, object userToken) { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.Threading.Tasks.Task<string> UploadStringTaskAsync(string address, string data) { return default(System.Threading.Tasks.Task<string>); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.Threading.Tasks.Task<string> UploadStringTaskAsync(string address, string method, string data) { return default(System.Threading.Tasks.Task<string>); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.Threading.Tasks.Task<string> UploadStringTaskAsync(System.Uri address, string data) { return default(System.Threading.Tasks.Task<string>); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.Threading.Tasks.Task<string> UploadStringTaskAsync(System.Uri address, string method, string data) { return default(System.Threading.Tasks.Task<string>); }
        public byte[] UploadValues(string address, System.Collections.Specialized.NameValueCollection data) { return default(byte[]); }
        public byte[] UploadValues(string address, string method, System.Collections.Specialized.NameValueCollection data) { return default(byte[]); }
        public byte[] UploadValues(System.Uri address, System.Collections.Specialized.NameValueCollection data) { return default(byte[]); }
        public byte[] UploadValues(System.Uri address, string method, System.Collections.Specialized.NameValueCollection data) { return default(byte[]); }
        public void UploadValuesAsync(System.Uri address, System.Collections.Specialized.NameValueCollection data) { }
        public void UploadValuesAsync(System.Uri address, string method, System.Collections.Specialized.NameValueCollection data) { }
        public void UploadValuesAsync(System.Uri address, string method, System.Collections.Specialized.NameValueCollection data, object userToken) { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.Threading.Tasks.Task<byte[]> UploadValuesTaskAsync(string address, System.Collections.Specialized.NameValueCollection data) { return default(System.Threading.Tasks.Task<byte[]>); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.Threading.Tasks.Task<byte[]> UploadValuesTaskAsync(string address, string method, System.Collections.Specialized.NameValueCollection data) { return default(System.Threading.Tasks.Task<byte[]>); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.Threading.Tasks.Task<byte[]> UploadValuesTaskAsync(System.Uri address, System.Collections.Specialized.NameValueCollection data) { return default(System.Threading.Tasks.Task<byte[]>); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.Threading.Tasks.Task<byte[]> UploadValuesTaskAsync(System.Uri address, string method, System.Collections.Specialized.NameValueCollection data) { return default(System.Threading.Tasks.Task<byte[]>); }
    }


    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public partial class WriteStreamClosedEventArgs : System.EventArgs
    {
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        public WriteStreamClosedEventArgs() { }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
        public System.Exception Error { get { return default(System.Exception); } }
    }


    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public delegate void WriteStreamClosedEventHandler(object sender, System.Net.WriteStreamClosedEventArgs e);

} // end of System.Net
