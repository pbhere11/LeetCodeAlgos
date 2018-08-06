/*
Example 1:

Input: "()())()"
Output: ["()()()", "(())()"]
Example 2:

Input: "(a)())()"
Output: ["(a)()()", "(a())()"]
Example 3:

Input: ")("
Output: [""]
*/
public class Solution {
    public IList<string> RemoveInvalidParentheses(string s) {
        IList<string> result = new List<string>();
        Queue<string> q = new Queue<string>();
        HashSet<string> visited = new HashSet<string>();
        q.Enqueue(s);
        visited.Add(s);
        bool found = false;
        while(q.Count>0)
        {
        	string str = q.Dequeue();
        	if(IsValid(str))
        	{
        		result.Add(str);
        		found = true;
        	}
        	else if(!found)
        	{
        		for(int i=0;i<str.Length;i++)
        		{
        			if(str[i]=='('||str[i]==')')
        			{
        				string temp = "";
        				if(str.Length>1)
        				{
        					temp = str.Substring(0,i)+str.Substring(i+1);
        				}
        				
        				if(!visited.Contains(temp))
        				{
        					q.Enqueue(temp);
        					visited.Add(temp);
        				}
        			}
        		}
        	}
        }
        return result;
    }
    private bool IsValid(string str)
    {
    	int count = 0;
    	for(int i=0;i<str.Length;i++)
    	{
    		if(str[i]=='(')
    		{
    			count++;
    		}
    		else if(str[i]==')')
    		{
    			count--;
    		}
    		if(count<0)
    		{
    			return false;
    		}
    	}
    	return count==0;
    }
}