using System;

interface IStudent
{
    void GetStudent();
}

interface ISports
{
    void GetSports();
}

class Result : IStudent, ISports
{
    public void GetStudent()
    {
        Console.WriteLine("Student Details");
    }

    public void GetSports()
    {
        Console.WriteLine("Sports Details");
    }

    public void Display()
    {
        Console.WriteLine("Result Calculated");
    }
}

class MultipleInheritanceDemo
{
    static void Main()
    {
        Result r = new Result();

        r.GetStudent();
        r.GetSports();
        r.Display();

        Console.ReadKey();
    }
}