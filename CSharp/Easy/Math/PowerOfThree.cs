/*
Example 1:

Input: 27
Output: true
Example 2:

Input: 0
Output: false
Example 3:

Input: 9
Output: true
Example 4:

Input: 45
Output: false
*/
public class Solution {
    public bool IsPowerOfThree(int n) {
    	if(n<1)
    	{
    		return false;
    	}
    	while(n%3==0)
    	{
    		n = n/3;
    	}
    	return n==1;
    }
}