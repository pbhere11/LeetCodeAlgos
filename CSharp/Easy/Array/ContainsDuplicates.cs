/*
Example 1:

Input: [1,2,3,1]
Output: true
Example 2:

Input: [1,2,3,4]
Output: false
Example 3:

Input: [1,1,1,3,3,4,3,2,4,2]
Output: true
*/
public class Solution {
	private int HeapSize =0;
    public bool ContainsDuplicate(int[] nums) {
    	if(nums.Length==0||nums.Length==1)
    	{
    		return false;
    	}
        sort(nums);
        for(int i=1;i<nums.Length;i++)
        {
        	if(nums[i]==nums[i-1])
        	{
        		return true;
        	}
        }
        return false;
    }

    private void sort(int[] nums)
    {
    	buildHeap(nums);
    	for(int i=0;i<nums.Length;i++)
    	{
    		int temp = nums[0];
    		nums[0] = nums[HeapSize-1];
    		nums[HeapSize-1] = temp;
    		HeapSize--;
    		maxHeapify(nums,0);
    	}
    }
    private void buildHeap(int[] nums)
    {
    	HeapSize = nums.Length;
    	for(int i=nums.Length/2;i>=0;i--)
    	{
    		maxHeapify(nums,i);
    	}
    }
    private void maxHeapify(int[] nums, int index)
    {
    	int left =  index*2+1;
    	int right = index*2+2;
    	int max = index;
    	if(left<HeapSize && nums[left]>nums[index])
    	{
    		max = left;
    	}
    	if(right<HeapSize&&nums[right]>nums[max])
    	{
    		max = right;
    	}
    	if(max!=index)
    	{
    		int temp = nums[index];
    		nums[index] = nums[max];
    		nums[max] = temp;
    		maxHeapify(nums,max);
    	}
    }
}