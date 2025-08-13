namespace Bank
{
    class SavingsAccount : BankAccount
    {
        public SavingsAccount(string accountNumber, decimal initialBalance) : base(accountNumber, initialBalance) { }

        public override void Withdraw(decimal amount)
        {
            if (Balance - amount >= 100)
                base.Withdraw(amount);
            else
                Console.WriteLine($"{AccountNumber}: Withdrawal denied, minimum balance 100 required.");
        }

        public void ApplyInterest()
        {
            decimal interest = Balance * 0.02m;
            Balance += interest;
            Console.WriteLine($"{AccountNumber}: Interest added {interest}, new balance {Balance}");
        }
    }
}
