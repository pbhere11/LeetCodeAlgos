/*
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
    public bool IsValidBST(TreeNode root) {
    	return isValidBST(root,Double.MinValue,Double.MaxValue) ;  
    }

    private bool isValidBST(TreeNode root, double minValue, double maxValue)
    {
    	if(root==null)
    	{
    		return true;
    	}
    	if(root.val>minValue&&root.val<maxValue)
    	{
    		bool isLeftValid = isValidBST(root.left,minValue,root.val);
    		bool isRightValid = isValidBST(root.right,root.val,maxValue);
    		return isLeftValid&&isRightValid;
    	}
    	else
    	{
    		return false;
    	}
    }
}