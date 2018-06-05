/*
Example:

Input: [-2,1,-3,4,-1,2,1,-5,4],
Output: 6
Explanation: [4,-1,2,1] has the largest sum = 6.
*/
class Solution {
    public int maxSubArray(int[] nums) {
    	if(nums.length==0)
    	{
    		return 0;
    	}
        return maxSubArray(nums,0,nums.length-1);
    }
    private int maxSubArray(int[] nums, int start, int end)
    {
    	if(start==end)
    	{
    		return nums[start];
    	}
    	int mid = (start+end)/2;
    	int left = maxSubArray(nums,start,mid);
    	int right = maxSubArray(nums,mid+1,end);
    	int cross = maxCrossSubArray(nums,start,mid,end);
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
    private int maxCrossSubArray(int[] nums, int start, int mid, int end)
    {
    	int leftSum =Integer.MIN_VALUE;
    	int sum =0;
    	int i=mid;
    	while(i>=start)
    	{
    		sum = sum + nums[i];
    		if(sum>leftSum)
    		{
    			leftSum = sum;
    		}
    		i--;
    	}
    	i=mid+1;
    	sum =0;
    	int rightSum = Integer.MIN_VALUE;
    	while(i<=end)
    	{
    		sum = sum + nums[i];
    		if(sum>rightSum)
    		{
    			rightSum = sum;
    		}
    		i++;
    	}
    	return leftSum+rightSum;
    }
}