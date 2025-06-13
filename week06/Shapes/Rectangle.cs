public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle(string color, double length, double width) : base (color)
    {
        _length = length;
        _width = width;
    }

    // The overide simply means it can make changes to the base class Shape
    public override double GetArea()
    {
        return _length * _width;
    }
}