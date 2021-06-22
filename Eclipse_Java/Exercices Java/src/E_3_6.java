/*Exercice 3.6 : Jeu du pendu 
L'algorithme lit un mot proposé par un premier joueur. 
Ce mot a une longueur minimum de 5 caractères (à contrôler). 
L'algorithme affiche ensuite le mot où toutes les lettres sauf la première et la dernière sont remplacées par un tiret. 
Un deuxième joueur propose des lettres une à une. 
Chaque fois que la lettre se trouve dans le mot, l'algorithme remplace les tirets qui remplaçaient cette lettre et 
réaffiche le mot. Le second joueur a droit à un maximum de 6 essais pour retrouver toutes les lettres.*/

import java.util.*;
public class E_3_6 {

	public static void main(String[] args) {


		Scanner sc = new Scanner (System.in);
		String rep = "void";

		do  {

			char test = ' ';
	
			int compteur =6;
			boolean trouve=false;
			System.out.println("Entrez un mot de minimum 5 caracteres");
			String mot ="test";
			mot = sc.nextLine();
			
			if (mot.length() < 6) {
				System.out.println("Le mot est trop court");
			} else 	
			{
				
				char [] pendu = new char [mot.length()];
				for (int i = 1; i < pendu.length-1; i++) {
					pendu[i] = '-';
				}
				pendu[0] = mot.charAt(0);
				pendu[mot.length()-1] = mot.charAt(mot.length()-1);

				do {
					System.out.println(pendu);

					System.out.println("Vous avez "+compteur+" chance(s) pour remplir le mot ");

					compteur--;

					test = sc.nextLine().charAt(0);

					for (int i = 1; i < mot.length()-1; i++) {
						if (test == mot.toCharArray()[i] ) {

							pendu[i]=mot.toCharArray()[i];
						}
					}

					trouve = verifLettre (pendu, ('-'));
					
					
				}while (   compteur >0 && trouve == false );


				System.out.println(pendu);
				if (trouve == true) {
					System.out.println("Vous avez gagnee");
				} else {
					System.out.println("Vous avez perdu");
				}
			}
			System.out.println("Voulez vous rejouer ? O/N");

			rep = sc.nextLine();

		}while(rep.equalsIgnoreCase("o"));
		System.out.println("Fin");
		sc.close();
	}

	public static boolean verifLettre(char[] _pendu, char _lettre){
		boolean trouvemot = true;
		for(int i = 0; i < _pendu.length; i++){
			if(_pendu[i] == _lettre){
				trouvemot = false;
				
			}
		}
		return trouvemot;
	}

}
