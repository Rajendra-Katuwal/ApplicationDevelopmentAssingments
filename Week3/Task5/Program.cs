namespace Task5;

class Program
{
    static void PrintSumOfNumbers()
    {
        Console.WriteLine("Enter a number to find the sumation upto that number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int sumation = 0;
        
        for (int i = 1; i <= n; i++)
        {
            sumation += i;
        }
        
        Console.WriteLine($"Sum of numbers upto {n} is {sumation}.");
    }

    static void PrintNumbersUpto()
    {
        Console.WriteLine("Printing numbers between 1 and 20 inclusive: ");
        int n = 1;

        while (n <= 20)
        {
            Console.WriteLine(n);
            n++;
        }
    }

    static int PrintSumationArray(int[] arr)
    {
        int summation = 0;
        foreach (var n in arr)
        {
            summation += n;
        }

        return summation;
    }
    
    static void Main(string[] args)
    {
        PrintSumOfNumbers();
        PrintNumbersUpto();
        
        int[] numbers = {2,5,6,8,10,22,66};
        PrintSumationArray(numbers);
    }
}