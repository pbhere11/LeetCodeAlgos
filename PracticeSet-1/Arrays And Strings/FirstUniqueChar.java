/*
s = "leetcode"
return 0.

s = "loveleetcode",
return 2.
*/
class Solution {
    public int firstUniqChar(String s) {
        if(s.length()==0)
        {
        	return -1;
        }
        int[] charCount = new int[26];
        for(int i=0;i<s.length();i++)
        {
        	charCount[(int)s.charAt(i)-'a']++;
        }
        for(int i=0;i<s.length();i++)
        {
        	if(charCount[(int)s.charAt(i)-'a']==1)
        	{
        		return i;
        	}
        }
        return -1;
    }
}