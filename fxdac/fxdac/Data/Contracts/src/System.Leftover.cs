[assembly:System.CLSCompliant(true)]
namespace System {

    public partial struct ArgIterator
    {
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
namespace System.Runtime.InteropServices.WindowsRuntime {
    public sealed partial class EventRegistrationTokenTable<T> where T : class
    {
        public EventRegistrationTokenTable() { }
        public T InvocationList { get { return default(T); } set { } }
        public System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken AddEventHandler(T handler) { return default(System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken); }
        public static System.Runtime.InteropServices.WindowsRuntime.EventRegistrationTokenTable<T> GetOrCreateEventRegistrationTokenTable(ref System.Runtime.InteropServices.WindowsRuntime.EventRegistrationTokenTable<T> refEventTable) { return default(System.Runtime.InteropServices.WindowsRuntime.EventRegistrationTokenTable<T>); }
        public void RemoveEventHandler(T handler) { }
        public void RemoveEventHandler(System.Runtime.InteropServices.WindowsRuntime.EventRegistrationToken token) { }
    }

} // end of System.Runtime.InteropServices.WindowsRuntime
