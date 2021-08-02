using System;
using System.Collections.Generic;
using System.Text;

// Package
namespace ClassLibrarySport
{
    // Class
    public class SportIndiv : Sport
    {
        // Attributs
        private string strChampion;
        private string strRecord;
        private string strLieu;
        private DateTime datRecord = new DateTime();

        // Properties 
        public string StrChampion { get => strChampion; set => strChampion = value; }
        public string StrRecord { get => strRecord; set => strRecord = value; }
        public string StrLieu { get => strLieu; }
        public DateTime DatRecord { get => datRecord; set => datRecord = value; }

        // Constructors
        public SportIndiv(string _strChampion, string _strRecord, string _strLieu, DateTime _datRecord, string _strNomSport) : base(_strNomSport)
        {
            this.strNomSport = _strNomSport;
            this.strChampion = _strChampion;
            this.strRecord = _strRecord;
            this.strLieu = _strLieu;
            try
            {
                this.datRecord = _datRecord;
            }
            catch (FormatException e)
            {
                if (e != null)
                    Console.WriteLine(e.Message);
                else
                    this.datRecord = DateTime.Today;
                throw;
            }
        }

        // Methods
        public override string ToString()
        {
            return base.ToString() + "\nLe nom du champion : " + this.StrChampion + "\nSon record est de : " + this.StrRecord +
                "\nLe record date de : " + this.DatRecord + "\nA : " + this.StrLieu ;
        }

        public string Gagne()
        {
            return "Le nom du champion : " + this.StrChampion + "\nSon record est de : " + this.strRecord;
        }
    }   
}
