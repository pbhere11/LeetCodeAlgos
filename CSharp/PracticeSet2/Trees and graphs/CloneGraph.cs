/**
 * Definition for undirected graph.
 * public class UndirectedGraphNode {
 *     public int label;
 *     public IList<UndirectedGraphNode> neighbors;
 *     public UndirectedGraphNode(int x) { label = x; neighbors = new List<UndirectedGraphNode>(); }
 * };
 */
public class Solution {
    public UndirectedGraphNode CloneGraph(UndirectedGraphNode node) {
    	if(node==null)
    	{
    		return null;
    	}
        Queue<UndirectedGraphNode> q = new Queue<UndirectedGraphNode>();
        Dictionary<UndirectedGraphNode,UndirectedGraphNode> map = new Dictionary<UndirectedGraphNode,UndirectedGraphNode>();
        q.Enqueue(node);
        while(q.Count>0)
        {
        	UndirectedGraphNode currNode = q.Dequeue();
        	UndirectedGraphNode cloneNode;
        	if(!map.ContainsKey(currNode))
        	{
        		cloneNode = CloneNode(currNode,map);
        	}
        	else
        	{
        		cloneNode = map[currNode];
        	}
        	IList<UndirectedGraphNode> neighborList = currNode.neighbors;
			for(int i=0;i<neighborList.Count;i++)
			{
        		UndirectedGraphNode neighborNode = neighborList[i];
        		UndirectedGraphNode clonedNeighborNode;
        		if(!map.ContainsKey(neighborNode))
        		{
        			q.Enqueue(neighborNode);
        			clonedNeighborNode = CloneNode(neighborNode,map);
        		}
        		else
        		{
        			clonedNeighborNode = map[neighborNode];
        		}
        		if(cloneNode.neighbors==null)
        		{
        			cloneNode.neighbors = new List<UndirectedGraphNode>();
        		}
        		cloneNode.neighbors.Add(clonedNeighborNode);
        	}
        }
        return map[node];
    }
    private UndirectedGraphNode CloneNode(UndirectedGraphNode node, Dictionary<UndirectedGraphNode,UndirectedGraphNode> map)
    {
    	UndirectedGraphNode cloneNode = new UndirectedGraphNode(node.label);
		map.Add(node,cloneNode);
		return cloneNode;
    }
}