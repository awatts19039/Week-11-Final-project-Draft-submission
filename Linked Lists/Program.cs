// See https://aka.ms/new-console-template for more information

using System;

class BankAccount {
    public string AccountNumber;
    public string AccountHolder;
    public decimal Balance;

    public BankAccount(string accountNumber, string accountHolder, decimal balance) {
        AccountNumber = accountNumber;
        AccountHolder = accountHolder;
        Balance = balance;
    }
}

class BankTracker {
    private LinkedList<BankAccount> accounts = new LinkedList<BankAccount>();

    public void AddAccount(string accountNumber, string accountHolder, decimal balance) {
        BankAccount account = new BankAccount(accountNumber, accountHolder, balance);
        accounts.AddLast(account);
    }

    public void PrintAllAccounts() {
        Console.WriteLine("All Bank Accounts:");
        foreach (BankAccount account in accounts) {
            Console.WriteLine("{0} - {1} - {2:C}", account.AccountNumber, account.AccountHolder, account.Balance);
        }
    }

    public void PrintAccountDetails(string accountNumber) {
        foreach (BankAccount account in accounts) {
            if (account.AccountNumber == accountNumber) {
                Console.WriteLine("Account Details:");
                Console.WriteLine("Account Number: {0}", account.AccountNumber);
                Console.WriteLine("Account Holder: {0}", account.AccountHolder);
                Console.WriteLine("Account Balance: {0:C}", account.Balance);
                return;
            }
        }
        Console.WriteLine("Account with Account Number {0} not found", accountNumber);
    }

    public void Deposit(string accountNumber, decimal amount) {
        foreach (BankAccount account in accounts) {
            if (account.AccountNumber == accountNumber) {
                account.Balance += amount;
                Console.WriteLine("{0:C} deposited to Account Number {1}", amount, accountNumber);
                return;
            }
        }
        Console.WriteLine("Account with Account Number {0} not found", accountNumber);
    }

    public void Withdraw(string accountNumber, decimal amount) {
        foreach (BankAccount account in accounts) {
            if (account.AccountNumber == accountNumber) {
                if (account.Balance >= amount) {
                    account.Balance -= amount;
                    Console.WriteLine("{0:C} withdrawn from Account Number {1}", amount, accountNumber);
                } else {
                    Console.WriteLine("Insufficient balance in Account Number {0}", accountNumber);
                }
                return;
            }
        }
        Console.WriteLine("Account with Account Number {0} not found", accountNumber);
    }
}

class Program {
    static void Main(string[] args) {
        BankTracker bank = new BankTracker();
        bank.AddAccount("1234567890", "John Smith", 1000);
        bank.AddAccount("2345678901", "Jane Doe", 2000);
        bank.PrintAllAccounts();
        bank.Deposit("1234567890", 500);
        bank.Withdraw("2345678901", 1000);
        bank.PrintAccountDetails("1234567890");
        bank.PrintAccountDetails("2345678901");
    }
}

