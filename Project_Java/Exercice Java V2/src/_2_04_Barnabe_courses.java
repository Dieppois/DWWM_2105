import java.util.Scanner;

public class _2_04_Barnabe_courses {

	public static void main(String[] args) {
		
		Scanner sc = new Scanner (System.in);
		int magasin=1;
		
		System.out.println("Entrez le solde" );
		double s= sc.nextDouble();
		
		
		if (s > 2) {
		do {
				System.out.println("Magasin numero "+magasin+" : "+s +"/2-1 = " + ((s/2)-1) );	
				s = s/2-1;	 

			magasin++;

		} while (s > 2);
	}
		
		
		System.out.println("\nDernier magasin numero "+magasin+" : "+s+"-"+s+" = "+(s-s) );	
		System.out.println("\nBarnabé est allé dans " + magasin + " magasins." );

		System.out.println("Fin");
		sc.close();

	}

}
