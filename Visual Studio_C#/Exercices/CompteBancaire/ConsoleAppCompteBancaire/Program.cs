using System;
using LibraryAppCompteBancaire;

namespace ConsoleAppCompteBancaire
{
    class Program
    {
        static void Main(string[] args)
        {
            String answer;

            Banque BNP = new Banque("BANQUE NATIONAL PARIS", "PARIS");

            CompteClient compte1 = new CompteClient(4815162342, "Bellamy", 1500, -100);
            CompteClient compte2 = new CompteClient(4815162343, "Octavia", 2000, -50);
            CompteClient compte3 = new CompteClient(4815162344, "Finn", 1985, -500);
            CompteClient compte4 = new CompteClient(4815162345, "Clark", 1007, -103);
            CompteClient compte5 = new CompteClient();

<<<<<<< Updated upstream
            
=======
>>>>>>> Stashed changes
            // Donner une représentation textuel de toutes ses informations
            Console.Write("Voulez-vous consulter votre compte ? O/N : ");
            answer = Console.ReadLine();
            if (answer.ToLower().Equals("o"))
            {
                Console.WriteLine(compte1.ToString());
            }

            Console.Write("\nVoulez-vous consulter les autres comptes ? O/N : ");
            answer = Console.ReadLine();
            if (answer.ToLower().Equals("o"))
            {
                Console.WriteLine(compte2.ToString());
                Console.WriteLine(compte3.ToString());
                Console.WriteLine(compte4.ToString());
                Console.WriteLine(compte5.ToString());
                Console.WriteLine("");
            }

            // Créditer d'un montant fourni 
            Console.Write("\nVoulez-vous déposer de l'argent ? O/N : ");
            answer = Console.ReadLine();
            if (answer.ToLower().Equals("o"))
            {
                Console.Write("Indiquez le montant a déposer : ");
                double num = Convert.ToDouble(Console.ReadLine());
                compte1.Crediter(num);
                Console.WriteLine("Crédit de " + num + " $ effectué.\nVotre Solde : " + compte1.Solde + "\n");
            }

            // Débiter le Solde d'un montant fourni, mais attention un "drapeau" (booleen) indiquera si l'opération a pu se réaliser
            Console.Write("\nVoulez-vous retirer de l'argent ? O/N : ");
            answer = Console.ReadLine();
            if (answer.ToLower().Equals("o"))
            {
                Console.Write("Indiquez le montant a retirer : ");
                double num = Convert.ToDouble(Console.ReadLine());
                if (compte1.Debiter(num) == true)

                    Console.WriteLine("Débit de : " + num + " $ effectué.\nVotre Solde : " + compte1.Solde + "\n");

                else
                    Console.WriteLine("Découvert autorisé dépassé, débit impossible.\nVotre Solde : " + compte1.Solde + "\n");
            }

            // Transférer un montant, du compte courant vers un autre compte; même remarque que pour le paragraphe précédent.
            Console.Write("\nVoulez-vous transferer de l'argent vers un autre comptre ? O/N : ");
            answer = Console.ReadLine();
            if (answer.ToLower().Equals("o"))
            {
                bool flag;
                do
                {
                    flag = true;
                    Console.Write("Indiquez le Numero du compte sujet au transfert : \"4815162343\" \"4815162344\" \"4815162345\" : ");
                    long numAnswer = Convert.ToInt64(Console.ReadLine());
                    Console.Write("Indiquez le montant a transferer (Solde actuel : " + compte1.Solde + ". Decouvert autorisé : " + compte1.DecouvertAutorise + " ) : ");
                    double num = Convert.ToDouble(Console.ReadLine());

                    if (compte2.Numero == numAnswer && compte1.Transferer(num, compte2) == true)
                    {
                        Console.WriteLine("Transfert accepté : " + (compte1.Solde + num) + " - " + num);
                        Console.WriteLine("Votre Solde : " + compte1.Solde + "\nSolde du compte crédité : " + compte2.Solde);
                    }
                    else if (compte3.Numero == numAnswer && compte1.Transferer(num, compte3) == true)
                    {
                        Console.WriteLine("Transfert accepté : " + (compte1.Solde + num) + " - " + num);
                        Console.WriteLine("Votre Solde : " + compte1.Solde + "\nSolde du compte crédité : " + compte3.Solde);
                    }
                    else if (compte4.Numero == numAnswer && compte1.Transferer(num, compte4) == true)
                    {
                        Console.WriteLine("Transfert accepté : " + (compte1.Solde + num) + " - " + num);
                        Console.WriteLine("Votre Solde : " + compte1.Solde + "\nSolde du compte crédité : " + compte4.Solde);
                    }
                    else if (compte2.Numero != numAnswer && compte3.Numero != numAnswer && compte4.Numero != numAnswer)
                    {
                        Console.WriteLine("Mauvaise saisie, recommencez.\n");
                        flag = false;
                    }
                    else
                        Console.WriteLine("Découvert autorisé dépassé, transfert impossible.");
                    Console.WriteLine("");
                } while (flag == false);
            }

            // Comparer le Solde de l'objet courant avec le Solde d'un autre compte fourni, le résultat sera un booléen
            Console.Write("\nVoulez-vous comparer le Solde de deux comptes ? O/N : ");
            answer = Console.ReadLine();
            if (answer.ToLower().Equals("o"))
            {
                bool flag;
                do
                {
                    flag = true;
                    Console.Write("Indiquez le Nom du compte sujet à la comparaison : \"Octavia\" \"Finn\" \"Clark\" : ");
                    string Answer = Console.ReadLine();

                    if (compte2.Nom == Answer)
                        if (compte1.Superieur(compte2) == true)
                            Console.WriteLine("Le Solde de votre compte de " + compte1.Solde + " est supérieur a celui du compte de " + compte2.Nom + " et son Solde de " + compte2.Solde);
                        else Console.WriteLine("Le Solde de votre compte de " + compte1.Solde + " est inférieur a celui du compte de " + compte2.Nom + " et son Solde de " + compte2.Solde);

                    else if (compte3.Nom == Answer)
                        if (compte1.Superieur(compte3) == true)
                            Console.WriteLine("Le Solde de votre compte de " + compte1.Solde + " est supérieur a celui du compte de " + compte3.Nom + " et son Solde de " + compte3.Solde);
                        else Console.WriteLine("Le Solde de votre compte de " + compte1.Solde + " est inférieur a celui du compte de " + compte3.Nom + " et son Solde de " + compte3.Solde);

                    else if (compte4.Nom == Answer)
                        if (compte1.Superieur(compte4) == true)
                            Console.WriteLine("Le Solde de votre compte de " + compte1.Solde + " est supérieur a celui du compte de " + compte4.Nom + " et son Solde de " + compte4.Solde);
                        else Console.WriteLine("Le Solde de votre compte de " + compte1.Solde + " est inférieur a celui du compte de " + compte4.Nom + " et son Solde de " + compte4.Solde);
                    else
                    {
                        Console.WriteLine("Mauvaise saisie, recommencez.");
                        flag = false;
                    }
                } while (flag == false);
            }

            // Implémentez le constructeur et les deux méthodes AjouterCompte.Attention une des méthodes est privé!
            // Ecrire la méthode ToString de la classe Banque qui réutilisera la méthode ToString de la classe Compte         

            BNP.AjouterCompte(compte1);
            BNP.AjouterCompte(compte2);
            BNP.AjouterCompte(compte3);
            BNP.AjouterCompte(compte4);
            BNP.AjouterCompte(compte5);

            Console.Write("\nVoulez-vous afficher les comptes de la banque ? O/N : ");
            answer = Console.ReadLine();
            if (answer.ToLower().Equals("o"))
            {
                bool ajout;
                ajout = BNP.AjouterCompte(345, "test1", 888, -99);
                ajout = BNP.AjouterCompte(123, "supertest", 1547, -544);

                if (ajout)
                    Console.WriteLine(BNP);
                else
                    Console.WriteLine("numero de compte existant, ajout impossible");
            }
            //Ecrire une méthode publique CompteSup de la classe Banque qui retourne le compte ayant solde maximum. Vous afficherez ce compte supérieur dans la console.
            Console.Write("\nVoulez-vous comparer le Solde de deux comptes de la banque ? O/N : ");
            answer = Console.ReadLine();
            if (answer.ToLower().Equals("o"))
            {
                Console.WriteLine("\nLe compte ayant le solde le plus grand est : \n" + BNP.CompteSup());
            }

            //Ecrire une méthode RendCompte de la classe Banque qui retourne un compte en fonction de son numéro. La fonction retourne Null si le compte n'est pas trouvé.  
            //Pour cela vous devrez ajouter éventuellement dans la classe Compte un accesseur public sur le numéro de compte.
            Console.Write("\nVoulez-vous afficher un compte ? O/N : ");
            answer = Console.ReadLine();
            if (answer.ToLower().Equals("o"))
            {
                Console.Write("\nEntrez le numero du compte que vous voulez afficher : ");
                long numAnswer = Convert.ToInt64(Console.ReadLine());
                Console.Write("\n"+BNP.RendCompte(numAnswer));
                if (BNP.RendCompte(numAnswer) == null)
                    Console.WriteLine("Mauvaise saisie, dommage.\n");
            }
            //Ecrire une méthode qui va transférer une somme d'un compte vers un autre compte.
            Console.Write("\nVoulez-vous transferer de l'argent vers un autre comptre de la banque ? O/N : ");
            answer = Console.ReadLine();
            if (answer.ToLower().Equals("o"))
            {
                Console.Write("\nIndiquez le numero du compte a debiter : \"4815162342\" \"4815162343\" \"4815162344\" : ");
                long numAnswer = Convert.ToInt64(Console.ReadLine());
                Console.Write("Indiquez le Numero du compte sujet au transfert : \"4815162345\" \"345\" \"123\" : ");
                long numAnswer2 = Convert.ToInt64(Console.ReadLine());
                Console.Write("Indiquez le montant a transferer (Solde actuel : " + compte1.Solde + ". Decouvert autorisé : " + compte1.DecouvertAutorise + " ) : ");
                double num = Convert.ToDouble(Console.ReadLine());
                if (BNP.TransfererBanque(numAnswer, numAnswer2, num))
                {
                    Console.WriteLine(BNP.RendCompte(numAnswer));
                    Console.WriteLine(BNP.RendCompte(numAnswer2));
                }
                else Console.WriteLine("Transfert impossible");
            }

            Console.WriteLine("\n-------------------------------------------------------------------------------\n\n" +
                "Appuyez sur une touche pour quitter le programme !");
            Console.ReadLine();
        }
    }
}
