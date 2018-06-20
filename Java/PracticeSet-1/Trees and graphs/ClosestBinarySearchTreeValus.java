/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode(int x) { val = x; }
 * }
 Input: root = [4,2,5,1,3], target = 3.714286

    4
   / \
  2   5
 / \
1   3

Output: 4
 */
class Solution {
    public int closestValue(TreeNode root, double target) {
        int result =0;
        if(root==null)
        {
        	return result;
        }
        
        Double diff = Double.POSITIVE_INFINITY;
        while(root!=null)
        {
        	double currentDiff = root.val>target?root.val-target:target-root.val;
        	if(currentDiff<diff)
        	{
        		diff = currentDiff;
        		result = root.val;
        	}
        	if(target<root.val)
        	{
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