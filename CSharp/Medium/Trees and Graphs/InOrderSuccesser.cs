/*
Example 1:

Input: root = [2,1,3], p = 1

  2
 / \
1   3

Output: 2
Example 2:

Input: root = [5,3,6,2,4,null,null,1], p = 6

      5
     / \
    3   6
   / \
  2   4
 /   
1

Output: null
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
    public TreeNode InorderSuccessor(TreeNode root, TreeNode p) {
        Stack<TreeNode> stck = new Stack<TreeNode>();
        bool prevFound = false;
        while(root!=null)
        {
        	stck.Push(root);
        	root = root.left;
        }

        while(stck.Count!=0)
        {
        	TreeNode node = stck.Pop();
        	if(prevFound)
        	{
        		return node;
        	}
        	if(!prevFound && node.val == p.val)
        	{
        		prevFound= true;
        	}
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
        return null;
    }
}