/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;

    public Node(){}
    public Node(int _val,Node _left,Node _right) {
        val = _val;
        left = _left;
        right = _right;
}
        4

    2       5

1       3
*/
public class Solution {
    public Node TreeToDoublyList(Node root) {
        if(root==null)
        {
            return null;
        }
        if(root.left==null&&root.right==null)
        {
            return root;
        }
        Node left = TreeToDoublyList(root.left);
        Node right = TreeToDoublyList(root.right);
        
    }
}