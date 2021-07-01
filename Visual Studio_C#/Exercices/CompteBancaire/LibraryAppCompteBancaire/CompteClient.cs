using System;

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
            set { nom = value; }
        }
        public double Solde
        {
            get { return solde; }
            set { solde = value; }
        }
        public double DecouvertAutorise
        {
            get { return decouvertAutorise; }
            set { decouvertAutorise = value; }
        }
        // Constructors
        public CompteClient()
        {

        }
        public CompteClient(long _numero, string _nom, double _solde, double _decouvertAutorise)
        {
            this.numero = _numero;
            this.nom = _nom;
            this.solde = _solde;
            this.decouvertAutorise = _decouvertAutorise;
        }

        // Methods
        public string Afficher()
        {
            string idc = "Numero : " + numero.ToString() + "\nNom : " + nom.ToString() + "\nSolde : " + solde.ToString() +
                "\nLimite decouvert autorisé : " + decouvertAutorise.ToString();
            return idc;
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
            if (solde - decouvertAutorise >= _montant)
            {
                Debiter(_montant);
                _compte.Crediter(_montant);
                return true;
            }
            return false;
        }
        public bool Comparer(CompteClient _compteY)
        {
            if (solde > _compteY.solde)
            {
                return true;
            }
            return false;
        }
    }

}
