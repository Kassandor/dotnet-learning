namespace dotnet_learning;

public static class RangesExample
{
    public static void RangeExample()
    {
        int[] myArray = [2, 10, 15, 16, 17, 19];
        // Range Со второго по пятый элемент
        var myArray2 = myArray[1..4];
        // Range Все элементы
        var myArray3 = myArray[..];
        // Range С пятого и до конца
        var myArray4 = myArray[5..];
        // Index Первый элемент с конца
        var myArray5 = myArray[^1];
        Console.WriteLine("myArray[1..4] = {0}", myArray2);
        Console.WriteLine("myArray3 = myArray[..] = {0}", myArray3);
        Console.WriteLine("myArray4 = myArray[5..] = {0}", myArray4);
        Console.WriteLine("myArray5 = myArray[^1] = {0}", myArray5);
    }
}