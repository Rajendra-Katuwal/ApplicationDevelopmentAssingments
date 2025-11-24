namespace Task1;

class Program
{
    static void Main(string[] args)
    {
        Student std1 = new("Rajendra Katuwal", 20, DateTime.Now);
        Student std2 = new("Ram Bahadur Ghanashyam", 30, DateTime.Now);

        Console.WriteLine("+============================================+");
        Console.WriteLine("Instance Fields");
        Console.WriteLine("+============================================+");
        Console.WriteLine("Student Object-1 (std1)");
        Console.WriteLine($"std1.name = {std1.name}");
        Console.WriteLine($"std1.age = {std1.age}");
        Console.WriteLine($"std1.joined_at = {std1.joined_at}");
        Console.WriteLine("+--------------------------------------------+");
        Console.WriteLine("Student Object-2 (std2)");
        Console.WriteLine($"std2.name = {std2.name}");
        Console.WriteLine($"std2.age = {std2.age}");
        Console.WriteLine($"std2.joined_at = {std2.joined_at}");
        Console.WriteLine("+============================================+\n\n");
        
        Console.WriteLine("+============================================+");
        Console.WriteLine("Static Field");
        Console.WriteLine("+============================================+");
        Console.WriteLine($"Student.course = {Student.course}");
        Console.WriteLine("+============================================+");
    }
}