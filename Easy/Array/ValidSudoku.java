class Solution {
    public boolean isValidSudoku(char[][] board) {
     	boolean[][] rows = new boolean[9][9];
     	boolean[][] cols = new boolean[9][9];
     	boolean[][] square = new boolean[9][9];

     	for(int i=0;i<board.length;i++)
     	{
     		for(int j=0;j<board[i].length;j++)
     		{
     			//find rows
     			if(board[i][j]!='.')
     			{
     				if(rows[i][(int)board[i][j]-'1'])
     				{
     					return false;
     				}
     				else
     				{
     					rows[i][(int)board[i][j]-'1'] = true;
     				}
     			}

     			//find columns
     			if(board[i][j]!='.')
     			{
     				if(cols[j][(int)board[i][j]-'1'])
     				{
     					return false;
     				}
     				else
     				{
     					cols[j][(int)board[i][j]-'1'] = true;
     				}
     			}

     			//find sqaures
     			if(board[i][j]!='.')
     			{
     				if(square[i/3*3 + j/3][(int)board[i][j]-'1'])
     				{
     					return false;
     				}
     				else
     				{
     					square[i/3*3 + j/3][(int)board[i][j]-'1'] = true;
     				}
     			}
     		}
     	}
     	return true;

    }
}