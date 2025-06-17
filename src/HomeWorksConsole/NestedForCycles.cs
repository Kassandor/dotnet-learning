namespace HomeWorksConsole;

public static class NestedForCycles
{
    public static void WriteTriangle()
    {
        const int height = 10;
        for (var i = 0; i < height; i++)
        {
            for (var j = 0; j <= i; j++)
            {
                Console.Write('*');
            }
            Console.WriteLine();
        }
    }
}