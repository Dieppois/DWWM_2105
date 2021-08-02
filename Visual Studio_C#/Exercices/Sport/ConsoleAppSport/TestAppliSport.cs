using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrarySport;

namespace ConsoleAppSport
{
    class TestAppliSport
    {
        public static void main(String[] args)
        {
            /* Créer une instance de Sport ayant pour nom : sport1
            avec comme nom du sport : Saut en longueur */
            Sport sport1 = new Sport("Saut en longueur");

            /* Indiquer que ce sport fait partie de l'athlétisme */
            sport1.strTypeSport = "Athlétisme";

            /* Créer seq1 qui est un sport d'équipe le polo à bicyclette
            qui a pour équipe championne Chambéry
            et un nombre de personnes de 5 par équipe */
            SportEquip seq1 = new SportEquip("Chambéry", 5, "Polo à bicyclette");
            
            /* Créer seq2 qui est le sport d'équipe par défaut */
            SportEquip seq2 = new SportEquip();
            
            /* Afficher les caractéristiques de sport1 */
            sport1.ToString();
            
            /* Afficher les caractéristiques de seq1 */
            seq1.ToString();
            
            /* Afficher les caractéristiques de seq2 */
            seq2.ToString();

            /* Créer un sport individuel sind1 "saut à la perche"
            dont le champion est "Galfione" avec un record de 6 mètres
            le 25 août 1996 à Séville  */
            /*
            Traiter l’exception (avec try et catch): tant que le format de date est incorrect, obliger la reconstruction 
            de l’objet sind1
            */
            SportIndiv sind1 = new SportIndiv("Galfione", "6 mètre", "Séville", new DateTime(1996, 08, 25), "Saut à la perche");

            /* Afficher les caractéristiques de l'instance ainsi créée */
            sind1.ToString();

            /* Puis enregistrer sur sind1 le fait que "BUBKA" gagne
            le record avec 6,15mètres */
            //Je dois changer les parametres d'accessibiliter.

            sind1.StrChampion = "BUBKA";
            sind1.StrRecord = "6.15 mètre";
           
            /* Changer par la méthode gagne l'équipe championne de seq1
            en "Quimper" */
            // ??????????????
           
            /* Changer par la méthode gagne l'équipe championne de sport1
            en "Paris" */
            // ??????????????
        }
    }
}
