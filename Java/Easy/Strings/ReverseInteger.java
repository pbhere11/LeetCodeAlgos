/*
Input: 123
Output: 321
Input: 10
Output: 01
Input: 1
Output: 1
*/
class Solution {
    public int reverse(int x) {
        int result = 0;
        while(x!=0)
        {
        	int temp = x%10;//1
        	result = 10*result + temp;//320 + 1
        	x = x/10;//1
        }
        return result;
    }
}