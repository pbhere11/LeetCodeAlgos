/*
Example 1:

Input: nums = [1, -1, 5, -2, 3], k = 3
Output: 4 
Explanation: The subarray [1, -1, 5, -2] sums to 3 and is the longest.
Example 2:

Input: nums = [-2, -1, 2, 1], k = 1
Output: 2 
Explanation: The subarray [-1, 2] sums to 1 and is the longest.
*/
class Solution {
    public int maxSubArrayLen(int[] nums, int k) {
    	int maxLength =0;
        if(nums.length==0)
        {
        	return maxLength;
        }
        int sum = 0;
        HashMap<Integer,Integer> sumMap = new HashMap<Integer,Integer>();
        for(int i=0;i<nums.length;i++)
        {
        	sum = sum+nums[i];
        	int diff = sum-k;
        	if(sum ==k)
        	{
        		maxLength = i+1;
        	}
        	else if(sumMap.containsKey(diff))
        	{
        		maxLength = Math.max(maxLength,i-sumMap.get(diff));
        	}
        	if(!sumMap.containsKey(sum))
        	{
        		sumMap.put(sum,i);
        	}
        }
        return maxLength;
    }
}