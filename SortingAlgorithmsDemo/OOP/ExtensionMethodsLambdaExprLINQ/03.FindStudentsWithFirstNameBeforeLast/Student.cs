namespace _03.FindStudentsWithFirstNameBeforeLast
{
   public class Student
    {
       
       public string FirstName { get; set; }
       public string LastName { get; set; }

       public Student(string firsName, string lastName)
       {
           FirstName = firsName;
           LastName = lastName;
       }
    }
}
