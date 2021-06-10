import java.util.*;
public class E_FactorielleV3 {

	public static void main(String[] args) {
	
	Scanner sc = new Scanner (System.in);
	
	System.out.println("Entrez un nombre");
	int a = sc.nextInt();
	System.out.println("Humm");
	int b = sc.nextInt();
	
	System.out.println( "La factorielle de " + (a) + " est " +  (Multiplie( a, b )) );
	
	sc.close();
	
	}static public int Multiplie (int _a, int _n){
		int resultat;
		if ( _n > 1 )
		{
			resultat = 0;
		}
		else
		{
			resultat = Multiplie(_a , _n-1)*_a;
		}
		return resultat;
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