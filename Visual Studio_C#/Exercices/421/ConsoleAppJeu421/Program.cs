using System;
using System.Drawing;
using ClassLibraryJeu421;
namespace ConsoleAppJeu421
{
    class Program
    {
        static void Main(string[] args)
        {
            int compteur3 = 0;
            int compteur2 = 0;
            string answer;

            Console.WriteLine("Jeu 421 commence !!");
            Console.WriteLine("Vous êtes le Joueur 1. Le Joueur 2 est l'ordinateur");

            Manche manche1 = new Manche();
            do
            {
                int compteur = 1;
                compteur3++;

                if (compteur3 % 2 != 0)
                {
                    compteur2++;    
                    Console.WriteLine("\n--------------------------------\nManche " + compteur2 + manche1.AfficherScore() +"\n-----------------------------------------------");
                    Console.WriteLine("\nTour du Joueur 1" + "\n----------------------------------------------------------");
                }
                else
                    Console.WriteLine("\n----------------------------------------------------------\nTour du Joueur 2" + "\n----------------------------------------------------------");

                manche1.AfficherScore();
                
                bool d1 = true;
                bool d3 = true;
                bool d2 = true;
                
                Console.WriteLine("1er lancé : \n" + manche1.Lancer(d1, d2, d3));

                do
                {
                    compteur++;
                    d1 = false;
                    d3 = false;
                    d2 = false;
                    Console.Write("Voulez-vous (re)lancer un ou plusieurs dé(s) ?\nSi oui, entrez le(s) numero(s) du(des) dé(s) séparés d'un espace (1 / 2 / 3), sinon, entrez \"No\" : ");
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
                        Console.WriteLine(compteur+"iem lancé : \n" + manche1.Lancer(d1, d2, d3));
                    }
                } while (!answer.ToLower().Equals("no") && compteur <= 2);

                if (compteur3 % 2 != 0)
                {
                    if (manche1.Gagner())
                    {
                        Console.Write("Vous avez gagné la manche, vous gagnez ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("30 points");
                        Console.ResetColor();
                        manche1.joueur1.Score += 30;
                    }
                    else
                    {
                        Console.Write("Vous avez perdue la manche, vous perdez ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("10 points");
                        Console.ResetColor();
                        manche1.joueur1.Score -= 10;
                    }
                    if (manche1.joueur1.Score <= 0)
                        Console.WriteLine("Vous avez perdue la partie");
                    else if (manche1.joueur1.Score > 99)
                        Console.WriteLine("Vous avez gagné la partie");
                }
                else
                {
                   
                    if (manche1.Gagner())
                    {

                        Console.Write("Joueur 2 gagne ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("30 points");
                        Console.ResetColor();
                        manche1.joueur2.Score += 30;
                    }
                    else
                    {
                        Console.Write("Joueur 2 perd ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("10 points");
                        Console.ResetColor();
                        manche1.joueur2.Score -= 10;
                    }
                    if (manche1.joueur2.Score <= 0)
                        Console.WriteLine("Joueur 2 a perdue, vous gagnez");
                    else if (manche1.joueur2.Score > 99)
                        Console.WriteLine("Joueur 2 a gagné, vous perdez");
                }

            } while ( (manche1.joueur1.Score > 0 && manche1.joueur1.Score < 100 ) || (manche1.joueur2.Score > 0 && manche1.joueur2.Score < 100));

            Console.WriteLine("Jeu 421 terminé !!");
            Console.ReadLine();
        }

    }
}
