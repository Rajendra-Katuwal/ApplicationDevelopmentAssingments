namespace Task3;

public class ParameterDemo
{
    public void Increase(ref int number)
    {
        number += 10;
    }

    public void GetFullName(out string fullname)
    {
        Console.Write("Enter your fullname: ");
        fullname = Console.ReadLine();
    }

    public int SumAll(params int[] numbers)
    {
        int sumation = 0;
        foreach (var n in numbers)
        {
            sumation += n;
        }
        return sumation;
    }
}
