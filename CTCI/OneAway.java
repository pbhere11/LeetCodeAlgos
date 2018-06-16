/*
One Away: There are three types of edits that can be performed on strings: insert a character,
remove a character, or replace a character. Given two strings, write a function to check if they are
one edit (or zero edits) away.
EXAMPLE
pale, pIe -> true
pales. pale -> true
pale. bale -> true
pale. bake -> false
Hints: #23, #97, #130
*/
// "static void main" must be defined in a public class.
public class Main {
    public static void main(String[] args) {
        String[][] pairs = {{"pale", "ple"}, {"pales", "pale"}, {"pale", "bale"}, {"pale", "bake"}};
        Main mn = new Main();
        for(int i=0;i<pairs.length;i++)
        {
        	System.out.println(mn.oneAway(pairs[i][0],pairs[i][1]));
        }
    }

    public boolean oneAway(String str1, String str2)
    {
    	if(str1.equals(str2))
    	{
    		return true;
    	}
    	if(str1.length()<str2.length())
    	{
    		int i=0;
    		int j=0;
    		int diffCount =0;
    		while(i<str1.length()&&j<str2.length())
    		{
    			if(diffCount>1)
    			{
    				return false;
    			}
    			if(str1.charAt(i)!=str2.charAt(j))
    			{
    				diffCount++;
    				j++;
    			}
    			else
    			{
    				i++;
    				j++;
    			}
    		}
    	}
    	else if(str1.length()>str2.length())
    	{
    		int i=0;
    		int j=0;
    		int diffCount =0;
    		while(i<str1.length()&&j<str2.length())
    		{
    			if(diffCount>1)
    			{
    				return false;
    			}
    			if(str1.charAt(i)!=str2.charAt(j))
    			{
    				diffCount++;
    				i++;
    			}
    			else
    			{
    				i++;
    				j++;
    			}
    		}
    	}
    	else
    	{
    		int i=0;
    		int j=0;
    		int diffCount =0;
    		while(i<str1.length()&&j<str2.length())
    		{
    			if(diffCount>1)
    			{
    				return false;
    			}
    			if(str1.charAt(i)!=str2.charAt(j))
    			{
    				diffCount++;
    			}
    			i++;
    			j++;
    		}
    	}

    	return true;
    }
}