namespace dotnet_learning;

public static class EnumExample
{
    /// <summary>
    /// Enum содержит ключ и целочисленное значение этого ключа
    /// Monday = 1 (по умолчанию первый элемент имеет значение 0)
    /// Каждое следующее значение имеет значение second = first + 1
    /// </summary>
    private enum DayOfWeek
    {
        Monday = 1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
    
    public static void Example()
    {
        const DayOfWeek dayOfWeek = DayOfWeek.Monday;
        Console.WriteLine(dayOfWeek);
    }
}