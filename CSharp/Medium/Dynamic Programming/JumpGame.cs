/*
Example 1:

Input: [2,3,1,1,4]
Output: true
Explanation: Jump 1 step from index 0 to 1, then 3 steps to the last index.
Example 2:

Input: [3,2,1,0,4]
Output: false
Explanation: You will always arrive at index 3 no matter what. Its maximum
             jump length is 0, which makes it impossible to reach the last index.
*/

public class Solution {
    public bool CanJump(int[] nums) {
    	if(nums.Length==0)
    	{
    		return false;
    	}
    	int lastPos = nums.Length-1;
        for(int i=nums.Length-1;i>=0;i--)
        {
        	if(i+nums[i]>=lastPos)
        	{
        		lastPos = i;
        	}
        }
        return lastPos==0;
    }
}