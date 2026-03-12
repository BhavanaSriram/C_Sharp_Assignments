using System;

class Program1
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine(" pass numbers from command line.");
            return;
        }

        int count = args.Length;
        int sum = 0;
        int max = int.Parse(args[0]);
        int min = int.Parse(args[0]);

        for (int i = 0; i < args.Length; i++)
        {
            int num = int.Parse(args[i]);
            sum += num;

            if (num > max)
                max = num;

            if (num < min)
                min = num;
        }

        double avg = (double)sum / count;

        Console.WriteLine("Count = " + count);
        Console.WriteLine("Sum   = " + sum);
        Console.WriteLine("Avg   = " + avg);
        Console.WriteLine("Max   = " + max);
        Console.WriteLine("Min   = " + min);
    }
}