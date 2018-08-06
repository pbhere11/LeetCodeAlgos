/*
Example 1:

Input: 
S = "abcdebdde", T = "bde"
Output: "bcde"
Explanation: 
"bcde" is the answer because it occurs before "bdde" which has the same length.
"deb" is not a smaller window because the elements of T in the window must occur in order.
*/
public class Solution {
    public string MinWindow(string S, string T) {
        int n = S.Length;
        int[] last = new int[26];
        for(int i=0;i<26;i++)
        {
        	last[i]=-1;
        }
        int[,] next = new int[n,26];
        for(int i=n-1;i>=0;i--)
        {
        	last[(int)S[i]-'a'] = i;
        	for(int k=0;k<26;k++)
        	{
        		next[i,k] = last[k];
        	}
        }
        IList<int[]> windows = new List<int[]>();
        for(int i=0;i<n;i++)
        {
        	if(S[i]==T[0])
        	{
        		int[] temp = new int[2];
        		temp[0] = i;
        		temp[1]=i;
        		windows.Add(temp);
        	}
        }

        for(int j=1;j<T.Length;j++)
        {
        	int letterIndex = (int)T[j]-'a';
        	foreach(int[] window in windows)
        	{
        		if(window[1]<n-1 && next[window[1]+1,letterIndex]>=0)
        		{
        			window[1]=next[window[1]+1,letterIndex];
        		}
        		else
        		{
        			window[0]=window[1]=-1;
        			break;
        		}
        	}
        }
        int[] ans = new int[2];
        ans[0] = -1;
        ans[1] = S.Length;
        foreach(int[] window in windows)
       	{
       		if(window[0]==-1) break;
       		if(window[1]-window[0]<ans[1]-ans[0])
       		{
       			ans = window;
       		}
       	}
       	return ans[0]>=0?S.Substring(ans[0],ans[1]-ans[0]+1):"";
    }
}