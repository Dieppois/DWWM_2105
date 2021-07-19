using System;
using System.Collections.Generic;
using System.Text;
//Cette classe doit héritée de la classe Sport.
//2. On doit pouvoir construire un objet SportEquip :
// en lui communiquant 
//• le nom du sport,
//• le nom de l'équipe championne
//• et le nombre de personnes par équipe
// ou en ne lui communicant rien : dans ce cas les variables prennent des valeurs par défaut
//• Nom du sport : "Beach Volley"
//• Nom du champion : "Brésil"
//• Nombre de personnes : 4
//3.L'encapsulation doit être mise en œuvre
//4.la méthode ToString() doit renvoyer 
// le nom du sport est 
// suivi du nom du sport
// suivi de ce sport a pour type
// suivi du contenu du type de sport.
//ainsi que 
// le nom des champions est suivi du nom de l'équipe "championne"
// le nombre de joueurs est de suivi du nombre de personnes dans l'équipe.

namespace ClassLibrarySport
{
    class SportEquip
    {
        private string strEquipChamp; // nom de l'équipe championne
        private int nbPers; // nombre de personne dans l'équipe
        public SportEquipe()
        {
        }
        // la méthode ToString
        public override string ToString()
        {
        }
    }
}
