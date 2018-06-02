/**
 * Definition for an interval.
 * public class Interval {
 *     int start;
 *     int end;
 *     Interval() { start = 0; end = 0; }
 *     Interval(int s, int e) { start = s; end = e; }
 * }
 */
class Solution {
    public int minMeetingRooms(Interval[] intervals) {
        quickSort(intervals,0,intervals.length-1);
        Iterval currentInterval = new Interval(intervals[0].start.intervals[0].end);
        for(int i=1;i<intervals.length;i++)
        {
        	
        }
    }

    private void quickSort(Interval[] intervals, int start, int end)
    {
    	if(start<end)
    	{
    		int q = partition(intervals,start,end);
    		quickSort(intervals,start,mid-1);
    		quickSort(intervals,mid+1,end);
    	}
    }

    private int partition(Interval[] intervals, int start, int end)
    {
    	int key = intervals[end].start;
    	int leftIndex =start;
    	for(int i=start;i<end;i++)
    	{
    		if(intervals[i].start<key)
    		{
    			Interval temp = intervals[i];
    			intervals[i] = intervals[leftIndex];
    			intervals[leftIndex] = temp;
    			leftIndex++;
    		}
    	}
    	Interval temp = intervals[end];
		intervals[end] = intervals[leftIndex];
		intervals[leftIndex] = temp;
		return leftIndex;
    }
}