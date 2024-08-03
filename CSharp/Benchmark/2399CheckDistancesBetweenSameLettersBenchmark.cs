using BenchmarkDotNet.Attributes;
using LanguageMasteryChallenges.LeetCode;

namespace Benchmark;

[MemoryDiagnoser]
public class _2399CheckDistancesBetweenSameLettersBenchmark
{
    private string _s = "qwqwerertytyuiuiopopasasdfdfghghjkjklzlzxcxcvbvbnmnm";

    private int[] _distance = [1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1];
    
    [Benchmark]
    public bool Basic()
    {
        return _2399CheckDistancesBetweenSameLetters.CheckDistancesBasic(_s, _distance);
    }

    [Benchmark]
    public bool UsingSpan()
    {
        return _2399CheckDistancesBetweenSameLetters.CheckDistancesUsingSpan(_s, _distance);
    }
}