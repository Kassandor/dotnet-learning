namespace PatternsExample;

using System;

// Интерфейсы классов, которые создает фабрика

#region IClasses

public interface IShape
{
    void Draw();
}

public interface IColor
{
    void Fill();
}

#endregion

// Интерфейсы фабрик

#region IFactories

public interface IShapeFactory
{
    IShape CreateShape();
}

public interface IColorFactory
{
    IColor CreateColor();
}

#endregion

// Реализации классов, которые создает фабрика

#region ConcreteClasses

public class Circle : IShape
{
    public void Draw() => Console.WriteLine("Draw Circle");
}

public class Square : IShape
{
    public void Draw() => Console.WriteLine("Draw Square");
}

public class Black : IColor
{
    public void Fill() => Console.WriteLine("Fill Black");
}

public class White : IColor
{
    public void Fill() => Console.WriteLine("Fill White");
}

public class ColoredShape(IShape shape, IColor color)
{
    private IShape Shape { get; } = shape;
    private IColor Color { get; } = color;

    public void Render()
    {
        Shape.Draw();
        Color.Fill();
    }
}

#endregion

// Реализации главной фабрики и ее компонентов 

#region ConcreteFactory

public class FigureFactory(IShapeFactory shapeFactory, IColorFactory colorFactory)
{
    public ColoredShape CreateFigure()
    {
        return new ColoredShape(shapeFactory.CreateShape(), colorFactory.CreateColor());
    }
}

public class CircleFactory : IShapeFactory
{
    public IShape CreateShape() => new Circle();
}

public class SquareFactory : IShapeFactory
{
    public IShape CreateShape() => new Square();
}

public class BlackFactory : IColorFactory
{
    public IColor CreateColor() => new Black();
}

public class WhiteFactory : IColorFactory
{
    public IColor CreateColor() => new White();
}

#endregion