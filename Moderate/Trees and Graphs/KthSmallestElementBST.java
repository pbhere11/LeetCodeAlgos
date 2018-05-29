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
    public int kthSmallest(TreeNode root, int k) {
        Stack<TreeNode> stck = new Stack<TreeNode>();
        int count =0;
        while(root!=null)
        {
        	stck.push(root);
        	root=root.left;
        }
        while(!stck.isEmpty())
        {
        	count++;
        	TreeNode node = stck.pop();
        	if(count==k)
        	{
        		return node.val;
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
        return 0;
    }
}