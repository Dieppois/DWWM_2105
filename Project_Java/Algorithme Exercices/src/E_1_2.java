/*Exercice 1.2 : Calcul de l’aire et du volume d’une sphère 

Lire le rayon R d'une sphère. 
Calculer et afficher :
Son aire = 4 π R2
Son volume = 4/3 π R3

 */

import java.util.Scanner;

public class E_1_2 {

	public static void main(String[] args) {

		Scanner sc = new Scanner(System.in);

		double volume;	
		double aire, rayon;


		System.out.println("Entrez le rayon d'une sphère");
		rayon = sc.nextDouble();

		aire = Math.PI*Math.pow(rayon, 2)*4;
		volume = 4*Math.PI*Math.pow(rayon, 3)/3;

		System.out.println("La superficie de la sphère est :" + aire+ "\nLe volume de la sphère est :" + volume);

		sc.close();
	}

}