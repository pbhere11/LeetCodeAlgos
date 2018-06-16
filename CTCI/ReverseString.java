/*
Implement a function void reverse(char* str) in C or C++ which reverses a nullterminated
string.
*/

// "static void main" must be defined in a public class.
public class Main {
    public static void main(String[] args) {
        String str = "abcdef";
        Main mn = new Main();
        System.out.println(mn.reverseStr(str));
    }

    public String reverseStr(String str)
    {
    	char[] charArr = str.toCharArray();
    	int i=0;
    	int j= charArr.length-1;
    	while(i<j)
    	{
    		char c = charArr[i];
    		charArr[i] = charArr[j];
    		charArr[j] = c;
    		i++;
    		j--;
    	}
    	return new String(charArr);
    }
}