/*
Example:

Input: ["eat", "tea", "tan", "ate", "nat", "bat"],
Output:
[
  ["ate","eat","tea"],
  ["nat","tan"],
  ["bat"]
]
*/
public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        IList<IList<string>> result = new List<IList<string>>();
        Dictionary<string,IList<string>> map = new Dictionary<string,IList<string>>();
        if(strs.Length==0)
        {
        	return result;
        }
        for(int i=0;i<strs.Length;i++)
        {
        	string sortedStr = Sort(strs[i]);
        	if(map.ContainsKey(sortedStr))
        	{
        		map[sortedStr].Add(strs[i]);
        	}
        	else
        	{
        		IList<string> innerList = new List<string>();
        		innerList.Add(strs[i]);
        		map.Add(sortedStr,innerList);
        	}
        }
        foreach(KeyValuePair<string,IList<string>> item in map)
        {
        	result.Add(item.Value);
        }
        return result;
    }

    private string Sort(string str)
    {
    	char[] charArr = str.ToCharArray();
    	int[] counter = new int[26];
    	for(int i=0;i<str.Length;i++)
    	{
    		counter[(int)char.ToLower(str[i])-'a']++;
    	}

    	StringBuilder sb = new StringBuilder();
    	for(int i=0;i<counter.Length;i++)
    	{
    		while(counter[i]>0)
    		{
    			sb.Append((char)i+'a');
    			counter[i]--;
    		}
    	}
    	return sb.ToString();
    }
}