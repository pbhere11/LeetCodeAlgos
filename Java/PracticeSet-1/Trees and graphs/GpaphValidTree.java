/*
Example 1:

Input: n = 5, and edges = [[0,1], [0,2], [0,3], [1,4]]
Output: true
Example 2:

Input: n = 5, and edges = [[0,1], [1,2], [2,3], [1,3], [1,4]]
Output: false
3
[[1,0],[0,2],[2,1]]
*/
class Solution {
    public boolean validTree(int n, int[][] edges) {
        HashMap<Integer,List<Integer>> map = new HashMap<Integer,List<Integer>>();
        for(int i=0;i<edges.length;i++)
        {
        	if(map.containsKey(edges[i][0]))
        	{
        		map.get(edges[i][0]).add(edges[i][1]);
        	}
        	else
        	{
        		List<Integer> list = new ArrayList<Integer>();
        		list.add(edges[i][1]);
        		map.put(edges[i][0],list);
        	}
        	if(map.containsKey(edges[i][1]))
        	{
        		map.get(edges[i][1]).add(edges[i][0]);
        	}
        	else
        	{
        		List<Integer> list = new ArrayList<Integer>();
        		list.add(edges[i][0]);
        		map.put(edges[i][1],list);
        	}
        }
        /*
		0 - 1
		1 - 0
		0 - 2
		2 - 0
		0 - 3
		3 - 0
		1 - 4
		4 - 1
        */
        boolean[] visitedNodes = new boolean[n];
        if(!helper(0,-1,visitedNodes,map))
        {
        	return false;
        }
        for(int i=0;i<visitedNodes.length;i++)
        {
        	if(!visitedNodes[i])
        	{
        		return false;
        	}
        }
        return true;
    }
    private boolean helper(int curr, int parent, boolean[] visitedNodes, HashMap<Integer,List<Integer>> map)
    {
    	if(visitedNodes[curr])//0
    	{
    		return false;
    	}
    	visitedNodes[curr] = true;
    	List<Integer> list = map.get(curr);//4
    	if(list!=null)
    	{
    		for(int i=0;i<list.size();i++)
	    	{
	    		int val = list.get(i);//1
	    		if(val!=parent)
	    		{
	    			if(!helper(val,curr,visitedNodes,map))
	    			{
	    				return false;
	    			}
	    		}
	    	}
    	}
    	return true;
    }
}