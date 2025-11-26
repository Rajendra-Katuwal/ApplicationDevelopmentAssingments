namespace Task5;

class Program
{
    static void Main(string[] args)
    {
        // Create store
        ElectronicsStore store = new ElectronicsStore();

        // Create devices
        Laptop laptop = new Laptop("Dell", 1500.00);
        Smartphone phone = new Smartphone("Samsung", 999.99);

        // Add to store
        store.AddDevice(laptop);
        store.AddDevice(phone);

        // Show all details
        store.ShowAllDeviceDetails();
    }
}
