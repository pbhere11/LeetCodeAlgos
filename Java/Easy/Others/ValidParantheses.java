class Solution {
    public boolean isValid(String s) {
        Stack<Character> stk = new Stack<Character>();
        for(int i=0;i<s.length();i++)
        {
        	if(isopeningTag(s.charAt(i)))
        	{
        		stk.push(s.charAt(i));
        	}
        	else if(isclosingTag(s.charAt(i)))
        	{
        		if(!stk.empty() && getclosingTag(stk.peek())==s.charAt(i))
        		{
        			stk.pop();
        		}
        		else
        		{
        			return false;
        		}
        	}
        }
        return stk.empty();
    }
    private char getclosingTag(char c)
    {
    	if(c=='(')
    	{
    		return ')';
    	}
    	if(c=='{')
    	{
    		return '}';
    	}
    	if(c=='[')
    	{
    		return ']';
    	}
    	return '-';
    }
    private boolean isopeningTag(char c)
    {
    	if(c=='{'||c=='('||c=='[')
    	{
    		return true;
    	}
    	else
    	{
    		return false;
    	}
    }
    private boolean isclosingTag(char c)
    {
    	if(c=='}'||c==')'||c==']')
    	{
    		return true;
    	}
    	else
    	{
    		return false;
    	}
    }
}