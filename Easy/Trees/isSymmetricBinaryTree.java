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
    public boolean isSymmetric(TreeNode root) {
        if(root==null)
        {
        	return true;
        }
        return isSymmetricRecurssive(root.left,root.right);
    }

    private boolean isSymmetricRecurssive(TreeNode leftNode, TreeNode rightNode)
    {
    	if((leftNode == null && rightNode != null) || (leftNode != null && rightNode == null))
    	{
    		return false;
    	}
    	if(leftNode==null && rightNode == null)
    	{
    		return true;
    	}
    	if(leftNode.val != rightNode.val)
    	{
    		return false;
    	}
    	boolean isLeftTreeSymmetric =  isSymmetricRecurssive(leftNode.left,rightNode.right);
    	boolean isRightTreeSymmetric = isSymmetricRecurssive(leftNode.right,rightNode.left);
    	return isLeftTreeSymmetric && isRightTreeSymmetric;
    }

    private boolean isSymmetricIterative(TreeNode leftNode, TreeNode rightNode)
    {
    	return false;
    }
}