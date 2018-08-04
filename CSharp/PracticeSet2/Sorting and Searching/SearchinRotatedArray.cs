/*
Example 1:

Input: nums = [4,5,6,7,0,1,2], target = 0
Output: 4
Example 2:

Input: nums = [4,5,6,7,0,1,2], target = 3
Output: -1
*/
public class Solution {
    public int Search(int[] nums, int target) {
        return Search(nums,target,0,nums.Length-1);
    }
    private int Search(int[] nums, int target, int start, int end)
    {
    	if(start<=end)
    	{
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
    		if(nums[mid]==target)
    		{
    			return mid;
    		}
    		else if(nums[start]<=nums[mid])
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
    		else
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
    	}
    	else
    	{
    		return -1;
    	}
    }
}