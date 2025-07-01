using BenchmarkDotNet.Attributes;
using HomeWorksConsole;

namespace Benchmark_dotnet.Tests
{
    [MemoryDiagnoser]  // показывает аллокации памяти
    public class SumEvenNumbersBenchmark
    {
        [Benchmark(Baseline = true)]
        public int UsingAggregate() => SumEvenNumbers.Example();

        [Benchmark]
        public int UsingForLoop() => SumEvenNumbers.Example2();
    }
}