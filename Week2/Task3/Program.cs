class Program
{

    byte b = 255; // Byte 
    short s = 32767; // Short 
    int i  = 2147483647; // Int 
    long l = 123456789L; // Long 
    double d = 3.14;
    float f = 3.14F; // Float 
    decimal dec = 19.99M; // Decimal


    static int val = 42;
    String st = val.ToString();

    static String strr = "3.14";
    double pi = double.Parse(strr);



    static void Main(string[] args)
    {
        // print all the variables in the console with appropriate labeles showing their types and values
        Program p = new Program();
        Console.WriteLine($"Byte: {p.b}");
        Console.WriteLine($"Short: {p.s}");
        Console.WriteLine($"Int: {p.i}");
        Console.WriteLine($"Long: {p.l}");
        Console.WriteLine($"Double: {p.d}");
        Console.WriteLine($"Float: {p.f}");
        Console.WriteLine($"Decimal: {p.dec}");
        Console.WriteLine($"Static Int: {val}");
        Console.WriteLine($"String from Int: {p.st}");
        Console.WriteLine($"Double from String: {p.pi}");
    }
}