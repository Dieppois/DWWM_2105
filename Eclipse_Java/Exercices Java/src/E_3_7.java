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
		    int mid = (f + l)/2;                		 // d�finir le milieu du tableau
		    while(f <= l){                     			 //
		      if (tab[mid] < val){						// si val se trouve dans la partie inf du tableau
		        f = mid + 1;   							// f 0 = moiti� +1
		      }else if(tab[mid] == val){          		//  si ta trouv� 
		      //  System.out.println("L'�l�ment se trouve � l'index: " + mid); 
		        break;
		      }else{
		         l = mid - 1;                        	 // sinon l max = moiti� -1
		      }
		      mid = (f + l)/2;							// mid moiti� = ( 0 / moiti� +1 + moiti� - 1 / max ) / 2 
		   }
		    if (f > l){									// 
		      System.out.println("L'�l�ment n'existe pas!");
		    }
		   }

	}


