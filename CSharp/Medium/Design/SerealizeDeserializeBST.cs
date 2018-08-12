
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 You may serialize the following tree:
    1
   / \
  2   3
     / \
    4   5
as "[1,2,3,null,null,4,5]"
 */
public class Codec {

    // Encodes a tree to a single string.
    public string serialize(TreeNode root) {
        if(root==null)
        {
            return "";
        }
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
        string [] strArr = data.Split(',');
        TreeNode root = new TreeNode(int.Parse(strArr[0]));
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);
        int index =1;
        while(q.Count>0)
        {
            TreeNode node = q.Dequeue();
            int left = index;
            int right = index+1;
            index = index+2;
            if(left<strArr.Length)
            {
                if(strArr[left].Equals("null"))
                {
                    node.left = null;
                }
                else
                {
                    TreeNode leftNode = new TreeNode(int.Parse(strArr[left]));
                    node.left = leftNode;
                    q.Enqueue(leftNode);
                }
            }
            if(right<strArr.Length)
            {
                if(strArr[right].Equals("null"))
                {
                    node.right = null;
                }
                else
                {
                    TreeNode rightNode = new TreeNode(int.Parse(strArr[right]));
                    node.right = rightNode;
                    q.Enqueue(rightNode);
                }
            }
        }
        return root;
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.deserialize(codec.serialize(root));
