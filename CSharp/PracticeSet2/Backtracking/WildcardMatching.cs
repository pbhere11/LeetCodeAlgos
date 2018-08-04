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
p = "*"
Output: true
Explanation: '*' matches any sequence.
Example 3:

Input:
s = "cb"
p = "?a"
Output: false
Explanation: '?' matches 'c', but the second letter is 'a', which does not match 'b'.
Example 4:

Input:
s = "adceb"
p = "*a*b"
Output: true
Explanation: The first '*' matches the empty sequence, while the second '*' matches the substring "dce".
Example 5:

Input:
s = "acdcb"
p = "a*c?b"
Output: false
    a * c ? b
  1 0 0 0 0 0  
a 0 1 1 0 0 0
c 0 0 1 1 0 0
d 0 0 1 0 1 0
c 0 0 1 1 0 0
b 0 0 1 0 1 1

a*c?
a
  # a  
# 1 0
a 0 1
a 0 0

"adceb"
"*a*b"

  # * a * b
# 1 1 0 0 0
a 0 1 1 1 0
d 0 1 0 1 0
c 0 1 0 1 0
e 0 1 0 1 0
b 0 1 0 1 1
*/
public class Solution {
    public bool IsMatch(string s, string p) {
    	if(s.Length==0&&p.Length==0)
    	{
    		return true;
    	}
    	if(s.Length==0&&p.Length>0||s.Length>0&&p.Length==0)
    	{
    		if(p.Length==1 && p[0]=='*')
    		{
    			return true;
    		}
    		return false;
    	}
        char[] str = new char[s.Length+1];
        str[0] = '#';
        for(int i=1;i<=s.Length;i++)
        {
        	str[i] = s[i-1];
        }
        char[] ptrn = new char[p.Length+1];
        int index = 1;
        ptrn[0] = '#';
        bool firstStar = true;
        for(int i=0;i<p.Length;i++)
        {
        	if(p[i]=='*')
        	{
        		if(firstStar)
        		{
        			ptrn[index]=p[i];
        			index++;
        			firstStar = false;
        		}
        	}
        	else
        	{
        		ptrn[index]=p[i];
				index++;
				firstStar = true;
        	}
        }
        bool[,] matrix = new bool[str.Length,index];
        for(int i=0;i<matrix.GetLength(0);i++)
        {
        	matrix[i,0] = false;
        }
        for(int i=0;i<matrix.GetLength(1);i++)
        {
        	matrix[0,i] = false;
        }
        matrix[0,0] = true;
        if(ptrn[1]=='*')
        {
        	matrix[0,1] = true;
        }
        for(int i=1;i<matrix.GetLength(0);i++)
        {
        	for(int j=1;j<matrix.GetLength(1);j++)
        	{
        		if(ptrn[j]=='?'||str[i]==ptrn[j])
        		{
        			matrix[i,j] = matrix[i-1,j-1];
        		}
        		else if(ptrn[j]=='*')
        		{
        			matrix[i,j] = matrix[i-1,j]||matrix[i,j-1];
        		}
        		else
        		{
        			matrix[i,j] = false;
        		}
        	}
        }
        return matrix[str.Length-1,index-1];
    }
}