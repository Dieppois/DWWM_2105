using System;
using System.Collections.Generic;

// Package
namespace ClassLibraryVehicules

{
    // Class
    public class Voiture : IComparable
    {
        // Attributs
        int numeroDeSerie;
        string marque;
        string modele;
        DateTime dateCirculation;

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
        }

        // Methods
        public override string ToString()
        {
            return "NumeroDeSerie : " + this.NumeroDeSerie + " || Marque : " + this.Marque + " || Modele : " 
              + this.Modele + " || DateCirculation : " + this.DateCirculation.ToLongDateString() + "\n";
        }

        public int CompareTo(object _autreVoiture)
        {
            Voiture _autreTest = (Voiture)_autreVoiture;
            return Marque.CompareTo(_autreTest.Marque);
        }
    }
}