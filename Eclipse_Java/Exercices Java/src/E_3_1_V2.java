/*Exercice 3.1 : Rechercher un nombre dans un tableau 
Soit un tableau de nombres tri�s par ordre croissant.
Chercher si un nombre donn� N figure parmi les �l�ments. 
Si oui, indiquer la valeur de l'indice correspondant. Sinon, indiquer � Non trouv� �*/

import java.util.*;
public class E_3_1_V2 {

	public static void main(String[] args) {


		int [] montab= new int[10];
		int recherche;
		Random aleas =new Random();
		boolean trouve=false;

		Scanner sc=new Scanner(System.in);

		for (int i = 0; i < montab.length; i++) 
		{


			montab[i]=aleas.nextInt(31);	

		}
		Arrays.sort(montab);
		System.out.println("Voici le tableau :");

		for (int i : montab) {

			System.out.print(i + " ");

		}

		System.out.println(" Veuillez saisir un nombre entier positif inf�rieur � 30 !!");
		recherche=sc.nextInt();
		int positiontab =0;
		do {
			if (montab[positiontab]==recherche)
			{

				trouve=true;
				//break;

			}


			positiontab++;

		} while (positiontab<=10 && trouve==false);

		if (positiontab>10) 
		{
			System.out.println("Le nombre ne se trouve pas dans le tableau!");

		}else 
		{
			System.out.println("Le nombre est dans le tableau � la position :"+positiontab);
		}

		sc.close();


	}

}


