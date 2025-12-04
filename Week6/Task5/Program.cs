using System;
using System.Collections.Generic;
using System.Linq;

namespace Task5;

public class CashierSales
{
    public string CashierName { get; set; }
    public decimal Sales { get; set; }
}

public class Applicant
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public class Music
{
    public string Title { get; set; }
    public int DurationSeconds { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Question 1
        List<CashierSales> salesList = new List<CashierSales>()
        {
            new CashierSales { CashierName = "A", Sales = 1500 },
            new CashierSales { CashierName = "B", Sales = 1200 },
            new CashierSales { CashierName = "C", Sales = 1800 },
            new CashierSales { CashierName = "D", Sales = 900 }
        };

        int totalCashiers = salesList.Count();
        decimal totalSales = salesList.Sum(s => s.Sales);
        decimal highestSales = salesList.Max(s => s.Sales);
        decimal lowestSales = salesList.Min(s => s.Sales);
        decimal averageSales = salesList.Average(s => s.Sales);

        Console.WriteLine("=== Aggregation Operators ===");
        Console.WriteLine($"Total Cashiers: {totalCashiers}");
        Console.WriteLine($"Total Sales: {totalSales}");
        Console.WriteLine($"Highest Sale: {highestSales}");
        Console.WriteLine($"Lowest Sale: {lowestSales}");
        Console.WriteLine($"Average Sale: {averageSales}");
        Console.WriteLine();


        // Question 2
        List<Applicant> applicants = new List<Applicant>()
        {
            new Applicant { Name = "John", Age = 20 },
            new Applicant { Name = "Rita", Age = 17 },
            new Applicant { Name = "Sam", Age = 25 }
        };

        bool anyUnder18 = applicants.Any(a => a.Age < 18);
        bool allAbove16 = applicants.All(a => a.Age > 16);

        Console.WriteLine("=== Quantifier Operators ===");
        Console.WriteLine($"Any applicant under 18? {anyUnder18}");
        Console.WriteLine($"Are all applicants above 16? {allAbove16}");
        Console.WriteLine();


        // Question 3
        List<Music> songs = new List<Music>()
        {
            new Music { Title = "Song A", DurationSeconds = 180 },
            new Music { Title = "Song B", DurationSeconds = 260 },
            new Music { Title = "Song C", DurationSeconds = 400 }
        };

        var firstSong = songs.First();
        var lastSong = songs.Last();
        var firstAbove4Min = songs.First(s => s.DurationSeconds > 240);
        var safeLongSong = songs.FirstOrDefault(s => s.DurationSeconds > 600);

        Console.WriteLine("=== Element Operators ===");
        Console.WriteLine($"First Song: {firstSong.Title}");
        Console.WriteLine($"Last Song: {lastSong.Title}");
        Console.WriteLine($"First song above 4 minutes: {firstAbove4Min.Title}");

        if (safeLongSong == null)
            Console.WriteLine("No song longer than 10 minutes.");
        else
            Console.WriteLine($"Song longer than 10 minutes: {safeLongSong.Title}");

        Console.WriteLine();
    }
}
