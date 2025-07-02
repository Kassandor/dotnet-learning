// See https://aka.ms/new-console-template for more information

using System.Text;

namespace HomeWorksConsole
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;   
            Console.WriteLine(ArithmeticHomeWork.Sum(10, 15, 20));
            Console.WriteLine(ArithmeticHomeWork.Average(10, 15, 20));
            Console.WriteLine(ArithmeticHomeWork.CurrencyConversion(250));
            Console.WriteLine($"Число десять: {10.IsEven()}, а число девять: {9.IsEven()}");
            
            Console.WriteLine();
            NestedForCycles.WriteTriangle();
            
            Console.WriteLine();
            ReversePrintArray.Example();
            
            Console.WriteLine();
            FindIndexInArray.Example();
            
            Console.WriteLine();
            ResizeArrayExample.Example(20);
            
            Console.WriteLine();
            AddElemInArray.Example(101);
            
            Console.WriteLine();
            RemoveElemInArrayExample.Example(9);
            
            Console.WriteLine();
            RecursiveSumDigitsInNumberExample.Example(561);
        }
    }
}