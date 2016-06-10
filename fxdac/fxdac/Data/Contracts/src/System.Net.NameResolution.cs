[assembly:System.CLSCompliant(true)]
namespace System.Net {

    public static partial class Dns
    {
        public static System.IAsyncResult BeginGetHostAddresses(string hostNameOrAddress, System.AsyncCallback requestCallback, object state) { return default(System.IAsyncResult); }
        [System.ObsoleteAttribute("Use BeginGetHostEntry instead")]
        public static System.IAsyncResult BeginGetHostByName(string hostName, System.AsyncCallback requestCallback, object stateObject) { return default(System.IAsyncResult); }
        public static System.IAsyncResult BeginGetHostEntry(System.Net.IPAddress address, System.AsyncCallback requestCallback, object stateObject) { return default(System.IAsyncResult); }
        public static System.IAsyncResult BeginGetHostEntry(string hostNameOrAddress, System.AsyncCallback requestCallback, object stateObject) { return default(System.IAsyncResult); }
        [System.ObsoleteAttribute("Use BeginGetHostEntry instead")]
        public static System.IAsyncResult BeginResolve(string hostName, System.AsyncCallback requestCallback, object stateObject) { return default(System.IAsyncResult); }
        public static System.Net.IPAddress[] EndGetHostAddresses(System.IAsyncResult asyncResult) { return default(System.Net.IPAddress[]); }
        [System.ObsoleteAttribute("Use EndGetHostEntry instead")]
        public static System.Net.IPHostEntry EndGetHostByName(System.IAsyncResult asyncResult) { return default(System.Net.IPHostEntry); }
        public static System.Net.IPHostEntry EndGetHostEntry(System.IAsyncResult asyncResult) { return default(System.Net.IPHostEntry); }
        [System.ObsoleteAttribute("Use EndGetHostEntry instead")]
        public static System.Net.IPHostEntry EndResolve(System.IAsyncResult asyncResult) { return default(System.Net.IPHostEntry); }
        public static System.Net.IPAddress[] GetHostAddresses(string hostNameOrAddress) { return default(System.Net.IPAddress[]); }
        public static System.Threading.Tasks.Task<System.Net.IPAddress[]> GetHostAddressesAsync(string hostNameOrAddress) { return default(System.Threading.Tasks.Task<System.Net.IPAddress[]>); }
        [System.ObsoleteAttribute("Use GetHostEntry instead")]
        public static System.Net.IPHostEntry GetHostByAddress(System.Net.IPAddress address) { return default(System.Net.IPHostEntry); }
        [System.ObsoleteAttribute("Use GetHostEntry instead")]
        public static System.Net.IPHostEntry GetHostByAddress(string address) { return default(System.Net.IPHostEntry); }
        [System.ObsoleteAttribute("Use GetHostEntry instead")]
        public static System.Net.IPHostEntry GetHostByName(string hostName) { return default(System.Net.IPHostEntry); }
        public static System.Net.IPHostEntry GetHostEntry(System.Net.IPAddress address) { return default(System.Net.IPHostEntry); }
        public static System.Net.IPHostEntry GetHostEntry(string hostNameOrAddress) { return default(System.Net.IPHostEntry); }
        public static System.Threading.Tasks.Task<System.Net.IPHostEntry> GetHostEntryAsync(System.Net.IPAddress address) { return default(System.Threading.Tasks.Task<System.Net.IPHostEntry>); }
        public static System.Threading.Tasks.Task<System.Net.IPHostEntry> GetHostEntryAsync(string hostNameOrAddress) { return default(System.Threading.Tasks.Task<System.Net.IPHostEntry>); }
        public static string GetHostName() { return default(string); }
        [System.ObsoleteAttribute("Use GetHostEntry instead")]
        public static System.Net.IPHostEntry Resolve(string hostName) { return default(System.Net.IPHostEntry); }
    }


    public partial class IPHostEntry
    {
        public IPHostEntry() { }
        public System.Net.IPAddress[] AddressList { get { return default(System.Net.IPAddress[]); } set { } }
        public string[] Aliases { get { return default(string[]); } set { } }
        public string HostName { get { return default(string); } set { } }
    }

} // end of System.Net
