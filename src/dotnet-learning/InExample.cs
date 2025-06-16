namespace dotnet_learning;

public static class InExample
{
    public static void Example(in int value)
    {
        Console.WriteLine($"value = {value} доступен внутри метода только для чтения");
    }
}