import java.util.Scanner;

public class _3_03_Denombrer_lettres_alphabet_tableau {

	public static void main(String[] args) {

		Scanner sc = new Scanner (System.in);

		char [] alphabet = new char [26];
		char lettre ='a';
		for (int i = 0; i < alphabet.length; i++) {
			alphabet[i]=lettre;
			lettre++;
		}
		String phrase = "";	
		System.out.println("Ecrire un texte d'au moins 120 caract�res ");
		phrase = sc.nextLine();

		phrase = phrase.replaceAll(" ", "");
		phrase = phrase.replace("�", "e"); phrase = phrase.replace("�", "o");
		phrase = phrase.replace("�", "e"); phrase = phrase.replace("�", "e");
		phrase = phrase.replace("�", "e"); phrase = phrase.replace("�", "a");
		phrase = phrase.replace("�", "u"); phrase = phrase.replace("�", "i");


		if (phrase.length() >121) {
			letterFinder (alphabet, phrase);
		} else System.out.println("Le texte a moins de 120 caract�res");	

		System.out.println("Fin");
		sc.close();
	}

	static String letterFinder (char _tab [], String _phrase ) {


		for (int i = 0; i < _tab.length; i++) {
			char a = _tab [i];
			int compteur = 0;
			for (int j = 0; j < _phrase.length(); j++) {
				char b = _phrase.charAt(j);

				if (b == a )
					compteur++;
				if (j == _phrase.length()-1 && compteur > 0) 
					System.out.println("La lettre : "+_tab [i] +" apparait "+compteur +" fois.");
			}
		}
		return "";
	}

}
