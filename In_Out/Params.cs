using System;

class ParamsDemo
{
    static int AddNumbers(params int[] numbers)
    {
        int sum = 0;

        foreach (int n in numbers)
        {
            sum += n;
        }

        return sum;
    }

    static void Main()
    {
        int result1 = AddNumbers(10, 20);
        int result2 = AddNumbers(5, 10, 15, 20);

        Console.WriteLine("Sum1 = " + result1);
        Console.WriteLine("Sum2 = " + result2);
    }
}