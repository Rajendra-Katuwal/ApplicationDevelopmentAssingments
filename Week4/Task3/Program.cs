using Task3;

class Program
{
    static void Main(string[] args)
    {
        ParameterDemo pd = new ParameterDemo();

        // ref keyword indicates that the parameter is passed by reference
        int value = 5;
        Console.WriteLine("Original value: " + value);
        pd.Increase(ref value);
        Console.WriteLine("Value after Increase(ref): " + value);

        // out keyword indicates that the parameter will be initialized inside the method
        string fullName;  // only declaring not initializing for out
        pd.GetFullName(out fullName);
        Console.WriteLine("Your fullname is: " + fullName);

        int total = pd.SumAll(2, 4, 6, 8, 10);
        Console.WriteLine("Sum of all numbers: " + total);
    }
}
