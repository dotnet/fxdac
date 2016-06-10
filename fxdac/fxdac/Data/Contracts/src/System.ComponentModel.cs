[assembly:System.CLSCompliant(true)]
namespace System.ComponentModel {
    public partial class CancelEventArgs : System.EventArgs
    {
        public CancelEventArgs() { }
        public CancelEventArgs(bool cancel) { }
        public bool Cancel { get { return default(bool); } set { } }
    }

    public delegate void CancelEventHandler(object sender, System.ComponentModel.CancelEventArgs e);


    public partial interface IChangeTracking
    {
        bool IsChanged { get; }
        void AcceptChanges();
    }


    public partial interface IEditableObject
    {
        void BeginEdit();
        void CancelEdit();
        void EndEdit();
    }


    public partial interface IRevertibleChangeTracking : System.ComponentModel.IChangeTracking
    {
        void RejectChanges();
    }

} // end of System.ComponentModel
