import java.util.Random;
import java.util.Scanner;

public class _2_05_Jeu_0_2 {
		

	public static  int tryParse(String _unechaine){
		int res;
		try {		
		res=  Integer.parseInt(_unechaine) ;
		}
		catch (NumberFormatException e) {

			res=4;
		}

		return res;
	}


	public static void main(String[] args) {
		
		Scanner sc=new Scanner(System.in); 
		int NbMachine;
		int NbUtilisateur;
		int Diff;
		int scoreUtilisateur = 0;
		int scoreBot = 0;
		String rep;
		Random aleas= new Random();
		do {
		do {
			do {

				System.out.println("Veuillez entrer un Nombre au choix entre 0-1-2, ou un nombre négatif pour arrêter la partie!");

				NbUtilisateur=tryParse(sc.nextLine());

			} while ( NbUtilisateur>=3 );

			NbMachine=aleas.nextInt(3); 


			if (NbUtilisateur>=0) {

				Diff=Math.abs(NbUtilisateur-NbMachine);

				switch (Diff) {
				case 2:
					if (NbUtilisateur> NbMachine) 
					{		
						scoreUtilisateur++;
						System.out.println("bravo vous avez gagné un point  votre score est de " + scoreUtilisateur +" score Machine :" +scoreBot);

					}else {
						scoreBot++;
						System.out.println("La machine gagne un point  son score est de " + scoreBot +" et votre est de :" +scoreUtilisateur) ;

					}

					break;
				case 1:
					if (NbUtilisateur< NbMachine) 
					{
						scoreUtilisateur++;
						System.out.println("bravo vous avez gagné un point  votre score est de " + scoreUtilisateur +" score Machine :" +scoreBot);

					}else {
						scoreBot++;
						System.out.println("La machine gagne un point  son score est de " + scoreBot +" et votre est de :" +scoreUtilisateur) ;
					}
					break;
				case 0:
					System.out.println("Match nul, personne ne marque de point : Score utilisateur "+ scoreUtilisateur +" score machine :"+ scoreBot);

					break;
				default:
					System.out.println(" valeur imprévue"); 

					break;
				}
			}

		} while (scoreBot<10 && scoreUtilisateur<10 && NbUtilisateur>=0  );

		if (NbUtilisateur<0) {

			System.out.println("\nVous avez arrêté le jeu! Le score de la machine est :" + scoreBot+" votre score est : " +scoreUtilisateur);
		}
		else if(scoreUtilisateur >=10)
		{
			System.out.println("\nBravo vous avez gagné! vous atteint 10 points, le score de la machine est :" + scoreBot);
		}
		else {
			System.out.println("\nPerdu ! Machine 10 points!  Essai encore!! Votre score était de :" + scoreUtilisateur);
		}
		
		System.out.println("Voulez vous recommencer ? O/N");
		rep = sc.nextLine();
		}while (rep.equalsIgnoreCase("o"));
	
		System.out.println("Fin");
		sc.close();

	}

}
