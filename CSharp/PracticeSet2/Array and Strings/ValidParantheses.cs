/*
Example 1:

Input: "()"
Output: true
Example 2:

Input: "()[]{}"
Output: true
Example 3:

Input: "(]"
Output: false
Example 4:

Input: "([)]"
Output: false
Example 5:

Input: "{[]}"
Output: true
*/
public class Solution {
    public bool IsValid(string s) {
    	Stack<char> stck = new Stack<char>();
        for(int i=0;i<s.Length;i++)
        {
        	if(s[i]=='('||s[i]=='['||s[i]=='{')
        	{
        		stck.Push(s[i]);
        	}
        	else if(s[i]==')'||s[i]==']'||s[i]=='}')
        	{
        		switch(s[i])
        		{
        			case ')':
        				if(stck.Count>0 && stck.Peek()=='(')
	        			{
	        				stck.Pop();
	        			}
	        			else
	        			{
	        				return false;
	        			}
	        			break;
	        		case ']':
        				if(stck.Count>0 && stck.Peek()=='[')
	        			{
	        				stck.Pop();
	        			}
	        			else
	        			{
	        				return false;
	        			}
	        			break;
	        		case '}':
        				if(stck.Count>0 && stck.Peek()=='{')
	        			{
	        				stck.Pop();
	        			}
	        			else
	        			{
	        				return false;
	        			}
	        			break;
        		}
        	}
        }
        return stck.Count==0;
    }
}