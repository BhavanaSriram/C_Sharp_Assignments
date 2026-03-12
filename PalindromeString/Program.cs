using System;

namespace PalindromeString
{
    public class Class1
    {
        public static void Main(string[] args)
        {
            string str, rev = "";
            int i;
            Console.Write("Enter a string: ");
            str = Console.ReadLine();
            for (i = str.Length - 1; i >= 0; i--)
            {
                rev = rev + str[i];
            }
            if (str == rev)
            {
                Console.WriteLine("It is a Palindrome");
            }
            else
                Console.WriteLine("It is not a Palindrome");
        }
    }
}