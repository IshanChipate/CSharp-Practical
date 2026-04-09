using System;
using System.Collections;

class StackQueueDemo
{
    static void Main()
    {
        Stack stack = new Stack();

        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        Console.WriteLine("Stack elements:");
        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }

        Queue queue = new Queue();

        queue.Enqueue(100);
        queue.Enqueue(200);
        queue.Enqueue(300);

        Console.WriteLine("\nQueue elements:");
        foreach (var item in queue)
        {
            Console.WriteLine(item);
        }

        Console.ReadKey();
    }
}