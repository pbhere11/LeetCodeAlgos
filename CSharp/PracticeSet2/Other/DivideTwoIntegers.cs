/*
Example 1:

Input: dividend = 10, divisor = 3
Output: 3
Example 2:

Input: dividend = 7, divisor = -3
Output: -2
*/
public class Solution {
    public int Divide(int dividend, int divisor) {
        if(divisor==0) return int.MaxValue;
        if(dividend==0) return 0;
        if(divisor==-1 && dividend==int.MinValue)
        {
        	return int.MaxValue;
        }
        int result =0;
        long tempDividend = Math.Abs((long)dividend);
        long tempDivisor = Math.Abs((long)divisor);
        while(tempDividend>=tempDivisor)
        {
        	int numShift =0;
        	while(tempDividend>=(tempDivisor<<numShift))
        	{
        		numShift++;
        	}
        	result+= 1<<(numShift-1);
        	tempDividend-= tempDivisor<<(numShift-1);
        }
        if(dividend<0&&divisor>0 || dividend>0&&divisor<0)
        {
        	if(result==int.MaxValue)
        	{
        		return int.MinValue;
        	}
        	return -result;
        }
        else
        {
        	return result;
        }
    }
    private long GetAbs(int num)
    {
    	if(num<0)
    	{
    		if(num==int.MinValue)
    		{
    			return int.MaxValue;
    		}
    		return -num;
    	}
    	return num;
    }
}