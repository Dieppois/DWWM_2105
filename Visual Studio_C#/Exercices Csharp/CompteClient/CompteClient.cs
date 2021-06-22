using System;

namespace CompteClient
{
    class CompteClient
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
        public string GetNomCli()
        {
            return this.nomCli;
        }
        public void SetSolde(double _montant)
        {
            this.solde = _montant;
        }

        // Constructeurs
        public CompteClient(long _numCli, string _nomCli, double _solde, double _da)
        {
            this.numCli = _numCli;
            this.nomCli = _nomCli;
            this.SetSolde(_solde);
            this.decouvertAutorise = _da;
        }
        //Destructeur
        //methodes

    }