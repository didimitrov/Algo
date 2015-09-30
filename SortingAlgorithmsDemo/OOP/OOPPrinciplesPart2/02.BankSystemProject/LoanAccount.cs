using System;

namespace _02.BankSystemProject
{
    public class LoanAccount : Account, IDepositable
    {
        private int _loanPeriod;

        public LoanAccount(CustomerType customer, decimal balance, int interestRate, int loanPeriod) 
            : base(customer, balance, interestRate)
        {
            this.LoanPeriod = loanPeriod;
        }

        public int LoanPeriod
        {
            get { return _loanPeriod; }
            set
            {
                if (value <= 0M)
                {
                    throw new ArgumentOutOfRangeException("Loan period can't be zero or negative!");
                }
                _loanPeriod = value;
            }
        }

        public override decimal CalculateInterestAmount()
        {
            if (this.Customer==CustomerType.Individuals && this.LoanPeriod<=3)
            {
                return 0M;
            }
            if (this.Customer==CustomerType.Companies && LoanPeriod<=2)
            {
                return 0M;
            }

            return InterestRate * LoanPeriod;
        }

        public void Deposit(decimal moneyToDeposit)
        {
            if (moneyToDeposit < 0)
            {
                throw new ArgumentOutOfRangeException("Cant deposit negative sum!");
            }

            Balance = Balance + moneyToDeposit;
        }
    }
}
