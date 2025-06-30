using BenchmarkDotNet.Attributes;
using LanguageMasteryChallenges.LeetCode;

namespace Benchmark;

[MemoryDiagnoser]
public class _1233RemoveSubFoldersFromTheFilesystemBenchmark
{
    private readonly string[] _arrayToSort = ["/c/d", "/c/d/e", "/c/f", "/a/b", "/a"];

    [Benchmark]
    public string[] ArraySort()
    {
        Array.Sort(_arrayToSort);
        return _arrayToSort;
    }

    [Benchmark]
    public string[] SpanSort()
    {
        _arrayToSort.AsSpan().Sort();
        return _arrayToSort;
    }
}