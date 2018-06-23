/*
Example 1:

Input: "A man, a plan, a canal: Panama"
Output: true
Example 2:

Input: "race a car"
Output: false
*/

public class Solution {
    public bool IsPalindrome(string s) {
    	if(s.Length==0)
    	{
    		return true;
    	}
       int i=0;
       int j=s.Length-1;
       while(i<=j)
       {
       		while(i<=j && !((char.ToLower(s[i])>='a'&&char.ToLower(s[i])<='z')||(s[i]>='0'&&s[i]<='9')))
       		{
       			i++;
       		}
       		while(i<=j && !((char.ToLower(s[j])>='a'&&char.ToLower(s[j])<='z')||(s[j]>='0'&&s[j]<='9')))
       		{
       			j--;
       		}
       		if(i<=j && char.ToLower(s[i])!=char.ToLower(s[j]))
       		{
       			return false;
       		}
       		i++;
       		j--;
       }
       return true;
       
    }
}