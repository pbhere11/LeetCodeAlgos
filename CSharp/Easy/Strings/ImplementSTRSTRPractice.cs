/*
Example 1:

Input: haystack = "hello", needle = "ll"
Output: 2
Example 2:

Input: haystack = "aaaaa", needle = "bba"
Output: -1

"mississippi"
"issip"
issip
00010
*/

public class Solution {
    public int StrStr(string haystack, string needle) {
    	if((haystack.Length==0 && needle.Length==0)||(haystack.Length>0&&needle.Length==0))
    	{
    		return 0;
    	}
    	if((haystack.Length==0&&needle.Length>0)||(needle.Length>haystack.Length))
    	{
    		return -1;
    	}
        int[] nexrPositionArr = GetNextPositionArray(needle);
        int i=0;
        int j=0;
        while(i<haystack.Length)
        {
        	if(haystack[i]==needle[j])
        	{
        		i++;
        		j++;
        		if(j==needle.Length)
        		{
        			return i-j;
        		}
        	}
        	else if(i<haystack.Length && haystack[i]!=needle[j])
        	{
        		if(j==0)
        		{
        			i++;
        		}
        		else
        		{
        			j = nexrPositionArr[j-1];
        		}
        	}
        }
        return -1;
    }

    private int[] GetNextPositionArray(string needle)
    {
    	int i=1;
    	int index =0;
    	int[] next = new int[needle.Length];
    	next[0] =0;
    	while(i<needle.Length)
    	{
    		if(needle[i]==needle[index])
    		{
    			index++;
    			next[i] = index;
    			i++;
    		}
    		else
    		{
    			if(index ==0)
    			{
    				next[i] = index;
    				i++;
    			}
    			else
    			{
    				index = next[index-1];
    			}
    		}
    	}
    	return next;
    }
}