namespace HomeWorksConsole;

public static class ReversePrintArray
{
    public static void Example()
    {
        var arr = new [] {1, 2, 3, 4, 5, 6, 7, 8, 9};
        
        // Через декремент
        for (var i = arr.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(arr[i]);
        }
        
        // Через инкремент
        // var lastIndex = arr.Length - 1;
        // for (var i = 0; i <= lastIndex ; i++)
        // {
            // Console.WriteLine(arr.GetValue(lastIndex - i));
        // }

        // Через LINQ
        // foreach (var i in arr.Reverse())
        // {
            // Console.WriteLine(i);
        // }
    }
}