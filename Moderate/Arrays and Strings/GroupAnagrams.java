/*
Input: ["eat", "tea", "tan", "ate", "nat", "bat"],
Output:
[
  ["ate","eat","tea"],
  ["nat","tan"],
  ["bat"]
]
*/
class Solution {
    public List<List<String>> groupAnagrams(String[] strs) {
        List<List<String>> result = new ArrayList<List<String>>();
        if(strs.length==0)
        {
        	return result;
        }
        HashMap<String,List<String>> map = new HashMap<String,List<String>>();
        for(int i=0;i<strs.length;i++)
        {
        	String str = sort(strs[i]);
        	if(map.containsKey(str))
        	{
        		map.get(str).add(strs[i]);
        	}
        	else
        	{
        		List<String> innerList = new ArrayList<String>();
        		innerList.add(strs[i]);
        		map.put(str,innerList);
        	}
        }
        Iterator<Map.Entry<String,List<String>>> itr = map.entrySet().iterator();
        while(itr.hasNext())
        {
        	Map.Entry<String,List<String>> entry = itr.next();
        	result.add(entry.getValue());
        } 
        return result;
    }

    private String sort(String str)
    {
    	int[] charCount = new int[26];
    	str = str.toLowerCase();
    	for(int i=0;i<str.length();i++)
    	{
    		charCount[str.charAt(i)-'a']++;
    	}
    	String result = "";
    	for(int i=0;i<charCount.length;i++)
    	{
    		if(charCount[i]>0)
    		{
    			while(charCount[i]>0)
    			{
    				char c = (char)(i+'a');
    				result = result+c;
    				charCount[i]--;
    			}
    		}
    	}
    	return result;
    }
}