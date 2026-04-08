using System;
using System.Text;

class StringBuilderDemo
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();

        sb.Append("Hello");
        sb.Append(" ");
        sb.Append("World");

        Console.WriteLine("After Append: " + sb);

        sb.Insert(6, "C# ");
        Console.WriteLine("After Insert: " + sb);

        sb.Replace("World", "Programming");
        Console.WriteLine("After Replace: " + sb);

        sb.Remove(6, 3);
        Console.WriteLine("After Remove: " + sb);

        Console.ReadKey();
    }
}