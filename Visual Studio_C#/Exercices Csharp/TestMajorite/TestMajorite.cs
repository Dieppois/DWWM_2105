using System;

namespace TestMajorite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez saisir votre date de naissance ! dd/mm/aaaa");
            string chaineDateAnniv = Console.ReadLine();
            string[] tabDateAnniv = chaineDateAnniv.Split("/");
            DateTime dateAnniv = new DateTime(int.Parse(tabDateAnniv[2]), int.Parse(tabDateAnniv[1]), int.Parse(tabDateAnniv[0]));
           // Console.WriteLine(dateAnniv.ToString("dd/MM/yyyy"));
            DateTime dateJour = DateTime.Today;
            DateTime jourMaj = new DateTime(dateJour.Year - 18, dateJour.Month, dateJour.Day);
            if (dateAnniv.CompareTo(jourMaj) == -1)
            {
                Console.WriteLine("\nVous êtes majeur");
            }
            else if (dateAnniv.CompareTo(jourMaj) == 0)

            {
                Console.WriteLine("\nVous êtes tout juste majeur, bon anniversaire !! ");
            }
            else

            {
                Console.WriteLine("\nVous êtes mineur");
            }
            Console.ReadKey();

        }
    }
}