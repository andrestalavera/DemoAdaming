using System;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ecrire dans la console "Hello World!"
            Console.WriteLine("Hello World! Type your first name.");

            string firstName = Console.ReadLine();

            // Ecrire dans la console ...
            Console.WriteLine("My name is " + firstName + ". Type your age.");

            string ageS = Console.ReadLine();

            // Stocker dans une variable de type "int", la valeur saisie dans la console
            int age = int.Parse(ageS);

            /* Concaténer l'age avec une phrase */
            Console.WriteLine("I'm " + age + " years old.");
        }
    }
}
