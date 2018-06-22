/*
Examples:

s = "leetcode"
return 0.

s = "loveleetcode",
return 2.
*/

public class Solution {
    public int FirstUniqChar(string s) {
        int[] countArr = new int[26];
        for(int i=0;i<s.Length;i++)
        {
        	countArr[s[i]-'a']++;
        }
        for(int i=0;i<s.Length;i++)
        {
        	if(countArr[s[i]-'a']==1)
        	{
        		return i;
        	}
        }
        return -1;
    }
}