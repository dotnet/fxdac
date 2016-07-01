[assembly:System.CLSCompliant(true)]
namespace System.Collections {
    public sealed partial class BitArray : System.Collections.ICollection, System.Collections.IEnumerable, System.ICloneable
    {
        public BitArray(bool[] values) { }
        public BitArray(byte[] bytes) { }
        public BitArray(System.Collections.BitArray bits) { }
        public BitArray(int length) { }
        public BitArray(int length, bool defaultValue) { }
        public BitArray(int[] values) { }
        public int Count { get { return default(int); } }
        public bool IsReadOnly { get { return default(bool); } }
        public bool IsSynchronized { get { return default(bool); } }
        public bool this[int index] { get { return default(bool); } set { } }
        public int Length { get { return default(int); } set { } }
        public object SyncRoot { get { return default(object); } }
        public System.Collections.BitArray And(System.Collections.BitArray value) { return default(System.Collections.BitArray); }
        public object Clone() { return default(object); }
        public void CopyTo(System.Array array, int index) { }
        public bool Get(int index) { return default(bool); }
        public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
        public System.Collections.BitArray Not() { return default(System.Collections.BitArray); }
        public System.Collections.BitArray Or(System.Collections.BitArray value) { return default(System.Collections.BitArray); }
        public void Set(int index, bool value) { }
        public void SetAll(bool value) { }
        public System.Collections.BitArray Xor(System.Collections.BitArray value) { return default(System.Collections.BitArray); }
        void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
        int System.Collections.ICollection.Count { get { return default(int); } }
        bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
        object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    }

