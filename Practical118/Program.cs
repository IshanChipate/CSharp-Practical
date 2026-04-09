using System;

interface IMessage
{
    void Send();
}

class EmailService : IMessage
{
    public void Send()
    {
        Console.WriteLine("Email Sent");
    }
}

class Notification
{
    private IMessage message;

    public Notification(IMessage msg)
    {
        message = msg;
    }

    public void Notify()
    {
        message.Send();
    }
}

class DependencyInjectionDemo
{
    static void Main()
    {
        IMessage msg = new EmailService();
        Notification notification = new Notification(msg);

        notification.Notify();

        Console.ReadKey();
    }
}