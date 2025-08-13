namespace Bank
{
    class BankAccount
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; protected set; }

        public BankAccount(string accountNumber, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"{AccountNumber}: Deposited {amount}, new balance {Balance}");
        }

        public virtual void Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"{AccountNumber}: Withdrew {amount}, new balance {Balance}");
            }
            else
            {
                Console.WriteLine($"{AccountNumber}: Withdrawal denied, insufficient funds.");
            }
        }
    }
}
