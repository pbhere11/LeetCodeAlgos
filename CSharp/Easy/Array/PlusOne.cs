/*
Example 1:

Input: [1,2,3]
Output: [1,2,4]
Explanation: The array represents the integer 123.
Example 2:

Input: [4,3,2,1]
Output: [4,3,2,2]
Explanation: The array represents the integer 4321.
*/

public class Solution {
    public int[] PlusOne(int[] digits) {
        int[] result = new int[digits.Length];
        int carry =1;
        for(int i=digits.Length-1;i>=0;i--)
        {
        	int sum = digits[i]+carry;
        	if(sum>=10)
        	{
        		result[i] = sum%10;
        		carry = 1;
        	}
        	else
        	{
        		result[i] = sum;
        		carry = 0;
        	}
        }
        if(carry==0)
        {
        	return result;
        }
        else
        {
        	int[] resultNew = new int[result.Length+1];
        	resultNew[0] = 1;
        	for(int i=0;i<result.Length;i++)
        	{
        		resultNew[i+1] = result[i]; 
        	}
        	return resultNew;
        }
        
    }
}