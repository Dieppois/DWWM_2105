/*Exercice 1.8 : Ann�e Bissextile 
Lire une ann�e A. 
D�terminer si l'ann�e A est bissextile. Si A n'est pas divisible par 4, l'ann�e n'est pas bissextile.
Si A est divisible par 4, l'ann�e est bissextile sauf si A est divisible par 100 et pas par 400.
Ecrire un message � Bissextile � ou � Non bissextile � suivant le cas.
 */

import java.util.Scanner;
public class E_1_8 {
	public static void main(String[] args) {


		System.out.print("Entrez une ann�e: ");
		Scanner s = new Scanner(System.in);
		int y = s.nextInt();
		boolean b = true;

		if(y % 400 == 0)
		{
			b = true;
		}
		else if (y % 100 == 0)
		{
			b = false;
		}
		else if(y % 4 == 0)
		{
			b = true;
		}
		else
		{
			b = false;
		}
		if(b == true)
		{
			System.out.println("L'ann�e "+ y +" est une ann�e bissextile");
		}
		else
		{
			System.out.println("L'ann�e "+ y +" n'est pas une ann�e bissextile");
		}
		System.out.println("Voulez-vous rentrer une autre ann�e ?");
		String rep=s.nextLine().toLowerCase();
		System.out.println(rep);

		s.close();
	}
}