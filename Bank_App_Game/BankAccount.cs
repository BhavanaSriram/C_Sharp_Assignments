using System;

class BankAccount
{
    public string AccountHolder;
    public double Balance;

    
    public BankAccount(string name, double balance)
    {
        AccountHolder = name;
        Balance = balance;
    }

    
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine(AccountHolder + " deposited " + amount);
        }
    }

    
    public void Withdraw(double amount)
    {
        if (amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine(AccountHolder + " withdrew " + amount);
        }
        else
        {
            Console.WriteLine(AccountHolder + " insufficient balance");
        }
    }

    
    public void Display()
    {
        Console.WriteLine(AccountHolder + " Balance = " + Balance);
    }
}