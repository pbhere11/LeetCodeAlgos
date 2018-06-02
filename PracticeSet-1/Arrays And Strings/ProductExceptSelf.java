/*
Example:

Input:  [1,2,3,4]
		 1 1 2 6
Output: [24,12,8,6]
*/
class Solution {
    public int[] productExceptSelf(int[] nums) {
        int[] output = new int[nums.length];
        output[0]=1;
        int multiplier=1;
        for(int i=0;i<nums.length;i++)
        {
        	if(i==0)
        	{
        		output[i]=multiplier;
        		multiplier = nums[i];
        	}
        	else
        	{
        		output[i] = multiplier*output[i-1];
        		multiplier = nums[i];
        	}
        }
        multiplier=1;
        for(int i=nums.length-1;i>=0;i--)
        {
        	if(i==nums.length-1)
        	{
        		output[i]=output[i]*multiplier;
        		multiplier = nums[i];
        	}
        	else
        	{
        		output[i] = output[i]*multiplier;
        		multiplier = nums[i]*multiplier;
        	}
        }
        return output;
    }
}