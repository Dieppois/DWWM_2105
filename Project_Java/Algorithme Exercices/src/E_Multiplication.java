
public class E_Multiplication{

	public static void main(String[] args) {



		System.out.println( multiplie( 8, 2  ) );    // Affiche 1
		System.out.println( multiplie( 3, 1 ) );    // Affiche 2
		System.out.println( multiplie( 2, 2 ) );    // Affiche 4
		System.out.println( multiplie( 2, 3 ) );    // Affiche 8
		System.out.println( multiplie( 2, 16 ) );   // Affiche 65536



	}	


	public static int multiplie (int _a, int _b) {

		int resultat;
		if ( _b < 1 ) {
			resultat =0; }

		else {
			resultat = multiplie(_a , _b-1)*_a;
		}
		return resultat;
	}
}



/*         
static void Main(string[] args)​
{​
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
    {
        resultat = Multiplie(a,n-1) + a;​
    }​
    return resultat;​
}
 */