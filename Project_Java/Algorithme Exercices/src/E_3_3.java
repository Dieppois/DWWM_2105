import java.util.*;
public class E_3_3 {

	public static void main(String[] args) {
		Scanner sc = new Scanner (System.in);
		
		

		Scanner input = new Scanner(new File("src/para1.txt"));

        int[] count = new int[26];

        while (input.hasNextLine()) {
            String answer = input.nextLine();
            answer = answer.toLowerCase();
            char[] characters = answer.toCharArray();

            for (int i = 0; i < 26; i++) {
                count[i]++;
            }
        }

        for (int i = 0; i < 26; i++) {
            StdOut.print((char) (i + 'a'));
            StdOut.println(": " + count[i]);
        }
    }
}













;
	}

}
