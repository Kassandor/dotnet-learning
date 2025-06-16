namespace dotnet_learning;

public static class RecurseExample
{
    private static void Foo()
    {
        Console.WriteLine("Foo");
        Foo();
    }
    public static void Example()
    {
        Foo();
    }
}