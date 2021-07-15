using System;
using ClassLibraryJeu421;
namespace ConsoleAppJeu421
{
    class Program
    {
        static void Main(string[] args)
        {
            De de1 = new De();
            De de2 = new De();
            De de3 = new De();

            Joueurs joueur1 = new Joueurs("Joueur1");
            Joueurs joueur2 = new Joueurs("Joueur2");

            //jeu commence
            //jetez les des
            de1.Jeter();
        }
    }
}
