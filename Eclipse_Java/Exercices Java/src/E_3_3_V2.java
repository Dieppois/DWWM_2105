import java.util.*;
public class E_3_3_V2 {


	public static void main(String[] args) {

		Scanner sc = new Scanner (System.in);

		String phrase = "";
		char [] alphabet = new char [26];
		int [] tabTrie = new int [26];
		char lettre ='a';
		for (int i = 0; i < alphabet.length; i++) {
			alphabet[i]=lettre;
			lettre++;
		}


		System.out.println("Saisissez une phrase de 120 char mini : ");


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
			trouverLettreCreerTableau (alphabet, phrase, tabTrie);
			trieTableau (tabTrie);

			System.out.println("_____________________________________________________________________________________________________________________");




			for (int k = 0; k < tabTrie.length; k++) {


				for (int i = 0; i < alphabet.length; i++) {
					char a = alphabet [i];
					int compteur = 0;
					for (int j = 0; j < phrase.length(); j++) {
						char b = phrase.charAt(j);

						if (b == a )
						{ 
							compteur++;
						}

					}
					if (tabTrie [k] == compteur && compteur > 0) 
					{
						System.out.println("La lettre : "+alphabet [i] +" apparait "+compteur +" fois.");
					}
				}
			}
		} else System.out.println("La phrase est de moins de 120 char");
		sc.close();
	}

	static int [] trouverLettreCreerTableau (char _tab [], String _phrase, int [] _tab2 ) {
		int compteur = 0;
		int test = 0;

		for (int i = 0; i < _tab.length; i++) {
			for (int j = 0; j < _phrase.length(); j++) {

				if (_tab [i] == _phrase.charAt(j) )
				{ 
					compteur++;
				}

			}
			_tab2 [test] =compteur;
			test++;
			compteur =0;
		}
		return _tab2;
	}
	static void trieTableau (int _monTab [])
	{
		int temp = 0;
		for (int i = 0; i < _monTab.length-1; i++) {
			for (int j = i+1; j < _monTab.length; j++) {
				if (_monTab [i] ==_monTab [j]){
					_monTab [j] =0 ;

				}
				if (_monTab [i] >_monTab [j]) {
					temp = _monTab [i];
					_monTab [i] = _monTab [j];
					_monTab [j] = temp;}
			}
		}
	}
}

