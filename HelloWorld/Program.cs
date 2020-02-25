using System;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ecrire dans la console "Hello World!"
            Console.WriteLine("Hello World!");

            // Ecrire dans la console ...
            Console.WriteLine("My name is Andrés. Type your age.");

            // Stocker dans une variable de type "int", la valeur saisie dans la console
            int age = int.Parse(Console.ReadLine());

            /* Concaténer l'age avec une phrase */
            Console.WriteLine("I'm " + age + " years old.");
        }
    }
}
