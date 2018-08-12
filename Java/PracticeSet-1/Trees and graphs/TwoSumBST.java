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
    5
   / \
  3   6
 / \   \
2   4   7

Target = 9

Output: True
Example 2:
Input: 
    5
   / \
  3   6
 / \   \
2   4   7

Target = 28

Output: False
 */
class Solution {
	HashSet<Integer> numsSet = new HashSet<Integer>();
    public boolean findTarget(TreeNode root, int k) {
        return inOrder(root,k);
    }

    private boolean inOrder(TreeNode root, int k)
    {
    	if(root!=null)
    	{
    		if(numsSet.contains(root.val))
    		{
    			return true;
    		}
    		else
    		{
    			numsSet.add(k-root.val);
    			boolean leftContainsTarget = inOrder(root.left,k);
    			boolean rightContainsTarget = inOrder(root.right,k);
    			return leftContainsTarget||rightContainsTarget;
    		}
    	}
    	else
    	{
    		return false;
    	}
    }
}