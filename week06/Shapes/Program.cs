using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        Square square1 = new Square("blue", 5);
        Console.WriteLine($"Color:{square1.GetColor()}, Area:{square1.GetArea()}");

        Rectangle rectangle1 = new Rectangle("red", 4, 6);
        Console.WriteLine($"Color:{rectangle1.GetColor()}, Area:{rectangle1.GetArea()}");

        Circle circle1 = new Circle("green", 3);
        Console.WriteLine($"Color:{circle1.GetColor()}, Area:{circle1.GetArea()}");

        List<Shape> shapes = new List<Shape>();

        shapes.Add(square1);
        shapes.Add(rectangle1);
        shapes.Add(circle1);

        foreach(Shape shape in shapes)
        {
            Console.WriteLine($"The {shape.GetColor()} color has an Area of {shape.GetArea()}");
        }

    }
}