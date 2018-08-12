/*
Example 1:

Input: 
[
  [1,1,1],
  [1,0,1],
  [1,1,1]
]
Output: 
[
  [1,0,1],
  [0,0,0],
  [1,0,1]
]
Example 2:

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
public class Solution {
    public void SetZeroes(int[,] matrix) {
        bool firstRowHasZero = false;
        bool firstColumnHasZero = false;
        for(int i=0;i<matrix.GetLength(0);i++)
        {
        	if(matrix[i,0]==0)
        	{
        		firstColumnHasZero = true;
        		break;
        	}
        }

        for(int j=0;j<matrix.GetLength(1);j++)
        {
        	if(matrix[0,j]==0)
        	{
        		firstRowHasZero = true;
        		break;
        	}
        }

        for(int i=1;i<matrix.GetLength(0);i++)
        {
        	for(int j=1;j<matrix.GetLength(1);j++)
        	{
        		if(matrix[i,j]==0)
        		{
        			matrix[i,0] = 0;
        			matrix[0,j] = 0;
        		}
        	}
        }

        for(int i=1;i<matrix.GetLength(0);i++)
        {
        	for(int j=1;j<matrix.GetLength(1);j++)
        	{
        		if(matrix[i,0]==0||matrix[0,j]==0)
        		{
        			matrix[i,j] = 0;
        		}
        	}
        }

        if(firstColumnHasZero)
        {
        	for(int i=0;i<matrix.GetLength(0);i++)
	        {
	        	matrix[i,0] = 0;
	        }
        }
        if(firstRowHasZero)
        {
        	for(int i=0;i<matrix.GetLength(1);i++)
        	{
        		matrix[0,i] = 0;
        	}
        }
    }
}