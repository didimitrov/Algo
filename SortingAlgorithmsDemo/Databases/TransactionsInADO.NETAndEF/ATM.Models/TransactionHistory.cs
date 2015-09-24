using System;

namespace ATM.Models
{
    public class TransactionHistory
    {
        public int TransactionHistoryId { get; set; }

        public int CardNumber { get; set; }

        public DateTime TransactionDate { get; set; }

        public decimal Ammount { get; set; }
    }
}
