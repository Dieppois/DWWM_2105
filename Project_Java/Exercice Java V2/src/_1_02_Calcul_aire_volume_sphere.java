import java.text.DecimalFormat;
import java.text.NumberFormat;
import java.util.*;
public class _1_02_Calcul_aire_volume_sphere {

	public static void main(String[] args) {

		Scanner sc = new Scanner(System.in);
		DecimalFormat dF =(DecimalFormat) NumberFormat.getInstance(Locale.US);
		double rayon;
		long volume,aire;


		System.out.println("Entrez le rayon R (km) d'une sph�re.");

		rayon = sc.nextDouble();
		aire = Math.round(4*Math.PI*Math.pow(rayon, 2));
		volume = Math.round(4.0/3.0*Math.PI*Math.pow(rayon, 3));

		System.out.println("L'aire de la sph�re est de : " + dF.format(aire)+ " (km�)\nLe volume de la sph�re est de : " + dF.format(volume) +" (km�)");

		System.out.println("Fin");
		sc.close();
	}
}
