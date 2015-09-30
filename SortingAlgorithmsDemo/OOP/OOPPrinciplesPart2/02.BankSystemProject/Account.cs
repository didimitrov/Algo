using System;

namespace _02.BankSystemProject
{
    public abstract class Account
    {
        private CustomerType _customer;
        private decimal _balance;
        private int _interestRate;

        protected Account(CustomerType customer, decimal balance, int interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public CustomerType Customer
        {
            get { return _customer; }
           protected set { _customer = value; }
        }

        public decimal Balance
        {
            get { return _balance; }
            set
            {
                if (value<0M)
                {
                    throw new ArgumentOutOfRangeException("Balance in account can not be negative number!");
                }
                _balance = value;
            }
        }

        public int InterestRate
        {
            get { return _interestRate; }
            set
            {
                if (value < 0M)
                {
                    throw new ArgumentOutOfRangeException("Interest rate can not be negative number!");
                }
                _interestRate = value;
            }
        }

        public abstract decimal CalculateInterestAmount();
    }
}
