/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode(int x) { val = x; }
 * }
For example:
Given binary tree [3,9,20,null,null,15,7],
    3
   / \
  9  20
    /  \
   15   7
return its level order traversal as:
[
  [3],
  [9,20],
  [15,7]
]
 */
class Solution {
    public List<List<Integer>> levelOrder(TreeNode root) {
        LinkedList<TreeNode> currentList = new LinkedList<TreeNode>();
        List<Integer> innerList = new ArrayList<Integer>();
        LinkedList<TreeNode> nextList = new LinkedList<TreeNode>();
        List<List<Integer>> result = new ArrayList<List<Integer>>();
        if(root!=null)
        {
        	currentList.add(root);
        }
        
        while(!currentList.isEmpty())
        {
        	TreeNode node = currentList.remove();
        	innerList.add(node.val);
        	
        	if(node.left!=null)
        	{
        		nextList.add(node.left);
        	}
        	if(node.right!=null)
        	{
        		nextList.add(node.right);
        	}
        	if(currentList.isEmpty())
        	{
        		result.add(innerList);
        		innerList = new ArrayList<Integer>();
        		currentList = nextList;
        		nextList = new LinkedList<TreeNode>();
        	}
        }
        return result;
    }
}