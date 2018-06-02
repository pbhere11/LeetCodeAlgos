/*
Example 1:

Input: "babad"
Output: "bab"
Note: "aba" is also a valid answer.
Example 2:

Input: "cbbd"
Output: "bb"
*/
class Solution {
    public String longestPalindrome(String s) {
    	int start =0;
    	int maxLength =1;
    	if(s.length()==0)
    	{
    		return "";
    	}
        boolean[][] matrix = new boolean[s.length()][s.length()];
        for(int i=0;i<matrix.length;i++)
        {
        	for(int j=0;j<matrix[i].length;j++)
        	{
        		matrix[i][j]=false;
        	}
        }
        for(int i=0;i<s.length();i++)
        {
        	matrix[i][i]=true;
        	maxLength=1;
        }
        for(int k=2;k<=s.length();k++)
        {
        	for(int i=0;i<=s.length()-k;i++)
        	{
        		int j = i+k-1;
        		if(k==2)
        		{
        			if(s.charAt(i)==s.charAt(j))
        			{
        				matrix[i][j]=true;
        				start = i;
        				maxLength=2;
        			}
        		}
        		else if(matrix[i+1][j-1] && s.charAt(i)==s.charAt(j))
        			{
        				matrix[i][j] = true;
        				start =i;
        				maxLength = Math.max(maxLength,k);
        			}
        	}
        }
        return s.substring(start,start+maxLength);
    }
}