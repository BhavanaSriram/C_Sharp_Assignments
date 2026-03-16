using System;

public class Account
{
    private string accountNumber;
    private string name;
    private double balance;
    private string accountType;
    public Account(string name, double balance, string accountType)
    {
        this.accountNumber = GenerateAccountNumber();
        this.name = name;
        this.balance = balance;
        this.accountType = accountType;
    }
    private string GenerateAccountNumber()
    {
        Random r = new Random();
        return "IDBI" + r.Next(100000000, 999999999);
    }
    public string GetAccountNumber()
    {
        return accountNumber;
    }

    public double GetBalance()
    {
        return balance;
    }
    public void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine("Amount Deposited Successfully");
    }

    public void Withdraw(double amount)
    {
        if (balance - amount >= 500)
        {
            balance -= amount;
            Console.WriteLine("Withdrawal Successful");
        }
        else
        {
            Console.WriteLine("Minimum balance of 500 must be maintained");
        }
    }


    public void Display()
    {
        Console.WriteLine("Account Number: " + accountNumber);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Account Type: " + accountType);
        Console.WriteLine("Balance: " + balance);
    }
}