namespace PatternsExample;

internal static class Program
{
    private static void Main(string[] args)
    {
        var blackCircleFactory = new FigureFactory(new CircleFactory(), new BlackFactory());
        var blackCircle = blackCircleFactory.CreateFigure();
        blackCircle.Render();
    }
}