/*
Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

Symbol       Value
I             1
V             5
X             10
L             50
C             100
D             500
M             1000
For example, two is written as II in Roman numeral, just two one's added together. Twelve is written as, XII, which is simply X + II. The number twenty seven is written as XXVII, which is XX + V + II.

Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. Instead, the number four is written as IV. Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:

I can be placed before V (5) and X (10) to make 4 and 9. 
X can be placed before L (50) and C (100) to make 40 and 90. 
C can be placed before D (500) and M (1000) to make 400 and 900.
Given a roman numeral, convert it to an integer. Input is guaranteed to be within the range from 1 to 3999.

Example 1:

Input: "III"
Output: 3
Example 2:

Input: "IV"
Output: 4
Example 3:

Input: "IX"
Output: 9
Example 4:

Input: "LVIII"
Output: 58
Explanation: C = 100, L = 50, XXX = 30 and III = 3.
Example 5:

Input: "MCMXCIV"
Output: 1994
Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.

*/
public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char,int> dict = new Dictionary<char,int>();
        dict.Add('I',1);
        dict.Add('V',5);
        dict.Add('X',10);
        dict.Add('L',50);
        dict.Add('C',100);
        dict.Add('D',500);
        dict.Add('M',1000);
        int result =0;
        for(int i=0;i<s.Length;i++)
        {
        	int currNum = dict[s[i]];
        	if(i+1<s.Length)
        	{
        		int nextNum = dict[s[i+1]];
        		if(currNum<nextNum)
        		{
        			result = result + nextNum-currNum;
        			i++;
        		}
        		else
        		{
        			result = result + currNum;
        		}
        	} 
        	else
        	{
        		result = result + currNum;
        	}
        }
        return result;
    }
}