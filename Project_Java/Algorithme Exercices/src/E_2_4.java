/*Exercice 2.4 : Barnab� fait ses courses 
Barnab� fait ses courses dans plusieurs magasins. 
Dans chacun, il a d�pens� 1 euro de plus que la moiti� de ce qu�il avait en entrant. 
Dans le dernier magasin, il d�pense le solde.
Soit S la somme dont il disposait au d�part (S > 1 euro). 
Repr�senter l�algorithme permettant de trouver le nombre de magasins dans lesquels il a achet�.
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
	
	System.out.println("Barnab� est all� dans " + magasin + " magasins." );
	
	sc.close();
	}
	
}
