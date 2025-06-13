using System;

class Program
{
    static void Main(string[] args)
    {
        // This simple means that since you cannot instantiate 
        // the abstract class Shape but it can also instantiate 
        // it with reference to the child classes since they are  
        // concrete to classes derived from the base class Shape  
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Red", 3);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("Blue", 4, 5);
        shapes.Add(s2);

        Circle s3 = new Circle("Green", 6);
        shapes.Add(s3);

        foreach (Shape s in shapes)
        {

            string color = s.GetColor();

            // All shapes have the GetArea() method but they have different 
            // functionality ass related to each unique shape 
            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}