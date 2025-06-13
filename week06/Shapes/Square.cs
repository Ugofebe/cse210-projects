public class Square : Shape
{
    private double _side;

    public Square(string color, double side) : base (color)
    {
        _side = side;
    }

    // The overide simply means it can make changes to the base class Shape
    public override double GetArea()
    {
        return _side * _side;
    }
}