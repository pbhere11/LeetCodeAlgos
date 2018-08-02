/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
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
public class Solution {
	int index =0;
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        return Helper(preorder,inorder,0,inorder.Length-1);
    }
    private TreeNode Helper(int[] preorder, int[] inorder, int start, int end)
    {
    	if(index<preorder.Length && start<=end)
    	{
    		int key = preorder[index];
	    	index++;
	    	int inorderIndex = Search(inorder,start,end,key);
	    	TreeNode node = new TreeNode(key);
	    	node.left = Helper(preorder,inorder,start,inorderIndex-1);
	    	node.right = Helper(preorder,inorder,inorderIndex+1,end);
	    	return node;
    	}
    	else
    	{
    		return null;
    	}
    	
    }
    private int Search(int[] inorder, int start, int end, int target)
    {
    	for(int i=start;i<=end;i++)
    	{
    		if(inorder[i]==target)
    		{
    			return i;
    		}
    	}
    	return -1;
    }
}