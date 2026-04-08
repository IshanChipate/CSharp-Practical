using System;

class DateTimeDemo
{
    static void Main()
    {
        DateTime now = DateTime.Now;

        Console.WriteLine("Current Date and Time: " + now);
        Console.WriteLine("Date: " + now.Date);
        Console.WriteLine("Time: " + now.TimeOfDay);
        Console.WriteLine("Day: " + now.Day);
        Console.WriteLine("Month: " + now.Month);
        Console.WriteLine("Year: " + now.Year);
        Console.WriteLine("Day of Week: " + now.DayOfWeek);

        Console.ReadKey();
    }
}