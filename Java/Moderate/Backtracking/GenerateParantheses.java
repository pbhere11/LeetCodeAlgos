/*
For example, given n = 3, a solution set is:

[
  "((()))",
  "(()())",
  "(())()",
  "()(())",
  "()()()"
]*/
class Solution {
    public List<String> generateParenthesis(int n) {
        List<String> result = new ArrayList<String>();
        if(n==0)
        {
        	return result;
        }
        generateParenthesis(n,0,0,result,"");
        return result;
    }
    private void generateParenthesis(int n, int openCount, int closeCount, List<String> result, String str)
    {
    	if(openCount+closeCount==n*2)
    	{
    		result.add(str);
    	}
    	else
    	{
    		if(openCount<n)
	    	{
	    		generateParenthesis(n,openCount+1,closeCount,result,str+"(");
	    	}
	    	if(closeCount<openCount)
	    	{
	    		generateParenthesis(n,openCount,closeCount+1,result,str+")");
	    	}
    	}
    }
}