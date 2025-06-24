namespace dotnet_learning;

public static class YieldBreakExample
{
    public static IEnumerable<int> Example1()
    {
        yield return 1;
        yield return 2;
        Console.WriteLine("break");
        yield break;
        Console.WriteLine(3);
        yield return 3;
    }

    private static IEnumerable<int> FilterEvenNumbers(int[]? numbers)
    {
        if (numbers == null)
        {
            Console.WriteLine("numbers is null");
            yield break;
        }

        foreach (var i in numbers.Where(number => number % 2 == 0)) yield return i;
    }

    public static void Example2()
    {
        var numbers = new[] { 1, 2, 3 };
        int[]? nullList = null;
        foreach (var number in FilterEvenNumbers(numbers))
        {
            Console.WriteLine(number);
        }

        foreach (var number in FilterEvenNumbers(nullList))
        {
            Console.WriteLine(number);
        }
    }
}