namespace HomeWorksConsole;

public static class FindIndexInArray
{
    private static readonly int[] MyArray = [1, 2, 3, 4, 5, 6, 7, 8, 9];
    private const int TargetValue = 7;

    public static void Example()
    {
        for (var i = 0; i < MyArray.Length; i++)
        {
            if (!ComparedWithTarget(MyArray[i])) continue;
            Console.WriteLine($"target: {TargetValue}, index: {i}");
            return;
        }
    }
    private static bool ComparedWithTarget(int number)
    {
        return number == TargetValue;
    }
}