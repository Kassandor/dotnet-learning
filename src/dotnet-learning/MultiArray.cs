namespace dotnet_learning;

public static class MultiArray
{
    /// <summary>
    /// Двумерный массив
    /// </summary>
    public static void TwoDimensionalArray()
    {
        // Прямоугольный массив
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

        for (var i = 0; i < twoDimensionalArray2.GetLength(0); i++)
        {
            for (var j = 0; j < twoDimensionalArray2.GetLength(1); j++)
            {
                Console.Write(twoDimensionalArray2[i, j] + "\t");
            }

            Console.WriteLine();
        }
    }
}