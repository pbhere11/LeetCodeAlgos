/*
Example: 

You may serialize the following tree:

    1
   / \
  2   3
     / \
    4   5

as "[1,2,3,null,null,4,5]"
*/
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
    1
   / \
  2   3
     / \
    4   5
 q = 4,5,null,null
sb = 1,2,3,null,null,4,5,null,null,null,null
node = 1
 */
public class Codec {

    // Encodes a tree to a single string.
    public string serialize(TreeNode root) {
        StringBuilder sb = new StringBuilder();
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);
        while(q.Count>0)
        {
        	TreeNode node = q.Dequeue();
        	if(node!=null)
        	{
        		sb.Append(node.val);
        		sb.Append(",");
        		q.Enqueue(node.left);
        		q.Enqueue(node.right);
        	}
        	else
        	{
				sb.Append("null");
        		sb.Append(",");
        	}
        }
        sb.Length--;
        return sb.ToString();
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data) {
    	if(data.Length==0)
    	{
    		return null;
    	}
        string[] nodeStrs = data.Split(',');
        if(nodeStrs.Length==0)
        {
        	if(data.Equals("null"))
        		return null;
        	return new TreeNode(int.Parse(data));
        }
        int index =1;
        Queue<TreeNode> q = new Queue<TreeNode>();
        if(nodeStrs[0].Equals("null"))
        {
        	return null;
        }
        q.Enqueue(new TreeNode(int.Parse(nodeStrs[0])));
        TreeNode head = null;
        while(q.Count>0)
        {
        	int left = index;
        	int right = index+1;
        	index = index+2;
        	TreeNode node = q.Dequeue();
        	if(head==null)
        	{
        		head = node;
        	}
        	if(left<nodeStrs.Length)
        	{
        		if(nodeStrs[left].Equals("null"))
        		{
        			node.left = null;
        		}
        		else
        		{
        			node.left = new TreeNode(int.Parse(nodeStrs[left]));
        			q.Enqueue(node.left);
        		}
        	}
        	if(right<nodeStrs.Length)
        	{
        		if(nodeStrs[right].Equals("null"))
        		{
        			node.right = null;
        		}
        		else
        		{
        			node.right = new TreeNode(int.Parse(nodeStrs[right]));
        			q.Enqueue(node.right);
        		}
        	}
        }
        return head;
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.deserialize(codec.serialize(root));