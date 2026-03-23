class Program
{
    static void Main()
    {
        SpecialEvent s = new SpecialEvent(1, "Royal Hall", 100, 50, 5000);
        Console.WriteLine("Total Earnings: " + s.CalculateEarning());
    }
}