    public static partial class StructuralComparisons
    {
        public static System.Collections.IComparer StructuralComparer { get { return default(System.Collections.IComparer); } }
        public static System.Collections.IEqualityComparer StructuralEqualityComparer { get { return default(System.Collections.IEqualityComparer); } }
    }
} // end of System.Collections
namespace System.Collections.Generic {
    public partial class LinkedList<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.ICollection, System.Collections.IEnumerable, System.Runtime.Serialization.IDeserializationCallback, System.Runtime.Serialization.ISerializable
    {
        public LinkedList() { }
        public LinkedList(System.Collections.Generic.IEnumerable<T> collection) { }
        protected LinkedList(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public int Count { get { return default(int); } }
        public System.Collections.Generic.LinkedListNode<T> First { get { return default(System.Collections.Generic.LinkedListNode<T>); } }
        public System.Collections.Generic.LinkedListNode<T> Last { get { return default(System.Collections.Generic.LinkedListNode<T>); } }
        bool System.Collections.Generic.ICollection<T>.IsReadOnly { get { return default(bool); } }
        bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
        object System.Collections.ICollection.SyncRoot { get { return default(object); } }
        public System.Collections.Generic.LinkedListNode<T> AddAfter(System.Collections.Generic.LinkedListNode<T> node, T value) { return default(System.Collections.Generic.LinkedListNode<T>); }
        public void AddAfter(System.Collections.Generic.LinkedListNode<T> node, System.Collections.Generic.LinkedListNode<T> newNode) { }
        public System.Collections.Generic.LinkedListNode<T> AddBefore(System.Collections.Generic.LinkedListNode<T> node, T value) { return default(System.Collections.Generic.LinkedListNode<T>); }
        public void AddBefore(System.Collections.Generic.LinkedListNode<T> node, System.Collections.Generic.LinkedListNode<T> newNode) { }
        public System.Collections.Generic.LinkedListNode<T> AddFirst(T value) { return default(System.Collections.Generic.LinkedListNode<T>); }
        public void AddFirst(System.Collections.Generic.LinkedListNode<T> node) { }
        public System.Collections.Generic.LinkedListNode<T> AddLast(T value) { return default(System.Collections.Generic.LinkedListNode<T>); }
        public void AddLast(System.Collections.Generic.LinkedListNode<T> node) { }
        public void Clear() { }
        public bool Contains(T value) { return default(bool); }
        public void CopyTo(T[] array, int index) { }
        public System.Collections.Generic.LinkedListNode<T> Find(T value) { return default(System.Collections.Generic.LinkedListNode<T>); }
        public System.Collections.Generic.LinkedListNode<T> FindLast(T value) { return default(System.Collections.Generic.LinkedListNode<T>); }
        public System.Collections.Generic.LinkedList<T>.Enumerator GetEnumerator() { return default(System.Collections.Generic.LinkedList<T>.Enumerator); }
        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public virtual void OnDeserialization(object sender) { }
        public bool Remove(T value) { return default(bool); }
        public void Remove(System.Collections.Generic.LinkedListNode<T> node) { }
        public void RemoveFirst() { }
        public void RemoveLast() { }
        void System.Collections.Generic.ICollection<T>.Add(T value) { }
        System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { return default(System.Collections.Generic.IEnumerator<T>); }
        void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public partial struct Enumerator : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable, System.Runtime.Serialization.IDeserializationCallback, System.Runtime.Serialization.ISerializable
        {
            public T Current { get { return default(T); } }
            object System.Collections.IEnumerator.Current { get { return default(object); } }
            public void Dispose() { }
            public bool MoveNext() { return default(bool); }
            void System.Collections.IEnumerator.Reset() { }
            void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }
            void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        }
    }
    public sealed partial class LinkedListNode<T>
    {
        public LinkedListNode(T value) { }
        public System.Collections.Generic.LinkedList<T> List { get { return default(System.Collections.Generic.LinkedList<T>); } }
        public System.Collections.Generic.LinkedListNode<T> Next { get { return default(System.Collections.Generic.LinkedListNode<T>); } }
        public System.Collections.Generic.LinkedListNode<T> Previous { get { return default(System.Collections.Generic.LinkedListNode<T>); } }
        public T Value { get { return default(T); } set { } }
    }
    public partial class SortedDictionary<TKey, TValue> : 
        System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, 
        System.Collections.Generic.IDictionary<TKey, TValue>, 
        System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>,
        System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>,
        System.Collections.ICollection, System.Collections.IDictionary, System.Collections.IEnumerable
    {
        public SortedDictionary() { }
        public SortedDictionary(System.Collections.Generic.IComparer<TKey> comparer) { }
        public SortedDictionary(System.Collections.Generic.IDictionary<TKey, TValue> dictionary) { }
        public SortedDictionary(System.Collections.Generic.IDictionary<TKey, TValue> dictionary, System.Collections.Generic.IComparer<TKey> comparer) { }
        public System.Collections.Generic.IComparer<TKey> Comparer { get { return default(System.Collections.Generic.IComparer<TKey>); } }
        public int Count { get { return default(int); } }
        public TValue this[TKey key] { get { return default(TValue); } set { } }
        public System.Collections.Generic.SortedDictionary<TKey, TValue>.KeyCollection Keys { get { return default(System.Collections.Generic.SortedDictionary<TKey, TValue>.KeyCollection); } }
        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>.IsReadOnly { get { return default(bool); } }
        System.Collections.Generic.ICollection<TKey> System.Collections.Generic.IDictionary<TKey, TValue>.Keys { get { return default(System.Collections.Generic.ICollection<TKey>); } }
        System.Collections.Generic.ICollection<TValue> System.Collections.Generic.IDictionary<TKey, TValue>.Values { get { return default(System.Collections.Generic.ICollection<TValue>); } }
        bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
        object System.Collections.ICollection.SyncRoot { get { return default(object); } }
        bool System.Collections.IDictionary.IsFixedSize { get { return default(bool); } }
        bool System.Collections.IDictionary.IsReadOnly { get { return default(bool); } }
        object System.Collections.IDictionary.this[object key] { get { return default(object); } set { } }
        System.Collections.ICollection System.Collections.IDictionary.Keys { get { return default(System.Collections.ICollection); } }
        System.Collections.ICollection System.Collections.IDictionary.Values { get { return default(System.Collections.ICollection); } }
        public System.Collections.Generic.SortedDictionary<TKey, TValue>.ValueCollection Values { get { return default(System.Collections.Generic.SortedDictionary<TKey, TValue>.ValueCollection); } }
        public void Add(TKey key, TValue value) { }
        public void Clear() { }
        public bool ContainsKey(TKey key) { return default(bool); }
        public bool ContainsValue(TValue value) { return default(bool); }
        public void CopyTo(System.Collections.Generic.KeyValuePair<TKey, TValue>[] array, int index) { }
        public System.Collections.Generic.SortedDictionary<TKey, TValue>.Enumerator GetEnumerator() { return default(System.Collections.Generic.SortedDictionary<TKey, TValue>.Enumerator); }
        public bool Remove(TKey key) { return default(bool); }
        void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>.Add(System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair) { }
        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>.Contains(System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair) { return default(bool); }
        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>.Remove(System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair) { return default(bool); }
        System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>.GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>>); }
        void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
        void System.Collections.IDictionary.Add(object key, object value) { }
        bool System.Collections.IDictionary.Contains(object key) { return default(bool); }
        System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { return default(System.Collections.IDictionaryEnumerator); }
        void System.Collections.IDictionary.Remove(object key) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
        public bool TryGetValue(TKey key, out TValue value) { value = default(TValue); return default(bool); }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public partial struct Enumerator : System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IDictionaryEnumerator, System.Collections.IEnumerator, System.IDisposable
        {
            public System.Collections.Generic.KeyValuePair<TKey, TValue> Current { get { return default(System.Collections.Generic.KeyValuePair<TKey, TValue>); } }
            System.Collections.DictionaryEntry System.Collections.IDictionaryEnumerator.Entry { get { return default(System.Collections.DictionaryEntry); } }
            object System.Collections.IDictionaryEnumerator.Key { get { return default(object); } }
            object System.Collections.IDictionaryEnumerator.Value { get { return default(object); } }
            object System.Collections.IEnumerator.Current { get { return default(object); } }
            public void Dispose() { }
            public bool MoveNext() { return default(bool); }
            void System.Collections.IEnumerator.Reset() { }
        }
        public sealed partial class KeyCollection : System.Collections.Generic.ICollection<TKey>, System.Collections.Generic.IEnumerable<TKey>, System.Collections.ICollection, System.Collections.IEnumerable
        {
            public KeyCollection(System.Collections.Generic.SortedDictionary<TKey, TValue> dictionary) { }
            public int Count { get { return default(int); } }
            bool System.Collections.Generic.ICollection<TKey>.IsReadOnly { get { return default(bool); } }
            bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
            object System.Collections.ICollection.SyncRoot { get { return default(object); } }
            public void CopyTo(TKey[] array, int index) { }
            public System.Collections.Generic.SortedDictionary<TKey, TValue>.KeyCollection.Enumerator GetEnumerator() { return default(System.Collections.Generic.SortedDictionary<TKey, TValue>.KeyCollection.Enumerator); }
            void System.Collections.Generic.ICollection<TKey>.Add(TKey item) { }
            void System.Collections.Generic.ICollection<TKey>.Clear() { }
            bool System.Collections.Generic.ICollection<TKey>.Contains(TKey item) { return default(bool); }
            bool System.Collections.Generic.ICollection<TKey>.Remove(TKey item) { return default(bool); }
            System.Collections.Generic.IEnumerator<TKey> System.Collections.Generic.IEnumerable<TKey>.GetEnumerator() { return default(System.Collections.Generic.IEnumerator<TKey>); }
            void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
            [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
            public partial struct Enumerator : System.Collections.Generic.IEnumerator<TKey>, System.Collections.IEnumerator, System.IDisposable
            {
                public TKey Current { get { return default(TKey); } }
                object System.Collections.IEnumerator.Current { get { return default(object); } }
                public void Dispose() { }
                public bool MoveNext() { return default(bool); }
                void System.Collections.IEnumerator.Reset() { }
            }
        }
        public sealed partial class ValueCollection : System.Collections.Generic.ICollection<TValue>, System.Collections.Generic.IEnumerable<TValue>, System.Collections.ICollection, System.Collections.IEnumerable
        {
            public ValueCollection(System.Collections.Generic.SortedDictionary<TKey, TValue> dictionary) { }
            public int Count { get { return default(int); } }
            bool System.Collections.Generic.ICollection<TValue>.IsReadOnly { get { return default(bool); } }
            bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
            object System.Collections.ICollection.SyncRoot { get { return default(object); } }
            public void CopyTo(TValue[] array, int index) { }
            public System.Collections.Generic.SortedDictionary<TKey, TValue>.ValueCollection.Enumerator GetEnumerator() { return default(System.Collections.Generic.SortedDictionary<TKey, TValue>.ValueCollection.Enumerator); }
            void System.Collections.Generic.ICollection<TValue>.Add(TValue item) { }
            void System.Collections.Generic.ICollection<TValue>.Clear() { }
            bool System.Collections.Generic.ICollection<TValue>.Contains(TValue item) { return default(bool); }
            bool System.Collections.Generic.ICollection<TValue>.Remove(TValue item) { return default(bool); }
            System.Collections.Generic.IEnumerator<TValue> System.Collections.Generic.IEnumerable<TValue>.GetEnumerator() { return default(System.Collections.Generic.IEnumerator<TValue>); }
            void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
            [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
            public partial struct Enumerator : System.Collections.Generic.IEnumerator<TValue>, System.Collections.IEnumerator, System.IDisposable
            {
                public TValue Current { get { return default(TValue); } }
                object System.Collections.IEnumerator.Current { get { return default(object); } }
                public void Dispose() { }
                public bool MoveNext() { return default(bool); }
                void System.Collections.IEnumerator.Reset() { }
            }
        }
        System.Collections.Generic.IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.Keys { get { return default(System.Collections.Generic.IEnumerable<TKey>); } }
        System.Collections.Generic.IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.Values { get { return default(System.Collections.Generic.IEnumerable<TValue>); } }
    }
    public partial class SortedList<TKey, TValue> : 
        System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, 
        System.Collections.Generic.IDictionary<TKey, TValue>, 
        System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>,
        System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>,
        System.Collections.ICollection, System.Collections.IDictionary, System.Collections.IEnumerable
    {
        public SortedList() { }
        public SortedList(System.Collections.Generic.IComparer<TKey> comparer) { }
        public SortedList(System.Collections.Generic.IDictionary<TKey, TValue> dictionary) { }
        public SortedList(System.Collections.Generic.IDictionary<TKey, TValue> dictionary, System.Collections.Generic.IComparer<TKey> comparer) { }
        public SortedList(int capacity) { }
        public SortedList(int capacity, System.Collections.Generic.IComparer<TKey> comparer) { }
        public int Capacity { get { return default(int); } set { } }
        public System.Collections.Generic.IComparer<TKey> Comparer { get { return default(System.Collections.Generic.IComparer<TKey>); } }
        public int Count { get { return default(int); } }
        public TValue this[TKey key] { get { return default(TValue); } set { } }
        public System.Collections.Generic.IList<TKey> Keys { get { return default(System.Collections.Generic.IList<TKey>); } }
        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>.IsReadOnly { get { return default(bool); } }
        System.Collections.Generic.ICollection<TKey> System.Collections.Generic.IDictionary<TKey, TValue>.Keys { get { return default(System.Collections.Generic.ICollection<TKey>); } }
        System.Collections.Generic.ICollection<TValue> System.Collections.Generic.IDictionary<TKey, TValue>.Values { get { return default(System.Collections.Generic.ICollection<TValue>); } }
        bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
        object System.Collections.ICollection.SyncRoot { get { return default(object); } }
        bool System.Collections.IDictionary.IsFixedSize { get { return default(bool); } }
        bool System.Collections.IDictionary.IsReadOnly { get { return default(bool); } }
        object System.Collections.IDictionary.this[object key] { get { return default(object); } set { } }
        System.Collections.ICollection System.Collections.IDictionary.Keys { get { return default(System.Collections.ICollection); } }
        System.Collections.ICollection System.Collections.IDictionary.Values { get { return default(System.Collections.ICollection); } }
        public System.Collections.Generic.IList<TValue> Values { get { return default(System.Collections.Generic.IList<TValue>); } }
        public void Add(TKey key, TValue value) { }
        public void Clear() { }
        public bool ContainsKey(TKey key) { return default(bool); }
        public bool ContainsValue(TValue value) { return default(bool); }
        public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>>); }
        public int IndexOfKey(TKey key) { return default(int); }
        public int IndexOfValue(TValue value) { return default(int); }
        public bool Remove(TKey key) { return default(bool); }
        public void RemoveAt(int index) { }
        void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>.Add(System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair) { }
        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>.Contains(System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair) { return default(bool); }
        void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>.CopyTo(System.Collections.Generic.KeyValuePair<TKey, TValue>[] array, int arrayIndex) { }
        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>.Remove(System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair) { return default(bool); }
        System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>.GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>>); }
        void System.Collections.ICollection.CopyTo(System.Array array, int arrayIndex) { }
        void System.Collections.IDictionary.Add(object key, object value) { }
        bool System.Collections.IDictionary.Contains(object key) { return default(bool); }
        System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { return default(System.Collections.IDictionaryEnumerator); }
        void System.Collections.IDictionary.Remove(object key) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
        public void TrimExcess() { }
        public bool TryGetValue(TKey key, out TValue value) { value = default(TValue); return default(bool); }
        System.Collections.Generic.IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.Keys { get { return default(System.Collections.Generic.IEnumerable<TKey>); } }
        System.Collections.Generic.IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>.Values { get { return default(System.Collections.Generic.IEnumerable<TValue>); } }
    }
    public partial class SortedSet<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.Generic.ISet<T>, System.Collections.ICollection, System.Collections.IEnumerable, System.Runtime.Serialization.IDeserializationCallback, System.Runtime.Serialization.ISerializable
    {
        public SortedSet() { }
        public SortedSet(System.Collections.Generic.IComparer<T> comparer) { }
        public SortedSet(System.Collections.Generic.IEnumerable<T> collection) { }
        public SortedSet(System.Collections.Generic.IEnumerable<T> collection, System.Collections.Generic.IComparer<T> comparer) { }
        protected SortedSet(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public System.Collections.Generic.IComparer<T> Comparer { get { return default(System.Collections.Generic.IComparer<T>); } }
        public int Count { get { return default(int); } }
        public T Max { get { return default(T); } }
        public T Min { get { return default(T); } }
        bool System.Collections.Generic.ICollection<T>.IsReadOnly { get { return default(bool); } }
        bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
        object System.Collections.ICollection.SyncRoot { get { return default(object); } }
        public bool Add(T item) { return default(bool); }
        public virtual void Clear() { }
        public virtual bool Contains(T item) { return default(bool); }
        public void CopyTo(T[] array) { }
        public void CopyTo(T[] array, int index) { }
        public void CopyTo(T[] array, int index, int count) { }
        public static System.Collections.Generic.IEqualityComparer<System.Collections.Generic.SortedSet<T>> CreateSetComparer() { return default(System.Collections.Generic.IEqualityComparer<System.Collections.Generic.SortedSet<T>>); }
        public static System.Collections.Generic.IEqualityComparer<System.Collections.Generic.SortedSet<T>> CreateSetComparer(System.Collections.Generic.IEqualityComparer<T> memberEqualityComparer) { return default(System.Collections.Generic.IEqualityComparer<System.Collections.Generic.SortedSet<T>>); }
        public void ExceptWith(System.Collections.Generic.IEnumerable<T> other) { }
        public System.Collections.Generic.SortedSet<T>.Enumerator GetEnumerator() { return default(System.Collections.Generic.SortedSet<T>.Enumerator); }
        protected virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public virtual System.Collections.Generic.SortedSet<T> GetViewBetween(T lowerValue, T upperValue) { return default(System.Collections.Generic.SortedSet<T>); }
        public virtual void IntersectWith(System.Collections.Generic.IEnumerable<T> other) { }
        public bool IsProperSubsetOf(System.Collections.Generic.IEnumerable<T> other) { return default(bool); }
        public bool IsProperSupersetOf(System.Collections.Generic.IEnumerable<T> other) { return default(bool); }
        public bool IsSubsetOf(System.Collections.Generic.IEnumerable<T> other) { return default(bool); }
        public bool IsSupersetOf(System.Collections.Generic.IEnumerable<T> other) { return default(bool); }
        protected virtual void OnDeserialization(object sender) { }
        public bool Overlaps(System.Collections.Generic.IEnumerable<T> other) { return default(bool); }
        public bool Remove(T item) { return default(bool); }
        public int RemoveWhere(System.Predicate<T> match) { return default(int); }
        [System.Diagnostics.DebuggerHiddenAttribute]
        public System.Collections.Generic.IEnumerable<T> Reverse() { return default(System.Collections.Generic.IEnumerable<T>); }
        public bool SetEquals(System.Collections.Generic.IEnumerable<T> other) { return default(bool); }
        public void SymmetricExceptWith(System.Collections.Generic.IEnumerable<T> other) { }
        void System.Collections.Generic.ICollection<T>.Add(T item) { }
        System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { return default(System.Collections.Generic.IEnumerator<T>); }
        void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
        void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public void UnionWith(System.Collections.Generic.IEnumerable<T> other) { }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public partial struct Enumerator : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable, System.Runtime.Serialization.IDeserializationCallback, System.Runtime.Serialization.ISerializable
        {
            public T Current { get { return default(T); } }
            object System.Collections.IEnumerator.Current { get { return default(object); } }
            public void Dispose() { }
            public bool MoveNext() { return default(bool); }
            void System.Collections.IEnumerator.Reset() { }
            void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }
            void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        }
    }
} // end of System.Collections.Generic
namespace System.Collections.Specialized {

