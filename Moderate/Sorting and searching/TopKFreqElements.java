/*
Given [1,1,1,2,2,3] and k = 2, return [1,2].
*/
class Solution {
    private int heapSize =0;
    public List<Integer> topKFrequent(int[] nums, int k) {
        
        HashMap<Integer,Integer> counterMap = new HashMap<Integer,Integer>();
        //O(n)
        for(int i=0;i<nums.length;i++)
        {
            if(counterMap.containsKey(nums[i]))
            {
                counterMap.put(nums[i],counterMap.get(nums[i])+1);
            }
            else
            {
                counterMap.put(nums[i],1);
            }
        }
        int[] heap = new int[counterMap.size()];
        int index =0;
        //O(n)
        for(int num : counterMap.keySet())
        {
            heap[index] = num;
            index++;
        }
        heapSize = k;
        //O(nlgn)
        buildHeap(heap,counterMap);
        List<Integer> result = new ArrayList<Integer>();
        for(int i=k;i<heap.length;i++)
        {
            if(counterMap.get(heap[i])>counterMap.get(heap[0]))
            {
                heap[0] = heap[i];
                minHeapify(heap,counterMap,0);
            }
        }
        for(int i=0;i<k;i++)
        {
            result.add(heap[i]);
        }
        return result;
    }
    

    private void buildHeap(int[] heap,HashMap<Integer,Integer> counterMap)
    {
        for(int i=heap.length/2;i>=0;i--)
        {
            minHeapify(heap,counterMap,i);
        }
    }

    private void minHeapify(int[] heap,HashMap<Integer,Integer> counterMap, int index)
    {
        int left = 2*index+1;
        int right = 2*index+2;
        int min = index;
        if(left>=0 && left<heapSize && counterMap.get(heap[left])<counterMap.get(heap[index]))
        {
            min = left;
        }
        if(right>=0 && right<heapSize && counterMap.get(heap[right])<counterMap.get(heap[min]))
        {
            min = right;
        }
        if(min!=index)
        {
            int temp = heap[min];
            heap[min] = heap[index];
            heap[index] = temp;
            minHeapify(heap,counterMap,min);
        }
    }

}