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
m�dian et du pr�nom recherch� (plus grand, plus petit ou �gal) on recommence la recherche sur une des 2 soustables, jusqu'� avoir trouv� ou obtenir une sous-table vide (le pr�nom est alors absent de la table).
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
		

	}

}
