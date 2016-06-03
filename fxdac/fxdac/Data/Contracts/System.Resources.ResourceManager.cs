[assembly:System.CLSCompliant(true)]
namespace System.Resources {
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class MissingManifestResourceException : System.SystemException {
    public MissingManifestResourceException() { }
    protected MissingManifestResourceException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public MissingManifestResourceException(string message) { }
    public MissingManifestResourceException(string message, System.Exception inner) { }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class MissingSatelliteAssemblyException : System.SystemException {
    public MissingSatelliteAssemblyException() { }
    protected MissingSatelliteAssemblyException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public MissingSatelliteAssemblyException(string message) { }
    public MissingSatelliteAssemblyException(string message, System.Exception inner) { }
    public MissingSatelliteAssemblyException(string message, string cultureName) { }
    public string CultureName { get { return default(string); } }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(1), AllowMultiple=false)]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class NeutralResourcesLanguageAttribute : System.Attribute {
    public NeutralResourcesLanguageAttribute(string cultureName) { }
    public NeutralResourcesLanguageAttribute(string cultureName, System.Resources.UltimateResourceFallbackLocation location) { }
    public string CultureName { get { return default(string); } }
    public System.Resources.UltimateResourceFallbackLocation Location { get { return default(System.Resources.UltimateResourceFallbackLocation); } }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class ResourceManager {
    protected string BaseNameField;
    public static readonly int HeaderVersionNumber;
    public static readonly int MagicNumber;
    protected System.Reflection.Assembly MainAssembly;
    [System.ObsoleteAttribute("call InternalGetResourceSet instead")]
    protected System.Collections.Hashtable ResourceSets;
    protected ResourceManager() { }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public ResourceManager(string baseName, System.Reflection.Assembly assembly) { }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public ResourceManager(string baseName, System.Reflection.Assembly assembly, System.Type usingResourceSet) { }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]public ResourceManager(System.Type resourceSource) { }
    public virtual string BaseName { get { return default(string); } }
    protected System.Resources.UltimateResourceFallbackLocation FallbackLocation { get { return default(System.Resources.UltimateResourceFallbackLocation); } set { } }
    public virtual bool IgnoreCase { get { return default(bool); } set { } }
    public virtual System.Type ResourceSetType { get { return default(System.Type); } }
    public static System.Resources.ResourceManager CreateFileBasedResourceManager(string baseName, string resourceDir, System.Type usingResourceSet) { return default(System.Resources.ResourceManager); }
    [System.Security.SecuritySafeCriticalAttribute]
    protected static System.Globalization.CultureInfo GetNeutralResourcesLanguage(System.Reflection.Assembly a) { return default(System.Globalization.CultureInfo); }
    public virtual object GetObject(string name) { return default(object); }
    public virtual object GetObject(string name, System.Globalization.CultureInfo culture) { return default(object); }
    protected virtual string GetResourceFileName(System.Globalization.CultureInfo culture) { return default(string); }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)][System.Security.SecuritySafeCriticalAttribute]
    public virtual System.Resources.ResourceSet GetResourceSet(System.Globalization.CultureInfo culture, bool createIfNotExists, bool tryParents) { return default(System.Resources.ResourceSet); }
    protected static System.Version GetSatelliteContractVersion(System.Reflection.Assembly a) { return default(System.Version); }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public System.IO.UnmanagedMemoryStream GetStream(string name) { return default(System.IO.UnmanagedMemoryStream); }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public System.IO.UnmanagedMemoryStream GetStream(string name, System.Globalization.CultureInfo culture) { return default(System.IO.UnmanagedMemoryStream); }
    public virtual string GetString(string name) { return default(string); }
    public virtual string GetString(string name, System.Globalization.CultureInfo culture) { return default(string); }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)][System.Security.SecuritySafeCriticalAttribute]
    protected virtual System.Resources.ResourceSet InternalGetResourceSet(System.Globalization.CultureInfo culture, bool createIfNotExists, bool tryParents) { return default(System.Resources.ResourceSet); }
    public virtual void ReleaseAllResources() { }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class ResourceSet : System.Collections.IEnumerable, System.IDisposable {
    protected System.Resources.IResourceReader Reader;
    protected System.Collections.Hashtable Table;
    protected ResourceSet() { }
    [System.Security.SecurityCriticalAttribute]
    public ResourceSet(System.IO.Stream stream) { }
    public ResourceSet(System.Resources.IResourceReader reader) { }
    public ResourceSet(string fileName) { }
    public virtual void Close() { }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public virtual System.Type GetDefaultReader() { return default(System.Type); }
    public virtual System.Type GetDefaultWriter() { return default(System.Type); }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public virtual System.Collections.IDictionaryEnumerator GetEnumerator() { return default(System.Collections.IDictionaryEnumerator); }
    public virtual object GetObject(string name) { return default(object); }
    public virtual object GetObject(string name, bool ignoreCase) { return default(object); }
    public virtual string GetString(string name) { return default(string); }
    public virtual string GetString(string name, bool ignoreCase) { return default(string); }
    protected virtual void ReadResources() { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(1), AllowMultiple=false)]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class SatelliteContractVersionAttribute : System.Attribute {
    public SatelliteContractVersionAttribute(string version) { }
    public string Version { get { return default(string); } }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public enum UltimateResourceFallbackLocation {
    MainAssembly = 0,
    Satellite = 1,
  }

} // end of System.Resources
