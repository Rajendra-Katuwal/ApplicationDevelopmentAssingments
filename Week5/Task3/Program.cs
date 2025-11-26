namespace  Task3;

class Program
{
    static void Main(string[] args)
    {
        Printer printer = new Printer();
        printer.Print("Hello World!");
        printer.Print(3);
        printer.Print("Bye World!", 5);
        
        
        NepaliTeacher nepaliTeacher = new NepaliTeacher();
        nepaliTeacher.Name = "Ram";
        Console.WriteLine($"Name: {nepaliTeacher.Name}");
        nepaliTeacher.Teaching();
        nepaliTeacher.SalaryInfo();

        Console.WriteLine();

        EnglishTeacher englishTeacher = new EnglishTeacher();
        englishTeacher.Name = "John";
        Console.WriteLine($"Name: {englishTeacher.Name}");
        englishTeacher.Teaching();   // Uses base class implementation
        englishTeacher.SalaryInfo();
    }
}