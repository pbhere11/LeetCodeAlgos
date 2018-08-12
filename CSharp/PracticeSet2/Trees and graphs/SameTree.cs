/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 Input:     1         1
          / \       / \
         2   3     2   3

        [1,2,3],   [1,2,3]

Output: true
Example 2:

Input:     1         1
          /           \
         2             2

        [1,2],     [1,null,2]

Output: false
 */
public class Solution {
    public bool IsSameTree(TreeNode p, TreeNode q) {
        if(p==null&&q==null)
        {
        	return true;
        }
        if(p==null&&q!=null || p!=null&&q==null)
        {
        	return false;
        }
        if(p.val==q.val)
        {
        	bool left = IsSameTree(p.left,q.left);
        	bool right = IsSameTree(p.right,q.right);
        	return left&&right;
        }
        else
        {
        	return false;
        }
    }
}