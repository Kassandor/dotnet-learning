using System.Text;

namespace dotnet_learning;

internal interface IPrintable
{
    void Print();
}

internal struct Point : IPrintable
{
    public int X { get; set; }
    public int Y { get; set; }
    public void Print()
    {
        Console.WriteLine("[Сигнатура string, object, object]Произойдет упаковка X и Y: X = {0}, Y = {1}", X, Y);
        var sb = new StringBuilder();
        sb.Append("[StringBuilder]Не произойдет упаковки: X = ")
            .Append(X)      // тут есть Append(int) — без boxing
            .Append(", Y = ")
            .Append(Y)      // Append(int) — тоже без boxing
            .AppendLine();
        Console.WriteLine(sb);
        Console.WriteLine($"[Интерполяция]Тоже не произойдет упаковки X = {X} Y = {Y}");
    }
}

