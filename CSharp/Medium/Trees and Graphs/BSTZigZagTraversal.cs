/*
For example:
Given binary tree [3,9,20,null,null,15,7],
    3
   / \
  9  20
    /  \
   15   7
return its zigzag level order traversal as:
[
  [3],
  [20,9],
  [15,7]
]
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
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        bool reverse = false;
        IList<IList<int>> result = new List<IList<int>>();
        if(root==null)
        {
        	return result;
        }
        Stack<TreeNode> currentList = new Stack<TreeNode>();
        Stack<TreeNode> nextList = new Stack<TreeNode>();
        IList<int> innerList = new List<int>();
        currentList.Push(root);
        while(currentList.Count!=0)
        {
        	TreeNode node = currentList.Pop();
        	innerList.Add(node.val);
        	if(!reverse)
        	{
        		if(node.left!=null)
        		{
        			nextList.Push(node.left);
        		}
        		if(node.right!=null)
        		{
        			nextList.Push(node.right);
        		}
        	}
        	else
        	{
        		if(node.right!=null)
        		{
        			nextList.Push(node.right);
        		}
        		if(node.left!=null)
        		{
        			nextList.Push(node.left);
        		}
        	}
        	if(currentList.Count==0)
        	{
        		currentList = nextList;
        		nextList = new Stack<TreeNode>();
        		result.Add(innerList);
        		innerList = new List<int>();
        		reverse = !reverse;
        	}
        }
        return result;
    }
}