namespace dotnet_learning;

public delegate int ExampleDelegate(int a, int b);

public static class DelegatesExample
{
    public static int Multiply(int x, int y)
    {
        return x * y;
    }

    public static int Sum(int x, int y)
    {
        return x + y;
    }

    public static void PerformMathOperation(Func<int, int, int> operation, int x, int y)
    {
        Console.WriteLine("operation(x, y)");
        var result = operation(x, y);
        Console.WriteLine(result);
    }
    
    public static void PerformMathOperation(ExampleDelegate operation, int x, int y)
    {
        Console.WriteLine("operation(x, y)");
        var result = operation(x, y);
        Console.WriteLine(result);
    }

    public static bool IsEven(int number)
    {
        return number % 2 == 0;
    }
    
    
}