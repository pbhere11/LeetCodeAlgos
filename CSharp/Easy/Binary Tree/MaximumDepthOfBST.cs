/*
Example:

Given binary tree [3,9,20,null,null,15,7],

    3
   / \
  9  20
    /  \
   15   7
return its depth = 3.
*/

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public int MaxDepth(TreeNode root) {
    	if(root==null)
    	{
    		return 0;
    	}
        int leftDepth = MaxDepth(root.left);
        int rightDepth = MaxDepth(root.right);
        if(leftDepth>=rightDepth)
        {
        	return leftDepth+1;
        }
        else
        {
        	return rightDepth+1;
        }
    }
}