/*
Example 1:

Input: [3,2,1,5,6,4] and k = 2
Output: 5
Example 2:

Input: [3,2,3,1,2,4,5,5,6] and k = 4
Output: 4
*/
class Solution {
	private int heapSize = 0;
    public int findKthLargest(int[] nums, int k) {
    	if(nums.length==0)
    	{
    		return 0;
    	}
        heapSize = k;
        buildHeap(nums);
        for(int i=k;i<nums.length;i++)
        {
        	if(nums[i]>nums[0])
        	{
        		nums[0] = nums[i];
        		minHeapify(nums,0);
        	}
        }
        return nums[0];
    }
    private void buildHeap(int[] nums)
    {
    	for(int i=nums.length/2;i>=0;i--)
    	{
    		minHeapify(nums,i);
    	}
    }
    private void minHeapify(int[] nums, int index)
    {
    	int left = index*2+1;
    	int right = index*2+2;
    	int min = index;
    	if(left<heapSize && nums[left]<nums[index])
    	{
    		min = left;
    	}
    	if(right<heapSize &&nums[right]<nums[min])
    	{
    		min = right;
    	}
    	if(min!=index)
    	{
    		int temp = nums[index];
    		nums[index] = nums[min];
    		nums[min] = temp;
    		minHeapify(nums,min);
    	}
    }
}