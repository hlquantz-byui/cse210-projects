using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Shapes Project.");
        // Square square = new Square("red", 2);
        // Rectangle rectangle = new Rectangle("blue", 2, 3);
        // Circle circle = new Circle("green", 1);

        // Console.WriteLine(square.GetArea());
        // Console.WriteLine(rectangle.GetArea());
        // Console.WriteLine(circle.GetArea());

        List<Shape> shapes = new List<Shape> { new Square("red", 2), new Rectangle("blue", 2, 3), new Circle("green", 1) };

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}");
            Console.WriteLine($"Area: {shape.GetArea()}");
        }
    }
}