/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode(int x) { val = x; }
 * }
    5
   / \
  1   4
     / \
    3   6
 */
class Solution {
    public boolean isValidBST(TreeNode root) {
        if(root == null)
        {
        	return true;
        }
        return isValidBST(root,Double.NEGATIVE_INFINITY,Double.POSITIVE_INFINITY);
    }
    private boolean isValidBST(TreeNode node, double minVal, double maxVal)
    {
    	if(node==null)
    	{
    		return true;
    	}
    	if(node.val<=minVal || node.val>=maxVal)
    	{
    		return false;
    	}
    	boolean leftTreeIsValid = isValidBST(node.left,minVal,node.val);
    	boolean rightTreeIsValid = isValidBST(node.right,node.val,maxVal);
    	return leftTreeIsValid && rightTreeIsValid;
    }
}