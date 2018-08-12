/*
Example 1:

Input: ["flower","flow","flight"]
Output: "fl"
Example 2:

Input: ["dog","racecar","car"]
Output: ""
Explanation: There is no common prefix among the input strings.
*/

public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if(strs.Length==0)
        {
        	return "";
        }

        for(int i=0;i<strs[0].Length;i++)
        {
        	for(int j =0;j<strs.Length;j++)
        	{
        		if(i==strs[j].Length||strs[0][i]!=strs[j][i])
        		{
        			return strs[0].Substring(0,i);
        		}
        	}
        }
        return strs[0];
    }
}