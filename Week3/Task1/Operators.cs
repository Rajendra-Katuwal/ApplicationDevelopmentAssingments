namespace Task1;

public class Operators
{
    // Takes two integer parameters and prints out their sumation.
    public void Add(int a, int b)
    {
        int su = a + b;
        Console.WriteLine($"{a} + {b} = {su}");
    }

    // Takes two int parameters and prints out the subtraction of b from a.
    public void Subtract(int a, int b)
    {
        int sub = a - b;
        Console.WriteLine($"{a} - {b} = {sub}");
    }

    // Takes two integer parameters and prints out their multiplication
    public void Multiply(int a, int b)
    {
        int mul = a * b;
        Console.WriteLine($"{a} * {b} = {mul}");
    }

    // Takes two integer parameters and prints out the division of a from b;
    public void Divide(int a, int b)
    {
        int div = a / b;
        Console.WriteLine($"{a} / {b} = {div}");
    }
    
    // Takes an integer and prints if the number is Odd or Even
    public void OddEvenFinder(int n)
    {
        string s = n % 2 == 0 ? "Even Number" : "Odd Number";
        Console.WriteLine(s);
    }

}