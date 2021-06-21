import java.util.Scanner;

public class Exercice_Final_PGCD {

	public static void main(String[] args) {
		Scanner sc = new Scanner (System.in);

		int p = 0;
		int q = 0;

		String [] monTab;       
		String saisie =" ";

		System.out.println("Entrez 2 nombres entiers séparés d'un espace : ");

		saisie = sc.nextLine();									  		
		monTab = saisie.split(" "); 

		p= Integer.parseInt(monTab[0]);
		q= Integer.parseInt(monTab[1]);
		System.out.println("La fraction non simplifié est : " +p+"/"+q+"\n" );

		Calcul_PGCD (p,q);

		System.out.println("Fin");
		sc.close();

	}public static int Calcul_PGCD ( int p, int q) {


		int temp_p = p;
		int temp_q = q;


		while ( p != q) {
			if (p>q) 
			{ p = p - q; }
			else { q = q-p; }
		}

		int a = temp_p / p;
		int b = temp_q / p;


		System.out.println("PGCD = " +p );

		System.out.println("La fraction la plus simplifié : " +(a)+"/"+(b)+"\n" );
		return p;

	}

}
