import java.util.*;
public class E_Puissance {

	public static void main(String[] args) {
	
	Scanner sc = new Scanner (System.in);
	
	System.out.println("Entrez un nombre");
	int a = sc.nextInt();
	System.out.println("Humm");
	int b = sc.nextInt();
	
	System.out.println( "La puissance de " + (a) + " est " +  (nombrePuissance( a, b )) );
	
	sc.close();
	
	}static public int nombrePuissance (int _a, int _n){

		
			
			if ( _n == 0 || _a ==1 ) 
				return 1;
			
			
			return nombrePuissance(_a , _n-1)*_a;
	}
}

	/*	​
		Console.WriteLine(Multiplie(10,3));​
		Console.ReadLine();​
		}​
		static private int Multiplie(int a,int n)​
		{​
		int resultat;​
		if (n < 1)            ​
		{​
		    resultat = 0;​
		}​
		else​
		{​
		   resultat = Multiplie(a,n-1) + a;​
		}​
		return resultat;​
		}​
		*/