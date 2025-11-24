namespace Task3;

class Program
{
    static void Main(string[] args)
    {
        string ageGroup;
        Console.Write("Enter your Age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age < 13)
        {
            ageGroup = "Child";
        }
        else if (age >= 13 && age <= 19)
        {
            ageGroup = "Teenager";
        }
        else if (age >= 20)
        {
            ageGroup = "Adult";
        }
        else
        {
            ageGroup = "Invalid Age Group";
        }
        
        Console.WriteLine($"You are in {ageGroup}.");
    }
}