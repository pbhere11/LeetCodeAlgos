/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode(int x) { val = x; }
 * }
 */
class Solution {
    public List<List<Integer>> levelOrder(TreeNode root) {
        LinkedList<TreeNode> currentList = new LinkedList<TreeNode>();
        LinkedList<TreeNode> nextList = new LinkedList<TreeNode>();
        List<List<Integer>> result = new ArrayList<List<Integer>>();
        if(root==null)
        {
        	return result;
        }
        currentList.add(root);
		List<Integer> innerList = new ArrayList<Integer>();
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
        		currentList = nextList;
        		nextList = new LinkedList<TreeNode>();
        		result.add(innerList);
        		innerList = new ArrayList<Integer>();
        	}
        }
        return result;
    }
}