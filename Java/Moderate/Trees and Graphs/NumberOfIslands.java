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
class Solution {
    public int numIslands(char[][] grid) {
    	int numberOfIslands =0;
        for(int i=0;i<grid.length;i++)
        {
        	for(int j=0;j<grid[i].length;j++)
        	{
        		if(grid[i][j]=='1')
        		{
        			numberOfIslands++;
        			dfs(grid,i,j);
        		}
        	}
        }
        return numberOfIslands;
    }
    private void dfs(char[][] grid, int i, int j)
    {
    	if(i>=0&&i<grid.length&&j>=0&&j<grid[i].length&&grid[i][j]=='1')
    	{
    		grid[i][j]='0';
    		dfs(grid,i+1,j);
	    	dfs(grid,i-1,j);
	    	dfs(grid,i,j+1);
	    	dfs(grid,i,j-1);
    	}
    }
}