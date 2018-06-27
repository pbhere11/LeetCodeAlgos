/*
Note:
0 ≤ x, y < 231.

Example:

Input: x = 1, y = 4

Output: 2

Explanation:
1   (0 0 0 1)
4   (0 1 0 0)
       ↑   ↑

The above arrows point to positions where the corresponding bits are different.
*/

public class Solution {
    public int HammingDistance(int x, int y) {
    	int count =0;
        while(x!=0||y!=0)
        {
        	int left = 0;
        	int right = 0;
        	if(x!=0)
        	{
        		left = x%2;
        		x = x/2;
        	}
        	if(y!=0)
        	{
        		right = y%2;
        		y = y/2;
        	}
        	if(left!=right)
        	{
        		count++;
        	}
        }
        return count;
    }
}