

import java.util.Scanner;

public class hello_world {

	public static void main(String[] args) {
		
		String ReponseUtilisateur;
		
		System.out.println("Est-ce qu'il fera beau demain ?");
		
		Scanner sc= new Scanner(System.in);
		
		ReponseUtilisateur=sc.nextLine().toLowerCase();
		
		System.out.println(ReponseUtilisateur);
		
		if (ReponseUtilisateur.equals("oui")) {
			System.out.println(" J'arrache les mauvaises herbes! ");
			System.out.println(" Je plante des tulipes ");
		}
		else
		{
			System.out.println(" Je reste sur mon canapé à la maison ! ");

		}
		sc.close();
}
	

}

