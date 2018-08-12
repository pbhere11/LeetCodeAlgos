/*
Example 1:

Input: 11
Output: 3
Explanation: Integer 11 has binary representation 00000000000000000000000000001011 
Example 2:

Input: 128
Output: 1
Explanation: Integer 128 has binary representation 00000000000000000000000010000000
*/
public class Solution {
    public int HammingWeight(uint n) {
        int count =0;
        while(n!=0)
        {	
        	if(n%2==1)
        	{
        		count++;
        	}
        	n = n/2;
        }
        return count;
    }
}