using System;
using System.Diagnostics;
using System.Text;

class PerformanceDemo
{
    static void Main()
    {
        Stopwatch sw = new Stopwatch();

        sw.Start();
        string str = "";
        for (int i = 0; i < 10000; i++)
        {
            str += i;
        }
        sw.Stop();
        Console.WriteLine("String Time: " + sw.ElapsedMilliseconds + " ms");

        sw.Reset();

        sw.Start();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < 10000; i++)
        {
            sb.Append(i);
        }
        sw.Stop();
        Console.WriteLine("StringBuilder Time: " + sw.ElapsedMilliseconds + " ms");

        Console.ReadKey();
    }
}