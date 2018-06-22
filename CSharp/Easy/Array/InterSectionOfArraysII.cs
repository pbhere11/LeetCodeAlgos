/*
Example:
Given nums1 = [1, 2, 2, 1], nums2 = [2, 2], return [2, 2].
*/
public class Solution {
	private int HeapSize =0;
    public int[] Intersect(int[] nums1, int[] nums2) {
    	
        Sort(nums1);
        Sort(nums2);
        int i=0;
        int j=0;
        List<int> resultList = new List<int>();
        while(i<nums1.Length && j<nums2.Length)
        {
        	if(nums1[i]<nums2[j])
        	{
        		i++;
        	}
        	else if (nums1[i]>nums2[j])
        	{
        		j++;
        	}
        	else
        	{
        		resultList.Add(nums1[i]);
        		i++;
        		j++;
        	}
        }
        return resultList.ToArray();
    }

    private void Sort(int[] nums)
    {
    	BuildHeap(nums);
    	for(int i=0;i<nums.Length;i++)
    	{
    		int temp = nums[0];
    		nums[0] = nums[HeapSize-1];
    		nums[HeapSize-1] = temp;
    		HeapSize--;
    		MaxHeapify(nums,0);
    	}
    }

    private void BuildHeap(int[] nums)
    {
    	HeapSize = nums.Length;
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
    	if(left<HeapSize && nums[left]>nums[index])
    	{
    		max = left;
    	}
    	if(right<HeapSize && nums[right]>nums[max])
    	{
    		max = right;
    	}
    	if(max!=index)
    	{
    		int temp = nums[index];
    		nums[index] = nums[max];
    		nums[max] = temp;
    		MaxHeapify(nums,max);
    	}
    }
}