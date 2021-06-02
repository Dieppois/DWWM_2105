/*Exercice 1.6 : Nombre Premier 
Lire un nombre N et déterminer s’il est un nombre premier.*/

import java.util.Scanner;


public class E_1_6_0 {
	public static void main(String[] args) {
		
		System.out.println("Veuillez entrer un nombre: ");
		Scanner sc = new Scanner(System.in);
		int reste;
		boolean flag = true;
		
		int nbr = sc.nextInt();
		
		for(int a=2; a <= nbr/2 ; a++)
		
		{
		reste = nbr%a;
		if(reste == 0)
		{
			flag = false ;
			break;
		}
	}
		
	if(flag)
		System.out.println(nbr + " est un nombre premier");
	else
		System.out.println(nbr+ "n'est pas un nombre premier");
	
	sc.close();
	}
	}
