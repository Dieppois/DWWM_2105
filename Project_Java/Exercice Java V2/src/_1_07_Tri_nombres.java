import java.util.*;
public class _1_07_Tri_nombres {

	public static void main(String[] args) {
		Scanner sc = new Scanner (System.in);

		System.out.println("Saisissez 2 nombres.");
		int temp= 0;
		int [] monTab = new int [3];
		for (int i = 0; i < monTab.length; i++) {
			monTab[i] = sc.nextInt();
			if (i==1) {
				System.out.println("Nombres: " + monTab[i-1] +" et "+ monTab[i]);
				if (monTab[i-1]>monTab[i]) {
					temp=monTab[i];
					monTab[i]=monTab[i-1];
					monTab[i-1]=temp;
					System.out.println("Nombres dans l'ordre croissant : " + monTab[i-1] +" et "+ monTab[i]);
					System.out.println("Saisissez un troisieme nombre.");
				}
			}
			if (i==2) {
				System.out.println("Nombres: " + monTab[i-2] +", "+ monTab[i-1]+" et "+ monTab[i]);
				if (monTab[i-2]>monTab[i]) {
					temp=monTab[i];
					monTab[i]=monTab[i-2];
					monTab[i-2]=temp;


					if (monTab[i-1]>monTab[i]) {
						temp=monTab[i];
						monTab[i]=monTab[i-1];
						monTab[i-1]=temp;

					}
				}
				System.out.println("Nombres dans l'ordre croissant : " + monTab[i-2] +", "+ monTab[i-1]+ " et " +monTab[i]);

			}
		}
		
		System.out.println("Fin");
		sc.close();
	}
}




