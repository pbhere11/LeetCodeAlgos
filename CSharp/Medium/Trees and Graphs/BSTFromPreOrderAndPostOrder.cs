/*
For example, given

preorder = [3,9,20,15,7]
inorder = [9,3,15,20,7]
Return the following binary tree:

    3
   / \
  9  20
    /  \
   15   7
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
	private int index =0;
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        return BuildTree(preorder,inorder,0,inorder.Length);
    }

    private TreeNode BuildTree(int[] preorder, int[] inorder, int start, int end)
    {
    	if(index<preorder.Length && start<=end)
    	{
    		TreeNode node = new TreeNode(preorder[index]);
	    	index++;
	    	int preNodeIndex = GetPreNodeIndex(inorder,node.val,start,end);
	    	node.left = BuildTree(preorder,inorder,start,preNodeIndex-1);
	    	node.right = BuildTree(preorder,inorder,preNodeIndex+1,end);
	    	return node;
    	}
    	else
    	{
    		return null;
    	}
    	
    }

    private int GetPreNodeIndex(int[] inorder, int preNodeVal, int start, int end)
    {
    	for(int i=start;i<=end;i++)
    	{
    		if(inorder[i]==preNodeVal)
    		{
    			return i;
    		}
    	}
    	return -1;
    }
}