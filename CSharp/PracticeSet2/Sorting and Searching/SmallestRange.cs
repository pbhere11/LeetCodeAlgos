/*
Example 1:
Input:[[4,10,15,24,26], [0,9,12,20], [5,18,22,30]]
Output: [20,24]
Explanation: 
List 1: [4, 10, 15, 24,26], 24 is in range [20,24].
List 2: [0, 9, 12, 20], 20 is in range [20,24].
List 3: [5, 18, 22, 30], 22 is in range [20,24].
*/
public class Solution {
	private int HeapSize =0;
	private int[] indexTracker;
    public int[] SmallestRange(IList<IList<int>> nums) {
        int[] result = new int[2];
        result[0]=0;
        result[1]=0;
        if(nums.Count==0)
        {
        	return result;
        }
        int min =nums[0][0];
        int max = nums[0][0];
        for(int i=0;i<nums.Count;i++)
        {
        	min = Math.Min(min,nums[i][0]);
        	max = Math.Max(max,nums[i][0]);
        }
        int range = max-min;
        HeapSize = nums.Count;
        indexTracker = new int[nums.Count];
        for(int i=0;i<indexTracker.Length;i++)
        {
        	indexTracker[i] = 0;
        }
        BuildHeap(nums);
        int currMax = max;
		int currMin = min;
		int currRange = range;
        while(indexTracker[0]<nums[0].Count)
        {
        	indexTracker[0]++;
        	if(indexTracker[0]>=nums[0].Count)
        	{
        		result[0] = min;
        		result[1] = max;
        		return result;
        	}
        	currMax = Math.Max(nums[0][indexTracker[0]],currMax);
        	MinHeapify(nums,0);
        	currMin = nums[0][indexTracker[0]];
        	currRange = currMax-currMin;
        	if(currRange<range)
        	{
        		min = currMin;
        		max = currMax;
        		range = currRange;
        	}
        }
        result[0]=min;
        result[1]=max;
        return result;
    }
    private void BuildHeap(IList<IList<int>> nums)
    {
    	for(int i= nums.Count/2;i>=0;i--)
    	{
    		MinHeapify(nums,i);
    	}
    }
    private void MinHeapify(IList<IList<int>> nums, int index)
    {
    	int left = index*2+1;
    	int right = index*2+2;
    	int min = index;
    	int mainIndex = indexTracker[index];
    	if(left<HeapSize)
    	{
    		int leftIndex = indexTracker[left];
    		if(nums[left][leftIndex]<nums[index][mainIndex])
    		{
    			min = left;
    		}
    	}
    	if(right<HeapSize)
    	{
    		int rightIndex = indexTracker[right];
    		int currIndex = min==index?indexTracker[index]:indexTracker[left];
    		if(nums[right][rightIndex]<nums[min][currIndex])
    		{
    			min = right;
    		}
    	}
    	if(min!=index)
    	{
    		Swap(nums,index,min);
    		SwapInt(indexTracker,index,min);
    		MinHeapify(nums,min);
    	}
    }
    private void SwapInt(int[] nums, int i, int j)
    {
    	int temp = nums[i];
    	nums[i] = nums[j];
    	nums[j] = temp;
    }
    private void Swap(IList<IList<int>> nums, int i, int j)
    {
    	IList<int> temp = nums[i];
    	nums[i] = nums[j];
    	nums[j] = temp;
    }
}