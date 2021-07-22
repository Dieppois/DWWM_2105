using System;
using System.Collections.Generic;
using System.Text;
using ClassLibraryJeu421;

namespace ClassLibraryJeu421
{
    public class Manche
    {
        // Attributs
        int[] tabDes;
        De de;
        Joueur joueur1;
        Joueur joueur2;

        // Property
        public int[] TabDes { get => tabDes; set => tabDes = value; }
        public De De { get => de; set => de = value; }
        public Joueur Joueur1 { get => joueur1; set => joueur1 = value; }
        public Joueur Joueur2 { get => joueur2; set => joueur2 = value; }

        // Constructors
        public Manche()
        {
            this.TabDes = new int[3];
            this.De = new De();
            this.Joueur1 = new Joueur();
            this.Joueur2 = new Joueur();
        }

        // Methods
        public string Lancer()
        {
            this.De.Jeter();
            TabDes[0] = this.De.Valeur;
            this.De.Jeter();
            TabDes[1] = this.De.Valeur;
            this.De.Jeter();
            TabDes[2] = this.De.Valeur;

            return AfficherLancer();
        }

        public string Relancer(bool _un, bool _deux, bool _quatre)
        {
            if (!_un)
            {
                De.Jeter();
                TabDes[2] = De.Valeur;
            }
            if (!_deux)
            {
                De.Jeter();
                TabDes[1] = De.Valeur;
            }
            if (!_quatre)
            {
                De.Jeter();
                TabDes[0] = De.Valeur;
            }
            return AfficherLancer();
        }
        public string AfficherLancer()
        {
            int compteur =0;
            Array.Sort(TabDes);
            Array.Reverse(TabDes);
            string resultat = "";
            for (int i = 2; i >= 0; i--)
            {
                compteur++;
                resultat += "Valeur du de " + (compteur) + " = " + TabDes[i] + "\n";
            }
            return resultat;
        }

        public bool MancheGagnante()
        {
            if (this.TabDes[0] == 4 && this.TabDes[1] == 2 && this.TabDes[2] == 1)
                return true;
            else
                return false;
        }

        public string MajPoint(Joueur _joueur)
        {
            string result;
            if (MancheGagnante())
            {
                Console.ForegroundColor = ConsoleColor.Green;
                _joueur.Score += 30;
                result = _joueur.Nom + " a gagné 30 points";
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                _joueur.Score -= 10;
                result = _joueur.Nom + " a perdue 10 points";
            }
            return result;
        }
    }
}