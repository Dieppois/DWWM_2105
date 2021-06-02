/*Exercice final : Calcul du PGCD de 2 entiers positifs (Codage uniquement) 
En arithmétique élémentaire, le plus grand commun diviseur ou PGCD de deux nombres entiers non nuls est le plus 
grand entier qui les divise simultanément. 
Par exemple, le PGCD de 20 et de 30 est 10, puisque leurs diviseurs communs sont 1, 2, 5 et 10.
On souhaite écrire un programme de calcul du PGCD de deux entiers non nuls strictement positifs, à partir de 
l’algorithme de la méthode dite « égyptienne ».
Voici une spécification de l'algorithme de calcul du PGCD de deux nombres (entiers strictement positifs) p et q, selon 
cette méthode : 
Lire (p, q )
 TantQue p ≠ q 
 Faire 
 Si p > q Alors
 p ← p – q 
 Sinon 
 q ← q – p 
 FinSi 
 Fin TantQue
Ecrire( " PGCD = " , p ) 
Version 1 :
Réalisez le programme correspondant. L’algorithme ci-dessus doit être implémenté dans une fonction nommée 
« Calcul_PGCD » qui accepte 2 nombres entiers en paramètres et retourne le PGCD calculé au format nombre entier.
La signature de la méthode Calcul_PGCD est : Calcul_PGCD ( int a , int b ) : int.
Conservez votre fonction Calcul_PGCD, elle vous sera utile pour les exercices suivants.
Exemple d’affichage en mode Console :
Programme de calcul du PGCD de 2 nombres entiers positifs
Saisir le 1er nombre : 
176
Saisir le 2nd nombre : 
892
Le PGCD de 176 et 892 est égal à 4.
Version 2 :
En vous inspirant des exercices précédents, proposez une version améliorée et intuitive du programme.
 */

import java.util.*;
public class E_Final {

	public static void main(String[] args) {
		Scanner sc = new Scanner (System.in);
		int [] monTab = new int [5];



		for (int i = 0; i < monTab.length; i++) 
		{
			monTab [i] = sc.nextInt();	
		}

		System.out.println(afficherTableau (monTab));


	}



	static String afficherTableau(int monTab[]){
		for (int i = 0; i < monTab.length; i++) 
		{
			System.out.print(monTab [i] +" ");
		}
		return "";
	}

	void Calcul_PGCD (int tableau[])
	{
		int passage = 0;
		boolean permutation = true;
		int en_cours;

		while ( permutation) {
			permutation = false;
			passage ++;
			for (en_cours=0;en_cours<20-passage;en_cours++) {
				if (tableau[en_cours]>tableau[en_cours+1]){
					permutation = true;
					// on echange les deux elements
					int temp = tableau[en_cours];
					tableau[en_cours] = tableau[en_cours+1];
					tableau[en_cours+1] = temp;
				}
			}
		}

	}
}