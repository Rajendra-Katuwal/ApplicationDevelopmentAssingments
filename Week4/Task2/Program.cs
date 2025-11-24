namespace Task2;

class Program
{
    static void Main(string[] args)
    {
        Calculator cal = new();
        int add_result = cal.Add(20, 44);
        int multiply_result = cal.Multiply(4, 88);

        cal.PrintWelcome();
        Console.WriteLine($"Addition Result: {add_result}");
        Console.WriteLine($"Multiplication Result: {multiply_result}");
    }
}