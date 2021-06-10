
public class E_FactorielleV2{

	public static void main(String[] args) {
	

		
		 	System.out.println( factorielle2( 8, 3  ) );    // Affiche 1
	        System.out.println( factorielle2( 3, 1 ) );    // Affiche 2
	        System.out.println( factorielle2( 2, 2 ) );    // Affiche 4
	        System.out.println( factorielle2( 2, 3 ) );    // Affiche 8
	        System.out.println( factorielle2( 2, 16 ) );   // Affiche 65536
	
		
		
	}	
		public static long factorielle2 (long _a, long _b) {
		
			
			if ( _b == 0 || _a ==1 ) {
				return 1;
			}
			else {
			return factorielle2(_a , _b-1)*_a;
			
	}
		}
}
		
		
		
		