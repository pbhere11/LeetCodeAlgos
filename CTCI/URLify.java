/*
1.3 URLify: Write a method to replace all spaces in a string with '%20: You may assume that the string
has sufficient space at the end to hold the additional characters, and that you are given the "true"
length of the string. (Note: If implementing in Java, please use a character array so that you can
perform this operation in place.)
EXAMPLE
Input: "Mr John Smith "J 13
Output: "Mr%20J ohn%20Smith""
*/

// "static void main" must be defined in a public class.
public class Main {
    public static void main(String[] args) {
        String str = "Mr John Smith    ";
        char[] charArr = str.toCharArray();
        Main mn = new Main();
        System.out.println(mn.urlify(str.toCharArray()));
    }

    public String urlify(char[] charArr)
    {
    	int lastLetter =0;
    	for(int i=0;i<charArr.length;i++)
    	{
    		if(charArr[i]!=' ')
    		{
    			lastLetter = i;
    		}
    	}

    	int i = charArr.length-1;

    	while(i>=0 && lastLetter>=0)
    	{
    		if(charArr[lastLetter]!=' ')
    		{
    			charArr[i] = charArr[lastLetter];
    			lastLetter--;
    			i--;
    		}
    		else
    		{
    			charArr[i] = '0';
    			i--;
    			charArr[i] = '2';
    			i--;
    			charArr[i] = '%';
    			i--;
    			lastLetter--;
    		}
    	}

    	return new String(charArr);
    }
}