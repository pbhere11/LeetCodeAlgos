/*
4.5 Validate BST: Implement a function to check if a binary tree is a binary search tree.
*/

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
    public boolean isValidBST(TreeNode root) {
        return isValidBST(root,Double.NEGATIVE_INFINITY,Double.POSITIVE_INFINITY);
    }

    public boolean isValidBST(TreeNode root,double min, double max)
    {
    	if(root==null)
    	{
    		return true;
    	}
    	if(root.val>min && root.val<max)
    	{
    		boolean isLeftValid = isValidBST(root.left,min,root.val);
    		boolean isRightValid = isValidBST(root.right,root.val,max);
    		return isLeftValid&&isRightValid;
    	}
    	return false;
    }
}