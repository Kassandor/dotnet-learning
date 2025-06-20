namespace dotnet_learning;

/// <summary>
/// Пример первый - без обобщения
/// </summary>
public static class WithoutGenericExample
{
    public static void Swap(ref int a, ref int b)
    {
        Console.WriteLine($"a = {a}, b = {b}");
        (a, b) = (b, a);
        PrintResult(a, b);
    }
    
    public static void Swap(ref double a, ref double b)
    {
        Console.WriteLine($"a = {a}, b = {b}");
        (a, b) = (b, a);
        PrintResult(a, b);
    }

    private static void PrintResult(int a, int b)
    {
        Console.WriteLine($"a = {a} b = {b}");
    }
    
    private static void PrintResult(double a, double b)
    {
        Console.WriteLine($"a = {a} b = {b}");
    }
}

/// <summary>
/// Пример второй - с обобщением, в качестве параметров один любой тип
/// </summary>
public static class GenericExample
{
    public static void Swap<T>(ref T a, ref T b)
    {
        Console.WriteLine($"a = {a} b = {b}");
        (a, b) = (b, a);
        PrintResult(a, b);
    }

    private static void PrintResult<T>(T a, T b)
    {
        Console.WriteLine($"a = {a} b = {b}");
    }
}

public class GenericExampleList<T>
{
    private T[] _array = [];

    public T this[int index]
    {
        get => _array[index];
        set => _array[index] = value;
    }
    
    public int Count => _array.Length;

    public void Add(T item)
    {
        var newArray = new T[Count + 1];
        Array.Copy(_array, newArray, Count);
        newArray[Count] = item;
        _array = newArray;
    }
    
    
}