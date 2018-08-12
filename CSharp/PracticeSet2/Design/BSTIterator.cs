/**
 * Definition for binary tree
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public class BSTIterator {
	private Queue<TreeNode> q = new Queue<TreeNode>();
    public BSTIterator(TreeNode root) {
        CreateQueue(root);
    }
    private void CreateQueue(TreeNode root)
    {
    	if(root!=null)
    	{
    		CreateQueue(root.left);
    		q.Enqueue(root);
    		CreateQueue(root.right);
    	}
    }

    /** @return whether we have a next smallest number */
    public bool HasNext() {
        return q.Count>0;
    }

    /** @return the next smallest number */
    public int Next() {
        return q.Dequeue().val;
    }
}

/**
 * Your BSTIterator will be called like this:
 * BSTIterator i = new BSTIterator(root);
 * while (i.HasNext()) v[f()] = i.Next();
 */