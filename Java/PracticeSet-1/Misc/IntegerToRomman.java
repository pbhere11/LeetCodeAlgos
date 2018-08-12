/*

Example 1:

Input: 3
Output: "III"
Example 2:

Input: 4
Output: "IV"
Example 3:

Input: 9
Output: "IX"
Example 4:

Input: 58
Output: "LVIII"
Explanation: C = 100, L = 50, XXX = 30 and III = 3.
Example 5:

Input: 1994
Output: "MCMXCIV"
Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.

Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

Symbol       Value
I             1
V             5
X             10
L             50
C             100
D             500
M             1000
For example, two is written as II in Roman numeral, just two one's added together. Twelve is written as, XII, which is simply X + II. 
The number twenty seven is written as XXVII, which is XX + V + II.

Roman numerals are usually written largest to smallest from left to right. 
However, the numeral for four is not IIII. 
Instead, the number four is written as IV. 
Because the one is before the five we subtract it making four. 
The same principle applies to the number nine, which is written as IX. 
There are six instances where subtraction is used:

I can be placed before V (5) and X (10) to make 4 and 9. 
X can be placed before L (50) and C (100) to make 40 and 90. 
C can be placed before D (500) and M (1000) to make 400 and 900.
Given an integer, convert it to a roman numeral. Input is guaranteed to be within the range from 1 to 3999.

*/
class Solution {
    public String intToRoman(int num) {
    	HashMap<Integer,String> romanMap = new HashMap<Integer,String>();
    	romanMap.put(1,"I");
    	romanMap.put(5,"V");
    	romanMap.put(10,"X");
    	romanMap.put(50,"L");
    	romanMap.put(100,"C");
    	romanMap.put(500,"D");
    	romanMap.put(1000,"M");
    	String result = "";
        while(num!=0)
        {
        	if(num/1000!=0)
        	{
        		int divider = num/1000;
        		result = result+getRoman(divider,romanMap)+"M";
        		num = num%1000;
        	}
        	else if(num/100!=0)
        	{
        		int divider = num/100;
        		if(divider == 5)
        		{
        			result = result + "D";
        		}
        		else if(divider ==4)
        		{
        			result = result + "CD";
        		}
        		else if(divider ==9)
        		{
        			result = result + "CM";
        		}
        		else
        		{
        			result = result+getRoman(divider,romanMap)+"C";
        		}
        		num = num%100;
        	}
        	else if(num/10!=0)
        	{
        		int divider = num/10;
        		if(divider == 5)
        		{
        			result = result + "L";
        		}
        		else if(divider ==4)
        		{
        			result = result + "XL";
        		}
        		else if(divider ==9)
        		{
        			result = result + "XC";
        		}
        		else
        		{
        			result = result+getRoman(divider,romanMap)+"x";
        		}
        		num = num%10;
        	}
        	else
        	{
        		result = result+getRoman(num,romanMap);
        		num = 0;
        	}
        }
        return result;
    }

    private String getRoman(int number,HashMap<Integer,String> romanMap)
    {
    	String result = "";
    	while(number!=0)
    	{
    		if(number==5)
    		{
    			return romanMap.get(number);
    		}
    		else if(number==4)
    		{
    			return romanMap.get(1)+romanMap.get(5);
    		}
    		else if(number ==9)
    		{
    			return romanMap.get(1)+romanMap.get(10);
    		}
    		else
    		{
    			if(number>5)
    			{
    				result = result+romanMap.get(5);
    				number = number-5;
    			}
    			else
    			{
    				result = result+romanMap.get(1);
    				number = number-1;
    			}
    		}
    	}
    	return result;
    } 
}