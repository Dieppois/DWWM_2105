/*Exercice final : Calcul du PGCD de 2 entiers positifs (Codage uniquement) 
En arithmétique élémentaire, le plus grand commun diviseur ou PGCD de deux nombres entiers non nuls est le plus 
grand entier qui les divise simultanément. 
Par exemple, le PGCD de 20 et de 30 est 10, puisque leurs diviseurs communs sont 1, 2, 5 et 10.
On souhaite écrire un programme de calcul du PGCD de deux entiers non nuls strictement positifs, à partir de 
l’algorithme de la méthode dite « égyptienne ».
Voici une spécification de l'algorithme de calcul du PGCD de deux nombres (entiers strictement positifs) p et q, selon 
cette méthode : 
Lire (p, q )
 TantQue p ≠ q 
 Faire 
 Si p > q Alors
 p ← p – q 
 Sinon 
 q ← q – p 
 FinSi 
 Fin TantQue
Ecrire( " PGCD = " , p ) 
Version 1 :
Réalisez le programme correspondant. L’algorithme ci-dessus doit être implémenté dans une fonction nommée 
« Calcul_PGCD » qui accepte 2 nombres entiers en paramètres et retourne le PGCD calculé au format nombre entier.
La signature de la méthode Calcul_PGCD est : Calcul_PGCD ( int a , int b ) : int.
Conservez votre fonction Calcul_PGCD, elle vous sera utile pour les exercices suivants.
Exemple d’affichage en mode Console :
Programme de calcul du PGCD de 2 nombres entiers positifs
Saisir le 1er nombre : 
176
Saisir le 2nd nombre : 
892
Le PGCD de 176 et 892 est égal à 4.
Version 2 :
En vous inspirant des exercices précédents, proposez une version améliorée et intuitive du programme.
 */

import java.util.*;
public class E_Final {

	public static void main(String[] args) {
		
		Scanner sc = new Scanner (System.in);
		
		int p = 0;
		int q = 0;
		
		String [] monTab;       
		String saisie =" ";
		
		System.out.println("Entrez 2 nombres entiers séparés d'un espace : ");

		saisie = sc.nextLine();									  		
		monTab = saisie.split(" "); 
		
		p= Integer.parseInt(monTab[0]);
		q= Integer.parseInt(monTab[1]);
	System.out.println("La fraction non simplifié est : " +p+"/"+q+"\n\n" );
		
		Calcul_PGCD (p,q);

		sc.close();
		
		
	}public static int Calcul_PGCD ( int p, int q) {
	
		
		int temp_p = p;
		int temp_q = q;
			
			
	while ( p != q) {
				if (p>q) 
				{ p = p - q; }
				else { q = q-p; }
			}
			// p=q  à la fin il n'y a  qu'un pgcd vous avez bien compris le raisonnement.
			int a = temp_p / p;
			int b = temp_q / p;
			
			
			System.out.println("PGCD = " +p );
		
			System.out.println("La fraction la plus simplifié : " +(a)+"/"+(b)+"\n\n" );
			return p;
			
			
	}
	}
	
