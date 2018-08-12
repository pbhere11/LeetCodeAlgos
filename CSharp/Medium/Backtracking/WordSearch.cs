/*
Example:

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
public class Solution {
    public bool Exist(char[,] board, string word) {
    	for(int i=0;i<board.GetLength(0);i++)
    	{
    		for(int j=0;j<board.GetLength(1);j++)
    		{
    			if(Exist(board,i,j,word,0))
    			{
    				return true;
    			}
    		}
    	}  
    	return false;
    }

    private bool Exist(char[,] board, int i, int j, string word, int wIndex)
    {
    	if(wIndex<=word.Length && i>=0 && i<board.GetLength(0) && j>=0 && j<board.GetLength(1) && board[i,j]==word[wIndex])
    	{

    		if(wIndex==word.Length-1)
    		{
    			return true;
    		}
    		char c = board[i,j];
    		board[i,j] = '#';
    		bool left = Exist(board,i-1,j,word,wIndex+1);
    		if(left)
    		{
    			return true;
    		}
    		bool right = Exist(board,i+1,j,word,wIndex+1);
    		if(right)
    		{
    			return true;
    		}
    		bool top = Exist(board,i,j-1,word,wIndex+1);
    		if(top)
    		{
    			return true;
    		}
    		bool bottom = Exist(board,i,j+1,word,wIndex+1);
    		if(bottom)
    		{
    			return true;
    		}
    		board[i,j] = c;
    		return false;
    	}
    	else
    	{
    		return false;
    	}
    }

}