using System;
using ClassLibraryPoint;

namespace ConsoleAppPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            String answer;
            Point point1 = new Point("point(1)", 5, 8);
            Point point2 = new Point("test", 5, 5);
            Point point3 = new Point();
            Point point4 = new Point();
            Point point5 = new Point();

            do
            {
                // Permuter ses coordonnées ( symétrie par rapport à la bissectrice des axes Ox, Oy ).
                Console.Write("\nVoulez-vous définir la distance entre deux points ? O/N : ");
                answer = Console.ReadLine();
                if (answer.ToLower().Equals("o"))
                {
                    Console.WriteLine(point1.MesureDistance(point2));
                }

                // Renvoyer une représentation textuelle en indiquant les valeurs de ses coordonnées.
                Console.Write("Voulez-vous montrer l'emplacement du point(1) ? O/N : ");
                answer = Console.ReadLine();
                if (answer.ToLower().Equals("o"))
                {
                    Console.WriteLine(point1.ToString());
                }

                Console.Write("\nVoulez-vous montrer l'emplacement des autres points ? O/N : ");
                answer = Console.ReadLine();
                if (answer.ToLower().Equals("o"))
                {
                    Console.WriteLine(point2.ToString());
                    Console.WriteLine(point3.ToString());
                    Console.WriteLine(point4.ToString());
                    Console.WriteLine(point5.ToString());
                    Console.WriteLine("");
                }

                // Se déplacer en modifiant abscisse et ordonnée.
                Console.Write("\nVoulez-vous modifier l'emplacement du point(1) ? O/N : ");
                answer = Console.ReadLine();
                if (answer.ToLower().Equals("o"))
                {
                    Console.Write("Indiquez la nouvelle position du point.\nNouvelle abscisseX : ");
                    float num = float.Parse(Console.ReadLine());
                    Console.Write("Nouvelle ordonneeY : ");
                    float num2 = float.Parse(Console.ReadLine());
                    point1.Deplacer(num, num2);
                    Console.WriteLine(point1.ToString());
                }

                // Construire un point symétrique par rapport à l'axe des ordonnées.
                Console.Write("\nVoulez-vous construire un point symétrique par rapport à l'axe des ordonnées du point(1) ? O/N : ");
                answer = Console.ReadLine();
                if (answer.ToLower().Equals("o"))
                {
                    point2 = point1.SymetrieAxeOrdonnee();
                    point2.PointNum = "point(2)";
                    Console.WriteLine(point2.ToString());
                }

                // Construire un point symétrique par rapport à l'axe des abscisses.
                Console.Write("\nVoulez-vous construire un point symétrique par rapport à l'axe des abscisses du point(1) ? O/N : ");
                answer = Console.ReadLine();
                if (answer.ToLower().Equals("o"))
                {
                    point3 = point1.SymetrieAxeAbscisse();
                    point3.PointNum = "point(3)";
                    Console.WriteLine(point3.ToString());
                }

                // Construire un point symétrique par rapport à l'origine.
                Console.Write("\nVoulez-vous construire un point symétrique par rapport à l'origine des coordonnées du point(1) ? O/N : ");
                answer = Console.ReadLine();
                if (answer.ToLower().Equals("o"))
                {
                    point4 = point1.SymetrieOrigine();
                    point4.PointNum = "point(4)";
                    Console.WriteLine(point4.ToString());
                }

                // Permuter ses coordonnées ( symétrie par rapport à la bissectrice des axes Ox, Oy ).
                Console.Write("\nVoulez-vous construire un point symétrique par rapport à l'axe des abscisses du point (1) ? O/N : ");
                answer = Console.ReadLine();
                if (answer.ToLower().Equals("o"))
                {
                    point1.Permuter();
                    Console.WriteLine(point1.ToString());
                }

                // Permuter ses coordonnées ( symétrie par rapport à la bissectrice des axes Ox, Oy ).
                Console.Write("\nVoulez-vous définir la distance entre deux points ? O/N : ");
                answer = Console.ReadLine();
                if (answer.ToLower().Equals("o"))
                {
                    Console.WriteLine(point1.MesureDistance(point2)); 
                }



                Console.Write("\nVoulez-vous recommencer ? O/N : ");
                answer = Console.ReadLine();
            } while (answer.ToLower().Equals("o"));

            Console.WriteLine("\n-------------------------------------------------------------------------------\n\n" +
               "Appuyez sur une touche pour quitter le programme !");
            Console.ReadLine();
        }
    }
}
