[assembly:System.CLSCompliant(true)]
namespace System {
  public partial struct ArgIterator {
    public ArgIterator(System.RuntimeArgumentHandle arglist) { throw new System.NotImplementedException(); }
    [System.CLSCompliantAttribute(false)]
    public unsafe ArgIterator(System.RuntimeArgumentHandle arglist, void* ptr) { throw new System.NotImplementedException(); }
    public void End() { }
    public override bool Equals(object o) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    [System.CLSCompliantAttribute(false)]
    public System.TypedReference GetNextArg() { return default(System.TypedReference); }
    [System.CLSCompliantAttribute(false)]
    public System.TypedReference GetNextArg(System.RuntimeTypeHandle rth) { return default(System.TypedReference); }
    public System.RuntimeTypeHandle GetNextArgType() { return default(System.RuntimeTypeHandle); }
    public int GetRemainingCount() { return default(int); }
  }

} // end of System
namespace System.Runtime.InteropServices {
  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  [System.ObsoleteAttribute("ComAwareEventInfo may be unavailable in future releases.")]
  public partial class ComAwareEventInfo : System.Reflection.EventInfo {
    public ComAwareEventInfo(System.Type type, string eventName) { }
    public override System.Reflection.EventAttributes Attributes { get { return default(System.Reflection.EventAttributes); } }
    public override System.Type DeclaringType { get { return default(System.Type); } }
    public override string Name { get { return default(string); } }
    public override void AddEventHandler(object target, System.Delegate handler) { }
    public override void RemoveEventHandler(object target, System.Delegate handler) { }
  }

} // end of System.Runtime.InteropServices
