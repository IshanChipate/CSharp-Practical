using System;

[Obsolete("This method is outdated")]
class Demo
{
    public void Show()
    {
        Console.WriteLine("Old Method");
    }
}

class AttributeDemo
{
    static void Main()
    {
        Demo d = new Demo();
        d.Show();

        Console.ReadKey();
    }
}