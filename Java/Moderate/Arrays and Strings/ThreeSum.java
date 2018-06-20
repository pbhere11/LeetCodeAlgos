/*
Given array nums = [-1, 0, 1, 2, -1, -4],
-4, -1, -1, 0, 1, 2

A solution set is:
[
  [-1, 0, 1],
  [-1, -1, 2]
]
*/
class Solution {
    public List<List<Integer>> threeSum(int[] nums) {
        quickSort(nums,0,nums.length-1);
        List<List<Integer>> result = new ArrayList<List<Integer>>();

        for(int i=0;i<nums.length-2;i++)
        {
        	if(i==0||nums[i]!=nums[i-1])
        	{
        		int num = nums[i];
	        	int j = i+1;
	        	int k = nums.length-1;
	        	while(j<k)
	        	{
	        		
	        			List<Integer> innerList = new ArrayList<Integer>();
		        		if(num + nums[j] + nums[k]==0)
		        		{
		        			innerList.add(num);
		        			innerList.add(nums[j]);
		        			innerList.add(nums[k]);
		        			result.add(innerList);
		        			j++;
		        			k--;
		        			while(j<nums.length && j>0 && nums[j]==nums[j-1])
							{
								j++;
							}
							while(k<nums.length-1 && k>=0 && nums[k]==nums[k+1])
							{
								k--;
							}
		        		}
		        		else if(num + nums[j] + nums[k]<0)
		        		{
		        			j++;
		        		}
		        		else if(num + nums[j] + nums[k]>0)
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
    	int num = nums[end];
    	int index = start;
    	for(int i=start;i<end;i++)
    	{
    		if(nums[i]<num)
    		{
    			swap(nums,i,index);
    			index++;
    		}
    	}
    	swap(nums,index,end);
    	return index;
    }
    private void swap(int[] nums, int i, int j)
    {
    	int temp = nums[i];
    	nums[i] = nums[j];
    	nums[j] = temp;
    }
}