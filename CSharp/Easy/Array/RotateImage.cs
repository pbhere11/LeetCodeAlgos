/*
Example 1:

Given input matrix = 
[
  [1,2,3],
  [4,5,6],
  [7,8,9]
],

rotate the input matrix in-place such that it becomes:
[
  [7,4,1],
  [8,5,2],
  [9,6,3]
]
Example 2:

Given input matrix =
[
  [ 5, 1, 9,11],
  [ 2, 4, 8,10],
  [13, 3, 6, 7],
  [15,14,12,16]
], 

rotate the input matrix in-place such that it becomes:
[
  [15,13, 2, 5],
  [14, 3, 4, 1],
  [12, 6, 8, 9],
  [16, 7,10,11]
]
*/

public class Solution {
    public void Rotate(int[,] matrix) {
        for(int i=0;i<matrix.GetLength(0)/2;i++)
        {
            for(int j=i;j<matrix.GetLength(1)-1-i;j++)
            {
                //savin the top element
                int temp = matrix[i,j];
                //left to top
                matrix[i,j] = matrix[matrix.GetLength(0)-1-j,i];
                //bottom to top
                matrix[matrix.GetLength(0)-1-j,i] = matrix[matrix.GetLength(0)-1-i,matrix.GetLength(1)-1-j];
                //right to bottom
                matrix[matrix.GetLength(0)-1-i,matrix.GetLength(1)-1-j] = matrix[j,matrix.GetLength(1)-1-i];
                //top to right
                matrix[j,matrix.GetLength(1)-1-i] = temp;
            }
        }
    }
}