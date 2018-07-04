/*
Example 1:

Input: m = 3, n = 2
Output: 3
Explanation:
From the top-left corner, there are a total of 3 ways to reach the bottom-right corner:
1. Right -> Right -> Down
2. Right -> Down -> Right
3. Down -> Right -> Right
Example 2:

Input: m = 7, n = 3
Output: 28
*/
public class Solution {
    public int UniquePaths(int m, int n) {
        int[,] matrix = new int[m,n];
        for(int i=0;i<m;i++)
        {
        	matrix[i,0] = 1;
        }
        for(int i=0;i<n;i++)
        {
        	matrix[0,i] = 1;
        }

        for(int i=1;i<m;i++)
        {
        	for(int j=1;j<n;j++)
        	{
        		matrix[i,j] = matrix[i-1,j]+matrix[i,j-1];
        	}
        }
        
    }
}