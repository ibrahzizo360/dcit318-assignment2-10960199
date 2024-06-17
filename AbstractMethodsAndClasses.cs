public abstract class Shape
{
    public abstract double GetArea();
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}

public class Rectangle : Shape
{
    public double Length { get; set; }
    public double Width { get; set; }

    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }

    public override double GetArea()
    {
        return Length * Width;
    }
}

public class AbstractMethodsAndClasses
{
    public static void Main(string[] args)
    {
        Circle circle = new Circle(5);
        Rectangle rectangle = new Rectangle(4, 3);

        Console.WriteLine($"Circle Area: {circle.GetArea()}");
        Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}");
    }
}
