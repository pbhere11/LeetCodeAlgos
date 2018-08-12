/*
1.5 One Away: There are three types of edits that can be performed on strings: insert a character,
remove a character, or replace a character. Given two strings, write a function to check if they are
one edit (or zero edits) away.
EXAMPLE
pale, pIe -> true
pales. pale -> true
pale. bale -> true
pale. bake -> false
Hints: #23, #97, #130
*/

class Program {
    static void Main() {
        Program p = new Program();
        System.Console.WriteLine(p.isOneAway("pale","ple"));
        System.Console.WriteLine(p.isOneAway("pales","pale"));
        System.Console.WriteLine(p.isOneAway("pale","bale"));
        System.Console.WriteLine(p.isOneAway("pale","bake"));
    }

    public bool isOneAway(string str1, string str2)
    {
    	if(str1.Length==str2.Length)
    	{
    		return isOneReplaceAway(str1,str2);
    	}
    	else if(str1.Length>str2.Length)
    	{
    		return isOneInsertAway(str2,str1);
    	}
    	else
    	{
    		return isOneInsertAway(str1,str2);
    	}
    }

    private bool isOneReplaceAway(string str1, string str2)
    {
    	int count=0;
    	for(int i=0;i<str1.Length;i++)
    	{
    		if(str1[i]!=str2[i])
    		{
    			count++;
    			if(count>1)
    			{
    				return false;
    			}
    		}
    	}
    	return true;
    }

    private bool isOneInsertAway(string str1, string str2)
    {
    	int i =0;
    	int j =0;
    	int count =0;
    	while(i<str1.Length && j<str2.Length)
    	{
    		if(str1[i]!=str2[j])
    		{
    			count++;
    			j++;
    			if(count>1)
    			{
    				return false;
    			}
    		}
    		else
    		{
    			i++;
    			j++;
    		}
    	}
    	return true;
    }
}