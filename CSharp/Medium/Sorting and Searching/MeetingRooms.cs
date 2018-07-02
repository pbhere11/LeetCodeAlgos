/*
Example 1:

Input: [[0, 30],[5, 10],[15, 20]]
Output: 2
Example 2:

Input: [[7,10],[2,4]]
Output: 1

Input: [[0, 30],[5, 10],[15, 20],[19,31],[30,35]]

0 5 15 
10 20 30 
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
    public int MinMeetingRooms(Interval[] intervals) {
        int[] start = new int[intervals.Length];
        int[] end = new int[intervals.Length];
        for(int x=0;x<intervals.Length;x++)
        {
        	start[x] = intervals[x].start;
        	end[x] = intervals[x].end;
        }
        Array.Sort(start);
        Array.Sort(end);

        int i = 0;
        int j = 0;
        int rooms = 0;
        while(i<start.Length)
        {
        	if(start[i]<end[j])
        	{
        		i++;
        	}
        	else if(start[i]>end[j])
        	{
        		j++;
        	}
        	else
        	{
        		i++;
        		j++;
        	}
        	rooms = Math.Max(rooms,i-j);
        }
        return rooms;
    }
}