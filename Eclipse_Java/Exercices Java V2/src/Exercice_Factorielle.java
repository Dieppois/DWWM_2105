import java.util.Scanner;

public class Exercice_Factorielle {

	public static void main(String[] args) {

		Scanner sc = new Scanner (System.in);

		System.out.print("Choisir un nombre pour fonction factorielle : ");
		long a = sc.nextInt();

		System.out.println("Factorielle test : "+factorielle(a));

		System.out.println("Fin");
		sc.close();

	}	
	public static long factorielle (long _a) {


		if ( _a < 1 ) {
			return 1;
		}
		else {
			return factorielle(_a -1)*_a;

		}
	}

}


