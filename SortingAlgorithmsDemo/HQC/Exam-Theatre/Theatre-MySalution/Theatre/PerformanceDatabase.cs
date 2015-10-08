using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using Theatre.Contracts;
using Theatre.Exceptions;

namespace Theatre
{
    public class PerformanceDatabase : IPerformanceDatabase
    {
        private readonly SortedDictionary<string, SortedSet<Performance>> _theatrePerformances =
            new SortedDictionary<string, SortedSet<Performance>>();

        public void AddTheatre(string name)
        {
            if (!this._theatrePerformances.ContainsKey(name))
            {
                throw new DuplicateTheatreException("Duplicate theatre");
            }

            this._theatrePerformances[name] = new SortedSet<Performance>();
        }

       public IEnumerable<string> ListTheatres()
        {
            return this._theatrePerformances.Keys;
            
        }

      public void AddPerformance(string theatreName, string performanceTitle, DateTime date, TimeSpan duration, decimal price)
        {
            if (!this._theatrePerformances.ContainsKey(theatreName))
            {
                throw new TheatreNotFoundException("Theatre does not exist");
            }

            var performancePerTheatre = this._theatrePerformances[theatreName];
            var endTime = date + duration;
            if (PerformanceOverlap(performancePerTheatre, date, endTime))
            {
                throw new TimeDurationOverlapException("Time/duration overlap");
            }

            var performance = new Performance(theatreName, performanceTitle, date, duration, price);
            performancePerTheatre.Add(performance);
        }

        public IEnumerable<Performance> ListAllPerformances()
        {
            var theatres = this._theatrePerformances.Keys;
            var performancesPerTheatre = new List<Performance>();
            foreach (var t in theatres)
            {
                var performances = this._theatrePerformances[t];
                performancesPerTheatre.AddRange(performances);
            }

            return performancesPerTheatre;
        }

        public IEnumerable<Performance> ListPerformances(string theatreName)
        {
            if (!this._theatrePerformances.ContainsKey(theatreName))
            {
                throw new TheatreNotFoundException("Theatre does not exist");
            }
            return this._theatrePerformances[theatreName];
        }

        private static bool PerformanceOverlap( IEnumerable<Performance> performances, DateTime starTime, DateTime endTime)
        {
            foreach (var p in performances)
            {
                var performanceStart = p.StartDate;
                var performanceEnd = p.StartDate + p.Duration;

                var overlap =
                    (performanceStart <= starTime && starTime <= performanceEnd) 
                    || (performanceStart <= endTime && endTime <= performanceEnd)
                    || (starTime <= performanceStart && performanceStart <= endTime)
                    || (starTime <= performanceEnd && performanceEnd <= endTime);
                if (overlap)
                {
                    return true;
                }
            }
            return false;
        }
    }

}
