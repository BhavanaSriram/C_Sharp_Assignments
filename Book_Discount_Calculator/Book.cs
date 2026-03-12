using System;

class Book
{
    public string Title;
    public string Author;
    public double Price;
    public bool IsBestseller;
    public Book(string title, string author, double price, bool isBestseller)
    {
        Title = title;
        Author = author;
        Price = price;
        IsBestseller = isBestseller;
    }

    
    public double CalculateDiscountedPrice()
    {
        double finalPrice = Price;

        if (IsBestseller)
        {
            finalPrice = finalPrice - (finalPrice * 0.10);
        }

        if (Price > 500)
        {
            finalPrice = finalPrice - (finalPrice * 0.05);
        }

        return finalPrice;
    }

    public void Display()
    {
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author: " + Author);
        Console.WriteLine("Original Price: " + Price);
        Console.WriteLine("Final Price: " + CalculateDiscountedPrice());
        Console.WriteLine();
    }
}