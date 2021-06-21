import java.util.*;
public class _2_07_Calcul_nombre_personnes {

	public static void main(String[] args) {

		Scanner sc = new Scanner (System.in);

		int [] monTab = new int  [20];
		int flag = 1;
		int flag2 = 1;

		System.out.println("Veuillez entrer l'âge de 20 personnes");


		for (int i = 0; i < monTab.length; i++) {
			monTab[i]=sc.nextInt();
			if ( monTab[i] > 20 )
				flag = 0;
			if ( monTab[i] <= 20)
				flag2 = 0;

		}

		if ( flag == 1) {
			System.out.println("TOUTES LES PERSONNES ONT MOINS DE 20 ANS");
		}
		else if ( flag2 == 1) {
			System.out.println("TOUTES LES PERSONNES ONT PLUS DE 20 ANS");
		} else {
			System.out.println("L'âge des personnes jeunes : ");
			for (int i = 0; i < monTab.length; i++) {
				if ( monTab[i] < 20)
					System.out.print(monTab[i]+" ");
			}
			System.out.println("\nL'âge des personnes non-jeunes ");
			for (int i = 0; i < monTab.length; i++) {
				if ( monTab[i] >= 20)
					System.out.print(monTab[i]+" ");
			}
		}

		System.out.println("Fin");
		sc.close();
	}	
}


