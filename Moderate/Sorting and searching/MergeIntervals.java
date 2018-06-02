

/**
 * Definition for an interval.
 * public class Interval {
 *     int start;
 *     int end;
 *     Interval() { start = 0; end = 0; }
 *     Interval(int s, int e) { start = s; end = e; }
 * }

 Example 1:

Input: [[1,3],[2,6],[8,10],[15,18]]
Output: [[1,6],[8,10],[15,18]]
Explanation: Since intervals [1,3] and [2,6] overlaps, merge them into [1,6].
Example 2:

Input: [[1,4],[4,5]]
Output: [[1,5]]
Explanation: Intervals [1,4] and [4,5] are considerred overlapping.

 */
class Solution {
    public List<Interval> merge(List<Interval> intervals) {
        
        List<Interval> result = new ArrayList<Interval>();
        if(intervals.size()==0)
        {
        	return result;
        }
        quickSort(intervals,0,intervals.size()-1);
        Interval currentInterval = new Interval(intervals.get(0).start,intervals.get(0).end);
        result.add(currentInterval);
        int resultIndex = 0;
        for(int i=1;i<intervals.size();i++)
        {
        	if(intervals.get(i).start>result.get(resultIndex).end)
        	{
        		resultIndex++;
        		Interval intrvl = new Interval(intervals.get(i).start,intervals.get(i).end);
        		result.add(resultIndex,intrvl);
        	}
        	else if(intervals.get(i).end>result.get(resultIndex).end)
        	{
        		result.get(resultIndex).end = intervals.get(i).end;
        	}
        }
        return result;
    }

    private void quickSort(List<Interval> intervals, int start, int end)
    {
    	if(start<end)
    	{
    		int q = partition(intervals,start,end);
    		quickSort(intervals,start,q-1);
    		quickSort(intervals,q+1,end);
    	}
    }
    private int partition(List<Interval> intervals,int start, int end)
    {
    	int key = intervals.get(end).start;
    	int leftIndex = start;
    	for(int i=start;i<end;i++)
    	{
    		if(intervals.get(i).start<key)
    		{
    			Collections.swap(intervals,i,leftIndex);
    			leftIndex++;
    		}
    	}
    	Collections.swap(intervals,end,leftIndex);
		return leftIndex;
    }
}