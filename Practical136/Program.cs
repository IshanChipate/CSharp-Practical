using System;

delegate void Notify();

class Process
{
    public event Notify OnProcessCompleted;

    public void StartProcess()
    {
        Console.WriteLine("Process Started...");
        Console.WriteLine("Process Completed");

        OnProcessCompleted?.Invoke();
    }
}

class EventDemo
{
    static void Main()
    {
        Process p = new Process();

        p.OnProcessCompleted += Message;

        p.StartProcess();

        Console.ReadKey();
    }

    static void Message()
    {
        Console.WriteLine("Event Received: Process Finished");
    }
}