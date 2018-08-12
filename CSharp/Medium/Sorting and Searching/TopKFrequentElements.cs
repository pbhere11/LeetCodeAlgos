/*
For example,
Given [1,1,1,2,2,3] and k = 2, return [1,2].
*/
public class Solution {
	private int HeapSize =0;
	private Dictionary<int,int> countMap = new Dictionary<int,int>();
    public IList<int> TopKFrequent(int[] nums, int k) {
        
        HeapSize=k;
        for(int i=0;i<nums.Length;i++)
        {
        	if(countMap.ContainsKey(nums[i]))
        	{
        		countMap[nums[i]]++;
        	}
        	else
        	{
        		countMap.Add(nums[i],1);
        	}
        }
        int index =0;
        int[] distinctNums = new int[countMap.Count];
        foreach(KeyValuePair<int,int> item in countMap)
        {
        	distinctNums[index] = item.Key;
        	index++;
        }
        BuildHeap(distinctNums);
        for(int i=k;i<distinctNums.Length;i++)
        {
        	if(countMap[distinctNums[i]]>countMap[distinctNums[0]])
        	{
        		Swap(distinctNums,i,0);
        		MinHeapify(distinctNums,0);
        	}
        }

        for(int i=0;i<k;i++)
        {
        	Swap(distinctNums,0,HeapSize-1);
        	HeapSize--;
        	MinHeapify(distinctNums,0);
        }
        IList<int> result = new List<int>();
        for(int i=0;i<k;i++)
        {
        	result.Add(distinctNums[i]);
        }
        return result;
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
    	if(left<HeapSize&& countMap[nums[left]]<countMap[nums[index]])
    	{
    		min = left;
    	}
    	if(right<HeapSize&&countMap[nums[right]]<countMap[nums[min]])
    	{
    		min = right;
    	}
    	if(min!=index)
    	{
    		Swap(nums,index,min);
    		MinHeapify(nums,min);
    	}
    }

    private void Swap(int[] nums, int i, int j)
    {
    	int temp = nums[i];
    	nums[i] = nums[j];
    	nums[j] = temp;
    }
}