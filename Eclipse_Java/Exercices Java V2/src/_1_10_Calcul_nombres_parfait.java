import java.util.*;
public class _1_10_Calcul_nombres_parfait {

	public static void main(String[] args) {
	
		
		Scanner sc = new Scanner (System.in);
		String rep;
		
		System.out.println("Programme de recherche des nombres parfaits.");
		
		do {
		System.out.println("Combien de nombre parfaits souhaitez-vous afficher ?");
		int a = sc.nextInt();
		int compteur = 0;
		
		
		for (int i = 2; i < 500; i++) {
			long resultat =0;
			
			for (int j = 0; j < _1_09_Recherche_diviseur_nombre.rechercheDiviseur(i).length; j++) {
				if (_1_09_Recherche_diviseur_nombre.rechercheDiviseur(i)[j]!=0) {
				 resultat = resultat + _1_09_Recherche_diviseur_nombre.rechercheDiviseur(i)[j];
				 }
			}
			if (resultat+1 == i && compteur <= a) {
				compteur++;
				if (compteur == 1){ System.out.println("\nAffichage des "+a+" premiers nombres parfaits : ");}
				System.out.println(i+" est un nombre parfait.");
				
				}
			
			}
			System.out.println("Voulez vous recommencez ? O/N ");
			rep = sc.nextLine();
			
		}while (rep.equals("o"));
		
		System.out.println("Fin");
		sc.close();
	}

}

