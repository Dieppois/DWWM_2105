/*Exercice 3.6 : Jeu du pendu 
L'algorithme lit un mot propos� par un premier joueur. 
Ce mot a une longueur minimum de 5 caract�res (� contr�ler). 
L'algorithme affiche ensuite le mot o� toutes les lettres sauf la premi�re et la derni�re sont remplac�es par un tiret. 
Un deuxi�me joueur propose des lettres une � une. 
Chaque fois que la lettre se trouve dans le mot, l'algorithme remplace les tirets qui rempla�aient cette lettre et 
r�affiche le mot. Le second joueur a droit � un maximum de 6 essais pour retrouver toutes les lettres.*/

import java.util.*;
public class E_3_6 {

	public static void main(String[] args) {


		Scanner sc = new Scanner (System.in);
		String rep = "void";

		do  {

			char test = ' ';
			boolean flag= true;
			int compteur =6;
			
			System.out.println("Entrez un mot de minimum 5 caract�res");
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

					flag = verifLettre (pendu, ('-'));
					System.out.println(flag);
				}while (   compteur >0 && flag == true );

				// Pourquoi le programme marche avec && et pas avec || ???


				System.out.println(pendu);
				if (flag == false) {
					System.out.println("Vous avez gagn�");
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
		boolean value = false;
		for(int i = 0; i < _pendu.length; i++){
			if(_pendu[i] == _lettre){
				value = true;
				//     break;
			}
		}
		return value;
	}

}
