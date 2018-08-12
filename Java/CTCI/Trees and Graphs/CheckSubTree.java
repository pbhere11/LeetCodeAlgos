/*
4.10 Check Subtree: Tl and T2 are two very large binary trees, with Tl much bigger than T2. Create an
algorithm to determine if T2 is a subtree of Tl.
A tree T2 is a subtree ofTi if there exists a node n in Ti such that the subtree of n is identical to T2.
That is, if you cut off the tree at node n, the two trees would be identical.
Hints: #4, #7 7, #78, #37, #37
*/

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
    public boolean isSubtree(TreeNode s, TreeNode t) {
        boolean isTreeEqual = isTreeEqual(s,t);
        boolean isLeftTreeSubTree = false;
        boolean isRightTreeSubTree = false;

        if(s!=null)
        {
        	isLeftTreeSubTree = isSubtree(s.left,t);
        	isRightTreeSubTree = isSubtree(s.right,t);
        }
        return isTreeEqual||isLeftTreeSubTree||isRightTreeSubTree;
    }

    public boolean isTreeEqual(TreeNode s, TreeNode t)
    {
    	if(s==null&&t==null)
    	{
    		return true;
    	}
    	if((s==null&&t!=null)||(s!=null&&t==null))
    	{
    		return false;
    	}
    	if(s.val == t.val)
    	{
    		boolean isLeftTreeEqual = isTreeEqual(s.left,t.left);
    		boolean isRightTreeEqual = isTreeEqual(s.right,t.right);
    		return isLeftTreeEqual&&isRightTreeEqual;
    	}
    	else
    	{
    		return false;
    	}
    	
    }
}