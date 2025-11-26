public class Vehicle
{
    public string Brand { get; }
    public int Speed { get; }

    public Vehicle(string brand, int speed)
    {
        Brand = brand;
        Speed = speed;
    }

    public void Start()
    {
        Console.WriteLine($"{Brand} is starting...");
    }

    public void Stop()
    {
        Console.WriteLine($"{Brand} is stopping...");
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Brand: {Brand}");
        Console.WriteLine($"Speed: {Speed}");
    }
}