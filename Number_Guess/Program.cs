using System;

namespace Number_Guess
{
    public class Class1
    {
        public static void Main(string[] args)
        {
            char choice;

            do
            {
                Random r = new Random();
                int number = r.Next(1, 101);
                int guess = 0;
                int count = 0;

                Console.WriteLine("Guess the number between 1 and 100");

                while (guess != number)
                {
                    Console.Write("Enter your guess: ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    count++;

                    if (guess < number)
                    {
                        Console.WriteLine("Sorry, Too Low");
                    }
                    else if (guess > number)
                    {
                        Console.WriteLine("Sorry, Too High");
                    }
                    else
                    {
                        Console.WriteLine("Correct Guess");
                        Console.WriteLine("Total tries: " + count);
                    }
                }

                Console.Write("Do you want to play again (y/n): ");
                choice = Convert.ToChar(Console.ReadLine().ToLower());

            } while (choice == 'y');
        }
    }
}