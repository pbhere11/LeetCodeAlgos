/*
Example:

Input: [10,9,2,5,3,7,101,18]
Output: 4 
Explanation: The longest increasing subsequence is [2,3,7,101], therefore the length is 4. 
10
9
2,5

*/
public class Solution {
    public int LengthOfLIS(int[] nums) {
    	if(nums.Length==0 || nums.Length==1)
    	{
    		return nums.Length;
    	}
        int[] dp = new int[nums.Length];
        int len =1;
        dp[0] = nums[0];
        for(int i=1;i<nums.Length;i++)
        {
			if(nums[i]<dp[0])
			{
				dp[0] = nums[i];
			}       	
			else if(nums[i]>dp[len-1])
			{
				dp[len] = nums[i];
				len++;
			}
			else
			{
				int index = Search(dp,0,len-1,nums[i]);
				dp[index] = nums[i];
			}
        }
        return len;
    }

    private int Search(int[] dp, int start, int end, int target)
    {
    	
    	while(start<end)
    	{
    		int mid = (start+end)/2;
    		if(dp[mid]>=target)
    		{
    			end = mid;
    		}
    		else
    		{
    			start = mid+1;
    		}
    	}
    	return end;
    }
}