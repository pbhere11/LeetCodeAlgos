/*
board =
[
  ['A','B','C','E'],
  ['S','F','C','S'],
  ['A','D','E','E']
]

Given word = "ABCCED", return true.
Given word = "SEE", return true.
Given word = "ABCB", return false.
*/
class Solution {
    public boolean exist(char[][] board, String word) {
    	char[][] ogboard = board;
        for(int i=0;i<board.length;i++)
        {
        	for(int j=0;j<board[i].length;j++)
        	{
        		if(exist(board,word,0,i,j))
				{
					return true;
				}
				board = ogboard;
        	}
        }
        return false;
    }

    private boolean exist(char[][] board, String word, int wordIndex, int i, int j)
    {
    	if(i>=0 && i<board.length && j>=0 && j<board[i].length && board[i][j]!= '0' && wordIndex<word.length() && word.charAt(wordIndex)==board[i][j])
    	{
    		if(wordIndex==word.length()-1)
    		{
    			return true;
    		}
    		board[i][j] = '0';
    		boolean top = exist(board,word,wordIndex+1,i-1,j);
    		boolean bottom = exist(board,word,wordIndex+1,i+1,j);
    		boolean left = exist(board,word,wordIndex+1,i,j-1);
    		boolean right = exist(board,word,wordIndex+1,i,j+1);
    		if(top||bottom||left||right)
    		{
    			return true;
    		}
    	}
    	return false;
    }
}