using System;

class Number
{
    int num;

    public Number() : this(10)
    {
        Console.WriteLine("constructor1");
    }

    public Number(int n)
    {
        num = n;
        Console.WriteLine("constructor2");
    }

    public void Display()
    {
        Console.WriteLine("Number = " + num);
    }
}

class Program
{
    static void Main()
    {
        Number n = new Number();
        n.Display();
    }
}