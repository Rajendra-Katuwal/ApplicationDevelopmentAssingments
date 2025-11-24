namespace Task1;

public class Student
{
    public string? name;
    public int age;
    public DateTime joined_at;
    public static string course = "BIT";

    public Student(){}
    public Student(string name, int age, DateTime joined_at)
    {
        this.name = name;
        this.age = age;
        this.joined_at = joined_at;
    }
}
