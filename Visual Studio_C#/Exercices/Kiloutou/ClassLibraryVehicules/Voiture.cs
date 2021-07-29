using System;
using System.Collections.Generic;

// Package
namespace ClassLibraryVehicules
{
    // Class
    public class Voiture 
    {
        // Attributs
        int numeroDeSerie;
        string marque;
        string modele;
        DateTime dateCirculation;
        public static List<Voiture> tabVoiture = new List<Voiture>();

        // Properties 
        public int NumeroDeSerie { get => numeroDeSerie; }
        public string Marque { get => marque; }
        public string Modele { get => modele; }
        public DateTime DateCirculation { get => dateCirculation; }
 
        // Constructors
        public Voiture(int _NumeroDeSerie, string _Marque, string _Modele, DateTime _DateTime)
        {
            this.numeroDeSerie = _NumeroDeSerie;
            this.marque = _Marque;
            this.modele = _Modele;
            this.dateCirculation = _DateTime;
            tabVoiture.Add(this);
        }

        // Methods
        public override string ToString()
        {
            return "NumeroDeSerie : " + this.NumeroDeSerie + " || Marque : " + this.Marque + " || Modele : " 
              + this.Modele + " || DateCirculation : " + this.DateCirculation.ToString("dd-MM-yyyy") + "\n";
        }
    }
}