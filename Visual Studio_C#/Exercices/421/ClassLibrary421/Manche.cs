using System;
using System.Collections.Generic;
using System.Text;
using ClassLibraryJeu421;

namespace ClassLibraryJeu421
{
    public class Manche
    {
        // Attributs
        De de;
        Joueur joueur1;
        Joueur joueur2;
        public int[] tabDes;

        // Constructors
        public Manche()
        {
            tabDes = new int[3];
            de = new De();
            joueur1 = new Joueur();
            joueur2 = new Joueur();
        }

        // Methods
        public string Lancer()
        {
            de.Jeter();
            tabDes[0] = de.Valeur;
            de.Jeter();
            tabDes[1] = de.Valeur;
            de.Jeter();
            tabDes[2] = de.Valeur;
            return AfficherLancer();
        }

        public string Relancer(bool _un, bool _deux, bool _quatre)
        {
            if (!_un)
            {
                de.Jeter();
                tabDes[0] = de.Valeur;
            }
            if (!_deux)
            {
                de.Jeter();
                tabDes[1] = de.Valeur;
            }
            if (!_quatre)
            {
                de.Jeter();
                tabDes[2] = de.Valeur;
            }
            return AfficherLancer();
        }

        public string MancheOrdinateur()
        {
            string resultat = "";
            resultat += Lancer();
            int temp = 0;
            int compteur = 1;
            bool un = false;
            bool deux = false;
            bool quatre = false;

            while (compteur <=2)
            {
                compteur++;
                if (tabDes[2] == 1)
                    un = true;
                if (tabDes[1] == 2)
                    deux = true;
                if (tabDes[0] == 4)
                    quatre = true;
                if (!deux && !quatre && tabDes[2] == 2)
                    temp = tabDes[2];
                tabDes[2] = tabDes[1];
                tabDes[1] = temp;
                deux = true;

                if (!un || !deux || !quatre)
                    resultat += Relancer(un, deux, quatre);
            }
            return resultat;  
        }

        public string AfficherLancer()
        {
            Array.Sort(tabDes);
            string resultat = " ";
            for (int i = 0; i < tabDes.Length; i++)
            {
                if (tabDes[i] != 0)
                    resultat += "Valeur du de " + (i + 1) + " = " + tabDes[i] + "\n";
            }
            return resultat;
        }
        
        public bool Gagner()
        { 
            if (this.tabDes[0] == 1 && this.tabDes[1] == 2 && this.tabDes[2] == 4)
                return true;
            return false;
        }
    }
}