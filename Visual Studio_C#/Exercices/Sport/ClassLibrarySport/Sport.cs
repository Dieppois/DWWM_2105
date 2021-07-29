using System;

        // Package
namespace ClassLibrarySport
{
        // Class
    public class Sport
    {
        // Attributs
        private string strNomSport;
        private string strTypeSport;

        // Properties 
        public string StrNomSport { get => strNomSport; set => strNomSport = value; }
        protected string StrTypeSport { get => strTypeSport; set => strTypeSport = value; }

        // Constructors
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


