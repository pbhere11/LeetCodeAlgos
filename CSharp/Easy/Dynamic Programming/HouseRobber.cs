/*
Example 1:

Input: [1,2,3,1]
Output: 4
Explanation: Rob house 1 (money = 1) and then rob house 3 (money = 3).
             Total amount you can rob = 1 + 3 = 4.
Example 2:

Input: [2,7,9,3,1]
Output: 12
Explanation: Rob house 1 (money = 2), rob house 3 (money = 9) and rob house 5 (money = 1).
             Total amount you can rob = 2 + 9 + 1 = 12.
*/

public class Solution {
    public int Rob(int[] nums) {
        int[]dp = new int[nums.Length];
        int max =0;
        for(int i=0;i<nums.Length;i++)
        {
        	if(i==0)
        	{
        		dp[i]=nums[i];
        		if(dp[i]>max)
        		{
        			max = dp[i];
        		}
        	}
        	else if(i==1)
        	{
        		dp[i]=Math.Max(nums[i],nums[i-1]);
        		if(dp[i]>max)
        		{
        			max = dp[i];
        		}
        	}
        	else
        	{
        		dp[i] = Math.Max(dp[i-1],nums[i]+dp[i-2]);
        		if(dp[i]>max)
        		{
        			max = dp[i];
        		}
        	}
        }
        return max;
    }
}