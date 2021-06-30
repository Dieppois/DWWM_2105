using System;

namespace LibraryAppCompteBancaire
{
    public class CompteClient
    {
        // Attributs
        public long numero;
        public string nom;
        public double solde;
        public double decouvertAutorise;

        // Constructeurs
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

        // Methodes
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
