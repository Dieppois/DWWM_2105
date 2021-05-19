/*
Exercice 1.4 : Inversion de 2 valeurs 
Lire 2 nombres a et b. 
Mettre le contenu de a dans b et celui de b dans a
 */

import java.util.Scanner;
public class E_1_4 {
	public static void main(String[] args) {
		String Reponse1;
		int[] array ={1, 2};

		//afficher les entiers du tableau
		for(int i = 0; i < array.length; i++)
		{
			System.out.println(array[i]);
		}
		//inverser les éléments du tableau
		for(int i = 0; i < array.length / 2; i++)
		{
			int temp = array[i];
			array[i] = array[array.length - i - 1];
			array[array.length - i - 1] = temp;
		}
		//afficher les entiers du tableau inversé
		System.out.println("tableau inversé");
		for(int i = 0; i < array.length; i++)
		{
			System.out.println(array[i]);
		}System.out.println("La bicylette fonctionne ?");
		Reponse1 = a.nextLine().toLowerCase();
	}if (Reponse1.equals("oui")) {
	}
}
}
}