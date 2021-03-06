/*
Example 1:

Input: [7,1,5,3,6,4]
Output: 5
Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
             Not 7-1 = 6, as selling price needs to be larger than buying price.
Example 2:

Input: [7,6,4,3,1]
Output: 0
Explanation: In this case, no transaction is done, i.e. max profit = 0.
*/
public class Solution {
    public int MaxProfit(int[] prices) {
        if(prices.Length==0 || prices.Length==1)
        {
        	return 0;
        }

        int min = prices[0];
        int max = prices[0];
        int maxProfit = max-min;
        for(int i=1;i<prices.Length;i++)
        {
        	if(prices[i]<min)
        	{
        		min = prices[i];
        		max = prices[i];
        	}
        	else if(prices[i]>max)
        	{
        		max = prices[i];
        		maxProfit = Math.Max(maxProfit,max-min);
        	}
        }
        return maxProfit;
    }
}