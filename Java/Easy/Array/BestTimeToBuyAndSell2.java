/*
Input: [7,1,5,3,6,4]
Output: 7
currentSmallest = 7

Input: [1,2,3,4,5]
Output: 4

Input: [7,6,4,3,1]
Output: 0

brute force - n^2
divide and conquere - n(log n)
dynamic programming - greedy algoritham - n
*/
class Solution {
    public int maxProfit(int[] prices) {
        int totalMaxProfit = 0;
        if(prices.length ==0 || prices.length ==1)
        {
        	return totalMaxProfit;
        }
        int currentSmallest = prices[0];//7
        int currentLargest = prices[0];//7
        int currentProfit = 0;//0
        for(int i=1;i<prices.length;i++)
        {
        	if(prices[i]<currentLargest)//4
        	{
        		totalMaxProfit = totalMaxProfit + currentProfit;//0+4+3
        		currentProfit = 0;
        		currentSmallest = prices[i];//4
        		currentLargest = prices[i];//4
        	}
        	else
        	{
        		if(prices[i]-currentSmallest>currentProfit)//3
        		{
        			currentProfit = prices[i]-currentSmallest;//3
        			currentLargest = prices[i];//6
        		}
        	}
        }
        totalMaxProfit = totalMaxProfit+currentProfit;
        return totalMaxProfit;//7
    }
}