[assembly:System.CLSCompliant(true)]
namespace System.ComponentModel {

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
