/*
Example 1:
Input: "aba"
Output: True
Example 2:
Input: "abca"
Output: True
Explanation: You could delete the character 'c'.
*/
public class Solution {
    public bool ValidPalindrome(string s) {
        int i=0;
        int j=s.Length-1;
        if(s.Length==0 || s.Length==1||s.Length==2)
        {
        	return true;
        }
        while(i<j)
        {
        	if(s[i]!=s[j])
        	{
        		return (isPalindrome(s,i+1,j))||(isPalindrome(s,i,j-1));
        	}
        	i++;
			j--;
        }
        return true;
    }
    private bool isPalindrome(string s, int i, int j)
    {
    	if(i==j)
    	{
    		return true;
    	}
    	if(i>j)
    	{
    		return false;
    	}
    	while(i<j)
    	{
    		if(s[i]!=s[j])
    		{
    			return false;
    		}
    		i++;
    		j--;
    	}
    	return true;
    }
}