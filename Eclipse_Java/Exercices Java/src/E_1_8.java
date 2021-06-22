/*Exercice 1.8 : Année Bissextile 
Lire une année A. 
Déterminer si l'année A est bissextile. Si A n'est pas divisible par 4, l'année n'est pas bissextile.
Si A est divisible par 4, l'année est bissextile sauf si A est divisible par 100 et pas par 400.
Ecrire un message « Bissextile » ou « Non bissextile » suivant le cas.
 */

import java.util.Scanner;
public class E_1_8 {
	public static void main(String[] args) {


		System.out.print("Entrez une année: ");
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
			System.out.println("L'année "+ y +" est une année bissextile");
		}
		else
		{
			System.out.println("L'année "+ y +" n'est pas une année bissextile");
		}
		System.out.println("Voulez-vous rentrer une autre année ?");
		String rep=s.nextLine().toLowerCase();
		System.out.println(rep);

		s.close();
	}
}