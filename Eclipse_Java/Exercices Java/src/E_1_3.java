/*Exercice 1.3 : Calcul de la surface d’un secteur circulaire 
Lire le rayon R d'un cercle et un angle A (en degré(s)). 
Calculer et afficher :
L’ aire du secteur circulaire = π R2 A / 360
 */


import java.util.Scanner;
public class E_1_3 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		
		String oui;


		do {


			double angle, rayon, aire;


			System.out.println("Entrez le rayon du cercle");
			rayon = sc.nextDouble();

			System.out.println("Entrez l'angle du cercle en degré ");
			angle = sc.nextDouble();

			aire = Math.PI*Math.pow(rayon, 2)*angle/360;


			System.out.println("La surface d'un secteur circulaire est :" +aire );
			System.out.println("\nContinuer ?");

			oui = sc.nextLine().toLowerCase();


		}
		while ( oui.equalsIgnoreCase("oui") );
		sc.close();
		
	

}


}