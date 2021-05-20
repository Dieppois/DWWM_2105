package nbrpremier;
import java.util.*;
public class E_1_6_3 {
public static void main(String[] args) {
		
				Scanner sc =new Scanner(System.in);
				
				System.out.println("Veuillez saisir un nombre entier"); 
				
				long nbtest=sc.nextLong();
				
				long [] diviseurs= new long[50];	
				
				diviseurs=rechercheDiviseur ( nbtest); 
				for (int i = 0; i < diviseurs.length; i++)
				{
					if (diviseurs[i]!=0)
					{ 
						System.out.println("Diviseur : "+diviseurs[i]);
					}
					
				}
				
				
				/*
				 * String recommencer=""; long nbtest;
				 * 
				 * boolean premier; do { premier= true; long diviseur=2;
				 * 
				 * System.out.println("Veuillez saisir un nombre entier"); nbtest=sc.nextLong();
				 * while(diviseur<=Math.sqrt(nbtest) && premier==true) { if (nbtest%diviseur==0)
				 * {
				 * 
				 * premier=false;
				 * 
				 * 
				 * }
				 * 
				 * 
				 * 
				 * diviseur++;
				 * 
				 * }
				 * 
				 * if (!premier) { System.out.println("Le nombre "
				 * +nbtest+" n'est pas premier car il a au moins un diviseur :"+ (diviseur-1));
				 * 
				 * } else { System.out.println("Le nombre "+nbtest+" est premier" ); }
				 * sc.nextLine();
				 * 
				 * System.out.println(" Voulez-vous recommencer? O/N");
				 * 
				 * recommencer=sc.nextLine();
				 * 
				 * 
				 * } while (recommencer.charAt(0)=='O' && recommencer.length()<2 );
				 */
				
				
			}

			
			public static long [] rechercheDiviseur ( long _unNombre ) 
			{
				long [] mesDiviseurs= new long[50];
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

