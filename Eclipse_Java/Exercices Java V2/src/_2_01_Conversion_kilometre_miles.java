import java.text.DecimalFormat;
import java.util.Scanner;
public class _2_01_Conversion_kilometre_miles {

	public static void main(String[] args) {

		Scanner sc= new Scanner(System.in );
		DecimalFormat dF = new DecimalFormat ("0.000");

		String saisie=" ";
		double distance;
		String [] monTab;
		double [][] monTab2 = new double [10][10];
		double [][] monTab3 = new double [10][10];
		int compteur = 1, compteur2 = 1;

		
		 
	        
	        System.out.println("Programme de conversion Kilomètres <-> Miles.");
		do {
			System.out.println("Saisir une valeur et son unité de mesure (km / mi) séparés par un espace : "+"\n"+"Ou");
			System.out.println("Saisir: go pour afficher le(s) résultat(s) / quit pour quitter le programme.");

			saisie = sc.nextLine();
			if (!saisie.equals("quit")) {

				if (saisie.equals("go")) {
					for (int i = 0; i < monTab3.length; i++) {
						if(monTab3[i][0] != 0) {
							System.out.println(monTab3[i][0] +" mi = "+ dF.format(monTab3[0][i])+" km");}
					}
					for (int i = 0; i < monTab2.length; i++) {
						if(monTab2[i][0] != 0) {
							System.out.println(monTab2[i][0] +" km = "+ dF.format(monTab2[0][i])+" mi");}
					}
				}

				else {

					monTab= saisie.split(" ");
					distance=Double.parseDouble(monTab[0]);
					if (monTab.length > 1 && monTab[1].equals("mi")) {

					    double res= distance*1.609344 ;	
						monTab3[compteur][0]=distance;
						monTab3[0][compteur]=res;
						compteur++;

					}else {

						double res= distance/1.609344 ;
						monTab2[compteur2][0]=distance;
						monTab2[0][compteur2]=res;
						compteur2++;
					}
				}

			}

		}while (!saisie.equals("quit"));
		
		System.out.println("Fin");
		sc.close();
	}
}
