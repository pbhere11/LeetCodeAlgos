/*
Given array nums = [-1, 0, 1, 2, -1, -4],

A solution set is:
[
  [-1, 0, 1],
  [-1, -1, 2]
]
*/
class Solution {
    public List<List<Integer>> threeSum(int[] nums) {
    	List<List<Integer>> result = new ArrayList<List<Integer>>();
        quickSort(nums,0,nums.length-1);
        for(int i=0;i<nums.length-2;i++)
        {
        	if(i==0 || nums[i]!=nums[i-1])
        	{
        		
	        	int j = i+1;
	        	int k = nums.length-1;
	        	int key = nums[i];
	        	while(j<k)
	        	{
                    List<Integer> innerList = new ArrayList<Integer>();
	        		if(key + nums[j] + nums[k]==0)
	        		{
	        			innerList.add(key);
	        			innerList.add(nums[j]);
	        			innerList.add(nums[k]);
	        			result.add(innerList);
	        			j++;
	        			k--;
	        			while(j>0&&j<nums.length&&j<k&&nums[j]==nums[j-1])
		        		{
		        			j++;
		        		}
		        		while(k>=0&&k<nums.length-1&&j<k&&nums[k]==nums[k+1])
		        		{
		        			k--;
		        		}
	        		}
	        		else if(key + nums[j] + nums[k]<0)
	        		{
	        			j++;
	        		}
	        		else
	        		{
	        			k--;
	        		}
	        	}
        	}
        }
        return result;
    }

    private void quickSort(int[] nums, int start, int end)
    {
    	if(start<end)
    	{
    		int q = partition(nums,start,end);
    		quickSort(nums,start,q-1);
    		quickSort(nums,q+1,end);
    	}
    }
    private int partition(int[] nums, int start, int end)
    {
    	int key = nums[end];
    	int j = start;
    	for(int i=start;i<end;i++)
    	{
    		if(nums[i]<=key)
    		{
    			int temp = nums[j];
    			nums[j] = nums[i];
    			nums[i] = temp;
    			j++;
    		}	
    	}
    	int temp = nums[j];
    	nums[j] = nums[end];
    	nums[end] = temp;
    	return j;
    }
}