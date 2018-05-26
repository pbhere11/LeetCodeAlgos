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
    public TreeNode inorderSuccessor(TreeNode root, TreeNode p) {
        Stack<TreeNode> stck = new Stack<TreeNode>();
        boolean flag = false;
        while(root!=null)
        {
        	stck.push(root);
        	root = root.left;
        }
        while(!stck.isEmpty())
        {
        	TreeNode node = stck.pop();
        	if(flag)
        	{
        		return node;
        	}
        	if(node.val == p.val)
        	{
        		flag=true;
        	}
        	
        	if(node.right!=null)
        	{
        		node = node.right;
        		while(node!=null)
        		{
        			stck.push(node);
        			node = node.left;
        		}
        	}
        }
        return null;
    }
}