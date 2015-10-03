using System;

namespace NightlifeEntertainment
{
    class VipTicket:Ticket
    {
        public VipTicket(IPerformance performance) 
            : base(performance, TicketType.VIP)
        {
        }
        protected override decimal CalculatePrice()
        {
            if (this.Performance == null)
            {
                throw new ArgumentException("The price cannot be calculated because there is no performance for this ticket.");
            }

            return this.Performance.BasePrice * 1.5m;
        }
    }
}
