using System;

namespace _03.Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. Dogs, frogs and cats are Animals. All animals can produce sound (specified by the ISound interface). Kittens and tomcats are cats. All animals are described by age, name and sex. Kittens can be only female and tomcats can be only male. Each animal produces a specific sound. Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).

            Dog[] dogs =
            {   
                new Dog(5, "pesho", 'M'),
                new Dog(6, "gosho", 'M'), 
                new Dog(14, "mariq", 'F') 
            };

            //use static method from class Animal
            Console.WriteLine("Dogs average age : {0}", Animal.AvgAge(dogs));
            dogs[0].Sound();
            Console.WriteLine();

            //use lambda expression
            //double averageDogsAge = dogs.Average(x => x.Age);
            //Console.WriteLine(averageDogsAge);

            Kitten[] kittens = 
            {
                new Kitten(10, "Djeni"),
                new Kitten(2, "Ani"),
                new Kitten(3, "Mimi")
            };

            Console.WriteLine("Kittens average age : {0}", Animal.AvgAge(kittens));
            kittens[0].Sound();
            Console.WriteLine();

            //use lambda expression
            //double averageKittensAge = kittens.Average(x => x.Age);
            //Console.WriteLine(averageKittensAge);

            Frog[] frogs =
            {
                new Frog(1, "firstFrog", 'F'),
                new Frog(2, "secondFrog", 'M')
            };

            Console.WriteLine("Frogs average age : {0}", Animal.AvgAge(frogs));
            frogs[0].Sound();
            Console.WriteLine();

            //use lambda expression
            //double averageFrogsAge = frogs.Average(x => x.Age);
            //Console.WriteLine(averageFrogsAge);

            Tomcat[] tomcats = 
            {
                new Tomcat(19, "Rex"),
                new Tomcat(7, "Jack"),
                new Tomcat(3, "Danny")
            };

            Console.WriteLine("Tomcats average age : {0}", Animal.AvgAge(tomcats));
            tomcats[0].Sound();
            Console.WriteLine();

            //use lambda expression
            //double averageTomcatsAge = tomcats.Average(x => x.Age);
            //Console.WriteLine(averageTomcatsAge);
        }
    }
}
