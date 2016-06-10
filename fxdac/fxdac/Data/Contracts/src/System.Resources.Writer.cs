[assembly:System.CLSCompliant(true)]
namespace System.Resources {

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IResourceWriter : System.IDisposable
    {
        void AddResource(string name, byte[] value);
        void AddResource(string name, object value);
        void AddResource(string name, string value);
        void Close();
        void Generate();
    }


    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class ResourceWriter : System.IDisposable, System.Resources.IResourceWriter
    {
        public ResourceWriter(System.IO.Stream stream) { }
        public ResourceWriter(string fileName) { }
        public System.Func<System.Type, string> TypeNameConverter { get { return default(System.Func<System.Type, string>); } set { } }
        public void AddResource(string name, byte[] value) { }
        public void AddResource(string name, System.IO.Stream value) { }
        public void AddResource(string name, System.IO.Stream value, bool closeAfterWrite) { }
        public void AddResource(string name, object value) { }
        public void AddResource(string name, string value) { }
        public void AddResourceData(string name, string typeName, byte[] serializedData) { }
        public void Close() { }
        public void Dispose() { }
        [System.Security.SecuritySafeCriticalAttribute]
        public void Generate() { }
    }

} // end of System.Resources
