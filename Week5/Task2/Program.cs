namespace Task2;

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car("BMW", 10, 4);
        car.Start();
        car.Stop();
        car.DisplayInfo();

        Motorcycle bike = new Motorcycle("Harley Davidson", 300, 600);
        // These Start and Stop method are from the base class -- Vehicle
        bike.Start();
        bike.Stop();
        bike.DisplayInfo();
    }
}