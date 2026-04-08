using System;

class Sample
{
    private int[] arr = new int[5];

    public int this[int index]
    {
        get
        {
            return arr[index];
        }
        set
        {
            arr[index] = value;
        }
    }
}

class IndexerDemo
{
    static void Main()
    {
        Sample s = new Sample();

        s[0] = 10;
        s[1] = 20;
        s[2] = 30;
        s[3] = 40;
        s[4] = 50;

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Value at index " + i + " = " + s[i]);
        }

        Console.ReadKey();
    }
}