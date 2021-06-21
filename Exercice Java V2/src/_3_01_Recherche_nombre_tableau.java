import java.util.*;
public class _3_01_Recherche_nombre_tableau {
	public static void main(String[] args) {

		Scanner sc=new Scanner(System.in);

		int [] montab= new int[10];
		int recherche;
		Random aleas =new Random();
		boolean trouve=false;

		for (int i = 0; i < montab.length; i++) 
		{
			montab[i]=aleas.nextInt(31);	
		}

		trieTableau(montab);

		System.out.println("Voici le tableau :");

		for (int i : montab) {
			System.out.print(i + " ");
		}

		System.out.println(" Veuillez saisir un nombre entier positif inférieur à 30 !!");
		recherche=sc.nextInt();

		int positiontab =0;

		do {
			if (montab[positiontab]==recherche)
			{
				trouve=true;	
			}
			positiontab++;

		} while (positiontab<10 && trouve==false);

		if (trouve==false) 
		{
			System.out.println("Le nombre ne se trouve pas dans le tableau!");

		}else {

			System.out.println("Le nombre est dans le tableau à la position :"+positiontab);
		}

		System.out.println("Fin");
		sc.close();

	}

	static void trieTableau (int _monTab []) {

		int temp = 0;

		for (int i = 0; i < _monTab.length-1; i++) {
			for (int j = i+1; j < _monTab.length; j++) {
				if (_monTab [i] >_monTab [j]) {
					temp = _monTab [i];
					_monTab [i] = _monTab [j];
					_monTab [j] = temp;

				}
			}
		}
	}
}