/*
Example 1:

Input: nums = [1,2,3,1]
Output: 2
Explanation: 3 is a peak element and your function should return the index number 2.
Example 2:

Input: nums = [1,2,1,3,5,6,4]
Output: 1 or 5 
Explanation: Your function can return either index number 1 where the peak element is 2, 
             or index number 5 where the peak element is 6.
*/
class Solution {
    public int findPeakElement(int[] nums) {
        return findPeekElement(nums,0,nums.length-1);
    }
    private int findPeekElement(int[] nums, int start, int end)
    {
    	if(start==end)
    	{
    		return start;
    	}
    	int mid = (start + end)/2;
    	if(nums[mid]>nums[mid+1])
    	{
    		return findPeekElement(nums,start,mid);
    	}
    	else
    	{
    		return findPeekElement(nums,mid+1,end);
    	}
    }
}