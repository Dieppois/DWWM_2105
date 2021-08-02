using System;

        // Package
namespace ClassLibrarySport
{
        // Class
    public class Sport
    {
        // Attributs
        public string strNomSport;
        public string strTypeSport;

        // Properties 
        protected string StrNomSport { get => strNomSport; set => strNomSport = value; }
        private string StrTypeSport { get => strTypeSport; set => strTypeSport = value; }

        // Constructors
        public Sport(string _strNomSport, string _strTypeSport)
        {
            this.strNomSport = _strNomSport;
            this.strTypeSport = _strTypeSport;
        }
        public Sport(string _strNomSport)
        {
            this.strNomSport = _strNomSport;
            this.strTypeSport = "";
        }
        public Sport()
        {
            this.strNomSport = "Beach Volley";
            this.strTypeSport = "";
        }

        // Methods
        public override string ToString()
        {
            return "Le nom du sport est : " + this.strNomSport + "\nCe sport a pour type : " + this.strTypeSport;
        }

    }

}


