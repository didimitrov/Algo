using System;

namespace _03.Animals
{
   public class Tomcat : Animal
    {
       public Tomcat( int age,string name) : base(name, age, 'M')
       {
       }

       public override void Sound()
       {
           Console.WriteLine("tomcat make sound");
       }
    }
}
