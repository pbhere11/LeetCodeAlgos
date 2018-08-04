/*
Example 1:

Input:
s = "aa"
p = "a"
Output: false
Explanation: "a" does not match the entire string "aa".
Example 2:

Input:
s = "aa"
p = "a*"
Output: true
Explanation: '*' means zero or more of the precedeng element, 'a'. Therefore, by repeating 'a' once, it becomes "aa".
Example 3:

Input:
s = "ab"
p = ".*"
Output: true
Explanation: ".*" means "zero or more (*) of any character (.)".
Example 4:

Input:
s = "aab"
p = "c*a*b"
Output: true
Explanation: c can be repeated 0 times, a can be repeated 1 time. Therefore it matches "aab".
Example 5:

Input:
s = "mississippi"
p = "mis*is*p*."
Output: false
  # a
# 1 0
a 0 1
a 0 0
*/
public class Solution {
    public bool IsMatch(string s, string p) {
        char[] text = new char[s.Length+1];
        char[] ptrn = new char[p.Length+1];
        text[0] = '#';
        ptrn[0] = '#';
        for(int i=1;i<text.Length;i++)
        {
        	text[i] = s[i-1];
        }
        for(int i=1;i<ptrn.Length;i++)
        {
        	ptrn[i] = p[i-1];
        }
        bool[,] matrix = new bool[text.Length,ptrn.Length];
        matrix[0,0] = true;
        for(int i=1;i<matrix.GetLength(0);i++)
        {
        	matrix[i,0] = false;
        }
     	for(int i=1;i<matrix.GetLength(1);i++)
        {
        	if(ptrn[i]=='*')
        	{
        		matrix[0,i] = matrix[0,i-2];
        	}
        	else
        	{
        		matrix[0,i] = false;
        	}
        }

        for(int i=1;i<matrix.GetLength(0);i++)
        {
        	for(int j=1;j<matrix.GetLength(1);j++)
        	{
        		if(ptrn[j]=='.'||ptrn[j]==text[i])
        		{
        			matrix[i,j] = matrix[i-1,j-1];
        		}
        		else if(ptrn[j] =='*')
        		{
        			matrix[i,j] = matrix[i,j-2];
        			if(ptrn[j-1]=='.'||ptrn[j-1]==text[i])
        			{
        				matrix[i,j] = matrix[i,j]||matrix[i-1,j];
        			}
        		}
        		else
        		{
        			matrix[i,j] = false;
        		}
        	}
        }    
        PrintMatrix(matrix);    
        return matrix[text.Length-1,ptrn.Length-1];
    }
    private void PrintMatrix(bool[,] matrix)
    {
    	for(int i=0;i<matrix.GetLength(0);i++)
    	{
    		for(int j=0;j<matrix.GetLength(1);j++)
    		{
    			System.Console.Write(matrix[i,j]+",");
    		}
    		System.Console.WriteLine();
    	}
    }
}