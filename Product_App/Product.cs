using System;

class Product
{
    public int Id;
    public string Name;
    public double Price;
    public double DiscountPercentage;
    public Product(int id, string name, double price, double discount)
    {
        Id = id;
        Name = name;
        Price = price;
        DiscountPercentage = discount;
    }
    public double GetPriceAfterDiscount()
    {
        double discountAmount = Price * DiscountPercentage / 100;
        return Price - discountAmount;
    }
    public void Display()
    {
        Console.WriteLine("Product Id: " + Id);
        Console.WriteLine("Product Name: " + Name);
        Console.WriteLine("Actual Price: " + Price);
        Console.WriteLine("Discount %: " + DiscountPercentage);
        Console.WriteLine("Price After Discount: " + GetPriceAfterDiscount());
        Console.WriteLine();
    }
}