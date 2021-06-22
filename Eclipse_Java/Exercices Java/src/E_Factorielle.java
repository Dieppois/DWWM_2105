/*Règle sur les factorielles:​

Le factorielle d’un nombre n est le factorielle du nombre (n-1) fois n.​

Le factorielle de 1 est 1.​

Exercice​

Réalisez à partir de cette définition une fonction récursive permettant de calculer le factorielle de n’importe quel nombre.
 */
import java.util.*;
public class E_Factorielle {

	public static void main(String[] args) {

		// Soit un nombre n n(n-1)(n-2)(n-(n-2)) 5*4*3*2
		
		Scanner sc = new Scanner (System.in);

		System.out.print("Choisir un nombre pour fonction factorielle : ");

		long a = sc.nextInt();

		System.out.println("Factorielle test : "+factorielle(a));

		sc.close();

	}	
	public static long factorielle (long _a) {


		if ( _a < 1 ) {
			return 1;
		}
		else {
			return factorielle(_a -1)*_a;

		}
	}
}

