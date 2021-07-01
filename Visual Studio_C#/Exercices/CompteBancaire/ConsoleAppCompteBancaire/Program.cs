using System;
using LibraryAppCompteBancaire;

namespace ConsoleAppCompteBancaire
{
    class Program
    {
        static void Main(string[] args)
        {
            String answer;
            CompteClient compte1 = new CompteClient(4815162342, "Bellamy", 1505, -100);
            CompteClient compte2 = new CompteClient(4815162343, "Octavia", 2007, -50);
            CompteClient compte3 = new CompteClient(4815162344, "Finn", 1985, -500);
            CompteClient compte4 = new CompteClient(4815162345, "Clark", 1007, -103);

            

            // Donner une représentation textuel de toutes ses informations
            Console.Write("Voulez-vous consulter votre compte ? O/N : ");
            answer = Console.ReadLine();
            if (answer.ToLower().Equals("o"))
            {
                Console.WriteLine(compte1.Afficher());
            }

            Console.Write("\nVoulez-vous consulter les autres comptes ? O/N : ");
            answer = Console.ReadLine();
            if (answer.ToLower().Equals("o"))
            {
                Console.WriteLine(compte2.Afficher());
                Console.WriteLine(compte3.Afficher());
                Console.WriteLine(compte4.Afficher());
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
                    Console.Write("PIndiquez le montant a transferer (Solde actuel : " + compte1.Solde + ". Decouvert autorisé : " + compte1.DecouvertAutorise + " ) : ");
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
                        if (compte1.Comparer(compte2) == true)
                            Console.WriteLine("Le Solde de votre compte de " + compte1.Solde + " est supérieur a celui du compte de " + compte2.Nom + " et son Solde de " + compte2.Solde);
                        else Console.WriteLine("Le Solde de votre compte de " + compte1.Solde + " est inférieur a celui du compte de " + compte2.Nom + " et son Solde de " + compte2.Solde);

                    else if (compte3.Nom == Answer)
                        if (compte1.Comparer(compte3) == true)
                            Console.WriteLine("Le Solde de votre compte de " + compte1.Solde + " est supérieur a celui du compte de " + compte3.Nom + " et son Solde de " + compte3.Solde);
                        else Console.WriteLine("Le Solde de votre compte de " + compte1.Solde + " est inférieur a celui du compte de " + compte3.Nom + " et son Solde de " + compte3.Solde);

                    else if (compte4.Nom == Answer)
                        if (compte1.Comparer(compte4) == true)
                            Console.WriteLine("Le Solde de votre compte de " + compte1.Solde + " est supérieur a celui du compte de " + compte4.Nom + " et son Solde de " + compte4.Solde);
                        else Console.WriteLine("Le Solde de votre compte de " + compte1.Solde + " est inférieur a celui du compte de " + compte4.Nom + " et son Solde de " + compte4.Solde);
                    else
                    {
                        Console.WriteLine("Mauvaise saisie, recommencez.");
                        flag = false;
                    }
                } while (flag == false);
            }

            Console.WriteLine("\n-------------------------------------------------------------------------------\n\n" +
                "Appuyez sur une touche pour quitter le programme !");
            Console.ReadLine();
        }
    }
}
