/*
Given [1,1,1,2,2,3] and k = 2, return [1,2].
*/
class Solution {
    private int heapSize =0;
    public List<Integer> topKFrequent(int[] nums, int k) {
        
        HashMap<Integer,Integer> counterMap = new HashMap<Integer,Integer>();
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
        for(int num : counterMap.keySet())
        {
            heap[index] = num;
            index++;
        }
        heapSize = heap.length;
        buildHeap(heap,counterMap);
        List<Integer> result = new ArrayList<Integer>();
        for(int i=0;i<k;i++)
        {
            int temp = heap[0];
            heap[0] = heap[heapSize-1];
            heap[heapSize-1] = temp;
            result.add(heap[heapSize-1]);
            heapSize--;
            maxHeapify(heap,counterMap,0);
        }
        return result;
    }
    

    private void buildHeap(int[] heap,HashMap<Integer,Integer> counterMap)
    {
        for(int i=heap.length/2;i>=0;i--)
        {
            maxHeapify(heap,counterMap,i);
        }
    }

    private void maxHeapify(int[] heap,HashMap<Integer,Integer> counterMap, int index)
    {
        int left = 2*index+1;
        int right = 2*index+2;
        int max = index;
        if(left>=0 && left<heapSize && counterMap.get(heap[left])>counterMap.get(heap[index]))
        {
            max = left;
        }
        if(right>=0 && right<heapSize && counterMap.get(heap[right])>counterMap.get(heap[max]))
        {
            max = right;
        }
        if(max!=index)
        {
            int temp = heap[max];
            heap[max] = heap[index];
            heap[index] = temp;
            maxHeapify(heap,counterMap,max);
        }
    }

}