import java.util.Random;
import java.util.Scanner;

public class _2_03_Jeu_fourchette {

	public static void main(String[] args) {

		Scanner sc = new Scanner(System.in);
		String r�ponse;

		do {

			int min = 0;
			int max = 100;
			int compteur=0;
			Random aleas= new Random();
			int nbMachine = aleas.nextInt(101);	
			int nbUser =0;


			do {
				System.out.println("Choisissez un nombre entre : "+ min+ " et " +max);
				System.out.println("Vous avez " + (5-compteur) +" essaies");

				System.out.println(nbMachine+" "+compteur);
				nbUser=sc.nextInt();

				if (nbUser > nbMachine) {

					max=nbUser;
					compteur++;

				}
				else if(nbUser < nbMachine)
				{
					min=nbUser;
					compteur++;
				}
				else if(nbUser == nbMachine){
					compteur++;
				}

			} while ( nbUser != nbMachine && compteur <5);

			if (nbUser == nbMachine) {
				System.out.println("Victoire, vous avez r�ussi en : " +(compteur) +" coups");
			} else {
				System.out.println("Perdue, le nombre recherch� �tait : " +nbMachine);
			}

			System.out.println("Voulez vous rejouer ? O/N" );
			sc.nextLine();
			r�ponse = sc.nextLine();
		} while (r�ponse.equalsIgnoreCase("O"));
	
		System.out.println("Fin");
		sc.close();

	}

}
