import java.math.RoundingMode;
import java.text.DecimalFormat;
import java.util.*;
public class _2_02_Conversion_fahrenheit_celsius {

	public static void main(String[] args) {
		
		Scanner sc =new Scanner(System.in);
		DecimalFormat modele= new DecimalFormat("0.00");
		modele.setRoundingMode(RoundingMode.HALF_UP);
		
		char mode =' ';
		String test="";
		String rep;

		System.out.println("Programme de conversion Celsius <-> Fahrenheit.");
		
		do {

			do {

				System.out.println("Saisir une unité de mesure (C ou F) : ");

				test= sc.nextLine();
				mode=test.charAt(0);

				if (mode!='C' &&  mode!='F' ||  test.length()>1)
				{ 
					System.out.println("Veuillez reitérer l'operation");
				}

			} while ((mode!='C'  &&  mode!='F') ||  test.length()>1); 

			
			if (mode=='C') {

				System.out.println("Saisir la valeur minimum : ");
				double a=sc.nextDouble();
				System.out.println("Saisir la valeur maximum (doit être supérieure à la valeur minimum) :");
				double b=sc.nextDouble();
				System.out.println("Resultat : ");
				for (double i = a; i <= b; i++) {
					double s=(i*9)/5 +32;
					s=NbArrondi2(s, 3);
					System.out.println(a+"°C = "+s+("°F") );
				}
				

			}
			else 
			{
				System.out.println("Saisir la valeur minimum : ");
				double a=sc.nextDouble();
				System.out.println("Saisir la valeur maximum (doit être supérieure à la valeur minimum) :");
				double b=sc.nextDouble();
				System.out.println("Resultat : ");
				for (double i = a; i <= b; i++) {
				double s= (i-32 )*5/9;
				s=NbArrondi2(s,3);
				System.out.println(a+"°F = "+s+("°C") );
				}
			}
			sc.nextLine();
			System.out.println("\nVoulez-vous convertir une autre température ? O/quit ");

			rep=sc.nextLine().toLowerCase();

		} while ( rep.charAt(0)=='o' && rep.length()<2 );

		System.out.println("Fin");
		sc.close();

	}


	public static double NbArrondi( double _nombre) {
		double nbArrondi=Math.round(_nombre*100.0)/100.0; 
		return nbArrondi;

	}

	public static double NbArrondi2 ( double _nombre, int _chiffreVirgule)
	{// 79.79
		double temp= _nombre*Math.pow(10,_chiffreVirgule);
		double nbArrondi= Math.round(temp)/Math.pow(10, _chiffreVirgule);
		return nbArrondi;

	}

}
