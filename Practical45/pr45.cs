using System;

enum Days
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

class EnumDemo
{
    static void Main()
    {
        Days today = Days.Wednesday;

        Console.WriteLine("Today is: " + today);
        Console.WriteLine("Integer value: " + (int)today);

        Console.ReadKey();
    }
}