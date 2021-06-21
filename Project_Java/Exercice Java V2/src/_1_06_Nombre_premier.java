import java.util.*;
public class _1_06_Nombre_premier {

	public static void main(String[] args) {
		
		Scanner sc =new Scanner(System.in);		
		String recommencer="";
		
		do {
			boolean premier= true;
			long diviseur=2;
			
			System.out.print("Veuillez saisir un nombre entier N : ");
			long nbtest=sc.nextLong();
			while(diviseur<nbtest && premier==true) 
			{ 
				if (nbtest%diviseur==0) {
					
					premier=false;
		
				}

				diviseur++;
				
			}
			
			if (!premier) {
        System.out.println("Le nombre "+nbtest+" n'est pas premier car il a au moins un diviseur : "+ (diviseur-1));
				
			}
			else {
				System.out.println("Le nombre "+nbtest+" est premier" );
			}
			
			System.out.println("Voulez-vous recommencer? O/N");
			sc.nextLine();
			recommencer=sc.nextLine();
			
			
		} while (recommencer.equalsIgnoreCase("o") );
		
		System.out.println("Fin");
		sc.close();
	}

}
