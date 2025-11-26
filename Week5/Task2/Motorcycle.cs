namespace Task2;

public class Motorcycle(string brand, int speed, int cc) : Vehicle(brand, speed)
{
    private int _cc = cc;

    public void DisplayInfo()
    {
        Console.WriteLine($"Brand: {Brand}");
        Console.WriteLine($"Speed: {Speed}");
        Console.WriteLine($"CC: {_cc}cc");
    }
}