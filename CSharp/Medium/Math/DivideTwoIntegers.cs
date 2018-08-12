/*
Example 1:

Input: dividend = 10, divisor = 3
Output: 3
Example 2:

Input: dividend = 7, divisor = -3
Output: -2
Note:

Both dividend and divisor will be 32-bit signed integers.
The divisor will never be 0.
Assume we are dealing with an environment which could only store integers within the 32-bit signed integer range: [−231,  231 − 1]. For the purpose of this problem, assume that your function returns 231 − 1 when the division result overflows.

*/
public class Solution {
    public int Divide(int dividend, int divisor) {
        int sign =1;
        if(dividend==0)
        {
            return 0;
        }
        if(divisor == 0 )
        {
            return int.MaxValue;
        }
        if(dividend<0)
        {
            sign*=-1;
            if(dividend==int.MinValue)
            {
                dividend = int.MaxValue;
            }
            else
            {
                dividend*=-1;
            }
        }
        if(divisor<0)
        {
            sign*=-1;
            if(divisor==int.MinValue)
            {
                divisor = int.MaxValue;
            }
            else
            {
                divisor*=-1;
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
            else
            {
                return dividend*sign;
            }
        }
        int count =0;
        while(dividend>=divisor)
        {
            count++;
            dividend-=divisor;
        }
        return count*sign;
    }
}