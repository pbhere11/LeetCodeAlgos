/*
Example 1:

Input: 123
Output: 321
Example 2:

Input: -123
Output: -321
Example 3:

Input: 120
Output: 21
*/
public class Solution {
    public int Reverse(int x) {

        int result = 0;
        while(x!=0)
        {
        	if(result>(Int32.MaxValue/10)||(result==Int32.MaxValue/10 && x%10>1))
        	{
        		return 0;
        	}
        	if(result<(Int32.MinValue/10)||(result==Int32.MinValue/10 && x%10<-1))
        	{
        		return 0;
        	}
        	result = result*10+x%10;
        	x=x/10;
        }
        return result;
    }
}