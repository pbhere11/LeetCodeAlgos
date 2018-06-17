/*
4.6 Successor: Write an algorithm to find the "next" node (i .e., in-order successor) of a given node in a
binary search tree. You may assume that each node has a link to its parent.
Hints: #79, #91
*/

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode(int x) { val = x; }
 * }

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
class Solution {
    public TreeNode inorderSuccessor(TreeNode root, TreeNode p) {
    	TreeNode result = null;
        while(root!=null)
        {
        	if(p.val<root.val)
        	{
        		result = root;
        		root = root.left;
        	}
        	else
        	{
        		root = root.right;
        	}
        }
        return result;
    }
}