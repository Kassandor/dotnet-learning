using System.Globalization;

namespace dotnet_learning;

public static class NumbersFormatExample
{
    private const string Str = "5.5";
    private const string Str2 = "2.5";

    public static void WriteLineNumber()
    {
        var nfi = new NumberFormatInfo()
        {
            NumberDecimalSeparator = ".",
        };
        Console.WriteLine($"NumbersFormat example: {Convert.ToDouble(Str, nfi) + Convert.ToDouble(Str2, nfi)}");
    }
}