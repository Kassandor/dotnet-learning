namespace dotnet_learning
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            HelloWorld.SayHello();
            NumbersFormatExample.WriteLineNumber();
            StringFormatExample.StringToInt();
            ArithmeticOperations.Divide(10, 10);
            ArithmeticOperations.Divide(10.0, 10); // Перегрузка, выбирается double
            ArithmeticOperations.Divide(10, 10.0); // Перегрузка, выбирается double
        }
    }
}