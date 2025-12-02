namespace Task2;

class Program
{
    
    // Question 1
    private delegate int Calculate(int a, int b);

    public static int Add(int a, int b) => a + b;
    public static int Subtract(int a, int b) => a - b;
    
    // Question 2
    public delegate double DiscountStrategy(double price);

    public static double FestivalDiscount(double price) =>  (price / 100) * 20;
    public static double SeasonalDiscount(double price) => (price / 100) * 10;
    public static double NoDiscount(double price) => price;

    // Question 2.1
    public static double CalculateFinalPrice(double originalPrice, DiscountStrategy strategy)
    {
        return originalPrice -  strategy(originalPrice);
    }

    
    static void Main(string[] args)
    {
        // Question 1 implementation
        Calculate cal;
        cal = Add;
        Console.WriteLine($"Addition: {cal(10, 20)}");
        
        cal = Subtract;
        Console.WriteLine($"Subtraction: {cal(50, 20)}");
        
        
        // Question 2.1 implementation
        var originalPrice = 500;
        DiscountStrategy strategy = FestivalDiscount;
        Console.WriteLine($"Final Price with Festival Discount: {CalculateFinalPrice(originalPrice,  strategy)}");
        
        strategy = SeasonalDiscount;
        Console.WriteLine($"Final Price with Seasonal Discount: {CalculateFinalPrice(originalPrice,  strategy)}");
        
        strategy = NoDiscount;
        Console.WriteLine($"Final Price with No Discount: {CalculateFinalPrice(originalPrice,  strategy)}");
        
        strategy = (double price) => (price / 100) * 30;
        Console.WriteLine($"Final Price with Custom 30% Discount: {CalculateFinalPrice(originalPrice, strategy)}");
    }
}   