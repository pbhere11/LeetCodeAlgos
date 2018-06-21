/*
Example 1:

Given nums = [1,1,2],

Your function should return length = 2, with the first two elements of nums being 1 and 2 respectively.

It doesn't matter what you leave beyond the returned length.
Example 2:

Given nums = [0,0,1,1,1,2,2,3,3,4],

Your function should return length = 5, with the first five elements of nums being modified to 0, 1, 2, 3, and 4 respectively.

It doesn't matter what values are set beyond the returned length.
[0,0,1,1,1,2,2,3,3,4]

0,1,2,3,4,0,2,1,3,4
*/
public class Solution {
    public int RemoveDuplicates(int[] nums) {
    	if(nums.Length==0 || nums.Length==1)
    	{
    		return nums.Length;
    	}
        int slow = 0;
        int fast = 1;
        while(fast<nums.Length)
        {
        	if(nums[fast]!=nums[slow])
        	{
        		slow++;
        		nums[slow] = nums[fast];
        	}
        	fast++;
        }
        return slow+1;
    }
}