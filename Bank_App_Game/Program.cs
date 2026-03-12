using System;

class Program
{
    static void Main()
    {
        Random r = new Random();

        BankAccount acc1 = new BankAccount("Jack", r.Next(500, 1000));
        BankAccount acc2 = new BankAccount("jill", r.Next(500, 1000));

        Console.WriteLine("Starting Balances");
        acc1.Display();
        acc2.Display();
        Console.WriteLine();

        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine("Round " + i);

            int amount1 = r.Next(100, 300);
            int amount2 = r.Next(100, 300);

            acc1.Deposit(amount1);
            acc2.Withdraw(amount2);

            Console.WriteLine();
        }

        Console.WriteLine("Final Balances");
        acc1.Display();
        acc2.Display();

        Console.WriteLine();

        if (acc1.Balance > acc2.Balance)
            Console.WriteLine(acc1.AccountHolder + " Wins!");
        else if (acc2.Balance > acc1.Balance)
            Console.WriteLine(acc2.AccountHolder + " Wins!");
        else
            Console.WriteLine("Game Draw!");
    }
}