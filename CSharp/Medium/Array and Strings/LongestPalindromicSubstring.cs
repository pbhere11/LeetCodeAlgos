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
        bool[,] matrix = new bool[n,n];
        int maxLength =0;
        int startIndex =0;
        for(int i=0;i<n;i++)
        {
            matrix[i,i] = true;
            maxLength=1;
        }
        for(int k = 2;k<=n;k++)
        {
            for(int i=0;i<=n-k;i++)
            {
                int j = i+k-1;
                if(k==2)
                {
                    if(s[i]==s[j])
                    {
                        matrix[i,j] = true;
                        maxLength = 2;
                        startIndex = i;
                    }
                }
                else
                {
                    if(matrix[i+1,j-1] && s[i]==s[j])
                    {
                        matrix[i,j] = true;
                        maxLength = Math.Max(maxLength,k);
                        startIndex = i;
                    }
                }
            }
        }
        return s.Substring(startIndex,maxLength);
    }
}