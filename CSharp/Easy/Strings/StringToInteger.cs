/*
Example 1:

Input: "42"
Output: 42
Example 2:

Input: "   -42"
Output: -42
Explanation: The first non-whitespace character is '-', which is the minus sign.
             Then take as many numerical digits as possible, which gets 42.
Example 3:

Input: "4193 with words"
Output: 4193
Explanation: Conversion stops at digit '3' as the next character is not a numerical digit.
Example 4:

Input: "words and 987"
Output: 0
Explanation: The first non-whitespace character is 'w', which is not a numerical 
             digit or a +/- sign. Therefore no valid conversion could be performed.
Example 5:

Input: "-91283472332"
Output: -2147483648
Explanation: The number "-91283472332" is out of the range of a 32-bit signed integer.
             Thefore INT_MIN (−231) is returned.
*/

public class Solution {
    public int MyAtoi(string str) {
        int num = 0;
        int sign =1;
        bool numStarted = false;
        bool numEnded = false;
        for(int i=0;i<str.Length;i++)
        {
        	if(!numStarted && (!(char.IsWhiteSpace(str[i])||(str[i]>='0'&&str[i]<='9')||str[i]=='-'||str[i]=='+')))
        	{
        		return 0;
        	}
        	if(numStarted && (!(str[i]>='0'&&str[i]<='9')))
        	{
        		numEnded = true;
        	}
        	if(!numStarted && ((str[i]=='-')||(str[i]=='+')))
        	{
        		if(str[i]=='-')
        		{
        			sign = sign*-1;
        		}
        		numStarted = true;
        	}
        	else if(numStarted && !numEnded && ((str[i]=='-')||(str[i]=='+')))
        	{
        		return 0;
        	}

        	if(!numEnded && str[i]>='0'&&str[i]<='9')
        	{
        		if(numEnded)
        		{
        			return num*sign;
        		}
        		numStarted = true;
        		if(num>int.MaxValue/10 ||(num==int.MaxValue/10 && ((int)str[i]-'0')>7))
        		{
        			if(sign<0)
        			{
        				return int.MinValue;
        			}
        			else
        			{
        				return int.MaxValue;
        			}
        		}
        		num = num*10+((int)str[i]-'0');
        	}
        }
        return num*sign;
    }
}