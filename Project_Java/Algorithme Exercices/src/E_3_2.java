/*Exercice 3.2 : Rechercher une lettre dans un chaine de caractères 
Soit une chaîne de caractères terminée par le caractère « . ». 
Donnez l'algorithme d'un programme qui compte le nombre d'occurrences d'une lettre donnée (« a » par exemple) 
dans cette chaîne.
Si la chaîne de caractères n'est composée que du caractère « . », le message « LA CHAINE EST VIDE » sera affiché.
Proposez un jeu d'essai prévoyant les 3 cas suivants :
▪ La phrase est vide
▪ La lettre n'est pas présente
▪ La lettre est présente plusieurs fois*/


import java.util.*;
public class E_3_2 {

	public static void main(String[] args) {

		Scanner sc = new Scanner (System.in);
		String test;

		do {
			System.out.print("Saisissez une phrase : ");
			String phrase = "";
			//String test2 = ".";
			phrase = sc.nextLine();

			if (phrase != "") {
				if	(!".".equals(phrase)) {

					System.out.print("Choisissez une lettre : ");		
					String lettre = sc.nextLine();
					char lettre2 = lettre.charAt(0);   
					int compteur = 0;


					for (int i = 0; i < phrase.length() ; i++) {
						if (phrase.charAt(i) == lettre2)
						{
							compteur++;  
						}    
					}
					if (compteur == 0)
					{
						System.out.print("La lettre n'est pas presente"); 
					}
					if (compteur>1) {
						System.out.println("La lettre est presente plusieurs fois\n");
						System.out.println("La lettre \""+lettre2+ "\" a "+compteur+ " occurence(s).");
					}
					else System.out.println("La lettre \""+lettre2+ "\" a "+compteur+ " occurence(s)."); 
				}
				else System.out.print("LA CHAINE EST VIDE");
			}	
			else System.out.print("La phrase est vide"); 

			System.out.println("\nVoulez vous recommencer ? O/N "); 
			test = sc.nextLine();


		}
		while (test.equals ("o"));
		System.out.println("\nFin. ");
		sc.close();
	}
}