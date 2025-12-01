using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("red", 12);
        Console.WriteLine(square.GetColor());
        Console.WriteLine(square.GetArea());

        Rectangle rectangle = new Rectangle("green", 5, 6);
        Console.WriteLine(rectangle.GetColor());
        Console.WriteLine(rectangle.GetArea());

        Circle circle = new Circle("blue", 3);
        Console.WriteLine(circle.GetColor());
        Console.WriteLine(circle.GetArea());
    }
}