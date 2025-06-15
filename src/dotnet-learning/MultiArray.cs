namespace dotnet_learning;

public static class MultiArray
{
    /// <summary>
    /// Вывод в консоль прямоугольного массива
    /// </summary>
    /// <param name="array">Прямоугольный массив</param>
    private static void WriteLineArray<T>(T[,] array)
    {
        var rows = array.GetLength(0);
        var cols = array.GetLength(1);
        for (var i = 0; i < rows; i++)
        {
            for (var j = 0; j < cols; j++)
            {
                Console.Write(array[i, j] + "\t");
            }

            Console.WriteLine();
        }
    }

    /// <summary>
    /// Вывод в консоль трехмерного массива
    /// </summary>
    /// <param name="array">Трехмерный массив</param>
    private static void WriteLineArray<T>(T[,,] array)
    {
        var rows = array.GetLength(0);
        var cols = array.GetLength(1);
        var z = array.GetLength(2);

        for (var i = 0; i < rows; i++)
        {
            Console.WriteLine("Page number {0}", i + 1);
            for (var j = 0; j < cols; j++)
            {
                for (var k = 0; k < z; k++)
                {
                    Console.Write(array[i, j, k] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }

    /// <summary>
    /// Вывод в консоль зубчатого массива
    /// </summary>
    /// <param name="array">Зубчатый массив</param>
    private static void WriteLineArray<T>(T[][] array)
    {
        foreach (var row in array)
        {
            foreach (var item in row)
            {
                Console.Write(item + "\t");
            }

            Console.WriteLine();
        }
    }

    /// <summary>
    /// Двумерный прямоугольный массив XY
    /// </summary>
    public static void TwoDimensionalArray()
    {
        // Прямоугольный массив с осями XY
        int[,] twoDimensionalArray =
        {
            { 1, 2 },
            { 3, 4 }
        };
        Console.WriteLine("twoDimensionalArray[1, 1] = {0}", twoDimensionalArray[1, 1]);

        // Заполнение двумерного массива случайными числами
        var random = new Random();
        var twoDimensionalArray2 = new int[10, 6];
        Console.WriteLine("Random + twoDimensionalArray2[10, 6]:");
        for (var i = 0; i < twoDimensionalArray2.GetLength(0); i++)
        {
            for (var j = 0; j < twoDimensionalArray2.GetLength(1); j++)
            {
                twoDimensionalArray2[i, j] = random.Next();
            }
        }

        // Таблица случайного двумерного массива
        WriteLineArray(twoDimensionalArray2);
    }

    /// <summary>
    /// Двумерный зубчатый массив
    /// </summary>
    public static void JaggedArray()
    {
        var jaggedArray = new int [3][];
        jaggedArray[0] = new int[3];
        jaggedArray[1] = new int[6];
        jaggedArray[2] = new int[4];
        Console.WriteLine("jaggedArray[3][]:");
        WriteLineArray(jaggedArray);
    }

    /// <summary>
    /// Трехмерный массив XYZ
    /// </summary>
    public static void ThreeDimensionalArray()
    {
        int[,,] threeDimensionalArray =
        {
            {
                { 1, 2 },
                { 3, 4 },
                { 5, 6 }
            },
            {
                { 4, 5 },
                { 6, 7 },
                { 7, 8 },
            },
        };
        Console.WriteLine("threeDimensionArray int[,,]:");
        WriteLineArray(threeDimensionalArray);  
    }
}