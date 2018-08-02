/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 Example:
Given a binary tree 
          1
         / \
        2   3
       / \     
      4   5  
 */
public class Solution {
	int ans =0;
    public int DiameterOfBinaryTree(TreeNode root) {
        if(root==null)
        {
        	return 0;
        }
        Depth(root);
        return ans-1;
    }
    private int Depth(TreeNode root)
    {
    	if(root==null)
    	{
    		return 0;
    	}
    	int left = Depth(root.left);
    	int right = Depth(root.right);
    	ans = Math.Max(ans,left+right+1);
    	return Math.Max(left,right)+1;
    }
}