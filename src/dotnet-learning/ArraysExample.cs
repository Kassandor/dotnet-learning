namespace dotnet_learning;

public static class ArraysExample
{
    public static void ArrayExample()
    {
        // Создание массива с выделением под него 3 ячейки
        // Массив имеет строго заданный размер
        var myArray = new int[2];
        Console.WriteLine("var myArray = new int[2]; = [{0}]", string.Join(", ", myArray));
        myArray[0] = 1;
        myArray[1] = 2;
        Console.WriteLine("myArray[0] = 1; myArray[1] = 2; = [{0}]", string.Join(", ", myArray));
    }

    public static void ArrayExample2()
    {
        int[] myArray = [11, 10, 4];
        Console.WriteLine("Max myArray = {0}", myArray.Max());
        Console.WriteLine("Min myArray = {0}", myArray.Min());
    }
}