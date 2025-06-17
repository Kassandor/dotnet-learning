using System.Text;

namespace dotnet_learning
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            HelloWorld.SayHello();

            Console.WriteLine();
            NumbersFormatExample.WriteLineNumber();
            StringFormatExample.StringToInt();

            Console.WriteLine();
            ArithmeticOperations.Divide(10, 10);
            ArithmeticOperations.Divide(10.0, 10); // Перегрузка, выбирается double
            ArithmeticOperations.Divide(10, 10.0); // Перегрузка, выбирается double

            Console.WriteLine();
            IncrementDecrement.PostFixForEach();
            IncrementDecrement.PreFixForEach();

            Console.WriteLine();
            SwitchCase.SwitchCaseExample(1);
            SwitchCase.SwitchCaseExample();
            // Ввести TAB для проверки, что падает исключение
            Console.WriteLine("Нажми <TAB> для проверки");
            SwitchCase.SwitchCaseTryCatchExample(Console.ReadKey().Key);
            
            Console.WriteLine();
            ForCycle.ForExample();
            
            Console.WriteLine();
            ArraysExample.ArrayExample();
            // LINQ to arrays Example
            ArraysExample.ArrayExample2();
            
            Console.WriteLine();
            RangesExample.RangeExample();
            
            Console.WriteLine();
            MultiArray.TwoDimensionalArray();
            Console.WriteLine();
            MultiArray.JaggedArray();
            Console.WriteLine();
            MultiArray.ThreeDimensionalArray();
            
            Console.WriteLine();
            var a = 10;
            RefVarsExample.RefExample(ref a, 15);
            
            Console.WriteLine();
            InExample.Example(10);

            // Пример бесконечной рекурсии, которая в итоге переполнит стек
            // RecurseExample.Example();
            Console.WriteLine();
            // Ядерный Ганди
            ArithmeticOverflowExample.Example();
            ArithmeticOverflowExample.Example2();
            
            Console.WriteLine();
            EnumExample.Example();

            Console.WriteLine();
            // Initialize example
            // Сначала вызовется secondary конструктор, затем primary
            var gun = new Gun("Проверка, какой конструктор вызовется первым");
            gun.Shoot();

            Console.WriteLine();
            // Статический конструктор
            var dbRepository = new DbRepository();
            dbRepository.GetData();
        }
    }
}