    public partial class StringCollection : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList
    {
        public StringCollection() { }
        public int Count { get { return default(int); } }
        public bool IsReadOnly { get { return default(bool); } }
        public bool IsSynchronized { get { return default(bool); } }
        public string this[int index] { get { return default(string); } set { } }
        public object SyncRoot { get { return default(object); } }
        bool System.Collections.IList.IsFixedSize { get { return default(bool); } }
        bool System.Collections.IList.IsReadOnly { get { return default(bool); } }
        object System.Collections.IList.this[int index] { get { return default(object); } set { } }
        public int Add(string value) { return default(int); }
        public void AddRange(string[] value) { }
        public void Clear() { }
        public bool Contains(string value) { return default(bool); }
        public void CopyTo(string[] array, int index) { }
        public System.Collections.Specialized.StringEnumerator GetEnumerator() { return default(System.Collections.Specialized.StringEnumerator); }
        public int IndexOf(string value) { return default(int); }
        public void Insert(int index, string value) { }
        public void Remove(string value) { }
        public void RemoveAt(int index) { }
        void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
        int System.Collections.IList.Add(object value) { return default(int); }
        bool System.Collections.IList.Contains(object value) { return default(bool); }
        int System.Collections.IList.IndexOf(object value) { return default(int); }
        void System.Collections.IList.Insert(int index, object value) { }
        void System.Collections.IList.Remove(object value) { }
    }
    public partial class StringDictionary : System.Collections.IEnumerable
    {
        public StringDictionary() { }
        public virtual int Count { get { return default(int); } }
        public virtual bool IsSynchronized { get { return default(bool); } }
        public virtual string this[string key] { get { return default(string); } set { } }
        public virtual System.Collections.ICollection Keys { get { return default(System.Collections.ICollection); } }
        public virtual object SyncRoot { get { return default(object); } }
        public virtual System.Collections.ICollection Values { get { return default(System.Collections.ICollection); } }
        public virtual void Add(string key, string value) { }
        public virtual void Clear() { }
        public virtual bool ContainsKey(string key) { return default(bool); }
        public virtual bool ContainsValue(string value) { return default(bool); }
        public virtual void CopyTo(System.Array array, int index) { }
        public virtual System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
        public virtual void Remove(string key) { }
    }

    public partial class StringEnumerator
    {
        internal StringEnumerator() { }
        public string Current { get { return default(string); } }
        public bool MoveNext() { return default(bool); }
        public void Reset() { }
    }
} // end of System.Collections.Specialized
