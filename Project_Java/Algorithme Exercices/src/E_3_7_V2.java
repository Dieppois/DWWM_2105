/* Exercice 3.7 : Recherche par dichotomie d'un élément dans un tableau classé 
Recherche par dichotomie d'un élément dans une table classée
Soit une table contenant des prénoms, classés par ordre alphabétique
Nous désirons chercher l'indice de la case de la table où se trouve le prénom, si il s'y trouve.
Pour cela, nous utiliserons la méthode de dichotomie (voir ci-dessous la méthode)
Donnez l'algorithme de la procédure qui recherche, par dichotomie le numéro du prénom recherché ou zéro s'il n'y 
est pas.
Principe de la recherche par dichotomie:
Les prénoms sont classés par ordre alphabétique
On connaît le nombre d'éléments de la table
Algorithme:
On partitionne la table en 2 sous-tables et un élément médian, et, suivant le résultat de la comparaison de l'élément 
médian et du prénom recherché (plus grand, plus petit ou égal) on recommence la recherche sur une des 2 soustables, 
jusqu'à avoir trouvé ou obtenir une sous-table vide (le prénom est alors absent de la table).
On cherche 'olga' dans la table:
Milieu: élément 4
'olga'>'cunégonde' -> 'olga' est entre 4 et 7
milieu: élément 6
'olga' < 'raymonde' -> 'olga' est entre 4 et 6
mileu: élément 5
'olga' trouvé en 5 */

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
				
				{System.out.println("La personne prenommée "+ _prenom +" se trouve à l'index: " + (mid+1)); 
				break;
			}else{
				f = mid - 1;                        													 // si val < tableau /2  => l max = mid-1
			}
			mid = (d + f)/2;																			 // mid moitié = ( 0 / moitié +1 + moitié - 1 / max ) / 2 
		}
		if (d > f){									
			System.out.println("L'élément n'existe pas!");
		}
	}

	
	
	
	
	
	
	
	
	

}


