/*Exercice 1.6 : Nombre Premier 
Lire un nombre N et d�terminer s�il est un nombre premier.*/

import java.util.*;
public class E_1_7 {
	public static void main(String[] args) {

		Scanner sc =new Scanner (System.in);
		String recommencer="";
		long nbtest;
		boolean premier= true;

		do {
			long diviseur=2;
			premier= true;
			System.out.println("Veuillez saisir un nombre");
			nbtest=sc.nextLong();

			while (diviseur<Math.sqrt(nbtest) && premier==true) 
			{
				if (nbtest%diviseur==0) {

					premier=false;

			}
			diviseur++;

		}

		if (!premier) {
			System.out.println("Le nombre n'est pas premier car il a au moin un diviseur : " + ((diviseur-1)));	

		}

		else {
			System.out.println("Le nombre "+nbtest+" est premier");
		}


		System.out.println("Voulez-vous recommencer ? O/N");
		sc.nextLine();
		recommencer = sc.nextLine();
	}
	while (recommencer.charAt(0)=='O' && recommencer.length()<2 );
	sc.close();	
}

}