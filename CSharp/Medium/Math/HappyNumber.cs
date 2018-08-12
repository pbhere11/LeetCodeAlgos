/*
Example: 

Input: 19
Output: true
Explanation: 
12 + 92 = 82
82 + 22 = 68
62 + 82 = 100
12 + 02 + 02 = 1
*/
public class Solution {
    public bool IsHappy(int n) {
        
        HashSet<int> set = new HashSet<int>();

        while(!set.Contains(n))
        {
        	set.Add(n);
        	int sum = GetSum(n);
        	if(sum ==1)
        	{
        		return true;
        	}
        	n = sum;
        }
        return false;
    }

    private int GetSum(int n)
    {
    	int sum =0;
    	while(n!=0)
    	{
    		int digit = n%10;
    		sum = sum + (digit * digit);
    		n = n/10;
    	}
    	return sum;
    }
}