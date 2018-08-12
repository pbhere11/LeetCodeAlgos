/*
1.7 Rotate Matrix: Given an image represented by an NxN matrix, where each pixel in the image is 4
bytes, write a method to rotate the image by 90 degrees. (an you do this in place?
Hints: #51, #100
*/

class Program {
    static void Main() {
        Program p = new Program();
        int[][] matrix = {new int[] {1,2,3},new int[] {4,5,6}, new int[]{7,8,9}};
        p.printMatrix(matrix);
        p.RotateMatrix(matrix);
        p.printMatrix(matrix);
    }

    private void printMatrix(int[,] matrix)
    {
    	for(int i=0;i<matrix.Length;i++)
    	{
    		for(int j=0;j<matrix[i].Length;j++)
    		{
    			System.Console.Write(matrix[i][j]+" ");
    		}
    		System.Console.WriteLine();
    	}
    }

    public void RotateMatrix(int[,] matrix)
    {
    	for(int i=0;i<matrix.Length/2;i++)
    	{
    		for(int j=i;j<matrix.Length-1-i;j++)
    		{
    			/*
					0 1 2
				  0	1 2 3
				  1	4 5 6
				  2	7 8 9
    			*/
				  //save top 
				  int temp = matrix[i][j];
				  //left to top
				  matrix[i][j] = matrix[matrix.Length-1-j][i];
				  //bottom to left
				  matrix[matrix.Length-1-j][i] = matrix[matrix.Length-1-i][matrix.Length-1-j];
				  //right to bottom
				  matrix[matrix.Length-1-i][matrix.Length-1-j] = matrix[j][matrix.Length-1-i];
				  //top to right
				  matrix[j][matrix.Length-1-i] = temp;
    		}
    	}
    }
}