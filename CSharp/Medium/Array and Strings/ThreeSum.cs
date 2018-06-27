/*
Example:

Given array nums = [-1, 0, 1, 2, -1, -4],

A solution set is:
[
  [-1, 0, 1],
  [-1, -1, 2]
]

[-1, 0, 1, 2, -1, -4]
-4, -1, -1, 0, 1, 2

*/
public class Solution {
	private int heapSize =0;
    public IList<IList<int>> ThreeSum(int[] nums) {
        
        IList<IList<int>> returnList = new List<IList<int>>();
        if(nums.Length<3)
        {
        	return returnList;
        }
        Sort(nums);
        for(int i=0;i<nums.Length;i++)
        {
        	if(i==0 || nums[i]!=nums[i-1])
        	{
        		int num = nums[i];
	        	int j = i+1;
	        	int k = nums.Length-1;
	        	while(j<k)
	        	{
	        		if(num+nums[j]+nums[k]==0)
	        		{
	        			IList<int> innerList = new List<int>();
	        			innerList.Add(num);
	        			innerList.Add(nums[j]);
	        			innerList.Add(nums[k]);
	        			returnList.Add(innerList);
	        			innerList = new List<int>();
	        			j++;
	        			k--;
	        			while(j<k && nums[j]==nums[j-1])
	        			{
	        				j++;
	        			}
	        			while(j<k && nums[k]==nums[k+1])
	        			{
	        				k--;
	        			}
	        		}
	        		else
	        		{
	        			if(num+nums[j]+nums[k]<0)
	        			{
	        				j++;
	        			}
	        			if(num+nums[j]+nums[k]>0)
	        			{
	        				k--;
	        			}
	        		}
	        	}
        	}
        }
        return returnList;
    }

    private void Sort(int[] nums)
    {
    	BuildHeap(nums);
    	for(int i=0;i<nums.Length;i++)
    	{
    		Swap(nums,0,heapSize-1);
    		heapSize--;
    		MaxHeapify(nums,0);
    	}
    }

    private void BuildHeap(int[] nums)
    {
    	heapSize = nums.Length;
    	for(int i=nums.Length/2;i>=0;i--)
    	{
    		MaxHeapify(nums,i);
    	}
    }

    private void MaxHeapify(int[] nums, int index)
    {
    	int left = index*2+1;
    	int right = index*2+2;
    	int max = index;
    	if(left<heapSize && nums[left]>nums[index])
    	{
    		max = left;
    	}
    	if(right<heapSize && nums[right]>nums[max])
    	{
    		max = right;
    	}
    	if(max!=index)
    	{
    		Swap(nums,index,max);
    		MaxHeapify(nums,max);
    	}
    }

    private void Swap(int[] nums, int i, int j)
    {
    	int temp = nums[i];
    	nums[i] = nums[j];
    	nums[j] = temp;
    }
}
