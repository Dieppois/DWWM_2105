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
        string joueur;
        int score;

        // Properties 

        public int Score { get => score; set => score = value; }
        public string Joueur { get => joueur; set => joueur = value; }


        // Constructors
        public Joueurs()
        {
            this.Joueur = "???";
            this.Score = 0;
        }
        public Joueurs(string _nom)
        {
            this.Joueur = _nom;
            this.Score = 0;
        }

        // Methods

        // >Resultat de jeter augmente le score de l'objet joueurAh c'et















    }
}
