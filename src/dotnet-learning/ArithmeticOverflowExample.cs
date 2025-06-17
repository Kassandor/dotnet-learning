namespace dotnet_learning;

public static class ArithmeticOverflowExample
{
    private static byte _aggression = 1;
    private const byte DemocracyModifier = 2;

    /// <summary>
    /// Проверка на переполнение byte-типа
    /// </summary>
    /// <param name="value">Значение для проверки</param>
    /// <returns></returns>
    private static bool IsWithinByteRange(int value)
    {
        return value is < byte.MinValue or > byte.MaxValue;
    }

    private static byte UpdateAggression(bool needCheck = false)
    {
        var result = _aggression - DemocracyModifier;
        _aggression = needCheck
            ? IsWithinByteRange(result) ? (byte)result : _aggression
            : (byte)result;
        return _aggression;
    }

    /// <summary>
    /// "Ядерный Ганди" и арифметическое переполнение
    /// </summary>
    public static void Example()
    {
        Console.WriteLine(
            "\nИзначальные атрибуты Ганди: agression = {0}, democracyModifier= {1}",
            _aggression,
            DemocracyModifier
        );
        // Происходит переполнение через нижнюю границу, byte = -1 превращается в byte = 255
        Console.WriteLine("(byte) aggression - democracyModifier = {0}", UpdateAggression());
        Console.WriteLine("Произошло переполнение, Ганди стал максимально агрессивным");
    }

    public static void Example2()
    {
        Console.WriteLine(
            "\nИзначальные атрибуты Ганди: agression = {0}, democracyModifier= {1}",
            _aggression,
            DemocracyModifier
        );
        // Не происходит переполнение через нижнюю границу
        Console.WriteLine(
            "CheckOverflowByteValue (result) aggression - democracyModifier = {0}",
            UpdateAggression(needCheck: true)
        );
        Console.WriteLine("Ганди не стал агрессивным, переполнения не произошло");
    }
}