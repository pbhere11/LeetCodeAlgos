
/*
Example 1:

Input: nums = [4,5,6,7,0,1,2], target = 0
Output: 4
Example 2:

Input: nums = [4,5,6,7,0,1,2], target = 3
Output: -1

[4,5,6,7,8,1,2,3]
8
*/
class Solution {
    public int search(int[] nums, int target) {
    	if(nums.length==0)
    	{
    		return -1;
    	}
        return search(nums, target, 0, nums.length-1);
    }

    private int search(int[] nums, int target, int start, int end)
    {
    	if(start<0||start>=nums.length||end<0||end>=nums.length||start>end)
    	{
    		return -1;
    	}
    	if(start==end)
    	{
    		if(nums[start]==target)
    		{
    			return start;
    		}
    		else
    		{
    			return -1;
    		}
    	}
    	int mid = (start+end)/2;
    	if(target==nums[mid])
    	{
    		return mid;
    	}
    	if(target<nums[mid])
    	{
    		if(nums[start]<=target || nums[start]>nums[mid])
    		{
    			return search(nums, target, start, mid-1);
    		}
    		else
    		{
    			return search(nums, target, mid+1, end);
    		}
    	}
    	if(target>nums[mid])
    	{
    		if(nums[end]>=target || nums[end]<nums[mid])
    		{
    			return search(nums, target, mid+1, end);
    		}
    		else
    		{
    			return search(nums, target, start, mid-1);
    		}
    	}
    	return -1;

    }
}