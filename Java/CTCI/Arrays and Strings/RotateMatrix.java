/*
1.7 Rotate Matrix: Given an image represented by an NxN matrix, where each pixel in the image is 4
bytes, write a method to rotate the image by 90 degrees. (an you do this in place?
Hints: #51, #100
  0 1 2
0 1 2 3
1 4 5 6
2 7 8 9
*/

// "static void main" must be defined in a public class.
public class Main {
    public static void main(String[] args) {
        int[][] matrix = new int[][]{{1,2,3},{4,5,6},{7,8,9}};
        Main mn = new Main();
        mn.printMatrix(matrix);
        System.out.println();
        mn.rotateMatrix(matrix);
        mn.printMatrix(matrix);
    }
    public void printMatrix(int[][] matrix)
    {
    	for(int i=0;i<matrix.length;i++)
    	{
    		for(int j=0;j<matrix[i].length;j++)
    		{
    			System.out.print(matrix[i][j]+" ");
    		}
    		System.out.println();
    	}
    }

    public void rotateMatrix(int[][] matrix)
    {
    	for(int i=0;i<matrix.length/2;i++)
    	{
    		for(int j=i;j<matrix.length-1-i;j++)
    		{
    			 //saving the top
    			int temp = matrix[i][j];
    			//left to the top
    			matrix[i][j] = matrix[matrix.length-1-j][i];
    			//bottom to left
    			matrix[matrix.length-1-j][i] = matrix[matrix.length-1-i][matrix.length-1-j];
    			//right to bottom
    			matrix[matrix.length-1-i][matrix.length-1-j] = matrix[j][matrix.length-1-i];
    			//top to right
    			matrix[j][matrix.length-1-i] = temp;

    		}
    	}
    }
}