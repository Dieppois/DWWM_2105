using System;
using ClassLibraryFraction;

namespace ConsoleAppFraction
{
    class Program
    {
        static void Main(string[] args)
        {
            String answer;
            Fraction f1 = new Fraction(120, -150);
            Fraction f2 = new Fraction();
            Fraction f3 = new Fraction(9);

            f1.Reduire();
            f1.Inverse();


            // Donner une représentation textuel de toutes ses informations
            Console.Write("Voulez-vous afficher les fractions ? O/N : ");
            answer = Console.ReadLine();
            if (answer.ToLower().Equals("o"))
            {
                Console.WriteLine(f1);
                Console.WriteLine(f3);
                Console.WriteLine(f2);

            }



            Console.WriteLine("\n-------------------------------------------------------------------------------\n\n" +
                "Appuyez sur une touche pour quitter le programme !");
            Console.ReadLine();
        }
    }
}
