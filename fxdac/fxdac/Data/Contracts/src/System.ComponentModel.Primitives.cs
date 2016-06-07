[assembly:System.CLSCompliant(true)]
namespace System.ComponentModel {
  [System.AttributeUsageAttribute((System.AttributeTargets)(32767))]
  public sealed partial class BrowsableAttribute : System.Attribute {
    public static readonly System.ComponentModel.BrowsableAttribute Default;
    public static readonly System.ComponentModel.BrowsableAttribute No;
    public static readonly System.ComponentModel.BrowsableAttribute Yes;
    public BrowsableAttribute(bool browsable) { }
    public bool Browsable { get { return default(bool); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override bool IsDefaultAttribute() { return default(bool); }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
  public sealed partial class DefaultEventAttribute : System.Attribute {
    public static readonly System.ComponentModel.DefaultEventAttribute Default;
    public DefaultEventAttribute(string name) { }
    public string Name { get { return default(string); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }

} // end of System.ComponentModel
