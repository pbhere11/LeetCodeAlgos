/*
Example 1:

Input:
[
  ["5","3",".",".","7",".",".",".","."],
  ["6",".",".","1","9","5",".",".","."],
  [".","9","8",".",".",".",".","6","."],
  ["8",".",".",".","6",".",".",".","3"],
  ["4",".",".","8",".","3",".",".","1"],
  ["7",".",".",".","2",".",".",".","6"],
  [".","6",".",".",".",".","2","8","."],
  [".",".",".","4","1","9",".",".","5"],
  [".",".",".",".","8",".",".","7","9"]
]
Output: true
Example 2:

Input:
[
  ["8","3",".",".","7",".",".",".","."],
  ["6",".",".","1","9","5",".",".","."],
  [".","9","8",".",".",".",".","6","."],
  ["8",".",".",".","6",".",".",".","3"],
  ["4",".",".","8",".","3",".",".","1"],
  ["7",".",".",".","2",".",".",".","6"],
  [".","6",".",".",".",".","2","8","."],
  [".",".",".","4","1","9",".",".","5"],
  [".",".",".",".","8",".",".","7","9"]
]
Output: false
Explanation: Same as Example 1, except with the 5 in the top left corner being 
    modified to 8. Since there are two 8's in the top left 3x3 sub-box, it is invalid.
*/
    public class Solution {
    public bool IsValidSudoku(char[,] board) {
        bool[,] row = new bool[9,9];
        bool[,] column = new bool[9,9];
        bool[,] square = new bool[9,9];

        
        for(int i=0;i<9;i++)
        {
            for(int j=0;j<9;j++)
            {
                //check rows
                if(board[i,j]!='.')
                {
                   if(row[i,(int)board[i,j]-'1'])
                   {
                      return false;
                   }
                   else
                   {
                      row[i,(int)board[i,j]-'1'] = true;
                   }
                }
                //check columns
                if(board[i,j]!='.')
                {
                   if(column[j,(int)board[i,j]-'1'])
                   {
                      return false;
                   }
                   else
                   {
                      column[j,(int)board[i,j]-'1'] = true;
                   }
                }
                //check squares
                if(board[i,j]!='.')
                {
                   if(square[i/3*3 + j/3,(int)board[i,j]-'1'])
                   {
                      return false;
                   }
                   else
                   {
                      square[i/3*3 + j/3,(int)board[i,j]-'1'] = true;
                   }
                }
            }
        }
        return true;
    }
}