/*
Example 1:

Input: 3
Output: 0
Explanation: 3! = 6, no trailing zero.
Example 2:

Input: 5
Output: 1
Explanation: 5! = 120, one trailing zero.
*/
public class Solution {
    public int TrailingZeroes(int n) {
        if (n < 0)
		return -1;
 
        long count = 0;
        for (long i = 5; n / i >= 1; i *= 5) {
            count += n / i;
        }

        return (int)count;
    }
}