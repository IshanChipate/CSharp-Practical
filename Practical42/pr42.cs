using System;

class DaysConversion
{
    static void Main()
    {
        int days, years, months, remainingDays;

        Console.Write("Enter number of days: ");
        days = Convert.ToInt32(Console.ReadLine());

        years = days / 365;
        days = days % 365;

        months = days / 30;
        remainingDays = days % 30;

        Console.WriteLine("Years = " + years);
        Console.WriteLine("Months = " + months);
        Console.WriteLine("Days = " + remainingDays);

        Console.ReadKey();
    }
}