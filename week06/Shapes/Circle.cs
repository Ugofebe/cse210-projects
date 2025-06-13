public class Circle : Shape
{
    private double _radius;

    public Circle(string color, double radius) : base (color)
    {
        _radius = radius;
    }

    // The overide simply means it can make changes to the base class Shape
    public override double GetArea()
    {
        return _radius * _radius * Math.PI;
    }
}