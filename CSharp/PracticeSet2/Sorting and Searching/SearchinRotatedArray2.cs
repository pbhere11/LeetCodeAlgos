/*
Example 1:

Input: nums = [2,5,6,0,0,1,2], target = 0
Output: true
Example 2:

Input: nums = [2,5,6,0,0,1,2], target = 3
Output: false
*/
public class Solution {
    public bool Search(int[] nums, int target) {
        return Search(nums,target,0,nums.Length-1);
    }
        private bool Search(int[] nums, int target, int start, int end)
	    {
	    	if(start<=end)
	    	{
	    		int mid = (start+end)/2;
	    		if(nums[mid]==target)
	    		{
	    			return true;
	    		}
	    		else if(nums[start]<nums[mid])
	    		{
	    			if(target<nums[mid] && target>=nums[start])
	    			{
	    				return Search(nums,target,start,mid-1);
	    			}
	    			else
	    			{
	    				return Search(nums,target,mid+1,end);
	    			}
	    		}
	    		else if(nums[start]>nums[mid])
	    		{
	    			if(target>nums[mid]&&target<=nums[end])
	    			{
	    				return Search(nums,target,mid+1,end);
	    			}
	    			else
	    			{
	    				return Search(nums,target,start,mid-1);
	    			}
	    		}
	    		else
	    		{
	    			return Search(nums,target,start+1,end);
	    		}
	    	}
	    	else
	    	{
	    		return false;
	    	}
	    }
}