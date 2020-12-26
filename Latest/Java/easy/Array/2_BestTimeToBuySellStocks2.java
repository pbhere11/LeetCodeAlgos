/*
[7,1,5,3,6,4]
*/
class Solution {
    public int maxProfit(int[] prices) {
        if(prices.length==0) return 0;
        int min = prices[0];
        int max = prices[0];
        int profit = 0;

        for(int i=1;i<prices.length;i++) {
            if(prices[i]<max) {
                profit += (max-min);
                min = prices[i];
                max = prices[i];
            } else {
                max = prices[i];
            }
        }
        profit += (max-min);
        return profit;
    }
}