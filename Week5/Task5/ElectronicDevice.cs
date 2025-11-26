namespace Task5;

public abstract class ElectronicDevice
{
    // Private fields
    private string brand;
    private double price;

    // Public properties (Encapsulation)
    public string Brand
    {
        get { return brand; }
        set { brand = value; }
    }

    public double Price
    {
        get { return price; }
        set { price = value; }
    }

    // Constructor
    public ElectronicDevice(string brand, double price)
    {
        Brand = brand;
        Price = price;
    }

    // Abstract method
    public abstract void ShowInfo();
}
