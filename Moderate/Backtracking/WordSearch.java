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

[
["C","A","A"],
["A","A","A"],
["B","C","D"]
]
AAB

[
["A","B","C","E"],
["S","F","E","S"],
["A","D","E","E"]
]
ABCESEEEFS
*/
class Solution {
    public boolean exist(char[][] board, String word) {
    	char[][] ogboard = new char[board.length][board[0].length];
        for(int i=0;i<board.length;i++)
        {
            for(int j=0;j<board[i].length;j++)
            {
                ogboard[i][j]=board[i][j];
            }
        }
        for(int i=0;i<board.length;i++)
        {
        	for(int j=0;j<board[i].length;j++)
        	{
        		if(exist(board,word,0,i,j))
				{
					return true;
				}
				for(int x=0;x<board.length;x++)
                {
                    for(int y=0;y<board[i].length;y++)
                    {
                        board[x][y]=ogboard[x][y];
                    }
                }
        	}
        }
        return false;
    }

    private boolean exist(char[][] board, String word, int wordIndex, int i, int j)
    {
    	if(i>=0 && i<board.length && j>=0 && j<board[i].length && board[i][j]!= '#' && wordIndex<word.length() 
            && word.charAt(wordIndex)==board[i][j])
    	{
    		if(wordIndex==word.length()-1)
    		{
    			return true;
    		}
            char c = board[i][j];
    		board[i][j] = '#';
    		boolean top = exist(board,word,wordIndex+1,i-1,j);
    		boolean bottom = exist(board,word,wordIndex+1,i+1,j);
    		boolean left = exist(board,word,wordIndex+1,i,j-1);
    		boolean right = exist(board,word,wordIndex+1,i,j+1);
    		if(top||bottom||left||right)
    		{
    			return true;
    		}
            else
            {
                board[i][j] = c;
            }
    	}
    	return false;
    }
}