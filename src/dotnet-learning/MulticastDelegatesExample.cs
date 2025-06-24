namespace dotnet_learning;

public static class MulticastDelegatesExample
{
    public delegate void Notify(string msg);

    public static void SendSms(string msg)
    {
        Console.WriteLine($"Sms: {msg}");
    }

    public static void SendEmail(string msg)
    {
        Console.WriteLine($"Email: {msg}");
    }
}