// See https://aka.ms/new-console-template for more information

namespace HomeWorksConsole
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(ArithmeticHomeWork.Sum(10, 15, 20));
            Console.WriteLine(ArithmeticHomeWork.Average(10, 15, 20));
            Console.WriteLine(ArithmeticHomeWork.CurrencyConversion(250));
        }
    }
}
