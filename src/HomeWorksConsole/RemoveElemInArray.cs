namespace HomeWorksConsole;

public static class RemoveElemInArrayExample
{
    private static int[] _myArray = [1, 2, 3, 4, 5, 6, 7, 8, 9];

    public static void Example(int number)
    {
        Console.WriteLine($"Remove elem {number} in array: {string.Join(", ", _myArray)}");
        if (RemoveElemInArray(ref _myArray, number)) Console.WriteLine($"new array: {string.Join(", ", _myArray)}");
    }

    private static bool RemoveElemInArray(ref int[] array, int number)
    {
        if (!array.Contains(number))
        {
            Console.WriteLine($"Elem {number} not found");
            return false;
        }

        var newArray = new int[array.Length];
        for (var i = 0; i < array.Length; i++)
        {
            if (array[i] == number) continue;
            newArray[i] = array[i];
        }

        array = newArray;
        return true;
    }
}