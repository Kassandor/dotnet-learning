namespace HomeWorksConsole;

public static class ArithmeticHomeWork
{
    public static int Average(params int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("numbers cannot be null or empty");
        }

        var sum = numbers.Aggregate<int, long>(0, (current, number) => current + number);

        return (int)(sum / numbers.Length);
    }

    public static int Sum(params int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("numbers cannot be null or empty");
        }

        return numbers.Sum();
    }
    /// <summary>
    /// Currency converter
    /// </summary>
    /// <param name="amount">decimal</param>
    /// <param name="currency">string</param>
    /// <param name="defaultRate">decimal</param>
    /// <returns>Multiply the amount by the currency modifier</returns>
    public static decimal CurrencyConversion(decimal amount, string currency = "USD", decimal defaultRate = 1m)
    {
        var currencies = new Dictionary<string, decimal>(StringComparer.OrdinalIgnoreCase)
        {
            { "USD", 0.05m },
            { "EUR", 0.1m },
        };
        return amount * currencies.GetValueOrDefault("USD", defaultRate);
    }
}