/*
Validate if a given string is numeric.

Some examples:
"0" => true
" 0.1 " => true
"abc" => false
"1 a" => false
"2e10" => true
number
e
space
decimal point
other char

aaa
e
.9 8
  9

*/
public class Solution {
    public bool IsNumber(string s) {
        bool numStarted = false;
        bool decimalStarted = false;
        bool expStarted = false;
        bool numEnded = false;
        bool signStarted = false;
        char prev = '#';
        for(int i=0;i<s.Length;i++)
        {
            char c = s[i];
            if(!isNumber(c)&&!isDecimal(c)&&!isExponential(c)&&!isSpace(c)&&!isSign(c))
            {
                return false;
            }
            if(!numStarted)
            {
                if(isExponential(c))
                {
                    return false;
                }
                if(isNumber(c))
                {
                    numStarted = true;
                }
                else if(isDecimal(c))
                {
                    if(decimalStarted)
                    {
                        return false;
                    }
                    decimalStarted = true;
                }
                else if(isSpace(c))
                {
                    if(isDecimal(prev)||isSign(prev))
                    {
                        return false;
                    }
                }
                else if(isSign(c))
                {
                    if(decimalStarted||signStarted)
                    {
                        return false;
                    }
                    else
                    {
                        signStarted = true;
                    }
                }
            }
            else
            {
                if(isSpace(c))
                {
                    if(isExponential(prev))
                    {
                        return false;
                    }
                    numEnded = true;
                }
                else if(numEnded)
                {
                    return false;
                }
                else if(isSign(c))
                {
                    if(!isExponential(prev))
                    {
                        return false;
                    }
                }
                else if(isDecimal(c))
                {
                    if(isExponential(prev)||isDecimal(prev))
                    {
                        return false;
                    }
                    if(decimalStarted||expStarted)
                    {
                        return false;
                    }
                    else
                    {
                        decimalStarted = true;
                    }
                }
                else if(isExponential(c))
                {
                    if(isExponential(prev))
                    {
                        return false;
                    }
                    if(expStarted)
                    {
                        return false;
                    }
                    else
                    {
                        expStarted = true;
                    }
                }
            }
            prev = c;
        }
        return numStarted&&!isExponential(prev)&&!isSign(prev);
    }
    private bool isNumber(char c)
    {
        return (int)c-'0'>=0 && (int)c-'0'<=9;
    }
    private bool isExponential(char c)
    {
        return c=='e';
    }
    private bool isDecimal(char c)
    {
        return c=='.';
    }
    private bool isSign(char c)
    {
        return c=='+'||c=='-';
    }
    private bool isSpace(char c)
    {
        return char.IsWhiteSpace(c);
    }
}