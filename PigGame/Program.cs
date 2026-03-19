using System;

class Program
{
    static void Main()
    {
        int totalScore = 0;
        int turns = 0;
        Random rand = new Random();

        while (totalScore < 20)
        {
            int turnScore = 0;
            turns++;
            Console.WriteLine("Turn " + turns + " begins");

            while (true)
            {
                Console.Write("Roll or Hold? (r/h): ");
                string choice = Console.ReadLine().ToLower();

                if (choice == "r")
                {
                    int roll = rand.Next(1, 7);
                    Console.WriteLine("You rolled: " + roll);

                    if (roll == 1)
                    {
                        turnScore = 0;
                        Console.WriteLine("Turn over, no points earned");
                        break;
                    }
                    else
                    {
                        turnScore += roll;
                        Console.WriteLine("Turn score: " + turnScore);
                    }
                }
                else if (choice == "h")
                {
                    totalScore += turnScore;
                    Console.WriteLine("Total score: " + totalScore);
                    break;
                }
            }
        }

        Console.WriteLine("You reached 20 points in " + turns + " turns");
    }
}