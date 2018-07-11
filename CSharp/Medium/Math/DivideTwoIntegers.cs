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
    	int sign =1;
    	if(divisor<0)
    	{
    		sign = sign*-1;
    		divisor =  divisor*-1;
    	}
    	if(dividend<0)
    	{
    		sign = sign*-1;
    		if(dividend==int.MinValue)
            {
                dividend = int.MaxValue;
            }
            else
            {
            	dividend =  dividend*-1;
            }
    		
    	}
    	if(divisor==1)
    	{
    		if(dividend==int.MaxValue)
    		{
    			if(sign<0)
    			{
    				return int.MinValue;
    			}
    			else
    			{
    				return int.MaxValue;
    			}
    		}
    		return dividend*sign;
    	}
        int count =0;
        while(dividend>=divisor)
        {
        	count++;
        	dividend = dividend-divisor;
        }
        return count*sign;
    }
}