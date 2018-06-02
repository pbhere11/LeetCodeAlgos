/**
 * Definition for an interval.
 * public class Interval {
 *     int start;
 *     int end;
 *     Interval() { start = 0; end = 0; }
 *     Interval(int s, int e) { start = s; end = e; }
 * }
<<<<<<< HEAD

 Example 1:

Input: [[0, 30],[5, 10],[15, 20]]
Output: 2
Example 2:

Input: [[7,10],[2,4]]
Output: 1

[[8,14],[12,13],[6,13],[1,9]]

 */
class Solution {
	private int heapSize = 0;
    public int minMeetingRooms(Interval[] intervals) {
        if(intervals.length==0 || intervals.length==1)
        {
            return intervals.length;
        }
        quickSort(intervals,0,intervals.length-1);
        Interval[] heapIntervals = new Interval[intervals.length];
        heapIntervals[0] = intervals[0];
        heapSize = 1;
        int count =1;
        for(int i=1;i<intervals.length;i++)
        {
        	Interval intrvl = heapIntervals[0];
        	if(intervals[i].start<intrvl.end)
        	{
        		count++;
                heapIntervals[heapSize] = intervals[i];
                heapSize++;
                buildHeap(heapIntervals);
        	}
        	else 
        	{
        		heapIntervals[0]=intervals[i];
        		minHeapify(heapIntervals,0);
        	}
        }
        return count;
    }

    private void buildHeap(Interval[] heapIntervals)
    {
    	for(int i=heapSize/2;i>=0;i--)
    	{
    		minHeapify(heapIntervals,i);
    	}
    }

    private void minHeapify(Interval[] heapIntervals, int index)
    {
    	int left = index*2+1;
    	int right = index*2+2;
    	int min =index;
    	if(left>=0 && left<heapSize && heapIntervals[left].end<heapIntervals[index].end)
    	{
    		min = left;
    	}
    	if(right>=0 && right<heapSize && heapIntervals[right].end<heapIntervals[min].end)
    	{
    		min = right;
    	}
    	if(min!=index)
    	{
    		swap(heapIntervals,min,index);
    		minHeapify(heapIntervals,min);
    	}

    }

    private void quickSort(Interval[] intervals, int start, int end)
    {

        //[[8,14],[12,13],[6,13],[1,9]]
    	if(start>=0 && start<=intervals.length && end>=0 && end<=intervals.length && start<end)
    	{
    		int q = partition(intervals,start,end);
            quickSort(intervals,start,q-1);
    		quickSort(intervals,q+1,end);
    	}	

    }

    private int partition(Interval[] intervals, int start, int end)
    {

    	Interval keyInterval = intervals[end];
    	int leftIndex =start;
    	for(int i=start;i<end;i++)
    	{
    		if(intervals[i].start<keyInterval.start)
    		{
    			swap(intervals,i,leftIndex);
    			leftIndex++;
    		}
    	}
    	swap(intervals,leftIndex,end);
    	return leftIndex;
    }
    private void swap(Interval[] intervals, int i, int j)
    {
    	Interval temp = intervals[i];
    	intervals[i] = intervals[j];
    	intervals[j] = temp;
    }
}