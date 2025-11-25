namespace Task1;

class Program
{
    static void Main(string[] args)
    {
        BankAccount bankaccount = new(20251125, 1000);
        Console.WriteLine($"Bank Account Number: {bankaccount.AccountNumber}");
        
        bankaccount.Deposit(10000);
        bankaccount.Withdraw(5600);
        
        Console.WriteLine($"Remaining Balance: {bankaccount.Balance}");
    }
}