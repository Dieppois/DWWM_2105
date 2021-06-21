import java.util.Scanner;
public class _3_05_Palindrome{

	public static void main(String[] args) {

		Scanner sc = new Scanner (System.in);
		String rep;
		
		do {

			System.out.println("Saisissez une phrase ou une suite de nombres terminés par un point.");
			String phrase = sc.nextLine();

			phrase=phrase.replaceAll("\'", "" );
			phrase=phrase.replaceAll("\\.", "" );
			phrase=phrase.replaceAll(" ", "");

			if (phrase.equalsIgnoreCase("")) {

				System.out.println("LA CHAINE EST VIDE");

			} else {
				
				if ( palindrome(phrase) )
					System.out.println("Palindrome");	
				else
					System.out.println("PAS Palindrome");	
			}

			System.out.println("Voulez-vous continuer ? O/N ");
			rep = sc.nextLine();


		}while (rep.equalsIgnoreCase("o"));


		System.out.println("Fin");	
		sc.close();


	}public static boolean palindrome(String n) {

		if(n.length()==0 || n.length()== 1) 
			return true;
		if (n.charAt(0)==n.charAt(n.length()-1))
			return palindrome(n.substring(1, n.length()-1));
		return false;
	}

}




