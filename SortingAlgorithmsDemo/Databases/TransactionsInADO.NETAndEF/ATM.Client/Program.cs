using System;
using System.Linq;
using System.Transactions;
using ATM.Data;
using ATM.Models;
using IsolationLevel = System.Data.IsolationLevel;

namespace ATM.Client
{
    class Program
    {
        public static bool WithdrawMoney(int pin, int cardNumber, decimal moneyToWithdraw, ApplicationDbContext context)
        {
            var transactionScope = new TransactionScope(
               TransactionScopeOption.RequiresNew,
               new TransactionOptions()
               {
                   IsolationLevel = (System.Transactions.IsolationLevel) IsolationLevel.RepeatableRead
               });

            using (transactionScope)
            {
                var card = context.CardAccounts.FirstOrDefault(c => c.CardNumber == cardNumber);

                var isPinValid = card != null && card.CardPin == pin;
                var isAmountValid = card.CardCash >= moneyToWithdraw;

                if (isAmountValid && isPinValid )
                {
                    card.CardCash -= moneyToWithdraw;
                    transactionScope.Complete();
                }
                else
                {
                    return false;
                }
            }

            AddTransactionToHistory(cardNumber, moneyToWithdraw, context);

            context.SaveChanges();
            return true;
        }

        private static void AddTransactionToHistory(int cardNumber, decimal moneyToWithdraw, ApplicationDbContext context)
        {
            var transactionScope = new TransactionScope(
               TransactionScopeOption.RequiresNew,
               new TransactionOptions()
               {
                   IsolationLevel = (System.Transactions.IsolationLevel) IsolationLevel.RepeatableRead
               });

            using (transactionScope)
            {
                context.TransactionHistories.Add(new TransactionHistory()
                {
                    TransactionDate = DateTime.Now,
                    Ammount = moneyToWithdraw,
                    CardNumber = cardNumber
                });

                transactionScope.Complete();
            }
        }

        private static void PrintAllCards()
        {
            using (var context = new ApplicationDbContext())
            {
                foreach (var card in context.CardAccounts)
                {
                    Console.WriteLine("ID:{0} -> Money: {1}", card.Id, card.CardCash);
                }
            }
        }
        static void Main(string[] args)
        {
            var atmContext = new ApplicationDbContext();
            atmContext.Database.Initialize(true);

            PrintAllCards();

            using (atmContext)
            {
                // for invalid data try with different pin, cardNumber and moneyToWithdraw to use that nothing happens
                int pin = 1111;
                int cardNumber = 1234567890;
                decimal moneyToWithdraw = 200M;

                if (WithdrawMoney(pin, cardNumber, moneyToWithdraw, atmContext))
                {
                    Console.WriteLine("\nMoney withdrawn\n");
                }
                else
                {
                    Console.WriteLine("\nCan not withdraw money.\n");
                }
            }

            PrintAllCards();
        }
    }
}
