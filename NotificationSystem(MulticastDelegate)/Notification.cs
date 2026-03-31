using System;

public class Notification
{
    public delegate void Notify(string message);

    public static void SendEmail(string message)
    {
        Console.WriteLine("Email: " + message);
    }

    public static void SendSMS(string message)
    {
        Console.WriteLine("SMS: " + message);
    }

    public static void SendWhatsApp(string message)
    {
        Console.WriteLine("WhatsApp: " + message);
    }
}