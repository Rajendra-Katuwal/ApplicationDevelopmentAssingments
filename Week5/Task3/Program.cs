namespace Task3;

class Program
{
    static void Main(string[] args)
    {
        Printer printer = new Printer();
        printer.Print("Hello World!");
        printer.Print(3);
        printer.Print("Bye World!", 5);
    }
}