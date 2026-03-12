using System;

class TryParse
{
    static void Main()
    {
        string input = "123";
        int number;

        bool success = int.TryParse(input, out number);

        if (success)
        {
            Console.WriteLine("successful");
            Console.WriteLine("Number = " + number);
        }
        else
        {
            Console.WriteLine("failed");
        }
    }
}