using System;
using System.Collections.Generic;
using System.Text;

// Package
namespace ClassLibrarySport
{
    // Class
    public class SportIndiv
    {
        // Attributs
        private string strChampion;
        private string strRecord;
        private string strLieu;
        private DateTime datRecord;

        // Properties 
        public string StrChampion
        {
            set { strChampion = value; }
            get { return strChampion; }
        }
        public string StrRecord
        {
            set { strRecord = value; }
            get { return strRecord; }
        }
        public string StrLieu
        {
            set { strLieu = value; }
            get { return strLieu; }
        }
        public DateTime DatRecord
        {
            set { datRecord = value; }
            get { return datRecord; }
        }

        // Constructors
        public SportIndiv(string _strChampion, string _strRecord, string _strLieu, DateTime _datRecord)
        {
            this.strChampion = _strChampion;
            this.strRecord = _strRecord;
            this.strLieu = _strLieu;
            this.datRecord = _datRecord;
        }

        // Methods
        public override string ToString()
        {
            return "Le nom du champion : " + this.StrChampion + "\nLe record : " + this.StrRecord +
                "Le lieu du record : " + this.StrLieu + "\nLa date du record : " + this.DatRecord;
        }

    }
}
