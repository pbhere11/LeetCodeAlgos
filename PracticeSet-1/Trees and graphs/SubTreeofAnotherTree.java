/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode(int x) { val = x; }
 * }
 Example 1:
Given tree s:

     3
    / \
   4   5
  / \
 1   2
Given tree t:
   4 
  / \
 1   2
Return true, because t has the same structure and node values with a subtree of s.
Example 2:
Given tree s:

     3
    / \
   4   5
  / \
 1   2
    /
   0
Given tree t:
   4
  / \
 1   2
Return false.
 */
class Solution {
    public boolean isSubtree(TreeNode s, TreeNode t) {
        boolean isTreeSubTree = isTreeEqual(s,t);
        boolean isLeftTreeSubTree = false;
        boolean isRighTreeSubTree = false;
        if(s!=null)
        {
        	isLeftTreeSubTree = isSubtree(s.left,t);
			isRighTreeSubTree = isSubtree(s.right,t);
        }
		return isTreeSubTree || isLeftTreeSubTree || isRighTreeSubTree;
    }
    private boolean isTreeEqual(TreeNode s, TreeNode t)
    {
    	if(s==null&&t==null)
        {
        	return true;
        }
        if((s==null&&t!=null)||(s!=null&&t==null))
        {
        	return false;
        }
        if(s.val==t.val)
        {
        	boolean isLeftTreeSubTree = isTreeEqual(s.left,t.left);
        	boolean isRightTreeSubTree = isTreeEqual(s.right,t.right);
        	return isLeftTreeSubTree && isRightTreeSubTree;
        }
        else
        {
        	return false;
        }
    }
}