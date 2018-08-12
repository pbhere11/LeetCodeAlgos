/*
s = "leetcode"
return 0.

s = "loveleetcode",
return 2.
*/
class Solution {
    public int firstUniqChar(String s) {
        int[] countArr = new int[26];
        String str = s.toLowerCase();
        for(int i=0;i<str.length();i++)
        {
        	countArr[str.charAt(i)-97]++;
        }
        for(int i=0;i<str.length();i++)
        {
        	if(countArr[str.charAt(i)-97]==1)
        	{
        		return i;
        	}
        }
        return -1;
    }
}