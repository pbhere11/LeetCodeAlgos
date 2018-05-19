/* The isBadVersion API is defined in the parent class VersionControl.
      boolean isBadVersion(int version); 

1 2 3 4 5

      */

public class Solution extends VersionControl {
    public int firstBadVersion(int n) {
        return firstBadVersion(1,n);
    }
    private int firstBadVersion(int start, int end)
    {
    	if(start==end)
    	{
    		return start;
    	}
    	int mid = (start + ((end-start)/2));
    	if(!isBadVersion(mid))
    	{
    		return firstBadVersion(mid+1,end);
    	}
    	else
    	{
    		return firstBadVersion(start,mid);
    	}
    }
}