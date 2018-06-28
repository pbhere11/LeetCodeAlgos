/*
Example 1:

Input:
11110
11010
11000
00000

Output: 1
Example 2:

Input:
11000
11000
00100
00011

Output: 3
*/
public class Solution {
    public int NumIslands(char[,] grid) {
    	int count = 0;
        for(int i=0;i<grid.GetLength(0);i++)
        {
        	for(int j=0;j<grid.GetLength(1);j++)
        	{
        		if(grid[i,j]=='1')
        		{
        			count++;
        			dfs(grid,i,j);
        		}
        	}
        }
        return count;
    }

    private void dfs(char[,] grid, int i, int j)
    {
    	if(i>=0 && i<grid.GetLength(0) && j>=0 && j<grid.GetLength(1) && grid[i,j]=='1')
    	{
    		grid[i,j] = '0';
    		dfs(grid,i-1,j);
    		dfs(grid,i+1,j);
    		dfs(grid,i,j-1);
    		dfs(grid,i,j+1);
    	}
    	
    }
}