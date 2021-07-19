using System;
using System.Collections.Generic;
using System.Text;
//5.Cette classe doit héritée de la classe Sport.
//6. On doit pouvoir construire un objet SportIndiv :
// en lui communiquant 
//• le nom du sport,
//• le nom du champion
//• le record
//• le lieu et la date où est le record a été battu.
//7. la méthode ToString() doit renvoyer 
// le nom du sport est 
// suivi du nom du sport
// suivi de ce sport a pour type
// suivi du contenu du type de sport.
//ainsi que 
// le nom du champion est suivi du nom du champion
// son record est de suivi du record .
// le record date de suivi de la date du record
// à suivi du lieu du record.
//4) Créer une méthode gagne() qui renseigne :
//Pour un sport individuel :
//Le nom du champion 
//Le record
//Pour un sport d'équipe 
//Le nom de l'équipe championne.

namespace ClassLibrarySport
{
    class SportIndiv
    {
        private string strChampion; // nom du champion
        private string strRecord; // record
        private string strLieu; // lieu du record
        private DateTime datRecord; // date du record (structure de type DateTime)
        public SportIndiv(……, string dateR)
        { ……..datRecord = DateTime.Parse(dateR); // date « chaine (jj/mm/aaaa) ou (jj moisenlettre aaaa)» au format
                                                 // DateTime
        }

        public string StrChampion
        {
            set { strChampion = value; }
            get { return strChampion; }
        }
        public string StrRecord
        {
            set { strRecord = value; }
            get { return strRecord; }
        }
        public string StrLieu
        {
            set { strLieu = value; }
            get { return strLieu; }
        }
        public DateTime DatRecord
        {
            set { datRecord = value; }
            get { return datRecord; }
        }
        // la méthode toString
        public override string ToString()
        {
            // TODO implement code
        }

    }
}
