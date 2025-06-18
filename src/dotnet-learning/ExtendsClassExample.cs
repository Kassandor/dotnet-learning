namespace dotnet_learning;

internal class Point2D
{
    protected Point2D(string message)
    {
        Console.WriteLine("Point2D() с переданным параметром message = {0}", message);
    }
}

internal class Point3D : Point2D
{
    /// <summary>
    /// По умолчанию всегда вызывается base() конструктор, даже если его не определять
    /// </summary>
    /// <param name="message">Сообщение</param>
    public Point3D(string message) : base(message)
    {
        Console.WriteLine("Point3D()");
    }
}