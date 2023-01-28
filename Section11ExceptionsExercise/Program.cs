using Section11ExceptionsExercise.Entities;
using Section11ExceptionsExercise.Entities.Exception;

try
{
    Console.WriteLine("Enter account data\r\n");
    Console.Write("Number: ");
    int number = int.Parse(Console.ReadLine());

    Console.Write("Holder: ");
    string holder = Console.ReadLine();

    Console.Write("Initial balance: ");
    double balance = double.Parse(Console.ReadLine());

    Console.Write("Withdraw limit: ");
    double withdrawLimit = double.Parse(Console.ReadLine());

    Account account = new Account(number, holder, balance, withdrawLimit);

    Console.WriteLine();
    Console.Write("Enter amount for withdraw: ");
    double amount = double.Parse(Console.ReadLine());
    account.Withdraw(amount);
    Console.WriteLine("New Balance: " + account.Balance);
}
catch (DomainException e)
{
    Console.WriteLine("Unexpected error: " + e.Message);
}