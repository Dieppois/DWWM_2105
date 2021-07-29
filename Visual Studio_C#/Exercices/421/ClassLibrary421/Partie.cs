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
        int nbMancheMax;
        int scoreMax;

        Manche manche;

        // Properties 
        public int NbMancheMax { get => nbMancheMax; set => nbMancheMax = value; }
        public int ScoreMax { get => scoreMax; set => scoreMax = value; }
        public Manche Manche { get => manche; set => manche = value; }

        // Constructors
        public Partie()
        {
            this.NbMancheMax = 10;
            this.ScoreMax = 100;

            this.Manche = new Manche();
        }

        // Methods
        public string AfficherScore()
        {
            return " Le score du " + this.Manche.Joueur1.Nom + " est de " + this.Manche.Joueur1.Score +
                ". Le score du " + this.Manche.Joueur2.Nom + " est de " + this.Manche.Joueur2.Score;
        }

        public int PartieGagnante()
        {
            int flag = 0;
            if (Manche.Joueur1.Score >= ScoreMax)
            {
                flag = 1;
            }
            else if (Manche.Joueur2.Score >= ScoreMax)
            {
                flag = 2;
            }
            return flag;
        }
    }
}
