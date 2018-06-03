/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode(int x) { val = x; }
 * }
 Example 1:

Input:
    2
   / \
  1   3
Output: true
Example 2:

    5
   / \
  1   4
     / \
    3   6
Output: false
Explanation: The input is: [5,1,4,null,null,3,6]. The root node's value
             is 5 but its right child's value is 4.
 */
class Solution {
    public boolean isValidBST(TreeNode root) {
        return isValidBST(root,Double.NEGATIVE_INFINITY, Double.POSITIVE_INFINITY);
    }
    private boolean isValidBST(TreeNode root, double min, double max)
    {
    	if(root==null)
    	{
    		return true;
    	}
    	if(root.val>min && root.val<max)
    	{
    		boolean isLeftTreeValid = isValidBST(root.left,min,root.val);
    		boolean isRightTreeValid = isValidBST(root.right,root.val,max);
    		return isLeftTreeValid&&isRightTreeValid;
    	}
    	else
    	{
    		return false;
    	}
    }
}