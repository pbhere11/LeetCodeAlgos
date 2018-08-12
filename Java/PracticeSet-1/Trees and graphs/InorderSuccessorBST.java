/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode(int x) { val = x; }
 * }
 Input: root = [2,1,3], p = 1

  2
 / \
1   3

Output: 2
 */
class Solution {
    public TreeNode inorderSuccessor(TreeNode root, TreeNode p) {
        TreeNode result = null;
        while(root!=null)
        {
        	if(root.val>p.val)
        	{
        		result = root;
        		root = root.left;
        	}
        	else if(root.val == p.val)
        	{
        		return result;
        	}
        	else
        	{
        		root=root.right;
        	}
        }
        return null;
    }
}