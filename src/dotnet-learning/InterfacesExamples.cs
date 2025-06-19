namespace dotnet_learning;

internal interface IDataProvider
{
    public string GetData();
}

internal interface IDataProcessor
{
    public void ProcessData(IDataProvider dataProvider);
}

internal class DbDataProvider : IDataProvider
{
    public string GetData()
    {
        return "Данные из БД";
    }
}

internal class FileDataProvider : IDataProvider
{
    public string GetData()
    {
        return "Данные из файла";
    }
}

internal class ApiDataProvider : IDataProvider
{
    public string GetData()
    {
        return "Данные из API";
    }
}

internal class ConsoleDataProcessor : IDataProcessor
{
    public void ProcessData(IDataProvider dataProvider)
    {
        Console.WriteLine(dataProvider.GetData());
    }
}

internal interface IFirstInterface
{
    void Action();
}

internal interface ISecondInterface
{
    void Action();
}

/// <summary>
/// Класс с двумя интерфейсами с одинаковой сигнатурой метода Action, но разной явной реализацией
/// </summary>
internal class ExplicityInterfaceExample : IFirstInterface, ISecondInterface
{
    void IFirstInterface.Action()
    {
        Console.WriteLine("void IFirstInterface.Action()");
    }

    void ISecondInterface.Action()
    {
        Console.WriteLine("void ISecondInterface.Action()");
    }
}