namespace Task6;

class Program
{
    static void Main(string[] args)
    {
        List<TourBooking> tourBookings = new List<TourBooking>()
        {
            new TourBooking("Champak Lal Gada", "Paris", 25000, 7, true),
            new TourBooking("Seth Ji", "Tokyo", 4200, 10, false),
            new TourBooking("Thorphin", "New York", 15000, 5, true),
            new TourBooking("Tony Stark", "Bali", 4800, 6, true),
            new TourBooking("Edward Stone", "Sydney", 4000, 12, false),
            new TourBooking("Fiona Martin", "Dubai", 2200, 7, false),
            new TourBooking("George White", "London", 11000, 5, true),
            new TourBooking("Hannah Williams", "Singapore", 1600, 4, true),
            new TourBooking("Ian Brown", "Maldives", 3500, 8, false),
            new TourBooking("Julia Adams", "Los Angeles", 9700, 6, true)
        };

        var tourAboveTenK = tourBookings.Where(booking => booking.Price >= 10000);
        Console.WriteLine("Printing the list of customer whose order value is above Rs.10000");
        foreach (var booking in tourAboveTenK)
        {
            Console.WriteLine($"{booking.CustomerName} -- Rs.{booking.Price}");
        }

        var tourDurationFourMore = tourBookings.Where(booking => booking.DurationInDay > 4);
        Console.WriteLine("Printing the list of customer whose order value is above Rs.10000");
        foreach (var booking in tourDurationFourMore)
        {
            Console.WriteLine($"{booking.CustomerName} -- {booking.DurationInDay} Days");
        }

        
        var newTourBookingList = tourBookings.Select(booking => new
        {
            CustomerName = booking.CustomerName,
            Destination = booking.Destination,
            Category = booking.IsInternational ? "International" : "Domestic",
            Price = booking.Price
        });
        var sortedBooking = newTourBookingList
            .OrderBy(booking => booking.Category)
            .ThenBy(booking => booking.Price);
        
        Console.WriteLine("===== TOUR SUMMARY REPORT =====\n");

        foreach (var tour in sortedBooking)
        {
            Console.WriteLine($"Customer: {tour.CustomerName}");
            Console.WriteLine($"Destination: {tour.Destination}");
            Console.WriteLine($"Category: {tour.Category}");
            Console.WriteLine($"Price: Rs. {tour.Price}");
            Console.WriteLine("-----------------------------------");
        }

    }
}