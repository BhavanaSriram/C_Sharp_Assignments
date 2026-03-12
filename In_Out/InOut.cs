using System;

class InOut
{
    static void ShowNumber(in int num)
    {
        Console.WriteLine("Value received using 'in' parameter: " + num);
    }
    static void GetSquare(int x, out int result)
    {
        result = x * x;
    }

    static void Main()
    {
        int a = 10;
        ShowNumber(a);
        int square;
        GetSquare(5, out square);

        Console.WriteLine("Square is: " + square);
    }
}