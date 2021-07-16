using System;
using ClassLibraryJeu421;
namespace ConsoleAppJeu421
{
    class Program
    {
        static void Main(string[] args)
        {

//jetez les des
            //jeu commence

            Console.WriteLine("Jeu 421 commence");
            Partie partie1 = new Partie();
            Console.WriteLine("Vous êtes le Joueur 1. Le Joueur 2 est l'ordinateur");
            Manche manche1 = new Manche();
            Console.WriteLine("Lancez les des ?");
            bool d1 = true;
            bool d2 = true;
            bool d3 = true;
            manche1.Lancer(d1, d2, d3);
            Console.ReadLine();
        }
    }
}
