/*
Example 1:

Input: "babad"
Output: "bab"
Note: "aba" is also a valid answer.
Example 2:

Input: "cbbd"
Output: "bb"
*/
public class Solution {
    public string LongestPalindrome(string s) {
        int n = s.Length;
        boolean[,] matrix = new boolean[n,n];
        for(int i=0;i<n;i++)
        {
        	matrix[i,i] = true;
        }
    }
}