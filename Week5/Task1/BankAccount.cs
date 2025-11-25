namespace Task1;

public class BankAccount(long accountNumber, double balance)
{
    private double balance = balance;

    public long AccountNumber { get; }

    public double Balance
    {
        get => balance;
        private set
        {
            if (value < 0)
            {
                throw  new ArgumentOutOfRangeException(nameof(value));
            }
            balance = value;
        }
    }

    public void Deposit(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Deposit Amount Cannot Be Zero or Negative");
            return;
        }

        balance += amount;
        Console.WriteLine($"Deposit Amount: {amount}");
        Console.WriteLine($"New Account Balance: {balance}");
    }

    public void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Withdraw Amount Cannot Be Zero or Negative");
            return;
        }

        if (amount > balance)
        {
            Console.WriteLine("Insufficient Balance in the Account");
            Console.WriteLine($"Current Account Balance: {balance}");
            return;
        }
        
        balance -= amount;
        Console.WriteLine("Amount Withdrawal Successful");
        Console.WriteLine($"Withdraw Amount: {amount}");
        Console.WriteLine($"New Account Balance: {balance}");
    }
}