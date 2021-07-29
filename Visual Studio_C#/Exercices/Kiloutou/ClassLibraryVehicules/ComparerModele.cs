using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryVehicules
{
    public class ComparerModele : IComparer<Voiture>
    {
        public int Compare(Voiture x, Voiture y)
        {
            return x.Modele.CompareTo(y.Modele);
        }
    }
}
