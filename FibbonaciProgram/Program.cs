using System;
namespace FibonacciProgram
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter number: ");
            int n = int.Parse(Console.ReadLine());
            int a = 0, b = 1;

            for (int i = 1; i < n; i++)
            {
                Console.Write(a + " ");
                int c = a + b;
                a = b;
                b = c;
            }
        }
    }
}