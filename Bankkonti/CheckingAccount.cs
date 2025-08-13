namespace Bank
{
    class CheckingAccount : BankAccount
    {
        public CheckingAccount(string accountNumber, decimal initialBalance) : base(accountNumber, initialBalance) { }

        public override void Withdraw(decimal amount)
        {
            if (Balance - amount >= -500)
            {
                Balance -= amount;
                Console.WriteLine($"{AccountNumber}: Withdrew {amount}, new balance {Balance}");
            }
            else
            {
                Console.WriteLine($"{AccountNumber}: Withdrawal denied, overdraft limit exceeded.");
            }
        }
    }
}
