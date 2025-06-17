namespace dotnet_learning;

/// <summary>
/// Конструкторы вызываются по принципу "первым пришел - последним ушел"
/// Это значит, что вызывая public Gun(string message) : this() сначала отработает private Gun() и так далее
/// Так же можно определить primary constructor: internal class Gun(bool isLoaded)
/// и он всегда будет отрабатывать самым первым
/// </summary>
internal class Gun
{
    /// <summary>
    /// Заряжена ли пушка
    /// </summary>
    private bool IsLoaded { get; set; }

    private Gun(bool isLoaded)
    {
        Console.WriteLine("Конструктор private Gun(bool isLoaded)");
        IsLoaded = isLoaded;
    }

    private Gun() : this(false)
    {
        Console.WriteLine("Конструктор public Gun() : this(false)");
    }

    public Gun(string message) : this()
    {
        Console.WriteLine("Конструктор public Gun(string message) : this()");
        Console.WriteLine(message);
    }
    
    private void Reload()
    {
        Console.WriteLine("Reloading...");
        IsLoaded = true;
        Console.WriteLine("Reload complete");
    }

    public void Shoot()
    {
        if (!IsLoaded)
        {
            Console.WriteLine("Пушка не заряжена");
            Reload();
        }

        Console.WriteLine("Пушка стреляет");
        IsLoaded = false;
    }
}