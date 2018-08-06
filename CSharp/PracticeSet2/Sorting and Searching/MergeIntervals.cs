/**
 * Definition for an interval.
 * public class Interval {
 *     public int start;
 *     public int end;
 *     public Interval() { start = 0; end = 0; }
 *     public Interval(int s, int e) { start = s; end = e; }
 * }
 */
public class Solution {
	private int HeapSize =0;
    public IList<Interval> Merge(IList<Interval> intervals) {
        Sort(intervals);
        IList<Interval> result = new List<Interval>();
        if(intervals.Count==0)
        {
        	return result;
        }
        result.Add(intervals[0]);
        int currentStart = intervals[0].start;
        int currentEnd = intervals[0].end; 
        int currentIndex =0;
        for(int i=1;i<intervals.Count;i++)
        {
        	if(intervals[i].start<=currentEnd)
        	{
        		if(intervals[i].end>currentEnd)
        		{
        			result[currentIndex].end = intervals[i].end;
        			currentEnd = intervals[i].end;
        		}
        	}
        	else
        	{
        		result.Add(intervals[i]);
        		currentStart=intervals[i].start;
        		currentEnd = intervals[i].end;
        		currentIndex++;
        	}
        }
        return result;
    }
    private void Sort(IList<Interval> intervals)
    {
    	BuildHeap(intervals);
    	for(int i=0;i<intervals.Count;i++)
    	{
    		Swap(intervals,0,HeapSize-1);
    		HeapSize--;
    		MaxHeapify(intervals,0);
    	}
    }
    private void BuildHeap(IList<Interval> intervals)
    {
    	HeapSize = intervals.Count;
    	for(int i=intervals.Count/2;i>=0;i--)
    	{
    		MaxHeapify(intervals,i);
    	}
    }
    private void MaxHeapify(IList<Interval> intervals, int index)
    {
    	int left = index*2+1;
    	int right = index*2+2;
    	int max = index;
    	if(left<HeapSize && intervals[left].start!=intervals[index].start && intervals[left].start>intervals[index].start)
    	{
    		max = left;
    	}
    	if(left<HeapSize && intervals[left].start==intervals[index].start && intervals[left].end>intervals[index].end)
    	{
    		max = left;
    	}
    	if(right<HeapSize && intervals[right].start!=intervals[max].start && intervals[right].start>intervals[max].start)
    	{
    		max = right;
    	}
    	if(right<HeapSize && intervals[right].start==intervals[max].start && intervals[right].end>intervals[max].end)
    	{
    		max = right;
    	}	
    	if(max!=index)
    	{
    		Swap(intervals,index,max);
    		MaxHeapify(intervals,max);
    	}
    }
    private void Swap(IList<Interval> intervals, int i, int j)
    {
    	Interval temp = intervals[i];
    	intervals[i] = intervals[j];
    	intervals[j] = temp;
    }
}