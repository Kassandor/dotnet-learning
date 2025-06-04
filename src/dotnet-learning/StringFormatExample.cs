namespace dotnet_learning;

public static class StringFormatExample
{
    public static void StringToInt()
    {
        const string str = "5";
        var num = int.Parse(str);
        Console.WriteLine($"StringFormat example: {num}");
    }
}