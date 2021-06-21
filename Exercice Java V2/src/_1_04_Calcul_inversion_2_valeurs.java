import java.util.*;
public class _1_04_Calcul_inversion_2_valeurs {

	public static void main(String[] args) {

		Scanner sc = new Scanner (System.in);

		System.out.println("Saisissez deux nombres :");

		int [] monTab = new int[2];

		for (int i = 0; i < monTab.length; i++) {
			monTab[i] = sc.nextInt();
			if (i==1) {
				System.out.println(monTab[i] +" et " +monTab[i-1]);
				int temp = monTab[i];
				monTab[i]=monTab[i-1];
				monTab[i-1]=temp;	
				System.out.println(monTab[i] +" et " +monTab[i-1]);
			}
		}
		
		System.out.println("Fin");
		sc.close();	
	
}
}


