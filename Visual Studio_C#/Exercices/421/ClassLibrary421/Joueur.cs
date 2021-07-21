using System;
using System.Collections.Generic;
using System.Text;

// Package
namespace ClassLibraryJeu421
{
// Class
    class Joueur
    {
// Attributs
        static int compteur;
        string nom;
        int score;

        // Properties 
        public string Nom { get => nom; }
        public int Score { get => score; set => score = value; }
        public static int Compteur { get => compteur; set => compteur = value; }



        // Constructors
        public Joueur()
        {
            Compteur ++;
            this.nom = "Joueur " + Compteur;
            this.Score = Partie.NbLancer * 10;
        }
        // Methods
    }
}