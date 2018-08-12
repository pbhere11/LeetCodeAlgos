/*
Example:

Given the sorted array: [-10,-3,0,5,9],

One possible answer is: [0,-3,9,-10,null,5], which represents the following height balanced BST:

      0
     / \
   -3   9
   /   /
 -10  5
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
    public TreeNode SortedArrayToBST(int[] nums) {
    	if(nums.Length==0)
    	{
    		return null;
    	}
        return SortedArrayToBST(nums,0,nums.Length-1);
    }

    private TreeNode SortedArrayToBST(int[] nums, int start, int end)
    {
    	if(start==end)
    	{
    		return new TreeNode(nums[start]);
    	}
    	if(start<end)
    	{
    		int mid = (start+end)/2;
	    	TreeNode node = new TreeNode(nums[mid]);
	    	node.left = SortedArrayToBST(nums,start,mid-1);
	    	node.right = SortedArrayToBST(nums,mid+1,end);
	    	return node;
    	}
    	else
    	{
    		return null;
    	}
    	
    }
}