/*Exercice 2.4 : Barnabé fait ses courses 
Barnabé fait ses courses dans plusieurs magasins. 
Dans chacun, il a dépensé 1 euro de plus que la moitié de ce qu’il avait en entrant. 
Dans le dernier magasin, il dépense le solde.
Soit S la somme dont il disposait au départ (S > 1 euro). 
Représenter l’algorithme permettant de trouver le nombre de magasins dans lesquels il a acheté.
*/

import java.util.Scanner;	
public class E_2_4 {
public static void main(String[] args) {

	Scanner sc = new Scanner (System.in);
	double s= sc.nextDouble();
	int magasin=0;
	
	do {
		
	if (s>2) {
	
	System.out.println("Voici les calcules :"+s +"/2-1= " + ((s/2)-1) );	
	
	s = s/2-1;	}  
	
	magasin++;
	
	} while (s > 2);
	
	magasin++;
	
	System.out.println("Barnabé est allé dans " + magasin + " magasins." );
	
	sc.close();
	}
	
}
