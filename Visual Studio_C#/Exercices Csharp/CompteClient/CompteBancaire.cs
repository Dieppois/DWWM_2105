using System;
using System.Collections.Generic;
using System.Text;

namespace CompteClient
{
    class CompteBancaire

    {
        //attributs
        private long numCli;
        private string nomCli;
        private double solde;
        private double decouvertAutorise;

        //proprietes
        public long NumCli { get => numCli; }
        public string NomCli { get => nomCli; set => nomCli = value; }
        public double Solde { get => solde; set => solde = value; }
        public double DecouvertAutorise { get => decouvertAutorise; set => decouvertAutorise = value; }

        //public long NumCli
        //{
        //    get { return numCli; }
        //    set { numCli = value; }
        //}
        //public string NomCli
        //{
        //    get { return nomCli; }
        //    set { nomCli = value; }
        //}
        //public double Solde
        //{
        //    get { return solde; }
        //    set { solde = value; }
        //}
        //public double DecouvertAutorise
        //{
        //    get { return decouvertAutorise; }
        //    set { decouvertAutorise = value; }
        //}

        // Constructors
        // public CompteBancaire() { }
        public CompteBancaire(long _numCli, string _nomCli, double _solde, double _decouvertAutorise)
        {
            this.numCli = _numCli;
            this.nomCli = _nomCli;
            this.solde = _solde;
            this.decouvertAutorise = _decouvertAutorise;
        }
        List<CompteBancaire> CompteBancaires = new List<CompteBancaire>();
        
        // Methodes
        public void Afficher()
        {
            Console.WriteLine("Numero : " + numCli + "\nNom : " + nomCli + "\nSolde : " + solde +
                              "\nLimite decouvert autorisé : " + decouvertAutorise + "\n");
        }

        public void Crediter(double _montant)
        {
            solde = solde + _montant;
            Console.WriteLine("Crédit de " + _montant + " $ effectué.\nSolde : " + solde + "\n");
        }

        public bool Debiter(double _montant)
        {
            if (solde - decouvertAutorise >= _montant)
            {
                solde = solde - _montant;
                Console.WriteLine("Débit de : " + _montant + " $ effectué.\nSolde : " + solde + "\n");
                return true;
            }
            Console.WriteLine("Découvert autorisé dépassé, débit impossible.\nSolde : " + solde + "\n");
            return false;
        }


        public bool Transfert(double _montant, CompteBancaire _compte)
        {
            if (solde - decouvertAutorise >= _montant)
            {
                Console.WriteLine("Transfert accepté : " + solde + " - " + _montant);
                solde = solde - _montant;
                _compte.solde = _compte.solde + _montant;
                Console.WriteLine("Solde : " + solde + "Solde du compte crédité : " + _compte.solde);
                return true;
            }
            Console.WriteLine("Découvert autorisé dépassé, transfert impossible.");
            return false;
        }



        //  public Crediter(_montant)


    }
}

