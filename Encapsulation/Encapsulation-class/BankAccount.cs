public class BankAccount
{
    //Private attributes (hidden from outside)
    private double balance;

    //Constructor
    public BankAccount(double initialBalance)
    {
        balance = initialBalance;
    }

    //Public method to access private data
    public void Deposit(double amount)
    {
        if(amount > 0)
        {
            balance+=amount;
            Console.WriteLine($"Deposit {amount}. New Balance {balance}");
        }
        else
        {
            Console.WriteLine("Invalid deposit amount.");

        }
    }

    public void Withdrawal(double amount)
    {
        if(amount > 0 && amount <= balance)
        {
            balance-=amount;
            Console.WriteLine($"Withdrew {amount}. New Balance {balance}");
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount or unsufficient balance.");

        }
    }

    //Method to check balance (read-only access)
    public void CheckBalance()
    {
        Console.WriteLine($"Current Balance : {balance}");
    }

}