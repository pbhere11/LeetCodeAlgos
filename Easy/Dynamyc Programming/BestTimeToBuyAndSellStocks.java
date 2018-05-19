/*
Input: [7,1,5,3,6,4]
Output: 5
*/
class Solution {
    public int maxProfit(int[] prices) {
    	if(prices.length ==0 || prices.length ==1)
    	{
    		return 0;
    	}
        int currentSmallest = prices[0];
        int currentHighest = prices[0];
        int currentProfit = 0;

        for(int i=1;i<prices.length;i++)
        {
        	if(prices[i]<currentSmallest)
        	{
        		currentSmallest = prices[i];
        		currentHighest = prices[i];
        	}
        	else if(prices[i]>currentHighest)
        	{
        		currentHighest = prices[i];
        		currentProfit = Math.max(currentProfit,currentHighest-currentSmallest);
        	}
        }
        return currentProfit;
    }
}