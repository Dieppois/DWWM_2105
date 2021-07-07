using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAppCompteBancaire
{
    public class Banque
    {
        //attributs

        public CompteClient[] mesComptes = new CompteClient[30];
        private int nbComptes;
        private string nomBanque;
        private string villeBanque;

        //property
        public string NomBanque { get => nomBanque; }
        public string VilleBanque { get => villeBanque; }
        // constructors
        public Banque()
        {
        }
        public Banque(string _nom, string _ville)
        {
            this.nomBanque = _nom;
            this.villeBanque = _ville;
            this.nbComptes = 0;
        }
        //methods
        public virtual void Dispose() //???
        {
        }
        public void AjouterCompte(CompteClient _unCompte)
        {
            nbComptes++;
            mesComptes[(nbComptes - 1)] = _unCompte;
        }
        public bool AjouterCompte(long _num, string _nom, double _solde, double _decouvertAutorise)
        {
            for (int i = 0; i < this.mesComptes.Length; i++)
            {

                if (mesComptes[i] != null)
                {
                    if (mesComptes[i].Numero == _num)
                        return false;
                }
            }
            CompteClient _compteTemp = new CompteClient(_num, _nom, _solde, _decouvertAutorise);
            this.AjouterCompte(_compteTemp);
            return true;

        }
        public override string ToString()
        {
            string chaine = "---------------- BANQUE " + this.nomBanque + "//" + VilleBanque + "----------\n";
            for (int i = 0; i < this.mesComptes.Length; i++)
            {
                if (mesComptes[i] != null)
                    chaine += mesComptes[i].ToString() + "\n--------------------\n";
            }
            chaine += "-------------------fin------------";
            return chaine;
        }
        public CompteClient CompteSup()
        {
            CompteClient compteMax = new CompteClient();
            for (int i = 0; i < this.mesComptes.Length; i++)
            {
                if (mesComptes[i] != null && mesComptes[i].Solde > compteMax.Solde)
                    compteMax = mesComptes[i];
            }
            return compteMax;
        }
        public CompteClient RendCompte(long _numeroTest)
        {

            for (int i = 0; i < this.mesComptes.Length; i++)
            {
                if ((mesComptes[i] != null && mesComptes[i].Numero == _numeroTest))
                    return mesComptes[i];
            }
            return null;
        }
        public bool TransfererBanque(long _numero1, long _numero2, double _montant)
        {
            if (RendCompte(_numero1) != null && RendCompte(_numero2) != null)
                return RendCompte(_numero1).Transferer(_montant, RendCompte(_numero2));
            else return false;
        }

    }//end Banque

}//end namespace System


