using System.Collections.Generic;

namespace NightlifeEntertainment
{
   public class Opera:Venue
    {
        public Opera(string name, string location, int numberOfSeats)
            : base(name, location, numberOfSeats, new List<PerformanceType>(){PerformanceType.Opera, PerformanceType.Theatre})
        {
        }
    }
}
