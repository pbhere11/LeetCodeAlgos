
/*
/*
Example 1:

Input: 2,0.1
Output: 1.41
Example 2:

Input: 8
Output: 2
Explanation: The square root of 8 is 2.82842..., and since 
             the decimal part is truncated, 2 is returned.
*/
*/
class Solution{
	 public double MySqrt(double x,double p)
        {
            if (x == 0 || x == 1)
            {
                return x;
            }
            double start = 0;
            double end = x;
            double ans = start;
            while (start <= end)
            {
                double mid = (start + end) / 2;
                if (mid * mid == x)
                {
                    return mid;
                }
                if (mid * mid < x)
                {
                    start = mid+p;
                    ans = mid;
                }
                else
                {
                    end = mid - p;
                }
            }
            return ans;
        }
}