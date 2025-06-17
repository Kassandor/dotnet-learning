namespace dotnet_learning;

public class DbRepository
{
    /// <summary>
    /// Строка подключения к базе данных, одна для всех
    /// </summary>
    private static string ConnectionString { get; }

    /// <summary>
    /// Статический конструктор, вызовется лишь раз на протяжении всего жизненного цикла
    /// </summary>
    static DbRepository()
    {
        ConnectionString = ConfigManager.GetConnectionString();
    }

    public void GetData()
    {
        Console.WriteLine("Используется {0}", ConnectionString);
    }
}

internal static class ConfigManager
{
    public static string GetConnectionString()
    {
        return "connectionString";
    }
}