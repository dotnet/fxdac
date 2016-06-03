[assembly:System.CLSCompliant(true)]
namespace System.CodeDom.Compiler {
  [System.AttributeUsageAttribute((System.AttributeTargets)(32767), Inherited=false, AllowMultiple=false)]
  public sealed partial class GeneratedCodeAttribute : System.Attribute {
    public GeneratedCodeAttribute(string tool, string version) { }
    public string Tool { get { return default(string); } }
    public string Version { get { return default(string); } }
  }

} // end of System.CodeDom.Compiler
