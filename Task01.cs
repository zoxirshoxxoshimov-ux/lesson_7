using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Square area: " + CalculateArea(5));
        Console.WriteLine("Rectangle area: " + CalculateArea(4, 6));
        Console.WriteLine("Triangle area: " + CalculateArea(8, 3, 2));
    }

    static double CalculateArea(double side)
    {
        return side * side;
    }

    static double CalculateArea(double length, double width)
    {
        return length * width;
    }

    static double CalculateArea(double baseValue, double height, double divisor)
    {
        return baseValue * height / divisor;
    }
}