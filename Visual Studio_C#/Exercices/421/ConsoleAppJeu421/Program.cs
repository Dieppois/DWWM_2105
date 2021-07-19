using System;
using ClassLibraryJeu421;
namespace ConsoleAppJeu421
{
    class Program
    {
        static void Main(string[] args)
        {
            int compteur2 = 0;
            string answer;

            Console.WriteLine("Jeu 421 commence !!");
            Partie partie1 = new Partie();
            Console.WriteLine("Vous êtes le Joueur 1. Le Joueur 2 est l'ordinateur");
            
            Manche manche1 = new Manche();
            do
            {
                compteur2 ++;
                Console.WriteLine("----------------------------------------------------------\nManche"+compteur2+"\n----------------------------------------------------------");
                int compteur = 0;
                manche1.AfficherScore();
                do
                {
                    compteur++;
                    bool d1 = false;
                    bool d3 = false;
                    bool d2 = false;
                    Console.WriteLine("Voulez-vous (re)lancer un ou plusieurs dé(s) ?\nSi oui, entrez le(s) numero(s) du(des) dé(s) séparés d'un espace (1 / 2 / 3), sinon, entrez \"No\"");
                    answer = Console.ReadLine();
                    if (!answer.ToLower().Equals("no"))
                    {       
                        string[] result = answer.Split(' ');

                        for (int i = 0; i < result.Length; i++)
                        {
                            if (result[i] == "1") d1 = true;
                            if (result[i] == "2") d2 = true;
                            if (result[i] == "3") d3 = true;
                        }
                        Console.WriteLine(manche1.Lancer(d1, d2, d3));
                    }
                } while (!answer.ToLower().Equals("no") && compteur <= 2);

                if (manche1.Gagner())
                {
                    Console.WriteLine("Vous avez gagné la manche, vous gagnez 30 points");
                    manche1.joueur1.Score += 30;
                }
                else
                {
                    Console.WriteLine("Vous avez perdue la manche, vous perdez 10 points");
                    manche1.joueur2.Score += 30;
                }
                if (manche1.joueur1.Score <= 0)
                    Console.WriteLine("Vous avez perdue la partie");
                else if (manche1.joueur1.Score > 99)
                    Console.WriteLine("Vous avez gagné la partie");      

            } while (manche1.joueur1.Score > 0 && manche1.joueur1.Score < 100);

            Console.WriteLine("Jeu 421 terminé !!");
            Console.ReadLine();
        }

    }
}
