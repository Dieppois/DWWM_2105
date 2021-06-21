import java.util.*;
public class _1_09_Recherche_diviseur_nombre {

	public static void main(String[] args) {


		Scanner sc =new Scanner(System.in);
		long [] diviseurs= new long[50];

		System.out.println("Veuillez saisir un nombre entier"); 
		long nbtest=sc.nextLong();

		diviseurs=rechercheDiviseur ( nbtest); 

		for (int i = 0; i < diviseurs.length; i++)
		{
			if (diviseurs[i]!=0)
			{ 
				System.out.println("Diviseur : "+diviseurs[i]);
			}
		}
		System.out.println("Fin");
		sc.close();
	}
	public static long [] rechercheDiviseur ( long _unNombre ) 
	{
		long [] mesDiviseurs= new long[100];
		int compteurCase=0;
		for (int i = 2; i<_unNombre ; i++) 
		{

			if (_unNombre%i==0) {

				mesDiviseurs[compteurCase]=i;
				compteurCase++;
			}
		}
		return mesDiviseurs;
	}
}
