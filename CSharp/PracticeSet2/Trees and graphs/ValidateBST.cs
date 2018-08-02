/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
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
public class Solution {
    public bool IsValidBST(TreeNode root) {
        if(root==null)
        {
        	return true;
        }
        return IsValidBST(root,Double.MinValue,Double.MaxValue);
    }
    private bool IsValidBST(TreeNode root, double min, double max)
    {
    	if(root==null)
    	{
    		return true;
    	}
    	if(root.val>min && root.val<max)
    	{
    		bool left = IsValidBST(root.left,min,root.val);
    		bool right = IsValidBST(root.right,root.val,max);
    		return left&&right;
    	}
    	else
    	{
    		return false;
    	}
    }
}