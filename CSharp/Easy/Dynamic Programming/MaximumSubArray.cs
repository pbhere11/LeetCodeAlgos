/*
Example:

Input: [-2,1,-3,4,-1,2,1,-5,4],
Output: 6
Explanation: [4,-1,2,1] has the largest sum = 6.
*/

public class Solution {
    public int MaxSubArray(int[] nums) {
        //return MaxSubArray(nums,0,nums.Length-1);
        return MaxSubArrayDynamic(nums);
    }

    private int MaxSubArrayDynamic(int[] nums)
    {
        int maxVal =0;
        if(nums.Length==0)
        {
            return 0;
        }
        if(nums.Length==1)
        {
            return nums[0];
        }
        int[] dp = new int[nums.Length];
        dp[0] = nums[0];
        maxVal = nums[0];
        for(int i=1;i<nums.Length;i++)
        {
            dp[i] = Math.Max(nums[i],nums[i]+dp[i-1]);
            if(dp[i]>maxVal)
            {
                maxVal = dp[i];
            }
        }
        return maxVal;
    }

    private int MaxSubArray(int[] nums, int start, int end)
    {
    	if(start==end)
    	{
    		return nums[start];
    	}
    	if(start<end)
    	{
    		int mid = (start+end)/2;
    		int left = MaxSubArray(nums,start,mid);
    		int right = MaxSubArray(nums,mid+1,end);
    		int cross = MaxCrossSubArray(nums,start,mid,end);
    		int max = left;
    		if(right>left)
    		{
    			max = right;
    		}
    		if(cross>max)
    		{
    			max = cross;
    		}
    		return max;
    	}
    	else
    	{
    		return 0;
    	}
    }
    private int MaxCrossSubArray(int[] nums, int start, int mid, int end)
    {
    	int i=mid;
    	int j = mid+1;
    	int left =int.MinValue;;
    	int right =int.MinValue;
    	int sum =0;
    	while(i>=start)
    	{
    		sum = sum+nums[i];
    		if(sum>left)
    		{
    			left = sum;
    		}
    		i--;
    	}
    	sum =0;
    	while(j<=end)
    	{
    		sum = sum+nums[j];
    		if(sum>right)
    		{
    			right = sum;
    		}
    		j++;
    	}
    	return left+right;
    }
}