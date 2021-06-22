/*EXERCICE tableau à 2 dimensions  -  FRANCK CHATELOT 2012
Réaliser la mise en oeuvre du programme:(Le codage en c#) à partir des commentaires suivants  (avec ou sans pseudo-code)  :

/* prog principal
 * 
         *creation d'un tableau tabF[n,2] de chaine  
         
         * //creation d'une procedure pour saisir les formations

         * SaisieFormation(tabF)  // procédure de saisie
         
	* // creation d'une procedure pour saisir le nombre de stagiaire par formation
         *SaisieNbreStag(tabF)
        
	 * //creation de la fonction trier les formations par ordre croissant du nombre de stagiaires 
         * Trier(tabF)


         * //Création de la  fonction afficher les formations triées par nombre
 	 * Afficher(tabF)
 
* fin prog principal 



Avec la création des 3 procedures ou fonctions dont vous avez besoins, vous pouvez  écrire ces 3 procedures en pseudo-code avant de les implémenter.
Mais vous pouvez aussi les implémentez directement.
Vous utiliserez un tableau à 2 dimensions.
le plus :
Vous utiliserez une procedure "try" "catch" pour la gestion des erreurs de saisie.
*/



import java.util.*;
public class E_double_dim {

	public static void main(String[] args) {
		Scanner sc = new Scanner (System.in);
		
		System.out.println("Veuillez entrer le nombre de formations de l'établissement!");
		int formations= sc.nextInt();
		sc.nextLine();
		String [][] mesFormations=new String [formations][2];
		
		
		saisieFormation(mesFormations, formations);
		//afficherFormation(mesFormations);
		
		trierEffectif(mesFormations);
		afficherFormation(mesFormations);
		

		
		
		
		sc.close();
	}	
		public static void saisieFormation(String [][] _tabf1, int _nbFormation) {
		
			
			Scanner sc2= new Scanner (System.in);
			boolean erreur = false;
			
			for (int i = 0; i < _nbFormation; i++) {
			
				System.out.println("Entrez le nom de la formation numero "+(i+1));
				_tabf1[i][0]=sc2.nextLine();
				do
                {
	                    erreur = false;
	                    System.out.println("Veuillez entrer l'effectif prévu de la formation " +(i+1));
	    				_tabf1[i][1]=sc2.nextLine();
	                    try
	                    {
	                        Integer.parseInt(_tabf1[i][1]);
	                    }
	                    catch (Exception e)
	                    {
	                    	 System.out.println("Vous n'avez pas entré un nombre");
	                        erreur = true;
	                    }
	                } while (erreur == true);
				
				
			}
			sc2.close();
		}
		public static void afficherFormation(String [][] _tabf) {
				
				for (int i = 0; i < _tabf.length; i++) {
					System.out.print("La formation : "+(_tabf[i][0]));
					System.out.print(" a un effectif de : "+(_tabf[i][1])+"\n");
					
				}	
			}
		public static void trierEffectif(String[][]_tabf2) {
			
		int [] tempTab = new int [_tabf2.length];

		for (int i = 0; i < _tabf2.length; i++) {
				tempTab[i] = Integer.parseInt(_tabf2[i][1]); }
		
			String temp2 = "";
			int temp = 0;

			for (int i = 0; i < tempTab.length-1; i++) {
				for (int j = i+1; j < tempTab.length; j++) {
					if (tempTab [i] >tempTab [j]) {
						
						temp = tempTab [i];
						tempTab [i] = tempTab [j];
						tempTab [j] = temp;
						
						temp2 = _tabf2[i][1];
                        _tabf2[i][1] = _tabf2[j][1];
                        _tabf2[j][1] = temp2;
                     
                        temp2 = _tabf2[i][0];
                        _tabf2[i][0] = _tabf2[j][0];
                        _tabf2[j][0] = temp2;
						
			
		}
		
	
		}
	
			
		}
		

}
						
}		
				
				
	
	
