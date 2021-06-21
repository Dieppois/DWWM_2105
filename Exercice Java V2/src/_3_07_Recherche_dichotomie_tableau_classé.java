import java.util.Scanner;
public class _3_07_Recherche_dichotomie_tableau_classé {

	public static void main(String[] args) {

		Scanner sc = new Scanner ( System.in);
		
		String [] monTab = {"agathe","berthe","chloe","cunegonde","olga","raymonde","sidonie"};

		System.out.print("Saisissez un prenom : ");
		String prenom = sc.nextLine();

		int val = valeurLettre (prenom);
		int f = monTab.length-1;
		int d = 0;   

		rechercheDichotomie(monTab,d,f,val,prenom);  

		System.out.println("Fin");
		sc.close();
	}
	public static int valeurLettre (String _mot) {

		char lettre = _mot.charAt(0);
		int val= lettre-96;

		return val;
	}	
	public static boolean comparerMot (String _mot, String _mot2 ) {

		
		if (_mot.equalsIgnoreCase(_mot2)) {
			return true; }
		else {
			return false;
		}


	}
	public static void rechercheDichotomie(String _tab[], int d, int f, int val, String _prenom){

		int mid= (d +f)/2;   																			
		while(d <= f){                     			 
			if (valeurLettre (_tab[mid]) < val){														
				d = mid + 1;   																			
			}else if(valeurLettre (_tab[mid]) == val && comparerMot(_tab[mid], _prenom) == true )  

			{System.out.println("La personne prenommée "+ _prenom +" se trouve à l'index: " + (mid+1)); 
			break;
			}else{
				f = mid - 1;                        													
			}
			mid = (d + f)/2;																			 
		}
		if (d > f){									
			System.out.println("L'élément n'existe pas!");
		}
		
	}

}
