/*
'A' -> 1
'B' -> 2
...
'Z' -> 26
Given a non-empty string containing only digits, determine the total number of ways to decode it.

Example 1:

Input: "12"
Output: 2
Explanation: It could be decoded as "AB" (1 2) or "L" (12).
Example 2:

Input: "226"
Output: 3
Explanation: It could be decoded as "BZ" (2 26), "VF" (22 6), or "BBF" (2 2 6).

123
abc

*/
public class Solution {
    public int NumDecodings(string s) {
        if(s.Length==0 || s[0]=='0' )
        {
        	return 0;
        }
        int[] dp = new int[s.Length];
        dp[0]=1;
        if(s.Length==1)
        {
        	return dp[0];
        }
        int val = int.Parse(s.Substring(0,2));
        if(val>=10&&val<=26)
        {
        	if(s[1]=='0')
        	{
        		dp[1]=1;
        	}
        	else
        	{
        		dp[1]=2;
        	}
        }
        else
        {
        	if(s[1]!='0')
        	{
        		dp[1]=1;
        	}
        	else
        	{
        		dp[1]=0;
        	}
        }
        for(int i=2;i<s.Length;i++)
        {
        	if(s[i]!='0')
        	{
        		dp[i] = dp[i-1];
        	}
        	int val1 =0;
        	if(i<s.Length-1)
        	{
        		val1 = int.Parse(s.Substring(i-1,2));
        	}
        	else
        	{
        		val1 = int.Parse(s.Substring(i-1));
        	}
        	if(val1>=10&&val1<=26)
        	{
        		dp[i]+=dp[i-2];
        	}
        }
        return dp[s.Length-1];
    }
}