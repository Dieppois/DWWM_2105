using System;

namespace CompteClient
{
    class CompteClient
    {

        static void Main(string[] args)
        {

            CompteBancaire compte1 = new CompteBancaire(4815162342, "Bellamy", 1505, -100);
            CompteBancaire compte2 = new CompteBancaire(4815162343, "Octavia", 2007, -300);
            CompteBancaire compte3 = new CompteBancaire(4815162344, "Finn", 1985, -500);

           
            
            String answer;

            // Donner une représentation textuel de toutes ses informations
            Console.Write("Voulez-vous consulter le compte ? O/N : ");
            answer = Console.ReadLine();
            if (answer.ToLower().Equals("o"))
            {
                compte1.Afficher();
            }
            
            // créditer d'un montant fourni 
            Console.Write("\nVoulez-vous déposer de l'argent ? O/N : ");
            answer = Console.ReadLine();
            if (answer.ToLower().Equals("o"))
            {
                Console.Write("Indiquez le montant a déposer : ");
                double num = Convert.ToDouble(Console.ReadLine());
                compte1.Crediter(num);
            }

            // débiter le solde d'un montant fourni, mais attention un "drapeau" (booleen) indiquera si l'opération a pu se réaliser
            Console.Write("\nVoulez-vous retirer de l'argent ? O/N : ");
            answer = Console.ReadLine();
            if (answer.ToLower().Equals("o"))
            {
                Console.Write("Indiquez le montant a transferer : ");
                double num = Convert.ToDouble(Console.ReadLine());
                compte1.Debiter(num);
            }

            //transférer un montant, du compte courant vers un autre compte; même remarque que pour le paragraphe précédent.
            Console.Write("\nVoulez-vous transferer de l'argent ? O/N : ");
            answer = Console.ReadLine();
            if (answer.ToLower().Equals("o"))
            {
                Console.Write("Indiquez le numero du compte sujet au transfert : ");
                int numero = Convert.ToInt32(Console.ReadLine());
                

                Console.Write("\nIndiquez le montant a transferer : ");
                double num = Convert.ToDouble(Console.ReadLine());
               // compte1.Transfert(num, compte);
            }



                Console.ReadLine();
        }

    }
}
