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
public class Solution {
    public int MaxSubArrayLen(int[] nums, int k) {
        Dictionary<int,int> map = new Dictionary<int,int>();
        int sum = 0;
        int maxLen = 0;
        for(int i=0;i<nums.Length;i++)
        {
        	sum+=nums[i];
        	int diff = sum-k;
        	if(sum==k)
        	{
        		maxLen = i+1;
        	}
        	else if(map.ContainsKey(diff))
        	{
        		maxLen = Math.Max(maxLen,i-map[diff]);
        	}
        	if(!map.ContainsKey(sum))
        	{
        		map.Add(sum,i);
        	}
        }
        return maxLen;
    }
}