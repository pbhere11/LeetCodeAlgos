/*
Example 1:

Input: nums = [5,7,7,8,8,10], target = 8
Output: [3,4]
Example 2:

Input: nums = [5,7,7,8,8,10], target = 6
Output: [-1,-1]

Input: nums = [5,7,7,8,8,10], target = 8
Output: [3,4]
Example 2:


*/
public class Solution {
    public int[] SearchRange(int[] nums, int target) {
         int[] result = new int[2];
         result[0]= -1;
         result[1] = -1;
         SearchRange(nums,target, 0, nums.Length-1,result,true,true);
         return result;
    }

    private void SearchRange(int[] nums, int target, int start, int end, int[] result, bool searchLow, bool searchHigh)
    {
    	if(start>=0 && start< nums.Length && end>=0 && end<nums.Length && start<=end)
    	{
    		if(start==end)
    		{
    			if(nums[start]==target)
    			{
    				if(searchLow)
		    		{
		    			result[0] = start;
		    		}
		    		if(searchHigh)
		    		{
		    			result[1] = start;
		    		}
    			}
    		}
    		int mid = (start+end)/2;
	    	if(nums[mid]>target)
	    	{
	    		SearchRange(nums,target, start, mid-1,result,searchLow,searchHigh);
	    	}
	    	else if(nums[mid]<target)
	    	{
	    		SearchRange(nums,target, mid+1, end,result,searchLow,searchHigh);
	    	}
	    	else if(nums[mid]==target)
	    	{
	    		if(searchLow)
	    		{
	    			result[0] = mid;
	    			SearchRange(nums,target, start, mid-1,result,true,false);
	    		}
	    		if(searchHigh)
	    		{
	    			result[1] = mid;
	    			SearchRange(nums,target, mid+1, end,result,false,true);
	    		}
	    	}
    	}
    }
}