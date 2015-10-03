using System;

namespace NightlifeEntertainment
{
   public class StudentTicket:Ticket
    {
        public StudentTicket(IPerformance performancee)
            : base(performancee, TicketType.Student)
        {
        }

       protected override decimal CalculatePrice()
       {
           if (this.Performance == null)
           {
               throw new ArgumentException("The price cannot be calculated because there is no performance for this ticket.");
           }

           return this.Performance.BasePrice*0.8m;
       }
    }
}
