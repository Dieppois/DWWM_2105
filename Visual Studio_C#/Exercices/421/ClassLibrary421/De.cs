using System;
using System.Collections.Generic;
using System.Text;
using ClassLibraryJeu421;

namespace ClassLibraryJeu421
{
    public class De
    {
        // Attributes
        private int valeur;

        // Properties
        public int Valeur { get => valeur; set => valeur = value; }

        // Constructors
        public De()
        {
            this.Valeur = 0;
        }

        // Methods
        public void Jeter()
        {
            this.Valeur = Alea.Instance().Nouveau(1, 6);
        }

    }

}



