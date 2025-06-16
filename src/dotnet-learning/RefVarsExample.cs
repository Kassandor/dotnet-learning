namespace dotnet_learning;

public static class RefVarsExample
{
    public static void RefExample(ref int a, int b)
    {
        Console.WriteLine($"a передан по ссылке = {a}, b копируется, создавая новый объект = {b}");
        Console.WriteLine(
            "Таким образом, изменения 'a' внутри метода, повлияют на оригинальную 'a'," +
            " а изменения 'b' не затронут оригинальный объект");
    }
}