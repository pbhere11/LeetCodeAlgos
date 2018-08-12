/*
Examples:

Given "abcabcbb", the answer is "abc", which the length is 3.

Given "bbbbb", the answer is "b", with the length of 1.

Given "pwwkew", the answer is "wke", with the length of 3. Note that the answer must be a substring, "pwke" is a subsequence and not a substring.
*/
public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int maxLength =0;
        Dictionary<char,int> positionMap = new Dictionary<char,int>();
        int start =0;
        for(int i=0;i<s.Length;i++)
        {
        	if(positionMap.ContainsKey(s[i]))
        	{
        		start = Math.Max(start,positionMap[s[i]]+1);
        		positionMap[s[i]] = i;
        	}
        	else
        	{
        		positionMap.Add(s[i],i);
        	}
        	maxLength = Math.Max(maxLength,i-start+1);
        	
        }
        return maxLength;
    }
}