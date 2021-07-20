using System;
using System.Collections.Generic;
using System.Text;

// Package
namespace ClassLibraryJeu421
{
    // Class
    public class Joueurs
    {
        // Attributs
        string nom;
        int score;
        public static int compteur = 0;

        // Properties 
        public int Score { get => score; set => score = value; }
        public string Nom { get => nom; set => nom = value; }

        // Constructors
        public Joueurs()
        {
            compteur++;
            this.Nom = "Joueur " + compteur;
            this.Score = 30;
        }
    }
}
