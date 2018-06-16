/*
1.8 Zero Matrix: Write an algorithm such that if an element in an MxN matrix is 0, its entire row and
column are set to O.
Hints: # 17, #74, #102
*/

// "static void main" must be defined in a public class.
public class Main {
    public static void main(String[] args) {
        int[][] matrix = new int[][]{{0,2,3},{4,5,6},{7,8,9}};
        Main mn = new Main();
        mn.printMatrix(matrix);
        System.out.println();
        mn.zeroMatrixify(matrix);
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

    public void zeroMatrixify(int[][] matrix)
    {
    	boolean firstColumnHasZero = false;
    	for(int i=0;i<matrix.length;i++)
    	{
    		if(matrix[i][0]==0)
    		{
    			firstColumnHasZero = true;
    			break;
    		}
    	}
    	boolean firstRowHasZero = false;
    	for(int i=0;i<matrix.length;i++)
    	{
    		if(matrix[0][i]==0)
    		{
    			firstRowHasZero = true;
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
    				matrix[0][j] =0;
    			}
    		}
    	}

    	for(int i=1;i<matrix.length;i++)
    	{
    		for(int j=1;j<matrix[i].length;j++)
    		{
    			if(matrix[i][0]==0||matrix[0][j]==0)
    			{
    				matrix[i][j]=0;
    			}
    		}
    	}

    	if(firstColumnHasZero)
    	{
    		for(int i=0;i<matrix.length;i++)
    		{
    			matrix[i][0] =0;
    		}
    	}

    	if(firstRowHasZero)
    	{
    		for(int i=0;i<matrix.length;i++)
    		{
    			matrix[0][i] =0;
    		}
    	}
    }
}