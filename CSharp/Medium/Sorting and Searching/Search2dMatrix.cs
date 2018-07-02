/*
Example:

Consider the following matrix:

[
  [1,   4,  7, 11, 15],
  [2,   5,  8, 12, 19],
  [3,   6,  9, 16, 22],
  [10, 13, 14, 17, 24],
  [18, 21, 23, 26, 30]
]
Given target = 5, return true.

Given target = 20, return false.
*/
public class Solution {
    public bool SearchMatrix(int[,] matrix, int target) {
        int row = 0;
        int column = matrix.GetLength(1)-1;

        while(row<matrix.GetLength(0) && column>=0)
        {
        	if(matrix[row,column]==target)
        	{
        		return true;
        	}
        	if(target<matrix[row,column])
        	{
        		column--;
        	}
        	else
        	{
        		row++;
        	}
        }
        return false;
    }
}