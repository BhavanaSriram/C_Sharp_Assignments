using System;

class Program
{
    static void Main()
    {
        int[] fees = new int[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter fees " + (i + 1) + ": ");
            fees[i] = Convert.ToInt32(Console.ReadLine());

            while (fees[i] < 5000 || fees[i] > 10000)
            {
                Console.WriteLine("Invalid, enter fees between 5000 and 10000");
                fees[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        fees = Discount(fees);

        Console.WriteLine("Fee after discount");

        foreach (int f in fees)
        {
            Console.WriteLine(f);
        }
    }

    static int[] Discount(int[] fees)
    {
        for (int i = 0; i < fees.Length; i++)
        {
            if (fees[i] > 7000)
            {
                fees[i] = fees[i] - (fees[i] * 5 / 100);
            }
        }
        return fees;
    }
}