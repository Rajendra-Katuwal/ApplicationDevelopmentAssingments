namespace Task2;

public class Car(string brand, int speed, int seats) : Vehicle(brand, speed)
{
    private int seats;
    public void DisplayInfo()
    {
        Console.WriteLine($"Brand: {Brand}");
        Console.WriteLine($"Speed: {Speed}");
        Console.Write($"Seats: {seats}");
    }
};