using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryVehicules
{
    public class ComparerMarque : IComparer<Voiture>
    {
        public int Compare(Voiture x, Voiture y)
        {
            return x.Marque.CompareTo(y.Marque);
        }
    }
}
