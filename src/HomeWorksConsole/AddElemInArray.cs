namespace HomeWorksConsole;

public static class AddElemInArray
{
    private static int[] _myArray = [1, 2, 3, 4, 5, 6, 7, 8, 9];

    public static void Example(int number)
    {
        AddInArray(ref _myArray, number);
        Console.Write($"Add {number} into array: [{string.Join(", ", _myArray)}]");
    }

    private static void AddInArray(ref int[] array, int number)
    {
        var newArray = new int[array.Length + 1];
        Array.Copy(array, newArray, array.Length);
        newArray[^1] = number;
        array = newArray;
    }
}