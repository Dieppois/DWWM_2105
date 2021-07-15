using System;
// Package
namespace LibraryAppCompteBancaire
{
    // Class
    public class CompteClient
    {
        // Attributes
        private long numero;
        private string nom;
        private double solde;
        private double decouvertAutorise;

        // Properties
        public long Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public string Nom
        {
            get { return nom; }
        }
        public double Solde
        {
            get { return solde; }
            set { solde = value; }
        }
        public double DecouvertAutorise
        {
            get { return decouvertAutorise; }
        }
        // Constructors
        public CompteClient()
        {
            this.numero = 4815161341;
            this.nom = "John";
            this.solde = 100000;
            this.decouvertAutorise = 0;
        }
        public CompteClient(long _numero, string _nom, double _solde, double _decouvertAutorise)
        {
            this.numero = _numero;
            this.nom = _nom;
            this.solde = _solde;
            this.decouvertAutorise = _decouvertAutorise;
        }

        // Methods
        public override string ToString()
        {
            return "Numero : " + numero + "\nNom : " + nom + "\nSolde : " + solde + "\nLimite decouvert autorisé : " + decouvertAutorise;
        }
        public void Crediter(double _montant)
        {
            solde += _montant;
        }
        public bool Debiter(double _montant)
        {
            if (solde - decouvertAutorise >= _montant)
            {
                solde -= _montant;
                return true;
            }
            return false;
        }
        public bool Transferer(double _montant, CompteClient _compte)
        {
            if (Debiter(_montant) == true)
            {
                _compte.Crediter(_montant);
                return true;
            }
            return false;
        }
        public bool Superieur(CompteClient _compteY)
        {
            if (solde > _compteY.solde)
            {
                return true;
            }
            return false;
        }
    }

}
