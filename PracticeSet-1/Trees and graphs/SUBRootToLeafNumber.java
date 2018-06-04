/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode(int x) { val = x; }
 * }
 Example:

Input: [1,2,3]
    1
   / \
  2   3
Output: 25
Explanation:
The root-to-leaf path 1->2 represents the number 12.
The root-to-leaf path 1->3 represents the number 13.
Therefore, sum = 12 + 13 = 25.
Example 2:

Input: [4,9,0,5,1]
    4
   / \
  9   0
 / \
5   1
Output: 1026
Explanation:
The root-to-leaf path 4->9->5 represents the number 495.
The root-to-leaf path 4->9->1 represents the number 491.
The root-to-leaf path 4->0 represents the number 40.
Therefore, sum = 495 + 491 + 40 = 1026.
 */
class Solution {
	private int result =0;
    public int sumNumbers(TreeNode root) {
        
        sumNumbers(root,0);
        return result;
    }
    private void sumNumbers(TreeNode root, int parentNumber)
    {
    	if(root!=null)
    	{
    		int num = parentNumber*10+root.val;
    		if(root.left==null && root.right==null)
    		{
    			result = result+num;
    		}
    		else
    		{
    			sumNumbers(root.left,num);
    			sumNumbers(root.right,num);
    		}
    	}
    }
}