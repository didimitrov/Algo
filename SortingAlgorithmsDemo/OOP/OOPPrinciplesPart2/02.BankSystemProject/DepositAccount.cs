using System;

namespace _02.BankSystemProject
{
    public class DepositAccount:Account, IDepositable,IWithDrawable
    {
        private int _depositPeriod;

        public DepositAccount(CustomerType customer, decimal balance, int interestRate, int depositPeriod) : base(customer, balance, interestRate)
        {
            this.DepositPeriod = depositPeriod;
        }

        public int DepositPeriod
        {
            get { return _depositPeriod; }
            set
            {
                if (value <= 0M)
                {
                    throw new ArgumentOutOfRangeException("Deposit period can't be zero or negative!");
                }
                _depositPeriod = value;
            }
        }

        public void Deposit(decimal moneyToDeposit)
        {
            if (moneyToDeposit<0)
            {
                throw new ArgumentOutOfRangeException("Cant deposit negative sum!");
            }

            Balance = Balance + moneyToDeposit;
        }

        public void WithDraw(decimal moneyToWithDraw)
        {
            if (moneyToWithDraw < 0)
            {
                throw new ArgumentOutOfRangeException("Cant withdraw negative sum!");
            }
            if (Balance<moneyToWithDraw)
            {
                throw new ArgumentOutOfRangeException("Not enoght balance");
            }
            Balance = Balance - moneyToWithDraw;
        }

        public override decimal CalculateInterestAmount()
        {
            if (this.Balance > 0M && this.Balance < 1000M)
            {
                return 0M;
            }
            return InterestRate*DepositPeriod;
        }
    }
}
