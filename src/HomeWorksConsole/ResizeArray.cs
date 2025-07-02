namespace HomeWorksConsole;

public static class ResizeArrayExample
{
    private static int[] _myArray = [1, 2, 3, 4, 5, 6, 7, 8, 9];

    public static void Example(int newSize)
    {
        var newArray = ResizeArray(ref _myArray, newSize);
        Console.WriteLine(string.Join(", ", newArray));
    }

    private static int[] ResizeArray(ref int[] array, in int newSize)
    {
        var newArray = new int[newSize];
        Array.Copy(array, newArray, Math.Min(array.Length, newSize));
        return newArray;
    }
}