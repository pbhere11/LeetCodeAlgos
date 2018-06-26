/*
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
    public bool IsSymmetric(TreeNode root) {
    	if(root==null)
    	{
    		return true;
    	}
        //return IsSymmetricRecursive(root.left,root.right);
    	return IsSymmetricIterative(root);
    }

    private bool IsSymmetricIterative(TreeNode root)
    {
    	Queue<TreeNode> q = new Queue<TreeNode>();
    	q.Enqueue(root.left);
    	q.Enqueue(root.right);
    	while(q.Count>0)
    	{
    		TreeNode left = q.Dequeue();
    		TreeNode right = q.Dequeue();
    		if(left!=null&&right!=null)
    		{
    			if(left.val==right.val)
    			{
    				q.Enqueue(left.left);
    				q.Enqueue(right.right);
    				q.Enqueue(left.right);
    				q.Enqueue(right.left);
    			}
    			else
    			{
    				return false;
    			}
    		}
    		else if(!(left==null&&right==null))
    		{
    			return false;
    		}
    	}
    	return true;
    }
    private bool IsSymmetricRecursive(TreeNode left,TreeNode right)
    {
    	if(left==null&&right==null)
    	{
    		return true;
    	}
    	if(left!=null&&right!=null&&left.val==right.val)
    	{
    		bool isLeftSymmetric = IsSymmetricRecursive(left.left,right.right);
    		bool isRightSymmetric = IsSymmetricRecursive(left.right,right.left);
    		return isLeftSymmetric&&isRightSymmetric;
    	}
    	else
    	{
    		return false;
    	}
    }
}