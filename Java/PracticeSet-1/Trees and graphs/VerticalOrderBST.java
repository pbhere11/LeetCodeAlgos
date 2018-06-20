/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode(int x) { val = x; }
 * }
 Input: [3,9,20,null,null,15,7]

   3
  /\
 /  \
 9  20
    /\
   /  \
  15   7 

Output:

[
  [9],
  [3,15],
  [20],
  [7]
]
fails for some test cases
 */
class Solution {
	private int minColumnIndex=0;
	private int maxColumnIndex =0;
    public List<List<Integer>> verticalOrder(TreeNode root) {
        HashMap<Integer,List<Integer>> columnMap = new HashMap<Integer,List<Integer>>();
        List<List<Integer>> result = new ArrayList<List<Integer>>();
        if(root==null)
        {
        	return result;
        }
        List<Integer> innerList = new ArrayList<Integer>();
		innerList.add(root.val);
		columnMap.put(0,innerList);
        helper(root,0,columnMap);

        for(int i=minColumnIndex;i<=maxColumnIndex;i++)
        {
        	result.add(columnMap.get(i));
        }
        return result;
    }
    private void helper(TreeNode root,int columnIndex, HashMap<Integer,List<Integer>> columnMap)
    {
    	minColumnIndex = Math.min(minColumnIndex,columnIndex);
		maxColumnIndex = Math.max(maxColumnIndex,columnIndex);
		if(root.left!=null&&root.right!=null)
		{
			addToMap(root.left,columnIndex-1,columnMap);
			addToMap(root.right,columnIndex+1,columnMap);
			helper(root.left,columnIndex-1,columnMap);
			helper(root.right,columnIndex+1,columnMap);
		}
    	else if(root.left!=null && root.right==null)
    	{
    		addToMap(root.left,columnIndex-1,columnMap);
    		helper(root.left,columnIndex-1,columnMap);
    	}
    	else if(root.right!=null && root.left==null)
    	{
    		addToMap(root.right,columnIndex+1,columnMap);
    		helper(root.right,columnIndex+1,columnMap);
    	}
    }
    private void addToMap(TreeNode node, int columnIndex, HashMap<Integer,List<Integer>> columnMap)
    {
    	if(columnMap.containsKey(columnIndex))
    	{
    		columnMap.get(columnIndex).add(node.val);
    	}
    	else
    	{
    		List<Integer> innerList = new ArrayList<Integer>();
    		innerList.add(node.val);
    		columnMap.put(columnIndex,innerList);
    	}
    }
}