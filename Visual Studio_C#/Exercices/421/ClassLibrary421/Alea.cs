using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryJeu421
{
    // design pattern : singleton
    public class Alea : Random
    {
        private static Alea monAlea = null;

        private Alea()
        {
        }
        public static Alea Instance()
        {
            if (monAlea == null)
            {
                monAlea = new Alea();
            }
            return monAlea;
        }
        public int Nouveau(int valMin, int valMax)
        {
            return base.Next(valMin, valMax + 1);
        }
    }
}
