using System;
using System.Collections.Generic;
using System.Text;
using ClassLibraryJeu421;

namespace ClassLibraryJeu421
{
    public class Manche
    {
        // Attributs
        De de1 = new De();
        De de2 = new De();
        De de3 = new De();
        public Joueurs joueur1 = new Joueurs();
        public Joueurs joueur2 = new Joueurs();
        public int[] tabDes = new int[2];
        
        // Constructors
        public Manche()
        {
            De de1 = new De();
            De de2 = new De();
            De de3 = new De();
            Joueurs joueur1 = new Joueurs();
            Joueurs joueur2 = new Joueurs();    
         }
        
         // Methods
        public string AfficherScore()
        {
            return "Le score du " + joueur1.Nom + " est de " + joueur1.Score + "\nLe score du " + joueur2.Nom + " est de " + joueur2.Score;
        }

        public string Lancer(bool _un, bool _deux, bool _trois)
        {
            if (_un == true)
            de1.Jeter();
            tabDes[0] = de1.Valeur;
            if (_deux == true)
            de2.Jeter();
            tabDes[1] = de2.Valeur;
            if (_trois == true)
            de3.Jeter();
            tabDes[2] = de3.Valeur;

            string resultat = "";
            for (int i = 0; i < tabDes.Length; i++)
            {
                if (tabDes[i] != 0)
                resultat += "Valeur du de " + (i + 1) + " = " + tabDes[i] + "\n";
            }
            return resultat;
        }

        public bool Gagner()
        {
            Array.Sort(tabDes);
            if (this.tabDes[0] == 1 && this.tabDes[1] == 2 && this.tabDes[2] == 4)
                return true;
            return false;
        }

    }
}