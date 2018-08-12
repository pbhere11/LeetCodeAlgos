/*
For example, given n = 3, a solution set is:

[
  "((()))",
  "(()())",
  "(())()",
  "()(())",
  "()()()"
]
*/
public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        IList<string> result = new List<string>();
        string resultStr = "";
        if(n==0)
        {
        	return result;
        }
        GenerateParantheses(0,0,result,resultStr,n);
        return result;
    }

    private void GenerateParantheses(int openParantheses, int closeParantheses,IList<string> result, string resultStr, int n)
    {
    	if(openParantheses==closeParantheses && openParantheses+closeParantheses == 2*n)
    	{
    		result.Add(resultStr);
    	}
    	else
    	{
    		if(openParantheses<n)
	    	{
	    		GenerateParantheses(openParantheses+1,closeParantheses,result,resultStr+"(",n);
	    	}
	    	if(closeParantheses<openParantheses)
	    	{
	    		GenerateParantheses(openParantheses,closeParantheses+1,result,resultStr+")",n);
	    	}
    	} 
    }
}