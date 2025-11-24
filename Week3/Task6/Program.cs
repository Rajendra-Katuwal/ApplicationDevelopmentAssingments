namespace Task6;

class Program
{
    public static void ConvertToInteger()
    {
        string nstr = Console.ReadLine();
        int n;

        try
        {
            n = Convert.ToInt32(nstr);
        }
        catch (Exception e)
        {
            Console.WriteLine("Invalid Number Format");
        }
        finally
        {
            Console.WriteLine("Program Executed");
        }
    }


    static void Password()
    {
        Console.Write("Enter a Password: ");
        string nstr = Console.ReadLine();

        if (nstr.Length < 6)
        {
            throw new Exception("Password must be at least 6 characters.");
        }
        else
        {
            Console.Write("Password requirement satisfied.");
        }
    }
    
    static void Main(string[] args)
    {
        ConvertToInteger();
     
        Password();
    }
}