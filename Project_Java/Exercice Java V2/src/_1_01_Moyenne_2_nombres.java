import java.util.*;
public class _1_01_Moyenne_2_nombres {

	public static void main(String[] args) {
		
	Scanner sc = new Scanner ( System.in )	;
		
	System.out.println("Programme de calcul de la moyenne de 2 nombres");		

	do {
	System.out.print("Veuillez saisir 2 nombres séparés par un espace : ");
	String phrase = sc.nextLine();
	System.out.println(phrase);
	String [] monTab = phrase.split(" ");
	double resultat = 0;
	int compteur = 0;
	
	for (int i = 0; i < monTab.length; i++) {
		
		resultat = resultat + Double.parseDouble(monTab[i]);
		compteur++; 
		
	}
	
	resultat = resultat / compteur; 
	
	System.out.println("La moyenne de " +monTab[0] +" et "+ monTab[1] +" est  : " +resultat);
		
	System.out.println("Souhaitez-vous faire un autre calcul ? (O/N)");
	String rep = "";
	
	}while ( rep = "o" )
	
	
	
	sc.close();
		
	}
	}


