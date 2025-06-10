using System.Text;

namespace dotnet_learning
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            HelloWorld.SayHello();
            
            NumbersFormatExample.WriteLineNumber();
            StringFormatExample.StringToInt();
            
            ArithmeticOperations.Divide(10, 10);
            ArithmeticOperations.Divide(10.0, 10); // Перегрузка, выбирается double
            ArithmeticOperations.Divide(10, 10.0); // Перегрузка, выбирается double
            
            IncrementDecrement.PostFixForEach();
            IncrementDecrement.PreFixForEach();
            
            SwitchCase.SwitchCaseExample(1);
            SwitchCase.SwitchCaseExample();
            // Ввести TAB для проверки что падает исключение
            SwitchCase.SwitchCaseTryCatchExample(Console.ReadKey().Key);
            
            ForCycle.ForExample();
        }
    }
}