class Circle
{
    public const double PI = 3.14;

    public double calculateArea(double radius)
    {
        double area = PI * radius * radius;
        return area;
    }

    public double calculatePerimeter(double radius)
    {
        double circumference = 2 * PI * radius;
        return circumference;
    }
}


class Program
{
    static void Main()
    {
        // Error: Cannot assign to 'PI' because it is a 'const'
        Circle.PI = 3.888;
    }
}