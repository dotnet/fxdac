[assembly:System.CLSCompliant(true)]
namespace System.Threading.Tasks {
    public static partial class Parallel
    {
        public static System.Threading.Tasks.ParallelLoopResult For(int fromInclusive, int toExclusive, System.Action<int, System.Threading.Tasks.ParallelLoopState> body) { return default(System.Threading.Tasks.ParallelLoopResult); }
        public static System.Threading.Tasks.ParallelLoopResult For(int fromInclusive, int toExclusive, System.Action<int> body) { return default(System.Threading.Tasks.ParallelLoopResult); }
        public static System.Threading.Tasks.ParallelLoopResult For(int fromInclusive, int toExclusive, System.Threading.Tasks.ParallelOptions parallelOptions, System.Action<int, System.Threading.Tasks.ParallelLoopState> body) { return default(System.Threading.Tasks.ParallelLoopResult); }
        public static System.Threading.Tasks.ParallelLoopResult For(int fromInclusive, int toExclusive, System.Threading.Tasks.ParallelOptions parallelOptions, System.Action<int> body) { return default(System.Threading.Tasks.ParallelLoopResult); }
        public static System.Threading.Tasks.ParallelLoopResult For(long fromInclusive, long toExclusive, System.Action<long, System.Threading.Tasks.ParallelLoopState> body) { return default(System.Threading.Tasks.ParallelLoopResult); }
        public static System.Threading.Tasks.ParallelLoopResult For(long fromInclusive, long toExclusive, System.Action<long> body) { return default(System.Threading.Tasks.ParallelLoopResult); }
        public static System.Threading.Tasks.ParallelLoopResult For(long fromInclusive, long toExclusive, System.Threading.Tasks.ParallelOptions parallelOptions, System.Action<long, System.Threading.Tasks.ParallelLoopState> body) { return default(System.Threading.Tasks.ParallelLoopResult); }
        public static System.Threading.Tasks.ParallelLoopResult For(long fromInclusive, long toExclusive, System.Threading.Tasks.ParallelOptions parallelOptions, System.Action<long> body) { return default(System.Threading.Tasks.ParallelLoopResult); }
        public static System.Threading.Tasks.ParallelLoopResult For<TLocal>(int fromInclusive, int toExclusive, System.Func<TLocal> localInit, System.Func<int, System.Threading.Tasks.ParallelLoopState, TLocal, TLocal> body, System.Action<TLocal> localFinally) { return default(System.Threading.Tasks.ParallelLoopResult); }
        public static System.Threading.Tasks.ParallelLoopResult For<TLocal>(int fromInclusive, int toExclusive, System.Threading.Tasks.ParallelOptions parallelOptions, System.Func<TLocal> localInit, System.Func<int, System.Threading.Tasks.ParallelLoopState, TLocal, TLocal> body, System.Action<TLocal> localFinally) { return default(System.Threading.Tasks.ParallelLoopResult); }
        public static System.Threading.Tasks.ParallelLoopResult For<TLocal>(long fromInclusive, long toExclusive, System.Func<TLocal> localInit, System.Func<long, System.Threading.Tasks.ParallelLoopState, TLocal, TLocal> body, System.Action<TLocal> localFinally) { return default(System.Threading.Tasks.ParallelLoopResult); }
        public static System.Threading.Tasks.ParallelLoopResult For<TLocal>(long fromInclusive, long toExclusive, System.Threading.Tasks.ParallelOptions parallelOptions, System.Func<TLocal> localInit, System.Func<long, System.Threading.Tasks.ParallelLoopState, TLocal, TLocal> body, System.Action<TLocal> localFinally) { return default(System.Threading.Tasks.ParallelLoopResult); }
        public static System.Threading.Tasks.ParallelLoopResult ForEach<TSource>(System.Collections.Concurrent.OrderablePartitioner<TSource> source, System.Action<TSource, System.Threading.Tasks.ParallelLoopState, long> body) { return default(System.Threading.Tasks.ParallelLoopResult); }
        public static System.Threading.Tasks.ParallelLoopResult ForEach<TSource>(System.Collections.Concurrent.OrderablePartitioner<TSource> source, System.Threading.Tasks.ParallelOptions parallelOptions, System.Action<TSource, System.Threading.Tasks.ParallelLoopState, long> body) { return default(System.Threading.Tasks.ParallelLoopResult); }
        public static System.Threading.Tasks.ParallelLoopResult ForEach<TSource>(System.Collections.Concurrent.Partitioner<TSource> source, System.Action<TSource, System.Threading.Tasks.ParallelLoopState> body) { return default(System.Threading.Tasks.ParallelLoopResult); }
        public static System.Threading.Tasks.ParallelLoopResult ForEach<TSource>(System.Collections.Concurrent.Partitioner<TSource> source, System.Action<TSource> body) { return default(System.Threading.Tasks.ParallelLoopResult); }
        public static System.Threading.Tasks.ParallelLoopResult ForEach<TSource>(System.Collections.Concurrent.Partitioner<TSource> source, System.Threading.Tasks.ParallelOptions parallelOptions, System.Action<TSource, System.Threading.Tasks.ParallelLoopState> body) { return default(System.Threading.Tasks.ParallelLoopResult); }
        public static System.Threading.Tasks.ParallelLoopResult ForEach<TSource>(System.Collections.Concurrent.Partitioner<TSource> source, System.Threading.Tasks.ParallelOptions parallelOptions, System.Action<TSource> body) { return default(System.Threading.Tasks.ParallelLoopResult); }
        public static System.Threading.Tasks.ParallelLoopResult ForEach<TSource>(System.Collections.Generic.IEnumerable<TSource> source, System.Action<TSource, System.Threading.Tasks.ParallelLoopState, long> body) { return default(System.Threading.Tasks.ParallelLoopResult); }
        public static System.Threading.Tasks.ParallelLoopResult ForEach<TSource>(System.Collections.Generic.IEnumerable<TSource> source, System.Action<TSource, System.Threading.Tasks.ParallelLoopState> body) { return default(System.Threading.Tasks.ParallelLoopResult); }
        public static System.Threading.Tasks.ParallelLoopResult ForEach<TSource>(System.Collections.Generic.IEnumerable<TSource> source, System.Action<TSource> body) { return default(System.Threading.Tasks.ParallelLoopResult); }
        public static System.Threading.Tasks.ParallelLoopResult ForEach<TSource>(System.Collections.Generic.IEnumerable<TSource> source, System.Threading.Tasks.ParallelOptions parallelOptions, System.Action<TSource, System.Threading.Tasks.ParallelLoopState, long> body) { return default(System.Threading.Tasks.ParallelLoopResult); }
        public static System.Threading.Tasks.ParallelLoopResult ForEach<TSource>(System.Collections.Generic.IEnumerable<TSource> source, System.Threading.Tasks.ParallelOptions parallelOptions, System.Action<TSource, System.Threading.Tasks.ParallelLoopState> body) { return default(System.Threading.Tasks.ParallelLoopResult); }
        public static System.Threading.Tasks.ParallelLoopResult ForEach<TSource>(System.Collections.Generic.IEnumerable<TSource> source, System.Threading.Tasks.ParallelOptions parallelOptions, System.Action<TSource> body) { return default(System.Threading.Tasks.ParallelLoopResult); }
        public static System.Threading.Tasks.ParallelLoopResult ForEach<TSource, TLocal>(System.Collections.Concurrent.OrderablePartitioner<TSource> source, System.Func<TLocal> localInit, System.Func<TSource, System.Threading.Tasks.ParallelLoopState, long, TLocal, TLocal> body, System.Action<TLocal> localFinally) { return default(System.Threading.Tasks.ParallelLoopResult); }
        public static System.Threading.Tasks.ParallelLoopResult ForEach<TSource, TLocal>(System.Collections.Concurrent.OrderablePartitioner<TSource> source, System.Threading.Tasks.ParallelOptions parallelOptions, System.Func<TLocal> localInit, System.Func<TSource, System.Threading.Tasks.ParallelLoopState, long, TLocal, TLocal> body, System.Action<TLocal> localFinally) { return default(System.Threading.Tasks.ParallelLoopResult); }
        public static System.Threading.Tasks.ParallelLoopResult ForEach<TSource, TLocal>(System.Collections.Concurrent.Partitioner<TSource> source, System.Func<TLocal> localInit, System.Func<TSource, System.Threading.Tasks.ParallelLoopState, TLocal, TLocal> body, System.Action<TLocal> localFinally) { return default(System.Threading.Tasks.ParallelLoopResult); }
        public static System.Threading.Tasks.ParallelLoopResult ForEach<TSource, TLocal>(System.Collections.Concurrent.Partitioner<TSource> source, System.Threading.Tasks.ParallelOptions parallelOptions, System.Func<TLocal> localInit, System.Func<TSource, System.Threading.Tasks.ParallelLoopState, TLocal, TLocal> body, System.Action<TLocal> localFinally) { return default(System.Threading.Tasks.ParallelLoopResult); }
        public static System.Threading.Tasks.ParallelLoopResult ForEach<TSource, TLocal>(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TLocal> localInit, System.Func<TSource, System.Threading.Tasks.ParallelLoopState, TLocal, TLocal> body, System.Action<TLocal> localFinally) { return default(System.Threading.Tasks.ParallelLoopResult); }
        public static System.Threading.Tasks.ParallelLoopResult ForEach<TSource, TLocal>(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TLocal> localInit, System.Func<TSource, System.Threading.Tasks.ParallelLoopState, long, TLocal, TLocal> body, System.Action<TLocal> localFinally) { return default(System.Threading.Tasks.ParallelLoopResult); }
        public static System.Threading.Tasks.ParallelLoopResult ForEach<TSource, TLocal>(System.Collections.Generic.IEnumerable<TSource> source, System.Threading.Tasks.ParallelOptions parallelOptions, System.Func<TLocal> localInit, System.Func<TSource, System.Threading.Tasks.ParallelLoopState, TLocal, TLocal> body, System.Action<TLocal> localFinally) { return default(System.Threading.Tasks.ParallelLoopResult); }
        public static System.Threading.Tasks.ParallelLoopResult ForEach<TSource, TLocal>(System.Collections.Generic.IEnumerable<TSource> source, System.Threading.Tasks.ParallelOptions parallelOptions, System.Func<TLocal> localInit, System.Func<TSource, System.Threading.Tasks.ParallelLoopState, long, TLocal, TLocal> body, System.Action<TLocal> localFinally) { return default(System.Threading.Tasks.ParallelLoopResult); }
        public static void Invoke(params System.Action[] actions) { }
        public static void Invoke(System.Threading.Tasks.ParallelOptions parallelOptions, params System.Action[] actions) { }
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct ParallelLoopResult
    {
        public bool IsCompleted { get { return default(bool); } }
        public System.Nullable<long> LowestBreakIteration { get { return default(System.Nullable<long>); } }
    }
    public partial class ParallelLoopState
    {
        internal ParallelLoopState() { }
        public bool IsExceptional { get { return default(bool); } }
        public bool IsStopped { get { return default(bool); } }
        public System.Nullable<long> LowestBreakIteration { get { return default(System.Nullable<long>); } }
        public bool ShouldExitCurrentIteration { get { return default(bool); } }
        public void Break() { }
        public void Stop() { }
    }

    public partial class ParallelOptions
    {
        public ParallelOptions() { }
        public System.Threading.CancellationToken CancellationToken { get { return default(System.Threading.CancellationToken); } set { } }
        public int MaxDegreeOfParallelism { get { return default(int); } set { } }
        public System.Threading.Tasks.TaskScheduler TaskScheduler { get { return default(System.Threading.Tasks.TaskScheduler); } set { } }
    }
} // end of System.Threading.Tasks
