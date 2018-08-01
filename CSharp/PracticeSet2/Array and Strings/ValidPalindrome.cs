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
        int i=0;
        int j=s.Length-1;

        while(i<j)
        {
        	while(i<j &&

        		!(
        			((int)(char.ToLower(s[i])-'a')>=0 && (int)(char.ToLower(s[i])-'a')<26) ||
        			((int)(char.ToLower(s[i])-'0')>=0 && (int)(char.ToLower(s[i])-'0')<10)
        		)
        		)
        	{
        		i++;
        	}
        	while(i<j &&

        		!(
        			((int)(char.ToLower(s[j])-'a')>=0 && (int)(char.ToLower(s[j])-'a')<26) ||
        			((int)(char.ToLower(s[j])-'0')>=0 && (int)(char.ToLower(s[j])-'0')<10)
        		)
        		)
        	{
        		j--;
        	}
			if(i<j && char.ToLower(s[i])!=char.ToLower(s[j]))
			{
				return false;
			}
			i++;
			j--;
        }
        return true;
    }
}