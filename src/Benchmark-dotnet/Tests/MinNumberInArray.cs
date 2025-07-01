using BenchmarkDotNet.Attributes;
using HomeWorksConsole;

namespace Benchmark_dotnet.Tests;

public class MinNumberInArrayBenchmark
{
    [MemoryDiagnoser]  // показывает аллокации памяти
    public class SumEvenNumbersBenchmark
    {
        [Benchmark(Baseline = true)]
        public int UsingLinqMin() => MinNumberInArray.Example();

        [Benchmark]
        public int UsingForLoop() => MinNumberInArray.Example2();
        
        [Benchmark]
        public int UsingForEach() => MinNumberInArray.Example3();
    }
}