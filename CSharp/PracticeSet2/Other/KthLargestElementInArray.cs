public class Solution {
	private int HeapSize =0;
    public int FindKthLargest(int[] nums, int k) {
        HeapSize = k;
        BuildHeap(nums);
        for(int i =k;i<nums.Length;i++)
        {
        	if(nums[i]>nums[0])
        	{
        		Swap(nums,i,0);
        		MinHeapify(nums,0);
        	}
        }
        return nums[0];
    }
    private void BuildHeap(int[] nums)
    {
    	for(int i=HeapSize/2;i>=0;i--)
    	{
    		MinHeapify(nums,i);
    	}
    }
    private void MinHeapify(int[] nums, int index)
    {
    	int left = index*2+1;
    	int right = index*2+2;
    	int min = index;
    	if(left<HeapSize && nums[left]<nums[index])
    	{
    		min = left;
    	}
    	if(right<HeapSize && nums[right]<nums[min])
    	{
    		min = right;
    	}
    	if(min!=index)
    	{
    		Swap(nums,min,index);
    		MinHeapify(nums,min);
    	}
    }
    private void Swap(int[] nums, int i, int j)
    {
    	int temp = nums[i];
    	nums[i]=nums[j];
    	nums[j] = temp;
    }
}