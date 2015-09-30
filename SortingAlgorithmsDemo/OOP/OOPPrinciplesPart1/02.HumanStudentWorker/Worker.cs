namespace _02.HumanStudentWorker
{
   public class Worker : Human
    {
       public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay) : base(firstName, lastName)
       {
           WeekSalary = weekSalary;
           WorkHoursPerDay = workHoursPerDay;
       }

       public decimal WeekSalary { get; set; }
       public int WorkHoursPerDay { get; set; }

       public decimal MoneyPerHour()
       {
           var workHoursPerWeek = 5*WorkHoursPerDay;
           var moneyPerHour = this.WeekSalary/workHoursPerWeek;
           
           return moneyPerHour;
       }

       public override string ToString()
       {
           return string.Format("{0} {1} - {2}", this.FirstName, this.LastName, this.MoneyPerHour());
       }
    }
}
