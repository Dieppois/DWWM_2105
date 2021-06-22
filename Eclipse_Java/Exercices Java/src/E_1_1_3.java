/* Exercice 1.1 : Calcul de la moyenne de 2 nombres

Exercice 1.1.3 :
L’utilisateur peut saisir autant de nombres entiers qu’il souhaite. Chaque nombre entier saisi doit être séparé par un
espace. Le programme calcule la moyenne de tous les nombres saisis.
 */

import java.util.Scanner;
public class E_1_1_3 {
	public static void main(String[] args) {

		Scanner sc = new Scanner (System.in);
		double somme = 0;
		double compteur =0;
		String [] array;                                           /*ini tableau String*/
		String saisie=" ";                                         /*ini variable String*/

		System.out.println("Entrez autant de nombres entier que vous voulez séparé d'un espace : ");

		saisie = sc.nextLine();									   /*definir valeur variable String */				
		array= saisie.split(" ");								   /*definir valeur tableau String */ /* si pas .plit(" ") ??? */


		for (int i = 0; i < array.length; i++) {

			double somme1 = Double.parseDouble (array[i]);
			somme = somme + somme1;
			compteur++;

		}

		somme = (somme / compteur );

		System.out.println("La moyenne est : " +somme );

		sc.close();
	}
}