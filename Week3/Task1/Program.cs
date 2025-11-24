namespace Task1;


class Program
{
    static void Main(string[] args)
    {
        Operators op = new Operators();
        op.Add(1, 2);
        op.Subtract(50, 22);
        op.Multiply(10, 20);
        op.Divide(10, 20);
        
        op.OddEvenFinder(21);
    }
}