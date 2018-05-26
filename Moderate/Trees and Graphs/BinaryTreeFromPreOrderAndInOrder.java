/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode(int x) { val = x; }
 * }
preorder = [3,9,20,15,7]
inorder = [9,3,15,20,7]
    3
   / \
  9  20
    /  \
   15   7
 */
class Solution {
	public int preOrderIndex =0;
    public TreeNode buildTree(int[] preorder, int[] inorder) {
    	if(preorder.length==0)
    	{
    		return null;
    	}
       return buildTree(preorder,inorder,0,inorder.length-1); 
    }

    private TreeNode buildTree(int[] preorder, int[] inorder, int startIndex, int endIndex)
    {
    	if(startIndex>endIndex)
    	{
    		return null;
    	}
    	TreeNode node = new TreeNode(preorder[preOrderIndex]);
    	preOrderIndex++;
    	int inorderIndex = startIndex;
    	for(int i=startIndex;i<=endIndex;i++)
    	{
    		if(inorder[i]==node.val)
    		{
    			inorderIndex = i;
    			break;
    		}
    	}
    	node.left = buildTree(preorder,inorder,startIndex,inorderIndex-1);
    	node.right = buildTree(preorder,inorder,inorderIndex+1,endIndex);
    	return node;
    }
}