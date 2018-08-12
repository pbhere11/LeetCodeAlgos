/*
Input: 
[
  [0,1,2,0],
  [3,4,5,2],
  [1,3,1,5]
]
Output: 
[
  [0,0,0,0],
  [0,4,5,0],
  [0,3,1,0]
]
*/
class Solution {
    public void setZeroes(int[][] matrix) {
    	boolean firstColumnZero = false; 
        // check if first column has 0
        for(int i=0;i<matrix.length;i++)
        {
        	if(matrix[i][0]==0)
        	{
        		firstColumnZero = true;
        		break;
        	}
        }
        boolean firstRowZero = false;
        //check if first row has 0
        for(int i=0;i<matrix[0].length;i++)
        {
        	if(matrix[0][i]==0)
        	{
        		firstRowZero = true;
        		break;
        	}
        }
        for(int i=1;i<matrix.length;i++)
        {
        	for(int j=1;j<matrix[i].length;j++)
        	{
        		if(matrix[i][j]==0)
        		{
        			matrix[i][0] = 0;
        			matrix[0][j] = 0;
        		}
        	}
        }
        for(int i=1;i<matrix.length;i++)
        {
        	for(int j=1;j<matrix[i].length;j++)
        	{
        		if(matrix[i][0]==0 || matrix[0][j]==0)
        		{
        			matrix[i][j] = 0;
        		}
        	}
        }

        if(firstColumnZero)
        {
        	for(int i=0;i<matrix.length;i++)
        	{
        		matrix[i][0]=0;
        	}
        }
        if(firstRowZero)
        {
        	for(int i=0;i<matrix[0].length;i++)
        	{
        		matrix[0][i]=0;
        	}
        }
    }
}