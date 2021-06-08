/* Exercice 3.7 : Recherche par dichotomie d'un �l�ment dans un tableau class� 
Recherche par dichotomie d'un �l�ment dans une table class�e
Soit une table contenant des pr�noms, class�s par ordre alphab�tique
Nous d�sirons chercher l'indice de la case de la table o� se trouve le pr�nom, si il s'y trouve.
Pour cela, nous utiliserons la m�thode de dichotomie (voir ci-dessous la m�thode)
Donnez l'algorithme de la proc�dure qui recherche, par dichotomie le num�ro du pr�nom recherch� ou z�ro s'il n'y 
est pas.
Principe de la recherche par dichotomie:
Les pr�noms sont class�s par ordre alphab�tique
On conna�t le nombre d'�l�ments de la table
Algorithme:
On partitionne la table en 2 sous-tables et un �l�ment m�dian, et, suivant le r�sultat de la comparaison de l'�l�ment 
m�dian et du pr�nom recherch� (plus grand, plus petit ou �gal) on recommence la recherche sur une des 2 soustables, 
jusqu'� avoir trouv� ou obtenir une sous-table vide (le pr�nom est alors absent de la table).
On cherche 'olga' dans la table:
Milieu: �l�ment 4
'olga'>'cun�gonde' -> 'olga' est entre 4 et 7
milieu: �l�ment 6
'olga' < 'raymonde' -> 'olga' est entre 4 et 6
mileu: �l�ment 5
'olga' trouv� en 5 */

import java.util.*;
public class E_3_7_V2 {

	public static void main(String[] args) {

		Scanner sc = new Scanner ( System.in);
		String [] monTab = {"agathe","berthe","chloe","cunegonde","olga","raymonde","sidonie"};

		System.out.print("Saisissez un prenom : ");

		String prenom = sc.nextLine();

		int val = valeurLettre (prenom);
		int f = monTab.length-1;
		int d = 0;   


		binarySearch(monTab,d,f,val,prenom);  


		sc.close();

	}public static int valeurLettre (String _mot) {

		char lettre = _mot.charAt(0);
		int val= lettre-96;
		
		return val;
	}
	
public static int valeurLettre2 (String _mot) {

	char lettre = _mot.charAt(1);
	int val= lettre-96;
	
	return val;
}


	public static void binarySearch(String _tab[], int d, int f, int val, String _prenom){

		int mid= (d +f)/2;   																			// mid du tableau
		while(d <= f){                     			 
			if (valeurLettre (_tab[mid]) < val){														// si val > tableau /2
				d = mid + 1;   																			// f mini = mid+1
			}else if(valeurLettre (_tab[mid]) == val && valeurLettre2 (_tab[mid]) == valeurLettre2 (_prenom))  
				
				{System.out.println("La personne prenomm�e "+ _prenom +" se trouve � l'index: " + (mid+1)); 
				break;
			}else{
				f = mid - 1;                        													 // si val < tableau /2  => l max = mid-1
			}
			mid = (d + f)/2;																			 // mid moiti� = ( 0 / moiti� +1 + moiti� - 1 / max ) / 2 
		}
		if (d > f){									
			System.out.println("L'�l�ment n'existe pas!");
		}
	}

	
	
	
	
	
	
	
	
	

}


