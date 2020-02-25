using System;

namespace GuestList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Person[] people = new Person[10];

            people[0] = new Person();
            people[0].FirstName = "Bertrand";
            people[0].LastName = "David";
            people[0].BirthDate = new DateTime(1980, 01, 02);

            people[1] = new Person();
            people[1].FirstName = "Lucie";
            people[1].LastName = "Ehrstein";
            people[1].BirthDate = new DateTime(1984, 01, 02);

            people[2] = new Person();
            people[2].FirstName = "Camille";
            people[2].LastName = "Le Fouler";
            people[2].BirthDate = new DateTime(1982, 01, 02);

            people[9] = new Person();
            people[9].FirstName = "Eric";
            people[9].LastName = "Bouzoubaa";
            people[9].BirthDate = new DateTime(1982, 01, 02);

            //for (int i = 3; i < 10; i++)
            //{
            //    people[i] = new Person();
            //    people[i].FirstName = "Toto";
            //    people[i].LastName = "Foo";
            //    people[i].BirthDate = new DateTime(1970, 4, 4);
            //}

            Console.WriteLine("for");
            for (int i = 0; i < people.Length; i++)
            {
                if (people[i] == null)
                {
                    continue;
                }
                Console.WriteLine(people[i]);

                //  // OU
                //  if (people[i] != null)
                //  {
                //      Console.WriteLine(people[i]);
                //  }
            }

            Console.WriteLine("foreach");
            foreach (Person person in people)
            {
                if (person == null)
                {
                    continue;
                }
                Console.WriteLine(person);
            }

            Console.WriteLine("do while");
            int iDo = 0;
            do
            {
                if (people[iDo] != null)
                {
                    Console.WriteLine(people[iDo]);
                }
                iDo++;
            } while (iDo < people.Length);

            Console.WriteLine("while");
            int iWhile = 0;
            while (iWhile < people.Length)
            {
                if (people[iWhile] != null)
                {
                    Console.WriteLine(people[iWhile]);
                }
                iWhile++;
            }
        }
    }

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName + " " + BirthDate;
        }
    }
}
