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
    public List<Integer> inorderTraversal(TreeNode root) {
        List<Integer> result = new ArrayList<Integer>();
        Stack<TreeNode> stck = new Stack<TreeNode>();
        while(root!=null)
        {
        	stck.push(root);
        	root=root.left;
        }
        while(!stck.isEmpty())
        {
        	TreeNode node = stck.pop();
        	result.add(node.val);
        	if(node.right!=null)
        	{
        		node = node.right;
        		while(node!=null)
        		{
        			stck.push(node);
        			node=node.left;
        		}
        	}
        }
        return result;
    }
}