using System;

namespace Theatre
{
    public class Performance : IComparable<Performance>
    {
        public Performance(string theatreName, string performanceTitle, DateTime startDate, TimeSpan duration, decimal price)
        {
            this.TheatreName = theatreName;
            this.PerformanceTitle = performanceTitle;
            this.StartDate = StartDate;
            this.Duration = duration;
            this.Price = price;
        }

        public string TheatreName { get; private set; }
        public string PerformanceTitle { get; private set; }
        public DateTime StartDate { get; set; }
        public TimeSpan Duration { get; private set; }
        protected internal decimal Price { get; protected set; }

        int IComparable<Performance>.CompareTo(Performance otherPerformance)
        {
            return this.StartDate.CompareTo(otherPerformance.StartDate);
        }

        public override string ToString()
        {
            string result =
                string.Format("Performance(Theatre name: {0}; performance title: {1}; start date: {2}, duration: {3}, price: {4})",
                this.TheatreName,
                this.PerformanceTitle,
                this.StartDate.ToString("dd.MM.yyyy HH:mm"), this.Duration.ToString("hh':'mm"), this.Price.ToString("f2"));
            return result;
        }
    }
}
