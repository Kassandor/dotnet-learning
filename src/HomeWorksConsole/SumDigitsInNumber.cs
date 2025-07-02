namespace HomeWorksConsole;

public static class RecursiveSumDigitsInNumberExample
{
    public static void Example(int n)
    {
        Console.WriteLine($"Sum digits by number {n} = {RecursiveSumDigitsInNumber(n)}");
    }

    private static int RecursiveSumDigitsInNumber(int n)
    {
        return n < 10 ? n : n % 10 + RecursiveSumDigitsInNumber(n / 10);
    }
}