using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryVehicules
{
    public class ComparerNumeroDeSerie : IComparer<Voiture>
    {
        public int Compare(Voiture x, Voiture y)
        {
            return x.NumeroDeSerie.CompareTo(y.NumeroDeSerie);
        }
    }












}

