/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode(int x) { val = x; }
 * }
           1
        /     \
       2        2
     /  \     /  \
    3    4   4    3
   / \  / \ / \  / \
  1  2 3  4 4  3 2  1
 */
class Solution {
    public boolean isSymmetric(TreeNode root) {
        if(root==null)
        {
        	return true;
        }
        //return isSymmetricRecurssive(root.left,root.right);
        return isSymmetricIterative(root);
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

    private boolean isSymmetricIterative(TreeNode root)
    {
        LinkedList<TreeNode> currentList = new LinkedList<TreeNode>();
        LinkedList<TreeNode> nextList = new LinkedList<TreeNode>();
        currentList.add(root);
        boolean reverseFlag = false;
        while(!currentList.isEmpty())
        {
            TreeNode node = currentList.remove();
            if(reverseFlag)
            {
                if(node.right!=null)
                {
                    nextList.add(node.right);
                }
                if(node.left!=null)
                {
                    nextList.add(node.left);
                }
            }
            else
            {
                if(node.left!=null)
                {
                    nextList.add(node.left);
                }
                if(node.right!=null)
                {
                    nextList.add(node.right);
                }
            }
           
            if(currentList.isEmpty())
            {
                currentList = nextList;
                nextList = new LinkedList<TreeNode>();
                reverseFlag = false;
            }
            reverseFlag = !reverseFlag;
        }
    	return false;
    }
}