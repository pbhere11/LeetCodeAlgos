/*
Given "abcabcbb", the answer is "abc", which the length is 3.

Given "bbbbb", the answer is "b", with the length of 1.

Given "pwwkew", the answer is "wke", with the length of 3

abba
*/
class Solution {
    public int lengthOfLongestSubstring(String s) {
        if(s.length()==0)
        {
        	return 0;
        }
        HashMap<Character,Integer> map = new HashMap<Character,Integer>();
        int maxLength = 0;
        int startIndex =0;
        for(int i=0;i<s.length();i++)
        {
        	if(map.containsKey(s.charAt(i)))
        	{
        		startIndex = Math.max(map.get(s.charAt(i)),startIndex);
        	}
        	map.put(s.charAt(i),i+1);
        	maxLength = Math.max(maxLength,i-startIndex+1);
        }
        return maxLength;
    }
}