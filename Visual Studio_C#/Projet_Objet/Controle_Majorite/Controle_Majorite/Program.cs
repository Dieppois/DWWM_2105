using System;

namespace Controle_Majorite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez saisir votre date de naissance ! dd/mm/aaaa" );
            string chaineDateAnniv = Console.ReadLine();
            string[] tabDateAnniv = chaineDateAnniv.Split("/");
            DateTime dateAnniv = new DateTime(int.Parse(tabDateAnniv[2]), int.Parse(tabDateAnniv[1]),int.Parse(tabDateAnniv[0]));
            Console.WriteLine(dateAnniv.ToString("dd/MM/yyyy"));
            DateTime dateJour = DateTime.Today;
            DateTime jourMaj = new DateTime(dateJour.Year - 18, dateJour.Month, dateJour.Day);
            if (dateAnniv.CompareTo(jourMaj) == -1)
            {
                Console.WriteLine("Vous êtes majeur");
            }
            else if (dateAnniv.CompareTo(jourMaj) == 0) 

            {
                Console.WriteLine("Vous êtes tout juste majeur, bon anniersaire?bbbnn!;wxnnbbbBBB ;;;;;;;;;;;...;!! ");
            }
            else 
            
            {
                Console.WriteLine("Vous êtes mineur");       
            }
            Console.ReadKey();

        }
    }
}
