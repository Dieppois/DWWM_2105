import java.util.*;
public class E_3_2 {

	public static void main(String[] args) {
		
		Scanner sc = new Scanner (System.in);
		String test;
		
		do {
		System.out.print("Saisissez une phrase : ");
		String phrase = "";
		//String test2 = ".";
		phrase = sc.nextLine();
		
		if (phrase != "") {
		if	(!".".equals(phrase)) {
		
			System.out.print("Choisissez une lettre : ");		
		String lettre = sc.nextLine();
		char lettre2 = lettre.charAt(0);   
		int compteur = 0;
		
		
		for (int i = 0; i < phrase.length() ; i++) {
		    if (phrase.charAt(i) == lettre2)
		    {
		        compteur++;  
		    }    
		}
		if (compteur == 0)
		{
		System.out.print("La lettre n'est pas presente"); 
		}
		if (compteur>1) {
			System.out.println("La lettre est presente plusieurs fois\n");
			System.out.println("La lettre \""+lettre2+ "\" a "+compteur+ " occurence(s).");
		}
		else System.out.println("La lettre \""+lettre2+ "\" a "+compteur+ " occurence(s)."); 
			}
			else System.out.print("LA CHAINE EST VIDE");
	}	
		else System.out.print("La phrase est vide"); 
		
		System.out.println("\nVoulez vous recommencer ? O/N "); 
		test = sc.nextLine();
		
		
}
		while (test.equals ("o"));
		System.out.println("\nFin. ");
		sc.close();
}
}