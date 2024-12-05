using System;

public abstract class Shape
{
    
    public abstract double CalculateArea();
}

public class Circle : Shape
{
    public double Radius { get; set; }

    
    public Circle(double radius)
    {
        Radius = radius;
    }

    
    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius; 
    }
}

public class Square : Shape
{
    public double SideLength { get; set; }

    public Square(double sideLength)
    {
        SideLength = sideLength;
    }

    
    public override double CalculateArea()
    {
        return SideLength * SideLength; 
    }
}

class Program
{
    static void Main()
    {
        
        Shape circle = new Circle(5); 
        Shape square = new Square(4); 

        
        Console.WriteLine($"Pole koła: {circle.CalculateArea()}");
        Console.WriteLine($"Pole kwadratu: {square.CalculateArea()}");
    }
}
