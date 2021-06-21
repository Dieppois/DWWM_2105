import java.util.Scanner;

public class _2_06_Bicyclette {

	public static void main(String[] args) {

		Scanner sc = new Scanner(System.in);


		System.out.println("Est-ce qu'il fait beau ?");
		String Reponse1 = sc.nextLine().toLowerCase();

		if (Reponse1.equals("oui")) {

			System.out.println("La bicylette fonctionne ?");
			Reponse1 = sc.nextLine().toLowerCase();

			if (Reponse1.equals("oui")) {

				System.out.println("Aller faire une balade en bicyclette");

			}else {	

				System.out.println("Aller chez le garagiste \nLa réparation est immédiate ?");
				Reponse1 = sc.nextLine().toLowerCase();

				if (Reponse1.equals("oui")) {

					System.out.println("Aller faire une balade en bicyclette");

				} else {

					System.out.println("Aller à pied jusqu'a l'étang pour cueillir des joncs");
				}
			}
		} else {

			System.out.println("Est-ce que l'on possède le livre Game of Thrones ");			
			Reponse1 = sc.nextLine().toLowerCase();

			if (Reponse1.equals("oui")) {

				System.out.println("Aller s'installer confortablement dans un fauteuil et se plonger dans la lecture");

			} else {

				System.out.println("Aller à la bibliothèque municipale\nEst-ce que Game of Thrones est dans la bibliothèque municipale?");
				Reponse1 = sc.nextLine().toLowerCase();

				if (Reponse1.equals("oui") ) {

					System.out.println("Aller emprunter Game of Thrones\nAller dans la maison\nAller s'installer confortablement dans un fauteuil et se plonger dans la lecture");

				} else {

					System.out.println("Aller emprunter un roman policier\nAller dans la maison\nAller s'installer confortablement dans un fauteuil et se plonger dans la lecture");

				}
			}
		}
		
		System.out.println("Fin");
		sc.close();
	}
}

