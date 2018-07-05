/*
For example:

    A -> 1
    B -> 2
    C -> 3
    ...
    Z -> 26
    AA -> 27
    AB -> 28 
    ...
Example 1:

Input: "A"
Output: 1
Example 2:

Input: "AB"
Output: 28
Example 3:

Input: "ZY"
Output: 701
*/
public class Solution {
    public int TitleToNumber(string s) {
		int i= s.Length-1;
		int t = 0;
		int result =0;
		while(i>=0)
		{
			result = result+((int)Math.Pow(26,t)*(int)(s[i]-'A'+1));
			i--;
			t++;
		}
		return result;
	}
}