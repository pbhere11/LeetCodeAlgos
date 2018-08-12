/*
Example 1:

Input:
[
  "wrt",
  "wrf",
  "er",
  "ett",
  "rftt"
]

Output: "wertf"
Example 2:

Input:
[
  "z",
  "x"
]

Output: "zx"
Example 3:

Input:
[
  "z",
  "x",
  "z"
] 

Output: "" 

Explanation: The order is invalid, so return "".
*/
class Solution {
	private Stack<Character> stck;
	private boolean isValidTree = true;
    public String alienOrder(String[] words) {
    	stck = new Stack<Character>();
		HashMap<Character,List<Character>> edges = new HashMap<Character,List<Character>>();
		List<Character> indexList = new ArrayList<Character>();
        for(int x=0;x<words.length-1;x++)
        {
        	String word1 = words[x];
        	String word2 = words[x+1];
        	int i=0;
        	int j=0;
        	while(i<word1.length()||j<word2.length())
        	{
        		if(i<word1.length() && j>=word2.length())
        		{
        			if(!edges.containsKey(word1.charAt(i)))
        			{
        				List<Character> list = new ArrayList<Character>();
        				edges.put(word1.charAt(i),list);
        				indexList.add(word1.charAt(i));
        			}
        			i++;
        		}
        		else if(j<word2.length() && i>=word1.length())
        		{
        			if(!edges.containsKey(word2.charAt(j)))
        			{
        				List<Character> list = new ArrayList<Character>();
        				edges.put(word2.charAt(j),list);
        				indexList.add(word2.charAt(j));
        			}
        			j++;
        		}
        		else if(i<word1.length() && j<word2.length() && word1.charAt(i)!=word2.charAt(j))
        		{
        			if(edges.containsKey(word1.charAt(i)))
        			{
        				if(!edges.get(word1.charAt(i)).contains(word2.charAt(j)))
        				{
        					edges.get(word1.charAt(i)).add(word2.charAt(j));
        				}
        			}
        			else
        			{
        				List<Character> list = new ArrayList<Character>();
        				list.add(word2.charAt(j));
        				edges.put(word1.charAt(i),list);
        				indexList.add(word1.charAt(i));
        			}
        			i++;
        			j++;
        		}
        		else if(i<word1.length() && j<word2.length() &&word1.charAt(i)==word2.charAt(j))
        		{
        			if(!edges.containsKey(word1.charAt(i)))
        			{
        				List<Character> list = new ArrayList<Character>();
        				edges.put(word1.charAt(i),list);
        				indexList.add(word1.charAt(i));
        			}
        			i++;
        			j++;
        		}
        	}
        }
        topologicalSort(edges,indexList);
        String result = "";
        while(!stck.isEmpty())
        {
        	result = result + stck.pop();
        }
        return result;
    }
    private void topologicalSort(HashMap<Character,List<Character>> edges,List<Character> indexList)
    {
    	HashMap<Character,Boolean> visitedmap = new HashMap<Character,Boolean>();
    	for(Character c: indexList)
    	{
    		if(!visitedmap.containsKey(c))
    		{
    			dfs(c,edges,visitedmap);
    		}
    	}
    }
    private void dfs(Character c, HashMap<Character,List<Character>> edges,HashMap<Character,Boolean> visitedmap)
    {
    	if(!visitedmap.containsKey(c))
    	{
    		visitedmap.put(c,true);
	    	List<Character> list = edges.get(c);
	    	if(list!=null)
	    	{
	    		for(int i=0;i<list.size();i++)
	    		{
	    			dfs(list.get(i),edges,visitedmap);
	    		}
	    	}
	    	if(isValidTree)
	    	{
	    		stck.push(c);
	    	}
	    	
    	}
    	else
    	{
    		isValidTree = false;
    		return;
    	}
    }
}