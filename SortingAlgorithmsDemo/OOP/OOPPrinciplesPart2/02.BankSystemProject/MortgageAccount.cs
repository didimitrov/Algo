using System;

namespace _02.BankSystemProject
{
    public class MortgageAccount : Account, IDepositable
    {
        private int _morgePeriod;

        public MortgageAccount(CustomerType customer, decimal balance, int interestRate, int morgePeriod)
            : base(customer, balance, interestRate)
        {
            this.MorgePeriod = morgePeriod;
        }

        public int MorgePeriod
        {
            get { return _morgePeriod; }
            set
            {
                if (value <= 0M)
                {
                    throw new ArgumentOutOfRangeException("Loan period can't be zero or negative!");
                }
                _morgePeriod = value;
            }
        }

        public override decimal CalculateInterestAmount()
        {
            if (Customer==CustomerType.Companies && MorgePeriod<=12)
            {
                return (InterestRate * MorgePeriod)/2;
            }
            if (Customer==CustomerType.Individuals && MorgePeriod<=6)
            {
                return 0M;
            }
            return InterestRate*MorgePeriod;
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
