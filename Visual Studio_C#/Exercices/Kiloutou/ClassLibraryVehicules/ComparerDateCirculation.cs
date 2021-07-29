using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryVehicules
{
    public class ComparerDateCirculation : IComparer<Voiture>
    {
        public int Compare(Voiture x, Voiture y)
        {
            return x.DateCirculation.CompareTo(y.DateCirculation);
        }
    }

}
