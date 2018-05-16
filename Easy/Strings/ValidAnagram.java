/*
Input: s = "anagram", t = "nagaram"
Output: true
Input: s = "rat", t = "car"
Output: false
*/
class Solution {
    public boolean isAnagram(String s, String t) {
        int[] countArr = new int[26];
        String str1 = "";
        String str2 = "";
        if(s.length()<=t.length())
        {
        	str1 = s.toLowerCase();
        	str2 = t.toLowerCase();
        }
        else
        {
        	str2 = s.toLowerCase();
        	str1 = t.toLowerCase();
        }
        for(int i=0;i<str1.length();i++)
        {
        	countArr[str1.charAt(i)-97]++;
        }
        for(int i=0;i<str2.length();i++)
        {
        	if(countArr[str2.charAt(i)-97]<1)
        	{
        		return false;
        	}
        	else
        	{
        		countArr[str2.charAt(i)-97]--;
        	}
        }
        return true;
    }
}