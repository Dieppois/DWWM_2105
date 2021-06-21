import java.util.Scanner;

public class _1_08_Annee_bissextile {

	public static void main(String[] args) {
	
		Scanner sc = new Scanner(System.in);
		String rep="";

		do {
		System.out.print("Entrez une année A : ");
		int annee = sc.nextInt();
		
		if (annee % 4 == 0) {
		if (annee % 100 == 0 && annee % 400 != 0); {
		System.out.println("L'année est bissextile.");
		}		
		}else System.out.println("L'année n'est pas bissextile.");

		System.out.println("Voulez-vous entrer une autre année ? O/N");
		sc.nextLine();
		rep=sc.nextLine().toLowerCase();
		
		}while ( rep.equals("o"));
		
		System.out.println("Fin");
		sc.close();
	}


	}


