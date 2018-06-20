/*
1.3 URLify: Write a method to replace all spaces in a string with '%20: You may assume that the string
has sufficient space at the end to hold the additional characters, and that you are given the "true"
length of the string. (Note: If implementing in Java, please use a character array so that you can
perform this operation in place.)
EXAMPLE
Input: "Mr John Smith "J 13
Output: "Mr%20J ohn%20Smith"
Hints: #53, #7 78
*/

public class Program {
    public static void Main() {
        string str = "Mr John Smith    ";
        Program p = new Program();
        System.Console.WriteLine(p.Urlify(str));
    }

    public string Urlify(string str)
    {
    	char[] charArray = str.ToCharArray();
    	int end = charArray.Length-1;
    	bool wordStartedFlag = false;
    	for(int i=end;i>=0;i--)
    	{
    		if(!wordStartedFlag && charArray[i]!=' ')
    		{
    			wordStartedFlag = true;
    			charArray[end] = charArray[i];
    			end--;
    		}
    		else if(wordStartedFlag)
    		{
    			if(charArray[i]==' ')
    			{
    				charArray[end] = '0';
    				end--;
    				charArray[end] = '2';
    				end--;
    				charArray[end] = '%';
    				end--;
    			}
    			else
    			{
    				charArray[end] = charArray[i];
    				end--;
    			}
    		}
    	}
    	return new string(charArray);
    }
}