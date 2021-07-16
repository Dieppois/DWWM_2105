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

        // Properties 

        public int Score { get => score; set => score = value; }
        public string Nom { get => nom; set => nom = value; }


        // Constructors
        public Joueurs()
        {
            int compteur = 0;
            compteur++;
            this.Nom = "Joueur"+(compteur);
            this.Score = 0;
        }
        

        // Methods

        // >Resultat de jeter augmente le score de l'objet joueurAh c'et















    }
}
