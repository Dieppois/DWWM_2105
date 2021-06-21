import java.text.DecimalFormat;
import java.util.*;
public class _1_01_Moyenne_2_nombres {

	public static void main(String[] args) {

		Scanner sc = new Scanner ( System.in )	;
		String rep;	
		DecimalFormat dF = new DecimalFormat("0.00");
		System.out.println("Programme de calcul de la moyenne de 2 nombres.");		

		do {
			System.out.println("Veuillez saisir autant de nombres entiers séparés par un espace que souhaité: ");
			String phrase = sc.nextLine();
			String [] monTab = phrase.split(" ");
			double resultat = 0;
			int compteur = 0;


			for (int i = 0; i < monTab.length; i++) {

				resultat = resultat + Double.parseDouble(monTab[i]);
				compteur++; 	
			}

			resultat = resultat / compteur; 

			System.out.print("La moyenne de ");

			for (String string : monTab) {
				if (!string.equalsIgnoreCase(monTab[monTab.length-1])) {
					System.out.print(string+ ", "); }

				else System.out.print("et "+string);

			}

			System.out.println(" est : " +dF.format(resultat)+".");

			System.out.println("Souhaitez-vous faire un autre calcul ? (O/N)");
			rep = sc.nextLine();

		}while ( rep.equalsIgnoreCase("o"));

		System.out.println("Appuyez sur une touche pour quitter.");
		rep = sc.nextLine();
		
		System.out.println("Fin");
		sc.close();

	}
}


