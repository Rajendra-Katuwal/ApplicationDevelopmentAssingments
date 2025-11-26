namespace Task3;

public class Printer
{
    public void Print(string message)
    {
        Console.WriteLine($"Printing String: {message}");
    }

    public void Print(int number)
    {
        Console.WriteLine($"Printing Number: {number}");
    }

    public void Print(string message, int count)
    {
        for (var i = 0; i < count; i++)
        {
            Console.WriteLine($"Count {i}: {message}");
        }
    }

}