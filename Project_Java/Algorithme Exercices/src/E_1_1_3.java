/* Exercice 1.1 : Calcul de la moyenne de 2 nombres

Exercice 1.1.3 :
L�utilisateur peut saisir autant de nombres entiers qu�il souhaite. Chaque nombre entier saisi doit �tre s�par� par un
espace. Le programme calcule la moyenne de tous les nombres saisis.
 */


import java.text.DecimalFormat;
import java.util.Scanner;
public class E_1_1_3 {
	public static void main(String[] args) {

		/*modulo*/ ?
			/*nbtest ?*/
		
		
		
		array1[2] = 10;
		array1[3] = 10;
		array1[4] = 10;
		
		System.out.println("Array Length=" + array1.length);
		System.out.println("array1[3]" + array1[3]);
		
		for (int index = 0; index < array1.length; index++) {
			System.out.println("Element" + index + "=" + array1[index]);
		}
		
		int[] array1 = new int[5];
		String test;
		String a;
		String b;
		double moyenne;
		Scanner sc = new Scanner(System.in);
		String R�ponse;
		
		do {
			
		System.out.println("Entrez deux nombres s�par�s d'un espace :");
		 	
		test = sc.nextLine();
		
		int position= test.indexOf(" ");
		int fin =test.length();
		a = test.substring(0, position);
		b = test.substring(position+1, fin);
		array1[0] = a;
		array1[1] = b;
		
		double int_val = Integer.valueOf(a);
		double int_val2 = Integer.valueOf(b);
		
		moyenne = (int_val + int_val2)/2;
		
		DecimalFormat df = new DecimalFormat("0.00");
		System.out.println("La moyenne de ces deux nombres est :");
		System.out.println(df.format(moyenne));
		System.out.println("Souhaitez-vous faire un autre calcul ? (O/N)");
		
		R�ponse = sc.nextLine().toLowerCase();
		} while (R�ponse.equals("o"));
		
		sc.close();
				
}pseudo for each
}
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
			System.out.println(in);	

			String test;
			String a;
			String b;
			double moyenne;
			Scanner sc = new Scanner(System.in);


			System.out.println("Entrez deux nombres s�par�s d'un espace :");

			test = sc.nextLine();

			int position= test.indexOf(" ");
			int fin =test.length();
			a = test.substring(0, position);
			b = test.substring(position+1, fin);

			double int_val = Integer.valueOf(a);
			double int_val2 = Integer.valueOf(b);

			moyenne = (int_val + int_val2)/2;

			DecimalFormat df = new DecimalFormat("0.00");
			System.out.println("La moyenne de ces deux nombres est :");
			System.out.println(df.format(moyenne));

			sc.close();


		}
	}