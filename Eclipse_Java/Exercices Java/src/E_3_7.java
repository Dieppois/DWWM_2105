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
public class E_3_7 {

	public static void main(String[] args) {
		
	Scanner sc = new Scanner (System.in);
	
	String [][] monTab = {{"Agathe", "1"},
						{"Berthe","2"},
						{"Chloe", "3"},
						{"Cunegonde", "4"},
						{"Olga","5"},
						{"Raymonde","6"},
						{"Sidonie","7"}};
	
	int tab[] = {1, 2, 3, 4, 5, 6, 7};

	trierEffectif (monTab, tab);
	
	
	
	System.out.println("entrez nombre de 1 a 7");
	int val = sc.nextInt();
	int l = tab.length-1;
	int f = 0;   
	
	
	binarySearch(tab,f,l,val);  
	

	System.out.println(monTab[val-1][0]+" est dans le tableau, emplacement : "+(monTab[val-1][1]));

	
	
	
	
	sc.close();
	
	
	
	
	}
	
	public static void trierEffectif(String[][]_tabf2, int [] tempTab) {
		
		tempTab = new int [_tabf2.length];

		for (int i = 0; i < _tabf2.length; i++) {
				tempTab[i] = Integer.parseInt(_tabf2[i][1]); }
		
			String temp2 = "";
			int temp = 0;

			for (int i = 0; i < tempTab.length-1; i++) {
				for (int j = i+1; j < tempTab.length; j++) {
					if (tempTab [i] >tempTab [j]) {
						
						temp = tempTab [i];
						tempTab [i] = tempTab [j];
						tempTab [j] = temp;
						
						temp2 = _tabf2[i][1];
                        _tabf2[i][1] = _tabf2[j][1];
                        _tabf2[j][1] = temp2;
                     
                        temp2 = _tabf2[i][0];
                        _tabf2[i][0] = _tabf2[j][0];
                        _tabf2[j][0] = temp2;
	
	
	
					}

				}
			}
		
	}
		
	  public static void binarySearch(int tab[], int f, int l, int val){
		    int mid = (f + l)/2;                		 // définir le milieu du tableau
		    while(f <= l){                     			 //
		      if (tab[mid] < val){						// si val se trouve dans la partie inf du tableau
		        f = mid + 1;   							// f 0 = moitié +1
		      }else if(tab[mid] == val){          		//  si ta trouvé 
		      //  System.out.println("L'élément se trouve à l'index: " + mid); 
		        break;
		      }else{
		         l = mid - 1;                        	 // sinon l max = moitié -1
		      }
		      mid = (f + l)/2;							// mid moitié = ( 0 / moitié +1 + moitié - 1 / max ) / 2 
		   }
		    if (f > l){									// 
		      System.out.println("L'élément n'existe pas!");
		    }
		   }

	}


