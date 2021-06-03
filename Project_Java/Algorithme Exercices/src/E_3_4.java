/*Exercice 3.4 : Tri d'un tableau 
Nous désignerons par a1, a2, ..., aN les éléments d'un tableau à trier par ordre croissant.
On commence par chercher l'indice du plus petit des éléments, soit j cet indice. 
On permute alors les valeurs de a1 et aj .
On cherche ensuite l'indice du plus petit des éléments a2, a3, ..., an et on permute avec a2, etc.*/

import java.util.*;
public class E_3_4 {

	public static void main(String[] args) {

		Scanner sc = new Scanner (System.in);
		int [] monTab = new int [5];


		for (int i = 0; i < monTab.length; i++) 
		{
			monTab [i] = sc.nextInt();	
		}


		System.out.print("Le tableau non trie : ");
		System.out.println(afficherTableau (monTab));

		trieTableau (monTab);

		System.out.print("Le tableau trie : ");
		System.out.println(afficherTableau (monTab));

		sc.close();



	}
	static void trieTableau (int _monTab []) {

		int temp = 0;

		for (int i = 0; i < _monTab.length-1; i++) {
			for (int j = i+1; j < _monTab.length; j++) {
				if (_monTab [i] >_monTab [j]) {
					temp = _monTab [i];
					_monTab [i] = _monTab [j];
					_monTab [j] = temp;

				}
			}
		}
	}


	static String afficherTableau(int _monTab[]){
		for (int i = 0; i < _monTab.length; i++) 
		{
			System.out.print(_monTab [i] +" ");
		}
		return "";
	}
}
