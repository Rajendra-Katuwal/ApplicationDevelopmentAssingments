namespace Task6;

public class TourBooking(string customerName, string destination, double price, int durationInDay, Boolean isInternational)
{
    public string CustomerName { get; set; } = customerName;
    public string Destination { get; set; } = destination;
    public double Price { get; set; } = price;
    public int DurationInDay { get; set; } = durationInDay;
    public bool IsInternational { get; set; } = isInternational;
}