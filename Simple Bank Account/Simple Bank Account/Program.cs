using System;

namespace Simple_Bank_Account
{
    internal class Program
    {
        static double balance = 0;

        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nWelcome to Mello Bank!");
                Console.WriteLine("1 - Check Balance");
                Console.WriteLine("2 - Deposit");
                Console.WriteLine("3 - Withdraw");
                Console.WriteLine("4 - Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ShowBalance();
                        break;
                    case "2":
                        Deposit();
                        break;
                    case "3":
                        Withdraw();
                        break;
                    case "4":
                        exit = true;
                        Console.WriteLine("Thank you for using Mello Bank!");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }

        static void ShowBalance()
        {
            Console.WriteLine($"Your current balance is: {balance} AZN");
        }

        static void Deposit()
        {
            Console.Write("Enter amount to deposit: ");
            if (double.TryParse(Console.ReadLine(), out double amount) && amount > 0)
            {
                balance += amount;
                Console.WriteLine($"{amount} AZN deposited successfully.");
            }
            else
            {
                Console.WriteLine("Invalid amount.");
            }
        }

        static void Withdraw()
        {
            Console.Write("Enter amount to withdraw: ");
            if (double.TryParse(Console.ReadLine(), out double amount) && amount > 0)
            {
                if (amount <= balance)
                {
                    balance -= amount;
                    Console.WriteLine($"{amount} AZN withdrawn successfully.");
                }
                else
                {
                    Console.WriteLine("Insufficient balance.");
                }
            }
            else
            {
                Console.WriteLine("Invalid amount.");
            }
        }
    }
}
