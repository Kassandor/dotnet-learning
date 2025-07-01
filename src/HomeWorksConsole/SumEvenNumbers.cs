namespace HomeWorksConsole;

public static class SumEvenNumbers
{
    private static readonly int[] IntArray = [1, 2, 3, 4, 5, 6, 7, 8, 9];

    public static int Example()
    {
        
        var result = IntArray.Aggregate(0, (accumulate, i) => IsEven(i) ? accumulate + i : accumulate);
        // Console.WriteLine($"Accumulate even numbers: {result}");
        return result;
    }

    public static int Example2()
    {
        var result = 0;
        for (var i = 0; i < IntArray.Length; i++)
        {
            if (IsEven(IntArray[i])) result += i;
        }
        // Console.WriteLine($"Accumulate even numbers: {result}");
        return result;
    }
    private static bool IsEven(int num) => num % 2 == 0;
}