import java.util.*;

public class TEST {

public static void main(String[] args) {


char [] alphabet =new char [26];
// String phrase="Ses nombreuses pattes, lamentablement grêles par comparaison avec la corpulence qu'il avait par ailleurs,; grouillaient désespérément sous ses yeux.?!";
String phrase="";
int [] tabfrequence= new int[26];
//int [] tabfrequence2= new int[26];



Scanner sc= new Scanner(System.in);



do {



System.out.
println("Veuillez saisir une phrase d'au moins 120 caractères ponctuation non comprise?"
); phrase=sc.nextLine();



} while (phrase.length()<120);



char lettre='a';
for (int i = 0; i < alphabet.length; i++)
{
alphabet[i]=lettre;
lettre++;
}



/*
* for (char element : alphabet) {
*
* System.out.print(element + " " ); }
*/



phrase=phrase.toUpperCase();
phrase= phrase.replace('à', 'a');
phrase= phrase.replace('é', 'e');
phrase= phrase.replace('ê', 'e');
phrase= phrase.replace('è', 'e');
phrase= phrase.replace('ù', 'u');
phrase= phrase.replace('ç', 'a');
phrase= phrase.replace('î', 'i');
phrase= phrase.replace('â', 'a');
phrase= phrase.replace('ë', 'e');
phrase= phrase.replace('ô', 'o');





// phrase=phrase.replace(" ",String.valueOf(null));




phrase=phrase.replaceAll("\\p{Punct}", "");
phrase=phrase.replaceAll("\'", " " );
//phrase=phrase.replaceAll(" ","");




System.out.println("verif phrase :"+phrase );
for (int i = 0; i < alphabet.length; i++) {



for (int j = 0; j < phrase.length(); j++)
{
if (alphabet[i]==phrase.charAt(j))
{


tabfrequence[i]++;


}
}


}
System.out.print("-------------------------------------\n");
for (int i = 0; i < tabfrequence.length; i++)
{
if (tabfrequence[i]>0) {

trieTableau (tabfrequence);
//tabfrequence = tabfrequence2;



System.out.println(tabfrequence[i] + " " + alphabet[i]);


}
}




System.out.print("\n-------------------------------------");
sc.close();
}




static void trieTableau (int _monTab [])
{
int temp = 0;
for (int i = 0; i < _monTab.length-1; i++) {
for (int j = i+1; j < _monTab.length; j++) {
if (_monTab [i] >_monTab [j]) {
temp = _monTab [i];
_monTab [i] = _monTab [j];
_monTab [j] = temp;}



}
}
}
}