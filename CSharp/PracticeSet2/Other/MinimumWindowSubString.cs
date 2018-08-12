/*
Example:

Input: S = "ADOBECODEBANC", T = "ABC"
Output: "BANC"

targetCountMap
A B C
1 1 1
map
0 1 2 3 4 5 6 7 8 9 10 11 12 
A D O B E C O D E B A  N  c
1 - - 1 - 1 - - - 1 1  -  1
1     2   3       3 
minLength = 4
str = BANC
*/
public class Solution {
    public string MinWindow(string s, string t) {
        Dictionary<char,int> targetCountMap = new Dictionary<char,int>();
        for(int i=0;i<t.Length;i++)
        {
        	if(targetCountMap.ContainsKey(t[i]))
        	{
        		targetCountMap[t[i]]++;
        	}
        	else
        	{
        		targetCountMap.Add(t[i],1);
        	}
        }
        Dictionary<char,int> map = new Dictionary<char,int>();
        int start =0;
        int count =0;
        int minLength = s.Length+1;
        string result = "";
        for(int i=0;i<s.Length;i++)
        {
        	if(targetCountMap.ContainsKey(s[i]))
        	{
        		if(!map.ContainsKey(s[i]))
        		{
        			count++;
        			map.Add(s[i],1);
        		}
        		else 
        		{
        			if (map.ContainsKey(s[i]) && map[s[i]]<targetCountMap[s[i]])
        				count++;
        			map[s[i]]++;
        		}
        	}
        	if(count==t.Length)
        	{
        		char c = s[start];
        		while(!map.ContainsKey(c) || (map.ContainsKey(c) && map[c]>targetCountMap[c]))
        		{
        			if(map.ContainsKey(c) && map[c]>targetCountMap[c])
        			{
        				map[c]--;
        			}
        			start++;
        			c = s[start];
        		}
        		if(i-start+1<minLength)
        		{
        			minLength = i-start+1;
        			result = s.Substring(start,minLength);
        		}
        	}
        }
        return result;
    }
}