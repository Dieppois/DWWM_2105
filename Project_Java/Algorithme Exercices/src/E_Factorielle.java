/*Règle sur les factorielles:​

Le factorielle d’un nombre n est le factorielle du nombre (n-1) fois n.​

Le factorielle de 1 est 1.​

Exercice​

Réalisez à partir de cette définition une fonction récursive permettant de calculer le factorielle de n’importe quel nombre.
*/
import java.util.*;
public class E_Factorielle {

	public static void main(String[] args) {
	
		Scanner sc = new Scanner (System.in);
		
		int a = sc.nextInt();
		factorielle(a);
		
		System.out.println(factorielle(a));
	
		
		sc.close();
	}	
		public static int factorielle (int _a) {
		
			int temp = 1;
			
			if ( _a == 0 || _a ==1 ) {
				return 1;
			}
			else {
			temp = factorielle(_a -1)*_a;
			return temp;
	}
		}
}


/*        static void Main(string[] args)​
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
    {​
       resultat = Multiplie(a,n-1) + a;​
    }​
    return resultat;​
}​
*/