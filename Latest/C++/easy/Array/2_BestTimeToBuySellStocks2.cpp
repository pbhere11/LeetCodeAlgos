#include <vector>
#include <iostream>

using namespace std;

class Solution {
public:
    int maxProfit(vector<int>& prices) {
        if(prices.size()==0) return 0;
        int min = prices[0];
        int max = prices[0];
        int profit = 0;

        for(int i=1;i<prices.size();i++) {
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
};

/*
Example 1:

Input: [7,1,5,3,6,4]
Output: 7
Explanation: Buy on day 2 (price = 1) and sell on day 3 (price = 5), profit = 5-1 = 4.
             Then buy on day 4 (price = 3) and sell on day 5 (price = 6), profit = 6-3 = 3.
Example 2:

Input: [1,2,3,4,5]
Output: 4
Explanation: Buy on day 1 (price = 1) and sell on day 5 (price = 5), profit = 5-1 = 4.
             Note that you cannot buy on day 1, buy on day 2 and sell them later, as you are
             engaging multiple transactions at the same time. You must sell before buying again.
Example 3:

Input: [7,6,4,3,1]
Output: 0
Explanation: In this case, no transaction is done, i.e. max profit = 0.
*/

int main() {
    // vector<int> nums {7,1,5,3,6,4};
    vector<int> nums {1,2,3,4,5};
    Solution sln;
    int profit = sln.maxProfit(nums);
    cout<<profit<<" "<<endl;
}