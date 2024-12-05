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

public interface IVehicle
{
    
    void Start();

    
    void Stop();

    
    int MaxSpeed { get; }
}

public class Car : IVehicle
{
    public int MaxSpeed { get; private set; }
    public string Brand { get; set; }

    
    public Car(int maxSpeed, string brand)
    {
        MaxSpeed = maxSpeed;
        Brand = brand;
    }

    
    public void Start()
    {
        Console.WriteLine("Samochód uruchomiony.");
    }

    
    public void Stop()
    {
        Console.WriteLine("Samochód zatrzymany.");
    }

    
    public void Honk()
    {
        Console.WriteLine("Samochód trąbi!");
    }
}

public class Bike : IVehicle
{
    public int MaxSpeed { get; private set; }
    public bool HasBell { get; set; }

    
    public Bike(int maxSpeed, bool hasBell)
    {
        MaxSpeed = maxSpeed;
        HasBell = hasBell;
    }

    
    public void Start()
    {
        Console.WriteLine("Rower ruszył.");
    }

    
    public void Stop()
    {
        Console.WriteLine("Rower zatrzymany.");
    }

    
    public void RingBell()
    {
        if (HasBell)
        {
            Console.WriteLine("Dzwonek rowerowy dzwoni!");
        }
        else
        {
            Console.WriteLine("Rower nie ma dzwonka.");
        }
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

        
        IVehicle car = new Car(200, "Toyota");
        IVehicle bike = new Bike(30, true);

        
        car.Start();
        Console.WriteLine($"Maksymalna prędkość samochodu: {car.MaxSpeed} km/h");
        ((Car)car).Honk(); 

        bike.Start();
        Console.WriteLine($"Maksymalna prędkość roweru: {bike.MaxSpeed} km/h");
        ((Bike)bike).RingBell(); 
    }
}


