import java.text.DecimalFormat;
import java.util.*;
public class _1_03_Calcul_surface_secteur_circulaire {

	public static void main(String[] args) {

		DecimalFormat dF = new DecimalFormat ("0.00");
		Scanner sc = new Scanner (System.in);
	
		double rayon,angle;
		
		System.out.println("Entrez la valeur en degré(s) du rayon R et de l'angle A : ");
		
		rayon = sc.nextDouble();
		angle = sc.nextDouble();
		
		double resultat = Math.PI*Math.pow(rayon, 2)*angle/360;
	
		System.out.println("L'aire du secteur circulaire est : "+dF.format(resultat));

		System.out.println("Fin");
		sc.close();
	}
	}


