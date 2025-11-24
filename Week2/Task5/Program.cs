DateTime DoB = new DateTime (2004, 12, 02);

DateTime currDateTime = DateTime.Now;

TimeSpan ageSpan = currDateTime - DoB;


Console.WriteLine ($"My date of birth is: {DoB.ToShortDateString()}");
Console.WriteLine ($"Current date is: {currDateTime.ToShortDateString()}");
Console.WriteLine($"My age in years is: {ageSpan.Days/365} years");

DateTime tenDayAdditionDOB = DoB.AddDays(10);
Console.WriteLine ($"Date after adding ten days to my DOB is: {tenDayAdditionDOB.ToShortDateString()}");


