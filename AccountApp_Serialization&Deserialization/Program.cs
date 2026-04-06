using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace AccountApp
{
    public class Account
    {
        public int AccountId { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "accounts.json";

            // Create list of accounts
            List<Account> accounts = new List<Account>()
            {
                new Account { AccountId = 1, Name = "Ram", Balance = 5000 },
                new Account { AccountId = 2, Name = "sita", Balance = 7000 }
            };

            // serialization
            string jsonData = JsonSerializer.Serialize(accounts);
            File.WriteAllText(filePath, jsonData);
            Console.WriteLine("Data Serialized and Saved to File\n");

            // deserialization
            string readData = File.ReadAllText(filePath);
            List<Account> result = JsonSerializer.Deserialize<List<Account>>(readData);

            Console.WriteLine("Deserialized Data:\n");

            foreach (var acc in result)
            {
                Console.WriteLine($"Id: {acc.AccountId}, Name: {acc.Name}, Balance: {acc.Balance}");
            }
        }
    }
}