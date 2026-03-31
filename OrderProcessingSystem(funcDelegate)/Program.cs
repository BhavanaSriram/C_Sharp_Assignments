using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter product price:");
        double price = Convert.ToDouble(Console.ReadLine());

        Func<double, double> calculateDiscount = p =>
        {
            if (p > 1000)
                return p * 0.15;
            else
                return p * 0.05;
        };

        Func<double, double, double> calculateFinalPrice = (p, d) => p - d;

        double discount = calculateDiscount(price);
        double finalPrice = calculateFinalPrice(price, discount);

        Console.WriteLine("Discount: " + discount);
        Console.WriteLine("Final Price: " + finalPrice);
    }
}