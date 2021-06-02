/* Exercice 1.5 : Calcul d’intérêts 
Lire la somme initiale S placée sur un compte, l'intérêt i offert par la banque et le nombre N d'années de placement 
de la somme S.
Calculez la valeur acquise par la somme S placée pendant N années :
▪ avec un intérêt simple : S ( 1 + N * i )
▪ avec un intérêt composé : S ( 1 + i 
*/

import java.util.Scanner;
public class E_1_5 {
	public static void main(String[] args) {
	
		
	Scanner sc =new Scanner(System.in);
		
		System.out.println("Veuillez entrer la somme initiale");
		double a = sc.nextDouble();
		System.out.println("Veuillez entrer l'intérêt");
		double b = sc.nextDouble();	
		System.out.println("Veuillez entrer le nombres d'années");
		double c = sc.nextDouble();
		
		double reponse = a*(1+c*b);
		System.out.println("Intérêt simple = " + reponse);
		
		double reponse2 = a*(1+b)*c;
		System.out.println("Intérêt composé = "+ reponse2);
		
		sc.close();
	}

}
