/*
Example 1:

Input: 4
Output: 2
Example 2:

Input: 8
Output: 2
Explanation: The square root of 8 is 2.82842..., and since 
             the decimal part is truncated, 2 is returned.
*/

public class Solution {
    public int MySqrt(int x) {
        if(x==0||x==1)
        {
        	return x;
        }
        int start =1;
        int end = x;
        int ans = 1;
        while(start<=end)
        {
        	int mid = (start+end)/2;
        	if(mid*mid == x)
        	{
        		return mid;
        	}
        	if(mid*mid<x)
        	{
        		start = mid+1;
        		ans = mid;
        	}
        	else
        	{
        		end = mid-1;
        	}
        }
        return ans;
    }
}