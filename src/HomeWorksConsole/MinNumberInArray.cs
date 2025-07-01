namespace HomeWorksConsole;

public class MinNumberInArray
{
    private static readonly int[] IntArray = [1, 2, 3, 4, 5, 6, 7, 8, 9];

    /// <summary>
    /// Linq
    /// </summary>
    /// <returns></returns>
    public static int Example()
    {
        var minValue = IntArray.Min();
        return minValue;
    }

    /// <summary>
    /// ForLoop
    /// </summary>
    /// <returns></returns>
    public static int Example2()
    {
        var minValue = IntArray[0];
        for (var i = 0; i < IntArray.Length; i++)
        {
            if (IntArray[i] < minValue) minValue = IntArray[i];
        }
        return minValue;
    }

    /// <summary>
    /// ForEach
    /// </summary>
    /// <returns></returns>
    public static int Example3()
    {
        var minValue = IntArray[0];
        foreach (var i in IntArray)
        {
            if (i < minValue) minValue = i;
        }
        return minValue;
    }
}