using System;
using System.Collections.Generic;
using System.Text;

// Package
namespace ClassLibraryJeu421
{
    // Class
    public class Partie

    {
        // Attributs
        static int nbLancerMax;
        De de;
        Joueur joueur1;
        Joueur joueur2;
        // Properties 
        public int Score { get => score; set => score = value; }
        public string Nom { get => nom; set => nom = value; }
        public static int NbLancer { get => nbLancer; set => nbLancer = value; }

        // Constructors
        public Partie()
        {
            this.NbLancer = 3;
            this.Nom = "Joueur " + compteur;
            this.Score = 30;
        }

        // Methods
        public string AfficherScore()
        {
            return " Le score du " + joueur.Nom + " est de " + joueur1.Score + " / Le score du " + joueur2.Nom + " est de " + joueur2.Score;
        }
        public void NouveauLancer()
        { 
        new Manche =





        public Manche TourOrdinateur()
        {
            bool un = true;
            bool deux = true;
            bool trois = true;
            Manche temp = new Manche();
            temp.Lancer(un, deux, trois);





        }
            
    }
}
