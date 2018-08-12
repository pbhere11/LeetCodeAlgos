/*
Example 1:

Input: 2.00000, 10
Output: 1024.00000
Example 2:

Input: 2.10000, 3
Output: 9.26100
Example 3:

Input: 2.00000, -2
Output: 0.25000
Explanation: 2-2 = 1/22 = 1/4 = 0.25
*/
public class Solution {
    public double MyPow(double x, int n) {
        if(n==0||x==1)
        {
        	return 1;
        }
        if(x==-1)
        {
        	if(n%2==0)
        	{
        		return 1;
        	}
        	else
        	{
        		return -1;
        	}
        }
        if(n<0)
        {
        	if(n==int.MinValue)
        	{
        		n = int.MaxValue;
        		return 1/MyPow(x,n);
        	}
        	return 1/MyPow(x,(-1)*n);
        }
        double ans = MyPow(x,n/2);
        if(n%2!=0)
        {
        	return ans*ans*x;
        }
        else
        {
        	return ans*ans;
        }
    }
}