namespace Task3;

class Program
{
    public static void ProcessNumbers(int[] numbers, Func<int, bool> condition)
    {
        foreach (var num in numbers)
        {
            if (condition(num))
            {
                Console.WriteLine(num);
            }
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Even Numbers");
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 20, 44, 22 };
        ProcessNumbers(arr, n => n%2==0 );
        Console.WriteLine("");
        
        Console.WriteLine("Numbers greater than 10");
        ProcessNumbers(arr, n => n>10);
    }
}