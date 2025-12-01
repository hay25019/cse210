using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = [];
        Square square = new Square("red", 12);
        Rectangle rectangle = new Rectangle("green", 5, 6);
        Circle circle = new Circle("blue", 3);
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}