using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace LibraryAppCompteBancaire
{
    public class Banque
    {
        //attributs

        //tableau dynamique
        private List<CompteClient> lesComptes = new List<CompteClient>();
        //tableau statique
        public CompteClient[] mesComptes = new CompteClient[30];
        private int nbComptes;

        private string nomBanque;
        private string villeBanque;

        //property
        public string NomBanque { get => nomBanque; }
        public string VilleBanque { get => villeBanque; }
        public List<CompteClient> LesComptes { get => lesComptes; set => lesComptes = value; }

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
        public bool Virement(long _numero1, long _numero2, double _montant, out string _message)
        {
            if (RendCompte(_numero1) != null)
            {
                if (RendCompte(_numero2) != null)
                {
                    bool test = RendCompte(_numero1).Transferer(_montant, RendCompte(_numero2));
                    if (test)
                    {
                        _message = "Virement effectué";
                        return true;
                    }
                    else _message = "Solde inssufisant";
                    return false;
                }
                else _message = "Le numero du compte crédité est erroné";
                return false;
            }
            else _message = "Le numero du compte débiteur est erroné";
            return false;
        }
        public CompteClient CompteSup2()
        {
            CompteClient comptemax = this.lesComptes[0];
            for (int i = 1; i < lesComptes.Count; i++)
            {
                if (lesComptes[i].Solde > comptemax.Solde)
                {
                    comptemax = lesComptes[i];
                }

            }
            return comptemax;
        }
        public CompteClient RendCompte2(long _numeroCompte)
        {
            for (int i = 0; i < this.nbComptes; i++)
            {
                if (lesComptes[i].Numero == _numeroCompte)
                {
                    return lesComptes[i];
                }
            }
            return null;
        }
    }
}


