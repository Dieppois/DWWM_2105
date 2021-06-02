/*Exercice 1.6 : Nombre Premier 
Lire un nombre N et déterminer s’il est un nombre premier.*/

import java.util.*;
public class E_1_6_V2 {
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

	/*
	static long rechercheDiviseur (long _unNombre )
	{
		long [] mesDiviseurs= new long[100];
		int compteurCase=0;

		//de int i = 2 jusqu'a i < _unNombre 
		for (int i = 2; i < _unNombre ; i++) {

			// modulo 	
			if (_unNombre%i==0)  {

				mesDiviseurs[compteurCase]=i;
				compteurCase++;

			}

			return mesDiviseurs;

		}
	}





/*
rechercheDiviseur (long _unNombre )

long nbtest=sc.nextLong();

long [] diviseurs= new long[50];

diviseurs=rechercheDiviseur (nbtest);

for (int i = 0; i < diviseurs.length; i++) 
{
	if (diviseurs[i]!= 0) {


	System.out.println(diviseurs[i]);


}*/
}	















