/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode(int x) { val = x; }
 * }
 Input: [3,2,1,6,0,5]
Output: return the tree root node representing the following tree:

      6
    /   \
   3     5
    \    / 
     2  0   
       \
        1
 */
class Solution {
    public TreeNode constructMaximumBinaryTree(int[] nums) {
    	if(nums.length==0)
    	{
    		return null;
    	}
        return constructMaximumBinaryTree(nums,0,nums.length-1);
    }
    private TreeNode constructMaximumBinaryTree(int[] nums, int start, int end)
    {
    	if(start==end)
    	{
    		return new TreeNode(nums[start]);
    	}
    	if(start>=0&&start<nums.length&&end>=0&&end<nums.length&&start<end)
    	{
    		int maxIndex = getMaxIndex(nums,start,end);
	    	TreeNode node = new TreeNode(nums[maxIndex]);
	    	node.left = constructMaximumBinaryTree(nums,start,maxIndex-1);
	    	node.right = constructMaximumBinaryTree(nums,maxIndex+1,end);
	    	return node;
    	}
    	return null;
    }
    private int getMaxIndex(int[] nums, int start, int end)
    {
    	int max = nums[start];
    	int maxIndex =start;
    	for(int i=start+1;i<=end;i++)
    	{
    		if(nums[i]>max)
    		{
    			max = nums[i];
    			maxIndex = i;
    		}
    	}
    	return maxIndex;
    }
}