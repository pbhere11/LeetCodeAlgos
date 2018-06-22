/*
Write a function that takes a string as input and returns the string reversed.

Example:
Given s = "hello", return "olleh".
*/

public class Solution {
    public string ReverseString(string s) {
        char[] charArr = s.ToCharArray();
        int i=0;
        int j = charArr.Length-1;
        while(i<j)
        {
        	char c = charArr[i];
        	charArr[i] = charArr[j];
        	charArr[j] = c;
        	i++;
        	j--;
        }
        return new string(charArr);
    }
}