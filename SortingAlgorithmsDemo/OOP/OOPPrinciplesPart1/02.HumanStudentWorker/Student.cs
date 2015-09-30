namespace _02.HumanStudentWorker
{
    public class Student : Human
    {
        public Student(string firstName, string lastName, int grade) : base(firstName, lastName)
        {
            Grade = grade;
        }

        public int Grade { get; private set; }

        public override string ToString()
        {
            return string.Format("{0} {1} - {2} grade", this.FirstName, this.LastName, this.Grade);
        }
    }
}
