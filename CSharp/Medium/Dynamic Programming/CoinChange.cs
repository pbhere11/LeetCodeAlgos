/*
Example 1:

Input: coins = [1, 2, 5], amount = 11
Output: 3 
Explanation: 11 = 5 + 5 + 1
Example 2:

Input: coins = [2], amount = 3
Output: -1
*/
public class Solution {
    public int CoinChange(int[] coins, int amount) {
    	if(amount==0)
    	{
    		return 0;
    	}
        int[] dp = new int[amount+1];
        dp[0] = 0;
        for(int i=1;i<=amount;i++)
        {
        	dp[i] = int.MaxValue;
        }
        for(int i=0;i<=amount;i++)
        {
        	for(int j=0;j<coins.Length;j++)
        	{
        		if(coins[j]!=int.MaxValue && coins[j]+i<dp.Length && coins[j]+i<=amount)
        		{
        			if(dp[i]!=int.MaxValue)
        			{
        				dp[coins[j]+i] = Math.Min(dp[coins[j]+i],dp[i]+1);
        			}
        		}
        	}
        }
        if(dp[amount]!=int.MaxValue)
        {
        	return dp[amount];
        }
        else
        {
        	return -1;
        }
    }
}