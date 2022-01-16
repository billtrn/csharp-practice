using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Bill", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} balance.");

            account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
            Console.WriteLine(account.Balance);
            account.MakeDeposit(100, DateTime.Now, "friend paid me back");
            Console.WriteLine(account.Balance);

            Console.WriteLine(account.GetAccountHistory());

            var account2 = new BankAccount("Nancy", 1000);
            Console.WriteLine($"Account {account2.Number} was created for {account2.Owner} with {account2.Balance} balance.");

            var account3 = new BankAccount("Foo", 1000);
            Console.WriteLine($"Account {account3.Number} was created for {account3.Owner} with {account3.Balance} balance.");
        }
    }
}