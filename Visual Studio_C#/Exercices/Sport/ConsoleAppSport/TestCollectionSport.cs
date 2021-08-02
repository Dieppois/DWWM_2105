using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrarySport;


namespace ConsoleAppSport
{
    /**
     * Titre : enregistrement des records et affichage de la liste
     * des records enregistrés en fin de saisie
    */
    public class TestCollectionSport
    {
        public static string lire()
        {
            string strSaisie = null;
            strSaisie = Console.ReadLine();
            return strSaisie;
        }
        public static void main(String[] args)
        {
            List<SportIndiv> sportList = new List<SportIndiv>();
            string strSport;
            string strNom;
            string strRecord;
            DateTime strDate;
            string strLieu;

            Console.Write("Souhaitez-vous enregistrer un nouveau champion ? (oui/non)");
            string strAutreChampion = lire();
            while (strAutreChampion.Equals("oui"))
            {
                Console.Write("nom du sport :");
                strSport = lire();
                Console.Write("nom du champion :");
                strNom = lire();
                Console.Write("nouveau record :");
                strRecord = lire();
                Console.Write("date du record :");
                strDate = DateTime.Parse(lire());
                Console.Write("le lieu où est le record a été battu :");
                strLieu = lire();

                sportList.Add(new SportIndiv(strNom, strRecord, strLieu, strDate, strSport));

                Console.Write("Souhaitez-vous enregistrer un nouveau record ? (oui/non)");
                strAutreChampion = lire();
            }

            /* affichage des résultats */
            sportList.ForEach(SportIndiv => Console.WriteLine(SportIndiv));

        }
    }
}
