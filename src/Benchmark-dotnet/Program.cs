using Benchmark_dotnet.Tests;
using BenchmarkDotNet.Running;

namespace Benchmark_dotnet;

internal static class Program
{
    private static void Main(string[] args)
    {
        {
            // Запускаем все бенчмарки из сборки
            
            // BenchmarkRunner.Run(typeof(SumEvenNumbersBenchmark).Assembly);
            BenchmarkRunner.Run(typeof(MinNumberInArrayBenchmark).Assembly);
        }
    }
}