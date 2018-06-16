/*
1.9 String Rotation: Assume you have a method isSubst ring which checks if one word is a substring
of another. Given two strings, 51 and 52, write code to check if 52 is a rotation of 51 using only one
call to isSubstring (e.g., "waterbottle" is a rotation of"erbottlewat").
Hints: #34, #88, #104
*/

// "static void main" must be defined in a public class.
public class Main {
    public static void main(String[] args) {
    	String str1 = "erbottlewat";
        String str2 = "waterbottle";
        
        Main mn = new Main();
        System.out.println(mn.isRotation(str1,str2));
    }

    public boolean isRotation(String str1, String str2)
    {
    	StringBuffer sb = new StringBuffer();
    	sb.append(str1);
    	sb.append(str2);
    	return sb.toString().contains(str2);
    }
}