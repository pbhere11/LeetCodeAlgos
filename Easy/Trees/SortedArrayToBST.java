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
    public TreeNode sortedArrayToBST(int[] nums) {
    	return sortedArrayToBST(nums, 0, nums.length-1);    
    }

    private TreeNode sortedArrayToBST(int[] nums, int start, int end)
    {
    	if(start==end)
    	{
    		return new TreeNode(nums[start]);
    	}
    	if(start>end)
    	{
    		return null;
    	}
    	int mid = (end + start)/2;
    	TreeNode node = new TreeNode(nums[mid]);
    	node.left = sortedArrayToBST(nums,start,mid-1);
    	node.right = sortedArrayToBST(nums,mid+1,end);
    	return node;
    }
}