/*
1.6 String Compression: Implement a method to perform basic string compression using the counts
of repeated characters. For example, the string aabcccccaaa would become a2b1c5a3. If the
"compressed" string would not become smaller than the original string, your method should return
the original string. You can assume the string has only uppercase and lowercase letters (a - z).
*/

// "static void main" must be defined in a public class.
public class Main {
    public static void main(String[] args) {
        Main mn = new Main();
        String str = "aabcccccaaa";
        System.out.println(mn.compressedString(str));
    }

    public String compressedString(String str)
    {
    	int count =1;
    	StringBuffer sb = new StringBuffer();
    	for(int i=1;i<str.length();i++)
    	{
    		if(str.charAt(i)==str.charAt(i-1))
    		{
    			count++;
    		}
    		else
    		{
    			sb.append(str.charAt(i-1));
    			sb.append(count);
    			count=1;
    		}
    	}
    	sb.append(str.charAt(str.length()-1));
		sb.append(count);
		return sb.toString();
    }
}