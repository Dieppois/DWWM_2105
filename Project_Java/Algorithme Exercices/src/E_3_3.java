/*Exercice 3.3 : Dénombrer les lettres de l'alphabet dans un tableau 
Lire un texte d'au moins 120 caractères (à contrôler). 
Compter et afficher le nombre d'occurrences (d'apparitions) de chacune des lettres de l'alphabet*/

import java.util.*;
public class E_3_3 {

	public static void main(String[] args) {

		Scanner sc = new Scanner (System.in);

		String phrase = "";
		char [] alphabet = {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};


		System.out.println("Ecris une phrase");
		phrase = sc.nextLine();

		phrase = phrase.replaceAll(" ", "");
		phrase = phrase.replace("è", "e");
		phrase = phrase.replace("é", "e");
		phrase = phrase.replace("ê", "e");
		phrase = phrase.replace("ë", "e");
		phrase = phrase.replace("à", "a");
		phrase = phrase.replace("ù", "u");
		phrase = phrase.replace("î", "i");
		phrase = phrase.replace("ô", "o");

		if (phrase.length() >121) {
		letterFinder (alphabet, phrase);
		} else System.out.println("La phrase est de moins de 120 char");
		sc.close();
	}
	static String letterFinder (char _tab [], String _phrase ) {
		int compteur = 0;
		
		for (int i = 0; i < _tab.length; i++) {
			char a = _tab [i];
			
			for (int j = 0; j < _phrase.length(); j++) {
				char b = _phrase.charAt(j);

				if (b == a )
				{ 
					compteur++;
				}
				if (j == _phrase.length()-1 && compteur > 0) 
				{
					System.out.println("La lettre : "+_tab [i] +" apparait "+compteur +" fois.");}
			}

			compteur =0;
		}
		return "";
		
	
	}
}


