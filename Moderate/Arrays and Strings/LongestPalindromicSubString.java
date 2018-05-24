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
    	if(s.length()==0)
    	{
    		return "";
    	}
    	if(s.length()==1)
    	{
    		return s;
    	}
        boolean[][] matrix = new boolean[s.length()][s.length()];
        int maxLength = 1;
        int start =0;
        //set everything to false
        for(int i=0;i<matrix.length;i++)
        {
        	for(int j=0;j<matrix[i].length;j++)
        	{
        		matrix[i][j] = false;
        	}
        }

        for(int i=0;i<matrix.length;i++)
        {
        	matrix[i][i]=true;
        }
        for(int i=2;i<s.length();i++)
        {
        	for(int j=0;j<=s.length()-i;j++)
        	{
        		int k = j+i-1;
        		if(i==2)
        		{
        			if(s.charAt(j)==s.charAt(k))
        			{
        				matrix[j][k]=true;
        				maxLength = Math.max(maxLength,2);
        				start = j;
        			}
        		}
        		else
        		{
	        		if(matrix[j+1][k-1] && s.charAt(j)==s.charAt(k))
	        		{
	        			matrix[j][k]=true;
	        			maxLength = Math.max(maxLength,i);
	        			start = j;
	        		}
        		}
        	}
        }
        return s.substring(start,start+maxLength);
    }
}