using System;
using System.Collections.Generic;
using System.Text;

// Package
namespace ClassLibraryJeu421
{
    // Class
    public class Joueur 
    {
        // Attributs
        static int compteur;
        string nom;
        int score;

        // Properties 
        public string Nom { get => nom; }
        public int Score { get => score; set => score = value; }

        // Constructors
        public Joueur()
        {
            compteur++;
            this.nom = "Joueur " + compteur;
            this.Score = 0;
        }

    }
}