using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Compte
    {
        // Attributs
        public long numero;
        public string nom;
        public double solde;
        public double decouvertAutorise;

        // Constructeurs
        public Compte()
        {

        }
        public Compte(long _numero, string _nom, double _solde, double _decouvertAutorise)
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
            solde = solde + _montant;
        }
        public bool Debiter(double _montant)
        {
            if (solde - decouvertAutorise >= _montant)
            {
                solde = solde - _montant;
                return true;
            }
            return false;
        }
        public bool Transferer(double _montant, Compte _compte)
        {
            if (solde - decouvertAutorise >= _montant)
            {
                Crediter(_montant);
                _compte.Debiter(_montant);
                return true;
            }
            return false;
        }
        public bool Comparer(Compte _compteY)
        {
            if (solde > _compteY.solde)
            {
                return true;
            }
            return false;
        }
    }
}
