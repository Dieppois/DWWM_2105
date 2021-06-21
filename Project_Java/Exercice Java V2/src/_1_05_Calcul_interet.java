import java.util.*;
public class _1_05_Calcul_interet {

	public static void main(String[] args) {
		Scanner sc = new Scanner (System.in);

		System.out.println("Saisissez la somme initial S : ");
		int somme = sc.nextInt();
		System.out.println("Saisissez l'interet i : ");
		double interet = sc.nextDouble();
		System.out.println("Saisissez le nombre d'ann�es de placement N : ");
		int annee = sc.nextInt();

		System.out.println("La valeur acquise par la somme S "+somme+ " plac�e pendant "+annee+" ann�es  : ");
		System.out.println("Avec un int�r�t simple : "+Math.round((somme* ( 1 + annee * interet ) )));
		System.out.println("Avec un int�r�t compos� : "+Math.round(somme*Math.pow(( 1 + interet ),annee)));

		System.out.println("Fin");
		sc.close();
	}

}
