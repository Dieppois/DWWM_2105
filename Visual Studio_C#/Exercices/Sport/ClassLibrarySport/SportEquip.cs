using System;
using System.Collections.Generic;
using System.Text;

// Package
namespace ClassLibrarySport
{

    // Class
    public class SportEquip : Sport
    {

        // Attributs
        private string strEquipChamp;
        private int nbPers;

        // Properties 
        public string StrEquipChamp { get => strEquipChamp; }
        public int NbPers { get => nbPers; }
        
        // Constructors
        public SportEquip(string _strEquipChamp, int _nbPers, string _strNomSport) : base (_strNomSport)
        {
            this.StrNomSport = _strNomSport;
            this.strEquipChamp = _strEquipChamp;
            this.nbPers = _nbPers;
        }

        public SportEquip() : base()
        {
            this.StrNomSport = "Beach Volley";
            this.strEquipChamp = "Brésil";
            this.nbPers = 4;
        }
        
        // Methods
        public override string ToString()
        {
            return base.ToString() + "\nLe nom des champions : " + this.strEquipChamp + "\nAux nombres de : " + this.nbPers;
        }
        public string Gagne()
        {
            return "Le nom de l'équipe championne : " + this.strEquipChamp;
        }
    }
}