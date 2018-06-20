
public class Main {
    public static void main(String[] args) {
        int[][] matrix = new int[][]{
        	{1,2,3},
        	{4,5,6},
        	{7,8,9}
        };
        int target = 38;
        Main mn = new Main();
        System.out.println("main matrix");
        for(int i=0;i<matrix.length;i++)
        {
        	for(int j=0;j<matrix[i].length;j++)
        	{
        		System.out.print(matrix[i][j]+" ");
        	}
        	System.out.println();
        }
        System.out.println();
        System.out.println("returned matrix");
        int[][] result = mn.findMatrixPath(matrix,target);
        for(int i=0;i<result.length;i++)
        {
        	for(int j=0;j<result[i].length;j++)
        	{
        		System.out.print(result[i][j]+" ");
        	}
        	System.out.println();
        }
    }

    private int[][] findMatrixPath(int[][] matrix, int target)
    {
    	int[][] returnMatrix = new int[matrix.length][matrix.length];
    	for(int i=0;i<matrix.length; i++)
    	{
    		for(int j=0;j<matrix[i].length;j++)
    		{
    			returnMatrix[i][j] = 0;
    		}
    	}
    	int[][] result = bfs(matrix,0,0,0,target,returnMatrix);
    	return result;
    }
    private int[][] bfs(int[][] matrix, int i, int j, int sum, int target, int[][] returnMatrix)
    {
    	if(i<0||i>=matrix.length||j<0||j>=matrix.length)
    	{
    		return null;
    	}
    	sum = sum+matrix[i][j];
    	if(returnMatrix[i][j]!=1 && sum == target)
    	{
    		returnMatrix[i][j]=1;
    		return returnMatrix;
    	}
    	else if(returnMatrix[i][j]!=1 && sum<target)
    	{
    		returnMatrix[i][j]=1;
    		int[][] ogMatrix = new int[returnMatrix.length][returnMatrix.length];
    		for(int x=0;x<ogMatrix.length; x++)
	    	{
	    		for(int y=0;y<ogMatrix[i].length;y++)
	    		{
	    			ogMatrix[x][y] = returnMatrix[x][y];
	    		}
	    	}
    		int[][] top = bfs(matrix,i-1,j,sum,target,returnMatrix);
    		if(top!=null)
    		{
    			return top;
    		}
    		resetMatrix(ogMatrix,returnMatrix);
    		int[][] bottom = bfs(matrix,i+1,j,sum,target,returnMatrix);
    		if(bottom!=null)
    		{
    			return bottom;
    		}
    		resetMatrix(ogMatrix,returnMatrix);
    		int[][] left = bfs(matrix,i,j-1,sum,target,returnMatrix);
    		if(left!=null)
    		{
    			return left;
    		}
    		resetMatrix(ogMatrix,returnMatrix);
    		int[][] right = bfs(matrix,i,j+1,sum,target,returnMatrix);
    		if(right!=null)
    		{
    			return right;
    		}
    		resetMatrix(ogMatrix,returnMatrix);
    		return null;
    	}
    	else
    	{
    		return null;
    	}
    }
    private void resetMatrix(int[][] ogMatrix, int[][] returnMatrix)
    {
    	for(int x=0;x<ogMatrix.length; x++)
	    	{
	    		for(int y=0;y<ogMatrix[x].length;y++)
	    		{
	    			returnMatrix[x][y] = ogMatrix[x][y];
	    		}
	    	}
    }
}