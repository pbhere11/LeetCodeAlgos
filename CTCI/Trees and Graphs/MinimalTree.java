/*
4.2 Minimal Tree: Given a sorted (increasing order) array with unique integer elements, write an algorithm
to create a binary search tree with minimal height.
Hints: #19, #73, #176
*/

// "static void main" must be defined in a public class.
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode(int x) { val = x; }
 * }
 Given the sorted array: [-10,-3,0,5,9],
       0
     / \
   -3   9
   /   /
 -10  5
 */
class Solution {
    public TreeNode sortedArrayToBST(int[] nums) {
    	if(nums.length ==0)
    	{
    		return null;
    	}
        TreeNode node = sortedArrayToBST(nums,0,nums.length-1);
        return node;
    }

    public TreeNode sortedArrayToBST(int[] nums, int start, int end)
    {
    	if(start>end)
    	{
    		return null;
    	}
    	if(start==end)
    	{
    		TreeNode node = new TreeNode(nums[start]);
    		return node;
    	}
    	else
    	{
    		int mid = (start+end)/2;
    		TreeNode node = new TreeNode(nums[mid]);
    		node.left = sortedArrayToBST(nums,start,mid-1);
    		node.right = sortedArrayToBST(nums,mid+1,end);
    		return node;
    	}
    }
}