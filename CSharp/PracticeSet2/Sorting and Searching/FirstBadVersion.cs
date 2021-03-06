/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); 
Example:

Given n = 5, and version = 4 is the first bad version.

call isBadVersion(3) -> false
call isBadVersion(5) -> true
call isBadVersion(4) -> true

Then 4 is the first bad version. 

 */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        return FirstBadVersion(1,n);
    }
    private int FirstBadVersion(int start, int end)
    {
    	if(start<=end)
    	{
    		if(start==end)
    		{
    			return start;
    		}
    		int mid = (start + ((end-start)/2));
    		if(base.IsBadVersion(mid))
    		{
    			return FirstBadVersion(start,mid);
    		}
    		else
    		{
    			return FirstBadVersion(mid+1,end);
    		}
    	}
    	else
    	{
    		return -1;
    	}
    }
}