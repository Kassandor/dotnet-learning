namespace dotnet_learning;

public delegate void OnNotify(string msg);

public class MessagePublisher
{
    public event OnNotify? OnNotify;

    public void RaiseEvent(string msg)
    {
        OnNotify?.Invoke(msg);
    }
}

public static class SmsSubscriber
{
    public static void ReceiveSms(string msg)
    {
        Console.WriteLine($"Sms: {msg}");
    }
}

public static class EmailSubscriber
{
    public static void ReceiveEmail(string msg)
    {
        Console.WriteLine($"Email: {msg}");
    }
}