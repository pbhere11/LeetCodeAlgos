/*
Example 1:

Input: [[1,3],[2,6],[8,10],[15,18]]
Output: [[1,6],[8,10],[15,18]]
Explanation: Since intervals [1,3] and [2,6] overlaps, merge them into [1,6].
Example 2:

Input: [[1,4],[4,5]]
Output: [[1,5]]
Explanation: Intervals [1,4] and [4,5] are considerred overlapping.
*/
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
    	IList<Interval> result = new List<Interval>();
    	
    	if(intervals.Count==0)
    	{
    		return result;
    	}
    	Sort(intervals);
    	int currentStart = intervals[0].start;
        int currentEnd = intervals[0].end;
        
        for(int i=1;i<intervals.Count;i++)
        {
        	if(intervals[i].start<=currentEnd)
        	{
        		if(intervals[i].end>currentEnd)
        		{
        			currentEnd = intervals[i].end;
        		}
        	}
        	else
        	{
        		Interval intrvl = new Interval(currentStart,currentEnd);
        		result.Add(intrvl);
        		currentStart = intervals[i].start;
        		currentEnd = intervals[i].end;
        	}
        }
        Interval interval = new Interval(currentStart,currentEnd);
        result.Add(interval);
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
    	if(left<HeapSize && intervals[left].start>intervals[index].start)
    	{
    		max = left;
    	}
    	if(left<HeapSize && intervals[left].start==intervals[index].start && intervals[left].end>intervals[index].end)
    	{
    		max = left;
    	}
    	if(right<HeapSize && intervals[right].start>intervals[max].start)
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