namespace dotnet_learning;

public static class ArithmeticOperations
{
    /// <summary>
    /// Return sum two int variables
    /// </summary>
    /// <param name="a">int</param>
    /// <param name="b">int</param>
    /// <returns>int</returns>
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Subtract(int a, int b)
    {
        return a - b;
    }

    public static int Multiply(int a, int b)
    {
        return a * b;
    }
    
    /// <summary>
    /// Divide int vars
    /// </summary>
    /// <param name="a">int</param>
    /// <param name="b">int</param>
    /// <returns></returns>
    public static int Divide(int a, int b)
    {
        return a / b;
    }
    /// <summary>
    /// Divide double vars
    /// </summary>
    /// <param name="a">double</param>
    /// <param name="b">double</param>
    /// <returns></returns>
    public static double Divide(double a, double b)
    {
        return a / b;
    }

    public static int Mod(int a, int b)
    {
        return a % b;
    }
}