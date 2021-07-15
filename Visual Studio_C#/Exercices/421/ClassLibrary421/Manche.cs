using System;
using System.Collections.Generic;
using System.Text;
using ClassLibraryJeu421;

namespace ClassLibraryJeu421
{
    public class Manche
    {

        // Attributs
        public int score;
        public string nom;
        public List<int> les3Des = new List<int>();
        // Constructors
        public Manche()
        {

            this.score = 0;
            // this.les3Des;
        }
        // Methods
        public override string ToString()
        {
            return "Le score du " + this.nom + " est de " + this.score;
        }

        public void Lancer(De _d1, De _d2, De _d3)
        {
            les3Des.Add(_d1.Valeur);
            les3Des.Add(_d2.Valeur);
            les3Des.Add(_d3.Valeur);



        }

























    }
}