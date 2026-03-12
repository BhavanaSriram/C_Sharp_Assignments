using System;

class Program
{
    static void Main()
    {
        int num = 10;

        object obj = num;
        Console.WriteLine("Boxed value: " + obj);

        int n = (int)obj;
        Console.WriteLine("Unboxed value: " + n);
    }
}