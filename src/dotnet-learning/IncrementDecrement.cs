namespace dotnet_learning;

public static class IncrementDecrement
{
    private const int Amount = 10;

    public static void PostFixForEach()
    {
        var counter = 0;
        foreach (var i in Enumerable.Range(2, Amount))
        {
            Console.WriteLine("Постфикс");
            Console.WriteLine($"Счетчик: {counter}");
            Console.WriteLine($"Число: {i}");
            Console.WriteLine($"Счетчик * число: {counter++ * i}\n");

        }
    }

    public static void PreFixForEach()
    {
        var counter = 0;
        foreach (var i in Enumerable.Range(2, Amount))
        {
            Console.WriteLine("Префикс");
            Console.WriteLine($"Счетчик: {counter}");
            Console.WriteLine($"Число: {i}");
            Console.WriteLine($"Счетчик * число: {++counter * i}\n");
        }
    }
}