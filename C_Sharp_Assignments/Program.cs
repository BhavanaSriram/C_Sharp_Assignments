using System;

namespace Reverse_number
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            int rev = 0;

            while (num > 0)
            {
                int digit = num % 10;
                rev = rev * 10 + digit;
                num = num / 10;
            }

            Console.WriteLine("Reverse number is: {0}", rev);
        }
    }
}