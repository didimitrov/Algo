using System;

namespace _02.BankSystemProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Account[] accounts = new Account[]
            {
                new DepositAccount(CustomerType.Individuals, 1000M, 4, 12),
                new DepositAccount(CustomerType.Companies, 10000M, 10, 24),

                new LoanAccount(CustomerType.Companies, 5000M, 1, 10),
                new LoanAccount(CustomerType.Individuals, 560M, 2, 4),

                new MortgageAccount(CustomerType.Individuals, 6500M, 6, 14),
                new MortgageAccount(CustomerType.Individuals, 1300M, 4, 11)
            };

            foreach (Account account in accounts)
            {
                Console.WriteLine("{0} interest amount -> {1}", account.GetType().Name, account.CalculateInterestAmount());
            }

            DepositAccount depositAccount = new DepositAccount(CustomerType.Individuals, 1000M, 3, 6);
            depositAccount.Deposit(1000M);
            depositAccount.WithDraw(1900M);

            Console.WriteLine(depositAccount.Balance);

            LoanAccount loanAccount = new LoanAccount(CustomerType.Companies, 1500M, 5, 10);
            loanAccount.Deposit(440.5M);

            Console.WriteLine(loanAccount.Balance);

            MortgageAccount mortgageAccount = new MortgageAccount(CustomerType.Individuals, 100M, 1, 1);
            mortgageAccount.Deposit(5000M);

            Console.WriteLine(mortgageAccount.Balance);
        }
    }
}
