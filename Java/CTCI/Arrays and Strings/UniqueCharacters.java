/*
Implement an algorithm to determine if a string has all unique characters. What
if you cannot use additional data structures?
*/

// "static void main" must be defined in a public class.
public class Main {
    public static void main(String[] args) {
        String test1 = "aaa";
        String test2 = "abc";
        Main mn = new Main();
        System.out.println(mn.isUniqueChars(test1));
        System.out.println(mn.isUniqueChars(test2));
    }

    public boolean isUniqueChars(String str)
    {
    	int num =0;
    	for(int i=0;i<str.length();i++)
    	{
    		int x = str.charAt(i)-'a'+1;
    		num = num^x;
    	}
    	return num==0;
    }
}