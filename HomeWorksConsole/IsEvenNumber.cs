namespace HomeWorksConsole;

public static class IsEvenChecker
{
    private static bool CheckParity(this int number)
    {
        return number % 2 == 0;
    }

    public static string IsEven(this int number)
    {
        return number.CheckParity() ? "четное" : "нечетное";
    }
}