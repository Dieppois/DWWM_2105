using System;
using System.Collections.Generic;
using System.Text;
using ClassLibraryJeu421;


namespace ConsoleAppJeu421
{
    class Test
    {
        public static void Run()
        {
            Partie partie = new Partie();
            Manche manche = partie.Manche;
            bool un, deux, quatre;

            int compteurLance, compteurManche;
            compteurManche = 0;

            Console.WriteLine("--------------------\nLe jeu 421 commence !\n--------------------");
            Console.WriteLine("Vous êtes le Joueur 1. Le Joueur 2 est l'ordinateur");

            Console.Write("Definissez le nombre de manche(s) maximal : ");
            partie.NbMancheMax = Convert.ToInt32(Console.ReadLine());
            manche.Joueur1.Score = manche.Joueur2.Score = partie.NbMancheMax * 15;

            while (partie.PartieGagnante() == 0 && compteurManche <= partie.NbMancheMax)
            {
                compteurManche++;
                Console.WriteLine("--------------------\nManche " + compteurManche + partie.AfficherScore() + "\n--------------------");

                compteurLance = 0;
                Console.WriteLine("--------------------\nTour du Joueur 1\n--------------------");
                Console.WriteLine("--------------------\nLe 1er Lancé : \n--------------------");
                Console.WriteLine(manche.Lancer());
                compteurLance++;
                while (!manche.MancheGagnante() && compteurLance < 3)
                {
                    compteurLance++;
                    un = deux = quatre = true;
                    Console.Write("Raté ! Relancez un ou plusieurs dé(s).\nEntrez le(s) numero(s) du(des) dé(s) a remplacer, séparés d'un espace (1 / 2 / 3) : ");
                    string[] result = Console.ReadLine().Split(' ');

                    for (int i = 0; i < result.Length; i++)
                    {
                        if (result[i] == "1") quatre = false;
                        if (result[i] == "2") deux = false;
                        if (result[i] == "3") un = false;
                    }
                    Console.WriteLine("--------------------\n" + compteurLance + "ièm Lancé : \n--------------------");
                    Console.WriteLine(manche.Relancer(un, deux, quatre));
                }
                Console.WriteLine(manche.MajPoint(manche.Joueur1));
                Console.ResetColor();

                Console.ReadLine();
                compteurLance = 0;
                Console.WriteLine("--------------------\nTour du Joueur 2\n--------------------");
                Console.WriteLine("--------------------\nLe 1er Lancé : \n--------------------");
                Console.WriteLine(manche.Lancer());
                compteurLance++;
                while (!manche.MancheGagnante() && compteurLance < 3)
                {
                    compteurLance++;
                    un = deux = quatre = false;
                    string answer = "Raté ! Relancez un ou plusieurs dé(s).\nEntrez le(s) numero(s) du(des) dé(s) a remplacer, séparés d'un espace (1 / 2 / 3) : ";

                    if (manche.TabDes[0] == 4) quatre = true;
                    else if (manche.TabDes[0] == 2 && manche.TabDes[1] != 2) quatre = true;
                    else answer += "1 ";
                        
                    if (manche.TabDes[1] == 2) deux = true;
                    else if (manche.TabDes[1] == 4 && manche.TabDes[0] != 4) deux = true;
                    else answer += "2 ";

                    if (manche.TabDes[2] == 1) un = true;
                    else if ((manche.TabDes[2] == 2 && manche.TabDes[1] != 2) || (manche.TabDes[2] == 4 && manche.TabDes[2] != 4)) un = true;
                    else answer += "3";

                    Console.WriteLine(answer);
                    Console.WriteLine("--------------------\n" + compteurLance + "ièm Lancé : \n--------------------");
                    Console.WriteLine(manche.Relancer(un, deux, quatre));
                }
                Console.WriteLine(manche.MajPoint(manche.Joueur2));
                Console.ResetColor();

            }  
                if (partie.PartieGagnante() == 1)
                    Console.WriteLine("Joueur 1 gagne. Vous avez gagné !");
                else if (partie.PartieGagnante() == 2)
                    Console.WriteLine("Joueur 2 gagne. Vous avez perdue !");
                else Console.WriteLine("Personne ne gagne !");

                Console.WriteLine("--------------------\nLe jeu 421 est terminé !\n--------------------");
                Console.ReadLine();
            
        }
    }
}
