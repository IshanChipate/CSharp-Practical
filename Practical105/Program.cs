using System;

class Animal
{
    public virtual void Sound()
    {
        Console.WriteLine("Animal makes sound");
    }
}

class Dog : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Dog barks");
    }
}

class MethodOverridingDemo
{
    static void Main()
    {
        Animal a = new Animal();
        a.Sound();

        Animal d = new Dog();
        d.Sound();

        Console.ReadKey();
    }
}