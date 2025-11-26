namespace Task5;

using System.Collections.Generic;

public class ElectronicsStore
{
    private List<ElectronicDevice> devices = new List<ElectronicDevice>();

    public void AddDevice(ElectronicDevice device)
    {
        devices.Add(device);
        Console.WriteLine($"{device.Brand} added to store.");
    }

    public void RemoveDevice(ElectronicDevice device)
    {
        devices.Remove(device);
        Console.WriteLine($"{device.Brand} removed from store.");
    }

    public void ShowAllDeviceDetails()
    {
        Console.WriteLine("\n--- Device Details in Store ---");

        foreach (var device in devices)
        {
            device.ShowInfo(); // Polymorphism

            // Downcasting for child specific methods
            if (device is Laptop laptop)
            {
                laptop.TurnOnBattery();
            }
            else if (device is Smartphone smartphone)
            {
                smartphone.EnableCamera();
            }

            Console.WriteLine();
        }
    }
}
