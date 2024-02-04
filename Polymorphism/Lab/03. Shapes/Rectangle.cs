namespace Shapes;


public class Rectangle : Shape
{

    public Rectangle(double height, double width)
    {
        Height = height;
        Width = width;
    }

    public double  Height { get; private set; }

    public double  Width { get; private set; }

    public override double CalculateArea()
    {
        return Height * Width;
    }

    public override double CalculatePerimeter()
    {
        return 2 * (Width + Height);
    }

    public override string Draw()
    {
        return  $"Drawing Rectangle";
    }
}