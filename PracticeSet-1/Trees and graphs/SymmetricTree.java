/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode(int x) { val = x; }
 * }
 For example, this binary tree [1,2,2,3,4,4,3] is symmetric:

    1
   / \
  2   2
 / \ / \
3  4 4  3
But the following [1,2,2,null,3,null,3] is not:
    1
   / \
  2   2
   \   \
   3    3
 */
class Solution {
    public boolean isSymmetric(TreeNode root) {
        if(root ==null)
        {
        	return true;
        }
        return isSymmetric(root.left,root.right);
    }

    private boolean isSymmetric(TreeNode leftNode, TreeNode rightNode)
    {
    	if(leftNode==null && rightNode==null)
    	{
    		return true;
    	}
    	if((leftNode==null && rightNode!=null)||(leftNode!=null && rightNode==null))
    	{
    		return false;
    	}
    	if(leftNode.val==rightNode.val)
    	{
    		boolean isLeftTreeSymmetric = isSymmetric(leftNode.left,rightNode.right);
    		boolean isRightTreeSymmetric = isSymmetric(leftNode.right,rightNode.left);
    		return isLeftTreeSymmetric && isRightTreeSymmetric;
    	}
    	return false;
    }
}