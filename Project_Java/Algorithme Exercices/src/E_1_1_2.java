/* Exercice 1.1 : Calcul de la moyenne de 2 nombres
  
Exercice 1.1.2 :
Apr�s chaque calcul, l�utilisateur est invit� � r�aliser un autre calcul ou quitter le programme.

Exemple d�affichage en mode Console
Programme de calcul de la moyenne de 2 nombres.
Veuillez saisir 2 nombres s�par�s par un espace :
12 81
La moyenne de 12 et 81 est : 46.5
Souhaitez-vous faire un autre calcul ? (O/N)
O
Veuillez saisir 2 nombres s�par�s par un espace :
23 577
La moyenne de 23 et 577 est : 300
Souhaitez-vous faire un autre calcul ? (O/N)
N
Appuyez sur une touche pour quitter.
*/

import java.text.DecimalFormat;
import java.util.Scanner;
public class E_1_1_2 {
	public static void main(String[] args) {

		String test;
		String a;
		String b;
		double moyenne;
		Scanner sc = new Scanner(System.in);
		String R�ponse;
		
		do {
			
		System.out.println("Entrez deux nombres s�par�s d'un espace :");
		 	
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
		System.out.println("Souhaitez-vous faire un autre calcul ? (O/N)");
		
		R�ponse = sc.nextLine().toLowerCase();
		} while (R�ponse.equals("o"));
		
		sc.close();
				
}
}