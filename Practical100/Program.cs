using System;

class MemoryDemo
{
    class Sample
    {
        public Sample()
        {
            Console.WriteLine("Object Created");
        }

        ~Sample()
        {
            Console.WriteLine("Object Destroyed");
        }
    }

    static void Main()
    {
        Sample obj1 = new Sample();
        Sample obj2 = new Sample();

        obj1 = null;
        obj2 = null;

        GC.Collect();
        GC.WaitForPendingFinalizers();

        Console.WriteLine("Garbage Collection Completed");

        Console.ReadKey();
    }
}