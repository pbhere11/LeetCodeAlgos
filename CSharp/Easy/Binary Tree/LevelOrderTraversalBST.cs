/*
For example:
Given binary tree [3,9,20,null,null,15,7],
    3
   / \
  9  20
    /  \
   15   7
return its level order traversal as:
[
  [3],
  [9,20],
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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        IList<IList<int>> result = new List<IList<int>>();
        if(root==null)
        {
        	return result;
        }
        Queue<TreeNode> currentList = new Queue<TreeNode>();
        Queue<TreeNode> nextList = new Queue<TreeNode>();
        IList<int> innerList = new List<int>();
        currentList.Enqueue(root);
        while(currentList.Count>0)
        {
        	TreeNode node = currentList.Dequeue();
        	innerList.Add(node.val);
        	if(node.left!=null)
        	{
        		nextList.Enqueue(node.left);
        	}
        	if(node.right!=null)
        	{
        		nextList.Enqueue(node.right);
        	}
        	if(currentList.Count==0)
        	{
        		currentList = nextList;
        		nextList = new Queue<TreeNode>();
        		result.Add(innerList);
        		innerList = new List<int>();
        	}
        }
        return result;
    }
}