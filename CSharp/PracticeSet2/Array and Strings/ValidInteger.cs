/*
Validate if a given string is numeric.

Some examples:
"0" => true
" 0.1 " => true
"abc" => false
"1 a" => false
"2e10" => true
*/
public class Solution {
    public bool IsNumber(string s) {
        int i=0;
        bool numStarted = false;
        bool exponentStarted = false;
        bool decimalStarted = false;
        bool numEnded = false;
        int result =0;
        while(i<s.Length)
        {
        	if(!numStarted)
        	{
        		if(isNumber(s[i]))
        		{
        			numStarted = true;
        			i++;
        		}
        		else if(isSpace(s[i]))
        		{
        			if(decimalStarted || exponentStarted)
        			{
        				return false;
        			}
        			else
        			{
        				i++;
        			}
        		}
        		else if(isDecimalPoint(s[i]))
        		{
        			if(decimalStarted)
					{
						return false;
					}
        			else
        			{
        				decimalStarted = true;
        				i++;
        			}
        		}
        		else
        		{
        			return false;
        		}
        	}
        	else
        	{
        		if(isSpace(s[i]))
        		{
        			if(decimalStarted || exponentStarted)
        			{
        				return false;
        			}
        			else
        			{
        				numEnded = true;
        				i++;
        			}
        		}
        		else if(!(isNumber(s[i])||isExponent(s[i])||isDecimalPoint(s[i])))
        		{
        			return false;
        		}
        		else
        		{
        			if(numEnded)
        			{
        				return false;
        			}
        			if(isExponent(s[i]))
        			{
        				if(exponentStarted)
        				{
        					return false;
        				}
        				else
        				{
        					exponentStarted = true;
        					i++;
        				}
        			}
        			else
        			{
        				if(isDecimalPoint(s[i]))
        				{
        					if(decimalStarted)
        					{
        						return false;
        					}
        					else
        					{
        						decimalStarted = true;
        						i++;
        					}
        				}
        				else
        				{
        					i++;
        				}
        			}
        		}
        	}
        }
        return numStarted && !isExponent(s[s.Length-1]);
    }
    private bool isNumber(char c)
    {
    	return ((int)c-'0')>=0&&((int)c-'0')<=9;
    }
    private bool isExponent(char c)
    {
    	return c=='e';
    }
    private bool isDecimalPoint(char c)
    {
    	return c=='.';
    }
    private bool isSpace(char c)
    {
    	return char.IsWhiteSpace(c);
    }
}