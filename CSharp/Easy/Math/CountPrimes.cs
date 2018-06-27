/*
Count the number of prime numbers less than a non-negative number, n.
Example:

Input: 10
Output: 4
Explanation: There are 4 prime numbers less than 10, they are 2, 3, 5, 7.
*/

public class Solution {
    public int CountPrimes(int n) {
        bool[] prime = new bool[n];
        if(n<=2)
        {
        	return 0;
        }
        prime[0] = false;
        prime[1]=false;
        prime[2] = true;
        for(int i=3;i<n;i++)
        {
        	prime[i] = true;
        }
        for(int i=2;i*i<n;i++)
        {
        	if(prime[i])
        	{
        		int j = i*2;
        		while(j<n)
        		{
        			prime[j] = false;
        			j = j+i;
        		}
        	}
        }
        int count =0;
        for(int i=1;i<n;i++)
        {
        	if(prime[i])
        	{
        		count++;
        	}
        }
        return count;
    }
}