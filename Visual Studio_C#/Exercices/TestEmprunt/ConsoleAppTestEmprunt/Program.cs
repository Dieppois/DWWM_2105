using System;
using ClassLibraryEmprunt;

namespace ConsoleAppTestEmprunt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Combien voulez-vous emprunter ?");
            double montant = double.Parse(Console.ReadLine());
            Console.WriteLine("Sur quelle durée en années voulez-vous emprunter ?");
            int nbanne = int.Parse(Console.ReadLine());
            Console.WriteLine("A quel taux voulez-vous emprunter ?");
            double taux = double.Parse(Console.ReadLine());
            
            Credit monCredit = new Credit(montant, taux, nbanne);

            Console.WriteLine("Mensualité : " + monCredit.CalculMensualite());
            Console.WriteLine("Cout total du crédit 'in fine' : " + monCredit.CoutTotalCredit());
            
            Console.ReadLine();
        }
    }
}
