using System;

sealed class Animal
{
    public void Show()
    {
        Console.WriteLine("This is sealed class");
    }
}

class SealedClassDemo
{
    static void Main()
    {
        Animal a = new Animal();
        a.Show();

        Console.ReadKey();
    }
}