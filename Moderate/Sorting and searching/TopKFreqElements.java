/*
Given [1,1,1,2,2,3] and k = 2, return [1,2].
*/
class Solution {
	public int heapSize = 0;
    public List<Integer> topKFrequent(int[] nums, int k) {
    	heapSize=k;
        HashMap<Integer,Integer> countMap = new HashMap<Integer,Integer>();

        //O(n)
        for(int i=0;i<nums.length;i++)
        {
        	if(countMap.containsKey(nums[i]))
        	{
        		countMap.put(nums[i],countMap.get(nums[i])+1);
        	}
        	else
        	{
        		countMap.put(nums[i],1);
        	}
        }
        int[] heap = new int[countMap.size()];
        int x=0;
        for(Map.Entry<Integer, Integer> entry: countMap.entrySet())
        {
        	heap[x] = entry.getKey();
        	x++;
        }
        heapSort(heap,countMap);
        for(int j=k;j<heap.length;j++)
        {
        	int temp = heap[0];
        	heap[0] = heap[heapSize-1];
        	heap[heapSize-1] = temp;
        	if(countMap.get(heap[j])>=countMap.get(heap[0]))
        	{
        		heap[0] = heap[j];
        	}
        	maxHeapify(heap,countMap,0);
        }
        List<Integer> result = new ArrayList<Integer>();

        for(int j=0;j<k;j++)
        {
        	result.add(heap[j]);
        }

        return result;
    }

    private void heapSort(int[] nums, HashMap<Integer,Integer>countMap)
    {
    	buildHeap(nums,countMap);
    }
    private void buildHeap(int[] nums, HashMap<Integer,Integer>countMap)
    {
    	for(int i=nums.length/2;i>=0;i--)
    	{
    		maxHeapify(nums,countMap, i);
    	}
    }
    private void maxHeapify(int[] nums, HashMap<Integer,Integer>countMap, int i)
    {
    	int left = 2*i+1;
    	int right = 2*i+2;
    	int max = i;
    	if(left < heapSize && countMap.get(nums[left])>=countMap.get(nums[i]))
    	{
    		max = left;
    	}
    	if(right < heapSize && countMap.get(nums[right])>=countMap.get(nums[max]))
    	{
    		max = right;
    	}
    	if(max!=i)
    	{
    		int temp = nums[max];
	    	nums[max] = nums[i];
	    	nums[i] = temp;
	    	maxHeapify(nums, countMap,max);
    	}
    }
}