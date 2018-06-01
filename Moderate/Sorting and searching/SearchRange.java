/*
Example 1:

Input: nums = [5,7,7,8,8,10], target = 8
Output: [3,4]
Example 2:

Input: nums = [5,7,7,8,8,10], target = 6
Output: [-1,-1]

Input: nums = [2,2], target = 1
Output: [-1,-1]

[1,2,3,3,3,3,4,5,9]
3

*/
class Solution {
    public int[] searchRange(int[] nums, int target) {
    	int[] result = new int[2];
    	result[0] = -1;
    	result[1] = -1;
    	if(nums.length==0)
    	{
    		return result;
    	}
        searchRange(nums,target,0,nums.length-1,result,true,true);
        return result;
    }
    private void searchRange(int[] nums, int target, int start, int end, int[] result, boolean searchLow, boolean searchHigh)
    {
    	if(start<0||start>=nums.length||end<0||end>=nums.length || start>end)
    	{
    		return;
    	}
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
			return;
    	}
    	int mid = (start+end)/2;
    	if(nums[mid]<target)
    	{
    		searchRange(nums,target,mid+1,end,result,searchLow,searchHigh);
    	}
    	else if(nums[mid]>target)
    	{
    		searchRange(nums,target,start,mid-1,result,searchLow,searchHigh);
    	}
    	else if(nums[mid]==target)
    	{
    		
    		if(searchLow)
    		{
    			result[0] = mid;
    			searchRange(nums,target,start,mid-1,result,true,false);
    		}
    		if(searchHigh)
    		{
    			result[1] = mid;
    			searchRange(nums,target,mid+1,end,result,false,true);
    		}
    	}
    }
}