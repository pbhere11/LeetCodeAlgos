/*
Input: [-2,1,-3,4,-1,2,1,-5,4],
Output: 6
-2,1,-3,4,-1,2,1,-5,4

Explanation: [4,-1,2,1] has the largest sum = 6.
*/

class Solution {
    public int maxSubArray(int[] nums) {
        //return maxSubArray(nums,0,nums.length-1);
    	return dynamicProgrammingMaxSumArray(nums);
    }

    private int dynamicProgrammingMaxSumArray(int[] nums)
    {
    	int[] sums = new int[nums.length+1];
    	sums[0] = nums[0];
    	int maxVal = sums[0];
    	for(int i=1;i<nums.length;i++)
    	{
    		sums[i] = Math.max(nums[i],nums[i]+sums[i-1]);
    		if(sums[i]>maxVal)
    		{
    			maxVal = sums[i];
    		}
    	}
    	return maxVal;
    }

    private int maxSubArray(int[] nums, int start, int end)
    {
    	if(start==end)
    	{
    		return nums[start];
    	}
    	int mid = (start+end)/2;
    	int maxLeftSubArray = maxSubArray(nums,0,mid);
    	int maxRightSubArray = maxSubArray(nums,mid+1,end);
    	int maxCrossingSubArray = maxCrossingSubArray(nums,start,mid,end);
    	int largest = maxLeftSubArray;
    	if(maxRightSubArray>=maxLeftSubArray)
    	{
    		largest =maxRightSubArray;
    	}
    	if(maxCrossingSubArray>largest)
    	{
    		largest = maxCrossingSubArray;
    	}
    	return largest;
    }

    private int maxCrossingSubArray(int[] nums, int start, int mid, int end)
    {
    	int i = mid;
    	int leftSum = Integer.MIN_VALUE;
    	int sum =0;
    	while(i>=start)
    	{
    		sum = sum + nums[i];
    		if(sum>leftSum)
    		{
    			leftSum = sum;
    		}
    		i--;
    	}

    	int rightSum = Integer.MIN_VALUE;
    	sum = 0;
    	int j = mid+1;
    	while(j<=end)
    	{
    		sum = sum + nums[j];
    		if(sum>rightSum)
    		{
    			rightSum = sum;
    		}
    		j++;
    	}
    	return leftSum + rightSum;
    }
}