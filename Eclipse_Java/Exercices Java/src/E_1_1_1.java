/*Exercice 1.1 : Calcul de la moyenne de 2 nombres

Exercice 1.1.1 :
 
L’utilisateur est invité à saisir 2 nombres entier.
Le programme calcule la moyenne des 2 nombres et affiche le résultat sous forme de nombre réel double précision

Exemple d’affichage en mode Console
Programme de calcul de la moyenne de 2 nombres.
Veuillez saisir 2 nombres séparés par un espace :
12 81
La moyenne de 12 et 81 est : 46.5
Appuyez sur une touche pour quitter.
 */

import java.text.DecimalFormat;
import java.util.Scanner;
public class E_1_1_1 {
	public static void main(String[] args) {

		String test;
		String a;
		String b;
		double moyenne;
		Scanner sc = new Scanner(System.in);
		
		System.out.println("Entrez deux nombres séparés d'un espace :");
		 	
		test = sc.nextLine();
		
		int position= test.indexOf(" ");
		int fin =test.length();
		a = test.substring(0, position);
		b = test.substring(position+1, fin);
		
		double int_val = Integer.valueOf(a);
		double int_val2 = Integer.valueOf(b);
		
		moyenne = (int_val + int_val2)/2;
		
		DecimalFormat df = new DecimalFormat("0.00");
		System.out.println("La moyenne de ces deux nombres est :");
		System.out.println(df.format(moyenne));
		
		sc.close();
			
}
}