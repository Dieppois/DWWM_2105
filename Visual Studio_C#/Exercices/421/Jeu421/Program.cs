using System;
using ClassLibrary421;

namespace _421
{
    class Program
    {
        static void Main(string[] args)
        {
            String answer;

            Joueur joueur1 = new Joueur("Joueur 1");
            Joueur joueur2 = new Joueur("Joueur 2");
            De de1 = new De("de1");
            De de2 = new De("de2");
            De de3 = new De("de3");

            Console.WriteLine(de1);
            Console.WriteLine(de2); 
            Console.WriteLine(de3);
            de1.Jeter();
            de2.Jeter();
            de3.Jeter();



            // Donner une représentation textuel de toutes ses informations
            Console.Write("Voulez-vous voir le score des joueurs ? O/N : ");
            answer = Console.ReadLine();
            if (answer.ToLower().Equals("o"))
            {
                Console.WriteLine(joueur1);
                Console.WriteLine(joueur2);
            }






            Console.WriteLine("\n-------------------------------------------------------------------------------\n\n" +
                    "Appuyez sur une touche pour quitter le programme !");
            Console.ReadLine();
        }
    }
}
