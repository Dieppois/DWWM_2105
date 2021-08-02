using ClassLibraryVehicules;
using System;
using System.Collections.Generic;

namespace ConsoleAppKiloutou
{
    public class Program
    {
        static void Main(string[] args)
        {
            string answer = "";
            
            List<Voiture> tabVoiture = new List<Voiture>();
          
            tabVoiture.Add(new Voiture(2098, "peugeot", "307", new DateTime(2000, 10, 30)));
            tabVoiture.Add(new Voiture(1987, "Renault", "Espace", new DateTime(1950, 8, 10)));
            tabVoiture.Add(new Voiture(1203, "Lancia", "Dedra", new DateTime(1900, 6, 5)));
            tabVoiture.Add(new Voiture(3049, "Bmw", "324d", new DateTime(700, 2, 10)));    
            tabVoiture.Add(new Voiture(1500, "Peugeot", "406", new DateTime(1300, 3, 11)));    
            tabVoiture.Add(new Voiture(2500, "Ford", "Mondeo", new DateTime(1450, 1, 13)));

            tabVoiture.ForEach(Voiture => Console.WriteLine(Voiture));

            while (!answer.Equals("Non"))
            {
                Console.Write("Trier le tableau ? Si Oui, indiquez la méthode de trie : Marque / Modele / NumeroDeSerie / DateCirculation\nSi Non : Non\n");
                switch (answer = Console.ReadLine())
                {
                    case "Marque":
                        tabVoiture.Sort(new ComparerMarque());
                        break;
                    case "Modele":
                        tabVoiture.Sort(new ComparerModele());
                        break;
                    case "NumeroDeSerie":
                        tabVoiture.Sort(new ComparerNumeroDeSerie());
                        break;
                    case "DateCirculation":
                        tabVoiture.Sort(new ComparerDateCirculation());
                        break;
                }
                tabVoiture.ForEach(Voiture => Console.WriteLine(Voiture));
                Console.Write("Recommencer ? Oui / Non : ");
                answer = Console.ReadLine();
            }
            Console.Write("Fin");
            Console.ReadLine();
        }
    }
}
