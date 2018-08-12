/*
Example:

Input:

A = [
  [ 1, 0, 0],
  [-1, 0, 3]
]

B = [
  [ 7, 0, 0 ],
  [ 0, 0, 0 ],
  [ 0, 0, 1 ]
]

Output:

     |  1 0 0 |   | 7 0 0 |   |  7 0 0 |
AB = | -1 0 3 | x | 0 0 0 | = | -7 0 3 |
                  | 0 0 1 |
*/
public class Solution {
    public int[,] Multiply(int[,] A, int[,] B) {
        int[,] result = new int[A.GetLength(0),B.GetLength(1)];
        for(int i=0;i<result.GetLength(0);i++)
        {
        	for(int k =0;k<A.GetLength(1);k++)
        	{
        		if(A[i,k]!=0)
        		{
        			for(int j=0;j<result.GetLength(1);j++)
	        		{
	        			result[i,j]+= A[i,k]*B[k,j];
	        		}
        		}
        	}
        }
        return result;
    }
}