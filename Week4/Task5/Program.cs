namespace Task5;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter today day of the week: ");
        string? day = (Console.ReadLine() ?? "Sunday").ToLower();
        if (day == "friday" || day == "saturday")
        {
            Console.WriteLine($"It is: {DayType.Weekend}");
        }
        else
        {
            Console.WriteLine($"It is: {DayType.Weekday}");
            
        }

        Book book1 = new Book("Ikigai", "F. Scott Fitzgerald", 10.99);
        
        Book book2 = new Book("Rich Dad Poor Dad", "F. Scott Fitzgerald", 10.99);
        book2 = book2 with { title = "Atomic Habits", price = 12.99 };
        Console.WriteLine($"Book Details: Title - {book1.title}, Author - {book1.author}, Price - ${book1.price}");

        var (title, author, price) = book2;
        Console.WriteLine($"Book Details: Title - {title}, Author - {author}, Price - ${price}");
    }
}