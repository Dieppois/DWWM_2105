import java.util.*;
public class _3_04_Tri_tableau {

	public static void main(String[] args) {

		Scanner sc = new Scanner (System.in);

		int [] monTab = new int [5];

		System.out.println("Saisissez 5 nombres à trier");

		for (int i = 0; i < monTab.length; i++) 
		{
			monTab [i] = sc.nextInt();	
		}

		System.out.print("Le tableau non trie : ");
		System.out.println(afficherTableau (monTab));

		trieTableau (monTab);

		System.out.print("Le tableau trie : ");
		System.out.println(afficherTableau (monTab));

		System.out.println("Fin");
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


