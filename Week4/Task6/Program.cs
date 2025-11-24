namespace Task6;

class Program
{
    private static void Main(string[] args)
    {
        int marks, total;
        
        Console.WriteLine("Enter integer value for marks: ");
        var marksStr = Console.ReadLine();
        
        Console.WriteLine("Enter integer value for total: ");
        var totalStr = Console.ReadLine();
        
        // Parsing both those values using the TryParse() function
        var markParseSuccess = int.TryParse(marksStr, out marks);
        var totalParseSuccess = int.TryParse(totalStr, out total);

        if (!markParseSuccess)
        {
            Console.WriteLine("Error while parsing the marks value entered by the user");
        }
        if (!totalParseSuccess)
        {
            Console.WriteLine("Error while parsing the total value entered by the user");
        }
        if (totalParseSuccess && markParseSuccess)
        {
            // this conversion will lose the decimal point values
            // double percentage =  marks / total * 100;
            // Console.WriteLine($"{percentage}%");100;
            
            // SO the fix is the below one
            double percentage = (double) marks / total * 100;
            Console.WriteLine($"{percentage}%");
        }

    }
}