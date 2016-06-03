[assembly:System.CLSCompliant(true)]
namespace System.Collections {
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CaseInsensitiveComparer : System.Collections.IComparer {
    public CaseInsensitiveComparer() { }
    public CaseInsensitiveComparer(System.Globalization.CultureInfo culture) { }
    public static System.Collections.CaseInsensitiveComparer Default { get { return default(System.Collections.CaseInsensitiveComparer); } }
    public static System.Collections.CaseInsensitiveComparer DefaultInvariant { get { return default(System.Collections.CaseInsensitiveComparer); } }
    public int Compare(object a, object b) { return default(int); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public abstract partial class CollectionBase : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList {
    protected CollectionBase() { }
    protected CollectionBase(int capacity) { }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public int Capacity { get { return default(int); } set { } }
    public int Count { get { return default(int); } }
    protected System.Collections.ArrayList InnerList { get { return default(System.Collections.ArrayList); } }
    protected System.Collections.IList List { get { return default(System.Collections.IList); } }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    bool System.Collections.IList.IsFixedSize { get { return default(bool); } }
    bool System.Collections.IList.IsReadOnly { get { return default(bool); } }
    object System.Collections.IList.this[int index] { get { return default(object); } set { } }
    public void Clear() { }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    protected virtual void OnClear() { }
    protected virtual void OnClearComplete() { }
    protected virtual void OnInsert(int index, object value) { }
    protected virtual void OnInsertComplete(int index, object value) { }
    protected virtual void OnRemove(int index, object value) { }
    protected virtual void OnRemoveComplete(int index, object value) { }
    protected virtual void OnSet(int index, object oldValue, object newValue) { }
    protected virtual void OnSetComplete(int index, object oldValue, object newValue) { }
    protected virtual void OnValidate(object value) { }
    public void RemoveAt(int index) { }
    void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
    int System.Collections.IList.Add(object value) { return default(int); }
    bool System.Collections.IList.Contains(object value) { return default(bool); }
    int System.Collections.IList.IndexOf(object value) { return default(int); }
    void System.Collections.IList.Insert(int index, object value) { }
    void System.Collections.IList.Remove(object value) { }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class Comparer : System.Collections.IComparer, System.Runtime.Serialization.ISerializable {
    public static readonly System.Collections.Comparer Default;
    public static readonly System.Collections.Comparer DefaultInvariant;
    public Comparer(System.Globalization.CultureInfo culture) { }
    public int Compare(object a, object b) { return default(int); }
    [System.Security.SecurityCriticalAttribute]
    public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public abstract partial class DictionaryBase : System.Collections.ICollection, System.Collections.IDictionary, System.Collections.IEnumerable {
    protected DictionaryBase() { }
    public int Count { get { return default(int); } }
    protected System.Collections.IDictionary Dictionary { get { return default(System.Collections.IDictionary); } }
    protected System.Collections.Hashtable InnerHashtable { get { return default(System.Collections.Hashtable); } }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    bool System.Collections.IDictionary.IsFixedSize { get { return default(bool); } }
    bool System.Collections.IDictionary.IsReadOnly { get { return default(bool); } }
    object System.Collections.IDictionary.this[object key] { get { return default(object); } set { } }
    System.Collections.ICollection System.Collections.IDictionary.Keys { get { return default(System.Collections.ICollection); } }
    System.Collections.ICollection System.Collections.IDictionary.Values { get { return default(System.Collections.ICollection); } }
    public void Clear() { }
    public void CopyTo(System.Array array, int index) { }
    public System.Collections.IDictionaryEnumerator GetEnumerator() { return default(System.Collections.IDictionaryEnumerator); }
    protected virtual void OnClear() { }
    protected virtual void OnClearComplete() { }
    protected virtual object OnGet(object key, object currentValue) { return default(object); }
    protected virtual void OnInsert(object key, object value) { }
    protected virtual void OnInsertComplete(object key, object value) { }
    protected virtual void OnRemove(object key, object value) { }
    protected virtual void OnRemoveComplete(object key, object value) { }
    protected virtual void OnSet(object key, object oldValue, object newValue) { }
    protected virtual void OnSetComplete(object key, object oldValue, object newValue) { }
    protected virtual void OnValidate(object key, object value) { }
    void System.Collections.IDictionary.Add(object key, object value) { }
    bool System.Collections.IDictionary.Contains(object key) { return default(bool); }
    void System.Collections.IDictionary.Remove(object key) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }

  [System.Diagnostics.DebuggerDisplayAttribute("Count = {Count}")]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class Queue : System.Collections.ICollection, System.Collections.IEnumerable, System.ICloneable {
    public Queue() { }
    public Queue(System.Collections.ICollection col) { }
    public Queue(int capacity) { }
    public Queue(int capacity, float growFactor) { }
    public virtual int Count { get { return default(int); } }
    public virtual bool IsSynchronized { get { return default(bool); } }
    public virtual object SyncRoot { get { return default(object); } }
    public virtual void Clear() { }
    public virtual object Clone() { return default(object); }
    public virtual bool Contains(object obj) { return default(bool); }
    public virtual void CopyTo(System.Array array, int index) { }
    public virtual object Dequeue() { return default(object); }
    public virtual void Enqueue(object obj) { }
    public virtual System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public virtual object Peek() { return default(object); }
    public static System.Collections.Queue Synchronized(System.Collections.Queue queue) { return default(System.Collections.Queue); }
    public virtual object[] ToArray() { return default(object[]); }
    public virtual void TrimToSize() { }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public abstract partial class ReadOnlyCollectionBase : System.Collections.ICollection, System.Collections.IEnumerable {
    protected ReadOnlyCollectionBase() { }
    public virtual int Count { get { return default(int); } }
    protected System.Collections.ArrayList InnerList { get { return default(System.Collections.ArrayList); } }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    public virtual System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
  }

  [System.Diagnostics.DebuggerDisplayAttribute("Count = {Count}")]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class SortedList : System.Collections.ICollection, System.Collections.IDictionary, System.Collections.IEnumerable, System.ICloneable {
    public SortedList() { }
    public SortedList(System.Collections.IComparer comparer) { }
    public SortedList(System.Collections.IComparer comparer, int capacity) { }
    public SortedList(System.Collections.IDictionary d) { }
    public SortedList(System.Collections.IDictionary d, System.Collections.IComparer comparer) { }
    public SortedList(int initialCapacity) { }
    public virtual int Capacity { get { return default(int); } set { } }
    public virtual int Count { get { return default(int); } }
    public virtual bool IsFixedSize { get { return default(bool); } }
    public virtual bool IsReadOnly { get { return default(bool); } }
    public virtual bool IsSynchronized { get { return default(bool); } }
    public virtual object this[object key] { get { return default(object); } set { } }
    public virtual System.Collections.ICollection Keys { get { return default(System.Collections.ICollection); } }
    public virtual object SyncRoot { get { return default(object); } }
    public virtual System.Collections.ICollection Values { get { return default(System.Collections.ICollection); } }
    public virtual void Add(object key, object value) { }
    public virtual void Clear() { }
    public virtual object Clone() { return default(object); }
    public virtual bool Contains(object key) { return default(bool); }
    public virtual bool ContainsKey(object key) { return default(bool); }
    public virtual bool ContainsValue(object value) { return default(bool); }
    public virtual void CopyTo(System.Array array, int arrayIndex) { }
    public virtual object GetByIndex(int index) { return default(object); }
    public virtual System.Collections.IDictionaryEnumerator GetEnumerator() { return default(System.Collections.IDictionaryEnumerator); }
    public virtual object GetKey(int index) { return default(object); }
    public virtual System.Collections.IList GetKeyList() { return default(System.Collections.IList); }
    public virtual System.Collections.IList GetValueList() { return default(System.Collections.IList); }
    public virtual int IndexOfKey(object key) { return default(int); }
    public virtual int IndexOfValue(object value) { return default(int); }
    public virtual void Remove(object key) { }
    public virtual void RemoveAt(int index) { }
    public virtual void SetByIndex(int index, object value) { }
    public static System.Collections.SortedList Synchronized(System.Collections.SortedList list) { return default(System.Collections.SortedList); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    public virtual void TrimToSize() { }
  }

  [System.Diagnostics.DebuggerDisplayAttribute("Count = {Count}")]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class Stack : System.Collections.ICollection, System.Collections.IEnumerable, System.ICloneable {
    public Stack() { }
    public Stack(System.Collections.ICollection col) { }
    public Stack(int initialCapacity) { }
    public virtual int Count { get { return default(int); } }
    public virtual bool IsSynchronized { get { return default(bool); } }
    public virtual object SyncRoot { get { return default(object); } }
    public virtual void Clear() { }
    public virtual object Clone() { return default(object); }
    public virtual bool Contains(object obj) { return default(bool); }
    public virtual void CopyTo(System.Array array, int index) { }
    public virtual System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public virtual object Peek() { return default(object); }
    public virtual object Pop() { return default(object); }
    public virtual void Push(object obj) { }
    public static System.Collections.Stack Synchronized(System.Collections.Stack stack) { return default(System.Collections.Stack); }
    public virtual object[] ToArray() { return default(object[]); }
  }

} // end of System.Collections
namespace System.Collections.Specialized {
  public partial class CollectionsUtil {
    public CollectionsUtil() { }
    public static System.Collections.Hashtable CreateCaseInsensitiveHashtable() { return default(System.Collections.Hashtable); }
    public static System.Collections.Hashtable CreateCaseInsensitiveHashtable(System.Collections.IDictionary d) { return default(System.Collections.Hashtable); }
    public static System.Collections.Hashtable CreateCaseInsensitiveHashtable(int capacity) { return default(System.Collections.Hashtable); }
    public static System.Collections.SortedList CreateCaseInsensitiveSortedList() { return default(System.Collections.SortedList); }
  }

} // end of System.Collections.Specialized
