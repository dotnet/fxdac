[assembly:System.CLSCompliant(true)]
namespace System.Resources {
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IResourceReader : System.Collections.IEnumerable, System.IDisposable
    {
        void Close();
        new System.Collections.IDictionaryEnumerator GetEnumerator();
    }


    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class ResourceReader : System.Collections.IEnumerable, System.IDisposable, System.Resources.IResourceReader
    {
        [System.Security.SecurityCriticalAttribute]
        public ResourceReader(System.IO.Stream stream) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public ResourceReader(string fileName) { }
        public void Close() { }
        public void Dispose() { }
        public System.Collections.IDictionaryEnumerator GetEnumerator() { return default(System.Collections.IDictionaryEnumerator); }
        public void GetResourceData(string resourceName, out string resourceType, out byte[] resourceData) { resourceType = default(string); resourceData = default(byte[]); }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    }

} // end of System.Resources
