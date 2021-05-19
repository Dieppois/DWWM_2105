/*Exercice 2.6 : Ma bicyclette 
Réalisez l’algorithme et le programme correspondant au texte ci-dessous : 
S'il fait beau demain, j'irai faire une balade à bicyclette. 
Je n'ai pas utilisé ma bicyclette depuis plusieurs mois, peut-être n'est-elle plus en parfait état de fonctionnement.
Si c'est le cas, je passerai chez le garagiste avant la balade. J'espère que les réparations seront immédiates sinon je 
devrai renoncer à la balade en bicyclette. Comme je veux de toute façon profiter du beau temps, si mon vélo n'est pas 
utilisable, j'irai à pied jusqu'à l'étang pour cueillir les joncs.
S'il ne fait pas beau, je consacrerai ma journée à la lecture. J'aimerais relire le 1er tome de Game of Thrones. Je pense 
posséder ce livre, il doit être dans la bibliothèque du salon. Si je ne le retrouve pas, j'irai l’emprunter à la bibliothèque 
municipale. Si le livre n'est pas disponible, j'emprunterai un roman policier. Je rentrerai ensuite directement à la 
maison.
Dès que j'aurai le livre qui me convient, je m'installerai confortablement dans un fauteuil et je me plongerai dans la 
lecture
*/

import java.util.Scanner;
/*Import de fonctionnalité */

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
				System.out.println("La réparation est immédiate ?");}
			Reponse1 = a.nextLine().toLowerCase();
			if (Reponse1.equals("oui")) {
	
					System.out.println("Aller faire une balade en bicyclette");
				} else {
					System.out.println("Aller à pied jusqu'a l'étang pour cueillir des joncs");
				}
			} else {
			System.out.println("Est-ce que l'on possède le livre Game of Thrones ");
				}			
			Reponse1 = a.nextLine().toLowerCase();
			if (Reponse1.equals("oui")) {
				System.out.println("Aller s'installer confortablement dans un fauteuil et se plonger dans la lecture");
			} else {
				System.out.println("Aller à la bibliothèque municipale");
				System.out.println("Est-ce que Game of Thrones est dans la bibliothèque municipale?");
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

	