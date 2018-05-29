/**
 * Definition for binary tree with next pointer.
 * public class TreeLinkNode {
 *     int val;
 *     TreeLinkNode left, right, next;
 *     TreeLinkNode(int x) { val = x; }
 * }
     1
   /  \
  2    3
 / \  / \
4  5  6  7
 */
public class Solution {
    public void connect(TreeLinkNode root) {
        LinkedList<TreeLinkNode> currentList = new LinkedList<TreeLinkNode>();
        LinkedList<TreeLinkNode> nextList = new LinkedList<TreeLinkNode>();
        TreeLinkNode prevNode = null;
        if(root!=null)
        {
            currentList.add(root);
            while(!currentList.isEmpty())
            {
                TreeLinkNode node = currentList.remove();
                if(prevNode!=null)
                {
                	prevNode.next = node;
                }
                prevNode = node;
                if(node.left!=null)
                {
                	nextList.add(node.left);
                }
                if(node.right!=null)
                {
                	nextList.add(node.right);
                }
                if(currentList.isEmpty())
                {
                	currentList = nextList;
                	nextList = new LinkedList<TreeLinkNode>();
                	prevNode = null;
                }
            }
        }
    }
}