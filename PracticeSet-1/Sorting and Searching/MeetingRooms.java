/**
 * Definition for an interval.
 * public class Interval {
 *     int start;
 *     int end;
 *     Interval() { start = 0; end = 0; }
 *     Interval(int s, int e) { start = s; end = e; }
 * }
Example 1:

Input: [[0, 30],[5, 10],[15, 20]]
Output: 2
Example 2:

Input: [[7,10],[2,4]]
Output: 1
 */
class Solution {
	private int heapSize;
    public int minMeetingRooms(Interval[] intervals) {
    	if(intervals.length==0)
    	{
    		return 0;
    	}
     	sort(intervals,0,intervals.length-1); 
     	heapSize=intervals.length; 
     	Interval[] heapIntervals = new Interval[intervals.length];
     	heapIntervals[0] = intervals[0];
     	heapSize=1;
     	int count=1;
     	for(int i=1;i<intervals.length;i++)
     	{
     		if(intervals[i].start<heapIntervals[0].end)
     		{
     			count++;
     			addToHeap(heapIntervals,intervals[i]);
     		}
     		else
     		{
     			heapIntervals[0] = intervals[i];
     			minHeapify(heapIntervals,0);
     		}
     	}
     	return count;
    }
    private void addToHeap(Interval[] heapIntervals,Interval interval)
    {
    	heapIntervals[heapSize] = interval;
    	heapSize++;
    	buildHeap(heapIntervals);
    }
    private void buildHeap(Interval[] intervals)
    {
    	for(int i=intervals.length/2;i>=0;i--)
    	{
    		minHeapify(intervals,i);
    	}
    }
    private void minHeapify(Interval[] intervals, int index)
    {
    	int left = index*2+1;
    	int right = index*2+2;
    	int min = index;
    	if(left<heapSize && intervals[left].end<intervals[index].end)
    	{
    		min = left;
    	}
    	if(right<heapSize && intervals[right].end<intervals[min].end)
    	{
    		min = right;
    	}
    	if(min!=index)
    	{
    		swap(intervals,min,index);
    		minHeapify(intervals,min);
    	}
    }
    private void sort(Interval[] intervals,int start, int end)
    {	
    	if(start<end)
    	{
    		int q = partition(intervals,start,end);
    		sort(intervals,start,q-1);
    		sort(intervals,q+1,end);
    	}
    }
    private int partition(Interval[] intervals, int start, int end)
    {
    	Interval key = intervals[end];
    	int index =start;
    	for(int i=start;i<end;i++)
    	{
    		if(intervals[i].start<key.start)
    		{
    			swap(intervals,i,index);
    			index++;
    		}
    	}
    	swap(intervals,end,index);
    	return index;
    }
    private void swap(Interval[] intervals, int i, int j)
    {
    	Interval temp = intervals[i];
    	intervals[i] = intervals[j];
    	intervals[j] = temp;
    }
}