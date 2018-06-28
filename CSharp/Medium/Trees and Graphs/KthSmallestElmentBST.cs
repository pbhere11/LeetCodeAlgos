/*
Example 1:

Input: root = [3,1,4,null,2], k = 1
   3
  / \
 1   4
  \
   2
Output: 1
Example 2:

Input: root = [5,3,6,2,4,null,null,1], k = 3
       5
      / \
     3   6
    / \
   2   4
  /
 1
Output: 3
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
    public int KthSmallest(TreeNode root, int k) {
        Stack<TreeNode> stck = new Stack<TreeNode>();
        int count =0;
        while(root!=null)
        {
        	stck.Push(root);
        	root = root.left;
        }
        while(stck.Count!=0)
        {
        	TreeNode node = stck.Pop();
        	count++;
        	if(count==k)
        	{
        		return node.val;
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
        return 0;
    }
}
