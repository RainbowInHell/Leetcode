using BenchmarkDotNet.Attributes;
using LanguageMasteryChallenges.LeetCode;

namespace Benchmark;

[MemoryDiagnoser]
public class _2000ReversePrefixOfWordBenchmark
{
    private string _word;

    private char _ch;

    [GlobalSetup]
    public void GlobalSetup()
    {
        _word = "aeiquwyeiqwuyeiquwyeiuqyeiuqwyeiuyqwiueyiqweyiqwuyiqyeiquweyqwuieyiquweyiqwyeiquweyiuqwyebcdefd";
        _ch = 'd';
    }

    [Benchmark]
    public void ReversePrefixWithSpan()
    {
        _2000ReversePrefixOfWord.ReversePrefixUsingSpan(_word, _ch);
    }

    [Benchmark]
    public void ReversePrefixWithArrayReverse()
    {
        _2000ReversePrefixOfWord.ReversePrefixUsingArrayReverse(_word, _ch);
    }
}