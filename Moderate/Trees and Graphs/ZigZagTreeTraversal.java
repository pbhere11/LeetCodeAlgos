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
    public List<List<Integer>> zigzagLevelOrder(TreeNode root) {
        boolean flip = true;
        List<List<Integer>> result = new ArrayList<List<Integer>>();
        if(root==null)
        {
            return result;
        }
        Stack<TreeNode> currentList = new Stack<TreeNode>();
        Stack<TreeNode> nextList = new Stack<TreeNode>();
        List<Integer> innerList = new ArrayList<Integer>();
        currentList.push(root);
        while(!currentList.isEmpty())
        {
        	TreeNode node = currentList.pop();
        	innerList.add(node.val);
        	if(flip)
        	{
        		if(node.left!=null)
        			nextList.push(node.left);
        		if(node.right!=null)
        			nextList.push(node.right);
        	}
        	else
        	{
        		if(node.right!=null)
        			nextList.push(node.right);
        		if(node.left!=null)
        			nextList.push(node.left);
        	}
        	if(currentList.isEmpty())
        	{
        		result.add(innerList);
        		innerList = new ArrayList<Integer>();
        		currentList = nextList;
        		nextList = new Stack<TreeNode>();
        		flip=!flip;
        	}
        }
        return result;
    }
}