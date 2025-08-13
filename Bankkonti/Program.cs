using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount savings = new SavingsAccount("SA001", 500);
            BankAccount checking = new CheckingAccount("CA001", 200);

            savings.Withdraw(450);
            checking.Withdraw(600);

            ((SavingsAccount)savings).ApplyInterest();
        }
    }
}
