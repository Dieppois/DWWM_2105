import java.util.*;
public class E_1_6_2 {
public static void main(String[] args) {
	
	
	
	
}
public static long [] rechercheDiviseur (long _unNombre)
{
 {
		{
			long [] mesDiviseurs= new long[100];
			int compteurCase=0;
			{

			/* de int i = 2 jusqu'a i < _unNombre */
			for (int i = 2; i < _unNombre ; i++) {

				/* modulo */	
				if (_unNombre%i==0)  {

					mesDiviseurs[compteurCase]=i;
					compteurCase++;

				}

				return mesDiviseurs;

			}
		}
		}

Scanner sc =new Scanner (System.in);

System.out.println("w/e");

rechercheDiviseur (long _unNombre )

long nbtest=sc.nextLong();

long [] diviseurs= new long[50];

diviseurs=rechercheDiviseur (nbtest);

for (int i = 0; i < diviseurs.length; i++) 
{
	if (diviseurs[i]!= 0) {
		
	
	System.out.println(diviseurs[i]);
	
}
}
}
}
}
