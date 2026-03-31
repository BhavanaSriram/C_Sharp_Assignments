using System;

class Program
{
    static void Main()
    {
        Notification.Notify notify = Notification.SendEmail;

        notify += Notification.SendSMS;
        notify += Notification.SendWhatsApp;

        Console.WriteLine("First Notification:");
        notify("Hello User");

        notify -= Notification.SendSMS;

        Console.WriteLine("After Removing SMS:");
        notify("Hello Again");
    }
}