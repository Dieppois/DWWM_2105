/*Exercice 2.6 : Ma bicyclette 
R�alisez l�algorithme et le programme correspondant au texte ci-dessous : 
S'il fait beau demain, j'irai faire une balade � bicyclette. 
Je n'ai pas utilis� ma bicyclette depuis plusieurs mois, peut-�tre n'est-elle plus en parfait �tat de fonctionnement.
Si c'est le cas, je passerai chez le garagiste avant la balade. J'esp�re que les r�parations seront imm�diates sinon je 
devrai renoncer � la balade en bicyclette. Comme je veux de toute fa�on profiter du beau temps, si mon v�lo n'est pas 
utilisable, j'irai � pied jusqu'� l'�tang pour cueillir les joncs.
S'il ne fait pas beau, je consacrerai ma journ�e � la lecture. J'aimerais relire le 1er tome de Game of Thrones. Je pense 
poss�der ce livre, il doit �tre dans la biblioth�que du salon. Si je ne le retrouve pas, j'irai l�emprunter � la biblioth�que 
municipale. Si le livre n'est pas disponible, j'emprunterai un roman policier. Je rentrerai ensuite directement � la 
maison.
D�s que j'aurai le livre qui me convient, je m'installerai confortablement dans un fauteuil et je me plongerai dans la 
lecture
*/

import java.util.Scanner;
/*Import de fonctionnalit� */

public class E_2_6 {
	/* Debut */

	public static void main(String[] args) {
		/* Structure */

		Scanner a = new Scanner(System.in);
		/* Fonction */

		String Reponse1;

		
		System.out.println("Est-ce qu'il fait beau ?");
		Reponse1 = a.nextLine().toLowerCase();
		if (Reponse1.equals("oui")) {
			
			System.out.println("La bicylette fonctionne ?");
			Reponse1 = a.nextLine().toLowerCase();
			if (Reponse1.equals("oui")) {
				
				System.out.println("Aller faire une balade en bicyclette");
			}else {
				System.out.println("Aller chez le garagiste");
				System.out.println("La r�paration est imm�diate ?");}
			Reponse1 = a.nextLine().toLowerCase();
			if (Reponse1.equals("oui")) {
	
					System.out.println("Aller faire une balade en bicyclette");
				} else {
					System.out.println("Aller � pied jusqu'a l'�tang pour cueillir des joncs");
				}
			} else {
			System.out.println("Est-ce que l'on poss�de le livre Game of Thrones ");
				}			
			Reponse1 = a.nextLine().toLowerCase();
			if (Reponse1.equals("oui")) {
				System.out.println("Aller s'installer confortablement dans un fauteuil et se plonger dans la lecture");
			} else {
				System.out.println("Aller � la biblioth�que municipale");
				System.out.println("Est-ce que Game of Thrones est dans la biblioth�que municipale?");
				Reponse1 = a.nextLine().toLowerCase();
	if (Reponse1.equals("oui")) {
					System.out.println("Aller emprunter Game of Thrones");
					System.out.println("Aller dans la maison");
					System.out.println("Aller s'installer confortablement dans un fauteuil et se plonger dans la lecture");
				} else {
					System.out.println("Aller emprunter un roman policier");
					System.out.println("Aller dans la maison");
					System.out.println("Aller s'installer confortablement dans un fauteuil et se plonger dans la lecture");
					
					
					}
	a.close();
				}
			}
		


}

	