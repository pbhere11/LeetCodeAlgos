/*
Example:

Input: [1,null,2,3]
   1
    \
     2
    /
   3

Output: [1,3,2]
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
    public IList<int> InorderTraversal(TreeNode root) {
        Stack<TreeNode> stck = new Stack<TreeNode>();
        IList<int> result = new List<int>();
        while(root!=null)
        {
        	stck.Push(root);
        	root = root.left;
        }

        while(stck.Count!=0)
        {
        	TreeNode node = stck.Pop();
        	result.Add(node.val);
        	if(node.right!=null)
        	{
        		node = node.right;
        		while(node!=null)
        		{
        			stck.Push(node);
        			node = node.left;
        		}
        	}
        }
        return result;
    }
}