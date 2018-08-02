/*
Example: 

Input: s = 7, nums = [2,3,1,2,4,3]
Output: 2
Explanation: the subarray [4,3] has the minimal length under the problem constraint.
*/
public class Solution {
    public int MinSubArrayLen(int s, int[] nums) {
        int minLen = int.MaxValue;
        int start =0;
        int sum =0;
        for(int i=0;i<nums.Length;i++)
        {
        	sum+=nums[i];
        	while(sum>=s)
        	{
        		minLen = Math.Min(minLen,i-start+1);
        		sum-=nums[start];
        		start++;
        	}
        }
        return minLen==int.MaxValue?0:minLen;
    }
}