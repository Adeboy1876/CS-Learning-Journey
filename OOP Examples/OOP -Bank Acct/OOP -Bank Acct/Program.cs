using System;

public class BankAccount
{
    // Properties
    public int AccountNumber { get; set; }
    public decimal Balance { get; private set; } // Balance is read -only outside the class
    public string AccountName { get; set; }


    //constructor
    public BankAccount(int accountNumber, decimal initialBalance, string accountName)
    {
        AccountNumber = accountNumber;
        Balance = initialBalance;
        AccountName = accountName;
    }

    //Deposit Method
    public void Deposit(decimal amount)
    {
        Balance += amount;
        Console.WriteLine($"{amount:C} deposited. New Balance: {Balance:C}.");
    }
    //Withdraw Method
    public void Withdraw(decimal amount)
    {
        Balance -= amount;
        Console.WriteLine($"{amount:C} withdrawn. New Balance: {Balance:C}");
    }

    //Account Summary
    public void AccountSummary()
    {
        Console.WriteLine($"Account Name: {AccountName}, Account Number: {AccountNumber}, Balance: {Balance:C}");
    }
    
}

public class Program
{
    public static void Main( string[] args)
    {
        BankAccount account = new BankAccount(12345678, 1000m, "Ademola O");

        account.AccountSummary();

        account.Deposit(1500);
        account.Withdraw(172);


        account.AccountSummary();
    }
}