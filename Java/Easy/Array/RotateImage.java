/*
  [1,2,3],
  [4,5,6],
  [7,8,9]
  
   [7,4,1],
  [8,5,2],
  [9,6,3]


  [ 5, 1, 9,11],
  [ 2, 4, 8,10],
  [13, 3, 6, 7],
  [15,14,12,16]

   [15,13, 2, 5],
  [14, 3, 4, 1],
  [12, 6, 8, 9],
  [16, 7,10,11]
*/
class Solution {
    public void rotate(int[][] matrix) {
       for(int i=0;i<matrix.length/2;i++)
       {
          for(int j=i;j<matrix[i].length-1-i;j++)
          {
              
              // saving the temp
              int temp = matrix[i][j];

              //left to top
              matrix[i][j] = matrix[matrix.length-1-j][i];

              //bottom to left
              matrix[matrix.length-1-j][i] = matrix[matrix.length-1-i][matrix.length-1-j];

              //right to bottom
              matrix[matrix.length-1-i][matrix.length-1-j] = matrix[j][matrix[i].length-1-i];

              //top to right
              matrix[j][matrix[i].length-1-i] =temp;
          }
       }
    }
}