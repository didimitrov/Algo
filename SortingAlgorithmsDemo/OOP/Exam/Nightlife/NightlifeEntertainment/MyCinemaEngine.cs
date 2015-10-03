using System;
using System.Linq;

namespace NightlifeEntertainment
{
    internal class MyCinemaEngine : CinemaEngine
    {
        protected override void ExecuteInsertVenueCommand(string[] commandWords)
        {
            switch (commandWords[2])
            {
                case "cinema":
                    var cinema = new Cinema(commandWords[3], commandWords[4], int.Parse(commandWords[5]));
                    this.Venues.Add(cinema);
                    break;
                case "opera":
                    var opera = new Opera(commandWords[3], commandWords[4], int.Parse(commandWords[5]));
                    this.Venues.Add(opera);
                    break;
                case "sports_hall":
                    var sportsHall = new SportsHall(commandWords[3], commandWords[4], int.Parse(commandWords[5]));
                    this.Venues.Add(sportsHall);
                    break;
                case "concert_hall":
                    var concertHall = new ConcertHall(commandWords[3], commandWords[4], int.Parse(commandWords[5]));
                    Venues.Add(concertHall);
                    break;
                default:
                    base.ExecuteInsertVenueCommand(commandWords);
                    break;
            }

        }

        protected override void ExecuteInsertPerformanceCommand(string[] commandWords)
        {
            switch (commandWords[2])
            {
                case "movie":
                    var venue = this.GetVenue(commandWords[5]);
                    var movie = new Movie(commandWords[3], decimal.Parse(commandWords[4]), venue,
                        DateTime.Parse(commandWords[6] + " " + commandWords[7]));
                    this.Performances.Add(movie);
                    break;
                case "theater":
                    venue = this.GetVenue(commandWords[5]);
                    var theater = new Theatre(commandWords[3], decimal.Parse(commandWords[4]), venue,
                        DateTime.Parse(commandWords[6] + " " + commandWords[7]));
                    Performances.Add(theater);
                    break;
                case "concert":
                    venue = this.GetVenue(commandWords[5]);
                    var concert = new Concert(commandWords[3], decimal.Parse(commandWords[4]), venue,
                        DateTime.Parse(commandWords[6] + " " + commandWords[7]));
                    break;
                default:
                    base.ExecuteInsertPerformanceCommand(commandWords);
                    break;
            }
        }

        protected override void ExecuteSupplyTicketsCommand(string[] commandWords)
        {
            var venue = this.GetVenue(commandWords[2]);
            var performance = this.GetPerformance(commandWords[3]);
            switch (commandWords[1])
            {
                case "regular":
                    for (int i = 0; i < int.Parse(commandWords[4]); i++)
                    {
                        performance.AddTicket(new RegularTicket(performance));
                    }

                    break;
                case "student":
                    for (int i = 0; i < int.Parse(commandWords[4]); i++)
                    {
                        performance.AddTicket(new StudentTicket(performance));
                    }

                    break;
                case "vip":
                    for (int i = 0; i < int.Parse(commandWords[4]); i++)
                    {
                        performance.AddTicket(new VipTicket(performance));
                    }

                    break;
                default:
                    base.ExecuteSupplyTicketsCommand(commandWords);
                    break;
            }
        }

        protected override void ExecuteReportCommand(string[] commandWords)
        {
            var performance = GetPerformance(commandWords[1]);

            this.Output.AppendFormat(
                "{0}: {1} ticket(s), total: ${2:0.00}",
                performance.Name,
                performance.Tickets.Count(x => x.Status == TicketStatus.Sold),
                performance.Tickets.Where(x => x.Status == TicketStatus.Sold).Sum(x => x.Price)).AppendLine();
            this.Output.AppendFormat("Venue: {0} ({1})", performance.Venue.Name, performance.Venue.Location)
                .AppendLine();
            this.Output.AppendFormat("Start time: {0}", performance.StartTime).AppendLine();
        }

        protected override void ExecuteSellTicketCommand(string[] commandWords)
        {
            var performance = this.GetPerformance(commandWords[1]);
            var type = (TicketType) Enum.Parse(typeof (TicketType), commandWords[2], true);
            this.Output.Append(performance.SellTicket(type));
        }

        protected override void ExecuteFindCommand(string[] commandWords)
        {
            var dt = DateTime.Parse(commandWords[2] + " " + commandWords[3]);

            var foundPerforms =
                this.Performances.Where(p => (p.StartTime >= dt && p.Name.ToLower().Contains(commandWords[1].ToLower())))
                    .OrderBy(p => p.StartTime)
                    .ThenByDescending(p => p.BasePrice)
                    .ThenBy(p => p.Name)
                    .Select(p => p.Name);

            this.Output.AppendFormat("Search for \"{0}\"", commandWords[1]).AppendLine();
            this.Output.Append("Performances:").AppendLine();

            if (!foundPerforms.Any())
            {
                this.Output.Append("no results").AppendLine();
            }
            else
            {
                this.Output.Append("-").Append(string.Join("\n-", foundPerforms)).AppendLine();
            }

            var venues =
                this.Venues.Where(v => v.Name.ToLower().Contains(commandWords[1].ToLower())).OrderBy(v => v.Name);
            this.Output.Append("Venues:").AppendLine();

            if (!venues.Any())
            {
                this.Output.Append("no results").AppendLine();
            }
            else
            {
                foreach (var v in venues)
                {
                    this.Output.AppendFormat("-{0}", v.Name).AppendLine();

                    var sumPerf =
                        this.Performances.Where(p => p.StartTime >= dt && p.Venue.Name == v.Name)
                            .OrderBy(p => p.StartTime)
                            .ThenByDescending(p => p.BasePrice)
                            .ThenBy(p => p.Name)
                            .Select(p => p.Name);

                    foreach (var per in sumPerf)
                    {
                        this.Output.AppendFormat("--{0}", per).AppendLine();
                    }
                }
            }
        }
    }
}
