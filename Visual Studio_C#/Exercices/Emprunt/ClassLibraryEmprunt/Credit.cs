using System;
// Package
namespace ClassLibraryEmprunt
{
    // Class
    public class Credit
    {
        // Attributs
        double capitalEmprunte; // ->  le capital emprunte
        double tauxInteretAnnuel; // ->  taux de l'interet annuel
        double tauxInteretMensuel; // ->  taux de l'interet annuel
        int nbrAnneeRbmt; // ->  le nombre d'annee de remboursement
        int nbMois; // ->  le nombre de mois de la période

        // Properties 
        public double CapitalEmprunte { get => capitalEmprunte; }
        public double TauxInteretAnnuel { get => tauxInteretAnnuel; }
        public double TauxInteretMensuel { get => tauxInteretMensuel; }
        public int NbrAnneeRbmt { get => nbrAnneeRbmt; }
        public int NbMois { get => nbMois; }

        // Constructors
        public Credit(double _capitalEmprunte, double _tauxInteretAnnuel, int _nbrAnneeRbmt)
        {
            this.capitalEmprunte = _capitalEmprunte; //->  le capital emprunte
            this.tauxInteretAnnuel = _tauxInteretAnnuel;  //->  taux de l'interet annuel
            this.tauxInteretMensuel = this.TauxInteretAnnuel / (double)1200; // ->  taux de l'intérêt mensuel<- tauxInteretAnnuel/12
            this.nbrAnneeRbmt = _nbrAnneeRbmt; //->  le nombre d'annee de remboursement
            this.nbMois = _nbrAnneeRbmt * 12; //->  le nombre de mois de la période
        }

        // Methods

        //1) Réaliser la fonction qui renvoie la mensualité constante du prêt 
        //        En fonction du "tauxInteretAnnuel" et du "capitalEmprunte" et du "nbrAnneeRbmt",
        //        Afficher l'annuité et la "mensualité" constante à rembourser d'après la formule de calcul financière
        //        qui vous est communiqué par la maîtrise d'ouvrage".
        //        formule financière calcul de la mensualité constante : a Avec 2 chiffres decimaux obligatoires.
        //        Soit n nbre de mois de remboursement
        //        tm = tmensuel = txannuel / 12
        //        a= K x tm/Q
        //        Q = (1 - (1 + tm)puissance-n)

        public double CalculMensualite()
        {
            double Q = (1 - Math.Pow((1 + this.TauxInteretMensuel), -this.NbMois));
            return Math.Round((this.CapitalEmprunte * this.TauxInteretMensuel) / Q, 2);
        }
        public double CoutTotalCredit()
        {
            return Math.Round((this.CalculMensualite() * this.NbMois - this.CapitalEmprunte), 2);
        }

        //2) Réaliser une fonction qui renvoie et affiche le tableau d'amortissement du prêt :		

        //        Afficher le tableau d'amortissement mensuel du prêt en mode console.
        //        sur 5 colonnes
        //        compteur numero mois//  part interet(1 décimal) // part capital(1decimal) //  capital restant(pas de décimal) du// mensualité (pas de décimal)  
        //        Soit K(n) capital restant dû au mois n
        //        Quand n = 0  k(n) =Capital emprunté
        //        autrement k(n+1)=k(n)- part_Capital(n)
        //        part_Interet(n+1) = K(n)*tm
        //        part_Capital(n+1) = Mensualité- part Interet(n+1).

    }
}
